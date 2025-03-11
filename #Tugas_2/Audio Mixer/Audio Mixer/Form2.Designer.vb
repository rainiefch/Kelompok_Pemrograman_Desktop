<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.btnPlusHour = New System.Windows.Forms.Button()
        Me.btnMinHour = New System.Windows.Forms.Button()
        Me.btnMinMinute = New System.Windows.Forms.Button()
        Me.btnPlusMinute = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHour
        '
        Me.txtHour.Location = New System.Drawing.Point(62, 89)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.Size = New System.Drawing.Size(65, 22)
        Me.txtHour.TabIndex = 0
        '
        'txtMinute
        '
        Me.txtMinute.Location = New System.Drawing.Point(210, 88)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.Size = New System.Drawing.Size(65, 22)
        Me.txtMinute.TabIndex = 1
        '
        'btnPlusHour
        '
        Me.btnPlusHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnPlusHour.FlatAppearance.BorderSize = 0
        Me.btnPlusHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlusHour.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlusHour.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPlusHour.Location = New System.Drawing.Point(62, 38)
        Me.btnPlusHour.Name = "btnPlusHour"
        Me.btnPlusHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPlusHour.Size = New System.Drawing.Size(65, 33)
        Me.btnPlusHour.TabIndex = 2
        Me.btnPlusHour.Text = "+"
        Me.btnPlusHour.UseVisualStyleBackColor = False
        '
        'btnMinHour
        '
        Me.btnMinHour.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMinHour.FlatAppearance.BorderSize = 0
        Me.btnMinHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinHour.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinHour.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMinHour.Location = New System.Drawing.Point(62, 133)
        Me.btnMinHour.Name = "btnMinHour"
        Me.btnMinHour.Size = New System.Drawing.Size(65, 33)
        Me.btnMinHour.TabIndex = 6
        Me.btnMinHour.Text = "-"
        Me.btnMinHour.UseVisualStyleBackColor = False
        '
        'btnMinMinute
        '
        Me.btnMinMinute.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnMinMinute.FlatAppearance.BorderSize = 0
        Me.btnMinMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinMinute.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnMinMinute.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMinMinute.Location = New System.Drawing.Point(210, 133)
        Me.btnMinMinute.Name = "btnMinMinute"
        Me.btnMinMinute.Size = New System.Drawing.Size(65, 33)
        Me.btnMinMinute.TabIndex = 7
        Me.btnMinMinute.Text = "-"
        Me.btnMinMinute.UseVisualStyleBackColor = False
        '
        'btnPlusMinute
        '
        Me.btnPlusMinute.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnPlusMinute.FlatAppearance.BorderSize = 0
        Me.btnPlusMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlusMinute.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btnPlusMinute.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPlusMinute.Location = New System.Drawing.Point(210, 38)
        Me.btnPlusMinute.Name = "btnPlusMinute"
        Me.btnPlusMinute.Size = New System.Drawing.Size(65, 33)
        Me.btnPlusMinute.TabIndex = 8
        Me.btnPlusMinute.Text = "+"
        Me.btnPlusMinute.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!)
        Me.btnOk.ForeColor = System.Drawing.SystemColors.Control
        Me.btnOk.Location = New System.Drawing.Point(373, 97)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(82, 33)
        Me.btnOk.TabIndex = 9
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReset.Location = New System.Drawing.Point(373, 58)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 33)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(144, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "jam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(292, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "menit"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(502, 212)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnPlusMinute)
        Me.Controls.Add(Me.btnMinMinute)
        Me.Controls.Add(Me.btnMinHour)
        Me.Controls.Add(Me.btnPlusHour)
        Me.Controls.Add(Me.txtMinute)
        Me.Controls.Add(Me.txtHour)
        Me.Name = "Form2"
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHour As TextBox
    Friend WithEvents txtMinute As TextBox
    Friend WithEvents btnPlusHour As Button
    Friend WithEvents btnMinHour As Button
    Friend WithEvents btnMinMinute As Button
    Friend WithEvents btnPlusMinute As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
