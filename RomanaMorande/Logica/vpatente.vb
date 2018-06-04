Public Class vpatente
    Dim idvehiculo As Integer
    Dim patente As String
    Dim marca As String
    Dim idtransportista As Integer
    Dim idtipovehiculo As Integer
    Dim tara As Integer



    'setter y getter

    Public Property gidvehiculo
        Get
            Return idvehiculo
        End Get
        Set(ByVal value)
            idvehiculo = value

        End Set
    End Property

    Public Property gpatente
        Get
            Return patente
        End Get
        Set(ByVal value)
            patente = value

        End Set
    End Property

    Public Property gmarca
        Get
            Return marca
        End Get
        Set(ByVal value)
            marca = value

        End Set
    End Property

    Public Property gidtransportista
        Get
            Return idtransportista
        End Get
        Set(ByVal value)
            idtransportista = value

        End Set
    End Property

    Public Property gidtipovehiculo
        Get
            Return idtipovehiculo
        End Get
        Set(ByVal value)
            idtipovehiculo = value

        End Set
    End Property

    Public Property gtara
        Get
            Return tara
        End Get
        Set(ByVal value)
            tara = value

        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idvehiculo As Integer, ByVal patente As String, ByVal marca As String, ByVal idtransportista As Integer, ByVal idtipovehiculo As Integer, ByVal tara As Integer)
        gidvehiculo = idvehiculo
        gpatente = patente
        gmarca = marca
        gidtransportista = idtransportista
        gidtipovehiculo = idtipovehiculo
        gtara = tara

    End Sub


End Class
