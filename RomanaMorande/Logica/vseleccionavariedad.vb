Public Class vseleccionavariedad
    Dim numcontrato As Integer

    Public Property gnumcontrato
        Get
            Return numcontrato
        End Get
        Set(ByVal value)
            numcontrato = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal numcontrato As Integer)
        gnumcontrato = numcontrato
    End Sub
End Class
