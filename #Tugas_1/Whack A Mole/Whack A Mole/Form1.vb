Public Class Form1

    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        Me.Hide()
        Dim gameForm As New Form2()
        gameForm.Show()
    End Sub

End Class
