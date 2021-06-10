Public Class Participante
    Dim _name As String
    Dim _id As Int32

    Public Sub New()
        MyBase.New()
    End Sub

    Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Property ID As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _id & "   " & _name
    End Function


End Class
