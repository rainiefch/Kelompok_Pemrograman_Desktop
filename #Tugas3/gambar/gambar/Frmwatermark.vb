Public Class Frmwatermark

    ' Property ini digunakan untuk mengambil atau mengatur teks dari TextBox
    Public Property WatermarkText As String
        Get
            Return txtWatermark.Text
        End Get
        Set(value As String)
            txtWatermark.Text = value
        End Set
    End Property

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not String.IsNullOrWhiteSpace(txtWatermark.Text) Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Silakan masukkan kata watermark.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
