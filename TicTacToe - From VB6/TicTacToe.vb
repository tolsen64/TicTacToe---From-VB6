Public Class TicTacToe
    Private moves As String()
    Private human As Char = "X"c
    Private computer As Char = "O"c
    Private rand As New Random()
    Private difficulty As String

    Public Sub New(difficulty As String)
        InitializeBoard(difficulty)
    End Sub

    Public Sub InitializeBoard(difficulty As String)
        moves = {"", "", "", "", "", "", "", "", ""}
        Me.difficulty = difficulty
    End Sub

    Public Function IsMovesLeft() As Boolean
        For Each move As String In moves
            If move = "" Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function Evaluate() As Integer
        Dim b(2, 2) As Char
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                b(i, j) = If(moves(i * 3 + j) = "", " "c, moves(i * 3 + j)(0))
            Next
        Next

        ' Check rows for victory
        For row As Integer = 0 To 2
            If b(row, 0) = b(row, 1) AndAlso b(row, 1) = b(row, 2) Then
                If b(row, 0) = computer Then
                    Return +10
                ElseIf b(row, 0) = human Then
                    Return -10
                End If
            End If
        Next

        ' Check columns for victory
        For col As Integer = 0 To 2
            If b(0, col) = b(1, col) AndAlso b(1, col) = b(2, col) Then
                If b(0, col) = computer Then
                    Return +10
                ElseIf b(0, col) = human Then
                    Return -10
                End If
            End If
        Next

        ' Check diagonals for victory
        If b(0, 0) = b(1, 1) AndAlso b(1, 1) = b(2, 2) Then
            If b(0, 0) = computer Then
                Return +10
            ElseIf b(0, 0) = human Then
                Return -10
            End If
        End If

        If b(0, 2) = b(1, 1) AndAlso b(1, 1) = b(2, 0) Then
            If b(0, 2) = computer Then
                Return +10
            ElseIf b(0, 2) = human Then
                Return -10
            End If
        End If

        ' If no one has won
        Return 0
    End Function

    Private Function Minimax(depth As Integer, isMax As Boolean) As Integer
        Dim score As Integer = Evaluate()

        ' If the computer has won the game return its evaluated score
        If score = 10 Then
            Return score
        End If

        ' If the human has won the game return its evaluated score
        If score = -10 Then
            Return score
        End If

        ' If there are no more moves and no winner then it is a tie
        If Not IsMovesLeft() Then
            Return 0
        End If

        ' If this is the computer's move
        If isMax Then
            Dim best As Integer = Integer.MinValue

            ' Traverse all cells
            For i As Integer = 0 To 2
                For j As Integer = 0 To 2
                    Dim index As Integer = i * 3 + j
                    ' Check if cell is empty
                    If moves(index) = "" Then
                        ' Make the move
                        moves(index) = computer.ToString()

                        ' Call minimax recursively and choose the maximum value
                        best = Math.Max(best, Minimax(depth + 1, Not isMax))

                        ' Undo the move
                        moves(index) = ""
                    End If
                Next
            Next
            Return best
        Else ' If this is the human's move
            Dim best As Integer = Integer.MaxValue

            ' Traverse all cells
            For i As Integer = 0 To 2
                For j As Integer = 0 To 2
                    Dim index As Integer = i * 3 + j
                    ' Check if cell is empty
                    If moves(index) = "" Then
                        ' Make the move
                        moves(index) = human.ToString()

                        ' Call minimax recursively and choose the minimum value
                        best = Math.Min(best, Minimax(depth + 1, Not isMax))

                        ' Undo the move
                        moves(index) = ""
                    End If
                Next
            Next
            Return best
        End If
    End Function

    Private Function FindBestMove() As (Integer, Integer)
        Dim bestVal As Integer = Integer.MinValue
        Dim bestMoveRow As Integer = -1
        Dim bestMoveCol As Integer = -1

        ' Traverse all cells, evaluate minimax function for all empty cells.
        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                Dim index As Integer = i * 3 + j
                ' Check if cell is empty
                If moves(index) = "" Then
                    ' Make the move
                    moves(index) = computer.ToString()

                    ' Compute evaluation function for this move.
                    Dim moveVal As Integer = Minimax(0, False)

                    ' Undo the move
                    moves(index) = ""

                    ' If the value of the current move is more than the best value, update best
                    If moveVal > bestVal Then
                        bestMoveRow = i
                        bestMoveCol = j
                        bestVal = moveVal
                    End If
                End If
            Next
        Next

        Return (bestMoveRow, bestMoveCol)
    End Function

    Private Function MakeRandomMove() As String()
        Dim emptyIndices As New List(Of Integer)
        For i As Integer = 0 To 8
            If moves(i) = "" Then
                emptyIndices.Add(i)
            End If
        Next
        If emptyIndices.Count > 0 Then
            Dim randomIndex As Integer = emptyIndices(rand.Next(emptyIndices.Count))
            moves(randomIndex) = computer.ToString()
        End If
        Return moves
    End Function

    Public Function ComputerMove() As String()
        Select Case difficulty
            Case "Easy"
                Return MakeRandomMove()
            Case "Normal"
                If rand.NextDouble() < 0.4 Then
                    Return MakeRandomMove()
                Else
                    Return MakeOptimalMove()
                End If
            Case "Difficult"
                If rand.NextDouble() < 0.3 Then
                    Return MakeRandomMove()
                Else
                    Return MakeOptimalMove()
                End If
            Case "Impossible"
                Return MakeOptimalMove()
            Case Else
                Return MakeOptimalMove()
        End Select
    End Function

    Private Function MakeOptimalMove() As String()
        Dim bestMove = FindBestMove()
        Dim index As Integer = bestMove.Item1 * 3 + bestMove.Item2
        moves(index) = computer.ToString()
        Return moves
    End Function

    Public Function HumanMove(row As Integer, col As Integer) As String()
        Dim index As Integer = row * 3 + col
        If moves(index) = "" Then
            moves(index) = human.ToString()
        End If
        Return moves
    End Function
End Class
