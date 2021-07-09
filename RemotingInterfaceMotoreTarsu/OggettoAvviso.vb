Namespace MotoreTarsuVARIABILE.Oggetti
    <Serializable()>
    Public Class ObjRuolo
        '*** 20131104 - TARES ***
        Public Class Generazione
            Public Const DaDichiarazione As String = "A"
            Public Const Manuale As String = "M"
            '*** 201809 Bollettazione Vigliano in OPENgov***
            Public Const DaFlusso As String = "F"
            '*** ***
        End Class
        Public Class Ruolo
            Public Const APercentuale As String = "P"
            Public Const AConguaglio As String = "C"
            Public Const Singolo As String = "S"
            '**** 201809 - Cartelle Insoluti ***
            Public Const CartelleInsoluti As String = "I"
            '*** ***
        End Class
        '*** 20131104 - TARES ***
        Public Class TipoCalcolo
            Public Const TARSU As String = "TARSU"
            Public Const TARES As String = "TARES"
        End Class

        Private _IdFlusso As Integer
        Private _sEnte As String
        Private _sTipoRuolo As String
        Private _sAnno As String
        Private _sNomeRuolo As String
        Private _sDescrRuolo As String
        Private _sDescrizioneTipoRuolo As String
        Private _nNumeroRuolo As Integer
        Private _nTassazioneMinima As Integer
        Private _ImpMinimo As Double
        Private _sNote As String
        Private _soperatore As String
        '***dati da elaborare***
        Private _nTessere As Integer
        Private _nKG As Double
        Private _nTesNoUI As Integer
        Private _nTesBidone As Integer
        '***dati elaborazione***
        Private _nContribuenti As Integer
        Private _nArticoli As Integer
        Private _nAvvisi As Integer
        Private _nScarti As Integer
        Private _nMQ As Double
        Private _ImpArticoli As Double
        Private _ImpRiduzione As Double
        Private _ImpDetassazione As Double
        Private _ImpNetto As Double
        Private _ImpPF As Double
        Private _ImpPV As Double
        Private _ImpCartellato As Double
        '***date elaborazione***
        Private _tDataCreazione As Date
        Private _tDataStampaMinuta As Date
        Private _tDataOKMinuta As Date
        Private _tDataCartellazione As Date
        Private _tDataElabDoc As Date
        Private _tDataOKDoc As Date
        '***oggetti associati***
        Private _oAvvisi() As ObjAvviso
        Private _oRate() As MotoreTarsu.Oggetti.OggettoDatiRata
        Private _oAddizionali() As MotoreTarsu.Oggetti.OggettoAddizionale
        '*** 20131104 - TARES ***
        Private _TipoMQ As String
        Private _HasMaggiorazione As Boolean
        Private _HasConferimenti As Boolean
        Private _impPM As Double
        Private _impPC As Double
        Private _nUtentiDom As Integer
        Private _nUtentiNonDom As Integer
        Private _nMQDom As Double
        Private _nMQNonDom As Double
        Private _nConferimenti As Integer
        Private _sTipoCalcolo As String
        Private _PercentTariffe As Double
        Private _impAddizionali As Double
        '*** ***
        Private _tDataInizioConf As DateTime
        '*** 20181011 Dal/Al Conferimenti ***
        Private _tDataFineConf As DateTime
        '*** 201809 Bollettazione Vigliano in OPENgov ***
        Private _TipoGenerazione As String = "D"




        Public Property IdFlusso() As Integer
            Get
                Return _IdFlusso
            End Get
            Set(ByVal Value As Integer)
                _IdFlusso = Value
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
        Public Property sTipoRuolo() As String
            Get
                Return _sTipoRuolo
            End Get
            Set(ByVal Value As String)
                _sTipoRuolo = Value
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
        Public Property sNomeRuolo() As String
            Get
                Return _sNomeRuolo
            End Get
            Set(ByVal Value As String)
                _sNomeRuolo = Value
            End Set
        End Property
        Public Property sDescrRuolo() As String
            Get
                Return _sDescrRuolo
            End Get
            Set(ByVal Value As String)
                _sDescrRuolo = Value
            End Set
        End Property
        Public Property sDescrTipoRuolo() As String
            Get
                Return _sDescrizioneTipoRuolo
            End Get
            Set(ByVal Value As String)
                _sDescrizioneTipoRuolo = Value
            End Set
        End Property
        Public Property nNumeroRuolo() As Integer
            Get
                Return _nNumeroRuolo
            End Get
            Set(ByVal Value As Integer)
                _nNumeroRuolo = Value
            End Set
        End Property
        Public Property nTassazioneMinima() As Integer
            Get
                Return _nTassazioneMinima
            End Get
            Set(ByVal Value As Integer)
                _nTassazioneMinima = Value
            End Set
        End Property
        Public Property ImpMinimo() As Double
            Get
                Return _ImpMinimo
            End Get
            Set(ByVal Value As Double)
                _ImpMinimo = Value
            End Set
        End Property
        Public Property sNote() As String
            Get
                Return _sNote
            End Get
            Set(ByVal Value As String)
                _sNote = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _soperatore
            End Get
            Set(ByVal Value As String)
                _soperatore = Value
            End Set
        End Property
        '***dati da elaborare***
        Public Property nTessere() As Integer
            Get
                Return _nTessere
            End Get
            Set(ByVal Value As Integer)
                _nTessere = Value
            End Set
        End Property
        Public Property nKG() As Double
            Get
                Return _nKG
            End Get
            Set(ByVal Value As Double)
                _nKG = Value
            End Set
        End Property
        Public Property nTesNoUI() As Integer
            Get
                Return _nTesNoUI
            End Get
            Set(ByVal Value As Integer)
                _nTesNoUI = Value
            End Set
        End Property
        Public Property nTesBidone() As Integer
            Get
                Return _nTesBidone
            End Get
            Set(ByVal Value As Integer)
                _nTesBidone = Value
            End Set
        End Property
        '***dati elaborazione***
        Public Property nContribuenti() As Integer
            Get
                Return _nContribuenti
            End Get
            Set(ByVal Value As Integer)
                _nContribuenti = Value
            End Set
        End Property
        Public Property nArticoli() As Integer
            Get
                Return _nArticoli
            End Get
            Set(ByVal Value As Integer)
                _nArticoli = Value
            End Set
        End Property
        Public Property nAvvisi() As Integer
            Get
                Return _nAvvisi
            End Get
            Set(ByVal Value As Integer)
                _nAvvisi = Value
            End Set
        End Property
        Public Property nScarti() As Integer
            Get
                Return _nScarti
            End Get
            Set(ByVal Value As Integer)
                _nScarti = Value
            End Set
        End Property
        Public Property nMQ() As Double
            Get
                Return _nMQ
            End Get
            Set(ByVal Value As Double)
                _nMQ = Value
            End Set
        End Property
        Public Property ImpArticoli() As Double
            Get
                Return _ImpArticoli
            End Get
            Set(ByVal Value As Double)
                _ImpArticoli = Value
            End Set
        End Property
        Public Property ImpRiduzione() As Double
            Get
                Return _ImpRiduzione
            End Get
            Set(ByVal Value As Double)
                _ImpRiduzione = Value
            End Set
        End Property
        Public Property ImpDetassazione() As Double
            Get
                Return _ImpDetassazione
            End Get
            Set(ByVal Value As Double)
                _ImpDetassazione = Value
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
        Public Property ImpPF() As Double
            Get
                Return _ImpPF
            End Get
            Set(ByVal Value As Double)
                _ImpPF = Value
            End Set
        End Property
        Public Property ImpPV() As Double
            Get
                Return _ImpPV
            End Get
            Set(ByVal Value As Double)
                _ImpPV = Value
            End Set
        End Property
        Public Property ImpAvvisi() As Double
            Get
                Return _ImpCartellato
            End Get
            Set(ByVal Value As Double)
                _ImpCartellato = Value
            End Set
        End Property
        '***date elaborazione***
        Public Property tDataCreazione() As Date
            Get
                Return _tDataCreazione
            End Get
            Set(ByVal Value As Date)
                _tDataCreazione = Value
            End Set
        End Property
        Public Property tDataStampaMinuta() As Date
            Get
                Return _tDataStampaMinuta
            End Get
            Set(ByVal Value As Date)
                _tDataStampaMinuta = Value
            End Set
        End Property
        Public Property tDataOKMinuta() As Date
            Get
                Return _tDataOKMinuta
            End Get
            Set(ByVal Value As Date)
                _tDataOKMinuta = Value
            End Set
        End Property
        Public Property tDataCartellazione() As Date
            Get
                Return _tDataCartellazione
            End Get
            Set(ByVal Value As Date)
                _tDataCartellazione = Value
            End Set
        End Property
        Public Property tDataElabDoc() As Date
            Get
                Return _tDataElabDoc
            End Get
            Set(ByVal Value As Date)
                _tDataElabDoc = Value
            End Set
        End Property
        Public Property tDataOKDoc() As Date
            Get
                Return _tDataOKDoc
            End Get
            Set(ByVal Value As Date)
                _tDataOKDoc = Value
            End Set
        End Property
        '***oggetti associati***
        Public Property oAvvisi() As ObjAvviso()
            Get
                Return _oAvvisi
            End Get
            Set(ByVal Value As ObjAvviso())
                _oAvvisi = Value
            End Set
        End Property
        Public Property oRate() As MotoreTarsu.Oggetti.OggettoDatiRata()
            Get
                Return _oRate
            End Get
            Set(ByVal Value As MotoreTarsu.Oggetti.OggettoDatiRata())
                _oRate = Value
            End Set
        End Property
        Public Property oAddizionali() As MotoreTarsu.Oggetti.OggettoAddizionale()
            Get
                Return _oAddizionali
            End Get
            Set(ByVal Value As MotoreTarsu.Oggetti.OggettoAddizionale())
                _oAddizionali = Value
            End Set
        End Property
        '*** 20131104 - TARES ***
        Public Property TipoMQ() As String
            Get
                Return _TipoMQ
            End Get
            Set(ByVal Value As String)
                _TipoMQ = Value
            End Set
        End Property
        Public Property HasMaggiorazione() As Boolean
            Get
                Return _HasMaggiorazione
            End Get
            Set(ByVal Value As Boolean)
                _HasMaggiorazione = Value
            End Set
        End Property
        Public Property HasConferimenti() As Boolean
            Get
                Return _HasConferimenti
            End Get
            Set(ByVal Value As Boolean)
                _HasConferimenti = Value
            End Set
        End Property
        Public Property impPM() As Double
            Get
                Return _impPM
            End Get
            Set(ByVal Value As Double)
                _impPM = Value
            End Set
        End Property
        Public Property impPC() As Double
            Get
                Return _impPC
            End Get
            Set(ByVal Value As Double)
                _impPC = Value
            End Set
        End Property
        Public Property nUtentiDom() As Integer
            Get
                Return _nUtentiDom
            End Get
            Set(ByVal Value As Integer)
                _nUtentiDom = Value
            End Set
        End Property
        Public Property nUtentiNonDom() As Integer
            Get
                Return _nUtentiNonDom
            End Get
            Set(ByVal Value As Integer)
                _nUtentiNonDom = Value
            End Set
        End Property
        Public Property nMQDom() As Double
            Get
                Return _nMQDom
            End Get
            Set(ByVal Value As Double)
                _nMQDom = Value
            End Set
        End Property
        Public Property nMQNonDom() As Double
            Get
                Return _nMQNonDom
            End Get
            Set(ByVal Value As Double)
                _nMQNonDom = Value
            End Set
        End Property
        Public Property nConferimenti() As Integer
            Get
                Return _nConferimenti
            End Get
            Set(ByVal Value As Integer)
                _nConferimenti = Value
            End Set
        End Property
        Public Property sTipoCalcolo() As String
            Get
                Return _sTipoCalcolo
            End Get
            Set(ByVal Value As String)
                _sTipoCalcolo = Value
            End Set
        End Property
        Public Property PercentTariffe() As Double
            Get
                Return _PercentTariffe
            End Get
            Set(ByVal Value As Double)
                _PercentTariffe = Value
            End Set
        End Property
        Public Property impAddizionali() As Double
            Get
                Return _impAddizionali
            End Get
            Set(ByVal Value As Double)
                _impAddizionali = Value
            End Set
        End Property
        '*** ***
        Public Property tDataInizioConf() As Date
            Get
                Return _tDataInizioConf
            End Get
            Set(ByVal Value As Date)
                _tDataInizioConf = Value
            End Set
        End Property
        Public Property tDataFineConf() As Date
            Get
                Return _tDataFineConf
            End Get
            Set(value As Date)
                _tDataFineConf = value
            End Set
        End Property
        '*** 201809 Bollettazione Vigliano in OPENgov ***
        Public Property TipoGenerazione() As String
            Get
                Return _TipoGenerazione
            End Get
            Set(value As String)
                _TipoGenerazione = value
            End Set
        End Property

        Public Sub New()
            _IdFlusso = -1
            _sEnte = ""
            _sTipoRuolo = ""
            _sAnno = ""
            _sNomeRuolo = ""
            _sDescrRuolo = ""
            _sDescrizioneTipoRuolo = ""
            _nNumeroRuolo = 0
            _nTassazioneMinima = 0
            _ImpMinimo = 0
            _sNote = ""
            _soperatore = ""
            '***dati da elaborare***
            _nTessere = 0
            _nKG = 0
            _nTesNoUI = 0
            _nTesBidone = 0
            '***dati elaborazione***
            _nContribuenti = 0
            _nArticoli = 0
            _nAvvisi = 0
            _nScarti = 0
            _nMQ = 0
            _ImpArticoli = 0
            _ImpRiduzione = 0
            _ImpDetassazione = 0
            _ImpNetto = 0
            _ImpPF = 0
            _ImpPV = 0
            _ImpCartellato = 0
            _oAvvisi = Nothing
            '***date elaborazione***
            _tDataCreazione = Now.Today
            _tDataStampaMinuta = Date.MinValue
            _tDataOKMinuta = Date.MinValue
            _tDataCartellazione = Date.MinValue
            _tDataElabDoc = Date.MinValue
            _tDataOKDoc = Date.MinValue
            '***oggetti associati***
            _oAvvisi = Nothing
            _oRate = Nothing
            _oAddizionali = Nothing
            '*** 20131104 - TARES ***
            _TipoMQ = "D"
            _HasMaggiorazione = False
            _HasConferimenti = False
            _impPM = 0
            _impPC = 0
            _nUtentiDom = 0
            _nUtentiNonDom = 0
            _nMQDom = 0
            _nMQNonDom = 0
            _nConferimenti = 0
            _sTipoCalcolo = Ruolo.APercentuale
            _PercentTariffe = 100
            _impAddizionali = 0
            '*** ***
            _tDataInizioConf = Date.MinValue
            _tDataFineConf = Date.MinValue
            _TipoGenerazione = Generazione.DaDichiarazione
        End Sub
    End Class

    <Serializable()>
    Public Class ObjAvviso
        Private _id As Integer
        Private _idcontribuente As Integer
        Private _IdFlussoRuolo As Integer = -1
        Private _IdLottoCartellazione As Integer = -1
        Private _nCheckRuolo As Integer = 0       'variabile per la visualizzazione in griglia del tipo ruolo {0: avviso inserito; 1: avviso in ruolo elaborato; 2: avviso in ruolo spedito; 3: avviso con sgravio}
        Private _idente As String = ""
        Private _sCodiceCartella As String = ""
        Private _sCodiceCliente As String = ""
        Private _sAnnoRiferimento As String = ""
        Private _sAnniPresenzaRuolo As String = ""
        Private _sCognome As String = ""
        Private _sNome As String = ""
        Private _sCodiceFiscale As String = ""
        Private _sPartitaIVA As String = ""
        Private _tDataNascita As DateTime = Date.MaxValue
        Private _sComuneNascita As String = ""
        Private _sPVNascita As String = ""
        Private _sSesso As String = ""
        Private _sIndirizzoRes As String = ""
        Private _sCivicoRes As String = ""
        Private _sEsponenteRes As String = ""
        Private _sInternoRes As String = ""
        Private _sScalaRes As String = ""
        Private _sCAPRes As String = ""
        Private _sProvRes As String = ""
        Private _sComuneRes As String = ""
        Private _sFrazRes As String = ""
        Private _sNominativoCO As String = ""
        Private _sIndirizzoCO As String = ""
        Private _sCivicoCO As String = ""
        Private _sCAPCO As String = ""
        Private _sProvCO As String = ""
        Private _sComuneCO As String = ""
        Private _sFrazCO As String = ""
        Private _sCodStatoNazione As String = ""
        Private _snote As String = ""
        Private _soperatore As String = ""
        Private _nImportoPF As Double = 0
        Private _nImportoPV As Double = 0
        Private _nImportoTotale As Double = 0
        Private _nImportoArrotondamento As Double = 0
        Private _nImportoCarico As Double = 0
        Private _nIdProgressivo As Integer = -1
        Private _bSelezionato As Boolean = False
        Private _bIsSgravio As Boolean = False
        Private _ImportoPRESgravio As Double = -1
        Private _tDataEmissione As DateTime = Date.MinValue
        Private _tdatainserimento As Date = Date.MinValue
        Private _tdatavariazione As Date = Date.MinValue
        Private _tdatacessazione As Date = Date.MinValue
        Private _tessere() As ObjTessera
        Private _scaglioni() As ObjScaglione
        Private _ui() As ObjUnitaImmobiliare
        Private _articoli() As ObjArticolo
        Private _detvoci() As ObjDetVoci
        Private _rate() As ObjRata
        '*** 20131104 - TARES ***
        Private _impPC As Double = 0
        Private _impPM As Double = 0
        Private _impPagato As Double = 0
        Private _impSaldo As Double = 0
        Private _impCreditoDebitoPrec As Double = 0
        Private _impDovuto As Double = 0
        Private _oPagamenti() As MotoreTarsu.Oggetti.OggettoPagamenti
        '*** ***
        '*** 20140630 - SUPPLETIVO/CONGUAGLIO ***
        Private _oArticoliPrec() As ObjArticolo
        '*** ***
        '**** 201809 - Cartelle Insoluti ***
        Private _tDataNotifica As DateTime = Date.MaxValue
        Private _RifNotifica As String
        Private _tDataAccertamento As DateTime = Date.MaxValue
        '*** ***

        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal Value As Integer)
                _id = Value
            End Set
        End Property
        Public Property IdContribuente() As Integer
            Get
                Return _idcontribuente
            End Get
            Set(ByVal Value As Integer)
                _idcontribuente = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _idente
            End Get
            Set(ByVal Value As String)
                _idente = Value
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
        Public Property sCodiceCliente() As String
            Get
                Return _sCodiceCliente
            End Get

            Set(ByVal Value As String)
                _sCodiceCliente = Value
            End Set
        End Property
        Public Property sCodiceCartella() As String
            Get
                Return _sCodiceCartella
            End Get

            Set(ByVal Value As String)
                _sCodiceCartella = Value
            End Set
        End Property
        Public Property tDataEmissione() As Date
            Get
                Return _tDataEmissione
            End Get

            Set(ByVal Value As Date)
                _tDataEmissione = Value
            End Set
        End Property
        Public Property sAnnoRiferimento() As String
            Get
                Return _sAnnoRiferimento
            End Get

            Set(ByVal Value As String)
                _sAnnoRiferimento = Value
            End Set
        End Property
        Public Property nLottoCartellazione() As Integer
            Get
                Return _IdLottoCartellazione
            End Get

            Set(ByVal Value As Integer)
                _IdLottoCartellazione = Value
            End Set
        End Property
        Public Property nCheckRuolo() As Integer
            Get
                Return _nCheckRuolo
            End Get

            Set(ByVal Value As Integer)
                _nCheckRuolo = Value
            End Set
        End Property
        Public Property sAnniPresenzaRuolo() As String
            Get
                Return _sAnniPresenzaRuolo
            End Get

            Set(ByVal Value As String)
                _sAnniPresenzaRuolo = Value
            End Set
        End Property
        Public Property sCognome() As String
            Get
                Return _sCognome
            End Get

            Set(ByVal Value As String)
                _sCognome = Value
            End Set
        End Property
        Public Property sNome() As String
            Get
                Return _sNome
            End Get

            Set(ByVal Value As String)
                _sNome = Value
            End Set
        End Property
        Public Property sCodFiscale() As String
            Get
                Return _sCodiceFiscale
            End Get

            Set(ByVal Value As String)
                _sCodiceFiscale = Value
            End Set
        End Property
        Public Property sPIVA() As String
            Get
                Return _sPartitaIVA
            End Get

            Set(ByVal Value As String)
                _sPartitaIVA = Value
            End Set
        End Property
        Public Property tDataNascita() As DateTime
            Get
                Return _tDataNascita
            End Get

            Set(ByVal Value As DateTime)
                _tDataNascita = Value
            End Set
        End Property
        Public Property sComuneNascita() As String
            Get
                Return _sComuneNascita
            End Get

            Set(ByVal Value As String)
                _sComuneNascita = Value
            End Set
        End Property
        Public Property sPVNascita() As String
            Get
                Return _sPVNascita
            End Get

            Set(ByVal Value As String)
                _sPVNascita = Value
            End Set
        End Property
        Public Property sSesso() As String
            Get
                Return _sSesso
            End Get

            Set(ByVal Value As String)
                _sSesso = Value
            End Set
        End Property
        Public Property sIndirizzoRes() As String
            Get
                Return _sIndirizzoRes
            End Get

            Set(ByVal Value As String)
                _sIndirizzoRes = Value
            End Set
        End Property
        Public Property sCivicoRes() As String
            Get
                Return _sCivicoRes
            End Get

            Set(ByVal Value As String)
                _sCivicoRes = Value
            End Set
        End Property
        Public Property sEsponenteRes() As String
            Get
                Return _sEsponenteRes
            End Get
            Set(ByVal Value As String)
                _sEsponenteRes = Value
            End Set
        End Property
        Public Property sInternoRes() As String
            Get
                Return _sInternoRes
            End Get
            Set(ByVal Value As String)
                _sInternoRes = Value
            End Set
        End Property
        Public Property sScalaRes() As String
            Get
                Return _sScalaRes
            End Get
            Set(ByVal Value As String)
                _sScalaRes = Value
            End Set
        End Property
        Public Property sCAPRes() As String
            Get
                Return _sCAPRes
            End Get

            Set(ByVal Value As String)
                _sCAPRes = Value
            End Set
        End Property
        Public Property sProvRes() As String
            Get
                Return _sProvRes
            End Get

            Set(ByVal Value As String)
                _sProvRes = Value
            End Set
        End Property
        Public Property sComuneRes() As String
            Get
                Return _sComuneRes
            End Get

            Set(ByVal Value As String)
                _sComuneRes = Value
            End Set
        End Property
        Public Property sFrazRes() As String
            Get
                Return _sFrazRes
            End Get

            Set(ByVal Value As String)
                _sFrazRes = Value
            End Set
        End Property
        Public Property sNominativoCO() As String
            Get
                Return _sNominativoCO
            End Get

            Set(ByVal Value As String)
                _sNominativoCO = Value
            End Set
        End Property
        Public Property sIndirizzoCO() As String
            Get
                Return _sIndirizzoCO
            End Get

            Set(ByVal Value As String)
                _sIndirizzoCO = Value
            End Set
        End Property
        Public Property sCivicoCO() As String
            Get
                Return _sCivicoCO
            End Get

            Set(ByVal Value As String)
                _sCivicoCO = Value
            End Set
        End Property
        Public Property sCAPCO() As String
            Get
                Return _sCAPCO
            End Get

            Set(ByVal Value As String)
                _sCAPCO = Value
            End Set
        End Property
        Public Property sProvCO() As String
            Get
                Return _sProvCO
            End Get

            Set(ByVal Value As String)
                _sProvCO = Value
            End Set
        End Property
        Public Property sComuneCO() As String
            Get
                Return _sComuneCO
            End Get

            Set(ByVal Value As String)
                _sComuneCO = Value
            End Set
        End Property
        Public Property sFrazCO() As String
            Get
                Return _sFrazCO
            End Get

            Set(ByVal Value As String)
                _sFrazCO = Value
            End Set
        End Property
        Public Property sCodStatoNazione() As String
            Get
                Return _sCodStatoNazione
            End Get

            Set(ByVal Value As String)
                _sCodStatoNazione = Value
            End Set
        End Property
        Public Property sNote() As String
            Get
                Return _snote
            End Get
            Set(ByVal Value As String)
                _snote = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _soperatore
            End Get
            Set(ByVal Value As String)
                _soperatore = Value
            End Set
        End Property
        Public Property impPF() As Double
            Get
                Return _nImportoPF
            End Get

            Set(ByVal Value As Double)
                _nImportoPF = Value
            End Set
        End Property
        Public Property impPV() As Double
            Get
                Return _nImportoPV
            End Get

            Set(ByVal Value As Double)
                _nImportoPV = Value
            End Set
        End Property
        Public Property impTotale() As Double
            Get
                Return _nImportoTotale
            End Get

            Set(ByVal Value As Double)
                _nImportoTotale = Value
            End Set
        End Property
        Public Property impArrotondamento() As Double
            Get
                Return _nImportoArrotondamento
            End Get

            Set(ByVal Value As Double)
                _nImportoArrotondamento = Value
            End Set
        End Property
        Public Property impCarico() As Double
            Get
                Return _nImportoCarico
            End Get

            Set(ByVal Value As Double)
                _nImportoCarico = Value
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
        Public Property impPRESgravio() As Double
            Get
                Return _ImportoPRESgravio
            End Get

            Set(ByVal Value As Double)
                _ImportoPRESgravio = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tdatainserimento
            End Get
            Set(ByVal Value As Date)
                _tdatainserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tdatavariazione
            End Get
            Set(ByVal Value As Date)
                _tdatavariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tdatacessazione
            End Get
            Set(ByVal Value As Date)
                _tdatacessazione = Value
            End Set
        End Property
        Public Property oTessere() As ObjTessera()
            Get
                Return _tessere
            End Get
            Set(ByVal Value As ObjTessera())
                _tessere = Value
            End Set
        End Property
        Public Property oScaglioni() As ObjScaglione()
            Get
                Return _scaglioni
            End Get
            Set(ByVal Value As ObjScaglione())
                _scaglioni = Value
            End Set
        End Property
        Public Property oUI() As ObjUnitaImmobiliare()
            Get
                Return _ui
            End Get
            Set(ByVal Value As ObjUnitaImmobiliare())
                _ui = Value
            End Set
        End Property
        Public Property oArticoli() As ObjArticolo()
            Get
                Return _articoli
            End Get
            Set(ByVal Value As ObjArticolo())
                _articoli = Value
            End Set
        End Property
        Public Property oDetVoci() As ObjDetVoci()
            Get
                Return _detvoci
            End Get
            Set(ByVal Value As ObjDetVoci())
                _detvoci = Value
            End Set
        End Property
        Public Property oRate() As ObjRata()
            Get
                Return _rate
            End Get
            Set(ByVal Value As ObjRata())
                _rate = Value
            End Set
        End Property
        '*** 20131104 - TARES ***
        Public Property impPC() As Double
            Get
                Return _impPC
            End Get

            Set(ByVal Value As Double)
                _impPC = Value
            End Set
        End Property
        Public Property impPM() As Double
            Get
                Return _impPM
            End Get

            Set(ByVal Value As Double)
                _impPM = Value
            End Set
        End Property
        Public Property impPagato() As Double
            Get
                Return _impPagato
            End Get

            Set(ByVal Value As Double)
                _impPagato = Value
            End Set
        End Property
        Public Property impSaldo() As Double
            Get
                Return _impSaldo
            End Get

            Set(ByVal Value As Double)
                _impSaldo = Value
            End Set
        End Property
        Public Property impCreditoDebitoPrec() As Double
            Get
                Return _impCreditoDebitoPrec
            End Get

            Set(ByVal Value As Double)
                _impCreditoDebitoPrec = Value
            End Set
        End Property
        Public Property impDovuto() As Double
            Get
                Return _impDovuto
            End Get

            Set(ByVal Value As Double)
                _impDovuto = Value
            End Set
        End Property
        Public Property oPagamenti() As MotoreTarsu.Oggetti.OggettoPagamenti()
            Get
                Return _oPagamenti
            End Get

            Set(ByVal Value As MotoreTarsu.Oggetti.OggettoPagamenti())
                _oPagamenti = Value
            End Set
        End Property
        '*** ***
        '*** 20140630 - SUPPLETIVO/CONGUAGLIO ***
        Public Property oArticoliPrec() As ObjArticolo()
            Get
                Return _oArticoliPrec
            End Get
            Set(ByVal value As ObjArticolo())
                _oArticoliPrec = value
            End Set
        End Property
        '*** ***
        '**** 201809 - Cartelle Insoluti ***
        Public Property tDataNotifica As DateTime
            Get
                Return _tDataNotifica
            End Get
            Set(value As DateTime)
                _tDataNotifica = value
            End Set
        End Property
        Public Property RifNotifica As String
            Get
                Return _rifnotifica
            End Get
            Set(value As String)
                _rifnotifica = value
            End Set
        End Property
        Public Property tDataAccertamento As DateTime
            Get
                Return _tDataAccertamento
            End Get
            Set(value As DateTime)
                _tDataAccertamento = value
            End Set
        End Property
        '*** ***
    End Class

    <Serializable()>
    Public Class ObjTestata
        Private _Id As Integer = -1
        Private _IdTestata As Integer = -1
        Private _sEnte As String = ""
        Private _IdContribuente As Integer = -1
        Private _tDataDichiarazione As Date = Nothing
        Private _sNDichiarazione As String = ""
        Private _tDataProtocollo As Date = Nothing
        Private _sNProtocollo As String = ""
        Private _sIdProvenienza As String = ""
        Private _sNoteDichiarazione As String = ""
        Private _tDataInserimento As Date = Nothing
        Private _tDataVariazione As Date = Nothing
        Private _tDataCessazione As Date = Nothing
        Private _sOperatore As String = ""
        Private _oTessere() As ObjTessera
        Private _oTesUI() As ObjTesseraUI
        '*** X UNIONE CON BANCADATI CMGC ***
        Private _oImmobili() As ObjDettaglioTestata = Nothing
        '*** ***
        Private _oFamiglia() As ObjFamiglia
        Private _dvFamigliaRes As DataView
        Private _oAnagrafe As AnagInterface.DettaglioAnagrafica

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
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
        Public Property IdTestata() As Integer
            Get
                Return _IdTestata
            End Get
            Set(ByVal Value As Integer)
                _IdTestata = Value
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
        Public Property tDataDichiarazione() As Date
            Get
                Return _tDataDichiarazione
            End Get
            Set(ByVal Value As Date)
                _tDataDichiarazione = Value
            End Set
        End Property
        Public Property sNDichiarazione() As String
            Get
                Return _sNDichiarazione
            End Get
            Set(ByVal Value As String)
                _sNDichiarazione = Value
            End Set
        End Property
        Public Property tDataProtocollo() As Date
            Get
                Return _tDataProtocollo
            End Get
            Set(ByVal Value As Date)
                _tDataProtocollo = Value
            End Set
        End Property
        Public Property sNProtocollo() As String
            Get
                Return _sNProtocollo
            End Get
            Set(ByVal Value As String)
                _sNProtocollo = Value
            End Set
        End Property
        Public Property sIdProvenienza() As String
            Get
                Return _sIdProvenienza
            End Get
            Set(ByVal Value As String)
                _sIdProvenienza = Value
            End Set
        End Property
        Public Property sNoteDichiarazione() As String
            Get
                Return _sNoteDichiarazione
            End Get
            Set(ByVal Value As String)
                _sNoteDichiarazione = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
        Public Property oTessere() As ObjTessera()
            Get
                Return _oTessere
            End Get
            Set(ByVal Value As ObjTessera())
                _oTessere = Value
            End Set
        End Property
        Public Property oTesUI() As ObjTesseraUI()
            Get
                Return _oTesUI
            End Get
            Set(ByVal Value As ObjTesseraUI())
                _oTesUI = Value
            End Set
        End Property
        '*** X UNIONE CON BANCADATI CMGC ***
        Public Property oImmobili() As ObjDettaglioTestata()
            Get
                Return _oImmobili
            End Get
            Set(ByVal Value As ObjDettaglioTestata())
                _oImmobili = Value
            End Set
        End Property
        '*** ***
        Public Property oFamiglia() As ObjFamiglia()
            Get
                Return _oFamiglia
            End Get
            Set(ByVal Value As ObjFamiglia())
                _oFamiglia = Value
            End Set
        End Property
        Public Property dvFamigliaResidenti As DataView
            Get
                Return _dvFamigliaRes
            End Get
            Set(ByVal Value As DataView)
                _dvFamigliaRes = Value
            End Set
        End Property
        Public Property oAnagrafe() As AnagInterface.DettaglioAnagrafica
            Get
                Return _oAnagrafe
            End Get
            Set(ByVal Value As AnagInterface.DettaglioAnagrafica)
                _oAnagrafe = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjTessera
        Public Const TESSERA_BIDONE As String = "NO-TESSERA"
        Private _Id As Integer = -1
        Private _IdTessera As Integer = -1
        Private _IdTestata As Integer = -1
        Private _IdEnte As String = ""
        Private _IdContribuente As Integer = -1
        Private _sCodInterno As String = ""
        Private _sCodUtente As String = ""
        Private _sNumeroTessera As String = TESSERA_BIDONE
        Private _tDataRilascio As Date = Date.MinValue
        Private _sNote As String = ""
        Private _tDataInserimento As Date = Date.MinValue
        Private _tDataVariazione As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue
        Private _sOperatore As String = ""
        Private _oImmobili() As ObjDettaglioTestata = Nothing
        Private _oRiduzioni() As ObjRidEseApplicati = Nothing
        Private _oDetassazioni() As ObjRidEseApplicati = Nothing
        Private _oPesature() As ObjPesatura = Nothing
        '*** 201511 - gestione tipo tessera ***
        Private _idTipoTessera As Integer = -1
        '*** ***

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdTessera() As Integer
            Get
                Return _IdTessera
            End Get
            Set(ByVal Value As Integer)
                _IdTessera = Value
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
        Public Property IdEnte() As String
            Get
                Return _IdEnte
            End Get
            Set(ByVal Value As String)
                _IdEnte = Value
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
        Public Property sCodUtente() As String
            Get
                Return _sCodUtente
            End Get
            Set(ByVal Value As String)
                _sCodUtente = Value
            End Set
        End Property
        Public Property sCodInterno() As String
            Get
                Return _sCodInterno
            End Get
            Set(ByVal Value As String)
                _sCodInterno = Value
            End Set
        End Property
        Public Property sNumeroTessera() As String
            Get
                Return _sNumeroTessera
            End Get
            Set(ByVal Value As String)
                _sNumeroTessera = Value
            End Set
        End Property
        Public Property tDataRilascio() As Date
            Get
                Return _tDataRilascio
            End Get
            Set(ByVal Value As Date)
                _tDataRilascio = Value
            End Set
        End Property
        Public Property sNote() As String
            Get
                Return _sNote
            End Get
            Set(ByVal Value As String)
                _sNote = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
        Public Property oImmobili() As ObjDettaglioTestata()
            Get
                Return _oImmobili
            End Get
            Set(ByVal Value As ObjDettaglioTestata())
                _oImmobili = Value
            End Set
        End Property
        Public Property oRiduzioni() As ObjRidEseApplicati()
            Get
                Return _oRiduzioni
            End Get
            Set(ByVal Value As ObjRidEseApplicati())
                _oRiduzioni = Value
            End Set
        End Property
        Public Property oDetassazioni() As ObjRidEseApplicati()
            Get
                Return _oDetassazioni
            End Get
            Set(ByVal Value As ObjRidEseApplicati())
                _oDetassazioni = Value
            End Set
        End Property
        Public Property oPesature() As ObjPesatura()
            Get
                Return _oPesature
            End Get
            Set(ByVal Value As ObjPesatura())
                _oPesature = Value
            End Set
        End Property
        '*** 201511 - gestione tipo tessera ***
        Public Property IdTipoTessera() As Integer
            Get
                Return _idTipoTessera
            End Get
            Set(value As Integer)
                _idTipoTessera = value
            End Set
        End Property
        '*** ***
    End Class

    <Serializable()>
    Public Class ObjDettaglioTestata
        Private _Id As Integer = -1
        '*** X UNIONE CON BANCADATI CMGC ***
        Private _IdTestata As Integer = -1
        '*** ***
        Private _IdTessera As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _IdPadre As Integer = -1
        Private _sCodVia As String = "-1"
        Private _sVia As String = ""
        Private _sCivico As String = ""
        Private _sEsponente As String = ""
        Private _sInterno As String = ""
        Private _sScala As String = ""
        Private _sFoglio As String = ""
        Private _sNumero As String = ""
        Private _sSubalterno As String = ""
        Private _tDataInizio As Date = Nothing
        Private _tDataFine As Date = Nothing
        Private _nVani As Integer = 0
        Private _nMQ As Double = 0
        Private _nMQAnater As Double = 0
        Private _nGGTarsu As Integer = -1
        Private _nNComponenti As Integer = -1
        Private _sIdStatoOccupazione As String = ""
        Private _sDescrOccupazione As String = ""
        Private _sNomeProprietario As String = ""
        Private _sNomeOccupantePrec As String = ""
        Private _sNoteUI As String = ""
        Private _sCatCatastale As String = ""
        Private _tDataInserimento As Date = Nothing
        Private _tDataVariazione As Date = Nothing
        Private _tDataCessazione As Date = Nothing
        Private _sOperatore As String = ""
        Private _oOggetti() As ObjOggetti
        Private _oRiduzioni() As ObjRidEseApplicati
        Private _oDetassazioni() As ObjRidEseApplicati
        '***Agenzia Entrate***
        Private _nIdTitoloOccupaz As Integer = -1
        Private _nIdNaturaOccupaz As Integer = -1
        Private _nIdDestUso As Integer = -1
        Private _sIdTipoUnita As String = ""
        Private _sIdTipoParticella As String = ""
        Private _nIdAssenzaDatiCatastali As Integer = 0
        Private _sSezione As String = ""
        Private _sEstensioneParticella As String = ""
        '*********************
        Private _nMQCatasto As Double = 0
        '*** ***
        '*** 20130325 - gestione mq tassabili per TARES ***
        Private _nMQTassabili As Double = 0
        '*** ***
        '*** 20130228 - gestione categoria Ateco per TARES ***
        Private _IdCatAteco As Integer = 0
        Private _sCatAteco As String = ""
        Private _nComponentiPV As Integer = 0
        Private _bForzaPV As Boolean = False
        '*** ***
        Private _CodImmobile As String = ""
        Private _ProgImmobile As Integer = 0
        Private _Key As String = ""
        '*** ***
        ' BD 09/07/2021
        Private _nImportoFissoRid As Double = 0
        Public Property ImportoFissoRid() As Double
            Get
                Return _nImportoFissoRid
            End Get
            Set(ByVal Value As Double)
                _nImportoFissoRid = Value
            End Set
        End Property
        ' BD 09/07/2021

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
        '*** X UNIONE CON BANCADATI CMGC ***
        Public Property IdTestata() As Integer
            Get
                Return _IdTestata
            End Get
            Set(ByVal Value As Integer)
                _IdTestata = Value
            End Set
        End Property
        '*** ***
        Public Property IdTessera() As Integer
            Get
                Return _IdTessera
            End Get
            Set(ByVal Value As Integer)
                _IdTessera = Value
            End Set
        End Property
        Public Property IdPadre() As Integer
            Get
                Return _IdPadre
            End Get
            Set(ByVal Value As Integer)
                _IdPadre = Value
            End Set
        End Property
        Public Property sCodVia() As String
            Get
                Return _sCodVia
            End Get
            Set(ByVal Value As String)
                _sCodVia = Value
            End Set
        End Property
        Public Property sVia() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property
        Public Property sCivico() As String
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As String)
                _sCivico = Value
            End Set
        End Property
        Public Property sEsponente() As String
            Get
                Return _sEsponente
            End Get
            Set(ByVal Value As String)
                _sEsponente = Value
            End Set
        End Property
        Public Property sInterno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property
        Public Property sScala() As String
            Get
                Return _sScala
            End Get
            Set(ByVal Value As String)
                _sScala = Value
            End Set
        End Property
        Public Property sFoglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property sNumero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property sSubalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property tDataInizio() As Date
            Get
                Return _tDataInizio
            End Get
            Set(ByVal Value As Date)
                _tDataInizio = Value
            End Set
        End Property
        Public Property tDataFine() As Date
            Get
                Return _tDataFine
            End Get
            Set(ByVal Value As Date)
                _tDataFine = Value
            End Set
        End Property
        Public Property nVani() As Integer
            Get
                Return _nVani
            End Get
            Set(ByVal Value As Integer)
                _nVani = Value
            End Set
        End Property
        Public Property nMQ() As Double
            Get
                Return _nMQ
            End Get
            Set(ByVal Value As Double)
                _nMQ = Value
            End Set
        End Property
        Public Property nMQAnater() As Double
            Get
                Return _nMQAnater
            End Get
            Set(ByVal Value As Double)
                _nMQAnater = Value
            End Set
        End Property
        Public Property nGGTarsu() As Integer
            Get
                Return _nGGTarsu
            End Get
            Set(ByVal Value As Integer)
                _nGGTarsu = Value
            End Set
        End Property
        Public Property sIdStatoOccupazione() As String
            Get
                Return _sIdStatoOccupazione
            End Get
            Set(ByVal Value As String)
                _sIdStatoOccupazione = Value
            End Set
        End Property
        Public Property sDescrOccupazione() As String
            Get
                Return _sDescrOccupazione
            End Get
            Set(ByVal Value As String)
                _sDescrOccupazione = Value
            End Set
        End Property
        Public Property nNComponenti() As Integer
            Get
                Return _nNComponenti
            End Get
            Set(ByVal Value As Integer)
                _nNComponenti = Value
            End Set
        End Property
        Public Property sNomeProprietario() As String
            Get
                Return _sNomeProprietario
            End Get
            Set(ByVal Value As String)
                _sNomeProprietario = Value
            End Set
        End Property
        Public Property sNomeOccupantePrec() As String
            Get
                Return _sNomeOccupantePrec
            End Get
            Set(ByVal Value As String)
                _sNomeOccupantePrec = Value
            End Set
        End Property
        Public Property sNoteUI() As String
            Get
                Return _sNoteUI
            End Get
            Set(ByVal Value As String)
                _sNoteUI = Value
            End Set
        End Property
        Public Property sCatCatastale() As String
            Get
                Return _sCatCatastale
            End Get
            Set(ByVal Value As String)
                _sCatCatastale = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
        Public Property oOggetti() As ObjOggetti()
            Get
                Return _oOggetti
            End Get
            Set(ByVal Value As ObjOggetti())
                _oOggetti = Value
            End Set
        End Property
        Public Property oRiduzioni() As ObjRidEseApplicati()
            Get
                Return _oRiduzioni
            End Get
            Set(ByVal Value As ObjRidEseApplicati())
                _oRiduzioni = Value
            End Set
        End Property
        Public Property oDetassazioni() As ObjRidEseApplicati()
            Get
                Return _oDetassazioni
            End Get
            Set(ByVal Value As ObjRidEseApplicati())
                _oDetassazioni = Value
            End Set
        End Property
        Public Property nIdTitoloOccupaz() As Integer
            Get
                Return _nIdTitoloOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdTitoloOccupaz = Value
            End Set
        End Property
        Public Property nIdNaturaOccupaz() As Integer
            Get
                Return _nIdNaturaOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdNaturaOccupaz = Value
            End Set
        End Property
        Public Property nIdDestUso() As Integer
            Get
                Return _nIdDestUso
            End Get
            Set(ByVal Value As Integer)
                _nIdDestUso = Value
            End Set
        End Property
        Public Property sIdTipoUnita() As String
            Get
                Return _sIdTipoUnita
            End Get
            Set(ByVal Value As String)
                _sIdTipoUnita = Value
            End Set
        End Property
        Public Property sIdTipoParticella() As String
            Get
                Return _sIdTipoParticella
            End Get
            Set(ByVal Value As String)
                _sIdTipoParticella = Value
            End Set
        End Property
        Public Property nIdAssenzaDatiCatastali() As Integer
            Get
                Return _nIdAssenzaDatiCatastali
            End Get
            Set(ByVal Value As Integer)
                _nIdAssenzaDatiCatastali = Value
            End Set
        End Property
        Public Property sSezione() As String
            Get
                Return _sSezione
            End Get
            Set(ByVal Value As String)
                _sSezione = Value
            End Set
        End Property
        Public Property sEstensioneParticella() As String
            Get
                Return _sEstensioneParticella
            End Get
            Set(ByVal Value As String)
                _sEstensioneParticella = Value
            End Set
        End Property
        '*** 20130201 - gestione mq da catasto per TARES ***
        Public Property nMQCatasto() As Double
            Get
                Return _nMQCatasto
            End Get
            Set(ByVal Value As Double)
                _nMQCatasto = Value
            End Set
        End Property
        '*** ***
        '*** 20130325 - gestione mq tassabili per TARES ***
        Public Property nMQTassabili() As Double
            Get
                Return _nMQTassabili
            End Get
            Set(ByVal Value As Double)
                _nMQTassabili = Value
            End Set
        End Property
        '*** ***
        '*** 20130228 - gestione categoria Ateco per TARES ***
        Public Property IdCatAteco() As Integer
            Get
                Return _IdCatAteco
            End Get
            Set(ByVal Value As Integer)
                _IdCatAteco = Value
            End Set
        End Property
        Public Property sCatAteco() As String
            Get
                Return _sCatAteco
            End Get
            Set(ByVal Value As String)
                _sCatAteco = Value
            End Set
        End Property
        Public Property nComponentiPV() As Integer
            Get
                Return _nComponentiPV
            End Get
            Set(ByVal Value As Integer)
                _nComponentiPV = Value
            End Set
        End Property
        Public Property bForzaPV() As Boolean
            Get
                Return _bForzaPV
            End Get
            Set(ByVal Value As Boolean)
                _bForzaPV = Value
            End Set
        End Property
        '*** ***
        Public Property CodImmobile() As String
            Get
                Return _CodImmobile
            End Get
            Set(ByVal Value As String)
                _CodImmobile = Value
            End Set
        End Property
        Public Property ProgImmobile() As Integer
            Get
                Return _ProgImmobile
            End Get
            Set(ByVal Value As Integer)
                _ProgImmobile = Value
            End Set
        End Property
        Public Property Key() As String
            Get
                Return _Key
            End Get
            Set(ByVal Value As String)
                _Key = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjOggetti
        Private _IdOggetto As Integer = -1
        Private _IdOggettoOld As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _IdCategoria As String = "-1"
        Private _sCategoria As String = ""
        Private _IdTipoVano As String = ""
        Private _sTipoVano As String = ""
        Private _nVani As Integer = 0
        Private _nMq As Double = 0
        Private _sProvenienza As String = ""
        Private _tDataInserimento As Date = Nothing
        Private _tDataVariazione As Date = Nothing
        Private _tDataCessazione As Date = Nothing
        Private _sOperatore As String = ""
        '*** 20130325 - gestione mq tassabili per TARES ***
        Private _bIsEsente As Boolean = False
        '*** ***
        '*** 20140805 - Gestione Categorie Vani ***
        Private _IdCatTARES As Integer = -1
        Private _sDescrCatTARES As String = ""
        Private _nNC As Integer = 0
        Private _nNCPV As Integer = 0
        Private _bForzaCalcolaPV As Boolean = False
        '*** ***
        Public Property IdOggetto() As Integer
            Get
                Return _IdOggetto
            End Get
            Set(ByVal Value As Integer)
                _IdOggetto = Value
            End Set
        End Property
        Public Property IdOggettoOld() As Integer
            Get
                Return _IdOggettoOld
            End Get
            Set(ByVal Value As Integer)
                _IdOggettoOld = Value
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
        Public Property IdCategoria() As String
            Get
                Return _IdCategoria
            End Get
            Set(ByVal Value As String)
                _IdCategoria = Value
            End Set
        End Property
        Public Property sCategoria() As String
            Get
                Return _sCategoria
            End Get
            Set(ByVal Value As String)
                _sCategoria = Value
            End Set
        End Property
        Public Property IdTipoVano() As String
            Get
                Return _IdTipoVano
            End Get
            Set(ByVal Value As String)
                _IdTipoVano = Value
            End Set
        End Property
        Public Property sTipoVano() As String
            Get
                Return _sTipoVano
            End Get
            Set(ByVal Value As String)
                _sTipoVano = Value
            End Set
        End Property
        Public Property nVani() As Integer
            Get
                Return _nVani
            End Get
            Set(ByVal Value As Integer)
                _nVani = Value
            End Set
        End Property
        Public Property nMq() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property
        Public Property sProvenienza() As String
            Get
                Return _sProvenienza
            End Get
            Set(ByVal Value As String)
                _sProvenienza = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
        '*** 20130325 - gestione mq tassabili per TARES ***
        Public Property bIsEsente() As Boolean
            Get
                Return _bIsEsente
            End Get
            Set(ByVal Value As Boolean)
                _bIsEsente = Value
            End Set
        End Property
        '*** ***
        '*** 20140805 - Gestione Categorie Vani ***
        Public Property IdCatTARES() As Integer
            Get
                Return _IdCatTARES
            End Get
            Set(ByVal Value As Integer)
                _IdCatTARES = Value
            End Set
        End Property
        Public Property sDescrCatTARES() As String
            Get
                Return _sDescrCatTARES
            End Get
            Set(ByVal Value As String)
                _sDescrCatTARES = Value
            End Set
        End Property
        Public Property nNC() As Integer
            Get
                Return _nNC
            End Get
            Set(ByVal Value As Integer)
                _nNC = Value
            End Set
        End Property
        Public Property nNCPV() As Integer
            Get
                Return _nNCPV
            End Get
            Set(ByVal Value As Integer)
                _nNCPV = Value
            End Set
        End Property
        Public Property bForzaCalcolaPV() As Boolean
            Get
                Return _bForzaCalcolaPV
            End Get
            Set(ByVal Value As Boolean)
                _bForzaCalcolaPV = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjRidEse
        Public Const TIPO_RIDUZIONI As String = "RIDUZIONI"
        Public Const TIPO_ESENZIONI As String = "DETASSAZIONI"
        Dim _id As Integer = 0
        Dim _idente As String = ""
        Dim _Codice As String = ""
        Dim _descrizione As String = ""
        Dim _descrtipo As String = ""
        Dim _descrapplicazione As String = ""
        Dim _anno As String = ""
        Dim _TipoOggetto As String = ""
        Dim _TipoValore As String = ""
        Dim _valore As String = ""
        Dim _tipoapplicazione As Integer = -1
        Dim _datainiziovalidita As Date = Date.MinValue
        Dim _datafinevalidita As Date = Date.MinValue

        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal Value As Integer)
                _id = Value
            End Set
        End Property
        Public Property nTipoApplicazione() As Integer
            Get
                Return _tipoapplicazione
            End Get
            Set(ByVal Value As Integer)
                _tipoapplicazione = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _idente
            End Get
            Set(ByVal Value As String)
                _idente = Value
            End Set
        End Property
        Public Property sCodice() As String
            Get
                Return _Codice
            End Get
            Set(ByVal Value As String)
                _Codice = Value
            End Set
        End Property
        Public Property sDescrizione() As String
            Get
                Return _descrizione
            End Get
            Set(ByVal Value As String)
                _descrizione = Value
            End Set
        End Property
        Public Property sDescrTipo() As String
            Get
                Return _descrtipo
            End Get
            Set(ByVal Value As String)
                _descrtipo = Value
            End Set
        End Property
        Public Property sDescrApplicazione() As String
            Get
                Return _descrapplicazione
            End Get
            Set(ByVal Value As String)
                _descrapplicazione = Value
            End Set
        End Property
        Public Property sAnno() As String
            Get
                Return _anno
            End Get
            Set(ByVal Value As String)
                _anno = Value
            End Set
        End Property
        Public Property sTipoOggetto() As String
            Get
                Return _TipoOggetto
            End Get
            Set(ByVal Value As String)
                _TipoOggetto = Value
            End Set
        End Property
        Public Property sTipoValore() As String
            Get
                Return _TipoValore
            End Get
            Set(ByVal Value As String)
                _TipoValore = Value
            End Set
        End Property

        Public Property sValore() As String
            Get
                Return _valore
            End Get
            Set(ByVal Value As String)
                _valore = Value
            End Set
        End Property

        Public Property tDataInizioValidita() As Date
            Get
                Return _datainiziovalidita
            End Get
            Set(ByVal Value As Date)
                _datainiziovalidita = Value
            End Set
        End Property

        Public Property tDataFineValidita() As Date
            Get
                Return _datafinevalidita
            End Get
            Set(ByVal Value As Date)
                _datafinevalidita = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjRidEseApplicati
        Inherits ObjRidEse
        Public Const RIF_UI As String = "UNITA IMMOBILIARE"
        Public Const RIF_TESSERA As String = "TESSERA"
        Public Const RIF_ARTICOLO As String = "ARTICOLO"
        Private _Riferimento As String = RIF_UI
        Private _IdRiferimento As Integer = -1

        Public Property Riferimento() As String
            Get
                Return _Riferimento
            End Get
            Set(ByVal Value As String)
                _Riferimento = Value
            End Set
        End Property
        Public Property IdRiferimento() As Integer
            Get
                Return _IdRiferimento
            End Get
            Set(ByVal Value As Integer)
                _IdRiferimento = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjCodDescr
        Public Const TIPO_RIDUZIONI As String = "TIPORIDUZIONI"
        Public Const TIPO_ESENZIONI As String = "TIPODETASSAZIONI"
        Public Const TIPO_CATEGORIE As String = "CATEGORIE"
        Dim _idente As String = ""
        Dim _Codice As String = ""
        Dim _Descrizione As String = ""
        Dim _id As Integer = -1

        Public Property IdEnte() As String
            Get
                Return _idente
            End Get
            Set(ByVal Value As String)
                _idente = Value
            End Set
        End Property
        Public Property sCodice() As String
            Get
                Return _Codice
            End Get
            Set(ByVal Value As String)
                _Codice = Value
            End Set
        End Property
        Public Property sDescrizione() As String
            Get
                Return _Descrizione
            End Get
            Set(ByVal Value As String)
                _Descrizione = Value
            End Set
        End Property
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal Value As Integer)
                _id = Value
            End Set
        End Property
    End Class

    '  <Serializable()> _
    'Public Class ObjRiduzione
    '      Inherits ObjRidEseApplicati

    '      Sub New()
    '          Tipo = ObjCodDescr.TIPO_RIDUZIONI
    '      End Sub
    '  End Class

    '  <Serializable()> _
    'Public Class ObjDetassazione
    '      Inherits ObjRidEseApplicati

    '      Sub New()
    '          Tipo = ObjCodDescr.TIPO_ESENZIONI
    '      End Sub
    '  End Class

    <Serializable()>
    Public Class ObjTariffa
        Dim _id As Integer = 0
        Dim _idente As String = ""
        Dim _Codice As String = ""
        Dim _descrizione As String = ""
        Dim _anno As String = ""
        Dim _valore As String = ""
        Dim _datainiziovalidita As Date = Date.MinValue
        Dim _datafinevalidita As Date = Date.MinValue

        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal Value As Integer)
                _id = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _idente
            End Get
            Set(ByVal Value As String)
                _idente = Value
            End Set
        End Property
        Public Property sCodice() As String
            Get
                Return _Codice
            End Get
            Set(ByVal Value As String)
                _Codice = Value
            End Set
        End Property
        Public Property sDescrizione() As String
            Get
                Return _descrizione
            End Get
            Set(ByVal Value As String)
                _descrizione = Value
            End Set
        End Property
        Public Property sAnno() As String
            Get
                Return _anno
            End Get
            Set(ByVal Value As String)
                _anno = Value
            End Set
        End Property
        Public Property sValore() As String
            Get
                Return _valore
            End Get
            Set(ByVal Value As String)
                _valore = Value
            End Set
        End Property
        Public Property tDataInizioValidita() As Date
            Get
                Return _datainiziovalidita
            End Get
            Set(ByVal Value As Date)
                _datainiziovalidita = Value
            End Set
        End Property
        Public Property tDataFineValidita() As Date
            Get
                Return _datafinevalidita
            End Get
            Set(ByVal Value As Date)
                _datafinevalidita = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjFamiglia
        Private _IdFamiglia As Integer = -1
        Private _IdTestata As Integer = -1
        Private _sCognome As String = ""
        Private _sNome As String = ""
        Private _tDataNascita As Date = Nothing
        Private _sLuogoNascita As String = ""
        Private _sParentela As String = ""
        Private _sDescrParentela As String = ""

        Public Property IdFamiglia() As Integer
            Get
                Return _IdFamiglia
            End Get
            Set(ByVal Value As Integer)
                _IdFamiglia = Value
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
        Public Property sCognome() As String
            Get
                Return _sCognome
            End Get
            Set(ByVal Value As String)
                _sCognome = Value
            End Set
        End Property
        Public Property sNome() As String
            Get
                Return _sNome
            End Get
            Set(ByVal Value As String)
                _sNome = Value
            End Set
        End Property
        Public Property tDataNascita() As Date
            Get
                Return _tDataNascita
            End Get
            Set(ByVal Value As Date)
                _tDataNascita = Value
            End Set
        End Property
        Public Property sLuogoNascita() As String
            Get
                Return _sLuogoNascita
            End Get
            Set(ByVal Value As String)
                _sLuogoNascita = Value
            End Set
        End Property
        Public Property sParentela() As String
            Get
                Return _sParentela
            End Get
            Set(ByVal Value As String)
                _sParentela = Value
            End Set
        End Property
        Public Property sDescrParentela() As String
            Get
                Return _sDescrParentela
            End Get
            Set(ByVal Value As String)
                _sDescrParentela = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjScaglione
        Private _Id As Long = -1
        Private _nIdAvviso As Long = -1
        Private _IdConferimento As Integer = -1
        Private _sIdEnte As String = ""
        Private _sAnno As String = ""
        Private _nIdScaglione As Integer = -1
        Private _nDa As Integer = -1
        Private _nA As Integer = -1
        Private _nQuantita As Integer = -1
        Private _impTariffa As Double = 0
        Private _impMinimo As Double = 0
        Private _impScaglione As Double = 0
        Private _tDataInserimento As Date = Date.MinValue
        Private _tDataVariazione As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue
        Private _sOperatore As String = ""

        Public Property Id() As Long
            Get
                Return _Id
            End Get
            Set(ByVal Value As Long)
                _Id = Value
            End Set
        End Property
        Public Property IdAvviso() As Long
            Get
                Return _nIdAvviso
            End Get
            Set(ByVal Value As Long)
                _nIdAvviso = Value
            End Set
        End Property
        Public Property nIdConferimento() As Integer
            Get
                Return _IdConferimento
            End Get
            Set(ByVal Value As Integer)
                _IdConferimento = Value
            End Set
        End Property
        Public Property sIdEnte() As String
            Get
                Return _sIdEnte
            End Get
            Set(ByVal Value As String)
                _sIdEnte = Value
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
        Public Property nIdScaglione() As Integer
            Get
                Return _nIdScaglione
            End Get
            Set(ByVal Value As Integer)
                _nIdScaglione = Value
            End Set
        End Property
        Public Property nDa() As Integer
            Get
                Return _nDa
            End Get
            Set(ByVal Value As Integer)
                _nDa = Value
            End Set
        End Property
        Public Property nA() As Integer
            Get
                Return _nA
            End Get
            Set(ByVal Value As Integer)
                _nA = Value
            End Set
        End Property
        Public Property nQuantita() As Integer
            Get
                Return _nQuantita
            End Get
            Set(ByVal Value As Integer)
                _nQuantita = Value
            End Set
        End Property
        Public Property impTariffa() As Double
            Get
                Return _impTariffa
            End Get
            Set(ByVal Value As Double)
                _impTariffa = Value
            End Set
        End Property
        Public Property impMinimo() As Double
            Get
                Return _impMinimo
            End Get
            Set(ByVal Value As Double)
                _impMinimo = Value
            End Set
        End Property
        Public Property impScaglione() As Double
            Get
                Return _impScaglione
            End Get
            Set(ByVal Value As Double)
                _impScaglione = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjUnitaImmobiliare
        Inherits ObjDettaglioTestata
        Private _idcategoria As String
        Private _idtariffa As Integer
        Private _imptariffa As Double
        '*** 20131104 - TARES ***
        Private _TipoPartita As String
        Private _bIsImportoForzato As Boolean
        Private _impRuolo As Double
        '*** ***
        '*** 20141211 - legami PF-PV ***
        Private _listpfpv() As ObjLegamePFPV
        '*** ***
        Public Property IdCategoria() As String
            Get
                Return _idcategoria
            End Get
            Set(ByVal Value As String)
                _idcategoria = Value
            End Set
        End Property
        Public Property IdTariffa() As Integer
            Get
                Return _idtariffa
            End Get
            Set(ByVal Value As Integer)
                _idtariffa = Value
            End Set
        End Property
        Public Property impTariffa() As Double
            Get
                Return _imptariffa
            End Get
            Set(ByVal Value As Double)
                _imptariffa = Value
            End Set
        End Property
        Public Property TipoPartita() As String
            Get
                Return _TipoPartita
            End Get
            Set(ByVal Value As String)
                _TipoPartita = Value
            End Set
        End Property
        Public Property bIsImportoForzato() As Boolean
            Get
                Return _bIsImportoForzato
            End Get
            Set(ByVal Value As Boolean)
                _bIsImportoForzato = Value
            End Set
        End Property
        Public Property impRuolo() As Double
            Get
                Return _impRuolo
            End Get
            Set(ByVal Value As Double)
                _impRuolo = Value
            End Set
        End Property
        '*** 20141211 - legami PF-PV ***
        Public Property ListPFvsPV() As ObjLegamePFPV()
            Get
                Return _listpfpv
            End Get
            Set(value As ObjLegamePFPV())
                _listpfpv = value
            End Set
        End Property
        '*** ***
        Public Sub New()
            _idcategoria = ""
            _idtariffa = -1
            _imptariffa = 0
            _TipoPartita = ObjArticolo.PARTEFISSA
            _bIsImportoForzato = False
            _impRuolo = 0
            _listpfpv = Nothing
        End Sub
    End Class

    <Serializable()>
    Public Class ObjArticolo
        '*** 20131104 - TARES ***
        Public Const PARTEFISSA As String = "PF"
        Public Const PARTEVARIABILE As String = "PV"
        Public Const PARTEMAGGIORAZIONE As String = "PM"
        Public Const PARTECONFERIMENTI As String = "PC"
        Private _TipoPartita As String = "PF"
        Private _nComponentiPV As Integer = 0
        Private _bForzaPV As Boolean = False
        '*** ***
        '*** 20140630 - SUPPLETIVO/CONGUAGLIO ***
        Public Const PARTEPRECEMESSO_DESCR As String = "GIÀ EMESSO"
        '*** ***
        Private _Id As Integer = -1
        Private _IdArticolo As Integer = -1
        Private _IdContribuente As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _IdAvviso As Integer = -1
        Private _IdEnte As String = String.Empty
        Private _sAnno As String = String.Empty
        Private _sVia As String = String.Empty
        Private _sCivico As String = ""
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
        Private _sCategoria As String = String.Empty
        Private _sdescrCategoria As String = ""
        Private _nComponenti As Integer = 0
        Private _nTariffa As Integer = 0
        Private _ImpTariffa As Double = 0
        Private _nMq As Double = 0
        Private _nBimestri As Integer = 0
        Private _ImpRuolo As Double = 0
        Private _ImpRiduzione As Double = 0
        Private _ImpDetassazione As Double = 0
        Private _ImpNetto As Double = 0
        Private _IdFlussoRuolo As Integer = -1
        Private _ImportoForzato As Boolean = False
        Private _IsTarsuGiornaliera As Boolean = False
        Private _DataInizio As DateTime
        Private _DataFine As DateTime
        Private _Note As String = String.Empty
        Private _TipoRuolo As String = ""
        Private _CodVia As Integer = 0
        Private _oRiduzioni() As ObjRidEseApplicati
        Private _oDetassazioni() As ObjRidEseApplicati
        Private _tDataInserimento As Date = Date.MinValue
        Private _tDataVariazione As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue
        Private _sOperatore As String = ""
        '*** 20141211 - legami PF-PV ***
        Private _idoggetto As Integer = 0
        Private _listpfpv() As ObjLegamePFPV = Nothing
        'BD 09/07/2021
        Private _ImportoFissoRid As Double = 0

        Public Property ImportoFissoRid() As Double
            Get
                Return _ImportoFissoRid
            End Get
            Set(ByVal Value As Double)
                _ImportoFissoRid = Value
            End Set
        End Property
        'BD 09/07/2021

        '*** ***
        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdArticolo() As Integer
            Get
                Return _IdArticolo
            End Get
            Set(ByVal Value As Integer)
                _IdArticolo = Value
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
        Public Property IdAvviso() As Integer
            Get
                Return _IdAvviso
            End Get
            Set(ByVal Value As Integer)
                _IdAvviso = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _IdEnte
            End Get
            Set(ByVal Value As String)
                _IdEnte = Value
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
        Public Property sVia() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property
        Public Property sCivico() As String
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As String)
                _sCivico = Value
            End Set
        End Property
        Public Property sEsponente() As String
            Get
                Return _sEsponente
            End Get
            Set(ByVal Value As String)
                _sEsponente = Value
            End Set
        End Property
        Public Property sInterno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property
        Public Property sScala() As String
            Get
                Return _sScala
            End Get
            Set(ByVal Value As String)
                _sScala = Value
            End Set
        End Property
        Public Property sFoglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property sNumero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property sSubalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property nIdTitoloOccupaz() As Integer
            Get
                Return _nIdTitoloOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdTitoloOccupaz = Value
            End Set
        End Property
        Public Property nIdNaturaOccupaz() As Integer
            Get
                Return _nIdNaturaOccupaz
            End Get
            Set(ByVal Value As Integer)
                _nIdNaturaOccupaz = Value
            End Set
        End Property
        Public Property nIdDestUso() As Integer
            Get
                Return _nIdDestUso
            End Get
            Set(ByVal Value As Integer)
                _nIdDestUso = Value
            End Set
        End Property
        Public Property sIdTipoUnita() As String
            Get
                Return _sIdTipoUnita
            End Get
            Set(ByVal Value As String)
                _sIdTipoUnita = Value
            End Set
        End Property
        Public Property sIdTipoParticella() As String
            Get
                Return _sIdTipoParticella
            End Get
            Set(ByVal Value As String)
                _sIdTipoParticella = Value
            End Set
        End Property
        Public Property nIdAssenzaDatiCatastali() As Integer
            Get
                Return _nIdAssenzaDatiCatastali
            End Get
            Set(ByVal Value As Integer)
                _nIdAssenzaDatiCatastali = Value
            End Set
        End Property
        Public Property sSezione() As String
            Get
                Return _sSezione
            End Get
            Set(ByVal Value As String)
                _sSezione = Value
            End Set
        End Property
        Public Property sEstensioneParticella() As String
            Get
                Return _sEstensioneParticella
            End Get
            Set(ByVal Value As String)
                _sEstensioneParticella = Value
            End Set
        End Property
        Public Property sCategoria() As String
            Get
                Return _sCategoria
            End Get
            Set(ByVal Value As String)
                _sCategoria = Value
            End Set
        End Property
        Public Property sDescrCategoria() As String
            Get
                Return _sdescrCategoria
            End Get
            Set(ByVal Value As String)
                _sdescrCategoria = Value
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
        Public Property nIdTariffa() As Integer
            Get
                Return _nTariffa
            End Get
            Set(ByVal Value As Integer)
                _nTariffa = Value
            End Set
        End Property
        Public Property impTariffa() As Double
            Get
                Return _ImpTariffa
            End Get
            Set(ByVal Value As Double)
                _ImpTariffa = Value
            End Set
        End Property
        Public Property nMQ() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property
        Public Property nBimestri() As Integer
            Get
                Return _nBimestri
            End Get
            Set(ByVal Value As Integer)
                _nBimestri = Value
            End Set
        End Property
        Public Property impRuolo() As Double
            Get
                Return _ImpRuolo
            End Get
            Set(ByVal Value As Double)
                _ImpRuolo = Value
            End Set
        End Property
        Public Property impRiduzione() As Double
            Get
                Return _ImpRiduzione
            End Get
            Set(ByVal Value As Double)
                _ImpRiduzione = Value
            End Set
        End Property
        Public Property impDetassazione() As Double
            Get
                Return _ImpDetassazione
            End Get
            Set(ByVal Value As Double)
                _ImpDetassazione = Value
            End Set
        End Property
        Public Property impNetto() As Double
            Get
                Return _ImpNetto
            End Get
            Set(ByVal Value As Double)
                _ImpNetto = Value
            End Set
        End Property
        Public Property nIdFlussoRuolo() As Integer
            Get
                Return _IdFlussoRuolo
            End Get
            Set(ByVal Value As Integer)
                _IdFlussoRuolo = Value
            End Set
        End Property
        Public Property bIsImportoForzato() As Boolean
            Get
                Return _ImportoForzato
            End Get
            Set(ByVal Value As Boolean)
                _ImportoForzato = Value
            End Set
        End Property
        Public Property bIsTarsuGiornaliera() As Boolean
            Get
                Return _IsTarsuGiornaliera
            End Get
            Set(ByVal Value As Boolean)
                _IsTarsuGiornaliera = Value
            End Set
        End Property
        Public Property tDataInizio() As DateTime
            Get
                Return _DataInizio
            End Get
            Set(ByVal Value As DateTime)
                _DataInizio = Value
            End Set
        End Property
        Public Property tDataFine() As DateTime
            Get
                Return _DataFine
            End Get
            Set(ByVal Value As DateTime)
                _DataFine = Value
            End Set
        End Property
        Public Property sNote() As String
            Get
                Return _Note
            End Get
            Set(ByVal Value As String)
                _Note = Value
            End Set
        End Property
        Public Property sTipoRuolo() As String
            Get
                Return _TipoRuolo
            End Get
            Set(ByVal Value As String)
                _TipoRuolo = Value
            End Set
        End Property
        Public Property nCodVia() As Integer
            Get
                Return _CodVia
            End Get
            Set(ByVal Value As Integer)
                _CodVia = Value
            End Set
        End Property

        Public Property oRiduzioni() As ObjRidEseApplicati()
            Get
                Return _oRiduzioni
            End Get
            Set(ByVal Value As ObjRidEseApplicati())
                _oRiduzioni = Value
            End Set
        End Property
        Public Property oDetassazioni() As ObjRidEseApplicati()
            Get
                Return _oDetassazioni
            End Get
            Set(ByVal Value As ObjRidEseApplicati())
                _oDetassazioni = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
        '*** 20131104 - TARES ***
        Public Property TipoPartita() As String
            Get
                Return _TipoPartita
            End Get
            Set(ByVal Value As String)
                _TipoPartita = Value
            End Set
        End Property
        Public Property nComponentiPV() As Integer
            Get
                Return _nComponentiPV
            End Get
            Set(ByVal Value As Integer)
                _nComponentiPV = Value
            End Set
        End Property
        Public Property bForzaPV() As Boolean
            Get
                Return _bForzaPV
            End Get
            Set(ByVal Value As Boolean)
                _bForzaPV = Value
            End Set
        End Property
        '*** ***
        '*** 20141211 - legami PF-PV ***
        Public Property IdOggetto As Integer
            Get
                Return _idoggetto
            End Get
            Set(value As Integer)
                _idoggetto = value
            End Set
        End Property
        Public Property ListPFvsPV() As ObjLegamePFPV()
            Get
                Return _listpfpv
            End Get
            Set(value As ObjLegamePFPV())
                _listpfpv = value
            End Set
        End Property
        '*** ***
    End Class

    '*** 20140701 - IMU/TARES ***
    <Serializable()>
    Public Class ObjArticoloAccertamento
        Inherits ObjArticolo
        Private _IdProvvedimento As Integer = -1
        Private _IdLegame As Integer = 0
        Private _Progressivo As Integer = 0
        Private _Sanzioni As String = ""
        Private _sDescrSanzioni As String = ""
        Private _Interessi As String = ""
        Private _CalcolaInteressi As Boolean = False
        Private _ImpSanzioni As Double = 0
        Private _ImpSanzioniRid As Double = 0
        Private _ImpSanzioniNonRid As Double = 0
        Private _ImpInteressi As Double = 0
        Private _bIsRientrato As Boolean = False
        Private _sDataRientro As String = ""

        Public Property IdProvvedimento() As Integer
            Get
                Return _IdProvvedimento
            End Get
            Set(ByVal Value As Integer)
                _IdProvvedimento = Value
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
        Public Property sDescrSanzioni() As String
            Get
                Return _sDescrSanzioni
            End Get
            Set(ByVal Value As String)
                _sDescrSanzioni = Value
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
        Public Property bIsRientrato() As Boolean
            Get
                Return _bIsRientrato
            End Get
            Set(ByVal Value As Boolean)
                _bIsRientrato = Value
            End Set
        End Property
        Public Property sDataRientro() As String
            Get
                Return _sDataRientro
            End Get
            Set(ByVal Value As String)
                _sDataRientro = Value
            End Set
        End Property
    End Class
    '*** ***
    <Serializable()>
    Public Class ObjDetVoci
        '*** 201809 Bollettazione Vigliano in OPENgov ***'**** 201809 - Cartelle Insoluti ***
        Public Class Capitolo
            Public Const Imposta As String = "0000"
            Public Const Arrotondamento As String = "9999"
            Public Const ECA As String = "9986"
            Public Const MECA As String = "9987"
            Public Const AggioEnte As String = "0095"
            Public Const ProvincialeEnte As String = "0094"
            Public Const Provinciale As String = "9994"
            Public Const IVA As String = "9996"
            Public Const Maggiorazione As String = "3955"
            Public Const Sanzione As String = "2Y99"
            Public Const Interessi As String = "2Y98"
            Public Const SpeseNotifica As String = "2Z01"
            Public Const CreditoPrec As String = "0100"
        End Class
        Public Class Voce
            Public Const Imposta As Integer = -1
            Public Const Domestica As Integer = 1
            Public Const NonDomestica As Integer = 2
            Public Const NettoAnno As Integer = 101
            Public Const ConguaglioAnno As Integer = 102
        End Class
        '*** ***
        Private _IdDettaglio As Long = -1
        Private _nIdAvviso As Long = -1
        Private _sIdEnte As String = ""
        Private _sanno As String = ""
        Private _sCapitolo As String = Capitolo.Imposta
        Private _CodVoce As Integer = Voce.Imposta
        Private _sDescrizione As String = ""
        Private _nAliquota As Double = 0
        Private _impDettaglio As Double = 0
        Private _tDataInserimento As Date = Date.MinValue
        Private _tDataVariazione As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue
        Private _sOperatore As String = ""

        Public Property IdDettaglio() As Long
            Get
                Return _IdDettaglio
            End Get
            Set(ByVal Value As Long)
                _IdDettaglio = Value
            End Set
        End Property
        Public Property IdAvviso() As Long
            Get
                Return _nIdAvviso
            End Get
            Set(ByVal Value As Long)
                _nIdAvviso = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _sIdEnte
            End Get
            Set(ByVal Value As String)
                _sIdEnte = Value
            End Set
        End Property
        Public Property sAnno() As String
            Get
                Return _sanno
            End Get
            Set(ByVal Value As String)
                _sanno = Value
            End Set
        End Property
        Public Property sCapitolo() As String
            Get
                Return _sCapitolo
            End Get
            Set(ByVal Value As String)
                _sCapitolo = Value
            End Set
        End Property
        Public Property CodVoce() As Integer
            Get
                Return _CodVoce
            End Get
            Set(ByVal Value As Integer)
                _CodVoce = Value
            End Set
        End Property
        Public Property sDescrizione() As String
            Get
                Return _sDescrizione
            End Get
            Set(ByVal Value As String)
                _sDescrizione = Value
            End Set
        End Property
        Public Property nAliquota() As Double
            Get
                Return _nAliquota
            End Get
            Set(ByVal Value As Double)
                _nAliquota = Value
            End Set
        End Property
        Public Property impDettaglio() As Double
            Get
                Return _impDettaglio
            End Get
            Set(ByVal Value As Double)
                _impDettaglio = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjRata
        Private _Id As Integer = -1
        Private _IdAvviso As Integer = -1
        Private _IdContribuente As Integer = -1
        Private _IdFlussoRuolo As Integer = -1
        Private _IdEnte As String = ""
        Private _sNRata As String = ""
        Private _sDescrRata As String = ""
        Private _impRata As Double = 0
        Private _tDataEmissione As Date = Date.MinValue
        Private _tDataScadenza As Date = Date.MinValue
        Private _sCodiceCartella As String = ""
        Private _sCodBollettino As String = ""
        Private _sCodeline As String = ""
        Private _sCodiceBarcode As String = ""
        Private _sContoCorrente As String = ""
        Private _tDataInserimento As Date = Date.MinValue
        Private _tDataVariazione As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue
        Private _sOperatore As String = ""
        Private _ListDetVoci() As ObjRataDettaglio

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _IdEnte
            End Get
            Set(ByVal Value As String)
                _IdEnte = Value
            End Set
        End Property
        Public Property IdAvviso() As Integer
            Get
                Return _IdAvviso
            End Get
            Set(ByVal Value As Integer)
                _IdAvviso = Value
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
        Public Property sNRata() As String
            Get
                Return _sNRata
            End Get
            Set(ByVal Value As String)
                _sNRata = Value
            End Set
        End Property
        Public Property sDescrRata() As String
            Get
                Return _sDescrRata
            End Get
            Set(ByVal Value As String)
                _sDescrRata = Value
            End Set
        End Property
        Public Property impRata() As Double
            Get
                Return _impRata
            End Get
            Set(ByVal Value As Double)
                _impRata = Value
            End Set
        End Property
        Public Property tDataEmissione() As Date
            Get
                Return _tDataEmissione
            End Get
            Set(ByVal Value As Date)
                _tDataEmissione = Value
            End Set
        End Property
        Public Property tDataScadenza() As Date
            Get
                Return _tDataScadenza
            End Get
            Set(ByVal Value As Date)
                _tDataScadenza = Value
            End Set
        End Property
        Public Property sCodiceCartella() As String
            Get
                Return _sCodiceCartella
            End Get
            Set(ByVal Value As String)
                _sCodiceCartella = Value
            End Set
        End Property
        Public Property sCodBollettino() As String
            Get
                Return _sCodBollettino
            End Get
            Set(ByVal Value As String)
                _sCodBollettino = Value
            End Set
        End Property
        Public Property sCodeline() As String
            Get
                Return _sCodeline
            End Get
            Set(ByVal Value As String)
                _sCodeline = Value
            End Set
        End Property
        Public Property sCodiceBarcode() As String
            Get
                Return _sCodiceBarcode
            End Get
            Set(ByVal Value As String)
                _sCodiceBarcode = Value
            End Set
        End Property
        Public Property sContoCorrente() As String
            Get
                Return _sContoCorrente
            End Get
            Set(ByVal Value As String)
                _sContoCorrente = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
        Public Property oDetVoci() As ObjRataDettaglio()
            Get
                Return _ListDetVoci
            End Get
            Set(value As ObjRataDettaglio())
                _ListDetVoci = value
            End Set
        End Property
    End Class
    <Serializable()>
    Public Class ObjRataDettaglio
        Private _Id As Integer = -1
        Private _IdAvviso As Integer = -1
        Private _NRata As String = ""
        Private _Tributo As String = ""
        Private _Importo As Decimal = 0
        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdAvviso() As Integer
            Get
                Return _IdAvviso
            End Get
            Set(ByVal Value As Integer)
                _IdAvviso = Value
            End Set
        End Property
        Public Property NRata() As String
            Get
                Return _NRata
            End Get
            Set(ByVal Value As String)
                _NRata = Value
            End Set
        End Property
        Public Property Tributo() As String
            Get
                Return _Tributo
            End Get
            Set(ByVal Value As String)
                _Tributo = Value
            End Set
        End Property
        Public Property Importo() As Decimal
            Get
                Return _Importo
            End Get
            Set(ByVal Value As Decimal)
                _Importo = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjTesseraUI
        Private _Id As Integer = -1
        Private _IdTessera As Integer = -1
        Private _IdTestata As Integer = -1
        Private _sNumeroTessera As String = ""
        Private _sNote As String = ""
        Private _tDataRilascio As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue

        Private _IdUI As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _sVia As String = ""
        Private _sCivico As String = ""
        Private _sEsponente As String = ""
        Private _sInterno As String = ""
        Private _sScala As String = ""
        Private _sFoglio As String = ""
        Private _sNumero As String = ""
        Private _sSubalterno As String = ""
        Private _tDataInizio As Date = Date.MinValue
        Private _tDataFine As Date = Date.MinValue

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdTessera() As Integer
            Get
                Return _IdTessera
            End Get
            Set(ByVal Value As Integer)
                _IdTessera = Value
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
        Public Property sNumeroTessera() As String
            Get
                Return _sNumeroTessera
            End Get
            Set(ByVal Value As String)
                _sNumeroTessera = Value
            End Set
        End Property
        Public Property tDataRilascio() As Date
            Get
                Return _tDataRilascio
            End Get
            Set(ByVal Value As Date)
                _tDataRilascio = Value
            End Set
        End Property
        Public Property sNote() As String
            Get
                Return _sNote
            End Get
            Set(ByVal Value As String)
                _sNote = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property IdUI() As Integer
            Get
                Return _IdUI
            End Get
            Set(ByVal Value As Integer)
                _IdUI = Value
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
        Public Property sVia() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property
        Public Property sCivico() As String
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As String)
                _sCivico = Value
            End Set
        End Property
        Public Property sEsponente() As String
            Get
                Return _sEsponente
            End Get
            Set(ByVal Value As String)
                _sEsponente = Value
            End Set
        End Property
        Public Property sInterno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property
        Public Property sScala() As String
            Get
                Return _sScala
            End Get
            Set(ByVal Value As String)
                _sScala = Value
            End Set
        End Property
        Public Property sFoglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property sNumero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property sSubalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property tDataInizio() As Date
            Get
                Return _tDataInizio
            End Get
            Set(ByVal Value As Date)
                _tDataInizio = Value
            End Set
        End Property
        Public Property tDataFine() As Date
            Get
                Return _tDataFine
            End Get
            Set(ByVal Value As Date)
                _tDataFine = Value
            End Set
        End Property
    End Class

    <Serializable()>
    Public Class ObjPesatura
        Private _Id As Integer = -1
        Private _IdPesatura As Integer = -1
        Private _IdEnte As String = ""
        Private _IdFlusso As Integer = -1
        Private _IdTessera As Integer = -1
        Private _tDataOraConferimento As Date = Date.MinValue
        Private _nLitri As Double = 0
        Private _sPuntoConferimento As String = ""
        Private _sCodInterno As String = ""
        Private _sCodUtente As String = ""
        Private _sNumeroTessera As String = ObjTessera.TESSERA_BIDONE
        '*** 201712 - gestione tipo conferimento ***
        Private _sTipoConferimento As String = ""
        '*** ***
        Private _nVolume As Double = 0
        Private _sComune As String = ""
        Private _tDataInserimento As Date = Date.MinValue
        Private _tDataVariazione As Date = Date.MinValue
        Private _tDataCessazione As Date = Date.MinValue
        Private _sOperatore As String = ""

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
            End Set
        End Property
        Public Property IdPesatura() As Integer
            Get
                Return _IdPesatura
            End Get
            Set(ByVal Value As Integer)
                _IdPesatura = Value
            End Set
        End Property
        Public Property IdEnte() As String
            Get
                Return _IdEnte
            End Get
            Set(ByVal Value As String)
                _IdEnte = Value
            End Set
        End Property
        Public Property IdFlusso() As Integer
            Get
                Return _IdFlusso
            End Get
            Set(ByVal Value As Integer)
                _IdFlusso = Value
            End Set
        End Property
        Public Property IdTessera() As Integer
            Get
                Return _IdTessera
            End Get
            Set(ByVal Value As Integer)
                _IdTessera = Value
            End Set
        End Property
        Public Property tDataOraConferimento() As Date
            Get
                Return _tDataOraConferimento
            End Get
            Set(ByVal Value As Date)
                _tDataOraConferimento = Value
            End Set
        End Property
        Public Property nLitri() As Double
            Get
                Return _nLitri
            End Get
            Set(ByVal Value As Double)
                _nLitri = Value
            End Set
        End Property
        Public Property nVolume() As Double
            Get
                Return _nVolume
            End Get
            Set(ByVal Value As Double)
                _nVolume = Value
            End Set
        End Property
        Public Property sPuntoConferimento() As String
            Get
                Return _sPuntoConferimento
            End Get
            Set(ByVal Value As String)
                _sPuntoConferimento = Value
            End Set
        End Property
        Public Property sCodUtente() As String
            Get
                Return _sCodUtente
            End Get
            Set(ByVal Value As String)
                _sCodUtente = Value
            End Set
        End Property
        Public Property sCodInterno() As String
            Get
                Return _sCodInterno
            End Get
            Set(ByVal Value As String)
                _sCodInterno = Value
            End Set
        End Property
        Public Property sNumeroTessera() As String
            Get
                Return _sNumeroTessera
            End Get
            Set(ByVal Value As String)
                _sNumeroTessera = Value
            End Set
        End Property
        '*** 201712 - gestione tipo conferimento ***
        Public Property sTipoConferimento() As String
            Get
                Return _sTipoConferimento
            End Get
            Set(ByVal Value As String)
                _sTipoConferimento = Value
            End Set
        End Property
        '*** ***
        Public Property sComune() As String
            Get
                Return _sComune
            End Get
            Set(ByVal Value As String)
                _sComune = Value
            End Set
        End Property
        Public Property tDataInserimento() As Date
            Get
                Return _tDataInserimento
            End Get
            Set(ByVal Value As Date)
                _tDataInserimento = Value
            End Set
        End Property
        Public Property tDataVariazione() As Date
            Get
                Return _tDataVariazione
            End Get
            Set(ByVal Value As Date)
                _tDataVariazione = Value
            End Set
        End Property
        Public Property tDataCessazione() As Date
            Get
                Return _tDataCessazione
            End Get
            Set(ByVal Value As Date)
                _tDataCessazione = Value
            End Set
        End Property
        Public Property sOperatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property
    End Class
    '*** 20141211 - legami PF-PV ***
    ''' <summary>
    ''' oggetto usato per memorizzare i legami tra parte fissa e parte variabile
    ''' </summary>
    ''' <remarks></remarks>
    <Serializable()>
    Public Class ObjLegamePFPV
        Private _idpf As Integer = -1
        Private _idpv As Integer = -1

        Public Property IdPF As Integer
            Get
                Return _idpf
            End Get
            Set(value As Integer)
                _idpf = value
            End Set
        End Property
        Public Property IdPV As Integer
            Get
                Return _idpv
            End Get
            Set(value As Integer)
                _idpv = value
            End Set
        End Property
    End Class
    '*** ***

    <Serializable()>
    Public Class ObjSearchTestata
        Public Const Sog_ALL As Integer = -1
        Public Const Sog_NoRes As Integer = 0
        Public Const Sog_Res As Integer = 1
        Private _IdEnte As String = ""
        Private _Dal As String = ""
        Private _Al As String = ""
        Private _sCognome As String = ""
        Private _sNome As String = ""
        Private _sCF As String = ""
        Private _sPIVA As String = ""
        Private _sNTessera As String = ""
        Private _sVia As String = ""
        Private _sCivico As String = ""
        Private _sInterno As String = ""
        Private _sFoglio As String = ""
        Private _sNumero As String = ""
        Private _sSubalterno As String = ""
        Private _Chiusa As Integer = 0
        Private _rbSoggetto As Boolean = False
        Private _rbImmobile As Boolean = False
        Private _provenienza As String = ""
        Private _catcatastale As String = ""
        Private _typesogres As Integer = Sog_ALL
        Private _idcatTARES As String = ""
        Private _nc As Integer = -1
        Private _isPF As Boolean = False
        Private _isPV As Boolean = False
        Private _isEsente As Boolean = False
        Private _idrid As String = ""
        Private _iddet As String = ""
        Private _moreUI As Boolean = False
        Private _idstatooccup As String = ""
        '*** 20140923 - GIS ***
        Private _listContrib As String = ""
        '***  ***

        Public Property IdEnte() As String
            Get
                Return _IdEnte
            End Get
            Set(ByVal Value As String)
                _IdEnte = Value
            End Set
        End Property
        Public Property Dal() As String
            Get
                Return _Dal
            End Get
            Set(ByVal Value As String)
                _Dal = Value
            End Set
        End Property
        Public Property Al() As String
            Get
                Return _Al
            End Get
            Set(ByVal Value As String)
                _Al = Value
            End Set
        End Property
        Public Property sCognome() As String
            Get
                Return _sCognome
            End Get
            Set(ByVal Value As String)
                _sCognome = Value
            End Set
        End Property
        Public Property sNome() As String
            Get
                Return _sNome
            End Get
            Set(ByVal Value As String)
                _sNome = Value
            End Set
        End Property
        Public Property sCF() As String
            Get
                Return _sCF
            End Get
            Set(ByVal Value As String)
                _sCF = Value
            End Set
        End Property
        Public Property sPIVA() As String
            Get
                Return _sPIVA
            End Get
            Set(ByVal Value As String)
                _sPIVA = Value
            End Set
        End Property
        Public Property sNTessera() As String
            Get
                Return _sNTessera
            End Get
            Set(ByVal Value As String)
                _sNTessera = Value
            End Set
        End Property
        Public Property sVia() As String
            Get
                Return _sVia
            End Get
            Set(ByVal Value As String)
                _sVia = Value
            End Set
        End Property
        Public Property sCivico() As String
            Get
                Return _sCivico
            End Get
            Set(ByVal Value As String)
                _sCivico = Value
            End Set
        End Property
        Public Property sInterno() As String
            Get
                Return _sInterno
            End Get
            Set(ByVal Value As String)
                _sInterno = Value
            End Set
        End Property
        Public Property rbSoggetto() As Boolean
            Get
                Return _rbSoggetto
            End Get
            Set(ByVal Value As Boolean)
                _rbSoggetto = Value
            End Set
        End Property
        Public Property rbImmobile() As Boolean
            Get
                Return _rbImmobile
            End Get
            Set(ByVal Value As Boolean)
                _rbImmobile = Value
            End Set
        End Property
        Public Property Chiusa() As Integer
            Get
                Return _Chiusa
            End Get
            Set(ByVal Value As Integer)
                _Chiusa = Value
            End Set
        End Property
        Public Property sFoglio() As String
            Get
                Return _sFoglio
            End Get
            Set(ByVal Value As String)
                _sFoglio = Value
            End Set
        End Property
        Public Property sNumero() As String
            Get
                Return _sNumero
            End Get
            Set(ByVal Value As String)
                _sNumero = Value
            End Set
        End Property
        Public Property sSubalterno() As String
            Get
                Return _sSubalterno
            End Get
            Set(ByVal Value As String)
                _sSubalterno = Value
            End Set
        End Property
        Public Property sProvenienza() As String
            Get
                Return _provenienza
            End Get
            Set(ByVal Value As String)
                _provenienza = Value
            End Set
        End Property
        Public Property IdCatCatastale() As String
            Get
                Return _catcatastale
            End Get
            Set(ByVal Value As String)
                _catcatastale = Value
            End Set
        End Property
        Public Property TypeSogRes() As Integer
            Get
                Return _typesogres
            End Get
            Set(ByVal Value As Integer)
                _typesogres = Value
            End Set
        End Property
        Public Property IdCatTARES() As String
            Get
                Return _idcatTARES
            End Get
            Set(ByVal Value As String)
                _idcatTARES = Value
            End Set
        End Property
        Public Property nComponenti() As Integer
            Get
                Return _nc
            End Get
            Set(ByVal Value As Integer)
                _nc = Value
            End Set
        End Property
        Public Property IsPF() As Boolean
            Get
                Return _isPF
            End Get
            Set(ByVal Value As Boolean)
                _isPF = Value
            End Set
        End Property
        Public Property IsPV() As Boolean
            Get
                Return _isPV
            End Get
            Set(ByVal Value As Boolean)
                _isPV = Value
            End Set
        End Property
        Public Property IsEsente() As Boolean
            Get
                Return _isEsente
            End Get
            Set(ByVal Value As Boolean)
                _isEsente = Value
            End Set
        End Property
        Public Property IdRiduzione() As String
            Get
                Return _idrid
            End Get
            Set(ByVal Value As String)
                _idrid = Value
            End Set
        End Property
        Public Property IdDetassazione() As String
            Get
                Return _iddet
            End Get
            Set(ByVal Value As String)
                _iddet = Value
            End Set
        End Property
        Public Property HasMoreUI() As Boolean
            Get
                Return _moreUI
            End Get
            Set(ByVal Value As Boolean)
                _moreUI = Value
            End Set
        End Property
        Public Property IdStatoOccupazione() As String
            Get
                Return _idstatooccup
            End Get
            Set(ByVal Value As String)
                _idstatooccup = Value
            End Set
        End Property
        '*** 20140923 - GIS ***
        Public Property sListContrib() As String
            Get
                Return _listContrib
            End Get
            Set(ByVal Value As String)
                _listContrib = Value
            End Set
        End Property
        '***  ***
    End Class
End Namespace

