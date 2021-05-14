Namespace MotoreTarsu.Oggetti
    <Serializable()> _
Public Class OggettoRataCalcolata
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoRataCalcolata contiene i dati completi della rata generata.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Dim _sCodiceCartella As String = ""
        Dim _sDataEmissione As String = ""
        Dim _sNumeroRata As String = ""
        Dim _sDescrizioneRata As String = ""
        Dim _nImportoRata As Double = 0
        Dim _sDataScadenza As String = ""
        Dim _sCodiceBollettino As String = ""
        Dim _sCodeline As String = ""
        Dim _sNumeroCC As String = ""
        Dim _sCodiceBarcode As String = ""

        Public Property CodiceCartella() As String
            Get
                Return _sCodiceCartella
            End Get

            Set(ByVal Value As String)
                _sCodiceCartella = Value
            End Set
        End Property

        Public Property DataEmissione() As String
            Get
                Return _sDataEmissione
            End Get

            Set(ByVal Value As String)
                _sDataEmissione = Value
            End Set
        End Property

        Public Property NumeroRata() As String
            Get
                Return _sNumeroRata
            End Get

            Set(ByVal Value As String)
                _sNumeroRata = Value
            End Set
        End Property

        Public Property DescrizioneRata() As String
            Get
                Return _sDescrizioneRata
            End Get

            Set(ByVal Value As String)
                _sDescrizioneRata = Value
            End Set
        End Property

        Public Property ImportoRata() As Double
            Get
                Return _nImportoRata
            End Get

            Set(ByVal Value As Double)
                _nImportoRata = Value
            End Set
        End Property

        Public Property DataScadenza() As String
            Get
                Return _sDataScadenza
            End Get

            Set(ByVal Value As String)
                _sDataScadenza = Value
            End Set
        End Property

        Public Property CodiceBollettino() As String
            Get
                Return _sCodiceBollettino
            End Get

            Set(ByVal Value As String)
                _sCodiceBollettino = Value
            End Set
        End Property

        Public Property Codeline() As String
            Get
                Return _sCodeline
            End Get

            Set(ByVal Value As String)
                _sCodeline = Value
            End Set
        End Property

        Public Property NumeroCC() As String
            Get
                Return _sNumeroCC
            End Get

            Set(ByVal Value As String)
                _sNumeroCC = Value
            End Set
        End Property
        '*** 20101014 - aggiunta gestione stampa barcode ***
        Public Property CodiceBarcode() As String
            Get
                Return _sCodiceBarcode
            End Get
            Set(ByVal Value As String)
                _sCodiceBarcode = Value
            End Set
        End Property
        '*********************************************
    End Class
End Namespace