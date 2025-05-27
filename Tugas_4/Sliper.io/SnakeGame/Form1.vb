Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim gameForm As New Form2()
        gameForm.Show()        ' Tampilkan Form2 (game)
        Me.Hide()              ' Sembunyikan Form1
    End Sub


End Class
