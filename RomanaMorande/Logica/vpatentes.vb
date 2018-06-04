Public Class vpatentes
    Dim idpatente As Integer
    Dim nombretransportista As String

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

    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idtransportista As Integer, ByVal nombretransportista As String)
        gidtransportista = idtransportista
        gnombretransportista = gnombretransportista

    End Sub


End Class
