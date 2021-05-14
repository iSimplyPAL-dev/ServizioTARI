''' <summary>
''' Definizione oggetto totali per anno
''' </summary>
Public Class TotaliRuoloPerAnno
    Dim _sAnno As String = ""
    Dim _nImportoNetto As Double = 0
    Dim _nImportoSanzioni As Double = 0
    Dim _nImportoInteressi As Double = 0
    Dim _nImportoSpese As Double = 0

    Public Property Anno() As String
        Get
            Return _sAnno
        End Get

        Set(ByVal Value As String)
            _sAnno = Value
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

    Public Property ImportoSanzioni() As Double
        Get
            Return _nImportoSanzioni
        End Get

        Set(ByVal Value As Double)
            _nImportoSanzioni = Value
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

    Public Property ImportoSpese() As Double
        Get
            Return _nImportoSpese
        End Get

        Set(ByVal Value As Double)
            _nImportoSpese = Value
        End Set
    End Property
End Class
