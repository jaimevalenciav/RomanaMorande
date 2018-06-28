Public Class vcontratos
    Dim idcontrato As Integer
    Dim numcontrato As Integer
    Dim idproveedor As Integer
    Dim vigente As Integer

    'setter y getter
    Public Property gidcontrato
        Get
            Return idcontrato
        End Get
        Set(ByVal value)
            idcontrato = value

        End Set
    End Property

    Public Property gnumcontrato
        Get
            Return numcontrato
        End Get
        Set(ByVal value)
            numcontrato = value

        End Set
    End Property

    Public Property gidproveedor
        Get
            Return idproveedor
        End Get
        Set(ByVal value)
            idproveedor = value

        End Set
    End Property

    Public Property gvigente
        Get
            Return vigente
        End Get
        Set(ByVal value)
            vigente = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idcontrato As Integer, ByVal numcontrato As Integer, ByVal idproveedor As Integer, ByVal vigente As Boolean)
        gidcontrato = idcontrato
        gnumcontrato = numcontrato
        gidproveedor = idproveedor
        gvigente = vigente

    End Sub
End Class
