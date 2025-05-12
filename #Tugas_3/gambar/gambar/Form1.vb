Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms

Public Class Form1

    Dim namafile As String
    Dim originalImage As Bitmap
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub



    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Simpan path untuk referensi jika diperlukan
            namafile = openFileDialog1.FileName

            ' Simpan gambar asli untuk digunakan saat trackbar digeser
            originalImage = New Bitmap(namafile)
            PictureBox1.Image = originalImage

            ' Reset nilai trackbar
            trackBarRed.Value = 0
            trackBarGreen.Value = 0
            trackBarBlue.Value = 0
        End If



    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files(*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If

    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)

    End Sub

    Private Sub GryscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GryscaleToolStripMenuItem.Click
        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next
        'Dim img As Image
        'img = CType(bmp, Image)
        'PictureBox1.Image = img
        PictureBox1.Image = bmp

    End Sub

    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp

    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KuranginKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KuranginKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RisetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RisetToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(namafile)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TampilakanHistrogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilakanHistrogramToolStripMenuItem.Click
        FrmHistogram.ShowDialog()
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Putar90DerajatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Putar90DerajatToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Image = bmp

    End Sub

    Private Sub FlipVertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub




    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click
        Dim frm As New Frmwatermark()

        If frm.ShowDialog() = DialogResult.OK Then
            Dim watermarkText As String = frm.WatermarkText

            If Not String.IsNullOrEmpty(watermarkText) And PictureBox1.Image IsNot Nothing Then
                Dim watermarkFont As New Font("Arial", 24, FontStyle.Bold)
                Dim watermarkBrush As New SolidBrush(Color.FromArgb(128, Color.White))

                Dim bitmap As New Bitmap(PictureBox1.Image)
                Dim graphics As Graphics = Graphics.FromImage(bitmap)
                graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                Dim textSize As SizeF = graphics.MeasureString(watermarkText, watermarkFont)
                Dim textPerRow As Integer = CInt(Math.Floor(PictureBox1.Width / textSize.Width))
                Dim numRows As Integer = CInt(Math.Floor(PictureBox1.Height / textSize.Height))

                For row As Integer = 0 To numRows - 1
                    For col As Integer = 0 To textPerRow - 1
                        Dim x As Single = col * textSize.Width
                        Dim y As Single = row * textSize.Height
                        graphics.DrawString(watermarkText, watermarkFont, watermarkBrush, x, y)
                    Next
                Next

                graphics.Dispose()
                PictureBox1.Image = bitmap
            End If
        End If
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        Frmopsiborder.ShowDialog()
    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To bmp.Height - 1
                For kol As Integer = 0 To bmp.Width - 1
                    Dim pixelColor As Color = bmp.GetPixel(kol, bar)

                    Dim invertedRed As Byte = CType(255 - pixelColor.R, Byte)
                    Dim invertedGreen As Byte = CType(255 - pixelColor.G, Byte)
                    Dim invertedBlue As Byte = CType(255 - pixelColor.B, Byte)

                    bmp.SetPixel(kol, bar, Color.FromArgb(invertedRed, invertedGreen, invertedBlue))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("Belum ada image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To bmp.Height - 1
                For kol As Integer = 0 To bmp.Width - 1
                    Dim pixelColor As Color = bmp.GetPixel(kol, bar)

                    Dim redTintFactor As Integer = 150
                    Dim newRed As Integer = pixelColor.R + redTintFactor
                    If newRed > 255 Then
                        newRed = 255
                    End If

                    Dim Green As Integer = pixelColor.G
                    Dim Blue As Integer = pixelColor.B

                    bmp.SetPixel(kol, bar, Color.FromArgb(newRed, Green, Blue))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("Belum ada image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To bmp.Height - 1
                For kol As Integer = 0 To bmp.Width - 1
                    Dim pixelColor As Color = bmp.GetPixel(kol, bar)

                    Dim blueTintFactor As Integer = 150
                    Dim newBlue As Integer = pixelColor.B + blueTintFactor
                    If newBlue > 255 Then
                        newBlue = 255
                    End If

                    Dim Red As Integer = pixelColor.R
                    Dim Green As Integer = pixelColor.G

                    bmp.SetPixel(kol, bar, Color.FromArgb(Red, Green, newBlue))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("Belum ada image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To bmp.Height - 1
                For kol As Integer = 0 To bmp.Width - 1
                    Dim pixelColor As Color = bmp.GetPixel(kol, bar)

                    Dim greenTintFactor As Integer = 150
                    Dim newGreen As Integer = pixelColor.G + greenTintFactor
                    If newGreen > 255 Then
                        newGreen = 255
                    End If

                    Dim Red As Integer = pixelColor.R
                    Dim Blue As Integer = pixelColor.B

                    bmp.SetPixel(kol, bar, Color.FromArgb(Red, newGreen, Blue))
                Next
            Next
            PictureBox1.Image = bmp
        Else
            MessageBox.Show("Belum ada image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RonaSpeisalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpeisalToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To bmp.Height - 1
                For kol As Integer = 0 To bmp.Width - 1
                    Dim pixelColor As Color = bmp.GetPixel(kol, bar)

                    Dim redTintFactor As Integer = 150
                    Dim blueTintFactor As Integer = 150

                    Dim newRed As Integer = pixelColor.R + redTintFactor
                    Dim newBlue As Integer = pixelColor.B + blueTintFactor
                    If newRed > 255 Then newRed = 255
                    If newBlue > 255 Then newBlue = 255

                    Dim Green As Integer = pixelColor.G

                    bmp.SetPixel(kol, bar, Color.FromArgb(newRed, Green, newBlue))
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub HistogramBalokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramBalokToolStripMenuItem.Click
        If PictureBox1.Image IsNot Nothing Then
            FrmHistogramBalok2.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur trackbar
        For Each tb As System.Windows.Forms.TrackBar In {trackBarRed, trackBarBlue, trackBarGreen}

            tb.Minimum = 0
            tb.Maximum = 200
            tb.Value = 100
        Next
    End Sub





    Private Sub TrackBar_Scroll(sender As Object, e As EventArgs) Handles trackBarRed.Scroll, trackBarGreen.Scroll, trackBarBlue.Scroll
        If originalImage Is Nothing Then Exit Sub

        ' Membuat salinan gambar untuk diproses
        Dim bmp As New Bitmap(originalImage)

        ' Mengubah nilai RGB berdasarkan trackbar
        Dim rOffset As Integer = trackBarRed.Value
        Dim gOffset As Integer = trackBarGreen.Value
        Dim bOffset As Integer = trackBarBlue.Value

        ' Menggunakan LockBits untuk manipulasi piksel secara lebih efisien
        Dim rect As New Rectangle(0, 0, bmp.Width, bmp.Height)
        Dim bmpData As BitmapData = bmp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)

        Dim ptr As IntPtr = bmpData.Scan0
        Dim bytes As Integer = Math.Abs(bmpData.Stride) * bmp.Height
        Dim rgbValues(bytes - 1) As Byte
        Marshal.Copy(ptr, rgbValues, 0, bytes)

        For i As Integer = 0 To rgbValues.Length - 1 Step 4
            ' urutan byte: Blue, Green, Red, Alpha
            rgbValues(i) = CByte(Math.Min(255, Math.Max(0, rgbValues(i) + bOffset)))       ' Blue
            rgbValues(i + 1) = CByte(Math.Min(255, Math.Max(0, rgbValues(i + 1) + gOffset))) ' Green
            rgbValues(i + 2) = CByte(Math.Min(255, Math.Max(0, rgbValues(i + 2) + rOffset))) ' Red
            ' Alpha tidak diubah: rgbValues(i + 3)
        Next

        Marshal.Copy(rgbValues, 0, ptr, bytes)
        bmp.UnlockBits(bmpData)

        ' Menampilkan gambar yang sudah dimodifikasi
        PictureBox1.Image = bmp

    End Sub


    Private Function AdjustRGB(src As Bitmap, rFactor As Single, gFactor As Single, bFactor As Single) As Bitmap
        Dim newBmp As New Bitmap(src.Width, src.Height, PixelFormat.Format24bppRgb)
        Dim rect As Rectangle = New Rectangle(0, 0, src.Width, src.Height)

        Dim srcData As BitmapData = src.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb)
        Dim dstData As BitmapData = newBmp.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb)

        Dim bytes As Integer = Math.Abs(srcData.Stride) * src.Height
        Dim rgbValues(bytes - 1) As Byte

        Marshal.Copy(srcData.Scan0, rgbValues, 0, bytes)

        For i As Integer = 0 To rgbValues.Length - 3 Step 3
            Dim b As Integer = CInt(rgbValues(i) * bFactor)
            Dim g As Integer = CInt(rgbValues(i + 1) * gFactor)
            Dim r As Integer = CInt(rgbValues(i + 2) * rFactor)

            rgbValues(i) = CByte(Math.Min(255, b))
            rgbValues(i + 1) = CByte(Math.Min(255, g))
            rgbValues(i + 2) = CByte(Math.Min(255, r))
        Next

        Marshal.Copy(rgbValues, 0, dstData.Scan0, bytes)
        src.UnlockBits(srcData)
        newBmp.UnlockBits(dstData)

        Return newBmp
    End Function




End Class
