Public Class vtransportistas
    Dim idtransportista As Integer
    Dim nombretransportista As String
    Dim rut As String

    'setter y getter

    Public Property gidtransportista
        Get
            Return idtransportista
        End Get
        Set(ByVal value)
            idtransportista = value

        End Set
    End Property

    Public Property gnombretransportista
        Get
            Return nombretransportista
        End Get
        Set(ByVal value)
            nombretransportista = value

        End Set
    End Property

    Public Property grut
        Get
            Return rut
        End Get
        Set(ByVal value)
            rut = value

        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idtransportista As Integer, ByVal rut As String, ByVal nombretransportista As String)
        gidtransportista = idtransportista
        grut = rut
        gnombretransportista = nombretransportista


    End Sub


End Class
