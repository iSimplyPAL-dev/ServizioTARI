Namespace MotoreTarsu.Oggetti

    'OggettoArticoloRuolo
    <Serializable()>
    Public Class OggettoArticoloRuolo

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoArticoloRuolo contiene i dati completi dell'articolo a ruolo.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub New()
        End Sub

        'Private _Id As Integer = -1
        'Private _IdArticoloRuolo As Integer = -1
        'Private _IdContribuente As Integer = -1
        'Private _IdDettaglioTestata As Integer = -1
        'Private _IdTestata As Integer = -1
        'Private _sEnte As String = String.Empty
        'Private _sAnno As String = String.Empty
        'Private _sVia As String = String.Empty
        'Private _sCivico As Integer
        'Private _sEsponente As String = String.Empty
        'Private _sInterno As String = String.Empty
        'Private _sScala As String = String.Empty
        'Private _sFoglio As String = String.Empty
        'Private _sNumero As String = String.Empty
        'Private _sSubalterno As String = String.Empty
        'Private _nIdTitoloOccupaz As Integer = -1
        'Private _nIdNaturaOccupaz As Integer = -1
        'Private _nIdDestUso As Integer = -1
        'Private _sIdTipoUnita As String = ""
        'Private _sIdTipoParticella As String = ""
        'Private _nIdAssenzaDatiCatastali As Integer = 0
        'Private _sSezione As String = ""
        'Private _sEstensioneParticella As String = ""
        'Private _sCategoria As String = String.Empty
        'Private _nComponenti As Integer = 0
        'Private _nTariffa As Integer = 0
        'Private _ImpTariffa As Double = 0
        'Private _nMq As Double = 0
        'Private _nBimestri As Integer = 0
        'Private _ImpRuolo As Double = 0
        'Private _ImpRiduzione As Double = 0
        'Private _ImpDetassazione As Double = 0
        'Private _ImpNetto As Double = 0
        'Private _ImpSanzioni As Double = 0
        'Private _ImpInteressi As Double = 0
        'Private _ImpSpeseNotifica As Double = 0
        'Private _DescrDiffImposta As String = String.Empty
        'Private _DescrSanzioni As String = String.Empty
        'Private _DescrInteressi As String = String.Empty
        'Private _DescrSpeseNotifica As String = String.Empty
        'Private _IdFlussoRuolo As Integer = -1
        'Private _ImportoForzato As Boolean
        'Private _IsTarsuGiornaliera As Boolean
        'Private _DataInizio As DateTime
        'Private _DataFine As DateTime
        'Private _bDaAccertamento As Boolean
        'Private _InformazioniCartella As String = String.Empty
        'Private _TipoRuolo As String = ""
        'Private _DataVariazione As DateTime
        'Private _CodCartella As String
        'Private _CodVia As Integer = 0
        'Private _oRiduzioni() As OggettoRiduzione
        'Private _oDetassazioni() As OggettoDetassazione
        ''Dipe 15/02/2011
        'Private _IdLegame As Integer = 0
        'Private _Progressivo As Integer = 0
        'Private _Sanzioni As String = ""
        'Private _Interessi As String = ""
        'Private _CalcolaInteressi As Boolean = False

        Private _Id As Integer = -1
        Private _IdArticoloRuolo As Integer = -1
        Private _IdContribuente As Integer = -1
        Private _COGNOME As String = ""
        Private _NOME As String = ""
        Private _CODICE_FISCALE As String = ""
        Private _PARTITA_IVA As String = ""
        Private _VIA_RES As String = ""
        Private _POSIZIONE_CIVICO_RES As String = ""
        Private _CIVICO_RES As String = ""
        Private _ESPONENTE_CIVICO_RES As String = ""
        Private _CAP_RES As String = ""
        Private _FRAZIONE_RES As String = ""
        Private _CITTA_RES As String = ""
        Private _PROVINCIA_RES As String = ""
        Private _CO As String = ""
        Private _VIA_CO As String = ""
        Private _POSIZIONE_CIVICO_CO As String = ""
        Private _CIVICO_CO As String = ""
        Private _ESPONENTE_CIVICO_CO As String = ""
        Private _CAP_CO As String = ""
        Private _FRAZIONE_CO As String = ""
        Private _CITTA_CO As String = ""
        Private _PROVINCIA_CO As String = ""
        Private _IdDettaglioTestata As Integer = -1
        Private _IdTestata As Integer = -1
        Private _sEnte As String = String.Empty
        Private _sAnno As String = String.Empty
        Private _sVia As String = String.Empty
        Private _sCivico As Integer
        Private _sEsponente As String = String.Empty
        Private _sInterno As String = String.Empty
        Private _sScala As String = String.Empty
        Private _sFoglio As String = String.Empty
        Private _sNumero As String = String.Empty
        Private _sSubalterno As String = String.Empty
        Private _sCategoria As String = String.Empty
        Private _nComponenti As Integer = 0
        Private _nTariffa As Integer = 0
        Private _ImpTariffa As Double = 0
        Private _nMq As Double = 0
        Private _nBimestri As Integer = 0
        Private _ImpRuolo As Double = 0
        Private _ImpRiduzione As Double = 0
        Private _ImpDetassazione As Double = 0
        Private _ImpNetto As Double = 0
        Private _ImpSanzioni As Double = 0
        Private _ImpSanzioniRidotto As Double = 0
        Private _ImpInteressi As Double = 0
        Private _ImpSpeseNotifica As Double = 0
        Private _DescrDiffImposta As String = String.Empty
        Private _DescrSanzioni As String = String.Empty
        Private _DescrInteressi As String = String.Empty
        Private _DescrSpeseNotifica As String = String.Empty
        Private _IdFlussoRuolo As Integer = -1
        Private _ImportoForzato As Boolean
        Private _IsTarsuGiornaliera As Boolean
        Private _DataInizio As DateTime
        Private _DataFine As DateTime
        Private _bDaAccertamento As Boolean
        Private _InformazioniCartella As String = String.Empty
        Private _TipoRuolo As String = ""
        Private _DataVariazione As DateTime
        Private _CodCartella As String
        Private _CodVia As Integer = 0
        Private _oRiduzioni() As OggettoRiduzione
        Private _oDetassazioni() As OggettoDetassazione
        Private _IdLegame As Integer = 0
        Private _Progressivo As Integer = 0
        Private _Sanzioni As String = ""
        Private _Interessi As String = ""
        Private _CalcolaInteressi As Boolean = False
        Private _nIdTitoloOccupaz As Integer = -1
        Private _nIdNaturaOccupaz As Integer = -1
        Private _nIdDestUso As Integer = -1
        Private _sIdTipoUnita As String = ""
        Private _sIdTipoParticella As String = ""
        Private _nIdAssenzaDatiCatastali As Integer = 0
        Private _sSezione As String = ""
        Private _sEstensioneParticella As String = ""

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdArticoloRuolo() As Integer
            Get
                Return _IdArticoloRuolo
            End Get
            Set(ByVal Value As Integer)
                _IdArticoloRuolo = Value
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
        Public Property COGNOME() As String
            Get
                Return _COGNOME
            End Get
            Set(ByVal Value As String)
                _COGNOME = Value
            End Set
        End Property
        Public Property NOME() As String
            Get
                Return _NOME
            End Get
            Set(ByVal Value As String)
                _NOME = Value
            End Set
        End Property
        Public Property CODICE_FISCALE() As String
            Get
                Return _CODICE_FISCALE
            End Get
            Set(ByVal Value As String)
                _CODICE_FISCALE = Value
            End Set
        End Property
        Public Property PARTITA_IVA() As String
            Get
                Return _PARTITA_IVA
            End Get
            Set(ByVal Value As String)
                _PARTITA_IVA = Value
            End Set
        End Property
        Public Property VIA_RES() As String
            Get
                Return _VIA_RES
            End Get
            Set(ByVal Value As String)
                _VIA_RES = Value
            End Set
        End Property
        Public Property POSIZIONE_CIVICO_RES() As String
            Get
                Return _POSIZIONE_CIVICO_RES
            End Get
            Set(ByVal Value As String)
                _POSIZIONE_CIVICO_RES = Value
            End Set
        End Property
        Public Property CIVICO_RES() As String
            Get
                Return _CIVICO_RES
            End Get
            Set(ByVal Value As String)
                _CIVICO_RES = Value
            End Set
        End Property
        Public Property ESPONENTE_CIVICO_RES() As String
            Get
                Return _ESPONENTE_CIVICO_RES
            End Get
            Set(ByVal Value As String)
                _ESPONENTE_CIVICO_RES = Value
            End Set
        End Property
        Public Property CAP_RES() As String
            Get
                Return _CAP_RES
            End Get
            Set(ByVal Value As String)
                _CAP_RES = Value
            End Set
        End Property
        Public Property FRAZIONE_RES() As String
            Get
                Return _FRAZIONE_RES
            End Get
            Set(ByVal Value As String)
                _FRAZIONE_RES = Value
            End Set
        End Property
        Public Property PROVINCIA_RES() As String
            Get
                Return _PROVINCIA_RES
            End Get
            Set(ByVal Value As String)
                _PROVINCIA_RES = Value
            End Set
        End Property
        Public Property CITTA_RES() As String
            Get
                Return _CITTA_RES
            End Get
            Set(ByVal Value As String)
                _CITTA_RES = Value
            End Set
        End Property
        Public Property CO() As String
            Get
                Return _CO
            End Get
            Set(ByVal Value As String)
                _CO = Value
            End Set
        End Property
        Public Property VIA_CO() As String
            Get
                Return _VIA_CO
            End Get
            Set(ByVal Value As String)
                _VIA_CO = Value
            End Set
        End Property
        Public Property POSIZIONE_CIVICO_CO() As String
            Get
                Return _POSIZIONE_CIVICO_CO
            End Get
            Set(ByVal Value As String)
                _POSIZIONE_CIVICO_CO = Value
            End Set
        End Property
        Public Property CIVICO_CO() As String
            Get
                Return _CIVICO_CO
            End Get
            Set(ByVal Value As String)
                _CIVICO_CO = Value
            End Set
        End Property
        Public Property ESPONENTE_CIVICO_CO() As String
            Get
                Return _ESPONENTE_CIVICO_CO
            End Get
            Set(ByVal Value As String)
                _ESPONENTE_CIVICO_CO = Value
            End Set
        End Property
        Public Property CAP_CO() As String
            Get
                Return _CAP_CO
            End Get
            Set(ByVal Value As String)
                _CAP_CO = Value
            End Set
        End Property
        Public Property FRAZIONE_CO() As String
            Get
                Return _FRAZIONE_CO
            End Get
            Set(ByVal Value As String)
                _FRAZIONE_CO = Value
            End Set
        End Property
        Public Property CITTA_CO() As String
            Get
                Return _CITTA_CO
            End Get
            Set(ByVal Value As String)
                _CITTA_CO = Value
            End Set
        End Property
        Public Property PROVINCIA_CO() As String
            Get
                Return _PROVINCIA_CO
            End Get
            Set(ByVal Value As String)
                _PROVINCIA_CO = Value
            End Set
        End Property
        Public Property IdDettaglioTestata() As Integer
            Get
                Return _IdDettaglioTestata
            End Get
            Set(ByVal Value As Integer)
                _IdDettaglioTestata = Value
            End Set
        End Property
        Public Property IdTestata() As Integer
            Get
                Return _IdTestata
            End Get
            Set(ByVal Value As Integer)
                _IdTestata = Value
            End Set
        End Property
        Public Property Ente() As String
            Get
                Return _sEnte
            End Get
            Set(ByVal Value As String)
                _sEnte = Value
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
        Public Property Via() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property
        Public Property Civico() As Integer
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As Integer)
                _sCivico = Value
            End Set
        End Property
        Public Property Esponente() As String
            Get
                Return _sEsponente
            End Get
            Set(ByVal Value As String)
                _sEsponente = Value
            End Set
        End Property
        Public Property Interno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property
        Public Property Scala() As String
            Get
                Return _sScala
            End Get
            Set(ByVal Value As String)
                _sScala = Value
            End Set
        End Property
        Public Property Foglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property Numero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property Subalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property Categoria() As String
            Get
                Return _sCategoria
            End Get
            Set(ByVal Value As String)
                _sCategoria = Value
            End Set
        End Property
        Public Property nComponenti() As Integer
            Get
                Return _nComponenti
            End Get
            Set(ByVal Value As Integer)
                _nComponenti = Value
            End Set
        End Property
        Public Property IDTariffa() As Integer
            Get
                Return _nTariffa
            End Get
            Set(ByVal Value As Integer)
                _nTariffa = Value
            End Set
        End Property
        Public Property ImpTariffa() As Double
            Get
                Return _ImpTariffa
            End Get
            Set(ByVal Value As Double)
                _ImpTariffa = Value
            End Set
        End Property
        Public Property MQ() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property
        Public Property NumeroBimestri() As Integer
            Get
                Return _nBimestri
            End Get
            Set(ByVal Value As Integer)
                _nBimestri = Value
            End Set
        End Property
        Public Property ImportoRuolo() As Double
            Get
                Return _ImpRuolo
            End Get
            Set(ByVal Value As Double)
                _ImpRuolo = Value
            End Set
        End Property
        Public Property ImportoRiduzione() As Double
            Get
                Return _ImpRiduzione
            End Get
            Set(ByVal Value As Double)
                _ImpRiduzione = Value
            End Set
        End Property
        Public Property ImportoDetassazione() As Double
            Get
                Return _ImpDetassazione
            End Get
            Set(ByVal Value As Double)
                _ImpDetassazione = Value
            End Set
        End Property
        Public Property ImportoNetto() As Double
            Get
                Return _ImpNetto
            End Get
            Set(ByVal Value As Double)
                _ImpNetto = Value
            End Set
        End Property
        Public Property ImpSanzioni() As Double
            Get
                Return _ImpSanzioni
            End Get
            Set(ByVal Value As Double)
                _ImpSanzioni = Value
            End Set
        End Property
        Public Property ImpSanzioniRidotto() As Double
            Get
                Return _ImpSanzioniRidotto
            End Get
            Set(ByVal Value As Double)
                _ImpSanzioniRidotto = Value
            End Set
        End Property
        Public Property ImpInteressi() As Double
            Get
                Return _ImpInteressi
            End Get
            Set(ByVal Value As Double)
                _ImpInteressi = Value
            End Set
        End Property
        Public Property ImpSpeseNotifica() As Double
            Get
                Return _ImpSpeseNotifica
            End Get
            Set(ByVal Value As Double)
                _ImpSpeseNotifica = Value
            End Set
        End Property
        Public Property DescrDiffImposta() As String
            Get
                Return _DescrDiffImposta
            End Get
            Set(ByVal Value As String)
                _DescrDiffImposta = Value
            End Set
        End Property
        Public Property DescrSanzioni() As String
            Get
                Return _DescrSanzioni
            End Get
            Set(ByVal Value As String)
                _DescrSanzioni = Value
            End Set
        End Property
        Public Property DescrInteressi() As String
            Get
                Return _DescrInteressi
            End Get
            Set(ByVal Value As String)
                _DescrInteressi = Value
            End Set
        End Property
        Public Property DescrSpeseNotifica() As String
            Get
                Return _DescrSpeseNotifica
            End Get
            Set(ByVal Value As String)
                _DescrSpeseNotifica = Value
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
        Public Property ImportoForzato() As Boolean
            Get
                Return _ImportoForzato
            End Get
            Set(ByVal Value As Boolean)
                _ImportoForzato = Value
            End Set
        End Property
        Public Property IsTarsuGiornaliera() As Boolean
            Get
                Return _IsTarsuGiornaliera
            End Get
            Set(ByVal Value As Boolean)
                _IsTarsuGiornaliera = Value
            End Set
        End Property
        Public Property DataInizio() As DateTime
            Get
                Return _DataInizio
            End Get
            Set(ByVal Value As DateTime)
                _DataInizio = Value
            End Set
        End Property
        Public Property DataFine() As DateTime
            Get
                Return _DataFine
            End Get
            Set(ByVal Value As DateTime)
                _DataFine = Value
            End Set
        End Property
        Public Property DaAccertamento() As Boolean
            Get
                Return _bDaAccertamento
            End Get
            Set(ByVal Value As Boolean)
                _bDaAccertamento = Value
            End Set
        End Property
        Public Property InformazioniCartella() As String
            Get
                Return _InformazioniCartella
            End Get
            Set(ByVal Value As String)
                _InformazioniCartella = Value
            End Set
        End Property
        Public Property TipoRuolo() As String
            Get
                Return _TipoRuolo
            End Get
            Set(ByVal Value As String)
                _TipoRuolo = Value
            End Set
        End Property
        Public Property DataVariazione() As DateTime
            Get
                Return _DataVariazione
            End Get
            Set(ByVal Value As DateTime)
                _DataVariazione = Value
            End Set
        End Property
        Public Property CodCartella() As String
            Get
                Return _CodCartella
            End Get
            Set(ByVal Value As String)
                _CodCartella = Value
            End Set
        End Property
        Public Property CodVia() As Integer
            Get
                Return _CodVia
            End Get
            Set(ByVal Value As Integer)
                _CodVia = Value
            End Set
        End Property
        Public Property oRiduzioni() As OggettoRiduzione()
            Get
                Return _oRiduzioni
            End Get
            Set(ByVal Value As OggettoRiduzione())
                _oRiduzioni = Value
            End Set
        End Property
        Public Property oDetassazioni() As OggettoDetassazione()
            Get
                Return _oDetassazioni
            End Get
            Set(ByVal Value As OggettoDetassazione())
                _oDetassazioni = Value
            End Set
        End Property
        Public Property IdLegame() As Integer
            Get
                Return _IdLegame
            End Get
            Set(ByVal Value As Integer)
                _IdLegame = Value
            End Set
        End Property
        Public Property Progressivo() As Integer
            Get
                Return _Progressivo
            End Get
            Set(ByVal Value As Integer)
                _Progressivo = Value
            End Set
        End Property
        Public Property Sanzioni() As String
            Get
                Return _Sanzioni
            End Get
            Set(ByVal Value As String)
                _Sanzioni = Value
            End Set
        End Property
        Public Property Interessi() As String
            Get
                Return _Interessi
            End Get
            Set(ByVal Value As String)
                _Interessi = Value
            End Set
        End Property
        Public Property Calcola_Interessi() As Boolean
            Get
                Return _CalcolaInteressi
            End Get
            Set(ByVal Value As Boolean)
                _CalcolaInteressi = Value
            End Set
        End Property
        Public Property IdTitoloOccupaz() As Integer
            Get
                Return _nIdTitoloOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdTitoloOccupaz = Value
            End Set
        End Property
        Public Property IdNaturaOccupaz() As Integer
            Get
                Return _nIdNaturaOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdNaturaOccupaz = Value
            End Set
        End Property
        Public Property IdDestUso() As Integer
            Get
                Return _nIdDestUso
            End Get
            Set(ByVal Value As Integer)
                _nIdDestUso = Value
            End Set
        End Property
        Public Property IdTipoUnita() As String
            Get
                Return _sIdTipoUnita
            End Get
            Set(ByVal Value As String)
                _sIdTipoUnita = Value
            End Set
        End Property
        Public Property IdTipoParticella() As String
            Get
                Return _sIdTipoParticella
            End Get
            Set(ByVal Value As String)
                _sIdTipoParticella = Value
            End Set
        End Property
        Public Property IdAssenzaDatiCatastali() As Integer
            Get
                Return _nIdAssenzaDatiCatastali
            End Get
            Set(ByVal Value As Integer)
                _nIdAssenzaDatiCatastali = Value
            End Set
        End Property
        Public Property Sezione() As String
            Get
                Return _sSezione
            End Get
            Set(ByVal Value As String)
                _sSezione = Value
            End Set
        End Property
        Public Property EstensioneParticella() As String
            Get
                Return _sEstensioneParticella
            End Get
            Set(ByVal Value As String)
                _sEstensioneParticella = Value
            End Set
        End Property

    End Class
    'OggettoDichiarazioneTARSU
    <Serializable()>
    Public Class OggettoDichiarazioneTARSU

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoDichiarazioneTARSURidDet contiene i dati completi di dichiarazione.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub New()
        End Sub

        Private _Id As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _IdTestata As Integer = -1
        Private _sEnte As String = String.Empty
        Private _sAnno As String = String.Empty
        Private _IdContribuente As Integer = -1
        Private _sVia As String = String.Empty
        Private _sCivico As Integer = -1
        Private _sEsponente As String = String.Empty
        Private _sInterno As String = String.Empty
        Private _sScala As String = String.Empty
        Private _sFoglio As String = String.Empty
        Private _sNumero As String = String.Empty
        Private _sSubalterno As String = String.Empty
        Private _nIdTitoloOccupaz As Integer = -1
        Private _nIdNaturaOccupaz As Integer = -1
        Private _nIdDestUso As Integer = -1
        Private _sIdTipoUnita As String = ""
        Private _sIdTipoParticella As String = ""
        Private _nIdAssenzaDatiCatastali As Integer = 0
        Private _sSezione As String = ""
        Private _sEstensioneParticella As String = ""
        Private _IdCategoria As String = String.Empty
        Private _nMq As Double = 0
        Private _DataInizio As Date = Nothing
        Private _DataFine As Date = Nothing
        Private _IdTariffa As Integer = -1
        Private _ImportoTariffa As Double = 0
        Private _GGtarsu As Integer

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdDettaglioTestata() As Integer
            Get
                Return _IdDettaglioTestata
            End Get
            Set(ByVal Value As Integer)
                _IdDettaglioTestata = Value
            End Set
        End Property
        Public Property IdTestata() As Integer
            Get
                Return _IdTestata
            End Get
            Set(ByVal Value As Integer)
                _IdTestata = Value
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

        Public Property Ente() As String
            Get
                Return _sEnte
            End Get
            Set(ByVal Value As String)
                _sEnte = Value
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

        Public Property Via() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property

        Public Property Civico() As Integer
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As Integer)
                _sCivico = Value
            End Set
        End Property

        Public Property Esponente() As String
            Get
                Return _sEsponente
            End Get
            Set(ByVal Value As String)
                _sEsponente = Value
            End Set
        End Property

        Public Property Interno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property

        Public Property Scala() As String
            Get
                Return _sScala
            End Get
            Set(ByVal Value As String)
                _sScala = Value
            End Set
        End Property
        Public Property Foglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property Numero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property Subalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property IdTitoloOccupaz() As Integer
            Get
                Return _nIdTitoloOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdTitoloOccupaz = Value
            End Set
        End Property
        Public Property IdNaturaOccupaz() As Integer
            Get
                Return _nIdNaturaOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdNaturaOccupaz = Value
            End Set
        End Property
        Public Property IdDestUso() As Integer
            Get
                Return _nIdDestUso
            End Get
            Set(ByVal Value As Integer)
                _nIdDestUso = Value
            End Set
        End Property
        Public Property IdTipoUnita() As String
            Get
                Return _sIdTipoUnita
            End Get
            Set(ByVal Value As String)
                _sIdTipoUnita = Value
            End Set
        End Property
        Public Property IdTipoParticella() As String
            Get
                Return _sIdTipoParticella
            End Get
            Set(ByVal Value As String)
                _sIdTipoParticella = Value
            End Set
        End Property
        Public Property IdAssenzaDatiCatastali() As Integer
            Get
                Return _nIdAssenzaDatiCatastali
            End Get
            Set(ByVal Value As Integer)
                _nIdAssenzaDatiCatastali = Value
            End Set
        End Property
        Public Property Sezione() As String
            Get
                Return _sSezione
            End Get
            Set(ByVal Value As String)
                _sSezione = Value
            End Set
        End Property
        Public Property EstensioneParticella() As String
            Get
                Return _sEstensioneParticella
            End Get
            Set(ByVal Value As String)
                _sEstensioneParticella = Value
            End Set
        End Property
        Public Property IDCategoria() As String
            Get
                Return _IdCategoria
            End Get
            Set(ByVal Value As String)
                _IdCategoria = Value
            End Set
        End Property


        Public Property MQ() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property

        Public Property IDTariffa() As Integer
            Get
                Return _IdTariffa
            End Get
            Set(ByVal Value As Integer)
                _IdTariffa = Value
            End Set
        End Property

        Public Property ImportoTariffa() As Double
            Get
                Return _ImportoTariffa
            End Get
            Set(ByVal Value As Double)
                _ImportoTariffa = Value
            End Set
        End Property

        Public Property DataInizio() As DateTime
            Get
                Return _DataInizio
            End Get
            Set(ByVal Value As DateTime)
                _DataInizio = Value
            End Set
        End Property

        Public Property DataFine() As DateTime
            Get
                Return _DataFine
            End Get
            Set(ByVal Value As DateTime)
                _DataFine = Value
            End Set
        End Property

        Public Property GiorniTARSU() As Integer
            Get
                Return _GGtarsu
            End Get
            Set(ByVal Value As Integer)
                _GGtarsu = Value
            End Set
        End Property

    End Class
    'OggettoTestataRuolo
    <Serializable()>
    Public Class OggettoTestataRuolo

        Public Sub New()
        End Sub

        Private _IdFlusso As Integer = -1
        Private _sNomeRuolo As String = String.Empty
        Private _sDescrRuolo As String = String.Empty
        Private _sTipoRuolo As String = String.Empty
        Private _sDescrizioneTipoRuolo As String = String.Empty
        Private _nNumeroRuolo As Integer = 0
        Private _nNArticoli As Integer = 0
        Private _nContribuenti As Integer = 0
        Private _nMq As Double = 0
        Private _ImpArticoli As Double = 0
        Private _ImpRiduzione As Double = 0
        Private _ImpDetassazione As Double = 0
        Private _ImpNetto As Double = 0
        Private _DataCreazione As Date = Now.Today
        Private _DataApprovazione As Date = Now.Today
        Private _DataEstrazionePostel As Date = Now.Today
        Private _DataEstrazione290 As Date = Now.Today
        Private _DataCartellazione As Date = Now.Today
        Private _sEnte As String = String.Empty
        Private _sAnno As String = String.Empty
        Private _nTassazioneMinima As Integer = 0
        Private _ImpMinimo As Double = 0

        Public Property IdFlusso() As Integer
            Get
                Return _IdFlusso
            End Get
            Set(ByVal Value As Integer)
                _IdFlusso = Value
            End Set
        End Property

        Public Property NomeRuolo() As String
            Get
                Return _sNomeRuolo
            End Get
            Set(ByVal Value As String)
                _sNomeRuolo = Value
            End Set
        End Property

        Public Property DescrizioneRuolo() As String
            Get
                Return _sDescrRuolo
            End Get
            Set(ByVal Value As String)
                _sDescrRuolo = Value
            End Set
        End Property

        Public Property TipoRuolo() As String
            Get
                Return _sTipoRuolo
            End Get
            Set(ByVal Value As String)
                _sTipoRuolo = Value
            End Set
        End Property

        Public Property DescrizioneTipoRuolo() As String
            Get
                Return _sDescrizioneTipoRuolo
            End Get
            Set(ByVal Value As String)
                _sDescrizioneTipoRuolo = Value
            End Set
        End Property

        Public Property NumeroRuolo() As Integer
            Get
                Return _nNumeroRuolo
            End Get
            Set(ByVal Value As Integer)
                _nNumeroRuolo = Value
            End Set
        End Property

        Public Property NumeroArticoli() As Integer
            Get
                Return _nNArticoli
            End Get
            Set(ByVal Value As Integer)
                _nNArticoli = Value
            End Set
        End Property

        Public Property NumeroContribuenti() As Integer
            Get
                Return _nContribuenti
            End Get
            Set(ByVal Value As Integer)
                _nContribuenti = Value
            End Set
        End Property

        Public Property Mq() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property
        Public Property ImportoArticoli() As Double
            Get
                Return _ImpArticoli
            End Get
            Set(ByVal Value As Double)
                _ImpArticoli = Value
            End Set
        End Property
        Public Property ImportoRiduzione() As Double
            Get
                Return _ImpRiduzione
            End Get
            Set(ByVal Value As Double)
                _ImpRiduzione = Value
            End Set
        End Property
        Public Property ImportoDetassazione() As Double
            Get
                Return _ImpDetassazione
            End Get
            Set(ByVal Value As Double)
                _ImpDetassazione = Value
            End Set
        End Property
        Public Property ImportoNetto() As Double
            Get
                Return _ImpNetto
            End Get
            Set(ByVal Value As Double)
                _ImpNetto = Value
            End Set
        End Property
        Public Property DataCreazione() As Date
            Get
                Return _DataCreazione
            End Get
            Set(ByVal Value As Date)
                _DataCreazione = Value
            End Set
        End Property

        Public Property DataEstrazione290() As Date
            Get
                Return _DataEstrazione290
            End Get
            Set(ByVal Value As Date)
                _DataEstrazione290 = Value
            End Set
        End Property

        Public Property DataEstrazionePostel() As Date
            Get
                Return _DataEstrazionePostel
            End Get
            Set(ByVal Value As Date)
                _DataEstrazionePostel = Value
            End Set
        End Property

        Public Property DataCartellazione() As Date
            Get
                Return _DataCartellazione
            End Get
            Set(ByVal Value As Date)
                _DataCartellazione = Value
            End Set
        End Property

        Public Property DataApprovazione() As Date
            Get
                Return _DataApprovazione
            End Get
            Set(ByVal Value As Date)
                _DataApprovazione = Value
            End Set
        End Property

        Public Property Ente() As String
            Get
                Return _sEnte
            End Get
            Set(ByVal Value As String)
                _sEnte = Value
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

        Public Property TassazioneMinima() As Integer
            Get
                Return _nTassazioneMinima
            End Get
            Set(ByVal Value As Integer)
                _nTassazioneMinima = Value
            End Set
        End Property

        Public Property ImportoMinimo() As Double
            Get
                Return _ImpMinimo
            End Get
            Set(ByVal Value As Double)
                _ImpMinimo = Value
            End Set
        End Property


    End Class
    'OggettoDichiarazioneTARSURidDet
    <Serializable()>
    Public Class OggettoDichiarazioneTARSURidDet
        'Inherits OggettoDichiarazioneTARSU

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoDichiarazioneTARSURidDet contiene i dati completi di dichiarazione con riduzioni e detassazioni.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub New()
        End Sub

        Public objDichiarazioneTARSU As OggettoDichiarazioneTARSU
        Public objRiduzione() As OggettoRiduzione
        Public objDetassazione() As OggettoDetassazione

    End Class
    'OggettoRuoloCreato
    <Serializable()>
    Public Class OggettoRuoloCreato

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoRuoloCreato contiene i dati completi di totalizzatori ruolo e relativo array articoli.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub New()
        End Sub

        Public objTestataRuolo As OggettoTestataRuolo
        Public oArrayArticoliRuolo As OggettoArticoloRuolo()

    End Class

    'DA COMPLUS OggettoRuolo.cls
    'OggettoDettaglioAtto
    <Serializable()>
    Public Class OggettoDettaglioAtto
        Public Sub New()
        End Sub

        Private _Id As Integer = -1
        Private _IdArticoloRuolo As Integer = -1
        Private _IdContribuente As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _sEnte As String = String.Empty
        Private _sAnno As String = String.Empty
        Private _sVia As String = String.Empty
        Private _sCivico As Integer
        Private _sEsponente As String = String.Empty
        Private _sInterno As String = String.Empty
        Private _sScala As String = String.Empty
        Private _sFoglio As String = String.Empty
        Private _sNumero As String = String.Empty
        Private _sSubalterno As String = String.Empty
        Private _sCategoria As String = String.Empty
        Private _nComponenti As Integer = 0
        Private _nTariffa As Integer = 0
        Private _ImpTariffa As Double = 0
        Private _nMq As Double = 0
        Private _nBimestri As Integer = 0
        Private _ImpAccertato As Double = 0
        Private _ImpDichiarato As Double = 0
        Private _ImpRuolo As Double = 0
        Private _ImpNetto As Double = 0
        Private _ImpSanzioni As Double = 0
        Private _ImpSanzioniRidotto As Double = 0
        Private _ImpInteressi As Double = 0
        Private _ImpSpeseNotifica As Double = 0
        Private _IdLegame As Integer = 0
        Private _Progressivo As Integer = 0
        Private _Sanzioni As String = ""
        Private _Interessi As String = ""
        Private _CalcolaInteressi As Boolean = False


        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdArticoloRuolo() As Integer
            Get
                Return _IdArticoloRuolo
            End Get
            Set(ByVal Value As Integer)
                _IdArticoloRuolo = Value
            End Set
        End Property
        Public Property IdDettaglioTestata() As Integer
            Get
                Return _IdDettaglioTestata
            End Get
            Set(ByVal Value As Integer)
                _IdDettaglioTestata = Value
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
        Public Property Ente() As String
            Get
                Return _sEnte
            End Get
            Set(ByVal Value As String)
                _sEnte = Value
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
        Public Property Via() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property
        Public Property Civico() As Integer
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As Integer)
                _sCivico = Value
            End Set
        End Property
        Public Property Esponente() As String
            Get
                Return _sEsponente
            End Get
            Set(ByVal Value As String)
                _sEsponente = Value
            End Set
        End Property
        Public Property Interno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property
        Public Property Scala() As String
            Get
                Return _sScala
            End Get
            Set(ByVal Value As String)
                _sScala = Value
            End Set
        End Property
        Public Property Foglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property Numero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property Subalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property Categoria() As String
            Get
                Return _sCategoria
            End Get
            Set(ByVal Value As String)
                _sCategoria = Value
            End Set
        End Property
        Public Property nComponenti() As Integer
            Get
                Return _nComponenti
            End Get
            Set(ByVal Value As Integer)
                _nComponenti = Value
            End Set
        End Property
        Public Property IDTariffa() As Integer
            Get
                Return _nTariffa
            End Get
            Set(ByVal Value As Integer)
                _nTariffa = Value
            End Set
        End Property
        Public Property ImpTariffa() As Double
            Get
                Return _ImpTariffa
            End Get
            Set(ByVal Value As Double)
                _ImpTariffa = Value
            End Set
        End Property
        Public Property MQ() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property
        Public Property NumeroBimestri() As Integer
            Get
                Return _nBimestri
            End Get
            Set(ByVal Value As Integer)
                _nBimestri = Value
            End Set
        End Property

        Public Property ImpAccertato() As Double
            Get
                Return _ImpAccertato
            End Get
            Set(ByVal Value As Double)
                _ImpAccertato = Value
            End Set
        End Property

        Public Property ImpDichiarato() As Double
            Get
                Return _ImpDichiarato
            End Get
            Set(ByVal Value As Double)
                _ImpDichiarato = Value
            End Set
        End Property

        Public Property ImportoRuolo() As Double
            Get
                Return _ImpRuolo
            End Get
            Set(ByVal Value As Double)
                _ImpRuolo = Value
            End Set
        End Property
        Public Property ImportoNetto() As Double
            Get
                Return _ImpNetto
            End Get
            Set(ByVal Value As Double)
                _ImpNetto = Value
            End Set
        End Property
        Public Property ImpSanzioni() As Double
            Get
                Return _ImpSanzioni
            End Get
            Set(ByVal Value As Double)
                _ImpSanzioni = Value
            End Set
        End Property
        Public Property ImpSanzioniRidotto() As Double
            Get
                Return _ImpSanzioniRidotto
            End Get
            Set(ByVal Value As Double)
                _ImpSanzioniRidotto = Value
            End Set
        End Property

        Public Property ImpInteressi() As Double
            Get
                Return _ImpInteressi
            End Get
            Set(ByVal Value As Double)
                _ImpInteressi = Value
            End Set
        End Property
        Public Property ImpSpeseNotifica() As Double
            Get
                Return _ImpSpeseNotifica
            End Get
            Set(ByVal Value As Double)
                _ImpSpeseNotifica = Value
            End Set
        End Property

        Public Property IdLegame() As Integer
            Get
                Return _IdLegame
            End Get
            Set(ByVal Value As Integer)
                _IdLegame = Value
            End Set
        End Property
        Public Property Progressivo() As Integer
            Get
                Return _Progressivo
            End Get
            Set(ByVal Value As Integer)
                _Progressivo = Value
            End Set
        End Property
        Public Property Sanzioni() As String
            Get
                Return _Sanzioni
            End Get
            Set(ByVal Value As String)
                _Sanzioni = Value
            End Set
        End Property
        Public Property Interessi() As String
            Get
                Return _Interessi
            End Get
            Set(ByVal Value As String)
                _Interessi = Value
            End Set
        End Property

        Public Property Calcola_Interessi() As Boolean
            Get
                Return _CalcolaInteressi
            End Get
            Set(ByVal Value As Boolean)
                _CalcolaInteressi = Value
            End Set
        End Property

    End Class
    'OggettoAttoTARSU
End Namespace