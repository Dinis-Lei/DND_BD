Public Class Character
    Dim _id As Int32
    Dim _name As String
    Dim _str As Int32
    Dim _strMod As Int32
    Dim _dex As Int32
    Dim _dexMod As Int32
    Dim _con As Int32
    Dim _conMod As Int32
    Dim _int As Int32
    Dim _intMod As Int32
    Dim _wis As Int32
    Dim _wisMod As Int32
    Dim _cha As Int32
    Dim _chaMod As Int32
    Dim _nivel As Int32
    Dim _raca As String

    Public Sub New()
        MyBase.New()
    End Sub

    Property Raca As String
        Get
            Return _raca
        End Get
        Set(value As String)
            _raca = value
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

    Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Property Str As Int32
        Get
            Return _str
        End Get
        Set(value As Int32)
            _str = value
        End Set
    End Property

    Property StrMod As Int32
        Get
            Return _strMod
        End Get
        Set(value As Int32)
            _strMod = value
        End Set
    End Property

    Property Dex As Int32
        Get
            Return _dex
        End Get
        Set(value As Int32)
            _dex = value
        End Set
    End Property

    Property DexMod As Int32
        Get
            Return _dexMod
        End Get
        Set(value As Int32)
            _dexMod = value
        End Set
    End Property

    Property Con As Int32
        Get
            Return _con
        End Get
        Set(value As Int32)
            _con = value
        End Set
    End Property

    Property ConMod As Int32
        Get
            Return _conMod
        End Get
        Set(value As Int32)
            _conMod = value
        End Set
    End Property

    Property Int As Int32
        Get
            Return _int
        End Get
        Set(value As Int32)
            _int = value
        End Set
    End Property

    Property IntMod As Int32
        Get
            Return _intMod
        End Get
        Set(value As Int32)
            _intMod = value
        End Set
    End Property

    Property Wis As Int32
        Get
            Return _wis
        End Get
        Set(value As Int32)
            _wis = value
        End Set
    End Property

    Property WisMod As Int32
        Get
            Return _wisMod
        End Get
        Set(value As Int32)
            _wisMod = value
        End Set
    End Property

    Property Cha As Int32
        Get
            Return _cha
        End Get
        Set(value As Int32)
            _cha = value
        End Set
    End Property

    Property ChaMod As Int32
        Get
            Return _chaMod
        End Get
        Set(value As Int32)
            _chaMod = value
        End Set
    End Property

    Property Nivel As Int32
        Get
            Return _nivel
        End Get
        Set(value As Int32)
            _nivel = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _id & "   " & _name & "   " & _nivel
    End Function

End Class
