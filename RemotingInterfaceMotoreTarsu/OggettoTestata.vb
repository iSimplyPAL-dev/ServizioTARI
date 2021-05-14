
Namespace MotoreTarsu.Oggetti
    <Serializable()> _
    Public Class OggettoTestata

        Public Sub New()
        End Sub

        Public objDettaglioTestata() As OggettoDettaglioTestata

        Private _Id As Integer = -1
        Private _IdTestata As Integer = -1
        Private _sEnte As String = String.Empty
        Private _IdContribuente As Integer = -1
        Private _DataDichiarazione As Date = Nothing
        Private _sNDichiarazione As String = String.Empty
        Private _DataProtocollo As Date = Nothing
        Private _sNProtocollo As String = String.Empty
        Private _nComponenti As Integer = 0
        Private _sIdProvenienza As String = String.Empty
        Private _sNoteDichiarazione As String = String.Empty
        Private _DataInserimento As Date = Nothing
        Private _DataVariazione As Date = Nothing
        Private _DataCessazione As Date = Nothing
        Private _sOperatore As String = String.Empty


        Public Property ID() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal Value As Integer)
                _Id = Value
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

        Public Property DataDichiarazione() As DateTime
            Get
                Return _DataDichiarazione
            End Get
            Set(ByVal Value As DateTime)
                _DataDichiarazione = Value
            End Set
        End Property

        Public Property NDichiarazione() As String
            Get
                Return _sNDichiarazione
            End Get
            Set(ByVal Value As String)
                _sNDichiarazione = Value
            End Set
        End Property

        Public Property DataProtocollo() As DateTime
            Get
                Return _DataProtocollo
            End Get
            Set(ByVal Value As DateTime)
                _DataProtocollo = Value
            End Set
        End Property

        Public Property NProtocollo() As String
            Get
                Return _sNProtocollo
            End Get
            Set(ByVal Value As String)
                _sNProtocollo = Value
            End Set
        End Property

        Public Property NumeroComponenti() As Integer
            Get
                Return _nComponenti
            End Get
            Set(ByVal Value As Integer)
                _nComponenti = Value
            End Set
        End Property

        Public Property IdProvenienza() As String
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