
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class GameForm
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentGame As Integer
    Dim adding As Boolean = False

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentGame = ListBox1.SelectedIndex
            ShowGame()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GameTitle.ReadOnly = True
        DMName.ReadOnly = True
        StartDate.ReadOnly = True
        Label14.Visible = False
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
        currentGame = 0
        ShowGame()

        CMD.CommandText = "SELECT * FROM dbo.DND_Participante"
        CMD.CommandType = CommandType.Text
        CN.Open()
        RDR = CMD.ExecuteReader
        CheckedListBox1.Items.Clear()
        CheckedListBox2.Items.Clear()
        While RDR.Read
            Dim part As New Participante
            part.ID = RDR.Item("idParticipante")
            part.Name = RDR.Item("nomeParticipante")
            CheckedListBox1.Items.Add(part)
            CheckedListBox2.Items.Add(part)
        End While
        CN.Close()
    End Sub

    Sub ShowGame()
        If ListBox1.Items.Count = 0 Or currentGame < 0 Then Exit Sub
        Dim game As New Game
        game = CType(ListBox1.Items.Item(currentGame), Game)
        GameTitle.Text = game.GameName
        DMName.Text = game.idDM
        'TextBox3.Text = game.StartDate
        StartDate.Text = Format(game.StartDate, "short Date")

        CMD = New SqlCommand
        CMD.Connection = CN
        CMD.CommandText = "getGameDetails"
        CMD.CommandType = CommandType.StoredProcedure
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
        'RDR = CMD.ExecuteNonQuery()
        ListBox2.Items.Clear()

        While RDR.Read
            Dim name As String = RDR.Item("nomeParticipante")
            Dim id As String = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("idParticipante")), "", RDR.Item("idParticipante")))
            ListBox2.Items.Add(id + "  " + name)
        End While
        RDR.Close()
        Dim str As String = CStr(CMD.Parameters("@DMName").Value)
        DMName.Text = str

        CN.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adding = True
        EnableAddInterface()
        'ClearFields()
        'ShowButtons()
        'UnlockControls()
        'ListBox1.Enabled = False
    End Sub

    'Sub ClearFields()
    '    GameTitle.Text = ""
    '    DMName.Text = ""
    '    StartDate.Text = ""
    '    ListBox2.Items.Clear()

    'End Sub

    'Sub ShowButtons()
    '    Button3.Visible = True
    '    Button4.Visible = True
    '    CheckedListBox1.Visible = True
    '    CheckedListBox2.Visible = True
    '    ListBox1.Visible = False
    '    ListBox2.Visible = False

    'End Sub

    'Sub UnlockControls()
    '    GameTitle.ReadOnly = False
    'End Sub

    Sub EnableAddInterface()
        GameTitle.Text = ""
        DMName.Text = ""
        StartDate.Text = Format(Today, "short Date")
        'ListBox2.Items.Clear()
        Button3.Visible = True
        Button4.Visible = True
        CheckedListBox1.Visible = True
        CheckedListBox2.Visible = True
        ListBox1.Visible = False
        ListBox2.Visible = False
        Label14.Visible = True
        Label4.Visible = False
        GameTitle.ReadOnly = False
        StartDate.ReadOnly = False
    End Sub

    Sub EnableReadInterface()
        GameTitle.Text = ""
        DMName.Text = ""
        StartDate.Text = ""
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1
            CheckedListBox2.SetItemChecked(i, False)
        Next
        Button3.Visible = False
        Button4.Visible = False
        CheckedListBox1.Visible = False
        CheckedListBox2.Visible = False
        ListBox1.Visible = True
        ListBox2.Visible = True
        Label14.Visible = False
        Label4.Visible = True
        GameTitle.ReadOnly = True
        ShowGame()
        'ListBox1.Enabled = True
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles GameTitle.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        adding = False
        EnableReadInterface()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click



        If CheckedListBox2.CheckedItems.Count > 6 Then
            'Error msg
        Else
            SaveGame()
        End If
    End Sub

    Private Function SaveGame()
        Dim game As New Game
        Try
            game.GameID = 0
            game.GameName = GameTitle.Text
            game.StartDate = StartDate.Text
            game.idDM = CheckedListBox1.CheckedItems.Item(0).ID.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'aaaa
        Button3.Visible = False
        Button4.Visible = False
        CheckedListBox1.Visible = False
        CheckedListBox2.Visible = False
        ListBox1.Visible = True
        ListBox2.Visible = True
        ListBox1.Enabled = True
        'aaaa

        If adding Then
            SubmitGame(game)
            ListBox1.Items.Add(game)
            adding = False

        Else
            'UpdateContact(contact)
            'ListBox1.Items(currentContact) = contact
        End If
        Return True
    End Function

    Private Sub SubmitGame(ByVal G As Game)
        CMD.CommandText = "INSERT DND_Jogo (idDM, dataComeco, titulo) " &
                          "VALUES (@idDM, @dataComeco, @titulo) "
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




    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        Dim item As String = e.ToString
        Dim index As Integer = CheckedListBox1.FindString(item)
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            If index <> i Then
                CheckedListBox1.SetItemChecked(i, False)
            End If
        Next
    End Sub
End Class

