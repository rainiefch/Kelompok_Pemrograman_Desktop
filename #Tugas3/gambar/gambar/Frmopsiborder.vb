Public Class Frmopsiborder
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click


        If Form1.PictureBox1.Image IsNot Nothing Then

            ' Cek apakah user sudah memilih warna
            If warna.SelectedItem Is Nothing Then
                MessageBox.Show("Silakan pilih warna border terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Cek apakah user sudah memilih ketebalan border
            If tebal.SelectedItem Is Nothing Then
                MessageBox.Show("Silakan pilih ketebalan border terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim bmp = New Bitmap(Form1.PictureBox1.Image)
            Dim graphics As Graphics = Graphics.FromImage(bmp)

            ' Tentukan warna border
            Dim borderColor As Color
            Select Case warna.SelectedItem.ToString().ToLower()
                Case "merah"
                    borderColor = Color.Red
                Case "hijau"
                    borderColor = Color.Green
                Case "biru"
                    borderColor = Color.Blue
                Case Else
                    borderColor = Color.Black ' default
            End Select

            ' Tentukan ketebalan border
            Dim borderThickness As Integer
            Select Case tebal.SelectedItem.ToString().ToLower()
                Case "2px"
                    borderThickness = 2
                Case "4px"
                    borderThickness = 4
                Case "6px"
                    borderThickness = 6
                Case "8px"
                    borderThickness = 8
                Case "10px"
                    borderThickness = 10
                Case Else
                    borderThickness = 1 ' default
            End Select

            ' Gambar border
            Dim pen As New Pen(borderColor, borderThickness)
            Dim rect As New Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1)
            graphics.DrawRectangle(pen, rect)

            pen.Dispose()
            graphics.Dispose()

            Form1.PictureBox1.Image = bmp
        Else
            MessageBox.Show("Belum ada image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.Close()
    End Sub

    Private Sub btnBtal_Click(sender As Object, e As EventArgs) Handles btnBtal.Click
        Me.Close()
    End Sub

    Private Sub Frmopsiborder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        warna.Items.Clear()
        warna.Items.Add("Merah")
        warna.Items.Add("Hijau")
        warna.Items.Add("Biru")

        ' Tambahkan opsi ketebalan
        tebal.Items.Clear()
        tebal.Items.Add("2px")
        tebal.Items.Add("4px")
        tebal.Items.Add("6px")
        tebal.Items.Add("8px")
        tebal.Items.Add("10px")

        ' (Opsional) Pilih default
        warna.SelectedIndex = 0
        tebal.SelectedIndex = 0
    End Sub
End Class