Namespace MotoreTarsu.Oggetti

    Public Class OggettoVano

        Public Sub New()
        End Sub

        Private _IdOggetto As Integer = -1
        Private _IdDettaglioTestata As Integer = -1
        Private _IdCategoria As Integer = -1
        Private _sCategoria As String = String.Empty
        Private _IdTipoVano As String = String.Empty
        Private _sTipoVano As String = String.Empty
        Private _nVani As Integer = 0
        Private _nMq As Double = 0
        Private _DataInserimento As Date = Nothing
        Private _DataVariazione As Date = Nothing
        Private _DataCessazione As Date = Nothing
        Private _sOperatore As String = String.Empty

        Public Property IDOggetto() As Integer
            Get
                Return _IdOggetto
            End Get
            Set(ByVal Value As Integer)
                _IdOggetto = Value
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

        Public Property IdCategoria() As Integer
            Get
                Return _IdCategoria
            End Get
            Set(ByVal Value As Integer)
                _IdCategoria = Value
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

        Public Property IdTipoVano() As String
            Get
                Return _IdTipoVano
            End Get
            Set(ByVal Value As String)
                _IdTipoVano = Value
            End Set
        End Property

        Public Property TipoVano() As String
            Get
                Return _sTipoVano
            End Get
            Set(ByVal Value As String)
                _sTipoVano = Value
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
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
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