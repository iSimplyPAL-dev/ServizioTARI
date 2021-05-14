Namespace MotoreTarsu.Oggetti

    <Serializable()> _
    Public Class OggettoCartella
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoCartella contiene i dati completi della cartella.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Dim _nidCartella As Integer = -1
        Dim _sCodTributo As String = "0434"
        Dim _sCodiceCartella As String = ""
        Private _sCodiceCliente As String = ""
        Dim _sDataEmissione As String = ""
        Dim _sCodiceEnte As String = ""
        Dim _IdContribuente As Integer = -1
        Dim _IdFlussoRuolo As Integer = -1
        Dim _sAnnoRiferimento As String = ""
        Dim _IdLottoCartellazione As Integer = -1
        Dim _sAnniPresenzaRuolo As String = ""
        Dim _sCognome As String = ""
        Dim _sNome As String = ""
        Dim _sCodiceFiscale As String = ""
        Dim _sPartitaIVA As String = ""
        Dim _sIndirizzoRes As String
        Dim _sCivicoRes As String = ""
        Dim _sCAPRes As String = ""
        Dim _sProvRes As String = ""
        Dim _sComuneRes As String = ""
        Dim _sFrazRes As String = ""
        Dim _sNominativoCO As String = ""
        Dim _sIndirizzoCO As String = ""
        Dim _sCivicoCO As String = ""
        Dim _sCAPCO As String = ""
        Dim _sProvCO As String = ""
        Dim _sComuneCO As String = ""
        Dim _sFrazCO As String = ""
        Private _sCodStatoNazione As String = ""
        Dim _nImportoTotale As Double = 0
        Dim _nImportoArrotondamento As Double = 0
        Dim _nImportoCarico As Double = 0
        Dim _nIdProgressivo As Integer = -1
        Dim _bSelezionato As Boolean = False
        Dim _bIsSgravio As Boolean = False
        Dim _ImportoPRESgravio As Double = -1
        Dim _oListDettaglioVoci() As OggettoDettaglioCartella = Nothing
        Dim _oListArticoli() As OggettoArticoloRuolo = Nothing

        Public Property idCartella() As Integer
            Get
                Return _nidCartella
            End Get

            Set(ByVal Value As Integer)
                _nidCartella = Value
            End Set
        End Property
        Public Property CodTributo() As String
            Get
                Return _sCodTributo
            End Get

            Set(ByVal Value As String)
                _sCodTributo = Value
            End Set
        End Property
        Public Property CodiceCliente() As String
            Get
                Return _sCodiceCliente
            End Get

            Set(ByVal Value As String)
                _sCodiceCliente = Value
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

        Public Property DataEmissione() As String
            Get
                Return _sDataEmissione
            End Get

            Set(ByVal Value As String)
                _sDataEmissione = Value
            End Set
        End Property

        Public Property CodiceEnte() As String
            Get
                Return _sCodiceEnte
            End Get

            Set(ByVal Value As String)
                _sCodiceEnte = Value
            End Set
        End Property

        Public Property IdContribuente() As Integer
            Get
                Return _IdContribuente
            End Get

            Set(ByVal Value As Integer)
                _IdContribuente = Value
            End Set
        End Property
        Public Property IdFlussoRuolo() As Integer
            Get
                Return _IdFlussoRuolo
            End Get

            Set(ByVal Value As Integer)
                _IdFlussoRuolo = Value
            End Set
        End Property
        Public Property AnnoRiferimento() As String
            Get
                Return _sAnnoRiferimento
            End Get

            Set(ByVal Value As String)
                _sAnnoRiferimento = Value
            End Set
        End Property

        Public Property LottoCartellazione() As Integer
            Get
                Return _IdLottoCartellazione
            End Get

            Set(ByVal Value As Integer)
                _IdLottoCartellazione = Value
            End Set
        End Property

        Public Property AnniPresenzaRuolo() As String
            Get
                Return _sAnniPresenzaRuolo
            End Get

            Set(ByVal Value As String)
                _sAnniPresenzaRuolo = Value
            End Set
        End Property

        Public Property Cognome() As String
            Get
                Return _sCognome
            End Get

            Set(ByVal Value As String)
                _sCognome = Value
            End Set
        End Property

        Public Property Nome() As String
            Get
                Return _sNome
            End Get

            Set(ByVal Value As String)
                _sNome = Value
            End Set
        End Property

        Public Property CodiceFiscale() As String
            Get
                Return _sCodiceFiscale
            End Get

            Set(ByVal Value As String)
                _sCodiceFiscale = Value
            End Set
        End Property

        Public Property PartitaIVA() As String
            Get
                Return _sPartitaIVA
            End Get

            Set(ByVal Value As String)
                _sPartitaIVA = Value
            End Set
        End Property

        Public Property IndirizzoRes() As String
            Get
                Return _sIndirizzoRes
            End Get

            Set(ByVal Value As String)
                _sIndirizzoRes = Value
            End Set
        End Property

        Public Property CivicoRes() As String
            Get
                Return _sCivicoRes
            End Get

            Set(ByVal Value As String)
                _sCivicoRes = Value
            End Set
        End Property

        Public Property CAPRes() As String
            Get
                Return _sCAPRes
            End Get

            Set(ByVal Value As String)
                _sCAPRes = Value
            End Set
        End Property

        Public Property ProvRes() As String
            Get
                Return _sProvRes
            End Get

            Set(ByVal Value As String)
                _sProvRes = Value
            End Set
        End Property

        Public Property ComuneRes() As String
            Get
                Return _sComuneRes
            End Get

            Set(ByVal Value As String)
                _sComuneRes = Value
            End Set
        End Property

        Public Property FrazRes() As String
            Get
                Return _sFrazRes
            End Get

            Set(ByVal Value As String)
                _sFrazRes = Value
            End Set
        End Property

        Public Property NominativoCO() As String
            Get
                Return _sNominativoCO
            End Get

            Set(ByVal Value As String)
                _sNominativoCO = Value
            End Set
        End Property

        Public Property IndirizzoCO() As String
            Get
                Return _sIndirizzoCO
            End Get

            Set(ByVal Value As String)
                _sIndirizzoCO = Value
            End Set
        End Property

        Public Property CivicoCO() As String
            Get
                Return _sCivicoCO
            End Get

            Set(ByVal Value As String)
                _sCivicoCO = Value
            End Set
        End Property

        Public Property CAPCO() As String
            Get
                Return _sCAPCO
            End Get

            Set(ByVal Value As String)
                _sCAPCO = Value
            End Set
        End Property

        Public Property ProvCO() As String
            Get
                Return _sProvCO
            End Get

            Set(ByVal Value As String)
                _sProvCO = Value
            End Set
        End Property

        Public Property ComuneCO() As String
            Get
                Return _sComuneCO
            End Get

            Set(ByVal Value As String)
                _sComuneCO = Value
            End Set
        End Property

        Public Property FrazCO() As String
            Get
                Return _sFrazCO
            End Get

            Set(ByVal Value As String)
                _sFrazCO = Value
            End Set
        End Property
        Public Property CodStatoNazione() As String
            Get
                Return _sCodStatoNazione
            End Get

            Set(ByVal Value As String)
                _sCodStatoNazione = Value
            End Set
        End Property
        Public Property ImportoTotale() As Double
            Get
                Return _nImportoTotale
            End Get

            Set(ByVal Value As Double)
                _nImportoTotale = Value
            End Set
        End Property

        Public Property ImportoArrotondamento() As Double
            Get
                Return _nImportoArrotondamento
            End Get

            Set(ByVal Value As Double)
                _nImportoArrotondamento = Value
            End Set
        End Property

        Public Property ImportoCarico() As Double
            Get
                Return _nImportoCarico
            End Get

            Set(ByVal Value As Double)
                _nImportoCarico = Value
            End Set
        End Property

        Public Property IdProgressivo() As Integer
            Get
                Return _nIdProgressivo
            End Get

            Set(ByVal Value As Integer)
                _nIdProgressivo = Value
            End Set
        End Property
        Public Property Selezionato() As Boolean
            Get
                Return _bSelezionato
            End Get

            Set(ByVal Value As Boolean)
                _bSelezionato = Value
            End Set
        End Property
        Public Property bIsSgravio() As Boolean
            Get
                Return _bIsSgravio
            End Get

            Set(ByVal Value As Boolean)
                _bIsSgravio = Value
            End Set
        End Property
        Public Property ImportoPRESgravio() As Double
            Get
                Return _ImportoPRESgravio
            End Get

            Set(ByVal Value As Double)
                _ImportoPRESgravio = Value
            End Set
        End Property
        Public Property oListDettaglioVoci() As OggettoDettaglioCartella()
            Get
                Return _oListDettaglioVoci
            End Get
            Set(ByVal Value As OggettoDettaglioCartella())
                _oListDettaglioVoci = Value
            End Set
        End Property
        Public Property oListArticoli() As OggettoArticoloRuolo()
            Get
                Return _oListArticoli
            End Get
            Set(ByVal Value As OggettoArticoloRuolo())
                _oListArticoli = Value
            End Set
        End Property
    End Class

    <Serializable()> _
    Public Class ObjLottoCartellazione
        Dim _sidEnte As String = ""
        Dim _sAnno As String = ""
        Dim _sCodiceConcessione As String = "100"
        Dim _nNumeroLotto As Integer = 1
        Dim _nPrimacartella As Integer = 1
        Dim _nUltimaCartella As Integer = 1
        Dim _dDataEmissione As Date = Date.MinValue
        Dim _nStatoElaborazione As Integer = -1

        Public Property IdEnte() As String
            Get
                Return _sidEnte
            End Get
            Set(ByVal Value As String)
                _sidEnte = Value
            End Set
        End Property
        Public Property Anno() As String
            Get
                Return _sAnno
            End Get
            Set(ByVal Value As String)
                _sAnno = Value
            End Set
        End Property
        Public Property CodiceConcessione() As String
            Get
                Return _sCodiceConcessione
            End Get
            Set(ByVal Value As String)
                _sCodiceConcessione = Value
            End Set
        End Property
        Public Property NumeroLotto() As Integer
            Get
                Return _nNumeroLotto
            End Get
            Set(ByVal Value As Integer)
                _nNumeroLotto = Value
            End Set
        End Property
        Public Property Primacartella() As Integer
            Get
                Return _nPrimacartella
            End Get
            Set(ByVal Value As Integer)
                _nPrimacartella = Value
            End Set
        End Property
        Public Property UltimaCartella() As Integer
            Get
                Return _nUltimaCartella
            End Get
            Set(ByVal Value As Integer)
                _nUltimaCartella = Value
            End Set
        End Property
        Public Property DataEmissione() As Date
            Get
                Return _dDataEmissione
            End Get
            Set(ByVal Value As Date)
                _dDataEmissione = Value
            End Set
        End Property
        Public Property StatoElaborazione() As Integer
            Get
                Return _nStatoElaborazione
            End Get
            Set(ByVal Value As Integer)
                _nStatoElaborazione = Value
            End Set
        End Property
    End Class
End Namespace
