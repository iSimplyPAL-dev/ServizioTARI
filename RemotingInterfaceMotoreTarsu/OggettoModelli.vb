Namespace MotoreTarsu.Oggetti
    <Serializable()> _
Public Class OggettoModelli
        Private _nIdModello As Integer = -1
        Private _sNomeModello As String = String.Empty

        Public Property IdModello() As Integer
            Get
                Return _nIdModello
            End Get
            Set(ByVal Value As Integer)
                _nIdModello = Value
            End Set
        End Property

        Public Property NomeModello() As String
            Get
                Return _sNomeModello
            End Get
            Set(ByVal Value As String)
                _sNomeModello = Value
            End Set
        End Property
    End Class
End Namespace