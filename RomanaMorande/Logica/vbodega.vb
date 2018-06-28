Public Class vbodega
    Dim idbodega As Integer
    Dim nombrebodega As String
    Dim codigo As String
    Dim estado As Integer

    'setter y getter

    Public Property gidbodega
        Get
            Return idbodega
        End Get
        Set(value)
            idbodega = value
        End Set
    End Property

    Public Property gnombrebodega
        Get
            Return nombrebodega
        End Get
        Set(value)
            nombrebodega = value
        End Set
    End Property

    Public Property gcodigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property

    Public Property gestado
        Get
            Return estado
        End Get
        Set(value)
            estado = value
        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idbodega As Integer, ByVal codigo As String, ByVal nombrebodega As String, ByVal estado As Integer)
        gidbodega = idbodega
        gcodigo = codigo
        gnombrebodega = nombrebodega
        gestado = estado
    End Sub

End Class
