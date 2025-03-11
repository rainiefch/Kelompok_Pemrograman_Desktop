Imports NAudio
Imports NAudio.CoreAudioApi
Imports NAudio.Wave
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Diagnostics
Imports NAudio.CoreAudioApi.Interfaces


Public Class Form1
    Private enumerator As New MMDeviceEnumerator()
    Private outputDevice As MMDevice
    Private inputDevice As MMDevice
    Private Shadows capture As WasapiLoopbackCapture
    Private waveProvider As BufferedWaveProvider
    Private WithEvents timerCD As New Timer()
    Private totalTime As Integer
    Private currentVolume As Integer = 100 ' Volume awal 100%
    Private audioDevice As MMDeviceEnumerator
    Private appVolumes As New Dictionary(Of String, SimpleAudioVolume)()
    Private countdownHours As Integer
    Private countdownMinutes As Integer
    Private countdownSeconds As Integer
    Private appTrackBars As New Dictionary(Of String, TrackBar)()
    Private appLabels As New Dictionary(Of String, Label)



    Private WithEvents Timer1 As New Timer()



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(55, 63, 81)
        LoadAudioDevices()

        outputDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        capture = New WasapiLoopbackCapture()
        waveProvider = New BufferedWaveProvider(capture.WaveFormat)
        AddHandler capture.DataAvailable, AddressOf CaptureData
        capture.StartRecording()

        timerCountDown.Interval = 1000 ' 1 detik

        LoadAudioApplications()
    End Sub

    Private Sub LoadAudioDevices()
        cmbOutputDevice.Items.Clear()
        cmbInputDevice.Items.Clear()

        Dim outputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)
        Dim inputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active)

        For Each device In outputDevices
            cmbOutputDevice.Items.Add(device.FriendlyName)
        Next
        For Each device In inputDevices
            cmbInputDevice.Items.Add(device.FriendlyName)
        Next

        If cmbOutputDevice.Items.Count > 0 Then cmbOutputDevice.SelectedIndex = 0
        If cmbInputDevice.Items.Count > 0 Then cmbInputDevice.SelectedIndex = 0
    End Sub

    Private Sub SetVolume(ByVal volumeLevel As Integer)
        Dim device As MMDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia)
        device.AudioEndpointVolume.MasterVolumeLevelScalar = volumeLevel / 100.0F
    End Sub

    Private Sub TbVolumeApp_Scroll(sender As Object, e As EventArgs) Handles tbVolumeApp.Scroll
        SetVolume(tbVolumeApp.Value)
        lblVolume.Text = tbVolumeApp.Value.ToString() & "%"

        If tbVolumeApp.Value = 0 Then
            picVolume.Image = My.Resources.no_volume
        ElseIf tbVolumeApp.Value > 0 AndAlso tbVolumeApp.Value <= 60 Then
            picVolume.Image = My.Resources.low_volume
        Else
            picVolume.Image = My.Resources.medium_volume
        End If
    End Sub

    Private Sub CaptureData(sender As Object, e As WaveInEventArgs)
        Dim buffer(e.BytesRecorded - 1) As Byte
        Array.Copy(e.Buffer, buffer, e.BytesRecorded)

        Dim sampleBuffer(buffer.Length \ 2 - 1) As Single
        For i As Integer = 0 To buffer.Length - 2 Step 2
            Dim sample As Short = BitConverter.ToInt16(buffer, i)
            sampleBuffer(i \ 2) = sample / 32768.0F
        Next

        Dim level As Single = 0
        For Each sample As Single In sampleBuffer
            level += Math.Abs(sample)
        Next
        level /= sampleBuffer.Length

        Me.Invoke(Sub()
                      Dim scaledValue As Double = level * pbVolumeLevel.Maximum

                      ' Pastikan scaledValue berada dalam rentang yang aman untuk CInt
                      If Double.IsNaN(scaledValue) OrElse Double.IsInfinity(scaledValue) Then
                          scaledValue = 0 ' Hindari nilai tidak valid
                      ElseIf scaledValue > Integer.MaxValue Then
                          scaledValue = Integer.MaxValue ' Hindari overflow
                      ElseIf scaledValue < Integer.MinValue Then
                          scaledValue = Integer.MinValue ' Hindari underflow
                      End If

                      pbVolumeLevel.Value = Math.Min(pbVolumeLevel.Maximum, CInt(Math.Max(0, scaledValue)))
                  End Sub)


    End Sub

    Private Sub picTime_Click(sender As Object, e As EventArgs) Handles picTime.Click
        Dim timerForm As New Form2()
        AddHandler timerForm.TimerSet, AddressOf StartCountdownTimer
        timerForm.Show()
    End Sub

    Private Sub StartCountdownTimer(ByVal totalSeconds As Integer)
        totalTime = totalSeconds
        currentVolume = tbVolumeApp.Value
        timerCountDown.Start()
    End Sub

    Private Sub timerCountDown_Tick(sender As Object, e As EventArgs) Handles timerCountDown.Tick
        If totalTime > 0 Then
            totalTime -= 1
            Dim volumeStep As Integer = CInt(100 / (totalTime + 1))
            currentVolume = Math.Max(0, currentVolume - volumeStep)
            tbVolumeApp.Value = currentVolume
            lblTimer.Text = $"Timer: {totalTime \ 60:D2}:{totalTime Mod 60:D2}"
        Else
            timerCD.Stop()
            MessageBox.Show("Waktu habis, audio dimatikan!", "Timer Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbVolumeApp.Value = 0
        End If
    End Sub



    ''' <summary>
    ''' Detect active audio applications and update UI
    ''' </summary>
    Private Sub LoadAudioApplications()
            Try
                Dim devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active)
                Dim existingApps As New HashSet(Of String)(appTrackBars.Keys)
                Dim currentY As Integer = 10 ' Start position for new UI elements

                For Each device As MMDevice In devices
                    Dim sessions = device.AudioSessionManager.Sessions
                    For i As Integer = 0 To sessions.Count - 1
                        Dim session As AudioSessionControl = sessions(i)
                        Try
                            Dim process As Process = Process.GetProcessById(session.GetProcessID)
                            Dim appName As String = process.ProcessName

                            If Not appVolumes.ContainsKey(appName) Then
                                ' Add new app
                                If session.SimpleAudioVolume IsNot Nothing Then
                                    appVolumes(appName) = session.SimpleAudioVolume

                                    ' Create Label for App Name
                                    Dim lblApp As New Label()
                                    lblApp.Text = appName
                                    lblApp.AutoSize = True
                                    lblApp.Location = New Point(10, currentY + 10)
                                    lblApp.ForeColor = Color.White
                                    pnlAppsContainer.Controls.Add(lblApp)
                                    appLabels(appName) = lblApp

                                    ' Create TrackBar for Volume Control
                                    Dim tb As New TrackBar()
                                    tb.Minimum = 0
                                    tb.Maximum = 100
                                    tb.Value = CInt(session.SimpleAudioVolume.Volume * 100)
                                    tb.Tag = appName
                                    tb.Width = pnlAppsContainer.Width - 120
                                    tb.Location = New Point(100, currentY)
                                    AddHandler tb.Scroll, AddressOf TrackBar_Scroll
                                    pnlAppsContainer.Controls.Add(tb)
                                    appTrackBars(appName) = tb

                                    ' Move down for next app
                                    currentY += 50
                                End If
                            Else
                                ' Keep track of existing apps
                                existingApps.Remove(appName)
                            End If
                        Catch ex As Exception
                            Debug.WriteLine($"Error accessing process: {ex.Message}")
                        End Try
                    Next
                Next

                ' Remove inactive apps
                For Each appName In existingApps
                    If appTrackBars.ContainsKey(appName) Then
                        pnlAppsContainer.Controls.Remove(appTrackBars(appName))
                        appTrackBars.Remove(appName)
                        appVolumes.Remove(appName)
                        pnlAppsContainer.Controls.Remove(appLabels(appName))
                        appLabels.Remove(appName)
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Error loading audio applications: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Adjusts app volume when TrackBar is moved
        ''' </summary>
        Private Sub TrackBar_Scroll(sender As Object, e As EventArgs)
            Dim tb As TrackBar = CType(sender, TrackBar)
            Dim appName As String = tb.Tag.ToString()
            If appVolumes.ContainsKey(appName) Then
                appVolumes(appName).Volume = tb.Value / 100.0F
            End If
        End Sub

    ''' <summary>
    ''' Refreshes the list every 2 seconds
    ''' </summary>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        LoadAudioApplications()
    End Sub




End Class
