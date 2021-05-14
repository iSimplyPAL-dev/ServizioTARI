Namespace MotoreTarsu.Oggetti

    <Serializable()> _
Public Class OggettoTotaliDettaglioVociCartella

        Dim _nidFlusso As Integer = -1
        Dim _sCodiceCapitolo As String = String.Empty
        Dim _sDescrVoce As String = ""
        Dim _nImportoVoce As Double = 0

        Public Property idFlusso() As Integer
            Get
                Return _nidFlusso
            End Get

            Set(ByVal Value As Integer)
                _nidFlusso = Value
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

        Public Property DescrVoce() As String
            Get
                Return _sDescrVoce
            End Get

            Set(ByVal Value As String)
                _sDescrVoce = Value
            End Set
        End Property

        Public Property ImportoVoce() As Double
            Get
                Return _nImportoVoce
            End Get

            Set(ByVal Value As Double)
                _nImportoVoce = Value
            End Set
        End Property
    End Class
End Namespace
