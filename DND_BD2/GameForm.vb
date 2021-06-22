
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class GameForm
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    'Game Tab
    Dim currentGame As Integer = -1
    Dim currentDM As Integer
    Dim adding As Boolean = False
    Dim editing As Boolean = False
    Dim deleting As Boolean = False
    'Tab2
    Dim currentPlayer As Integer = -1
    Dim currentChar As Integer = -1
    Dim edditingChar As Boolean = False
    Dim addingChar As Boolean = False
    Dim deletingChar As Boolean = False



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentGame = ListBox1.SelectedItem.GameID
            ShowGame()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Game Tab
        GameTitle.ReadOnly = True
        DMName.ReadOnly = True
        StartDate.ReadOnly = True
        Label14.Visible = False
        ListBox4.Visible = False
        'Char Tab
        NormalInterface()

        '' Change this line for your database
        CN = New SqlConnection("Server = tcp:mednat.ieeta.pt\SQLSERVER,8101; Database =  p4g5 ; UID = p4g5; PWD =  ola123adeus321LEI")

        CMD = New SqlCommand
        CMD.Connection = CN

        'Comando: Informação do jogo e personagens que participam
        'CMD.CommandText = "SELECT * FROM DND.Jogo JOIN DND.DM ON DND.Jogo.idDM = DND.DM.idJDM JOIN DND.Joga ON DND.Jogo.idJogo = DND.Joga.idJogo JOIN DND.Jogador ON DND.Joga.idJogador = DND.Jogador.idJogador"
        CMD.CommandText = "SELECT * FROM dbo.DND_Jogo"

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim Game As New Game
            Game.GameID = RDR.Item("idJogo")
            Game.GameName = RDR.Item("titulo")
            Game.StartDate = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("dataComeco")), "", RDR.Item("dataComeco")))
            Game.idDM = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("idDM")), "", RDR.Item("idDM")))
            ListBox1.Items.Add(Game)
        End While
        CN.Close()
        RDR.Close()
        currentGame = -1
        ShowGame()

        CMD.CommandText = "SELECT * FROM dbo.DND_Participante"
        CMD.CommandType = CommandType.Text
        CN.Open()
        RDR = CMD.ExecuteReader
        ListBox4.Items.Clear()
        CheckedListBox2.Items.Clear()
        While RDR.Read
            Dim part As New Participante
            part.ID = RDR.Item("idParticipante")
            part.Name = RDR.Item("nomeParticipante")
            ListBox4.Items.Add(part)
            CheckedListBox2.Items.Add(part)
        End While
        CN.Close()
        RDR.Close()
        currentDM = 0

        CMD.CommandText = "SELECT nome FROM DND_Classe"
        CMD.CommandType = CommandType.Text
        CN.Open()
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim part As New Participante
            Classesss.Items.Add(RDR.Item("nome"))
        End While
        CN.Close()
        RDR.Close()

        CMD.CommandText = "SELECT nome FROM DND_Raca"
        CMD.CommandType = CommandType.Text
        CN.Open()
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim part As New Participante
            ListBox3.Items.Add(RDR.Item("nome"))
        End While
        CN.Close()
        RDR.Close()
    End Sub

    Sub EditingGame()
        If currentGame < 0 Then Exit Sub
        Dim game As New Game
        game = CType(ListBox1.SelectedItem, Game)
        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "SELECT TOP 1 nomeParticipante FROM DND_Participante WHERE idParticipante = @idDM"
        CMD.CommandType = CommandType.Text
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idDM", SqlDbType.Int).Value = Convert.ToInt32(game.idDM)

        Dim RDR As SqlDataReader
        CN.Open()
        RDR = CMD.ExecuteReader
        While RDR.Read
            Dim name As String
            name = RDR.Item("nomeParticipante")
            DMName.Text = name
        End While
        CN.Close()
        RDR.Close()

        For Each part As Participante In ListBox2.Items
            CheckedListBox2.SetItemChecked(part.ID, True)
        Next
    End Sub

    Sub ShowGame()
        If ListBox1.Items.Count = 0 Or currentGame < 0 Then Exit Sub
        Dim game As New Game
        game = CType(ListBox1.SelectedItem, Game)
        'Debug.Print(currentGame)
        GameTitle.Text = game.GameName
        DMName.Text = game.idDM
        StartDate.Text = Format(game.StartDate, "short Date")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "getGameDetails"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idJogo", SqlDbType.Int).Value = Convert.ToInt32(game.GameID)
        CMD.Parameters.Add("@idDM", SqlDbType.Int).Value = Convert.ToInt32(game.idDM)
        CMD.Parameters.Add("@DMName", SqlDbType.VarChar, 30)
        CMD.Parameters("@DMName").Direction = ParameterDirection.Output

        'CN.Open()
        'CMD.ExecuteNonQuery()
        'CN.Close()
        'Dim parameter

        CN.Open()
        Dim RDR As SqlDataReader

        RDR = CMD.ExecuteReader
        ListBox2.Items.Clear()

        While RDR.Read
            Dim name As String = RDR.Item("nomeParticipante")
            Dim id As String = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("idParticipante")), "", RDR.Item("idParticipante")))
            Dim part As New Participante
            part.ID = id
            part.Name = name
            ListBox2.Items.Add(part)
        End While
        RDR.Close()
        Dim str As String = CStr(CMD.Parameters("@DMName").Value)
        DMName.Text = str

        CN.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adding = True
        EnableAddInterface()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        deleting = True
        EnableDeleteInterface()
    End Sub

    Sub EnableReadInterface()
        GameTitle.Text = ""
        DMName.Text = ""
        StartDate.Text = ""
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1
            CheckedListBox2.SetItemChecked(i, False)
        Next
        Button10.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Visible = False
        Button4.Visible = False
        ListBox4.Visible = False
        CheckedListBox2.Visible = False
        ListBox1.Visible = True
        ListBox2.Visible = True
        Label14.Visible = False
        Label4.Visible = True
        GameTitle.ReadOnly = True
        ListBox1.Enabled = True
        ShowGame()
    End Sub

    Sub EnableAddInterface()
        GameTitle.Text = ""
        DMName.Text = ""
        StartDate.Text = Format(Today, "short Date")
        Button10.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Visible = True
        Button4.Visible = True
        ListBox4.Visible = True
        CheckedListBox2.Visible = True
        ListBox1.Visible = False
        ListBox2.Visible = False
        Label14.Visible = True
        Label4.Visible = False
        GameTitle.ReadOnly = False
    End Sub

    Sub EnableDeleteInterface()
        EnableReadInterface()
        ListBox1.Enabled = False
        Button10.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Visible = True
        Button4.Visible = True
    End Sub

    Sub EnableEditInterface()
        DMName.Text = ""
        Button10.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Visible = True
        Button4.Visible = True
        ListBox4.Visible = True
        CheckedListBox2.Visible = True
        ListBox1.Visible = False
        ListBox2.Visible = False
        Label14.Visible = True
        Label4.Visible = False
        GameTitle.ReadOnly = False
        EditingGame()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Cancel Button
        adding = False
        deleting = False
        editing = False
        EnableReadInterface()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Confirm Button (Available for all interfaces)
        If adding Then
            If CheckedListBox2.CheckedItems.Count > 6 Then
                MsgBox("You cannot add more than 6 players to a game!")
            Else
                SaveGame()
            End If
        ElseIf deleting Then
            DeleteGame()
        ElseIf editing Then
            EditGame()
        End If
        adding = False
        deleting = False
        editing = False
    End Sub

    Private Function SaveGame()
        Dim game As New Game
        Try
            game.GameID = 0
            game.GameName = GameTitle.Text
            game.StartDate = StartDate.Text
            game.idDM = DMName.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmitGame(game)
            ListBox1.Items.Add(game)
            For Each part As Participante In CheckedListBox2.CheckedItems
                SubmitPlayerToGame(game, part)
            Next
            adding = False
        Else
            'Should never not be adding when calling this function
        End If

        EnableReadInterface()

        Return True
    End Function

    Private Function DeleteGame()
        CMD.CommandText = "deleteGame"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idJogo", SqlDbType.Int).Value = Convert.ToInt32(currentGame)
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to remove game in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try

        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        currentGame = -1

        EnableReadInterface()
        ListBox2.Items.Clear()

        Return True
    End Function

    Private Function EditGame()
        CMD.CommandText = "updateGame"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idJogo", SqlDbType.Int).Value = Convert.ToInt32(currentGame)
        CMD.Parameters.Add("@idDM", SqlDbType.Int).Value = Convert.ToInt32(currentDM)
        CMD.Parameters.Add("@titulo", SqlDbType.VarChar, 64).Value = GameTitle.Text
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to edit game in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try

        Debug.Print("Deleted Participants:")
        For Each part As Participante In ListBox2.Items ' Check previous participants
            If Not CheckedListBox2.CheckedItems.Contains(part) Then
                Debug.Print(part.ToString())
                CMD.CommandText = "deletePlayerFromGame"
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.Clear()
                CMD.Parameters.Add("@idJogo", SqlDbType.Int).Value = Convert.ToInt32(currentGame)
                CMD.Parameters.Add("@idJogador", SqlDbType.Int).Value = Convert.ToInt32(part.ID)
                CN.Open()

                Try
                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Failed to update game players in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
                Finally
                    CN.Close()
                End Try
            End If
        Next

        Debug.Print("Added Participants:")
        For Each part As Participante In CheckedListBox2.CheckedItems 'Check new participants
            If Not ListBox2.Items.Contains(part) Then
                Debug.Print(part.ToString())
                CMD.CommandText = "addPlayerToGame"
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.Clear()
                CMD.Parameters.Add("@idGame", SqlDbType.Int).Value = Convert.ToInt32(currentGame)
                CMD.Parameters.Add("@idPlayer", SqlDbType.Int).Value = Convert.ToInt32(part.ID)
                CN.Open()

                Try
                    CMD.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Failed to update game players in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
                Finally
                    CN.Close()
                End Try
            End If
        Next

        EnableReadInterface()
        ListBox2.Items.Clear()
        ShowGame()

        Return True
    End Function

    Private Sub SubmitGame(ByVal G As Game)
        CMD.CommandText = "insertGame"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idDM", SqlDbType.Int).Value = Convert.ToInt32(G.idDM)
        CMD.Parameters.Add("@dataComeco", SqlDbType.Date).Value = Convert.ToDateTime(G.StartDate)
        CMD.Parameters.Add("@titulo", SqlDbType.VarChar, 64).Value = G.GameName
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update game in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try

        CN.Close()
        CMD.CommandText = "SELECT TOP 1 * FROM DND_Jogo ORDER BY idJogo DESC"
        CMD.CommandType = CommandType.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        While RDR.Read
            G.GameID = RDR.Item("idJogo")
            G.GameName = RDR.Item("titulo")
        End While
        CN.Close()
    End Sub

    Private Sub SubmitPlayerToGame(ByVal G As Game, ByVal P As Participante)
        CMD.CommandText = "addPlayerToGame"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idGame", SqlDbType.Int).Value = Convert.ToInt32(G.GameID)
        CMD.Parameters.Add("@idPlayer", SqlDbType.Int).Value = Convert.ToInt32(P.ID)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update game in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        If ListBox4.SelectedIndex > -1 Then
            currentDM = ListBox4.SelectedItem.ID
            DMName.Text = currentDM.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        editing = True
        EnableEditInterface()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RefreshTab2()
    End Sub

    Private Sub RefreshTab2()
        PlayerCharacters.Items.Clear()
        Dim id
        Try
            id = Convert.ToInt32(PlayerID.Text)

        Catch
            MessageBox.Show("Error Please Insert an Integer in field")
            Exit Sub
        End Try
        Dim name = PlayerName.Text

        CMD.CommandText = "existsPlayer"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idP", SqlDbType.Int).Value = id
        CMD.Parameters.Add("@exists", SqlDbType.Int)
        CMD.Parameters("@exists").Direction = ParameterDirection.Output
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to verify id. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()

        Dim exists As Integer = CStr(CMD.Parameters("@exists").Value)
        If exists = 1 Then
            currentPlayer = id
        Else
            currentPlayer = -1
            currentChar = -1
        End If


        CMD.CommandText = "getPersonagens"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id)
        CMD.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = name
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()



        While RDR.Read
            Dim c = New Character
            c.ID = RDR.Item("id")
            c.Name = RDR.Item("nome")
            c.Nivel = RDR.Item("level")
            c.Str = RDR.Item("str")
            c.StrMod = RDR.Item("strMod")
            c.Dex = RDR.Item("dex")
            c.DexMod = RDR.Item("dexMod")
            c.Con = RDR.Item("con")
            c.ConMod = RDR.Item("conMod")
            c.Int = RDR.Item("int")
            c.IntMod = RDR.Item("intMod")
            c.Wis = RDR.Item("wis")
            c.WisMod = RDR.Item("wisMod")
            c.Cha = RDR.Item("cha")
            c.ChaMod = RDR.Item("chaMod")
            c.Raca = RDR.Item("nomeRaca")
            PlayerCharacters.Items.Add(c)


        End While

        CN.Close()
    End Sub

    Private Sub PlayerCharacters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerCharacters.SelectedIndexChanged
        If PlayerCharacters.SelectedIndex > -1 Then
            currentChar = PlayerCharacters.SelectedItem.ID
            showCharacter(PlayerCharacters.SelectedItem)
        End If
    End Sub

    Sub showCharacter(c As Character)
        clearCharFields()
        CharName.Text = c.Name
        CharLevel.Text = c.Nivel
        CharStr.Text = c.Str
        StrMod.Text = c.StrMod
        CharDex.Text = c.Dex
        DexMod.Text = c.DexMod
        CharCon.Text = c.Con
        ConMod.Text = c.ConMod
        CharInt.Text = c.Int
        intMod.Text = c.IntMod
        CharWis.Text = c.Wis
        WisMod.Text = c.WisMod
        CharCha.Text = c.Cha
        ChaMod.Text = c.ChaMod
        CharRace.Text = c.Raca

        CMD.CommandText = "getItems"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(c.ID)

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        While RDR.Read
            Dim itemName = RDR.Item("nome")
            CharItems.Items.Add(itemName)
        End While

        CN.Close()


        CMD.CommandText = "getClasses"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(c.ID)

        CN.Open()
        RDR = CMD.ExecuteReader()
        While RDR.Read
            Dim itemName = RDR.Item("nome")
            CharClasses.Items.Add(itemName)
        End While

        CN.Close()


    End Sub

    Sub clearCharFields()
        CharName.Text = ""
        CharLevel.Text = ""
        CharStr.Text = ""
        StrMod.Text = ""
        CharDex.Text = ""
        DexMod.Text = ""
        CharCon.Text = ""
        ConMod.Text = ""
        CharInt.Text = ""
        intMod.Text = ""
        CharWis.Text = ""
        WisMod.Text = ""
        CharCha.Text = ""
        ChaMod.Text = ""
        CharClasses.Items.Clear()
        CharItems.Items.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SpellList.Items.Clear()
        SpellInfo.Text = ""
        Dim sName = Nothing
        Dim sClass = Nothing
        Dim sNivel = Nothing
        Dim sRange = Nothing
        Dim flg1 = 0
        Dim flg2 = 0

        CMD.CommandText = "filterSpells"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        If (String.Compare(SpellName.Text, "") <> 0) Then
            sName = SpellName.Text
            CMD.Parameters.Add("@spellName", SqlDbType.VarChar, 15).Value = sName
        Else
            CMD.Parameters.Add("@spellName", SqlDbType.VarChar, 15).Value = DBNull.Value
        End If


        If (String.Compare(ClassFilter.Text, "") <> 0) Then
            sClass = ClassFilter.Text
            CMD.Parameters.Add("@nomeClasse", SqlDbType.VarChar, 15).Value = sClass
        Else
            CMD.Parameters.Add("@nomeClasse", SqlDbType.VarChar, 15).Value = DBNull.Value
        End If

        If (String.Compare(LevelFilter.Text, "") <> 0) Then
            sNivel = Convert.ToInt32(LevelFilter.Text)
            CMD.Parameters.Add("@nivel", SqlDbType.Int).Value = Convert.ToInt32(sNivel)
        Else
            CMD.Parameters.Add("@nivel", SqlDbType.Int).Value = DBNull.Value
        End If

        If (String.Compare(RangeFilter.Text, "") <> 0) Then
            sRange = Convert.ToInt32(RangeFilter.Text)
            CMD.Parameters.Add("@range", SqlDbType.Int).Value = Convert.ToInt32(sRange)
        Else
            CMD.Parameters.Add("@range", SqlDbType.Int).Value = DBNull.Value
        End If

        If LevelAsc.Checked = True Then
            flg1 = 1
        ElseIf LevelDesc.Checked = True Then
            flg1 = 2
        End If

        If RangeAsc.Checked = True Then
            flg2 = 1
        ElseIf RangeDesc.Checked = True Then
            flg2 = 2
        End If

        CMD.Parameters.Add("@flg1", SqlDbType.Int).Value = flg1
        CMD.Parameters.Add("@flg2", SqlDbType.Int).Value = flg2

        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        While RDR.Read
            Dim spell As New Spell
            spell.Name = RDR.Item("spellName")
            spell.ID = RDR.Item("idSpell")
            spell.Level = RDR.Item("nivel")
            spell.Range = RDR.Item("range")
            spell.TypeOfDamage = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("tipoDano")), "", RDR.Item("tipoDano")))
            spell.Classe = RDR.Item("classe")
            spell.FlavorText = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("flavorText")), "", RDR.Item("flavorText")))

            SpellList.Items.Add(spell)
        End While

        CN.Close()
    End Sub

    Private Sub SpellList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SpellList.SelectedIndexChanged
        SpellInfo.Text = SpellList.SelectedItem.getExpandedText()
    End Sub

    Private Sub LevelAsc_CheckedChanged(sender As Object, e As EventArgs) Handles LevelAsc.CheckedChanged
        If LevelAsc.Checked Then
            LevelDesc.Checked = False
        End If
    End Sub

    Private Sub LevelDesc_CheckedChanged(sender As Object, e As EventArgs) Handles LevelDesc.CheckedChanged
        If LevelDesc.Checked Then
            LevelAsc.Checked = False
        End If
    End Sub

    Private Sub RangeAsc_CheckedChanged(sender As Object, e As EventArgs) Handles RangeAsc.CheckedChanged
        If RangeAsc.Checked Then
            RangeDesc.Checked = False
        End If
    End Sub

    Private Sub RangeDesc_CheckedChanged(sender As Object, e As EventArgs) Handles RangeDesc.CheckedChanged
        If RangeDesc.Checked Then
            RangeAsc.Checked = False
        End If
    End Sub



    Sub EditInterfaceTab2()
        CharItems.Visible = False
        ListBox3.Visible = True
        StrMod.Enabled = False
        DexMod.Enabled = False
        ConMod.Enabled = False
        intMod.Enabled = False
        WisMod.Enabled = False
        ChaMod.Enabled = False
        EdChar.Enabled = False
        CharStr.Enabled = True
        CharInt.Enabled = True
        CharCha.Enabled = True
        CharCon.Enabled = True
        CharWis.Enabled = True
        CharDex.Enabled = True
        AddChar.Enabled = False
        CharName.Enabled = True
        PlayerCharacters.Enabled = False
        Button6.Enabled = False
        PlayerID.Enabled = False
        PlayerName.Enabled = False
        CharItems.Enabled = False
        Classesss.Visible = True
        Button8.Visible = True
        Button7.Visible = True
        AddClassToChar.Visible = False
        ListBox3.Visible = False
        Label22.Visible = False
        AddClassToChar.Visible = True
        Lvl.Visible = True
        Label21.Visible = True
        Button9.Enabled = False
    End Sub

    Sub AddInterface()
        clearCharFields()
        CharItems.Visible = False
        ListBox3.Visible = True
        StrMod.Enabled = False
        DexMod.Enabled = False
        ConMod.Enabled = False
        intMod.Enabled = False
        WisMod.Enabled = False
        ChaMod.Enabled = False
        EdChar.Enabled = False
        CharStr.Enabled = True
        CharInt.Enabled = True
        CharCha.Enabled = True
        CharCon.Enabled = True
        CharWis.Enabled = True
        CharDex.Enabled = True
        AddChar.Enabled = False
        CharName.Enabled = True
        PlayerCharacters.Enabled = False
        Button6.Enabled = False
        PlayerID.Enabled = False
        PlayerName.Enabled = False
        CharItems.Enabled = False
        Classesss.Visible = True
        Button8.Visible = True
        Button7.Visible = True
        AddClassToChar.Visible = False
        Button9.Enabled = False
    End Sub

    Sub NormalInterface()
        clearCharFields()
        CharItems.Visible = True
        Button9.Enabled = True
        ListBox3.Visible = False
        Label22.Visible = False
        CharRace.Enabled = False
        StrMod.Enabled = False
        DexMod.Enabled = False
        ConMod.Enabled = False
        intMod.Enabled = False
        WisMod.Enabled = False
        ChaMod.Enabled = False
        CharStr.Enabled = False
        CharInt.Enabled = False
        CharCha.Enabled = False
        CharCon.Enabled = False
        CharWis.Enabled = False
        CharDex.Enabled = False
        EdChar.Enabled = True
        AddChar.Enabled = True
        PlayerCharacters.Enabled = True
        Button6.Enabled = True
        PlayerID.Enabled = True
        PlayerName.Enabled = True
        CharItems.Enabled = False
        CharName.Enabled = False
        CharLevel.Enabled = False
        AddClassToChar.Enabled = True
        Classesss.Visible = False
        Lvl.Visible = False
        Label21.Visible = False
        AddClassToChar.Visible = False
        Button8.Visible = False
        Button7.Visible = False
    End Sub

    Sub DeleteInterface()
        PlayerCharacters.Enabled = False
        Button8.Visible = True
        Button7.Visible = True
        Button9.Enabled = False
        EdChar.Enabled = False
        AddChar.Enabled = False
    End Sub

    Private Sub AddChar_Click(sender As Object, e As EventArgs) Handles AddChar.Click
        If currentPlayer = -1 Then
            MsgBox("You must select a player to add the character to!")
            Exit Sub
        End If
        addingChar = True
        AddInterface()
    End Sub

    Private Sub EdChar_Click(sender As Object, e As EventArgs) Handles EdChar.Click
        If currentChar = -1 Then
            MsgBox("You must select a character to edit them!")
            Exit Sub
        End If
        edditingChar = True
        EditInterfaceTab2()
    End Sub

    Private Sub confirmWhileAdd()


        CMD.CommandText = "adicionarPersonagem"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        If CharName.Text.Length = 0 Then
            MsgBox("Specify Charname")
            Exit Sub
        End If
        CMD.Parameters.Add("@nome", SqlDbType.VarChar, 30).Value = CharName.Text
        Dim Str, Wis, Int, Con, Dex, Cha As Integer


        Try
            Str = Convert.ToInt32(CharStr.Text)
            Wis = Convert.ToInt32(CharWis.Text)
            Int = Convert.ToInt32(CharInt.Text)
            Con = Convert.ToInt32(CharCon.Text)
            Dex = Convert.ToInt32(CharDex.Text)
            Cha = Convert.ToInt32(CharCha.Text)
        Catch ex As Exception
            MsgBox("Stats are not integer values.")
            Exit Sub
        End Try

        CMD.Parameters.Add("@Str", SqlDbType.Int).Value = Str
        CMD.Parameters.Add("@Wis", SqlDbType.Int).Value = Wis
        CMD.Parameters.Add("@Cha", SqlDbType.Int).Value = Cha
        CMD.Parameters.Add("@Int", SqlDbType.Int).Value = Int
        CMD.Parameters.Add("@Con", SqlDbType.Int).Value = Con
        CMD.Parameters.Add("@Dex", SqlDbType.Int).Value = Dex

        If Classesss.SelectedItems.Count = 0 Then
            MsgBox("Please select a class.")
            Exit Sub
        End If

        CMD.Parameters.Add("@nomeC", SqlDbType.VarChar, 15).Value = Classesss.SelectedItem

        If ListBox3.SelectedItems.Count = 0 Then
            MsgBox("Please select a race.")
            Exit Sub
        End If
        CMD.Parameters.Add("@nomeR", SqlDbType.VarChar, 15).Value = ListBox3.SelectedItem
        CMD.Parameters.Add("@idParticipante", SqlDbType.Int).Value = currentPlayer
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add character to the database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try

    End Sub

    Private Sub edCharacter()
        Dim Str, Wis, Int, Con, Dex, Cha As Integer
        If CharName.Text = "" Then
            MsgBox("Invalid Character name!")
            Exit Sub
        End If
        Try
            Str = Convert.ToInt32(CharStr.Text)
            Wis = Convert.ToInt32(CharWis.Text)
            Int = Convert.ToInt32(CharInt.Text)
            Con = Convert.ToInt32(CharCon.Text)
            Dex = Convert.ToInt32(CharDex.Text)
            Cha = Convert.ToInt32(CharCha.Text)
        Catch ex As Exception
            MsgBox("Stats are not integer values.")
            Exit Sub
        End Try

        CMD.CommandText = "updatePersonagem"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@Str", SqlDbType.Int).Value = Str
        CMD.Parameters.Add("@Wis", SqlDbType.Int).Value = Wis
        CMD.Parameters.Add("@Cha", SqlDbType.Int).Value = Cha
        CMD.Parameters.Add("@Int", SqlDbType.Int).Value = Int
        CMD.Parameters.Add("@Con", SqlDbType.Int).Value = Con
        CMD.Parameters.Add("@Dex", SqlDbType.Int).Value = Dex
        CMD.Parameters.Add("@nome", SqlDbType.VarChar, 30).Value = CharName.Text
        CMD.Parameters.Add("@idP", SqlDbType.Int).Value = currentChar
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update character. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub delChar()

        CMD.CommandText = "deleteChar"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idPersonagem", SqlDbType.Int).Value = currentChar
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete character. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NormalInterface()
        addingChar = False
        edditingChar = False
        deletingChar = False
    End Sub

    Private Sub CharName_TextChanged(sender As Object, e As EventArgs) Handles CharName.TextChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Confirm button
        If addingChar Then
            confirmWhileAdd()
        ElseIf edditingChar Then
            edCharacter()
        ElseIf deletingChar Then
            delChar()
        End If
        RefreshTab2()
        NormalInterface()
        If PlayerCharacters.SelectedIndex > -1 Then
            showCharacter(PlayerCharacters.SelectedItem)
        End If
        addingChar = False
        edditingChar = False
        deletingChar = False
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        CharRace.Text = ListBox3.SelectedItem
    End Sub

    Private Sub AddClassToChar_Click(sender As Object, e As EventArgs) Handles AddClassToChar.Click
        If Classesss.SelectedItems.Count = 0 Then
            MsgBox("No selected class to add to character!")
            Exit Sub
        End If
        If Lvl.Text = "" Then
            MsgBox("No class level specified!")
            Exit Sub
        End If
        Dim nivel As Integer
        Try
            nivel = Convert.ToInt32(Lvl.Text)
        Catch ex As Exception
            MsgBox("Class level is not integer value.")
            Exit Sub
        End Try

        CMD.CommandText = "addClassToChar"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@nomeC", SqlDbType.VarChar, 15).Value = Classesss.SelectedItem
        CMD.Parameters.Add("@idP", SqlDbType.Int).Value = currentChar
        CMD.Parameters.Add("@nivel", SqlDbType.Int).Value = nivel
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add class to a character. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try


        If PlayerCharacters.SelectedIndex > -1 Then
            showCharacter(PlayerCharacters.SelectedItem)
        End If

        CMD.CommandText = "getPersonagemLvl"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@idP", SqlDbType.Int).Value = currentChar
        CMD.Parameters.Add("@lvl", SqlDbType.Int)
        CMD.Parameters("@lvl").Direction = ParameterDirection.Output
        CN.Open()

        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to calculate character level. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try


        Dim newLvl As Integer = CStr(CMD.Parameters("@lvl").Value)
        CharLevel.Text = newLvl.ToString()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If currentChar = -1 Then
            MsgBox("You must select a character to delete them!")
            Exit Sub
        End If
        deletingChar = True
        DeleteInterface()
    End Sub


End Class

