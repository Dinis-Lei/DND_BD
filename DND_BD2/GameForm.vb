
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
        '' Change this line for our database
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

    Sub EnableReadInterface()
        GameTitle.Text = ""
        DMName.Text = ""
        StartDate.Text = ""
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1
            CheckedListBox2.SetItemChecked(i, False)
        Next
        Button6.Enabled = True
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
        Button6.Enabled = False
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
        Button6.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Visible = True
        Button4.Visible = True
    End Sub

    Sub EnableEditInterface()
        DMName.Text = ""
        Button6.Enabled = False
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
        CMD.CommandText = "SELECT TOP 1 idJogo FROM DND_Jogo ORDER BY idJogo DESC"
        CMD.CommandType = CommandType.Text
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        While RDR.Read
            G.GameID = RDR.Item("idJogo")
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

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
End Class

