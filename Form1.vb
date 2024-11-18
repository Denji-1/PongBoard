Public Class Form1
    ' Default speed for player-controlled paddle
    Dim paddleRightSpeed As Integer = 8

    ' Ball movement variables
    Dim ballSpeedX As Integer = 5
    Dim ballSpeedY As Integer = 5

    ' Paddle movement variables
    Dim paddleSpeed As Integer = 8

    ' Scores
    Dim scoreLeft As Integer = 0
    Dim scoreRight As Integer = 0

    'Pause/Start
    Dim isPaused As Boolean = False

    ' Add a Boolean flag to determine whether it's single-player or two-player mode
    Dim isSinglePlayer As Boolean = False

    ' Handle the radio button or button click to change the mode
    Private Sub btnToggleMode_Click(sender As Object, e As EventArgs) Handles btnToggleMode.Click
        ' Toggle between Single Player and Two Player mode
        isSinglePlayer = Not isSinglePlayer

        If isSinglePlayer Then
            ' Set the right paddle as AI-controlled and display a message
            btnToggleMode.Text = "2 players"
            MessageBox.Show("Switched to Single Player Mode. The computer will control Player 2.", "Single Player Mode")
        Else
            ' Reset to Two Player Mode
            btnToggleMode.Text = "Single Player"
            MessageBox.Show("Switched to Two Player Mode. Controls for 2nd player are I/K for up/down", "Two Player Mode")
        End If

        'Reset game when the mode changes
        ResetGame()
    End Sub



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Only allow paddle movement if the game is not paused
        If isPaused Then Exit Sub

        ' Paddle movement logic
        If e.KeyCode = Keys.W And paddleLeft.Top > 0 Then
            paddleLeft.Top -= paddleSpeed
        End If
        If e.KeyCode = Keys.S And paddleLeft.Bottom < gamePanel.ClientSize.Height Then
            paddleLeft.Top += paddleSpeed
        End If
        If e.KeyCode = Keys.I And paddleRight.Top > 0 Then
            paddleRight.Top -= paddleSpeed
        End If

        If e.KeyCode = Keys.K And paddleRight.Bottom < gamePanel.ClientSize.Height Then
            paddleRight.Top += paddleSpeed
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isPaused Then Exit Sub ' Stop the game logic if paused

        ' Move the ball
        Ball.Left += ballSpeedX
        Ball.Top += ballSpeedY

        ' Ball collision with top and bottom walls of the panel
        If Ball.Top <= 0 Or Ball.Bottom >= gamePanel.ClientSize.Height Then
            ballSpeedY *= -1
        End If

        ' Ball collision with paddles
        If Ball.Bounds.IntersectsWith(paddleLeft.Bounds) Or Ball.Bounds.IntersectsWith(paddleRight.Bounds) Then
            ballSpeedX *= -1
        End If

        ' Ball out of bounds (scoring)
        If Ball.Left <= 0 Then
            scoreRight += 1
            ResetBall()
        End If
        If Ball.Right >= gamePanel.ClientSize.Width Then
            scoreLeft += 1
            ResetBall()
        End If

        ' If Single Player, move the AI Paddle
        If isSinglePlayer Then
            MoveAIPaddle() ' Move the AI-controlled right paddle
        End If

        ' Update the score display
        UpdateScore()

        ' Check if anyone has won
        CheckGameOver()
    End Sub

    Private Sub MoveAIPaddle()
        ' Simple AI to move the computer paddle towards the ball's vertical position
        If Ball.Left > gamePanel.ClientSize.Width / 2 Then ' Ball is on the right side
            ' Move the computer paddle to follow the ball (but with some limitations)
            If paddleRight.Top + paddleRight.Height / 2 < Ball.Top Then
                ' Move down
                paddleRight.Top += paddleSpeed
            ElseIf paddleRight.Top + paddleRight.Height / 2 > Ball.Top Then
                ' Move up
                paddleRight.Top -= paddleSpeed
            End If
        End If

        ' Ensure the AI paddle stays within the panel
        If paddleRight.Top < 0 Then
            paddleRight.Top = 0
        End If
        If paddleRight.Bottom > gamePanel.ClientSize.Height Then
            paddleRight.Top = gamePanel.ClientSize.Height - paddleRight.Height
        End If
    End Sub



    Private Sub ResetBall()
        Ball.Location = New Point(gamePanel.ClientSize.Width \ 2, gamePanel.ClientSize.Height \ 2)
        ballSpeedX *= -1 ' Change direction
    End Sub

    Private Sub UpdateScore()
        lblScoreleft.Text = scoreLeft.ToString()
        lblScoreRight.Text = scoreRight.ToString()
    End Sub

    Private Sub CheckGameOver()
        If scoreLeft >= 5 Then
            Timer1.Stop()
            Dim result As DialogResult = MessageBox.Show("Player 1 Wins! Do you want to replay?", "Game Over", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ResetGame()
            Else
                Application.Exit() ' Exit the application
            End If
        ElseIf scoreRight >= 5 Then
            Timer1.Stop()
            Dim result As DialogResult = MessageBox.Show("Player 2 Wins! Do you want to replay?", "Game Over", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ResetGame()
            Else
                Application.Exit() ' Exit the application
            End If
        End If
    End Sub


    Private Sub ResetGame()
        scoreLeft = 0
        scoreRight = 0
        UpdateScore()
        ResetBall()
        isPaused = False ' Ensure game starts unpaused\
        ' Start or stop AI based on game mode
        If isSinglePlayer Then
            '  increase AI difficulty by adjusting paddle speed
            paddleRightSpeed = 6
        Else
            paddleRightSpeed = 8 ' Player controlled speed
        End If
        Timer1.Start()
    End Sub

    Private Sub btnPauseStart_Click(sender As Object, e As EventArgs) Handles btnPauseStart.Click
        If isPaused Then
            ' Unpause the game
            Timer1.Start()
            btnPauseStart.Text = "Pause"
        Else
            ' Pause the game
            Timer1.Stop()
            btnPauseStart.Text = "Start"
        End If

        ' Toggle the isPaused flag
        isPaused = Not isPaused
    End Sub


End Class
