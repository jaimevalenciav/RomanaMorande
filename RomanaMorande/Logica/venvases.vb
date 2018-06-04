Public Class venvases
    Dim idenvase As Integer
    Dim nombreenvase As String
    Dim peso As Integer
    Dim activo As Boolean

    'setter y getter

    Public Property gidenvase
        Get
            Return idenvase
        End Get
        Set(ByVal value)
            idenvase = value

        End Set
    End Property

    Public Property gnombreenvase
        Get
            Return nombreenvase
        End Get
        Set(ByVal value)
            nombreenvase = value

        End Set
    End Property

    Public Property gpeso
        Get
            Return peso
        End Get
        Set(ByVal value)
            peso = value
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

    Public Sub New(ByVal idenvase As Integer, ByVal nomenvase As String, ByVal peso As Integer, ByVal activo As Boolean)
        gidenvase = idenvase
        gnombreenvase = nombreenvase
        gpeso = peso
        gactivo = activo

    End Sub
End Class
