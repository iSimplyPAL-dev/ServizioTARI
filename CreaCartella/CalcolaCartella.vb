Imports RemotingInterfaceMotoreTarsu
Imports RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti

Namespace CalcoloCartellaSingola

    ''' -----------------------------------------------------------------------------
    ''' Project	 : CreaCartella
    ''' Class	 : CalcoloCartellaSingola
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' La classe CalcolaCartella determina la singola cartella di pagamento.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[monicatarello]	23/09/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class CalcolaCartella
        Public Sub New()
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina la cartella di pagamento per il contribuente e gli articoli in ingresso.<br/>
        ''' La funzione totalizza gli importi articolo a parità di anno e ne calcola le addizionali e il carico.<br/>
        ''' L'importo per anno netto, di sanzioni, interessi, spese, addizionali e arrotondamento sono inseriti nel dettaglio.<br/>
        ''' L'importo carico dovuto alla totalizzazione di tutti gli importi calcolati è arrotondato all'euro con la funzione ImportoArrotondatoEuroIntero.<br/>
        ''' Dopo aver ottenuto l'importo carico si determinano le singole rate arrotondate all'euro; mentre l'ultima rata la si ottiene per differenza.<br/>
        ''' Per ogni rata di determinano CodiceBollettino e Codeline.<br/>
        ''' </summary>
        ''' <param name="objAnagrafica">Oggetto di tipo OggettoAnagraficaCartellazione contiene i dati anagrafici del contribuente.</param>
        ''' <param name="arrayobjRuolo">Array di oggetti di tipo OggettoRuoloPerCalcoloCartelle contiene gli articoli di ruolo.</param>
        ''' <param name="arrayDatiRate">Array di oggetti di tipo OggettoDatiRata contiene i dati generali delle rate da calcolare.</param>
        ''' <param name="arrayobjAddizionali">Array di oggetti di tipo OggettoAddizionale contiene i dati generali delle addizionali da calcolare.</param>
        ''' <param name="objDatiCartellazione">Oggetto di tipo OggettoDatiCartellazione contiene i dati identificati della cartella da creare.</param>
        ''' <param name="objCartella">Oggetto di tipo OggettoCartella restituisce la cartella creata.</param>
        ''' <param name="arrayobjRateCalcolate">Array di oggetti di tipo OggettoRataCalcolata restituisce le rate della cartella create.</param>
        ''' <param name="arrayobjDettaglioCartellaPerAnno">Array di oggetti di tipo OggettoDettaglioCartella restituisce il dettaglio della cartella creato.</param>
        ''' <param name="sErrRuolo">Stringa restituisce la descrizione dell'errore generato.</param>
        ''' <returns>Intero<br/>
        ''' Il metodo restituisce <c>0</c> se si è verificato un errore; mentre restituisce <c>1</c> se è la creazione è avvenuta con successo.</returns>
        ''' <remarks>
        ''' Le addizionali sono calcolate con le seguente formula:<br/>
        ''' (importo netto * valore addizionale / 100)
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function GetCartellazione(ByVal objAnagrafica As OggettoAnagraficaCartellazione, ByVal arrayobjRuolo() As OggettoRuoloPerCalcoloCartelle, ByVal arrayDatiRate() As OggettoDatiRata, ByVal arrayobjAddizionali() As OggettoAddizionale, ByVal objDatiCartellazione As OggettoDatiCartellazione, ByRef objCartella As OggettoCartella, ByRef arrayobjRateCalcolate() As OggettoRataCalcolata, ByRef arrayobjDettaglioCartellaPerAnno() As OggettoDettaglioCartella, ByRef sErrRuolo As String) As Integer
            Try

                Dim i As Integer
                Dim nIndiceRate As Integer

                Dim dtAddizionali As DataTable
                Dim drAddizionale As DataRow

                Dim dtRate As DataTable
                Dim drRata As DataRow
                '********************************************************************
                'variabili per effettuare la select su un datatable
                '********************************************************************
                Dim expression As String
                Dim foundRows() As DataRow
                Dim nIndiceRigheTrovate As Integer
                '********************************************************************
                'variabili per memorizzare i totali generali del ruolo
                '********************************************************************
                Dim nTotaleArticoli As Double = 0
                Dim nTotaleSanzioni As Double = 0
                Dim nTotaleInteressi As Double = 0
                Dim nTotaleSpese As Double = 0
                '********************************************************************
                'variabili per memorizzare i totali generali del ruolo per anno
                '********************************************************************
                Dim objTotaliRuoloPerAnno As TotaliRuoloPerAnno
                Dim arrayobjTotaliRuoloPerAnno() As TotaliRuoloPerAnno
                Dim sAnnoRuolo As String = ""
                Dim nindiceRuoloPerAnno As Integer = 0
                '********************************************************************
                'variabili per memorizzare il dettaglio della cartella per anno
                '********************************************************************
                Dim objDettaglioCartellaPerAnno As OggettoDettaglioCartella
                'Dim arrayobjDettaglioCartellaPerAnno() As OggettoDettaglioCartella
                Dim nIndiceDettaglioCartellaPerAnno As Integer = 0
                Dim nImportoAddizionaleCalcolata As Double
                Dim nImportoPerCalcolo As Double
                '********************************************************************
                'variabili per il calcolo della cartella
                '********************************************************************
                Dim nImportoTotale As Double
                Dim nImportoArrotondamento As Double
                Dim nImportoCarico As Double
                '********************************************************************
                'variabili per il calcolo delle rate
                '********************************************************************
                Dim nImportoRataSingola As Double
                Dim nImportoUltimaRata As Double
                Dim nImportoArrotondamentoRata As Double
                Dim nNumeroRate As Integer
                Dim MyRata As OggettoRataCalcolata
                'Dim arrayMyRata() As OggettoRataCalcolata
                '********************************************************************
                'istanzio la classe contenente funzioni di utilità generale
                '********************************************************************
                Dim objGenerale As New Generale
                '********************************************************************
                'scarico l'array con i dati del ruolo in un dataset
                '********************************************************************
                For i = 0 To arrayobjRuolo.Length - 1
                    '********************************************************************
                    'totalizzo gli importi per anno e per ogni anno vado a calcolare le addizionali
                    '********************************************************************
                    If sAnnoRuolo <> arrayobjRuolo(i).Anno Then
                        objTotaliRuoloPerAnno = New TotaliRuoloPerAnno
                        ReDim Preserve arrayobjTotaliRuoloPerAnno(nindiceRuoloPerAnno)

                        nindiceRuoloPerAnno += 1
                    End If
                    objTotaliRuoloPerAnno.Anno = arrayobjRuolo(i).Anno
                    objTotaliRuoloPerAnno.ImportoNetto += arrayobjRuolo(i).ImportoNetto
                    objTotaliRuoloPerAnno.ImportoInteressi += arrayobjRuolo(i).ImportoInteressi
                    objTotaliRuoloPerAnno.ImportoSanzioni += arrayobjRuolo(i).ImportoSanzioni
                    objTotaliRuoloPerAnno.ImportoSpese += arrayobjRuolo(i).ImportoSpese

                    arrayobjTotaliRuoloPerAnno(nindiceRuoloPerAnno - 1) = objTotaliRuoloPerAnno
                    sAnnoRuolo = arrayobjRuolo(i).Anno

                    nTotaleArticoli += CDbl(arrayobjRuolo(i).ImportoNetto)
                    nTotaleSanzioni += CDbl(arrayobjRuolo(i).ImportoSanzioni)
                    nTotaleInteressi += CDbl(arrayobjRuolo(i).ImportoInteressi)
                    nTotaleSpese += CDbl(arrayobjRuolo(i).ImportoSpese)
                Next
                '********************************************************************
                'scarico l'array con i dati delle addizionali in un dataset
                '********************************************************************
                If Not IsNothing(arrayobjAddizionali) Then
                    dtAddizionali = CreaDtAddizionali()
                    For i = 0 To arrayobjAddizionali.Length - 1
                        drAddizionale = dtAddizionali.NewRow()
                        drAddizionale("ID_ADDIZIONALE") = arrayobjAddizionali(i).idAddizionale
                        drAddizionale("ANNO") = arrayobjAddizionali(i).Anno
                        drAddizionale("VALORE") = arrayobjAddizionali(i).Valore
                        drAddizionale("CODICE_CAPITOLO") = arrayobjAddizionali(i).CodiceCapitolo

                        dtAddizionali.Rows.Add(drAddizionale)
                    Next
                    '********************************************************************
                    'ciclo i totali per anno e calcolo le addizionali filtrando il datatable
                    'per anno
                    '********************************************************************+
                    nImportoTotale = 0
                    nImportoArrotondamento = 0
                    nImportoCarico = 0
                    For i = 0 To arrayobjTotaliRuoloPerAnno.Length - 1
                        '********************************************************************
                        'inserisco nel dettaglio l'importo netto, l'importo delle sanzioni, l'importo
                        'degli interessi, l'importo delle spese per anno
                        '********************************************************************
                        'importo netto
                        '********************************************************************
                        If arrayobjTotaliRuoloPerAnno(i).ImportoNetto > 0 Then
                            objDettaglioCartellaPerAnno = New OggettoDettaglioCartella
                            ReDim Preserve arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno)
                            objDettaglioCartellaPerAnno.AnnoRuolo = arrayobjTotaliRuoloPerAnno(i).Anno
                            objDettaglioCartellaPerAnno.IdVoce = -1
                            objDettaglioCartellaPerAnno.CodiceCapitolo = "0000"
                            objDettaglioCartellaPerAnno.CodiceCartella = objDatiCartellazione.CodiceCartella
                            objDettaglioCartellaPerAnno.DataEmissione = objDatiCartellazione.DataEmissione
                            objDettaglioCartellaPerAnno.ImportoVoce = CDbl(objGenerale.ImportoArrotondato(arrayobjTotaliRuoloPerAnno(i).ImportoNetto))

                            arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno) = objDettaglioCartellaPerAnno
                            nIndiceDettaglioCartellaPerAnno += 1
                        End If
                        '********************************************************************
                        'importo interessi
                        '********************************************************************
                        If arrayobjTotaliRuoloPerAnno(i).ImportoInteressi > 0 Then
                            objDettaglioCartellaPerAnno = New OggettoDettaglioCartella
                            ReDim Preserve arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno)
                            objDettaglioCartellaPerAnno.AnnoRuolo = arrayobjTotaliRuoloPerAnno(i).Anno
                            objDettaglioCartellaPerAnno.IdVoce = -1
                            objDettaglioCartellaPerAnno.CodiceCapitolo = "0424"
                            objDettaglioCartellaPerAnno.CodiceCartella = objDatiCartellazione.CodiceCartella
                            objDettaglioCartellaPerAnno.DataEmissione = objDatiCartellazione.DataEmissione
                            objDettaglioCartellaPerAnno.ImportoVoce = CDbl(objGenerale.ImportoArrotondato(arrayobjTotaliRuoloPerAnno(i).ImportoInteressi))
                            arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno) = objDettaglioCartellaPerAnno
                            nIndiceDettaglioCartellaPerAnno += 1
                        End If
                        '********************************************************************
                        'importo sanzioni
                        '********************************************************************
                        If arrayobjTotaliRuoloPerAnno(i).ImportoSanzioni > 0 Then
                            objDettaglioCartellaPerAnno = New OggettoDettaglioCartella
                            ReDim Preserve arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno)
                            objDettaglioCartellaPerAnno.AnnoRuolo = arrayobjTotaliRuoloPerAnno(i).Anno
                            objDettaglioCartellaPerAnno.IdVoce = -1
                            objDettaglioCartellaPerAnno.CodiceCapitolo = "0423"
                            objDettaglioCartellaPerAnno.CodiceCartella = objDatiCartellazione.CodiceCartella
                            objDettaglioCartellaPerAnno.DataEmissione = objDatiCartellazione.DataEmissione
                            objDettaglioCartellaPerAnno.ImportoVoce = CDbl(objGenerale.ImportoArrotondato(arrayobjTotaliRuoloPerAnno(i).ImportoSanzioni))
                            arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno) = objDettaglioCartellaPerAnno
                            nIndiceDettaglioCartellaPerAnno += 1
                        End If
                        '********************************************************************
                        'importo spese
                        '********************************************************************
                        If arrayobjTotaliRuoloPerAnno(i).ImportoSpese > 0 Then
                            objDettaglioCartellaPerAnno = New OggettoDettaglioCartella
                            ReDim Preserve arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno)
                            objDettaglioCartellaPerAnno.AnnoRuolo = arrayobjTotaliRuoloPerAnno(i).Anno
                            objDettaglioCartellaPerAnno.IdVoce = -1
                            objDettaglioCartellaPerAnno.CodiceCapitolo = "0423"
                            objDettaglioCartellaPerAnno.CodiceCartella = objDatiCartellazione.CodiceCartella
                            objDettaglioCartellaPerAnno.DataEmissione = objDatiCartellazione.DataEmissione
                            objDettaglioCartellaPerAnno.ImportoVoce = CDbl(objGenerale.ImportoArrotondato(arrayobjTotaliRuoloPerAnno(i).ImportoSpese))
                            arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno) = objDettaglioCartellaPerAnno
                            nIndiceDettaglioCartellaPerAnno += 1
                        End If
                        nImportoTotale += CDbl(objGenerale.ImportoArrotondato(arrayobjTotaliRuoloPerAnno(i).ImportoNetto + arrayobjTotaliRuoloPerAnno(i).ImportoInteressi + arrayobjTotaliRuoloPerAnno(i).ImportoSanzioni + arrayobjTotaliRuoloPerAnno(i).ImportoSpese))
                        sAnnoRuolo = arrayobjTotaliRuoloPerAnno(i).Anno
                        nImportoPerCalcolo = arrayobjTotaliRuoloPerAnno(i).ImportoNetto
                        '********************************************************************
                        'imposto la condizione di filtro
                        '********************************************************************
                        expression = "ANNO = '" & sAnnoRuolo & "'"
                        '********************************************************************
                        'tramite il metodo Select si estraggono tutte le righe che rispondono al 
                        'filtro impostato
                        '********************************************************************
                        foundRows = dtAddizionali.Select(expression)
                        '********************************************************************
                        For nIndiceRigheTrovate = 0 To foundRows.Length - 1
                            '********************************************************************
                            'calcolo delle addizionali
                            '********************************************************************
                            nImportoAddizionaleCalcolata = CDbl(objGenerale.ImportoArrotondato(nImportoPerCalcolo * foundRows(nIndiceRigheTrovate)("VALORE") / 100))

                            objDettaglioCartellaPerAnno = New OggettoDettaglioCartella
                            ReDim Preserve arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno)
                            objDettaglioCartellaPerAnno.AnnoRuolo = sAnnoRuolo
                            objDettaglioCartellaPerAnno.IdVoce = foundRows(nIndiceRigheTrovate)("ID_ADDIZIONALE")
                            objDettaglioCartellaPerAnno.CodiceCapitolo = foundRows(nIndiceRigheTrovate)("CODICE_CAPITOLO")
                            objDettaglioCartellaPerAnno.CodiceCartella = objDatiCartellazione.CodiceCartella
                            objDettaglioCartellaPerAnno.DataEmissione = objDatiCartellazione.DataEmissione
                            objDettaglioCartellaPerAnno.ImportoVoce = nImportoAddizionaleCalcolata
                            arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno) = objDettaglioCartellaPerAnno
                            nIndiceDettaglioCartellaPerAnno += 1
                            nImportoTotale += nImportoAddizionaleCalcolata
                        Next
                    Next
                    '********************************************************************
                    'calcolo l'arrotondamento all'euro
                    '********************************************************************
                    nImportoCarico = objGenerale.ImportoArrotondatoEuroIntero(nImportoTotale, nImportoArrotondamento)
                    '********************************************************************
                    'inserisco nell'array la posizione dell'arrotondamento
                    '********************************************************************
                    objDettaglioCartellaPerAnno = New OggettoDettaglioCartella
                    ReDim Preserve arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno)
                    objDettaglioCartellaPerAnno.AnnoRuolo = ""
                    objDettaglioCartellaPerAnno.IdVoce = -1
                    objDettaglioCartellaPerAnno.CodiceCapitolo = "9999"
                    objDettaglioCartellaPerAnno.CodiceCartella = objDatiCartellazione.CodiceCartella
                    objDettaglioCartellaPerAnno.DataEmissione = objDatiCartellazione.DataEmissione
                    objDettaglioCartellaPerAnno.ImportoVoce = nImportoArrotondamento
                    arrayobjDettaglioCartellaPerAnno(nIndiceDettaglioCartellaPerAnno) = objDettaglioCartellaPerAnno
                    nIndiceDettaglioCartellaPerAnno += 1
                End If
                '********************************************************************
                'scarico l'array con i dati delle rate in un dataset
                '********************************************************************
                If Not IsNothing(arrayDatiRate) Then
                    dtRate = CreaDtRate()
                    For i = 0 To arrayDatiRate.Length - 1
                        drRata = dtRate.NewRow()
                        drRata("NUMERO_RATA") = arrayDatiRate(i).NumeroRata
                        drRata("DATA_SCADENZA") = arrayDatiRate(i).DataScadenza
                        drRata("DESCRIZIONE_RATA") = arrayDatiRate(i).DescrizioneRata
                        drRata("NUMERO_CONTO_CORRENTE") = arrayDatiRate(i).NumeroContoCorrente
                        dtRate.Rows.Add(drRata)
                    Next
                    '********************************************************************
                    'determino le rate
                    '********************************************************************
                    'imposto la condizione di filtro
                    '********************************************************************
                    expression = "NUMERO_RATA <> 'U'"
                    '********************************************************************
                    'tramite il metodo Select si estraggono tutte le righe che rispondono al 
                    'filtro impostato
                    '********************************************************************
                    foundRows = dtRate.Select(expression)
                    nNumeroRate = foundRows.Length
                    '********************************************************************
                    Dim nImportoRataArrCentEuro As Double = 0
                    nIndiceRate = 0
                    If nNumeroRate > 0 Then
                        nImportoRataArrCentEuro = objGenerale.ImportoArrotondato(nImportoCarico / nNumeroRate)
                        nImportoRataSingola = objGenerale.ImportoArrotondatoEuroIntero((nImportoRataArrCentEuro), nImportoArrotondamentoRata)
                        nImportoUltimaRata = nImportoCarico - (nImportoRataSingola * (nNumeroRate - 1))
                        '********************************************************************
                        'popolo l'oggetto rate calcolate
                        '********************************************************************
                        For i = 1 To nNumeroRate - 1
                            expression = "NUMERO_RATA = '" & i & "'"
                            '********************************************************************
                            'tramite il metodo Select si estraggono tutte le righe che rispondono al 
                            'filtro impostato
                            '********************************************************************
                            foundRows = dtRate.Select(expression)

                            MyRata = New OggettoRataCalcolata
                            ReDim Preserve arrayobjRateCalcolate(nIndiceRate)

                            MyRata.NumeroRata = foundRows(0)("NUMERO_RATA")
                            MyRata.CodiceCartella = objDatiCartellazione.CodiceCartella
                            MyRata.DataEmissione = objDatiCartellazione.DataEmissione
                            MyRata.DataScadenza = foundRows(0)("DATA_SCADENZA")
                            MyRata.CodiceBollettino = CodiceBollettino(objAnagrafica.CodiceEnte, MyRata.NumeroRata.PadLeft(2, "0"), objDatiCartellazione.AnnoRiferimento, objDatiCartellazione.CodiceCartella)
                            MyRata.Codeline = Codeline(MyRata.CodiceBollettino, foundRows(0)("NUMERO_CONTO_CORRENTE"), nImportoRataSingola)
                            MyRata.DescrizioneRata = foundRows(0)("DESCRIZIONE_RATA")
                            MyRata.ImportoRata = nImportoRataSingola
                            MyRata.NumeroCC = foundRows(0)("NUMERO_CONTO_CORRENTE")
                            MyRata.CodiceBarcode = GetDataForBarcode(MyRata.CodiceBollettino, CStr(MyRata.ImportoRata), MyRata.NumeroCC)
                            arrayobjRateCalcolate(nIndiceRate) = MyRata
                            nIndiceRate += 1
                        Next

                        '********************************************************************
                        'inserisco l'ultima rata calcolata per differenza
                        '********************************************************************
                        expression = "NUMERO_RATA = '" & nNumeroRate & "'"
                        '********************************************************************
                        'tramite il metodo Select si estraggono tutte le righe che rispondono al 
                        'filtro impostato
                        '********************************************************************
                        foundRows = dtRate.Select(expression)
                        '********************************************************************
                        MyRata = New OggettoRataCalcolata
                        ReDim Preserve arrayobjRateCalcolate(nIndiceRate)

                        MyRata.NumeroRata = foundRows(0)("NUMERO_RATA")
                        MyRata.CodiceCartella = objDatiCartellazione.CodiceCartella
                        MyRata.DataEmissione = objDatiCartellazione.DataEmissione
                        MyRata.DataScadenza = foundRows(0)("DATA_SCADENZA")
                        MyRata.CodiceBollettino = CodiceBollettino(objAnagrafica.CodiceEnte, MyRata.NumeroRata.PadLeft(2, "0"), objDatiCartellazione.AnnoRiferimento, objDatiCartellazione.CodiceCartella)
                        MyRata.Codeline = Codeline(MyRata.CodiceBollettino, foundRows(0)("NUMERO_CONTO_CORRENTE"), nImportoUltimaRata)
                        MyRata.DescrizioneRata = foundRows(0)("DESCRIZIONE_RATA")
                        MyRata.ImportoRata = nImportoUltimaRata
                        MyRata.NumeroCC = foundRows(0)("NUMERO_CONTO_CORRENTE")
                        MyRata.CodiceBarcode = GetDataForBarcode(MyRata.CodiceBollettino, CStr(MyRata.ImportoRata), MyRata.NumeroCC)
                        arrayobjRateCalcolate(nIndiceRate) = MyRata
                        nIndiceRate += 1
                    End If
                    '********************************************************************
                    'verifico se è configurata l'unica soluzione
                    '********************************************************************
                    expression = "NUMERO_RATA = 'U'"
                    '********************************************************************
                    'tramite il metodo Select si estraggono tutte le righe che rispondono al 
                    'filtro impostato
                    '********************************************************************
                    foundRows = dtRate.Select(expression)
                    If foundRows.Length > 0 Then
                        MyRata = New OggettoRataCalcolata
                        ReDim Preserve arrayobjRateCalcolate(nIndiceRate)

                        MyRata.NumeroRata = foundRows(0)("NUMERO_RATA")
                        MyRata.CodiceCartella = objDatiCartellazione.CodiceCartella
                        MyRata.DataEmissione = objDatiCartellazione.DataEmissione
                        MyRata.DataScadenza = foundRows(0)("DATA_SCADENZA")
                        MyRata.CodiceBollettino = CodiceBollettino(objAnagrafica.CodiceEnte, "00", objDatiCartellazione.AnnoRiferimento, objDatiCartellazione.CodiceCartella)
                        MyRata.Codeline = Codeline(MyRata.CodiceBollettino, foundRows(0)("NUMERO_CONTO_CORRENTE"), nImportoCarico)
                        MyRata.DescrizioneRata = foundRows(0)("DESCRIZIONE_RATA")
                        MyRata.ImportoRata = nImportoCarico
                        MyRata.NumeroCC = foundRows(0)("NUMERO_CONTO_CORRENTE")
                        MyRata.CodiceBarcode = GetDataForBarcode(MyRata.CodiceBollettino, CStr(MyRata.ImportoRata), MyRata.NumeroCC)
                        arrayobjRateCalcolate(nIndiceRate) = MyRata
                    End If
                End If
                '********************************************************************
                'popolo l'oggetto cartella
                '********************************************************************
                objCartella = New OggettoCartella
                objCartella.CodiceCartella = objDatiCartellazione.CodiceCartella
                objCartella.DataEmissione = objDatiCartellazione.DataEmissione
                objCartella.CodiceEnte = objAnagrafica.CodiceEnte
                objCartella.IdContribuente = objAnagrafica.IdContribuente
                objCartella.AnnoRiferimento = objDatiCartellazione.AnnoRiferimento
                objCartella.LottoCartellazione = objDatiCartellazione.LottoCartellazione
                '********************************************************************
                'estrazione dei dati dall'array del ruolo
                '********************************************************************
                objCartella.AnniPresenzaRuolo = ""
                '********************************************************************
                objCartella.Cognome = objAnagrafica.Cognome
                objCartella.Nome = objAnagrafica.Nome
                objCartella.CodiceFiscale = objAnagrafica.CodiceFiscale
                objCartella.PartitaIVA = objAnagrafica.PartitaIVA
                objCartella.IndirizzoRes = objAnagrafica.IndirizzoRes
                objCartella.CivicoRes = objAnagrafica.CivicoRes
                objCartella.CAPRes = objAnagrafica.CAPRes
                objCartella.ComuneRes = objAnagrafica.ComuneRes
                objCartella.ProvRes = objAnagrafica.ProvRes
                objCartella.FrazRes = objAnagrafica.FrazRes
                objCartella.NominativoCO = objAnagrafica.NominativoCO
                objCartella.IndirizzoCO = objAnagrafica.IndirizzoCO
                objCartella.CivicoCO = objAnagrafica.CivicoCO
                objCartella.CAPCO = objAnagrafica.CAPCO
                objCartella.ComuneCO = objAnagrafica.ComuneCO
                objCartella.ProvCO = objAnagrafica.ProvCO
                objCartella.FrazCO = objAnagrafica.FrazCO
                '********************************************************************
                'importo al netto dell'arrotondamento
                '********************************************************************
                objCartella.ImportoTotale = objGenerale.ImportoArrotondato(nImportoTotale)
                objCartella.ImportoArrotondamento = nImportoArrotondamento
                '********************************************************************
                'importo comprensivo di arrotondamnento
                '********************************************************************
                objCartella.ImportoCarico = nImportoCarico
                '********************************************************************
                'popolo l'array delle rate calcolate
                '********************************************************************
                Return 1
            Catch Err As Exception
                Throw New Exception("Creazione Cartella::" & Err.Message)
                Return 0
            End Try
        End Function

        '*** 20101014 - aggiunta gestione stampa barcode ***
        Public Function GetDataForBarcode(ByVal sCodBollettino As String, ByVal impRata As Double, ByVal sContoCorrente As String) As String
            Dim sDataBarcode, sLenIVCampo, sLenConto, sLenImporto, sLenTipoDoc, sTipoDoc, sImpRata As String

            Try
                sLenIVCampo = "18"
                sLenConto = "12"
                sLenImporto = "10"
                sLenTipoDoc = "3"
                sTipoDoc = "896"
                sContoCorrente = sContoCorrente.PadLeft(12, "0")
                sImpRata = Format(impRata, "#,##0.00")
                sImpRata = sImpRata.Replace(",", "").Replace(".", "").PadLeft(10, "0")
                sDataBarcode = sLenIVCampo & sCodBollettino & sLenConto & sContoCorrente & sLenImporto & sImpRata & sLenTipoDoc & sTipoDoc
                Return sDataBarcode
            Catch Err As Exception
                Throw New Exception("CalcolaCartella::GetDataForBarcode::si è verificato il seguente errore::" & Err.Message)
                Return ""
            End Try
        End Function
        '************************************************

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione crea il datatable per le addizionali
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function CreaDtAddizionali() As DataTable
            Dim Ds = New DataSet

            Ds.Tables.Add("ADDIZIONALI")
            Ds.Tables("ADDIZIONALI").Columns.Add("ID_ADDIZIONALE")
            Ds.Tables("ADDIZIONALI").Columns.Add("ANNO")
            Ds.Tables("ADDIZIONALI").Columns.Add("VALORE")
            Ds.Tables("ADDIZIONALI").Columns.Add("CODICE_CAPITOLO")

            CreaDtAddizionali = Ds.Tables("ADDIZIONALI")
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        '''  La funzione crea il datatable per le rate
        ''' </summary>
        ''' <returns>DataTable</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function CreaDtRate() As DataTable

            Dim Ds = New DataSet

            Ds.Tables.Add("RATE")
            Ds.Tables("RATE").Columns.Add("NUMERO_RATA")
            Ds.Tables("RATE").Columns.Add("DATA_SCADENZA")
            Ds.Tables("RATE").Columns.Add("DESCRIZIONE_RATA")
            Ds.Tables("RATE").Columns.Add("NUMERO_CONTO_CORRENTE")

            CreaDtRate = Ds.Tables("RATE")
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina il codice bollettino per la singola rata.<br/>
        ''' Il codice è di lunghezza 18 chr così formato:<br/>
        ''' 5 chr	codice ente<br/>
        ''' 2 chr	numero rata (Unica soluzione = '00', Prima rata = '01', Seconda rata = '02', ecc…)<br/>
        ''' 2 chr	anno riferimento avviso di pagamento (ultimi due caratteri dell'anno)<br/>
        ''' 7 chr	numero avviso<br/>
        ''' 2 chr	CIN di controllo<br/><br/>
        ''' L'algoritmo per la determinazione del CIN è:<br/>
        ''' n1 = 16 caratteri (determinati in base alla logica stabilita)<br/>
        ''' n2 = Int(n1 / 93) (risultato intero della divisione tra dividendo e 93)<br/>
        ''' n3 = n2 * 93 (moltiplico il risultato della divisione per 93)<br/>
        ''' resto = n1 - n3 <br/>
        ''' CIN = resto.
        ''' </summary>
        ''' <param name="sCodEnte">Stringa contiene il codice ente.</param>
        ''' <param name="sNumeroRata">Stringa contiene il numero della rata.</param>
        ''' <param name="sAnnoRiferimento">Stringa contiene l'anno.</param>
        ''' <param name="sNumeroAvviso">Stringa contiene il numero avviso.</param>
        ''' <returns>Stringa contiene il codice bollettino calcolato.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function CodiceBollettino(ByVal sCodEnte As String, ByVal sNumeroRata As String, ByVal sAnnoRiferimento As String, ByVal sNumeroAvviso As String) As String
            '********************************************************************
            'logica di popolamento del codice bollettino
            '********************************************************************
            '5 chr	codice ente
            '2 chr	numero rata (Unica soluzione = ‘00', Prima rata = '01, Seconda rata = ‘02', ecc…')
            '2 chr	anno riferimento avviso di pagamento (ultimi due caratteri dell'anno)
            '7 chr	numero avviso
            '2 chr	caratteri di controllo
            'Algoritmo per la determinazione del CIN
            'n1 = 16 caratteri (determinati in base alla logica stabilita)
            'n2 = Int(n1 / 93) (risultato intero della divione tra dividendo e 93)
            'n3 = n2 * 93 (moltiplico il risultato della divisione per 93)
            'resto = n1 - n3 
            'formatto a due caratteri il resto.
            '********************************************************************
            Dim n1 As Double
            Dim n2 As Double
            Dim n3 As Double
            Dim cin As Integer

            CodiceBollettino = sCodEnte.PadLeft(6, "0").Substring(1, 5)
            CodiceBollettino += sNumeroRata
            CodiceBollettino += sAnnoRiferimento.Substring(2, 2)
            CodiceBollettino += sNumeroAvviso.Substring(8, 7)

            n1 = CodiceBollettino
            n2 = Int(n1 / 93)
            n3 = n2 * 93
            cin = n1 - n3

            CodiceBollettino += CStr(cin).PadRight(2, "0")

        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina la code line per la singola rata.<br/>
        ''' La code line è così formata:<br/>
        ''' &lt;codice bollettino&gt;<br/>
        ''' 9 spazi<br/>
        ''' parte intera dell'importo formattato a 8 caratteri<br/>
        ''' +<br/>
        ''' parte decimale dell'importo&gt;<br/>
        ''' conto corrente formattato a 11 caratteri (utilizzare spazi come riempimento)&lt;<br/>
        ''' 2 spazi<br/>
        ''' 896&gt;
        ''' </summary>
        ''' <param name="sCodiceBollettino">Stringa contiene il codice bollettino.</param>
        ''' <param name="sContoCorrente">Stringa contiene il conto corrente.</param>
        ''' <param name="nImportoRata">Intero contiene l'importo della rata.</param>
        ''' <returns>Stringa contiene la code line calcolata.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <example>
        ''' &lt;069920107000000177&gt;         00000096+75&gt;   73682981&lt;  896&gt;
        ''' </example>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function Codeline(ByVal sCodiceBollettino As String, ByVal sContoCorrente As String, ByVal nImportoRata As Integer) As String
            '********************************************************************
            'logica di popolamento della codeline
            '********************************************************************
            '&lt;codice bollettino&gt;
            '7:      spazi
            'parte intera dell'importo formattata a 8 caratteri
            '+
            'parte decimale dell'importo
            '&gt;
            '2 spazi
            'conto corrente formattato a 12 caratteri (utilizzare spazi come riempimento)
            '&lt;
            '2 spazi
            '896:
            '&gt;
            'Esempio:&lt;069920107000000177&gt;       00000096+75&gt;     736829814&lt;  896&gt;
            '********************************************************************
            Codeline = "<" & sCodiceBollettino & ">"
            Codeline += Space(7)
            Codeline += CStr(nImportoRata).PadLeft(8, "0")
            Codeline += "+00>"
            Codeline += Space(2) + sContoCorrente.PadLeft(12, " ")
            Codeline += "<" + Space(2) + "896>"
        End Function
    End Class
End Namespace
