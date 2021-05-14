Imports RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti
Imports log4net

Namespace ImportiRuolo
    ''' -----------------------------------------------------------------------------
    ''' Project	 : Ruolo
    ''' Class	 : ClsImportiRuolo
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' La class ClsImportiRuolo determina gli importi dell'articolo a ruolo.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[monicatarello]	23/09/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class ClsImportiRuolo
        Private Shared ReadOnly log As ILog = LogManager.GetLogger(GetType(ClsImportiRuolo))

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina gli importi lordi e netti da inserire a ruolo per ogni articolo.<br/>
        ''' L'oggetto OggettoArticoloRuolo contiene i dati di base per il calcolo:<br />
        '''  - base tempo,<br/>
        '''  - metri quadri,<br/>
        '''  - tariffa,<br/>
        '''  - bimestri.<br/>
        ''' L'oggetto OggettoRiduzione contiene tutte le eventuali riduzioni da applicare all'articolo.<br/>
        ''' L'oggetto OggettoDetassazione contiene tutte le eventuali detassazioni da applicare all'articolo.<br/><br/>
        ''' La funzione determina l'importo lordo a ruolo applicando la seguente formula:<br/>
        ''' ((metri quadri * tariffa) * tempo) / base tempo<br/><br/>
        ''' Sia l'importo di riduzione sia quello di detassazione sono calcolati sull'importo a ruolo in base alle diverse tipologie di appartenenza: percentuale, a valore fisso, a formula.<br/>
        ''' La funzione può anche essere richiamata per calcolare singolarmente l'importo lordo dell'articolo piuttosto chè l'importo netto con relative riduzioni/detassazioni;
        ''' nel secondo caso l'importo lordo dovrà già essere contenuto nell'OggettoArticoloRuolo originale.<br/>
        ''' Una volta ottenuti gli importi desiderati, questi vengono inseriti nell'OggettoArticoloRuolo che è restituito al chiamante.
        ''' </summary>
        ''' <param name="oMyArticolo">Restituisce un oggetto di tipo OggettoArticoloRuolo in ingresso contiene i dati per il calcolo.</param>
        ''' <param name="oMyRiduzioni">Array di oggetti di tipo OggettoRiduzione contiene le riduzioni da applicare.</param>
        ''' <param name="oMyDetrazioni">Array di oggetti di tipo OggettoDetassazione contiene le riduzioni da applicare.</param>
        ''' <param name="LevelCalcolo">Opzionale di tipo Intero con valore di default 0 indica quali importi calcolare.</param>
        ''' <returns>Boolean<br/>
        ''' Il metodo restituisce <c>False</c> se si è verificato un errore; mentre restituisce <c>True</c> se il calcolo è avvenuto con successo.
        ''' </returns>
        ''' <remarks>
        ''' Il parametro <c>LevelCalcolo</c> deve valere 0 se deve essere calcolato l'importo articolo, l'importo di riduzione, di detassazione e l'importo netto;<br/>
        ''' deve valere 1 se deve essere calcolato solo l'importo articolo;<br/>
        ''' deve valere 2 se deve essere calcolato solo l'importo di riduzione, di detassazione e l'importo netto.<br/>
        ''' Se uno dei parametri per il calcolo è pari a zero la funzione non può procedere quindi l'importo articolo sarà pari a zero.<br/>
        ''' L'importo di riduzione e di detassazione può valere al massimo l'importo articolo; di conseguenza se maggiore viene forzato pari all'importo articolo.<br/>
        ''' L'importo netto può valere al massimo zero, di conseguenza se minore viene forzato pari a zero.<br/>
        ''' Se l'importo a ruolo o il valore della riduzione/detassazione da applicare sono pari a zero non si può procedere al calcolo quindi l'importo di riduzione/detassazione sarà pari a zero.<br/><br/>
        ''' Il calcolo di riduzione e detassazione in base a formula attualmente non è gestito.<br/> 
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function CalcolaImportiRuolo(ByRef oMyArticolo As OggettoArticoloRuolo, ByVal oMyRiduzioni() As OggettoRiduzione, ByVal oMyDetrazioni() As OggettoDetassazione, Optional ByVal LevelCalcolo As Integer = 0) As Boolean
            'LevelCalcolo {0= calcola tutto; 1= calcola solo importo articolo; 2= calcola solo importi netti}
            Dim ImpArticolo As Double = 0
            Dim ImpRid As Double = 0
            Dim ImpDet As Double = 0
            Dim ImpNetto As Double = 0
            Dim nBaseTempoCalc As Integer = 6
            Dim x As Integer

            Try
                'determino la base di tempo per il calcolo
                If oMyArticolo.IsTarsuGiornaliera = True Then
                    nBaseTempoCalc = 365
                Else
                    nBaseTempoCalc = 6
                End If
                'determino l'importo ruolo lordo
                If LevelCalcolo <> 2 Then
                    ImpArticolo = CalcolaRuolo(oMyArticolo.MQ, oMyArticolo.ImpTariffa, oMyArticolo.NumeroBimestri, nBaseTempoCalc)
                    oMyArticolo.ImportoRuolo = ImpArticolo
                End If
                If LevelCalcolo <> 1 Then
                    ImpArticolo = oMyArticolo.ImportoRuolo
                    'testo se ho delle riduzioni da calcolare
                    If Not oMyRiduzioni Is Nothing Then
                        For x = 0 To oMyRiduzioni.GetUpperBound(0)
                            'l'importo per la base del calcolo deve sempre essere al netto delle precedenti riduzioni calcolate
                            ImpArticolo = oMyArticolo.ImportoRuolo - ImpRid
                            'determino l'importo di riduzione
                            ImpRid += CalcolaRiduzioni(ImpArticolo, oMyRiduzioni(x).sTipoValoreRid, oMyRiduzioni(x).sValore)
                        Next
                    End If
                    'l'importo per la base del calcolo deve sempre essere al netto delle precedenti riduzioni calcolate
                    ImpArticolo = oMyArticolo.ImportoRuolo - ImpRid
                    'l'importo di riduzione può valere al massimo importo articolo
                    If ImpRid > oMyArticolo.ImportoRuolo Then
                        ImpRid = oMyArticolo.ImportoRuolo
                    End If
                    'testo se ho delle Detrazioni da calcolare
                    If Not oMyDetrazioni Is Nothing Then
                        For x = 0 To oMyDetrazioni.GetUpperBound(0)
                            'l'importo per la base del calcolo deve sempre essere al netto delle precedenti riduzioni e detrazioni calcolate
                            ImpArticolo = oMyArticolo.ImportoRuolo - ImpRid - ImpDet
                            'determino l'importo di Detrazione
                            ImpDet += CalcolaDetrazioni(ImpArticolo, oMyDetrazioni(x).sTipoValoreDet, oMyDetrazioni(x).sValore)
                        Next
                    End If
                    'l'importo per la base del calcolo deve sempre essere al netto delle precedenti riduzioni e detrazioni calcolate
                    ImpArticolo = oMyArticolo.ImportoRuolo - ImpRid - ImpDet
                    'l'importo di Detrazione può valere al massimo importo articolo
                    If ImpDet > oMyArticolo.ImportoRuolo - ImpRid Then
                        ImpDet = oMyArticolo.ImportoRuolo - ImpRid
                    End If
                    'determino l'importo netto
                    ImpNetto = oMyArticolo.ImportoRuolo - ImpRid - ImpDet
                    'l'importo netto può valere al massimo zero
                    If ImpNetto < 0 Then
                        ImpNetto = 0
                    End If
                End If
                'aggiorno gli importi dell'articolo
                oMyArticolo.ImportoRuolo = oMyArticolo.ImportoRuolo
                oMyArticolo.ImportoRiduzione = ImpRid
                oMyArticolo.ImportoDetassazione = ImpDet
                If oMyArticolo.ImportoForzato = True Then
                    oMyArticolo.ImportoNetto = ImpArticolo
                Else
                    oMyArticolo.ImportoNetto = ImpNetto
                End If
                Return True
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CalcolaImportiRuolo::" & Err.Message)
                Return False
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina l'importo lordo a ruolo applicando la formula:<br/>
        ''' ((metri quadri * tariffa) * tempo) / base tempo
        ''' </summary>
        ''' <param name="nMq">Decimale contenente i metri quadri</param>
        ''' <param name="ImpTariffa">Decimale contenente la tariffa</param>
        ''' <param name="nTempo">Intero contenente il tempo su cui applicare la tariffa</param>
        ''' <param name="nBaseTempo">Intero contenente la base tempo per il rapporto</param>
        ''' <returns>
        ''' Decimale contenente l'importo risultante dal calcolo.<br/>
        ''' Vale 0 in caso di errore.
        ''' </returns>
        ''' <remarks>
        ''' Se uno dei parametri in ingresso è pari a zero la funzione non può procedere al calcolo quindi restituisce zero. 
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function CalcolaRuolo(ByVal nMq As Double, ByVal ImpTariffa As Double, ByVal nTempo As Integer, ByVal nBaseTempo As Integer) As Double
            Try
                Dim ImpCalcolo As Double

                'controllo di avere tutti i parametri per il calcolo
                If nMq = 0 Or ImpTariffa = 0 Or nTempo = 0 Or nBaseTempo = 0 Then
                    Return 0
                End If
                ImpCalcolo = ((nMq * ImpTariffa) * nTempo) / nBaseTempo

                Return ImpCalcolo
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CalcolaRuolo::" & Err.Message)
                log.Warn("Si è verificato un errore in CalcolaRuolo::" & Err.Message)
                Return 0
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina l'importo di riduzione sull'importo a ruolo in base alla tipologia di riduzione.<br/>
        ''' La riduzione può essere di tipo percentuale, a valore fisso o a formula.
        ''' </summary>
        ''' <param name="ImpRuolo">Decimale contenente l'importo lordo a ruolo</param>
        ''' <param name="sTipoValoreRid">Stringa contenente la tipologia di riduzione da applicare</param>
        ''' <param name="sValRiduzione">Striga contenente il valore della riduzione da applicare</param>
        ''' <returns>
        ''' Decimale contenente l'importo di riduzione risultante dal calcolo.
        ''' Vale 0 in caso di errore.
        ''' </returns>
        ''' <remarks>
        ''' Se l'importo a ruolo o il valore della riduzione da applicare sono pari a zero la funzione non può procedere al calcolo quindi restituisce zero.
        ''' Il calcolo in base a formula attualmente non è gestito. 
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function CalcolaRiduzioni(ByVal ImpRuolo As Double, ByVal sTipoValoreRid As String, ByVal sValRiduzione As String) As Double
            Dim culture As IFormatProvider
            culture = New System.Globalization.CultureInfo("it-IT", True)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("it-IT")
            Try
                Dim ImpRiduzione As Double

                'controllo di avere tutti i parametri per il calcolo
                If ImpRuolo = 0 Or CDbl(sValRiduzione) = 0 Then
                    Return 0
                End If
                Select Case sTipoValoreRid
                    Case "P"
                        'ImpRiduzione = (ImpRuolo * CDbl(sValRiduzione)) / 100
                        ImpRiduzione = (ImpRuolo * Double.Parse(sValRiduzione, culture)) / 100
                    Case "I"
                        'ImpRiduzione = CDbl(sValRiduzione)
                        ImpRiduzione = Double.Parse(sValRiduzione, culture)
                    Case "F"
                End Select

                Return ImpRiduzione
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CalcolaRiduzioni::" & Err.Message)
                Return 0
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina l'importo di detassazione sull'importo a ruolo in base alla tipologia di detassazione.<br/>
        ''' La detassazione può essere di tipo percentuale, a valore fisso o a formula.
        ''' </summary>
        ''' <param name="ImpRuolo">Decimale contenente l'importo lordo a ruolo</param>
        ''' <param name="sTipoValoreDet">Stringa contenente la tipologia di detassazione da applicare</param>
        ''' <param name="sValDetrazione">Striga contenente il valore della detassazione da applicare</param>
        ''' <returns>
        ''' Decimale contenente l'importo di detassazione risultante dal calcolo.
        ''' Vale 0 in caso di errore.
        ''' </returns>
        ''' <remarks>
        ''' Se l'importo a ruolo o il valore della detassazione da applicare sono pari a zero la funzione non può procedere al calcolo quindi restituisce zero.
        ''' Il calcolo in base a formula attualmente non è gestito. 
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function CalcolaDetrazioni(ByVal ImpRuolo As Double, ByVal sTipoValoreDet As String, ByVal sValDetrazione As String) As Double
            Dim culture As IFormatProvider
            culture = New System.Globalization.CultureInfo("it-IT", True)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("it-IT")
            Try
                Dim ImpDetrazione As Double

                'controllo di avere tutti i parametri per il calcolo
                If ImpRuolo = 0 Or CDbl(sValDetrazione) = 0 Then
                    Return 0
                End If
                Select Case sTipoValoreDet
                    Case "P"
                        ImpDetrazione = (ImpRuolo * CDbl(sValDetrazione)) / 100
                    Case "I"
                        'ImpDetrazione = CDbl(sValDetrazione)
                        ImpDetrazione = Double.Parse(sValDetrazione, culture)
                    Case "F"
                End Select

                Return ImpDetrazione
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CalcolaDetrazioni::" & Err.Message)
                log.Warn("Si è verificato un errore in CalcolaDetrazioni::" & Err.Message)
                Return 0
            End Try
        End Function
    End Class
End Namespace