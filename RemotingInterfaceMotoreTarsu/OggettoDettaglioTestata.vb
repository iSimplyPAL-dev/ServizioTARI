Namespace MotoreTarsu.Oggetti
    <Serializable()> _
    Public Class OggettoDettaglioTestata

        Public Sub New()
        End Sub

        Public objOggetti() As OggettoVano
        Public objRiduzioni() As OggettoRiduzione
        Public objDetassazioni() As OggettoDetassazione

        Private _Id As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _IdTestata As Integer = -1
        Private _IdPadre As Integer = -1
        Private _sVia As String = String.Empty
        Private _CodVia As Integer = -1
        Private _sCivico As Integer = -1
        Private _sEsponente As String = String.Empty
        Private _sInterno As String = String.Empty
        Private _sScala As String = String.Empty
        Private _sFoglio As String = String.Empty
        Private _sNumero As String = String.Empty
        Private _sSubalterno As Integer = -1
        Private _DataInizio As Date = Nothing
        Private _DataFine As Date = Nothing
        Private _nVani As Integer = 0
        Private _nMQ As Double = 0
        Private _nGGTarsu As Integer = -1
        Private _sIdStatoOccupazione As String = String.Empty
        Private _sIdTipoConduttore As String = String.Empty
        Private _sNomeProprietario As String = String.Empty
        Private _sNomeOccupantePrec As String = String.Empty
        Private _sNoteUI As String = String.Empty
        Private _DataInserimento As Date = Nothing
        Private _DataVariazione As Date = Nothing
        Private _DataCessazione As Date = Nothing
        Private _sOperatore As String = String.Empty
        Private _nImportoFissoRid As Double = 0

        Public Property ID() As Integer
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


        Public Property IdPadre() As Integer
            Get
                Return _IdPadre
            End Get
            Set(ByVal Value As Integer)
                _IdPadre = Value
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

        Public Property NumVani() As Integer
            Get
                Return _nVani
            End Get
            Set(ByVal Value As Integer)
                _nVani = Value
            End Set
        End Property

        Public Property MQ() As Double
            Get
                Return _nMQ
            End Get
            Set(ByVal Value As Double)
                _nMQ = Value
            End Set
        End Property
        Public Property ImportoFissoRid() As Double
            Get
                Return _nImportoFissoRid
            End Get
            Set(ByVal Value As Double)
                _nImportoFissoRid = Value
            End Set
        End Property
        Public Property NumGGTarsu() As Integer
            Get
                Return _nGGTarsu
            End Get
            Set(ByVal Value As Integer)
                _nGGTarsu = Value
            End Set
        End Property

        Public Property IdStatoOccupazione() As String
            Get
                Return _sIdStatoOccupazione
            End Get
            Set(ByVal Value As String)
                _sIdStatoOccupazione = Value
            End Set
        End Property

        Public Property IdTipoConduttore() As String
            Get
                Return _sIdTipoConduttore
            End Get
            Set(ByVal Value As String)
                _sIdTipoConduttore = Value
            End Set
        End Property

        Public Property NomeProprietario() As String
            Get
                Return _sNomeProprietario
            End Get
            Set(ByVal Value As String)
                _sNomeProprietario = Value
            End Set
        End Property

        Public Property NomeOccupantePrec() As String
            Get
                Return _sNomeOccupantePrec
            End Get
            Set(ByVal Value As String)
                _sNomeOccupantePrec = Value
            End Set
        End Property

        Public Property NoteUI() As String
            Get
                Return _sNoteUI
            End Get
            Set(ByVal Value As String)
                _sNoteUI = Value
            End Set
        End Property

        Public Property DataInserimento() As DateTime
            Get
                Return _DataInserimento
            End Get
            Set(ByVal Value As DateTime)
                _DataInserimento = Value
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

        Public Property DataCessazione() As DateTime
            Get
                Return _DataCessazione
            End Get
            Set(ByVal Value As DateTime)
                _DataCessazione = Value
            End Set
        End Property

        Public Property Operatore() As String
            Get
                Return _sOperatore
            End Get
            Set(ByVal Value As String)
                _sOperatore = Value
            End Set
        End Property


    End Class


End Namespace
