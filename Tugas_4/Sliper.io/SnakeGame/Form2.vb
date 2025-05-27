Imports System.Drawing
Imports System.IO


Public Class Form2
    Private Const GRID_SIZE As Integer = 20
    Private Const GRID_WIDTH As Integer = 30
    Private Const GRID_HEIGHT As Integer = 25
    Private Const MAX_FOOD_COUNT As Integer = 5
    Private Const BOT_DETECTION_RADIUS As Integer = 10

    Private playerSnake As New List(Of Point)
    Private botSnake1 As New List(Of Point)
    Private botSnake2 As New List(Of Point)
    Private foods As New List(Of Point)
    Private random As New Random()
    Private startScreenActive As Boolean = True
    Private startScreenPanel As Panel
    Private lblStartPrompt As Label

    Private ReadOnly directionVectors As Point() = {
        New Point(0, -1),
        New Point(1, 0),
        New Point(0, 1),
        New Point(-1, 0)
    }

    Private playerDirection As Integer = 1
    Private botDirection1 As Integer = 3
    Private botDirection2 As Integer = 1

    Private nextPlayerDirection As Integer = 1
    Private nextBotDirection1 As Integer = 3
    Private nextBotDirection2 As Integer = 1

    Private gameRunning As Boolean = False
    Private score As Integer = 0
    Private highScore As Integer = 0
    Private isGameOver As Boolean = False

    Private gameOverPanel As Panel
    Private lblGameOver As Label
    Private lblFinalScore As Label
    Private btnMulaiLagi As Button
    Private btnExit As Button

    Private playerHeadImage As Image
    Private botHead1Image As Image
    Private botHead2Image As Image
    Private foodImage As Image

    Public Sub New()
        InitializeComponent()
        LoadHighScore()
        LoadImages()
        SetupGameOverPanel()
        SetupStartScreen()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.KeyPreview = True
    End Sub

    Private Sub SetupStartScreen()
        startScreenPanel = New Panel()
        Me.Controls.Add(startScreenPanel)
        startScreenPanel.BackColor = Color.Purple
        startScreenPanel.Dock = DockStyle.Fill
        startScreenPanel.Visible = True
        startScreenPanel.BringToFront()

        lblStartPrompt = New Label()
        startScreenPanel.Controls.Add(lblStartPrompt)
        lblStartPrompt.Text = "Mulai | Tekan ENTER "
        lblStartPrompt.Font = New Font("Sagoe UI", 36, FontStyle.Bold)
        lblStartPrompt.ForeColor = Color.White
        lblStartPrompt.AutoSize = True
        lblStartPrompt.BackColor = Color.Transparent

        lblStartPrompt.Location = New Point(
            startScreenPanel.Width \ 2 - lblStartPrompt.Width \ 2,
            startScreenPanel.Height \ 2 - lblStartPrompt.Height \ 2)
    End Sub

    Private Sub AdjustStartScreenControls()
        If lblStartPrompt IsNot Nothing Then
            lblStartPrompt.Location = New Point(
                startScreenPanel.Width \ 2 - lblStartPrompt.Width \ 2,
                startScreenPanel.Height \ 2 - lblStartPrompt.Height \ 2)
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If startScreenActive AndAlso e.KeyCode = Keys.Enter Then
            startScreenActive = False
            startScreenPanel.Visible = False
            gameRunning = True
            Timer1.Interval = 100
            Timer1.Enabled = True
            Return
        End If

        If gameRunning Then
            Select Case e.KeyCode
                Case Keys.Up
                    If playerDirection <> 2 Then
                        nextPlayerDirection = 0
                    End If
                Case Keys.Right
                    If playerDirection <> 3 Then
                        nextPlayerDirection = 1
                    End If
                Case Keys.Down
                    If playerDirection <> 0 Then
                        nextPlayerDirection = 2
                    End If
                Case Keys.Left
                    If playerDirection <> 1 Then
                        nextPlayerDirection = 3
                    End If
            End Select
        End If
    End Sub

    Private Sub LoadImages()
        Try
            playerHeadImage = Image.FromFile(Path.Combine(Application.StartupPath, "snake.png"))
            botHead1Image = Image.FromFile(Path.Combine(Application.StartupPath, "snakebot1.png"))
            botHead2Image = Image.FromFile(Path.Combine(Application.StartupPath, "snakebot2.png"))
            foodImage = Image.FromFile(Path.Combine(Application.StartupPath, "makan.png"))
        Catch ex As Exception
            MessageBox.Show("Error loading images: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadHighScore()
        Try
            Dim highScorePath As String = Path.Combine(Application.StartupPath, "highscore.txt")
            If File.Exists(highScorePath) Then
                highScore = Integer.Parse(File.ReadAllText(highScorePath))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SaveHighScore()
        Try
            Dim highScorePath As String = Path.Combine(Application.StartupPath, "highscore.txt")
            File.WriteAllText(highScorePath, highScore.ToString())
        Catch ex As Exception
            MessageBox.Show("Error saving high score: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "background.png"))
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

        InitializeGame()

        PictureBox1.Invalidate()
    End Sub

    Private Sub InitializeGame()
        playerSnake.Clear()
        botSnake1.Clear()
        botSnake2.Clear()
        foods.Clear()
        score = 0

        playerSnake.Add(New Point(10, 12))
        playerSnake.Add(New Point(9, 12))
        playerSnake.Add(New Point(8, 12))
        playerDirection = 1
        nextPlayerDirection = 1

        botSnake1.Add(New Point(20, 5))
        botSnake1.Add(New Point(21, 5))
        botSnake1.Add(New Point(22, 5))
        botDirection1 = 3
        nextBotDirection1 = 3

        botSnake2.Add(New Point(20, 20))
        botSnake2.Add(New Point(19, 20))
        botSnake2.Add(New Point(18, 20))
        botDirection2 = 1
        nextBotDirection2 = 1

        For i As Integer = 0 To MAX_FOOD_COUNT - 1
            GenerateFood()
        Next

        gameRunning = False
        Timer1.Enabled = False
    End Sub

    Private Sub SetupGameOverPanel()
        gameOverPanel = New Panel()
        Me.Controls.Add(gameOverPanel)
        gameOverPanel.BackColor = Color.Purple

        gameOverPanel.Dock = DockStyle.Fill
        gameOverPanel.Visible = False
        gameOverPanel.BringToFront()

        lblGameOver = New Label()
        gameOverPanel.Controls.Add(lblGameOver)
        lblGameOver.Text = "Game Over"
        lblGameOver.Font = New Font("Arial", 36, FontStyle.Bold)
        lblGameOver.ForeColor = Color.White
        lblGameOver.AutoSize = True
        lblGameOver.Location = New Point(gameOverPanel.Width \ 2 - 150, gameOverPanel.Height \ 2 - 150)

        lblFinalScore = New Label()
        gameOverPanel.Controls.Add(lblFinalScore)
        lblFinalScore.Font = New Font("Arial", 18, FontStyle.Regular)
        lblFinalScore.ForeColor = Color.White
        lblFinalScore.AutoSize = True
        lblFinalScore.Location = New Point(gameOverPanel.Width \ 2 - 150, gameOverPanel.Height \ 2 - 80)

        btnMulaiLagi = New Button()
        gameOverPanel.Controls.Add(btnMulaiLagi)
        btnMulaiLagi.Text = "Mulai Lagi"
        btnMulaiLagi.Font = New Font("Arial", 14, FontStyle.Bold)
        btnMulaiLagi.Size = New Size(150, 50)
        btnMulaiLagi.Location = New Point(gameOverPanel.Width \ 2 - 160, gameOverPanel.Height \ 2)
        AddHandler btnMulaiLagi.Click, AddressOf BtnMulaiLagi_Click

        btnExit = New Button()
        gameOverPanel.Controls.Add(btnExit)
        btnExit.Text = "Exit"
        btnExit.Font = New Font("Arial", 14, FontStyle.Bold)
        btnExit.Size = New Size(150, 50)
        btnExit.Location = New Point(gameOverPanel.Width \ 2 + 10, gameOverPanel.Height \ 2)
        AddHandler btnExit.Click, AddressOf BtnExit_Click
    End Sub

    Private Sub AdjustGameOverPanelControls()
        lblGameOver.Location = New Point(gameOverPanel.Width \ 2 - lblGameOver.Width \ 2, gameOverPanel.Height \ 3)
        lblFinalScore.Location = New Point(gameOverPanel.Width \ 2 - lblFinalScore.Width \ 2, lblGameOver.Bottom + 20)
        btnMulaiLagi.Location = New Point(gameOverPanel.Width \ 2 - btnMulaiLagi.Width - 10, lblFinalScore.Bottom + 30)
        btnExit.Location = New Point(gameOverPanel.Width \ 2 + 10, lblFinalScore.Bottom + 30)
    End Sub

    Private Sub BtnMulaiLagi_Click(sender As Object, e As EventArgs)
        gameOverPanel.Visible = False
        isGameOver = False

        StartGame()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub StartGame()
        InitializeGame()
        gameRunning = True
        Timer1.Interval = 100
        Timer1.Enabled = True
    End Sub

    Private Sub ShowGameOver()
        If score > highScore Then
            highScore = score
            SaveHighScore()
        End If

        lblFinalScore.Text = "Skor akhir: " & score.ToString() & " | High Score: " & highScore.ToString()

        AdjustGameOverPanelControls()

        isGameOver = True
        gameRunning = False
        Timer1.Enabled = False
        gameOverPanel.Visible = True
    End Sub

    Private Sub ResetGame()
        gameRunning = False
        Timer1.Enabled = False

        PictureBox1.Invalidate()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not gameRunning Then Return

        playerDirection = nextPlayerDirection

        MovePlayerSnake()
        MoveBotSnake(botSnake1, botDirection1, nextBotDirection1, 1)
        MoveBotSnake(botSnake2, botDirection2, nextBotDirection2, 2)

        If CheckPlayerCollisions() Then
            ShowGameOver()
            Return
        End If

        PictureBox1.Invalidate()
    End Sub

    Private Sub MovePlayerSnake()
        Dim head As Point = playerSnake(0)
        Dim newHead As New Point(
            (head.X + directionVectors(playerDirection).X + GRID_WIDTH) Mod GRID_WIDTH,
            (head.Y + directionVectors(playerDirection).Y + GRID_HEIGHT) Mod GRID_HEIGHT)

        playerSnake.Insert(0, newHead)

        Dim ate As Boolean = False
        For i As Integer = foods.Count - 1 To 0 Step -1
            If newHead = foods(i) Then
                foods.RemoveAt(i)
                score += 10
                GenerateFood()
                ate = True
                Exit For
            End If
        Next

        If Not ate Then
            playerSnake.RemoveAt(playerSnake.Count - 1)
        End If
    End Sub

    Private Sub MoveBotSnake(ByRef snake As List(Of Point), ByRef direction As Integer, ByRef nextDirection As Integer, botId As Integer)
        Dim head As Point = snake(0)

        Dim nearestFood As Point = FindNearestFood(head)
        Dim distanceToFood As Integer = ManhattanDistance(head, nearestFood)

        If distanceToFood <= BOT_DETECTION_RADIUS Then
            Dim bestDir As Integer = FindBestDirectionToFood(head, nearestFood, direction)
            nextDirection = bestDir
        Else
            Dim validDirections As New List(Of Integer)
            For i As Integer = 0 To 3
                If (i + 2) Mod 4 <> direction Then
                    Dim nextPos As New Point(
                        (head.X + directionVectors(i).X + GRID_WIDTH) Mod GRID_WIDTH,
                        (head.Y + directionVectors(i).Y + GRID_HEIGHT) Mod GRID_HEIGHT)

                    If Not snake.Contains(nextPos) And Not (botId = 1 And botSnake2.Contains(nextPos)) And
                       Not (botId = 2 And botSnake1.Contains(nextPos)) And Not playerSnake.Contains(nextPos) Then
                        validDirections.Add(i)
                    End If
                End If
            Next

            If validDirections.Count > 0 Then
                nextDirection = validDirections(random.Next(validDirections.Count))
            End If
        End If

        direction = nextDirection

        Dim newHead As New Point(
            (head.X + directionVectors(direction).X + GRID_WIDTH) Mod GRID_WIDTH,
            (head.Y + directionVectors(direction).Y + GRID_HEIGHT) Mod GRID_HEIGHT)

        snake.Insert(0, newHead)

        Dim ate As Boolean = False
        For i As Integer = foods.Count - 1 To 0 Step -1
            If newHead = foods(i) Then
                foods.RemoveAt(i)
                GenerateFood()
                ate = True
                Exit For
            End If
        Next

        If CheckBotCollision(snake, botId) Then
            ResetBot(snake, botId)
            Return
        End If

        If playerSnake.Contains(newHead) AndAlso playerSnake.IndexOf(newHead) > 0 Then
            score += 50
            ResetBot(snake, botId)
            Return
        End If

        If Not ate Then
            snake.RemoveAt(snake.Count - 1)
        End If
    End Sub

    Private Function CheckBotCollision(snake As List(Of Point), botId As Integer) As Boolean
        Dim head As Point = snake(0)

        For i As Integer = 1 To snake.Count - 1
            If head = snake(i) Then
                Return True
            End If
        Next

        If botId = 1 And botSnake2.Count > 0 Then
            If botSnake2.Contains(head) Then
                Return True
            End If
        ElseIf botId = 2 And botSnake1.Count > 0 Then
            If botSnake1.Contains(head) Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Sub ResetBot(ByRef snake As List(Of Point), botId As Integer)
        snake.Clear()

        If botId = 1 Then
            snake.Add(New Point(20, 5))
            snake.Add(New Point(21, 5))
            snake.Add(New Point(22, 5))
            botDirection1 = 3
            nextBotDirection1 = 3
        Else
            snake.Add(New Point(20, 20))
            snake.Add(New Point(19, 20))
            snake.Add(New Point(18, 20))
            botDirection2 = 1
            nextBotDirection2 = 1
        End If
    End Sub

    Private Function FindNearestFood(position As Point) As Point
        Dim minDistance As Integer = Integer.MaxValue
        Dim nearest As Point = New Point(-1, -1)

        For Each food As Point In foods
            Dim distance As Integer = ManhattanDistance(position, food)
            If distance < minDistance Then
                minDistance = distance
                nearest = food
            End If
        Next

        If nearest.X = -1 Then
            Return New Point(random.Next(GRID_WIDTH), random.Next(GRID_HEIGHT))
        End If

        Return nearest
    End Function

    Private Function ManhattanDistance(p1 As Point, p2 As Point) As Integer
        Return Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y)
    End Function

    Private Function FindBestDirectionToFood(head As Point, food As Point, currentDirection As Integer) As Integer
        Dim dx As Integer = food.X - head.X
        Dim dy As Integer = food.Y - head.Y

        If Math.Abs(dx) > GRID_WIDTH / 2 Then
            dx = If(dx > 0, dx - GRID_WIDTH, dx + GRID_WIDTH)
        End If

        If Math.Abs(dy) > GRID_HEIGHT / 2 Then
            dy = If(dy > 0, dy - GRID_HEIGHT, dy + GRID_HEIGHT)
        End If

        Dim preferredDirections As New List(Of Integer)

        If dx > 0 Then
            preferredDirections.Add(1)
        ElseIf dx < 0 Then
            preferredDirections.Add(3)
        End If

        If dy > 0 Then
            preferredDirections.Add(2)
        ElseIf dy < 0 Then
            preferredDirections.Add(0)
        End If

        Shuffle(preferredDirections)

        For Each dir As Integer In preferredDirections
            If (dir + 2) Mod 4 <> currentDirection Then
                Return dir
            End If
        Next

        Return currentDirection
    End Function

    Private Sub Shuffle(ByRef list As List(Of Integer))
        Dim n As Integer = list.Count
        While n > 1
            n -= 1
            Dim k As Integer = random.Next(n + 1)
            Dim value As Integer = list(k)
            list(k) = list(n)
            list(n) = value
        End While
    End Sub

    Private Function CheckPlayerCollisions() As Boolean
        Dim head As Point = playerSnake(0)

        For i As Integer = 1 To playerSnake.Count - 1
            If head = playerSnake(i) Then
                Return True
            End If
        Next

        For Each segment As Point In botSnake1
            If head = segment Then
                Return True
            End If
        Next

        For Each segment As Point In botSnake2
            If head = segment Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub GenerateFood()
        Dim valid As Boolean = False
        Dim newFood As Point

        While Not valid
            newFood = New Point(random.Next(GRID_WIDTH), random.Next(GRID_HEIGHT))
            valid = True

            For Each segment As Point In playerSnake
                If segment = newFood Then
                    valid = False
                    Exit For
                End If
            Next

            If valid Then
                For Each segment As Point In botSnake1
                    If segment = newFood Then
                        valid = False
                        Exit For
                    End If
                Next
            End If

            If valid Then
                For Each segment As Point In botSnake2
                    If segment = newFood Then
                        valid = False
                        Exit For
                    End If
                Next
            End If

            If valid Then
                For Each food As Point In foods
                    If food = newFood Then
                        valid = False
                        Exit For
                    End If
                Next
            End If
        End While

        foods.Add(newFood)
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim g As Graphics = e.Graphics

        Dim cellWidth As Integer = PictureBox1.Width / GRID_WIDTH
        Dim cellHeight As Integer = PictureBox1.Height / GRID_HEIGHT

        For Each food As Point In foods
            g.DrawImage(foodImage, food.X * cellWidth, food.Y * cellHeight, cellWidth, cellHeight)
        Next

        If playerSnake.Count > 0 Then
            g.DrawImage(playerHeadImage, playerSnake(0).X * cellWidth, playerSnake(0).Y * cellHeight, cellWidth, cellHeight)

            Dim playerBrush As New SolidBrush(Color.Lime)
            For i As Integer = 1 To playerSnake.Count - 1
                g.FillRectangle(playerBrush, playerSnake(i).X * cellWidth, playerSnake(i).Y * cellHeight, cellWidth, cellHeight)
            Next
            playerBrush.Dispose()
        End If

        If botSnake1.Count > 0 Then
            g.DrawImage(botHead1Image, botSnake1(0).X * cellWidth, botSnake1(0).Y * cellHeight, cellWidth, cellHeight)

            Dim botBrush1 As New SolidBrush(Color.Gold)
            For i As Integer = 1 To botSnake1.Count - 1
                g.FillRectangle(botBrush1, botSnake1(i).X * cellWidth, botSnake1(i).Y * cellHeight, cellWidth, cellHeight)
            Next
            botBrush1.Dispose()
        End If

        If botSnake2.Count > 0 Then
            g.DrawImage(botHead2Image, botSnake2(0).X * cellWidth, botSnake2(0).Y * cellHeight, cellWidth, cellHeight)

            Dim botBrush2 As New SolidBrush(Color.Cyan)
            For i As Integer = 1 To botSnake2.Count - 1
                g.FillRectangle(botBrush2, botSnake2(i).X * cellWidth, botSnake2(i).Y * cellHeight, cellWidth, cellHeight)
            Next
            botBrush2.Dispose()
        End If

        If gameRunning And Not isGameOver Then
            Dim scoreBrush As New SolidBrush(Color.White)
            Dim scoreFont As New Font("Arial", 12, FontStyle.Bold)
            g.DrawString("Score: " & score.ToString(), scoreFont, scoreBrush, New PointF(10, 10))
            scoreBrush.Dispose()
            scoreFont.Dispose()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If gameOverPanel IsNot Nothing Then
            AdjustGameOverPanelControls()
        End If

        If startScreenPanel IsNot Nothing Then
            AdjustStartScreenControls()
        End If
    End Sub
End Class
