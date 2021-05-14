Namespace MotoreTarsu.Oggetti

    <Serializable()> _
Public Class OggettoDatiCartellazione
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoDatiCartellazione contiene i dati identificati della cartella da generare.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Dim _sCodiceCartella As String = ""
        Dim _sDataEmissione As String = ""
        Dim _IdLottoCartellazione As Integer = -1
        Dim _sAnnoRiferimento As String = ""

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

        Public Property LottoCartellazione() As Integer
            Get
                Return _IdLottoCartellazione
            End Get

            Set(ByVal Value As Integer)
                _IdLottoCartellazione = Value
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
    End Class

End Namespace