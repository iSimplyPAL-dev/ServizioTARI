Namespace MotoreTarsu.Oggetti
    <Serializable()> _
Public Class OggettoRuoloPerCalcoloCartelle
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoRuoloPerCalcoloCartelle contiene i dati dell'articoli per la cartella.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Dim _IdCodiceArticolo As Integer = -1
        Dim _sAnno As String = ""
        Private _nMq As Double = 0
        Dim _nImportoNetto As Double = 0
        Dim _nImportoInteressi As Double = 0
        Dim _nImportoSanzioni As Double = 0
        Dim _nImportoSpese As Double = 0
        Private _DataVariazione As DateTime = Date.MinValue

        Public Property IdCodiceArticolo() As Integer
            Get
                Return _IdCodiceArticolo
            End Get

            Set(ByVal Value As Integer)
                _IdCodiceArticolo = Value
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
        Public Property MQ() As Double
            Get
                Return _nMq
            End Get
            Set(ByVal Value As Double)
                _nMq = Value
            End Set
        End Property
        Public Property ImportoNetto() As Double
            Get
                Return _nImportoNetto
            End Get

            Set(ByVal Value As Double)
                _nImportoNetto = Value
            End Set
        End Property

        Public Property ImportoInteressi() As Double
            Get
                Return _nImportoInteressi
            End Get

            Set(ByVal Value As Double)
                _nImportoInteressi = Value
            End Set
        End Property

        Public Property ImportoSanzioni() As Double
            Get
                Return _nImportoSanzioni
            End Get

            Set(ByVal Value As Double)
                _nImportoSanzioni = Value
            End Set
        End Property

        Public Property ImportoSpese() As Double
            Get
                Return _nImportoSpese
            End Get

            Set(ByVal Value As Double)
                _nImportoSpese = Value
            End Set
        End Property
        Public Property tDataVariazione() As DateTime
            Get
                Return _DataVariazione
            End Get
            Set(ByVal Value As DateTime)
                _DataVariazione = Value
            End Set
        End Property
    End Class
End Namespace