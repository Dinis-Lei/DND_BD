﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GameTitle = New System.Windows.Forms.TextBox()
        Me.DMName = New System.Windows.Forms.TextBox()
        Me.StartDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EdChar = New System.Windows.Forms.Button()
        Me.AddChar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Lvl = New System.Windows.Forms.TextBox()
        Me.Classesss = New System.Windows.Forms.ListBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.AddClassToChar = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AddCharacter = New System.Windows.Forms.Button()
        Me.EditCharacter = New System.Windows.Forms.Button()
        Me.CharItems = New System.Windows.Forms.ListBox()
        Me.CharClasses = New System.Windows.Forms.ListBox()
        Me.CharLevel = New System.Windows.Forms.TextBox()
        Me.CharName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChaMod = New System.Windows.Forms.TextBox()
        Me.WisMod = New System.Windows.Forms.TextBox()
        Me.intMod = New System.Windows.Forms.TextBox()
        Me.ConMod = New System.Windows.Forms.TextBox()
        Me.DexMod = New System.Windows.Forms.TextBox()
        Me.StrMod = New System.Windows.Forms.TextBox()
        Me.CharCha = New System.Windows.Forms.TextBox()
        Me.CharWis = New System.Windows.Forms.TextBox()
        Me.CharInt = New System.Windows.Forms.TextBox()
        Me.CharCon = New System.Windows.Forms.TextBox()
        Me.CharDex = New System.Windows.Forms.TextBox()
        Me.CharStr = New System.Windows.Forms.TextBox()
        Me.PlayerCharacters = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PlayerName = New System.Windows.Forms.TextBox()
        Me.PlayerID = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RangeAsc = New System.Windows.Forms.CheckBox()
        Me.RangeDesc = New System.Windows.Forms.CheckBox()
        Me.LevelAsc = New System.Windows.Forms.CheckBox()
        Me.LevelDesc = New System.Windows.Forms.CheckBox()
        Me.SpellInfo = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.RangeFilter = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SpellList = New System.Windows.Forms.ListBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LevelFilter = New System.Windows.Forms.TextBox()
        Me.ClassFilter = New System.Windows.Forms.TextBox()
        Me.SpellName = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(667, 318)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 22)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(581, 318)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(0, 15)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(204, 319)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(210, 111)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(538, 199)
        Me.ListBox2.TabIndex = 3
        '
        'GameTitle
        '
        Me.GameTitle.Location = New System.Drawing.Point(210, 35)
        Me.GameTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GameTitle.Name = "GameTitle"
        Me.GameTitle.Size = New System.Drawing.Size(338, 23)
        Me.GameTitle.TabIndex = 4
        '
        'DMName
        '
        Me.DMName.Location = New System.Drawing.Point(554, 35)
        Me.DMName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DMName.Name = "DMName"
        Me.DMName.Size = New System.Drawing.Size(194, 23)
        Me.DMName.TabIndex = 5
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(554, 77)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(194, 23)
        Me.StartDate.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Título"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dungeon Master"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(554, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Data de Começo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jogo"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(327, 319)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 22)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(415, 319)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 22)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Confirm"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(209, 111)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(538, 202)
        Me.CheckedListBox2.TabIndex = 14
        Me.CheckedListBox2.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 2)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(766, 377)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox4)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.StartDate)
        Me.TabPage1.Controls.Add(Me.CheckedListBox2)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Controls.Add(Me.GameTitle)
        Me.TabPage1.Controls.Add(Me.DMName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(758, 349)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Game Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.ItemHeight = 15
        Me.ListBox4.Location = New System.Drawing.Point(0, 14)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(204, 319)
        Me.ListBox4.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Dungeon Master"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 15)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Jogadores"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.EdChar)
        Me.TabPage2.Controls.Add(Me.AddChar)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Lvl)
        Me.TabPage2.Controls.Add(Me.Classesss)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.AddClassToChar)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.AddCharacter)
        Me.TabPage2.Controls.Add(Me.EditCharacter)
        Me.TabPage2.Controls.Add(Me.CharItems)
        Me.TabPage2.Controls.Add(Me.CharClasses)
        Me.TabPage2.Controls.Add(Me.CharLevel)
        Me.TabPage2.Controls.Add(Me.CharName)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ChaMod)
        Me.TabPage2.Controls.Add(Me.WisMod)
        Me.TabPage2.Controls.Add(Me.intMod)
        Me.TabPage2.Controls.Add(Me.ConMod)
        Me.TabPage2.Controls.Add(Me.DexMod)
        Me.TabPage2.Controls.Add(Me.StrMod)
        Me.TabPage2.Controls.Add(Me.CharCha)
        Me.TabPage2.Controls.Add(Me.CharWis)
        Me.TabPage2.Controls.Add(Me.CharInt)
        Me.TabPage2.Controls.Add(Me.CharCon)
        Me.TabPage2.Controls.Add(Me.CharDex)
        Me.TabPage2.Controls.Add(Me.CharStr)
        Me.TabPage2.Controls.Add(Me.PlayerCharacters)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.PlayerName)
        Me.TabPage2.Controls.Add(Me.PlayerID)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(758, 349)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Character Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EdChar
        '
        Me.EdChar.Location = New System.Drawing.Point(440, 247)
        Me.EdChar.Name = "EdChar"
        Me.EdChar.Size = New System.Drawing.Size(75, 23)
        Me.EdChar.TabIndex = 37
        Me.EdChar.Text = "Edit"
        Me.EdChar.UseVisualStyleBackColor = True
        '
        'AddChar
        '
        Me.AddChar.Location = New System.Drawing.Point(288, 313)
        Me.AddChar.Name = "AddChar"
        Me.AddChar.Size = New System.Drawing.Size(97, 23)
        Me.AddChar.TabIndex = 36
        Me.AddChar.Text = "Add Character"
        Me.AddChar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(679, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 15)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Level"
        '
        'Lvl
        '
        Me.Lvl.Location = New System.Drawing.Point(672, 47)
        Me.Lvl.Name = "Lvl"
        Me.Lvl.Size = New System.Drawing.Size(50, 23)
        Me.Lvl.TabIndex = 34
        '
        'Classesss
        '
        Me.Classesss.FormattingEnabled = True
        Me.Classesss.ItemHeight = 15
        Me.Classesss.Location = New System.Drawing.Point(536, 4)
        Me.Classesss.Name = "Classesss"
        Me.Classesss.Size = New System.Drawing.Size(120, 94)
        Me.Classesss.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(283, 59)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 15)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Name"
        '
        'AddClassToChar
        '
        Me.AddClassToChar.Location = New System.Drawing.Point(659, 76)
        Me.AddClassToChar.Name = "AddClassToChar"
        Me.AddClassToChar.Size = New System.Drawing.Size(75, 23)
        Me.AddClassToChar.TabIndex = 31
        Me.AddClassToChar.Text = "Add Class"
        Me.AddClassToChar.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(456, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 15)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Level"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(270, 20)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 29)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AddCharacter
        '
        Me.AddCharacter.Location = New System.Drawing.Point(707, 427)
        Me.AddCharacter.Name = "AddCharacter"
        Me.AddCharacter.Size = New System.Drawing.Size(82, 22)
        Me.AddCharacter.TabIndex = 28
        Me.AddCharacter.Text = "Add"
        Me.AddCharacter.UseVisualStyleBackColor = True
        '
        'EditCharacter
        '
        Me.EditCharacter.Location = New System.Drawing.Point(559, 427)
        Me.EditCharacter.Name = "EditCharacter"
        Me.EditCharacter.Size = New System.Drawing.Size(82, 22)
        Me.EditCharacter.TabIndex = 27
        Me.EditCharacter.Text = "Edit"
        Me.EditCharacter.UseVisualStyleBackColor = True
        '
        'CharItems
        '
        Me.CharItems.FormattingEnabled = True
        Me.CharItems.ItemHeight = 15
        Me.CharItems.Location = New System.Drawing.Point(536, 158)
        Me.CharItems.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharItems.Name = "CharItems"
        Me.CharItems.Size = New System.Drawing.Size(198, 184)
        Me.CharItems.TabIndex = 26
        '
        'CharClasses
        '
        Me.CharClasses.FormattingEnabled = True
        Me.CharClasses.ItemHeight = 15
        Me.CharClasses.Location = New System.Drawing.Point(536, 103)
        Me.CharClasses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharClasses.Name = "CharClasses"
        Me.CharClasses.Size = New System.Drawing.Size(198, 49)
        Me.CharClasses.TabIndex = 25
        '
        'CharLevel
        '
        Me.CharLevel.Location = New System.Drawing.Point(460, 72)
        Me.CharLevel.Name = "CharLevel"
        Me.CharLevel.Size = New System.Drawing.Size(30, 23)
        Me.CharLevel.TabIndex = 24
        '
        'CharName
        '
        Me.CharName.Location = New System.Drawing.Point(285, 72)
        Me.CharName.Name = "CharName"
        Me.CharName.Size = New System.Drawing.Size(168, 23)
        Me.CharName.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(318, 251)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(318, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Wis"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(318, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Int"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Con"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Dex"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Str"
        '
        'ChaMod
        '
        Me.ChaMod.Location = New System.Drawing.Point(392, 246)
        Me.ChaMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChaMod.Name = "ChaMod"
        Me.ChaMod.Size = New System.Drawing.Size(28, 23)
        Me.ChaMod.TabIndex = 16
        '
        'WisMod
        '
        Me.WisMod.Location = New System.Drawing.Point(392, 221)
        Me.WisMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.WisMod.Name = "WisMod"
        Me.WisMod.Size = New System.Drawing.Size(28, 23)
        Me.WisMod.TabIndex = 15
        '
        'intMod
        '
        Me.intMod.Location = New System.Drawing.Point(392, 196)
        Me.intMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.intMod.Name = "intMod"
        Me.intMod.Size = New System.Drawing.Size(28, 23)
        Me.intMod.TabIndex = 14
        '
        'ConMod
        '
        Me.ConMod.Location = New System.Drawing.Point(392, 171)
        Me.ConMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConMod.Name = "ConMod"
        Me.ConMod.Size = New System.Drawing.Size(28, 23)
        Me.ConMod.TabIndex = 13
        '
        'DexMod
        '
        Me.DexMod.Location = New System.Drawing.Point(392, 146)
        Me.DexMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DexMod.Name = "DexMod"
        Me.DexMod.Size = New System.Drawing.Size(28, 23)
        Me.DexMod.TabIndex = 12
        '
        'StrMod
        '
        Me.StrMod.Location = New System.Drawing.Point(392, 122)
        Me.StrMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StrMod.Name = "StrMod"
        Me.StrMod.Size = New System.Drawing.Size(28, 23)
        Me.StrMod.TabIndex = 11
        '
        'CharCha
        '
        Me.CharCha.Location = New System.Drawing.Point(357, 246)
        Me.CharCha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharCha.Name = "CharCha"
        Me.CharCha.Size = New System.Drawing.Size(28, 23)
        Me.CharCha.TabIndex = 10
        '
        'CharWis
        '
        Me.CharWis.Location = New System.Drawing.Point(357, 221)
        Me.CharWis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharWis.Name = "CharWis"
        Me.CharWis.Size = New System.Drawing.Size(28, 23)
        Me.CharWis.TabIndex = 9
        '
        'CharInt
        '
        Me.CharInt.Location = New System.Drawing.Point(357, 196)
        Me.CharInt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharInt.Name = "CharInt"
        Me.CharInt.Size = New System.Drawing.Size(28, 23)
        Me.CharInt.TabIndex = 8
        '
        'CharCon
        '
        Me.CharCon.Location = New System.Drawing.Point(357, 171)
        Me.CharCon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharCon.Name = "CharCon"
        Me.CharCon.Size = New System.Drawing.Size(28, 23)
        Me.CharCon.TabIndex = 7
        '
        'CharDex
        '
        Me.CharDex.Location = New System.Drawing.Point(357, 146)
        Me.CharDex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharDex.Name = "CharDex"
        Me.CharDex.Size = New System.Drawing.Size(28, 23)
        Me.CharDex.TabIndex = 6
        '
        'CharStr
        '
        Me.CharStr.Location = New System.Drawing.Point(357, 122)
        Me.CharStr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CharStr.Name = "CharStr"
        Me.CharStr.Size = New System.Drawing.Size(28, 23)
        Me.CharStr.TabIndex = 5
        '
        'PlayerCharacters
        '
        Me.PlayerCharacters.FormattingEnabled = True
        Me.PlayerCharacters.ItemHeight = 15
        Me.PlayerCharacters.Location = New System.Drawing.Point(25, 63)
        Me.PlayerCharacters.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlayerCharacters.Name = "PlayerCharacters"
        Me.PlayerCharacters.Size = New System.Drawing.Size(255, 274)
        Me.PlayerCharacters.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ID"
        '
        'PlayerName
        '
        Me.PlayerName.Location = New System.Drawing.Point(89, 24)
        Me.PlayerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(168, 23)
        Me.PlayerName.TabIndex = 1
        '
        'PlayerID
        '
        Me.PlayerID.Location = New System.Drawing.Point(33, 24)
        Me.PlayerID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PlayerID.Name = "PlayerID"
        Me.PlayerID.Size = New System.Drawing.Size(30, 23)
        Me.PlayerID.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RangeAsc)
        Me.TabPage3.Controls.Add(Me.RangeDesc)
        Me.TabPage3.Controls.Add(Me.LevelAsc)
        Me.TabPage3.Controls.Add(Me.LevelDesc)
        Me.TabPage3.Controls.Add(Me.SpellInfo)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.RangeFilter)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.SpellList)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.LevelFilter)
        Me.TabPage3.Controls.Add(Me.ClassFilter)
        Me.TabPage3.Controls.Add(Me.SpellName)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(758, 349)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Spell Info"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RangeAsc
        '
        Me.RangeAsc.AutoSize = True
        Me.RangeAsc.Location = New System.Drawing.Point(709, 37)
        Me.RangeAsc.Name = "RangeAsc"
        Me.RangeAsc.Size = New System.Drawing.Size(58, 24)
        Me.RangeAsc.TabIndex = 26
        Me.RangeAsc.Text = "ASC"
        Me.RangeAsc.UseVisualStyleBackColor = True
        '
        'RangeDesc
        '
        Me.RangeDesc.AutoSize = True
        Me.RangeDesc.Location = New System.Drawing.Point(709, 66)
        Me.RangeDesc.Name = "RangeDesc"
        Me.RangeDesc.Size = New System.Drawing.Size(67, 24)
        Me.RangeDesc.TabIndex = 27
        Me.RangeDesc.Text = "DESC"
        Me.RangeDesc.UseVisualStyleBackColor = True
        '
        'LevelAsc
        '
        Me.LevelAsc.AutoSize = True
        Me.LevelAsc.Location = New System.Drawing.Point(561, 37)
        Me.LevelAsc.Name = "LevelAsc"
        Me.LevelAsc.Size = New System.Drawing.Size(58, 24)
        Me.LevelAsc.TabIndex = 24
        Me.LevelAsc.Text = "ASC"
        Me.LevelAsc.UseVisualStyleBackColor = True
        '
        'LevelDesc
        '
        Me.LevelDesc.AutoSize = True
        Me.LevelDesc.Location = New System.Drawing.Point(561, 66)
        Me.LevelDesc.Name = "LevelDesc"
        Me.LevelDesc.Size = New System.Drawing.Size(67, 24)
        Me.LevelDesc.TabIndex = 25
        Me.LevelDesc.Text = "DESC"
        Me.LevelDesc.UseVisualStyleBackColor = True
        '
        'SpellInfo
        '
        Me.SpellInfo.Location = New System.Drawing.Point(92, 294)
        Me.SpellInfo.Name = "SpellInfo"
        Me.SpellInfo.Size = New System.Drawing.Size(678, 120)
        Me.SpellInfo.TabIndex = 17
        Me.SpellInfo.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(652, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 20)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Range"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(512, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Level"
        '
        'RangeFilter
        '
        Me.RangeFilter.Location = New System.Drawing.Point(652, 47)
        Me.RangeFilter.Name = "RangeFilter"
        Me.RangeFilter.Size = New System.Drawing.Size(45, 23)
        Me.RangeFilter.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(369, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 15)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Classe"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(92, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Name"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SpellList
        '
        Me.SpellList.FormattingEnabled = True
        Me.SpellList.ItemHeight = 20
        Me.SpellList.Location = New System.Drawing.Point(92, 144)
        Me.SpellList.Name = "SpellList"
        Me.SpellList.Size = New System.Drawing.Size(678, 104)
        Me.SpellList.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(592, 82)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 22)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LevelFilter
        '
        Me.LevelFilter.Location = New System.Drawing.Point(512, 47)
        Me.LevelFilter.Name = "LevelFilter"
        Me.LevelFilter.Size = New System.Drawing.Size(38, 23)
        Me.LevelFilter.TabIndex = 2
        '
        'ClassFilter
        '
        Me.ClassFilter.Location = New System.Drawing.Point(369, 47)
        Me.ClassFilter.Name = "ClassFilter"
        Me.ClassFilter.Size = New System.Drawing.Size(115, 23)
        Me.ClassFilter.TabIndex = 1
        '
        'SpellName
        '
        Me.SpellName.Location = New System.Drawing.Point(92, 47)
        Me.SpellName.Name = "SpellName"
        Me.SpellName.Size = New System.Drawing.Size(259, 27)
        Me.SpellName.TabIndex = 0
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 376)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GameForm"
        Me.Text = "Cancel"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GameTitle As TextBox
    Friend WithEvents DMName As TextBox
    Friend WithEvents StartDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents PersonName As TextBox
    Friend WithEvents PlayerID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ChaMod As TextBox
    Friend WithEvents WisMod As TextBox
    Friend WithEvents intMod As TextBox
    Friend WithEvents ConMod As TextBox
    Friend WithEvents e As TextBox
    Friend WithEvents StrMod As TextBox
    Friend WithEvents CharCha As TextBox
    Friend WithEvents CharWis As TextBox
    Friend WithEvents CharInt As TextBox
    Friend WithEvents CharCon As TextBox
    Friend WithEvents CharDex As TextBox
    Friend WithEvents CharStr As TextBox
    Friend WithEvents PlayerCharacters As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EditCharacter As Button
    Friend WithEvents CharItems As ListBox
    Friend WithEvents CharClasses As ListBox
    Friend WithEvents CharLevel As TextBox
    Friend WithEvents CharName As TextBox
    Friend WithEvents AddCharacter As Button
    Friend WithEvents DexMod As TextBox
    Friend WithEvents JogadorID As TextBox
    Friend WithEvents PlayerName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RangeFilter As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents SpellList As ListBox
    Friend WithEvents Button5 As Button
    Friend WithEvents LevelFilter As TextBox
    Friend WithEvents ClassFilter As TextBox
    Friend WithEvents SpellName As TextBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents SpellInfo As RichTextBox
    Friend WithEvents LevelAsc As CheckBox
    Friend WithEvents LevelDesc As CheckBox
    Friend WithEvents RangeAsc As CheckBox
    Friend WithEvents RangeDesc As CheckBox
End Class
