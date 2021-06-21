<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Button1.Location = New System.Drawing.Point(762, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(664, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(0, 20)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(233, 424)
        Me.ListBox1.TabIndex = 2
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(240, 148)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(614, 264)
        Me.ListBox2.TabIndex = 3
        '
        'GameTitle
        '
        Me.GameTitle.Location = New System.Drawing.Point(240, 47)
        Me.GameTitle.Name = "GameTitle"
        Me.GameTitle.Size = New System.Drawing.Size(386, 27)
        Me.GameTitle.TabIndex = 4
        '
        'DMName
        '
        Me.DMName.Location = New System.Drawing.Point(633, 47)
        Me.DMName.Name = "DMName"
        Me.DMName.Size = New System.Drawing.Size(221, 27)
        Me.DMName.TabIndex = 5
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(633, 103)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(221, 27)
        Me.StartDate.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Título"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(633, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dungeon Master"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Data de Começo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jogo"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(374, 425)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(474, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Confirm"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(239, 148)
        Me.CheckedListBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(614, 268)
        Me.CheckedListBox2.TabIndex = 14
        Me.CheckedListBox2.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(875, 503)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(867, 470)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.ItemHeight = 20
        Me.ListBox4.Location = New System.Drawing.Point(0, 19)
        Me.ListBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(233, 424)
        Me.ListBox4.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 20)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Dungeon Master"
        Me.Label14.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(240, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Jogadores"
        '
        'TabPage2
        '
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(867, 470)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(299, 31)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 39)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AddCharacter
        '
        Me.AddCharacter.Location = New System.Drawing.Point(808, 569)
        Me.AddCharacter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddCharacter.Name = "AddCharacter"
        Me.AddCharacter.Size = New System.Drawing.Size(94, 29)
        Me.AddCharacter.TabIndex = 28
        Me.AddCharacter.Text = "Add"
        Me.AddCharacter.UseVisualStyleBackColor = True
        '
        'EditCharacter
        '
        Me.EditCharacter.Location = New System.Drawing.Point(639, 569)
        Me.EditCharacter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EditCharacter.Name = "EditCharacter"
        Me.EditCharacter.Size = New System.Drawing.Size(94, 29)
        Me.EditCharacter.TabIndex = 27
        Me.EditCharacter.Text = "Edit"
        Me.EditCharacter.UseVisualStyleBackColor = True
        '
        'CharItems
        '
        Me.CharItems.FormattingEnabled = True
        Me.CharItems.ItemHeight = 20
        Me.CharItems.Location = New System.Drawing.Point(594, 135)
        Me.CharItems.Name = "CharItems"
        Me.CharItems.Size = New System.Drawing.Size(226, 244)
        Me.CharItems.TabIndex = 26
        '
        'CharClasses
        '
        Me.CharClasses.FormattingEnabled = True
        Me.CharClasses.ItemHeight = 20
        Me.CharClasses.Location = New System.Drawing.Point(612, 43)
        Me.CharClasses.Name = "CharClasses"
        Me.CharClasses.Size = New System.Drawing.Size(226, 64)
        Me.CharClasses.TabIndex = 25
        '
        'CharLevel
        '
        Me.CharLevel.Location = New System.Drawing.Point(402, 89)
        Me.CharLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CharLevel.Name = "CharLevel"
        Me.CharLevel.Size = New System.Drawing.Size(34, 27)
        Me.CharLevel.TabIndex = 24
        '
        'CharName
        '
        Me.CharName.Location = New System.Drawing.Point(402, 43)
        Me.CharName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CharName.Name = "CharName"
        Me.CharName.Size = New System.Drawing.Size(191, 27)
        Me.CharName.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(418, 337)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 20)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Cha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(418, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 20)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Wis"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(418, 271)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Int"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(418, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Con"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Dex"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(418, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Str"
        '
        'ChaMod
        '
        Me.ChaMod.Location = New System.Drawing.Point(503, 331)
        Me.ChaMod.Name = "ChaMod"
        Me.ChaMod.Size = New System.Drawing.Size(31, 27)
        Me.ChaMod.TabIndex = 16
        '
        'WisMod
        '
        Me.WisMod.Location = New System.Drawing.Point(503, 297)
        Me.WisMod.Name = "WisMod"
        Me.WisMod.Size = New System.Drawing.Size(31, 27)
        Me.WisMod.TabIndex = 15
        '
        'intMod
        '
        Me.intMod.Location = New System.Drawing.Point(503, 264)
        Me.intMod.Name = "intMod"
        Me.intMod.Size = New System.Drawing.Size(31, 27)
        Me.intMod.TabIndex = 14
        '
        'ConMod
        '
        Me.ConMod.Location = New System.Drawing.Point(503, 231)
        Me.ConMod.Name = "ConMod"
        Me.ConMod.Size = New System.Drawing.Size(31, 27)
        Me.ConMod.TabIndex = 13
        '
        'DexMod
        '
        Me.DexMod.Location = New System.Drawing.Point(503, 197)
        Me.DexMod.Name = "DexMod"
        Me.DexMod.Size = New System.Drawing.Size(31, 27)
        Me.DexMod.TabIndex = 12
        '
        'StrMod
        '
        Me.StrMod.Location = New System.Drawing.Point(503, 165)
        Me.StrMod.Name = "StrMod"
        Me.StrMod.Size = New System.Drawing.Size(31, 27)
        Me.StrMod.TabIndex = 11
        '
        'CharCha
        '
        Me.CharCha.Location = New System.Drawing.Point(463, 331)
        Me.CharCha.Name = "CharCha"
        Me.CharCha.Size = New System.Drawing.Size(31, 27)
        Me.CharCha.TabIndex = 10
        '
        'CharWis
        '
        Me.CharWis.Location = New System.Drawing.Point(463, 297)
        Me.CharWis.Name = "CharWis"
        Me.CharWis.Size = New System.Drawing.Size(31, 27)
        Me.CharWis.TabIndex = 9
        '
        'CharInt
        '
        Me.CharInt.Location = New System.Drawing.Point(463, 264)
        Me.CharInt.Name = "CharInt"
        Me.CharInt.Size = New System.Drawing.Size(31, 27)
        Me.CharInt.TabIndex = 8
        '
        'CharCon
        '
        Me.CharCon.Location = New System.Drawing.Point(463, 231)
        Me.CharCon.Name = "CharCon"
        Me.CharCon.Size = New System.Drawing.Size(31, 27)
        Me.CharCon.TabIndex = 7
        '
        'CharDex
        '
        Me.CharDex.Location = New System.Drawing.Point(463, 197)
        Me.CharDex.Name = "CharDex"
        Me.CharDex.Size = New System.Drawing.Size(31, 27)
        Me.CharDex.TabIndex = 6
        '
        'CharStr
        '
        Me.CharStr.Location = New System.Drawing.Point(463, 165)
        Me.CharStr.Name = "CharStr"
        Me.CharStr.Size = New System.Drawing.Size(31, 27)
        Me.CharStr.TabIndex = 5
        '
        'PlayerCharacters
        '
        Me.PlayerCharacters.FormattingEnabled = True
        Me.PlayerCharacters.ItemHeight = 20
        Me.PlayerCharacters.Location = New System.Drawing.Point(38, 89)
        Me.PlayerCharacters.Name = "PlayerCharacters"
        Me.PlayerCharacters.Size = New System.Drawing.Size(291, 424)
        Me.PlayerCharacters.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ID"
        '
        'PlayerName
        '
        Me.PlayerName.Location = New System.Drawing.Point(102, 32)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(191, 27)
        Me.PlayerName.TabIndex = 1
        '
        'PlayerID
        '
        Me.PlayerID.Location = New System.Drawing.Point(38, 32)
        Me.PlayerID.Name = "PlayerID"
        Me.PlayerID.Size = New System.Drawing.Size(34, 27)
        Me.PlayerID.TabIndex = 0
        '
        'TabPage3
        '
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(867, 470)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        Me.Label18.Location = New System.Drawing.Point(713, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 20)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Range"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(639, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 20)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Level"
        '
        'RangeFilter
        '
        Me.RangeFilter.Location = New System.Drawing.Point(713, 47)
        Me.RangeFilter.Name = "RangeFilter"
        Me.RangeFilter.Size = New System.Drawing.Size(51, 27)
        Me.RangeFilter.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(479, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 20)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Classe"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(91, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 20)
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
        Me.Button5.Location = New System.Drawing.Point(676, 109)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 29)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LevelFilter
        '
        Me.LevelFilter.Location = New System.Drawing.Point(639, 47)
        Me.LevelFilter.Name = "LevelFilter"
        Me.LevelFilter.Size = New System.Drawing.Size(43, 27)
        Me.LevelFilter.TabIndex = 2
        '
        'ClassFilter
        '
        Me.ClassFilter.Location = New System.Drawing.Point(479, 47)
        Me.ClassFilter.Name = "ClassFilter"
        Me.ClassFilter.Size = New System.Drawing.Size(131, 27)
        Me.ClassFilter.TabIndex = 1
        '
        'SpellName
        '
        Me.SpellName.Location = New System.Drawing.Point(91, 47)
        Me.SpellName.Name = "SpellName"
        Me.SpellName.Size = New System.Drawing.Size(337, 27)
        Me.SpellName.TabIndex = 0
        '
        'GameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 501)
        Me.Controls.Add(Me.TabControl1)
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
End Class
