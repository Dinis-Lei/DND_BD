
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class GameForm
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentGame As Integer

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
        currentGame = 0
        ShowGame()
    End Sub

    Sub ShowGame()
        If ListBox1.Items.Count = 0 Or currentGame < 0 Then Exit Sub
        Dim game As New Game
        game = CType(ListBox1.Items.Item(currentGame), Game)
        TextBox1.Text = game.GameName
        'TextBox2.Text = game.idDM
        'TextBox3.Text = game.StartDate
        TextBox3.Text = Format(game.StartDate, "short Date")

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


        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox2.Items.Clear()
        While RDR.Read
            Dim name As String = RDR.Item("nomeParticipante")
            Dim id As String = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("idParticipante")), "", RDR.Item("idParticipante")))
            ListBox2.Items.Add(id + "  " + name)
        End While
        Dim str As String = CMD.Parameters("@DMName").Value
        TextBox2.Text = str


        CN.Close()
    End Sub

End Class

