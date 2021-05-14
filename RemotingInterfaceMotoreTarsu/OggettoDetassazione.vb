Namespace MotoreTarsu.Oggetti

    <Serializable()> _
    Public Class OggettoDetassazione

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoDetassazione contiene i dati completi della detassazione.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub New()
        End Sub

        Private _IdDettaglioTestata As Integer = -1
        Private _sIdEnte As String = String.Empty
        Private _sIdDetassazione As String = String.Empty
        Private _sDescrizione As String = String.Empty
        Private _sTipo As String = String.Empty
        Private _sTipoValoreDet As String = String.Empty
        Private _sValore As String = String.Empty

        Public Property IdDettaglioTestata() As Integer
            Get
                Return _IdDettaglioTestata
            End Get
            Set(ByVal Value As Integer)
                _IdDettaglioTestata = Value
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
        Public Property IdDetassazione() As String
            Get
                Return _sIdDetassazione
            End Get
            Set(ByVal Value As String)
                _sIdDetassazione = Value
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
        Public Property sTipo() As String
            Get
                Return _sTipo
            End Get
            Set(ByVal Value As String)
                _sTipo = Value
            End Set
        End Property
        Public Property sTipoValoreDet() As String
            Get
                Return _sTipoValoreDet
            End Get
            Set(ByVal Value As String)
                _sTipoValoreDet = Value
            End Set
        End Property
        Public Property sValore() As String
            Get
                Return _sValore
            End Get
            Set(ByVal Value As String)
                _sValore = Value
            End Set
        End Property

    End Class

End Namespace