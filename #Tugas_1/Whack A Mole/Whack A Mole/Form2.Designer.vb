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
        components = New ComponentModel.Container()
        pbMole1 = New PictureBox()
        pbMole4 = New PictureBox()
        pbMole2 = New PictureBox()
        pbMole3 = New PictureBox()
        pbMole6 = New PictureBox()
        pbMole5 = New PictureBox()
        pbMole7 = New PictureBox()
        lblScore = New Label()
        lblHighScore = New Label()
        lblTime = New Label()
        pbRefresh = New PictureBox()
        TimerGame = New Timer(components)
        TimerMole = New Timer(components)
        Label1 = New Label()
        CType(pbMole1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbRefresh, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbMole1
        ' 
        pbMole1.BackColor = Color.Transparent
        pbMole1.BackgroundImage = My.Resources.Resources.Mole
        pbMole1.BackgroundImageLayout = ImageLayout.Stretch
        pbMole1.Location = New Point(60, 288)
        pbMole1.Name = "pbMole1"
        pbMole1.Size = New Size(134, 127)
        pbMole1.TabIndex = 0
        pbMole1.TabStop = False
        pbMole1.Visible = False
        ' 
        ' pbMole4
        ' 
        pbMole4.BackColor = Color.Transparent
        pbMole4.BackgroundImage = My.Resources.Resources.Mole
        pbMole4.BackgroundImageLayout = ImageLayout.Stretch
        pbMole4.Location = New Point(462, 364)
        pbMole4.Name = "pbMole4"
        pbMole4.Size = New Size(134, 127)
        pbMole4.TabIndex = 1
        pbMole4.TabStop = False
        pbMole4.Visible = False
        ' 
        ' pbMole2
        ' 
        pbMole2.BackColor = Color.Transparent
        pbMole2.BackgroundImage = My.Resources.Resources.Mole
        pbMole2.BackgroundImageLayout = ImageLayout.Stretch
        pbMole2.Location = New Point(313, 231)
        pbMole2.Name = "pbMole2"
        pbMole2.Size = New Size(134, 127)
        pbMole2.TabIndex = 2
        pbMole2.TabStop = False
        pbMole2.Visible = False
        ' 
        ' pbMole3
        ' 
        pbMole3.BackColor = Color.Transparent
        pbMole3.BackgroundImage = My.Resources.Resources.Mole
        pbMole3.BackgroundImageLayout = ImageLayout.Stretch
        pbMole3.Location = New Point(177, 421)
        pbMole3.Name = "pbMole3"
        pbMole3.Size = New Size(134, 127)
        pbMole3.TabIndex = 3
        pbMole3.TabStop = False
        pbMole3.Visible = False
        ' 
        ' pbMole6
        ' 
        pbMole6.BackColor = Color.Transparent
        pbMole6.BackgroundImage = My.Resources.Resources.Mole
        pbMole6.BackgroundImageLayout = ImageLayout.Stretch
        pbMole6.Location = New Point(324, 671)
        pbMole6.Name = "pbMole6"
        pbMole6.Size = New Size(134, 127)
        pbMole6.TabIndex = 4
        pbMole6.TabStop = False
        pbMole6.Visible = False
        ' 
        ' pbMole5
        ' 
        pbMole5.BackColor = Color.Transparent
        pbMole5.BackgroundImage = My.Resources.Resources.Mole
        pbMole5.BackgroundImageLayout = ImageLayout.Stretch
        pbMole5.Location = New Point(43, 585)
        pbMole5.Name = "pbMole5"
        pbMole5.Size = New Size(134, 127)
        pbMole5.TabIndex = 5
        pbMole5.TabStop = False
        pbMole5.Visible = False
        ' 
        ' pbMole7
        ' 
        pbMole7.BackColor = Color.Transparent
        pbMole7.BackgroundImage = My.Resources.Resources.Mole
        pbMole7.BackgroundImageLayout = ImageLayout.Stretch
        pbMole7.Location = New Point(490, 509)
        pbMole7.Name = "pbMole7"
        pbMole7.Size = New Size(134, 127)
        pbMole7.TabIndex = 6
        pbMole7.TabStop = False
        pbMole7.Visible = False
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.BackColor = Color.Transparent
        lblScore.Font = New Font("Felix Titling", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.ForeColor = Color.White
        lblScore.Location = New Point(43, 179)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(73, 78)
        lblScore.TabIndex = 7
        lblScore.Text = "0"
        ' 
        ' lblHighScore
        ' 
        lblHighScore.AutoSize = True
        lblHighScore.BackColor = Color.Transparent
        lblHighScore.Font = New Font("Felix Titling", 40.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHighScore.ForeColor = Color.White
        lblHighScore.Location = New Point(324, 125)
        lblHighScore.Name = "lblHighScore"
        lblHighScore.Size = New Size(73, 78)
        lblHighScore.TabIndex = 8
        lblHighScore.Text = "0"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.BackColor = Color.Transparent
        lblTime.Font = New Font("Felix Titling", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.ForeColor = Color.White
        lblTime.Location = New Point(571, 179)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(98, 68)
        lblTime.TabIndex = 9
        lblTime.Text = "30"
        ' 
        ' pbRefresh
        ' 
        pbRefresh.BackColor = Color.Transparent
        pbRefresh.BackgroundImage = My.Resources.Resources.Refresh
        pbRefresh.BackgroundImageLayout = ImageLayout.Stretch
        pbRefresh.Location = New Point(26, 27)
        pbRefresh.Name = "pbRefresh"
        pbRefresh.Size = New Size(65, 62)
        pbRefresh.TabIndex = 10
        pbRefresh.TabStop = False
        ' 
        ' TimerGame
        ' 
        ' 
        ' TimerMole
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(243, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 57)
        Label1.TabIndex = 11
        Label1.Text = "Best Score"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.MapMole
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 837)
        Controls.Add(Label1)
        Controls.Add(pbRefresh)
        Controls.Add(lblTime)
        Controls.Add(lblHighScore)
        Controls.Add(lblScore)
        Controls.Add(pbMole7)
        Controls.Add(pbMole5)
        Controls.Add(pbMole6)
        Controls.Add(pbMole3)
        Controls.Add(pbMole2)
        Controls.Add(pbMole4)
        Controls.Add(pbMole1)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Whack a Mole!"
        CType(pbMole1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole4, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole3, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole6, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole5, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMole7, ComponentModel.ISupportInitialize).EndInit()
        CType(pbRefresh, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbMole1 As PictureBox
    Friend WithEvents pbMole4 As PictureBox
    Friend WithEvents pbMole2 As PictureBox
    Friend WithEvents pbMole3 As PictureBox
    Friend WithEvents pbMole6 As PictureBox
    Friend WithEvents pbMole5 As PictureBox
    Friend WithEvents pbMole7 As PictureBox
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents pbRefresh As PictureBox
    Friend WithEvents TimerGame As Timer
    Friend WithEvents TimerMole As Timer
    Friend WithEvents Label1 As Label
End Class
