Public Class vpatentevendimia
    Dim idvehiculo As Integer
    Dim patente As String
    Dim idtransportista As Integer
    Dim idtipovehiculo As Integer
    Dim tara As Integer
    Dim tipoenvase As Integer
    Dim cantenv As Integer

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

    Public Property gtipoenvase
        Get
            Return tipoenvase
        End Get
        Set(ByVal value)
            tipoenvase = value
        End Set
    End Property

    Public Property gcantenv
        Get
            Return cantenv
        End Get
        Set(ByVal value)
            cantenv = value
        End Set
    End Property

    'constructor

    Public Sub New()

    End Sub

    Public Sub New(ByVal idvehiculo As Integer, ByVal patente As String, ByVal idtransportista As Integer,
                   ByVal idtipovehiculo As Integer, ByVal tara As Integer, ByVal tipoenvase As Integer, ByVal cantenv As Integer)
        gidvehiculo = idvehiculo
        gpatente = patente
        gidtransportista = idtransportista
        gidtipovehiculo = idtipovehiculo
        gtara = tara
        gtipoenvase = tipoenvase
        gcantenv = cantenv
    End Sub
End Class
