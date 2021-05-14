Namespace MotoreTarsu.Oggetti

    <Serializable()> _
    Public Class OggettoAddizionale
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoAddizionale contiene i dati generali delle addizionali da calcolare.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        '**** 201809 - Cartelle Insoluti ***
        Public Class Tipo
            Public Const Formula As Integer = 1
            Public Const Importo As Integer = 2
        End Class

        Dim _idAddizionale As Integer = -1
        Dim _sAnno As String = ""
        Dim _sCodiceCapitolo As String = ""
        Dim _nValore As Double = 0
        Dim _dImportoCalcolato As Double = 0
		Dim _sDescrizione As String = ""
        '**** 201809 - Cartelle Insoluti ***
        Dim _Tipo As Integer = Tipo.Formula

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
        Public Property TipoCalcolo() As String
            Get
                Return _Tipo
            End Get
            Set(ByVal Value As String)
                _Tipo = Value
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

End Namespace