Namespace MotoreTarsu.Oggetti

    <Serializable()> _
Public Class OggettoDatiRata
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoDatiRata contiene i dati completi delle rate da generare.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        '*** 20131104 - TARES ***
        Public Const BOLLETTINO_123 As String = "123"
        Public Const BOLLETTINO_896 As String = "896"
        Public Const BOLLETTINO_F24 As String = "F24"

        Private _Percentuale As Double = 100
        Private _HasImposta As Boolean = True
        Private _HasMaggiorazione As Boolean = False
        Private _TipoBollettino As String = BOLLETTINO_123
        Private _impSoglia As Double = 0
        '*** ***
        Private _nNumeroRata As String = ""
        Private _sDataScadenza As String = ""
        Private _sDescrizioneRata As String = ""
        Private _sNumeroContoCorrente As String = ""

        Public Property NumeroRata() As String
            Get
                Return _nNumeroRata
            End Get

            Set(ByVal Value As String)
                _nNumeroRata = Value
            End Set
        End Property
		Public Property DataScadenza() As String
			Get
				Return _sDataScadenza
			End Get

			Set(ByVal Value As String)
				_sDataScadenza = Value
			End Set
		End Property
		Public Property DescrizioneRata() As String
			Get
				Return _sDescrizioneRata
			End Get

			Set(ByVal Value As String)
				_sDescrizioneRata = Value
			End Set
		End Property
		Public Property NumeroContoCorrente() As String
			Get
				Return _sNumeroContoCorrente
			End Get

			Set(ByVal Value As String)
				_sNumeroContoCorrente = Value
			End Set
		End Property
		'*** 20131104 - TARES ***
		Public Property Percentuale() As Double
			Get
				Return _Percentuale
			End Get
			Set(ByVal Value As Double)
				_Percentuale = Value
			End Set
		End Property
		Public Property HasImposta() As Boolean
			Get
				Return _HasImposta
			End Get
			Set(ByVal Value As Boolean)
				_HasImposta = Value
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
        Public Property sTipoBollettino() As String
            Get
                Return _TipoBollettino
            End Get
            Set(ByVal Value As String)
                _TipoBollettino = Value
            End Set
        End Property
        Public Property impSoglia() As Double
            Get
                Return _impSoglia
            End Get
            Set(ByVal Value As Double)
                _impSoglia = Value
            End Set
        End Property
        '*** ***
	End Class
End Namespace