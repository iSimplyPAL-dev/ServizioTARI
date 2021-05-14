Namespace MotoreTarsu.Oggetti

    <Serializable()> _
    Public Class OggettoRiduzione

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoRiduzione contiene i dati completi della riduzione.
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
        Private _sIdRiduzione As String = String.Empty
        Private _sDescrizione As String = String.Empty
        Private _sTipo As String = String.Empty
        Private _sTipoValoreRid As String = String.Empty
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
        Public Property IdRiduzione() As String
            Get
                Return _sIdRiduzione
            End Get
            Set(ByVal Value As String)
                _sIdRiduzione = Value
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
        Public Property sTipoValoreRid() As String
            Get
                Return _sTipoValoreRid
            End Get
            Set(ByVal Value As String)
                _sTipoValoreRid = Value
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