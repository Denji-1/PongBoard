<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.paddleLeft = New System.Windows.Forms.PictureBox()
        Me.paddleRight = New System.Windows.Forms.PictureBox()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblScoreleft = New System.Windows.Forms.Label()
        Me.lblScoreRight = New System.Windows.Forms.Label()
        Me.btnPauseStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gamePanel = New System.Windows.Forms.Panel()
        Me.btnToggleMode = New System.Windows.Forms.Button()
        CType(Me.paddleLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddleRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'paddleLeft
        '
        Me.paddleLeft.BackColor = System.Drawing.Color.MediumPurple
        Me.paddleLeft.Location = New System.Drawing.Point(3, 198)
        Me.paddleLeft.Name = "paddleLeft"
        Me.paddleLeft.Size = New System.Drawing.Size(10, 100)
        Me.paddleLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.paddleLeft.TabIndex = 0
        Me.paddleLeft.TabStop = False
        '
        'paddleRight
        '
        Me.paddleRight.BackColor = System.Drawing.Color.Orange
        Me.paddleRight.Location = New System.Drawing.Point(765, 198)
        Me.paddleRight.Name = "paddleRight"
        Me.paddleRight.Size = New System.Drawing.Size(10, 100)
        Me.paddleRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.paddleRight.TabIndex = 1
        Me.paddleRight.TabStop = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.Linen
        Me.Ball.Image = CType(resources.GetObject("Ball.Image"), System.Drawing.Image)
        Me.Ball.InitialImage = Nothing
        Me.Ball.Location = New System.Drawing.Point(370, 230)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(30, 26)
        Me.Ball.TabIndex = 2
        Me.Ball.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'lblScoreleft
        '
        Me.lblScoreleft.AutoSize = True
        Me.lblScoreleft.BackColor = System.Drawing.Color.MediumPurple
        Me.lblScoreleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreleft.Location = New System.Drawing.Point(249, 42)
        Me.lblScoreleft.Name = "lblScoreleft"
        Me.lblScoreleft.Size = New System.Drawing.Size(27, 29)
        Me.lblScoreleft.TabIndex = 3
        Me.lblScoreleft.Text = "0"
        '
        'lblScoreRight
        '
        Me.lblScoreRight.AutoSize = True
        Me.lblScoreRight.BackColor = System.Drawing.Color.Orange
        Me.lblScoreRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreRight.Location = New System.Drawing.Point(503, 45)
        Me.lblScoreRight.Name = "lblScoreRight"
        Me.lblScoreRight.Size = New System.Drawing.Size(27, 29)
        Me.lblScoreRight.TabIndex = 4
        Me.lblScoreRight.Text = "0"
        '
        'btnPauseStart
        '
        Me.btnPauseStart.BackColor = System.Drawing.Color.BurlyWood
        Me.btnPauseStart.Location = New System.Drawing.Point(343, 2)
        Me.btnPauseStart.Name = "btnPauseStart"
        Me.btnPauseStart.Size = New System.Drawing.Size(62, 38)
        Me.btnPauseStart.TabIndex = 5
        Me.btnPauseStart.Text = "pause"
        Me.btnPauseStart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(725, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Player 2"
        '
        'gamePanel
        '
        Me.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gamePanel.Controls.Add(Me.Ball)
        Me.gamePanel.Controls.Add(Me.paddleRight)
        Me.gamePanel.Controls.Add(Me.paddleLeft)
        Me.gamePanel.Location = New System.Drawing.Point(3, 74)
        Me.gamePanel.Name = "gamePanel"
        Me.gamePanel.Size = New System.Drawing.Size(778, 458)
        Me.gamePanel.TabIndex = 8
        '
        'btnToggleMode
        '
        Me.btnToggleMode.Location = New System.Drawing.Point(12, 10)
        Me.btnToggleMode.Name = "btnToggleMode"
        Me.btnToggleMode.Size = New System.Drawing.Size(101, 30)
        Me.btnToggleMode.TabIndex = 9
        Me.btnToggleMode.Text = "Single Player"
        Me.btnToggleMode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(782, 566)
        Me.Controls.Add(Me.btnToggleMode)
        Me.Controls.Add(Me.gamePanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPauseStart)
        Me.Controls.Add(Me.lblScoreRight)
        Me.Controls.Add(Me.lblScoreleft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pong Board"
        CType(Me.paddleLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddleRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gamePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paddleLeft As PictureBox
    Friend WithEvents paddleRight As PictureBox
    Friend WithEvents Ball As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblScoreleft As Label
    Friend WithEvents lblScoreRight As Label
    Friend WithEvents btnPauseStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gamePanel As Panel
    Friend WithEvents btnToggleMode As Button
End Class
