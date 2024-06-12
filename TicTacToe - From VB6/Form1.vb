Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1
    Private game As TicTacToe
    Private labels As Label()
    Private computerMovedFirst As Boolean = False
    Private difficultyLevel As String = "Impossible"
    Private rand As New Random()
    Private WithEvents animationTimer As New Timer()
    Private currentXPosition As Integer
    Private currentOPosition As Integer

    Public Sub New()
        InitializeComponent()

        labels = {lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8}

        For Each label As Label In labels
            label.Text = ""
            AddHandler label.Click, AddressOf Label_Click
        Next

        game = New TicTacToe(difficultyLevel)
        InitializeAnimationTimer()
    End Sub

    Private Sub InitializeAnimationTimer()
        animationTimer.Interval = 100
        animationTimer.Enabled = False
        animationTimer.Start()
    End Sub

    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        MoveX()
        MoveO()
    End Sub

    Private Sub MoveX()
        Dim newIndex As Integer = GetNextPosition(currentXPosition)
        MoveCharacter("X", currentXPosition, newIndex)
        currentXPosition = newIndex
    End Sub

    Private Sub MoveO()
        Dim newIndex As Integer = GetNextPosition(currentOPosition)
        MoveCharacter("O", currentOPosition, newIndex)
        currentOPosition = newIndex
    End Sub

    Private Function GetNextPosition(currentPosition As Integer) As Integer
        Dim emptyLabels As New List(Of Integer)
        Dim row As Integer = currentPosition \ 3
        Dim col As Integer = currentPosition Mod 3

        If row > 0 AndAlso labels((row - 1) * 3 + col).Text = "" Then
            emptyLabels.Add((row - 1) * 3 + col)
        End If
        If row < 2 AndAlso labels((row + 1) * 3 + col).Text = "" Then
            emptyLabels.Add((row + 1) * 3 + col)
        End If
        If col > 0 AndAlso labels(row * 3 + (col - 1)).Text = "" Then
            emptyLabels.Add(row * 3 + (col - 1))
        End If
        If col < 2 AndAlso labels(row * 3 + (col + 1)).Text = "" Then
            emptyLabels.Add(row * 3 + (col + 1))
        End If

        If emptyLabels.Count > 0 Then
            Return emptyLabels(rand.Next(emptyLabels.Count))
        Else
            Return currentPosition
        End If
    End Function

    Private Sub MoveCharacter(character As String, oldIndex As Integer, newIndex As Integer)
        labels(oldIndex).Text = ""
        labels(newIndex).Text = character
    End Sub

    Private Sub DifficultyChanged(sender As Object, e As EventArgs) Handles rdoEasy.CheckedChanged, rdoNormal.CheckedChanged, rdoDifficult.CheckedChanged, rdoImpossible.CheckedChanged
        If rdoEasy.Checked Then
            difficultyLevel = "Easy"
        ElseIf rdoNormal.Checked Then
            difficultyLevel = "Normal"
        ElseIf rdoDifficult.Checked Then
            difficultyLevel = "Difficult"
        ElseIf rdoImpossible.Checked Then
            difficultyLevel = "Impossible"
        End If
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs)
        Dim clickedLabel As Label = CType(sender, Label)
        Dim index As Integer = Array.IndexOf(labels, clickedLabel)

        If index <> -1 AndAlso clickedLabel.Text = "" Then
            Dim row As Integer = index \ 3
            Dim col As Integer = index Mod 3
            If HumanMove(row, col) = False Then
                ComputerMove()
            End If
        End If
    End Sub

    Private Function HumanMove(row As Integer, col As Integer) As Boolean
        UpdateGrid(game.HumanMove(row, col))

        If game.Evaluate() = -10 Then
            lblHumanWins.Text = Integer.Parse(lblHumanWins.Text) + 1
            ShowMsgBox("You win!")
            Return True
        End If

        If Not game.IsMovesLeft() Then
            lblCatsGames.Text = Integer.Parse(lblCatsGames.Text) + 1
            ShowMsgBox("It's a tie!")
            Return True
        End If

        Return False
    End Function

    Private Sub ComputerMove()
        UpdateGrid(game.ComputerMove())

        If game.Evaluate() = 10 Then
            lblComputerWins.Text = Integer.Parse(lblComputerWins.Text) + 1
            ShowMsgBox("Computer wins!")
            Exit Sub
        End If

        If Not game.IsMovesLeft() Then
            lblCatsGames.Text = Integer.Parse(lblCatsGames.Text) + 1
            ShowMsgBox("It's a tie!")
        End If
    End Sub

    Private Sub UpdateGrid(Moves As String())
        For i As Integer = 0 To 8
            labels(i).Text = Moves(i)
        Next
    End Sub

    Private Sub InitializeGame()
        animationTimer.Stop()
        For Each label As Label In labels
            label.Text = ""
        Next
        game.InitializeBoard(difficultyLevel)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitializeGame()
        If chkComputerMovesFirst.Checked Then
            ComputerMove()
        End If
    End Sub

    Private Sub ShowMsgBox(Msg As String)
        Using New CenteredMsgBox(Me)
            MessageBox.Show(Msg, "Game Over!", MessageBoxButtons.OK)
        End Using
    End Sub
End Class
