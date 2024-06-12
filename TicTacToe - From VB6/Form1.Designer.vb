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
        TableLayoutPanel1 = New TableLayoutPanel()
        lbl7 = New Label()
        lbl6 = New Label()
        lbl5 = New Label()
        lbl4 = New Label()
        lbl1 = New Label()
        lbl3 = New Label()
        lbl2 = New Label()
        lbl8 = New Label()
        lbl0 = New Label()
        Button1 = New Button()
        chkComputerMovesFirst = New CheckBox()
        GroupBox1 = New GroupBox()
        lblComputerWins = New Label()
        GroupBox2 = New GroupBox()
        lblHumanWins = New Label()
        GroupBox3 = New GroupBox()
        lblCatsGames = New Label()
        rdoEasy = New RadioButton()
        rdoNormal = New RadioButton()
        rdoDifficult = New RadioButton()
        rdoImpossible = New RadioButton()
        lblCreator = New Label()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(lbl7, 1, 2)
        TableLayoutPanel1.Controls.Add(lbl6, 0, 2)
        TableLayoutPanel1.Controls.Add(lbl5, 2, 1)
        TableLayoutPanel1.Controls.Add(lbl4, 1, 1)
        TableLayoutPanel1.Controls.Add(lbl1, 1, 0)
        TableLayoutPanel1.Controls.Add(lbl3, 0, 1)
        TableLayoutPanel1.Controls.Add(lbl2, 2, 0)
        TableLayoutPanel1.Controls.Add(lbl8, 2, 2)
        TableLayoutPanel1.Controls.Add(lbl0, 0, 0)
        TableLayoutPanel1.ForeColor = SystemColors.AppWorkspace
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(129, 129)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' lbl7
        ' 
        lbl7.AutoSize = True
        lbl7.Dock = DockStyle.Fill
        lbl7.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl7.Location = New Point(46, 85)
        lbl7.Name = "lbl7"
        lbl7.Size = New Size(35, 43)
        lbl7.TabIndex = 15
        lbl7.Text = "O"
        lbl7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl6
        ' 
        lbl6.AutoSize = True
        lbl6.Dock = DockStyle.Fill
        lbl6.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl6.Location = New Point(4, 85)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(35, 43)
        lbl6.TabIndex = 14
        lbl6.Text = "X"
        lbl6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Dock = DockStyle.Fill
        lbl5.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl5.Location = New Point(88, 43)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(37, 41)
        lbl5.TabIndex = 13
        lbl5.Text = "O"
        lbl5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Dock = DockStyle.Fill
        lbl4.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl4.Location = New Point(46, 43)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(35, 41)
        lbl4.TabIndex = 12
        lbl4.Text = "X"
        lbl4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Dock = DockStyle.Fill
        lbl1.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl1.Location = New Point(46, 1)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(35, 41)
        lbl1.TabIndex = 11
        lbl1.Text = "O"
        lbl1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Dock = DockStyle.Fill
        lbl3.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl3.Location = New Point(4, 43)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(35, 41)
        lbl3.TabIndex = 10
        lbl3.Text = "O"
        lbl3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Dock = DockStyle.Fill
        lbl2.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl2.Location = New Point(88, 1)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(37, 41)
        lbl2.TabIndex = 9
        lbl2.Text = "X"
        lbl2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl8
        ' 
        lbl8.AutoSize = True
        lbl8.Dock = DockStyle.Fill
        lbl8.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl8.Location = New Point(88, 85)
        lbl8.Name = "lbl8"
        lbl8.Size = New Size(37, 43)
        lbl8.TabIndex = 8
        lbl8.Text = "X"
        lbl8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl0
        ' 
        lbl0.AutoSize = True
        lbl0.Dock = DockStyle.Fill
        lbl0.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lbl0.Location = New Point(4, 1)
        lbl0.Name = "lbl0"
        lbl0.Size = New Size(35, 41)
        lbl0.TabIndex = 0
        lbl0.Text = "X"
        lbl0.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 138)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 30)
        Button1.TabIndex = 1
        Button1.Text = "Start Game"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' chkComputerMovesFirst
        ' 
        chkComputerMovesFirst.AutoSize = True
        chkComputerMovesFirst.Location = New Point(84, 145)
        chkComputerMovesFirst.Name = "chkComputerMovesFirst"
        chkComputerMovesFirst.Size = New Size(143, 19)
        chkComputerMovesFirst.TabIndex = 2
        chkComputerMovesFirst.Text = "Computer Moves First"
        chkComputerMovesFirst.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblComputerWins)
        GroupBox1.Location = New Point(138, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(108, 42)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Computer Wins"
        ' 
        ' lblComputerWins
        ' 
        lblComputerWins.Dock = DockStyle.Fill
        lblComputerWins.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblComputerWins.ForeColor = Color.Magenta
        lblComputerWins.Location = New Point(3, 19)
        lblComputerWins.Name = "lblComputerWins"
        lblComputerWins.Size = New Size(102, 20)
        lblComputerWins.TabIndex = 0
        lblComputerWins.Text = "0"
        lblComputerWins.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblHumanWins)
        GroupBox2.Location = New Point(138, 48)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(108, 41)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Human Wins"
        ' 
        ' lblHumanWins
        ' 
        lblHumanWins.Dock = DockStyle.Fill
        lblHumanWins.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblHumanWins.ForeColor = Color.Magenta
        lblHumanWins.Location = New Point(3, 19)
        lblHumanWins.Name = "lblHumanWins"
        lblHumanWins.Size = New Size(102, 19)
        lblHumanWins.TabIndex = 1
        lblHumanWins.Text = "0"
        lblHumanWins.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lblCatsGames)
        GroupBox3.Location = New Point(138, 90)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(108, 42)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Cats Games"
        ' 
        ' lblCatsGames
        ' 
        lblCatsGames.Dock = DockStyle.Fill
        lblCatsGames.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblCatsGames.ForeColor = Color.Magenta
        lblCatsGames.Location = New Point(3, 19)
        lblCatsGames.Name = "lblCatsGames"
        lblCatsGames.Size = New Size(102, 20)
        lblCatsGames.TabIndex = 1
        lblCatsGames.Text = "0"
        lblCatsGames.TextAlign = ContentAlignment.TopCenter
        ' 
        ' rdoEasy
        ' 
        rdoEasy.AutoSize = True
        rdoEasy.Location = New Point(252, 3)
        rdoEasy.Name = "rdoEasy"
        rdoEasy.Size = New Size(48, 19)
        rdoEasy.TabIndex = 6
        rdoEasy.Text = "Easy"
        rdoEasy.UseVisualStyleBackColor = True
        ' 
        ' rdoNormal
        ' 
        rdoNormal.AutoSize = True
        rdoNormal.Location = New Point(252, 28)
        rdoNormal.Name = "rdoNormal"
        rdoNormal.Size = New Size(65, 19)
        rdoNormal.TabIndex = 7
        rdoNormal.Text = "Normal"
        rdoNormal.UseVisualStyleBackColor = True
        ' 
        ' rdoDifficult
        ' 
        rdoDifficult.AutoSize = True
        rdoDifficult.Location = New Point(252, 53)
        rdoDifficult.Name = "rdoDifficult"
        rdoDifficult.Size = New Size(67, 19)
        rdoDifficult.TabIndex = 8
        rdoDifficult.Text = "Difficult"
        rdoDifficult.UseVisualStyleBackColor = True
        ' 
        ' rdoImpossible
        ' 
        rdoImpossible.AutoSize = True
        rdoImpossible.Checked = True
        rdoImpossible.Location = New Point(252, 78)
        rdoImpossible.Name = "rdoImpossible"
        rdoImpossible.Size = New Size(82, 19)
        rdoImpossible.TabIndex = 9
        rdoImpossible.TabStop = True
        rdoImpossible.Text = "Impossible"
        rdoImpossible.UseVisualStyleBackColor = True
        ' 
        ' lblCreator
        ' 
        lblCreator.BorderStyle = BorderStyle.FixedSingle
        lblCreator.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblCreator.ForeColor = Color.Magenta
        lblCreator.Location = New Point(252, 100)
        lblCreator.Name = "lblCreator"
        lblCreator.Size = New Size(94, 68)
        lblCreator.TabIndex = 10
        lblCreator.Text = "Tic Tac Toe in Visual Basic" & vbCrLf & "by Terry Olsen tolsen64@" & vbCrLf & "hotmail.com"
        lblCreator.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.HotTrack
        ClientSize = New Size(348, 172)
        Controls.Add(lblCreator)
        Controls.Add(rdoImpossible)
        Controls.Add(rdoDifficult)
        Controls.Add(rdoNormal)
        Controls.Add(rdoEasy)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(chkComputerMovesFirst)
        Controls.Add(Button1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Tic Tac Toe - By Terry R. Olsen"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents chkComputerMovesFirst As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdoEasy As RadioButton
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents rdoDifficult As RadioButton
    Friend WithEvents rdoImpossible As RadioButton
    Friend WithEvents lblCreator As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl8 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lblComputerWins As Label
    Friend WithEvents lblHumanWins As Label
    Friend WithEvents lblCatsGames As Label

End Class
