Public Class Spell
    Dim _id As Int32
    Dim _name As String
    Dim _typeOfDamage As String
    Dim _range As Int32
    Dim _level As Int32
    Dim _class As String
    Dim _flavorText As String

    Public Sub New()
        MyBase.New()
    End Sub

    Property ID As Int32
        Get
            Return _id
        End Get
        Set(value As Int32)
            _id = value
        End Set
    End Property

    Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Property TypeOfDamage As String
        Get
            Return _typeOfDamage
        End Get
        Set(value As String)
            _typeOfDamage = value
        End Set
    End Property

    Property Range As Int32
        Get
            Return _range
        End Get
        Set(value As Int32)
            _range = value
        End Set
    End Property

    Property Level As Int32
        Get
            Return _level
        End Get
        Set(value As Int32)
            _level = value
        End Set
    End Property

    Property Classe As String
        Get
            Return _class
        End Get
        Set(value As String)
            _class = value
        End Set
    End Property

    Property FlavorText As String
        Get
            Return _flavorText
        End Get
        Set(value As String)
            _flavorText = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return "ID: " & _id & " Name: " & _name
    End Function

    Public Function getExpandedText() As String
        Return "ID:" & _id & " Name: " & _name & " Level: " & _level & " Range: " & _range & vbCrLf & "Class: " & _class & " Type of Damage: " & _typeOfDamage & vbCrLf & _flavorText
    End Function

End Class
