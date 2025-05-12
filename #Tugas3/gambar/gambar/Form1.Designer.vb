<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        PropertiToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        HistogramToolStripMenuItem = New ToolStripMenuItem()
        GryscaleToolStripMenuItem = New ToolStripMenuItem()
        CerahkanToolStripMenuItem = New ToolStripMenuItem()
        GelapkanToolStripMenuItem = New ToolStripMenuItem()
        TambahKontrasToolStripMenuItem = New ToolStripMenuItem()
        KuranginKontrasToolStripMenuItem = New ToolStripMenuItem()
        RisetToolStripMenuItem = New ToolStripMenuItem()
        TampilakanHistrogramToolStripMenuItem = New ToolStripMenuItem()
        EfekToolStripMenuItem = New ToolStripMenuItem()
        TajamkanToolStripMenuItem = New ToolStripMenuItem()
        KaburkanToolStripMenuItem = New ToolStripMenuItem()
        Putar90DerajatToolStripMenuItem = New ToolStripMenuItem()
        FlipHorizontalToolStripMenuItem = New ToolStripMenuItem()
        FlipVertikalToolStripMenuItem = New ToolStripMenuItem()
        TajamkanRinganToolStripMenuItem = New ToolStripMenuItem()
        GaussianBlurToolStripMenuItem = New ToolStripMenuItem()
        TugasToolStripMenuItem = New ToolStripMenuItem()
        BorderToolStripMenuItem = New ToolStripMenuItem()
        WatermarkToolStripMenuItem = New ToolStripMenuItem()
        InversiWarnaToolStripMenuItem = New ToolStripMenuItem()
        RonaMerahToolStripMenuItem = New ToolStripMenuItem()
        RonaHijauToolStripMenuItem = New ToolStripMenuItem()
        RonaBToolStripMenuItem = New ToolStripMenuItem()
        RonaSpeisalToolStripMenuItem = New ToolStripMenuItem()
        HistogramBalokToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        trackBarRed = New TrackBar()
        trackBarGreen = New TrackBar()
        trackBarBlue = New TrackBar()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(trackBarRed, ComponentModel.ISupportInitialize).BeginInit()
        CType(trackBarGreen, ComponentModel.ISupportInitialize).BeginInit()
        CType(trackBarBlue, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HistogramToolStripMenuItem, EfekToolStripMenuItem, TugasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem, PropertiToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(178, 34)
        BukaToolStripMenuItem.Text = "buka"
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(178, 34)
        SimpanToolStripMenuItem.Text = "simpan"
        ' 
        ' PropertiToolStripMenuItem
        ' 
        PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        PropertiToolStripMenuItem.Size = New Size(178, 34)
        PropertiToolStripMenuItem.Text = "properti"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(178, 34)
        KeluarToolStripMenuItem.Text = "keluar"
        ' 
        ' HistogramToolStripMenuItem
        ' 
        HistogramToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GryscaleToolStripMenuItem, CerahkanToolStripMenuItem, GelapkanToolStripMenuItem, TambahKontrasToolStripMenuItem, KuranginKontrasToolStripMenuItem, RisetToolStripMenuItem, TampilakanHistrogramToolStripMenuItem})
        HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        HistogramToolStripMenuItem.Size = New Size(112, 29)
        HistogramToolStripMenuItem.Text = "Histogram"
        ' 
        ' GryscaleToolStripMenuItem
        ' 
        GryscaleToolStripMenuItem.Name = "GryscaleToolStripMenuItem"
        GryscaleToolStripMenuItem.Size = New Size(293, 34)
        GryscaleToolStripMenuItem.Text = "gryscale"
        ' 
        ' CerahkanToolStripMenuItem
        ' 
        CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        CerahkanToolStripMenuItem.Size = New Size(293, 34)
        CerahkanToolStripMenuItem.Text = "cerahkan"
        ' 
        ' GelapkanToolStripMenuItem
        ' 
        GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        GelapkanToolStripMenuItem.Size = New Size(293, 34)
        GelapkanToolStripMenuItem.Text = "gelapkan"
        ' 
        ' TambahKontrasToolStripMenuItem
        ' 
        TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        TambahKontrasToolStripMenuItem.Size = New Size(293, 34)
        TambahKontrasToolStripMenuItem.Text = "tambah kontras"
        ' 
        ' KuranginKontrasToolStripMenuItem
        ' 
        KuranginKontrasToolStripMenuItem.Name = "KuranginKontrasToolStripMenuItem"
        KuranginKontrasToolStripMenuItem.Size = New Size(293, 34)
        KuranginKontrasToolStripMenuItem.Text = "kurangin kontras"
        ' 
        ' RisetToolStripMenuItem
        ' 
        RisetToolStripMenuItem.Name = "RisetToolStripMenuItem"
        RisetToolStripMenuItem.Size = New Size(293, 34)
        RisetToolStripMenuItem.Text = "riset"
        ' 
        ' TampilakanHistrogramToolStripMenuItem
        ' 
        TampilakanHistrogramToolStripMenuItem.Name = "TampilakanHistrogramToolStripMenuItem"
        TampilakanHistrogramToolStripMenuItem.Size = New Size(293, 34)
        TampilakanHistrogramToolStripMenuItem.Text = "tampilakan histrogram"
        ' 
        ' EfekToolStripMenuItem
        ' 
        EfekToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TajamkanToolStripMenuItem, KaburkanToolStripMenuItem, Putar90DerajatToolStripMenuItem, FlipHorizontalToolStripMenuItem, FlipVertikalToolStripMenuItem, TajamkanRinganToolStripMenuItem, GaussianBlurToolStripMenuItem})
        EfekToolStripMenuItem.Name = "EfekToolStripMenuItem"
        EfekToolStripMenuItem.Size = New Size(61, 29)
        EfekToolStripMenuItem.Text = "Efek"
        ' 
        ' TajamkanToolStripMenuItem
        ' 
        TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        TajamkanToolStripMenuItem.Size = New Size(241, 34)
        TajamkanToolStripMenuItem.Text = "tajamkan"
        ' 
        ' KaburkanToolStripMenuItem
        ' 
        KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        KaburkanToolStripMenuItem.Size = New Size(241, 34)
        KaburkanToolStripMenuItem.Text = "kaburkan"
        ' 
        ' Putar90DerajatToolStripMenuItem
        ' 
        Putar90DerajatToolStripMenuItem.Name = "Putar90DerajatToolStripMenuItem"
        Putar90DerajatToolStripMenuItem.Size = New Size(241, 34)
        Putar90DerajatToolStripMenuItem.Text = "putar 90 derajat"
        ' 
        ' FlipHorizontalToolStripMenuItem
        ' 
        FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        FlipHorizontalToolStripMenuItem.Size = New Size(241, 34)
        FlipHorizontalToolStripMenuItem.Text = "flip horizontal"
        ' 
        ' FlipVertikalToolStripMenuItem
        ' 
        FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        FlipVertikalToolStripMenuItem.Size = New Size(241, 34)
        FlipVertikalToolStripMenuItem.Text = "flip vertikal"
        ' 
        ' TajamkanRinganToolStripMenuItem
        ' 
        TajamkanRinganToolStripMenuItem.Name = "TajamkanRinganToolStripMenuItem"
        TajamkanRinganToolStripMenuItem.Size = New Size(241, 34)
        TajamkanRinganToolStripMenuItem.Text = "tajamkan ringan"
        ' 
        ' GaussianBlurToolStripMenuItem
        ' 
        GaussianBlurToolStripMenuItem.Name = "GaussianBlurToolStripMenuItem"
        GaussianBlurToolStripMenuItem.Size = New Size(241, 34)
        GaussianBlurToolStripMenuItem.Text = "gaussian blur"
        ' 
        ' TugasToolStripMenuItem
        ' 
        TugasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BorderToolStripMenuItem, WatermarkToolStripMenuItem, InversiWarnaToolStripMenuItem, RonaMerahToolStripMenuItem, RonaHijauToolStripMenuItem, RonaBToolStripMenuItem, RonaSpeisalToolStripMenuItem, HistogramBalokToolStripMenuItem})
        TugasToolStripMenuItem.Name = "TugasToolStripMenuItem"
        TugasToolStripMenuItem.Size = New Size(90, 29)
        TugasToolStripMenuItem.Text = "Tugas 3"
        ' 
        ' BorderToolStripMenuItem
        ' 
        BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        BorderToolStripMenuItem.Size = New Size(246, 34)
        BorderToolStripMenuItem.Text = "Border"
        ' 
        ' WatermarkToolStripMenuItem
        ' 
        WatermarkToolStripMenuItem.Name = "WatermarkToolStripMenuItem"
        WatermarkToolStripMenuItem.Size = New Size(246, 34)
        WatermarkToolStripMenuItem.Text = "Watermark"
        ' 
        ' InversiWarnaToolStripMenuItem
        ' 
        InversiWarnaToolStripMenuItem.Name = "InversiWarnaToolStripMenuItem"
        InversiWarnaToolStripMenuItem.Size = New Size(246, 34)
        InversiWarnaToolStripMenuItem.Text = "inversi Warna"
        ' 
        ' RonaMerahToolStripMenuItem
        ' 
        RonaMerahToolStripMenuItem.Name = "RonaMerahToolStripMenuItem"
        RonaMerahToolStripMenuItem.Size = New Size(246, 34)
        RonaMerahToolStripMenuItem.Text = "Rona Merah"
        ' 
        ' RonaHijauToolStripMenuItem
        ' 
        RonaHijauToolStripMenuItem.Name = "RonaHijauToolStripMenuItem"
        RonaHijauToolStripMenuItem.Size = New Size(246, 34)
        RonaHijauToolStripMenuItem.Text = "Rona Hijau"
        ' 
        ' RonaBToolStripMenuItem
        ' 
        RonaBToolStripMenuItem.Name = "RonaBToolStripMenuItem"
        RonaBToolStripMenuItem.Size = New Size(246, 34)
        RonaBToolStripMenuItem.Text = "Rona Biru"
        ' 
        ' RonaSpeisalToolStripMenuItem
        ' 
        RonaSpeisalToolStripMenuItem.Name = "RonaSpeisalToolStripMenuItem"
        RonaSpeisalToolStripMenuItem.Size = New Size(246, 34)
        RonaSpeisalToolStripMenuItem.Text = "Rona speisal"
        ' 
        ' HistogramBalokToolStripMenuItem
        ' 
        HistogramBalokToolStripMenuItem.Name = "HistogramBalokToolStripMenuItem"
        HistogramBalokToolStripMenuItem.Size = New Size(246, 34)
        HistogramBalokToolStripMenuItem.Text = "Histogram Balok"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 417)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' trackBarRed
        ' 
        trackBarRed.Location = New Point(23, 312)
        trackBarRed.Name = "trackBarRed"
        trackBarRed.Size = New Size(239, 69)
        trackBarRed.TabIndex = 2
        ' 
        ' trackBarGreen
        ' 
        trackBarGreen.Location = New Point(286, 312)
        trackBarGreen.Name = "trackBarGreen"
        trackBarGreen.Size = New Size(239, 69)
        trackBarGreen.TabIndex = 3
        ' 
        ' trackBarBlue
        ' 
        trackBarBlue.Location = New Point(549, 312)
        trackBarBlue.Name = "trackBarBlue"
        trackBarBlue.Size = New Size(239, 69)
        trackBarBlue.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(109, 382)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 25)
        Label1.TabIndex = 5
        Label1.Text = "Red"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(378, 382)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 6
        Label2.Text = "Green"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(640, 384)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 25)
        Label3.TabIndex = 7
        Label3.Text = "Blue"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(trackBarBlue)
        Controls.Add(trackBarGreen)
        Controls.Add(trackBarRed)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(trackBarRed, ComponentModel.ISupportInitialize).EndInit()
        CType(trackBarGreen, ComponentModel.ISupportInitialize).EndInit()
        CType(trackBarBlue, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EfekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GryscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KuranginKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RisetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilakanHistrogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Putar90DerajatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanRinganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GaussianBlurToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WatermarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InversiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaMerahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaHijauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaSpeisalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramBalokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents trackBarRed As TrackBar
    Friend WithEvents trackBarGreen As TrackBar
    Friend WithEvents trackBarBlue As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
