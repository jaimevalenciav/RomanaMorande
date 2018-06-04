Public Class vpesajesindestareM
    Dim idpesaje As Integer
    Dim idsap As String
    Dim numguia As Integer
    Dim idvehiculo As Integer
    'Dim fechacreacion As Date
    Dim fechapesajein As Date
    'Dim horapesajein As Date
    Dim fechapesajeout As Date
    'Dim horapesajeout As Date
    Dim pesajein1 As Integer
    Dim pesajein2 As Integer
    Dim pesajein3 As Integer
    Dim pesajein4 As Integer
    Dim pesajeout1 As Integer
    Dim pesajeout2 As Integer
    Dim pesajeout3 As Integer
    Dim pesajeout4 As Integer
    Dim pesajetara As Integer
    Dim pesajebruto As Integer
    Dim pesajeneto As Integer
    Dim pesaje As Integer
    Dim tipopesaje As Integer
    Dim observaciones As String
    Dim estadopesaje As Integer
    Dim visible As Integer
    Dim taracont As Integer
    Dim vgm As Integer

    'setter y getter
    Public Property gvisible
        Get
            Return visible
        End Get
        Set(ByVal value)
            visible = value

        End Set
    End Property
    Public Property gestadopesaje
        Get
            Return estadopesaje
        End Get
        Set(ByVal value)
            estadopesaje = value

        End Set
    End Property
    Public Property gobservaciones
        Get
            Return observaciones
        End Get
        Set(ByVal value)
            observaciones = value

        End Set
    End Property
    Public Property gtipopesaje
        Get
            Return tipopesaje
        End Get
        Set(ByVal value)
            tipopesaje = value

        End Set
    End Property
    Public Property gpesaje
        Get
            Return pesaje
        End Get
        Set(ByVal value)
            pesaje = value

        End Set
    End Property
    Public Property gpesajeneto
        Get
            Return pesajeneto
        End Get
        Set(ByVal value)
            pesajeneto = value

        End Set
    End Property
    Public Property gpesajebruto
        Get
            Return pesajebruto
        End Get
        Set(ByVal value)
            pesajebruto = value

        End Set
    End Property
    Public Property gpesajetara
        Get
            Return pesajetara
        End Get
        Set(ByVal value)
            pesajetara = value

        End Set
    End Property
    Public Property gpesajeout4
        Get
            Return pesajeout4
        End Get
        Set(ByVal value)
            pesajeout4 = value

        End Set
    End Property
    Public Property gpesajeout3
        Get
            Return pesajeout3
        End Get
        Set(ByVal value)
            pesajeout3 = value

        End Set
    End Property
    Public Property gpesajeout2
        Get
            Return pesajeout2
        End Get
        Set(ByVal value)
            pesajeout2 = value

        End Set
    End Property
    Public Property gpesajeout1
        Get
            Return pesajeout1
        End Get
        Set(ByVal value)
            pesajeout1 = value

        End Set
    End Property

    Public Property gpesajein4
        Get
            Return pesajein4
        End Get
        Set(ByVal value)
            pesajein4 = value

        End Set
    End Property
    Public Property gpesajein3
        Get
            Return pesajein3
        End Get
        Set(ByVal value)
            pesajein3 = value

        End Set
    End Property
    Public Property gpesajein2
        Get
            Return pesajein2
        End Get
        Set(ByVal value)
            pesajein2 = value

        End Set
    End Property
    Public Property gpesajein1
        Get
            Return pesajein1
        End Get
        Set(ByVal value)
            pesajein1 = value

        End Set
    End Property
    'Public Property ghorapesajeout
    'Get
    'Return horapesajeout
    'End Get
    'Set(ByVal value)
    '        horapesajeout = value
    '
    'End Set
    'End Property

    Public Property gfechapesajeout
        Get
            Return fechapesajeout
        End Get
        Set(ByVal value)
            fechapesajeout = value

        End Set
    End Property
    'Public Property ghorapesajein
    'Get
    'Return horapesajein
    'End Get
    'Set(ByVal value)
    '        horapesajein = value
    '
    'End Set
    'End Property

    Public Property gfechapesajein
        Get
            Return fechapesajein
        End Get
        Set(ByVal value)
            fechapesajein = value

        End Set
    End Property

    'Public Property gfechacreacion
    'Get
    'Return fechacreacion
    'End Get
    'Set(ByVal value)
    '       fechacreacion = value
    '
    'End Set
    'End Property

    Public Property gidvehiculo
        Get
            Return idvehiculo
        End Get
        Set(ByVal value)
            idvehiculo = value

        End Set
    End Property

    Public Property gnumguia
        Get
            Return numguia
        End Get
        Set(ByVal value)
            numguia = value

        End Set
    End Property
    Public Property gidpesaje
        Get
            Return idpesaje
        End Get
        Set(ByVal value)
            idpesaje = value

        End Set
    End Property

    Public Property gidsap
        Get
            Return idsap
        End Get
        Set(ByVal value)
            idsap = value

        End Set
    End Property

    Public Property gtaracont
        Get
            Return taracont
        End Get
        Set(ByVal value)
            taracont = value

        End Set
    End Property

    Public Property gvgm
        Get
            Return vgm
        End Get
        Set(ByVal value)
            vgm = value

        End Set
    End Property



    'constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal idtransportista As Integer, ByVal nombretransportista As String, ByVal fechapesajein As Date,
                   ByVal fechapesajeout As Date, ByVal pesajein1 As Integer, ByVal pesajein2 As Integer, ByVal idsap As String, ByVal numguia As Integer,
                   ByVal pesajein3 As Integer, ByVal pesajein4 As Integer, ByVal pesajeout1 As Integer, ByVal pesajeout2 As Integer, ByVal pesajeout3 As Integer,
                   ByVal pesajeout4 As Integer, ByVal pesajetara As Integer, ByVal pesajebruto As Integer, ByVal pesajeneto As Integer, ByVal pesaje As Integer,
                   ByVal tipopesaje As Integer, ByVal observaciones As String, ByVal estadopesaje As Integer, ByVal visible As Integer, ByVal taracont As Integer,
                   ByVal vgm As Integer)

        gidsap = idsap
        gnumguia = numguia
        gidvehiculo = idvehiculo
        'gfechacreacion = fechacreacion
        gfechapesajein = fechapesajein
        'ghorapesajein = horapesajein
        gfechapesajeout = fechapesajeout
        'ghorapesajeout = horapesajeout
        gpesajein1 = pesajein1
        gpesajein2 = pesajein2
        gpesajein3 = pesajein3
        gpesajein4 = pesajein4
        gpesajeout1 = pesajeout1
        gpesajeout2 = pesajeout2
        gpesajeout3 = pesajeout3
        gpesajeout4 = pesajeout4
        gpesajetara = pesajetara
        gpesajebruto = pesajebruto
        gpesajeneto = pesajeneto
        gpesaje = pesaje
        gtipopesaje = tipopesaje
        gobservaciones = observaciones
        gestadopesaje = estadopesaje
        gvisible = visible
        gtaracont = taracont
        gvgm = vgm

    End Sub


End Class
