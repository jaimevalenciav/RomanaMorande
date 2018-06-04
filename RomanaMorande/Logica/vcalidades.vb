Public Class vcalidades
    Dim idcalidad As Integer
    Dim nomcalidad As String
    Dim nomcorto As String
    Dim activo As Boolean

    'setter y getter

    Public Property gidcalidad
        Get
            Return idcalidad
        End Get
        Set(ByVal value)
            idcalidad = value

        End Set
    End Property

    Public Property gnomcalidad
        Get
            Return nomcalidad
        End Get
        Set(ByVal value)
            nomcalidad = value

        End Set
    End Property

    Public Property gnomcorto
        Get
            Return nomcorto
        End Get
        Set(ByVal value)
            nomcorto = value
        End Set

    End Property

    Public Property gactivo
        Get
            Return activo
        End Get
        Set(ByVal value)
            activo = value
        End Set

    End Property


    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idcalidad As Integer, ByVal nomcalidad As String, ByVal nomcorto As Integer, ByVal activo As Boolean)
        gidcalidad = idcalidad
        gnomcalidad = nomcalidad
        gnomcorto = nomcorto
        gactivo = activo

    End Sub
End Class
