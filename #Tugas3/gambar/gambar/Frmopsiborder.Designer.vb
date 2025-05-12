<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmopsiborder
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
        Label1 = New Label()
        Label2 = New Label()
        warna = New ComboBox()
        tebal = New ComboBox()
        btnBtal = New Button()
        btnSimpan = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 25)
        Label1.TabIndex = 0
        Label1.Text = "Warna Border:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 25)
        Label2.TabIndex = 1
        Label2.Text = "Ketebalan Border:"
        ' 
        ' warna
        ' 
        warna.FormattingEnabled = True
        warna.Location = New Point(181, 54)
        warna.Name = "warna"
        warna.Size = New Size(182, 33)
        warna.TabIndex = 2
        ' 
        ' tebal
        ' 
        tebal.FormattingEnabled = True
        tebal.Location = New Point(181, 111)
        tebal.Name = "tebal"
        tebal.Size = New Size(182, 33)
        tebal.TabIndex = 3
        ' 
        ' btnBtal
        ' 
        btnBtal.Location = New Point(73, 176)
        btnBtal.Name = "btnBtal"
        btnBtal.Size = New Size(112, 34)
        btnBtal.TabIndex = 4
        btnBtal.Text = "Batal"
        btnBtal.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(251, 176)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Frmopsiborder
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(470, 265)
        Controls.Add(btnSimpan)
        Controls.Add(btnBtal)
        Controls.Add(tebal)
        Controls.Add(warna)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Frmopsiborder"
        Text = "Frmopsiborder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents warna As ComboBox
    Friend WithEvents tebal As ComboBox
    Friend WithEvents btnBtal As Button
    Friend WithEvents btnSimpan As Button
End Class
