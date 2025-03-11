Public Class Form2
    Public Event TimerSet(ByVal totalSeconds As Integer)

    Private Sub btnAplly_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim hours As Integer
        Dim minutes As Integer
        If Integer.TryParse(txtHour.Text, hours) AndAlso Integer.TryParse(txtMinute.Text, minutes) Then
            Dim totalTime As Integer = (hours * 3600) + (minutes * 60)
            RaiseEvent TimerSet(totalTime)
            Me.Close()
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtHour.Text = "0"
        txtMinute.Text = "0"
    End Sub

    Private Sub btnPlusHour_Click(sender As Object, e As EventArgs) Handles btnPlusHour.Click
        Dim hourValue As Integer
        If Integer.TryParse(txtHour.Text, hourValue) Then
            txtHour.Text = (hourValue + 1).ToString()
        Else
            txtHour.Text = "0"
        End If
    End Sub

    Private Sub btnMinHour_Click(sender As Object, e As EventArgs) Handles btnMinHour.Click
        Dim hourValue As Integer
        If Integer.TryParse(txtHour.Text, hourValue) Then
            txtHour.Text = Math.Max(0, hourValue - 1).ToString()
        Else
            txtHour.Text = "0"
        End If
    End Sub

    Private Sub btnPlusMinute_Click(sender As Object, e As EventArgs) Handles btnPlusMinute.Click
        Dim minuteValue As Integer
        If Integer.TryParse(txtMinute.Text, minuteValue) Then
            txtMinute.Text = (minuteValue + 1).ToString()
        Else
            txtMinute.Text = "0"
        End If
    End Sub

    Private Sub btnMinMinute_Click(sender As Object, e As EventArgs) Handles btnMinMinute.Click
        Dim minuteValue As Integer
        If Integer.TryParse(txtMinute.Text, minuteValue) Then
            txtMinute.Text = Math.Max(0, minuteValue - 1).ToString()
        Else
            txtMinute.Text = "0"
        End If
    End Sub
End Class
