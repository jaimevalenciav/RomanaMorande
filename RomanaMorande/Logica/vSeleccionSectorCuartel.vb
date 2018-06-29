Public Class vSeleccionSectorCuartel
    Dim numcontrato As Integer
    Dim variedad As String

    Public Property gnumcontrato
        Get
            Return numcontrato
        End Get
        Set(ByVal value)
            numcontrato = value
        End Set
    End Property
    Public Property gvariedad
        Get
            Return variedad
        End Get
        Set(ByVal value)
            variedad = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal numcontrato As Integer, ByVal variedad As String)
        gnumcontrato = numcontrato
        gvariedad = variedad
    End Sub
End Class
