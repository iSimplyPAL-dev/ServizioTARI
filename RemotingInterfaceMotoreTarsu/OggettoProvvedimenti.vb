Public Class OggettoProvvedimenti
    Inherits System.ComponentModel.Component

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    'OggettoDettaglioAtto
    <Serializable()> _
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

    'OggettoArticoloRuoloAccertamento
    <Serializable()> _
    Public Class OggettoArticoloRuoloAccertamento

        Public Sub New()
        End Sub

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

    End Class

    'OggettoAttoTARSU
    <Serializable()> _
    Public Class OggettoAttoTARSU

        Public Sub New()
        End Sub

        Private _nIdProvvedimento As Integer = -1
        Private _sEnte As String = ""
        Private _sTributo As String = ""
        Private _sAnno As String = ""
        Private _nIdContribuente As Integer = -1
        'Private _oAnagrafica As DettaglioAnagrafica
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
        Private _sNavviso As String = ""
        Private _sNatto As String = ""
        Private _ImpImposta As Double = 0
        Private _ImpSanzioni As Double = 0
        Private _ImpSanzioniRid As Double = 0
        Private _ImpSanzioniNonRid As Double = 0
        Private _ImpInteressi As Double = 0
        Private _ImpAltro As Double = 0
        Private _ImpNetto As Double = 0
        Private _ImpArrotondamento As Double = 0
        Private _ImpArrotondamentoRid As Double = 0
        Private _ImpSpese As Double = 0
        Private _ImpTotale As Double = 0
        Private _ImpTotaleRid As Double = 0
        Private _sDataConsegna As String = ""
        Private _sDataNotifica As String = ""
        Private _sDataRettifica As String = ""
        Private _sDataAnnullamento As String = ""
        Private _sDataPervenutoIl As String = ""
        Private _sDataScadenzaQuestionario As String = ""
        Private _sDataRimborso As String = ""
        Private _sDataSospensioneAutotutela As String = ""
        Private _sDataPresentRicorso As String = ""
        Private _sDataSospensioneCommTribut As String = ""
        Private _sDataSentenza As String = ""
        Private _sDataAttoDefinitivo As String = ""
        Private _sDataUnicaSoluzione As String = ""
        Private _sDataRateizzazione As String = ""
        Private _ImpPagato As Double = 0
        Private _sDataElaborazione As String = ""
        Private _sDataConferma As String = ""
        Private _sDataStampa As String = ""
        Private _sDataSollecitoBon As String = ""
        Private _sDataRuoloOrdinario As String = ""
        Private _sDataRuoloCoattivo As String = ""
        Private _sDataPresentRicorsoReg As String = ""
        Private _sDataSospensioneCommTributReg As String = ""
        Private _sDataSentenzaReg As String = ""
        Private _sDataPresentRicorsoCassaz As String = ""
        Private _sDataSospensioneCommTributCassaz As String = ""
        Private _sDataSentenzaCassaz As String = ""
        Private _nProgElaborazione As Integer = -1
        Private _sNoteProv As String = ""
        Private _sNoteReg As String = ""
        Private _sNoteCassaz As String = ""
        Private _nEsito As Integer = -1
        Private _sTermineRicorsoAcc As String = ""
        Private _sNoteAccertamento As String = ""
        Private _sNoteConciliazione As String = ""
        Private _isFlagAccertamento As Boolean = False
        Private _isFlagConciliazione As Boolean = False
        Private _ImpRuoloCoattivo As Double = 0
        Private _sNoteAtto As String = ""

        Public Property nIdProvvedimento() As Integer
            Get
                Return _nIdProvvedimento
            End Get
            Set(ByVal Value As Integer)
                _nIdProvvedimento = Value
            End Set
        End Property

        Public Property sTributo() As String
            Get
                Return _sTributo
            End Get
            Set(ByVal Value As String)
                _sTributo = Value
            End Set
        End Property

        Public Property sAnno() As String
            Get
                Return _sAnno
            End Get
            Set(ByVal Value As String)
                _sAnno = Value
            End Set
        End Property

        Public Property sEnte() As String
            Get
                Return _sEnte
            End Get
            Set(ByVal Value As String)
                _sEnte = Value
            End Set
        End Property

        Public Property nIdContribuente() As Integer
            Get
                Return _nIdContribuente
            End Get
            Set(ByVal Value As Integer)
                _nIdContribuente = Value
            End Set
        End Property
        '''Public Property oAnagrafica() As DettaglioAnagrafica
        '''    Get
        '''        Return _oAnagrafica
        '''    End Get
        '''    Set(ByVal Value As DettaglioAnagrafica)
        '''        _oAnagrafica = Value
        '''    End Set
        '''End Property
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

        Public Property sNavviso() As Integer
            Get
                Return _sNavviso
            End Get
            Set(ByVal Value As Integer)
                _sNavviso = Value
            End Set
        End Property
        Public Property sNatto() As String
            Get
                Return _sNatto
            End Get
            Set(ByVal Value As String)
                _sNatto = Value
            End Set
        End Property
        Public Property ImpImposta() As Double
            Get
                Return _ImpImposta
            End Get
            Set(ByVal Value As Double)
                _ImpImposta = Value
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
        Public Property ImpSanzioniRid() As Double
            Get
                Return _ImpSanzioniRid
            End Get
            Set(ByVal Value As Double)
                _ImpSanzioniRid = Value
            End Set
        End Property
        Public Property ImpSanzioniNonRid() As Double
            Get
                Return _ImpSanzioniNonRid
            End Get
            Set(ByVal Value As Double)
                _ImpSanzioniNonRid = Value
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
        Public Property ImpAltro() As Double
            Get
                Return _ImpAltro
            End Get
            Set(ByVal Value As Double)
                _ImpAltro = Value
            End Set
        End Property
        Public Property ImpNetto() As Double
            Get
                Return _ImpNetto
            End Get
            Set(ByVal Value As Double)
                _ImpNetto = Value
            End Set
        End Property
        Public Property ImpArrotondamento() As Double
            Get
                Return _ImpArrotondamento
            End Get
            Set(ByVal Value As Double)
                _ImpArrotondamento = Value
            End Set
        End Property
        Public Property ImpArrotondamentoRid() As Double
            Get
                Return _ImpArrotondamentoRid
            End Get
            Set(ByVal Value As Double)
                _ImpArrotondamentoRid = Value
            End Set
        End Property
        Public Property ImpSpese() As Double
            Get
                Return _ImpSpese
            End Get
            Set(ByVal Value As Double)
                _ImpSpese = Value
            End Set
        End Property
        Public Property ImpTotale() As Double
            Get
                Return _ImpTotale
            End Get
            Set(ByVal Value As Double)
                _ImpTotale = Value
            End Set
        End Property
        Public Property ImpTotaleRid() As Double
            Get
                Return _ImpTotaleRid
            End Get
            Set(ByVal Value As Double)
                _ImpTotaleRid = Value
            End Set
        End Property
        Public Property sDataConsegna() As String
            Get
                Return _sDataConsegna
            End Get
            Set(ByVal Value As String)
                _sDataConsegna = Value
            End Set
        End Property

        Public Property sDataNotifica() As String
            Get
                Return _sDataNotifica
            End Get
            Set(ByVal Value As String)
                _sDataNotifica = Value
            End Set
        End Property
        Public Property sDataRettifica() As String
            Get
                Return _sDataRettifica
            End Get
            Set(ByVal Value As String)
                _sDataRettifica = Value
            End Set
        End Property
        Public Property sDataAnnullamento() As String
            Get
                Return _sDataAnnullamento
            End Get
            Set(ByVal Value As String)
                _sDataAnnullamento = Value
            End Set
        End Property
        Public Property sDataPervenutoIl() As String
            Get
                Return _sDataPervenutoIl
            End Get
            Set(ByVal Value As String)
                _sDataPervenutoIl = Value
            End Set
        End Property
        Public Property sDataScadenzaQuestionario() As String
            Get
                Return _sDataScadenzaQuestionario
            End Get
            Set(ByVal Value As String)
                _sDataScadenzaQuestionario = Value
            End Set
        End Property
        Public Property sDataRimborso() As String
            Get
                Return _sDataRimborso
            End Get
            Set(ByVal Value As String)
                _sDataRimborso = Value
            End Set
        End Property
        Public Property sDataSospensioneAutotutela() As String
            Get
                Return _sDataSospensioneAutotutela
            End Get
            Set(ByVal Value As String)
                _sDataSospensioneAutotutela = Value
            End Set
        End Property
        Public Property sDataPresentRicorso() As String
            Get
                Return _sDataPresentRicorso
            End Get
            Set(ByVal Value As String)
                _sDataPresentRicorso = Value
            End Set
        End Property
        Public Property sDataSospensioneCommTribut() As String
            Get
                Return _sDataSospensioneCommTribut
            End Get
            Set(ByVal Value As String)
                _sDataSospensioneCommTribut = Value
            End Set
        End Property
        Public Property sDataSentenza() As String
            Get
                Return _sDataSentenza
            End Get
            Set(ByVal Value As String)
                _sDataSentenza = Value
            End Set
        End Property
        Public Property sDataAttoDefinitivo() As String
            Get
                Return _sDataAttoDefinitivo
            End Get
            Set(ByVal Value As String)
                _sDataAttoDefinitivo = Value
            End Set
        End Property
        Public Property sDataUnicaSoluzione() As String
            Get
                Return _sDataUnicaSoluzione
            End Get
            Set(ByVal Value As String)
                _sDataUnicaSoluzione = Value
            End Set
        End Property
        Public Property sDataRateizzazione() As String
            Get
                Return _sDataRateizzazione
            End Get
            Set(ByVal Value As String)
                _sDataRateizzazione = Value
            End Set
        End Property

        Public Property ImpPagato() As Double
            Get
                Return _ImpPagato
            End Get
            Set(ByVal Value As Double)
                _ImpPagato = Value
            End Set
        End Property

        Public Property sDataElaborazione() As String
            Get
                Return _sDataElaborazione
            End Get
            Set(ByVal Value As String)
                _sDataElaborazione = Value
            End Set
        End Property
        Public Property sDataConferma() As String
            Get
                Return _sDataConferma
            End Get
            Set(ByVal Value As String)
                _sDataConferma = Value
            End Set
        End Property
        Public Property sDataSollecitoBon() As String
            Get
                Return _sDataSollecitoBon
            End Get
            Set(ByVal Value As String)
                _sDataSollecitoBon = Value
            End Set
        End Property

        Public Property sDataRuoloOrdinario() As String
            Get
                Return _sDataRuoloOrdinario
            End Get
            Set(ByVal Value As String)
                _sDataRuoloOrdinario = Value
            End Set
        End Property

        Public Property sDataRuoloCoattivo() As String
            Get
                Return _sDataRuoloCoattivo
            End Get
            Set(ByVal Value As String)
                _sDataRuoloCoattivo = Value
            End Set
        End Property

        Public Property sDataPresentRicorsoReg() As String
            Get
                Return _sDataPresentRicorsoReg
            End Get
            Set(ByVal Value As String)
                _sDataPresentRicorsoReg = Value
            End Set
        End Property

        Public Property sDataSospensioneCommTributReg() As String
            Get
                Return _sDataSospensioneCommTributReg
            End Get
            Set(ByVal Value As String)
                _sDataSospensioneCommTributReg = Value
            End Set
        End Property

        Public Property sDataSentenzaReg() As String
            Get
                Return _sDataSentenzaReg
            End Get
            Set(ByVal Value As String)
                _sDataSentenzaReg = Value
            End Set
        End Property

        Public Property sDataPresentRicorsoCassaz() As String
            Get
                Return _sDataPresentRicorsoCassaz
            End Get
            Set(ByVal Value As String)
                _sDataPresentRicorsoCassaz = Value
            End Set
        End Property

        Public Property sDataSospensioneCommTributCassaz() As String
            Get
                Return _sDataSospensioneCommTributCassaz
            End Get
            Set(ByVal Value As String)
                _sDataSospensioneCommTributCassaz = Value
            End Set
        End Property

        Public Property sDataSentenzaCassaz() As String
            Get
                Return _sDataSentenzaCassaz
            End Get
            Set(ByVal Value As String)
                _sDataSentenzaCassaz = Value
            End Set
        End Property

        Public Property nProgElaborazione() As Integer
            Get
                Return _nProgElaborazione
            End Get
            Set(ByVal Value As Integer)
                _nProgElaborazione = Value
            End Set
        End Property
        Public Property sNoteProv() As String
            Get
                Return _sNoteProv
            End Get
            Set(ByVal Value As String)
                _sNoteProv = Value
            End Set
        End Property
        Public Property sNoteReg() As String
            Get
                Return _sNoteReg
            End Get
            Set(ByVal Value As String)
                _sNoteReg = Value
            End Set
        End Property
        Public Property sNoteCassaz() As String
            Get
                Return _sNoteCassaz
            End Get
            Set(ByVal Value As String)
                _sNoteCassaz = Value
            End Set
        End Property
        Public Property nEsito() As Integer
            Get
                Return _nEsito
            End Get
            Set(ByVal Value As Integer)
                _nEsito = Value
            End Set
        End Property
        Public Property sTermineRicorsoAcc() As String
            Get
                Return _sTermineRicorsoAcc
            End Get
            Set(ByVal Value As String)
                _sTermineRicorsoAcc = Value
            End Set
        End Property
        Public Property sNoteAccertamento() As String
            Get
                Return _sNoteAccertamento
            End Get
            Set(ByVal Value As String)
                _sNoteAccertamento = Value
            End Set
        End Property
        Public Property sNoteConciliazione() As String
            Get
                Return _sNoteConciliazione
            End Get
            Set(ByVal Value As String)
                _sNoteConciliazione = Value
            End Set
        End Property
        Public Property isFlagAccertamento() As Boolean
            Get
                Return _isFlagAccertamento
            End Get
            Set(ByVal Value As Boolean)
                _isFlagAccertamento = Value
            End Set
        End Property
        Public Property isFlagConciliazione() As Boolean
            Get
                Return _isFlagConciliazione
            End Get
            Set(ByVal Value As Boolean)
                _isFlagConciliazione = Value
            End Set
        End Property
        Public Property ImpRuoloCoattivo() As Double
            Get
                Return _ImpRuoloCoattivo
            End Get
            Set(ByVal Value As Double)
                _ImpRuoloCoattivo = Value
            End Set
        End Property

        Public Property sNoteAtto() As String
            Get
                Return _sNoteAtto
            End Get
            Set(ByVal Value As String)
                _sNoteAtto = Value
            End Set
        End Property
    End Class

    'OggettoAddizionaleAccertamento
    <Serializable()> _
    Public Class OggettoAddizionaleAccertamento

        Public Sub New()
        End Sub

        Dim _idAddizionale As Integer = -1
        Dim _sAnno As String = ""
        Dim _sCodiceCapitolo As String = ""
        Dim _nValore As Double = 0
        Dim _dImportoCalcolato As Double = 0
        Dim _sDescrizione As String = ""

        Public Property idAddizionale() As Integer
            Get
                Return _idAddizionale
            End Get

            Set(ByVal Value As Integer)
                _idAddizionale = Value
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

        Public Property CodiceCapitolo() As String
            Get
                Return _sCodiceCapitolo
            End Get

            Set(ByVal Value As String)
                _sCodiceCapitolo = Value
            End Set
        End Property

        Public Property Valore() As Double
            Get
                Return _nValore
            End Get

            Set(ByVal Value As Double)
                _nValore = Value
            End Set
        End Property

        Public Property ImportoCalcolato() As Double
            Get
                Return _dImportoCalcolato
            End Get

            Set(ByVal Value As Double)
                _dImportoCalcolato = Value
            End Set
        End Property

        Public Property Descrizione() As String
            Get
                Return _sDescrizione
            End Get

            Set(ByVal Value As String)
                _sDescrizione = Value
            End Set
        End Property

    End Class



End Class
