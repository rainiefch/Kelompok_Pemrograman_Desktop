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
        pbPlay = New PictureBox()
        CType(pbPlay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbPlay
        ' 
        pbPlay.BackColor = Color.Transparent
        pbPlay.BackgroundImageLayout = ImageLayout.Stretch
        pbPlay.Cursor = Cursors.Hand
        pbPlay.Image = My.Resources.Resources.Play
        pbPlay.Location = New Point(252, 480)
        pbPlay.Name = "pbPlay"
        pbPlay.Size = New Size(200, 100)
        pbPlay.TabIndex = 0
        pbPlay.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        BackgroundImage = My.Resources.Resources.Halaman_Depan
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 837)
        Controls.Add(pbPlay)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(pbPlay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbPlay As PictureBox

End Class
