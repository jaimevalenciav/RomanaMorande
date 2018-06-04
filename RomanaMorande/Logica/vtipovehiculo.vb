Public Class vtipovehiculo
    Dim idtipovehiculo As Integer
    Dim nombrevehiculo As String

    'setter y getter

    Public Property gidtipovehiculo
        Get
            Return idtipovehiculo
        End Get
        Set(ByVal value)
            idtipovehiculo = value

        End Set
    End Property

    Public Property gnombrevehiculo
        Get
            Return nombrevehiculo
        End Get
        Set(ByVal value)
            nombrevehiculo = value

        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idtipovehiculo As Integer, ByVal nombrevehiculo As String)
        gidtipovehiculo = idtipovehiculo
        gnombrevehiculo = nombrevehiculo

    End Sub


End Class
