<Serializable()> Public Class Game
    'Proprieties of a Game
    Private _gameID As String
    Private _gameName As String
    Private _startDate As String
    Private _idDM As String

    Public Sub New()
        MyBase.New()
    End Sub

    Property GameID As String
        Get
            Return _gameID
        End Get
        Set(value As String)
            _gameID = value
        End Set
    End Property

    Property GameName As String
        Get
            Return _gameName
        End Get
        Set(value As String)
            _gameName = value
        End Set
    End Property

    Property StartDate As String
        Get
            Return _startDate
        End Get
        Set(value As String)
            _startDate = value
        End Set
    End Property

    Property idDM As String
        Get
            Return _idDM
        End Get
        Set(value As String)
            _idDM = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _gameID & "   " & _gameName
    End Function

    Public Shared Widening Operator CType(v As Game) As ListBox
        Throw New NotImplementedException()
    End Operator
End Class
