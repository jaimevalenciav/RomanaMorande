Public Class vpesajevendimia

    Dim idpesajev As Integer
    Dim aniovendimia As Integer
    Dim idsapv As String
    Dim idvehiculo As Integer
    Dim fechacreacion As Date
    Dim fechapesajein As Date
    Dim fechapesajeout As Date
    Dim pesajetara As Integer
    Dim pesajebruto As Integer
    Dim pesajeneto As Integer
    Dim observaciones As String
    Dim estadopesaje As Integer
    Dim visible As Integer
    Dim numguia As Integer
    Dim idbodega As Integer
    Dim idenvase As Integer
    Dim cantenvin As Integer
    Dim cantenout As Integer
    Dim diftaraenvases As Integer
    Dim tipocosecha As String
    Dim idcontrato As Integer
    Dim idcontratovariedad As Integer
    Dim sector As Integer
    Dim nomsector As String
    Dim cuartel As Integer
    Dim nomcuartel As String
    Dim subcuartel As Integer
    Dim nomsubcuartel As String
    Dim idcalidad As Integer
    Dim brix As Integer
    Dim densidad As Integer
    Dim temp As Integer
    Dim apb As Integer
    Dim porccastigo As Integer
    Dim kiloscastigo As Integer
    Dim anulado As Boolean
    Dim activo As Boolean

    'setter y getter

    Public Property gidpesajev
        Get
            Return idpesajev
        End Get
        Set(value)
            idpesajev = value
        End Set
    End Property

    Public Property ganiovendimia
        Get
            Return aniovendimia
        End Get
        Set(value)
            aniovendimia = value
        End Set
    End Property

    Public Property gidsapv
        Get
            Return idsapv
        End Get
        Set(value)
            idsapv = value
        End Set
    End Property

    Public Property gidvehiculo
        Get
            Return idvehiculo
        End Get
        Set(value)
            idvehiculo = value
        End Set
    End Property

    Public Property gfechacreacion
        Get
            Return fechacreacion
        End Get
        Set(value)
            fechacreacion = value
        End Set
    End Property

    Public Property gfechapesajein
        Get
            Return fechapesajein
        End Get
        Set(value)
            fechapesajein = value
        End Set
    End Property

    Public Property gfechapesajeout
        Get
            Return fechapesajeout
        End Get
        Set(value)
            fechapesajeout = value

        End Set
    End Property

    Public Property gpesajetara
        Get
            Return pesajetara
        End Get
        Set(value)
            pesajetara = value
        End Set
    End Property

    Public Property gpesajebruto
        Get
            Return pesajebruto
        End Get
        Set(value)
            pesajebruto = value
        End Set
    End Property

    Public Property gpesajeneto
        Get
            Return pesajeneto
        End Get
        Set(value)
            pesajeneto = value
        End Set
    End Property

    Public Property gobservaciones
        Get
            Return observaciones
        End Get
        Set(value)
            observaciones = value
        End Set
    End Property

    Public Property gestadopesaje
        Get
            Return estadopesaje
        End Get
        Set(value)
            estadopesaje = value
        End Set
    End Property

    Public Property gvisible
        Get
            Return visible
        End Get
        Set(value)
            visible = value
        End Set
    End Property

    Public Property gnumguia
        Get
            Return numguia
        End Get
        Set(value)
            numguia = value
        End Set
    End Property

    Public Property gidbodega
        Get
            Return idbodega
        End Get
        Set(value)
            idbodega = value
        End Set
    End Property

    Public Property gidenvase
        Get
            Return idenvase
        End Get
        Set(value)
            idenvase = value
        End Set
    End Property

    Public Property gcantenvin
        Get
            Return cantenvin
        End Get
        Set(value)
            cantenvin = value
        End Set
    End Property

    Public Property gcantenvout
        Get
            Return cantenout
        End Get
        Set(value)
            cantenout = value
        End Set
    End Property

    Public Property gdiftaraenvases
        Get
            Return diftaraenvases
        End Get
        Set(value)
            diftaraenvases = value
        End Set
    End Property

    Public Property gtipocosecha
        Get
            Return tipocosecha
        End Get
        Set(value)
            tipocosecha = value
        End Set
    End Property

    Public Property gidcontrato
        Get
            Return idcontrato
        End Get
        Set(value)
            idcontrato = value
        End Set
    End Property

    Public Property gidcontratovariedad
        Get
            Return idcontratovariedad
        End Get
        Set(value)
            idcontratovariedad = value
        End Set
    End Property

    Public Property gsector
        Get
            Return sector
        End Get
        Set(value)
            sector = value
        End Set
    End Property

    Public Property gnomsector
        Get
            Return nomsector
        End Get
        Set(value)
            nomsector = value
        End Set
    End Property

    Public Property gcuartel
        Get
            Return cuartel
        End Get
        Set(value)
            cuartel = value
        End Set
    End Property

    Public Property gnomcuartel
        Get
            Return nomcuartel
        End Get
        Set(value)
            nomcuartel = value
        End Set
    End Property

    Public Property gsubcuartel
        Get
            Return subcuartel
        End Get
        Set(value)
            subcuartel = value
        End Set
    End Property

    Public Property gnomsubcuartel
        Get
            Return nomsubcuartel
        End Get
        Set(value)
            nomsubcuartel = value

        End Set
    End Property

    Public Property gidcalidad
        Get
            Return idcalidad
        End Get
        Set(value)
            idcalidad = value
        End Set
    End Property

    Public Property gbrix
        Get
            Return brix
        End Get
        Set(value)
            brix = value
        End Set
    End Property

    Public Property gdensidad
        Get
            Return densidad
        End Get
        Set(value)
            densidad = value

        End Set
    End Property

    Public Property gtemp
        Get
            Return temp
        End Get
        Set(value)
            temp = value
        End Set
    End Property

    Public Property gapb
        Get
            Return apb
        End Get
        Set(value)
            apb = value
        End Set
    End Property

    Public Property gporccastigo
        Get
            Return porccastigo
        End Get
        Set(value)
            porccastigo = value

        End Set
    End Property

    Public Property gkiloscastigo
        Get
            Return kiloscastigo
        End Get
        Set(value)
            kiloscastigo = value
        End Set
    End Property

    Public Property ganulado
        Get
            Return anulado
        End Get
        Set(value)
            anulado = value
        End Set
    End Property

    Public Property gactivo
        Get
            Return activo
        End Get
        Set(value)
            activo = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(
                    ByVal idpesajev As Integer,
                    ByVal aniovendimia As Integer,
                    ByVal idsapv As String,
                    ByVal idvehiculo As Integer,
                    ByVal fechacreacion As Date,
                    ByVal fechapesajein As Date,
                    ByVal fechapesajeout As Date,
                    ByVal pesajetara As Integer,
                    ByVal pesajebruto As Integer,
                    ByVal pesajeneto As Integer,
                    ByVal observaciones As String,
                    ByVal estadopesaje As Integer,
                    ByVal visible As Integer,
                    ByVal numguia As Integer,
                    ByVal idbodega As Integer,
                    ByVal idenvase As Integer,
                    ByVal cantenvin As Integer,
                    ByVal cantenout As Integer,
                    ByVal diftaraenvases As Integer,
                    ByVal tipocosecha As String,
                    ByVal idcontrato As Integer,
                    ByVal idcontratovariedad As Integer,
                    ByVal sector As Integer,
                    ByVal nomsector As String,
                    ByVal cuartel As Integer,
                    ByVal nomcuartel As String,
                    ByVal subcuartel As Integer,
                    ByVal nomsubcuartel As String,
                    ByVal idcalidad As Integer,
                    ByVal brix As Integer,
                    ByVal densidad As Integer,
                    ByVal temp As Integer,
                    ByVal apb As Integer,
                    ByVal porccastigo As Integer,
                    ByVal kiloscastigo As Integer,
                    ByVal anulado As Boolean,
                    ByVal activo As Boolean)

        gidpesajev = idpesajev
        ganiovendimia = aniovendimia
        gidsapv = idsapv
        gidvehiculo = idvehiculo
        gfechacreacion = fechacreacion
        gfechapesajein = fechapesajein
        gfechapesajeout = fechapesajeout
        gpesajetara = pesajetara
        gpesajebruto = pesajebruto
        gpesajeneto = pesajeneto
        gobservaciones = observaciones
        gestadopesaje = estadopesaje
        gvisible = visible
        gnumguia = numguia
        gidbodega = idbodega
        gidenvase = idenvase
        gcantenvin = cantenvin
        gcantenvout = cantenout
        gdiftaraenvases = diftaraenvases
        gtipocosecha = tipocosecha
        gidcontrato = idcontrato
        gidcontratovariedad = idcontratovariedad
        gsector = sector
        gnomsector = nomsector
        gcuartel = cuartel
        gnomcuartel = nomcuartel
        gsubcuartel = subcuartel
        gnomsubcuartel = nomsubcuartel
        gidcalidad = idcalidad
        gbrix = brix
        gdensidad = densidad
        gtemp = temp
        gapb = apb
        gporccastigo = porccastigo
        gkiloscastigo = kiloscastigo
        ganulado = anulado
        gactivo = activo

    End Sub

    '########## FALTA TERMINAR SETTER Y GETTER, y CREAR LOS CONTRUCTORES ###########
End Class
