Namespace MotoreTarsu.Oggetti

    <Serializable()> _
Public Class OggettoAnagraficaCartellazione
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoAnagraficaCartellazione contiene i dati completi dell'anagrafica per la cartella.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Dim _IdContribuente As Integer = -1
        Dim _sEnte As String = ""
        Dim _sCognome As String = ""
        Dim _sNome As String = ""
        Dim _sCodiceFiscale As String = ""
        Dim _sPartitaIVA As String = ""
        Dim _sIndirizzoRes As String = ""
        Dim _sCivicoRes As String = ""
        Dim _sCAPRes As String = ""
        Dim _sProvRes As String = ""
        Dim _sComuneRes As String = ""
        Dim _sFrazRes As String = ""
        Dim _sNominativoCO As String = ""
        Dim _sIndirizzoCO As String = ""
        Dim _sCivicoCO As String = ""
        Dim _sCAPCO As String = ""
        Dim _sProvCO As String = ""
        Dim _sComuneCO As String = ""
        Dim _sFrazCO As String = ""

        Public Property IdContribuente() As Integer
            Get
                Return _IdContribuente
            End Get

            Set(ByVal Value As Integer)
                _IdContribuente = Value
            End Set
        End Property

        Public Property CodiceEnte() As String
            Get
                Return _sEnte
            End Get

            Set(ByVal Value As String)
                _sEnte = Value
            End Set
        End Property

        Public Property Cognome() As String
            Get
                Return _sCognome
            End Get

            Set(ByVal Value As String)
                _sCognome = Value
            End Set
        End Property

        Public Property Nome() As String
            Get
                Return _sNome
            End Get

            Set(ByVal Value As String)
                _sNome = Value
            End Set
        End Property

        Public Property CodiceFiscale() As String
            Get
                Return _sCodiceFiscale
            End Get

            Set(ByVal Value As String)
                _sCodiceFiscale = Value
            End Set
        End Property

        Public Property PartitaIVA() As String
            Get
                Return _sPartitaIVA
            End Get

            Set(ByVal Value As String)
                _sPartitaIVA = Value
            End Set
        End Property

        Public Property IndirizzoRes() As String
            Get
                Return _sIndirizzoRes
            End Get

            Set(ByVal Value As String)
                _sIndirizzoRes = Value
            End Set
        End Property

        Public Property CivicoRes() As String
            Get
                Return _sCivicoRes
            End Get

            Set(ByVal Value As String)
                _sCivicoRes = Value
            End Set
        End Property

        Public Property CAPRes() As String
            Get
                Return _sCAPRes
            End Get

            Set(ByVal Value As String)
                _sCAPRes = Value
            End Set
        End Property

        Public Property ProvRes() As String
            Get
                Return _sProvRes
            End Get

            Set(ByVal Value As String)
                _sProvRes = Value
            End Set
        End Property

        Public Property ComuneRes() As String
            Get
                Return _sComuneRes
            End Get

            Set(ByVal Value As String)
                _sComuneRes = Value
            End Set
        End Property

        Public Property FrazRes() As String
            Get
                Return _sFrazRes
            End Get

            Set(ByVal Value As String)
                _sFrazRes = Value
            End Set
        End Property

        Public Property NominativoCO() As String
            Get
                Return _sNominativoCO
            End Get

            Set(ByVal Value As String)
                _sNominativoCO = Value
            End Set
        End Property

        Public Property IndirizzoCO() As String
            Get
                Return _sIndirizzoCO
            End Get

            Set(ByVal Value As String)
                _sIndirizzoCO = Value
            End Set
        End Property

        Public Property CivicoCO() As String
            Get
                Return _sCivicoCO
            End Get

            Set(ByVal Value As String)
                _sCivicoCO = Value
            End Set
        End Property

        Public Property CAPCO() As String
            Get
                Return _sCAPCO
            End Get

            Set(ByVal Value As String)
                _sCAPCO = Value
            End Set
        End Property

        Public Property ProvCO() As String
            Get
                Return _sProvCO
            End Get

            Set(ByVal Value As String)
                _sProvCO = Value
            End Set
        End Property

        Public Property ComuneCO() As String
            Get
                Return _sComuneCO
            End Get

            Set(ByVal Value As String)
                _sComuneCO = Value
            End Set
        End Property

        Public Property FrazCO() As String
            Get
                Return _sFrazCO
            End Get

            Set(ByVal Value As String)
                _sFrazCO = Value
            End Set
        End Property
    End Class
End Namespace