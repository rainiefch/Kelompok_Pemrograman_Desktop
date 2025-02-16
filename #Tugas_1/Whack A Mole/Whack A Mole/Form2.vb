Public Class Form2
    Dim score As Integer = 0
    Dim highScore As Integer = 0
    Dim timeLeft As Integer = 30
    Dim random As New Random()
    Dim moles() As PictureBox
    Dim gameRunning As Boolean = False

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moles = {pbMole1, pbMole2, pbMole3, pbMole4, pbMole5, pbMole6, pbMole7}
        TimerGame.Interval = 1000
        TimerMole.Interval = 800

        For Each mole In moles
            mole.Visible = False
        Next

        StartGame()
    End Sub

    Private Sub StartGame()
        score = 0
        lblScore.Text = "0"
        timeLeft = 30
        lblTime.Text = "30"

        gameRunning = True
        TimerGame.Start()
        TimerMole.Start()
    End Sub

    Private Sub TimerGame_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick
        If timeLeft > 0 Then
            timeLeft -= 1
            lblTime.Text = timeLeft.ToString()
        Else
            TimerGame.Stop()
            TimerMole.Stop()
            gameRunning = False

            Dim result As DialogResult = MessageBox.Show("Time's Up! Your score: " & score & vbCrLf & "Play again?", "Game Over", MessageBoxButtons.YesNo)

            If score > highScore Then
                highScore = score
                lblHighScore.Text = highScore.ToString()
            End If

            If result = DialogResult.Yes Then
                StartGame()
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub TimerMole_Tick(sender As Object, e As EventArgs) Handles TimerMole.Tick
        For Each mole In moles
            mole.Visible = False
        Next

        Dim randomIndex As Integer = random.Next(0, moles.Length)
        moles(randomIndex).Visible = True
    End Sub

    Private Sub Mole_Click(sender As Object, e As EventArgs) Handles pbMole1.Click, pbMole2.Click, pbMole3.Click, pbMole4.Click, pbMole5.Click, pbMole6.Click, pbMole7.Click
        If gameRunning Then
            score += 1
            lblScore.Text = score.ToString()

            Dim mole As PictureBox = CType(sender, PictureBox)
            mole.Visible = False
        End If
    End Sub

    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        StartGame()
    End Sub
End Class
