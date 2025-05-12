Public Class FrmHistogramBalok2
    Private Sub frmHistogramBalok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim binCount As Integer = 16 ' Lebih sedikit agar balok lebar
        Dim histogramR(binCount - 1) As Integer
        Dim histogramG(binCount - 1) As Integer
        Dim histogramB(binCount - 1) As Integer

        Dim rnd As New Random()
        For i As Integer = 0 To binCount - 1
            histogramR(i) = rnd.Next(0, 255)
            histogramG(i) = rnd.Next(0, 255)
            histogramB(i) = rnd.Next(0, 255)
        Next

        Dim bmp As New Bitmap(1000, 600) ' Ukuran gambar lebih besar
        DrawGroupedHistogram(bmp, histogramR, histogramG, histogramB)
        PictureBox1.Image = bmp
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub DrawGroupedHistogram(bmp As Bitmap, red() As Integer, green() As Integer, blue() As Integer)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.LightGray)

            Dim binCount As Integer = red.Length
            Dim groupWidth As Integer = bmp.Width \ binCount
            Dim barWidth As Integer = (groupWidth - 10) \ 3 ' Lebih besar karena bin sedikit
            Dim maxHeight As Integer = bmp.Height - 30

            Dim maxVal As Integer = red.Concat(green).Concat(blue).Max()

            For i As Integer = 0 To binCount - 1
                Dim baseX As Integer = i * groupWidth

                Dim rHeight As Integer = CInt(red(i) * maxHeight / maxVal)
                Dim gHeight As Integer = CInt(green(i) * maxHeight / maxVal)
                Dim bHeight As Integer = CInt(blue(i) * maxHeight / maxVal)

                g.FillRectangle(Brushes.Red, baseX, bmp.Height - rHeight, barWidth, rHeight)
                g.FillRectangle(Brushes.Green, baseX + barWidth, bmp.Height - gHeight, barWidth, gHeight)
                g.FillRectangle(Brushes.Blue, baseX + 2 * barWidth, bmp.Height - bHeight, barWidth, bHeight)
            Next
        End Using
    End Sub



End Class