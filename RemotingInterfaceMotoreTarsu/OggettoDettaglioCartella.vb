Namespace MotoreTarsu.Oggetti

    <Serializable()> _
Public Class OggettoDettaglioCartella
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoDettaglioCartella contiene i dati completi del dettaglio per anno della cartella generato.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Dim _nIdCartella As Integer = -1
        Dim _sCodiceCartella As String = ""
        Dim _sidEnte As String = ""
        Dim _sDataEmissione As String = ""
        Dim _sAnnoRuolo As String = ""
        Dim _IdVoce As Integer = -1
        Dim _sCodiceCapitolo As String = ""
        Dim _nImportoVoce As Double = 0
        Dim _DescrVoce As String = ""
        Dim _nIdContribuente As Integer = -1
        Dim _nIdFlusso As Integer = -1

        Public Property IdCartella() As Integer
            Get
                Return _nIdCartella
            End Get

            Set(ByVal Value As Integer)
                _nIdCartella = Value
            End Set
        End Property

        Public Property CodiceCartella() As String
            Get
                Return _sCodiceCartella
            End Get

            Set(ByVal Value As String)
                _sCodiceCartella = Value
            End Set
        End Property

        Public Property idEnte() As String
            Get
                Return _sidEnte
            End Get

            Set(ByVal Value As String)
                _sidEnte = Value
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

        Public Property AnnoRuolo() As String
            Get
                Return _sAnnoRuolo
            End Get

            Set(ByVal Value As String)
                _sAnnoRuolo = Value
            End Set
        End Property

        Public Property IdVoce() As Integer
            Get
                Return _IdVoce
            End Get

            Set(ByVal Value As Integer)
                _IdVoce = Value
            End Set
        End Property

        Public Property CodiceCapitolo() As String
            Get
                Return _sCodiceCapitolo
            End Get

            Set(ByVal Value As String)
                _sCodiceCapitolo = Value
            End Set
        End Property

        Public Property ImportoVoce() As Double
            Get
                Return _nImportoVoce
            End Get

            Set(ByVal Value As Double)
                _nImportoVoce = Value
            End Set
        End Property

        Public Property DescrizioneVoce() As String
            Get
                Return _DescrVoce
            End Get

            Set(ByVal Value As String)
                _DescrVoce = Value
            End Set
        End Property

        Public Property IdContribuente() As Integer
            Get
                Return _nIdContribuente
            End Get

            Set(ByVal Value As Integer)
                _nIdContribuente = Value
            End Set
        End Property

        Public Property IdFlusso() As Integer
            Get
                Return _nIdFlusso
            End Get

            Set(ByVal Value As Integer)
                _nIdFlusso = Value
            End Set
        End Property

    End Class
End Namespace