<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.blOutputDevice = New System.Windows.Forms.Label()
        Me.lblInputDevice = New System.Windows.Forms.Label()
        Me.tbVolumeApp = New System.Windows.Forms.TrackBar()
        Me.cmbOutputDevice = New System.Windows.Forms.ComboBox()
        Me.cmbInputDevice = New System.Windows.Forms.ComboBox()
        Me.pbVolumeLevel = New System.Windows.Forms.ProgressBar()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.pnlAppsContainer = New System.Windows.Forms.Panel()
        Me.tmrUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.timerCountDown = New System.Windows.Forms.Timer(Me.components)
        Me.picTime = New System.Windows.Forms.PictureBox()
        Me.picVolume = New System.Windows.Forms.PictureBox()
        CType(Me.tbVolumeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.ForeColor = System.Drawing.Color.White
        Me.lblVolume.Location = New System.Drawing.Point(69, 35)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(87, 26)
        Me.lblVolume.TabIndex = 0
        Me.lblVolume.Text = "Volume"
        '
        'blOutputDevice
        '
        Me.blOutputDevice.AutoSize = True
        Me.blOutputDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.blOutputDevice.ForeColor = System.Drawing.Color.White
        Me.blOutputDevice.Location = New System.Drawing.Point(69, 104)
        Me.blOutputDevice.Name = "blOutputDevice"
        Me.blOutputDevice.Size = New System.Drawing.Size(150, 26)
        Me.blOutputDevice.TabIndex = 1
        Me.blOutputDevice.Text = "Output Device"
        '
        'lblInputDevice
        '
        Me.lblInputDevice.AutoSize = True
        Me.lblInputDevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lblInputDevice.ForeColor = System.Drawing.Color.White
        Me.lblInputDevice.Location = New System.Drawing.Point(69, 171)
        Me.lblInputDevice.Name = "lblInputDevice"
        Me.lblInputDevice.Size = New System.Drawing.Size(133, 26)
        Me.lblInputDevice.TabIndex = 2
        Me.lblInputDevice.Text = "Input Device"
        '
        'tbVolumeApp
        '
        Me.tbVolumeApp.Location = New System.Drawing.Point(251, 35)
        Me.tbVolumeApp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbVolumeApp.Maximum = 100
        Me.tbVolumeApp.Name = "tbVolumeApp"
        Me.tbVolumeApp.Size = New System.Drawing.Size(289, 69)
        Me.tbVolumeApp.TabIndex = 5
        Me.tbVolumeApp.TickFrequency = 10
        '
        'cmbOutputDevice
        '
        Me.cmbOutputDevice.FormattingEnabled = True
        Me.cmbOutputDevice.Location = New System.Drawing.Point(231, 101)
        Me.cmbOutputDevice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbOutputDevice.Name = "cmbOutputDevice"
        Me.cmbOutputDevice.Size = New System.Drawing.Size(388, 28)
        Me.cmbOutputDevice.TabIndex = 6
        '
        'cmbInputDevice
        '
        Me.cmbInputDevice.FormattingEnabled = True
        Me.cmbInputDevice.Location = New System.Drawing.Point(231, 169)
        Me.cmbInputDevice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbInputDevice.Name = "cmbInputDevice"
        Me.cmbInputDevice.Size = New System.Drawing.Size(388, 28)
        Me.cmbInputDevice.TabIndex = 7
        '
        'pbVolumeLevel
        '
        Me.pbVolumeLevel.Location = New System.Drawing.Point(73, 244)
        Me.pbVolumeLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbVolumeLevel.Name = "pbVolumeLevel"
        Me.pbVolumeLevel.Size = New System.Drawing.Size(182, 29)
        Me.pbVolumeLevel.TabIndex = 8
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lblTimer.ForeColor = System.Drawing.Color.White
        Me.lblTimer.Location = New System.Drawing.Point(460, 245)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(169, 26)
        Me.lblTimer.TabIndex = 9
        Me.lblTimer.Text = "Timer : 00:00:00"
        '
        'pnlAppsContainer
        '
        Me.pnlAppsContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAppsContainer.Location = New System.Drawing.Point(0, 319)
        Me.pnlAppsContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlAppsContainer.Name = "pnlAppsContainer"
        Me.pnlAppsContainer.Size = New System.Drawing.Size(713, 331)
        Me.pnlAppsContainer.TabIndex = 11
        '
        'tmrUpdate
        '
        Me.tmrUpdate.Interval = 2000
        '
        'timerCountDown
        '
        Me.timerCountDown.Interval = 1000
        '
        'picTime
        '
        Me.picTime.Image = Global.Audio_Mixer.My.Resources.Resources.stopwatch
        Me.picTime.Location = New System.Drawing.Point(416, 228)
        Me.picTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picTime.Name = "picTime"
        Me.picTime.Size = New System.Drawing.Size(37, 45)
        Me.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTime.TabIndex = 10
        Me.picTime.TabStop = False
        '
        'picVolume
        '
        Me.picVolume.Image = Global.Audio_Mixer.My.Resources.Resources.no_volume
        Me.picVolume.Location = New System.Drawing.Point(171, 35)
        Me.picVolume.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVolume.Name = "picVolume"
        Me.picVolume.Size = New System.Drawing.Size(37, 45)
        Me.picVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVolume.TabIndex = 4
        Me.picVolume.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(713, 650)
        Me.Controls.Add(Me.pnlAppsContainer)
        Me.Controls.Add(Me.picTime)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.pbVolumeLevel)
        Me.Controls.Add(Me.cmbInputDevice)
        Me.Controls.Add(Me.cmbOutputDevice)
        Me.Controls.Add(Me.tbVolumeApp)
        Me.Controls.Add(Me.picVolume)
        Me.Controls.Add(Me.lblInputDevice)
        Me.Controls.Add(Me.blOutputDevice)
        Me.Controls.Add(Me.lblVolume)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Audio Mixer"
        CType(Me.tbVolumeApp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVolume As Label
    Friend WithEvents blOutputDevice As Label
    Friend WithEvents lblInputDevice As Label
    Friend WithEvents picVolume As PictureBox
    Friend WithEvents tbVolumeApp As TrackBar
    Friend WithEvents cmbOutputDevice As ComboBox
    Friend WithEvents cmbInputDevice As ComboBox
    Friend WithEvents pbVolumeLevel As ProgressBar
    Friend WithEvents lblTimer As Label
    Friend WithEvents picTime As PictureBox
    Friend WithEvents pnlAppsContainer As Panel
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents timerCountDown As Timer
End Class
