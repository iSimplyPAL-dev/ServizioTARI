Imports RemotingInterfaceMotoreTarsu
Imports RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti
Imports RemotingInterfaceMotoreTarsu.RemotingInterfaceMotoreTarsu
Imports log4net

Namespace Ruolo
    ''' -----------------------------------------------------------------------------
    ''' Project	 : Ruolo
    ''' Class	 : ClsElaboraRuolo
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' La classe ClsElaboraRuolo determina i singoli articoli da mandare a ruolo.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[monicatarello]	23/09/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class ClsElaboraRuolo
        Private Shared ReadOnly log As ILog = LogManager.GetLogger(GetType(ClsElaboraRuolo))

        Public Sub New()
            log.Debug("Istanziata la classe Ruolo")
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione, partendo dalle dichiarazioni TARSU e dal ruolo principale di riferimento, determina gli articoli completi di bimestri e importi che andranno a ruolo suppletivo.<br/>
        ''' Si calcola il ruolo sulle dichiarazioni come se fosse principale, tramite la funzione CreaRuolo_AUTO_PRINCIPALE, e lo si confronta con quello di riferimento in ingresso.<br/> 
        ''' Ciclando si confrontano uno per uno gli articoli; 
        ''' se il nuovo importo calcolato è maggiore del precedente 
        ''' viene creato un articolo avente gli importi risultanti dalla differenza fra nuovo e originale di riferimento.<br/>
        ''' </summary>
        ''' <param name="ArrayDichiarazioniRidDet">Array di oggetti di tipo OggettoDichiarazioneTARSURidDet contiene i dati per la generazione degli articoli.</param>
        ''' <param name="oRuoloPrincipaleCreato">Oggetto di tipo OggettoRuoloCreato contiene gli articoli principali di riferimento.</param>
        ''' <returns>
        ''' Oggetto di tipo OggettoRuoloCreato contiene gli articoli creati con relativi totalizzatori di ruolo.<br/>
        ''' Il metodo restituisce <c>Nothing</c> se si è verificato un errore.
        ''' </returns>
        ''' <remarks>
        ''' Per poter creare articoli da dichiarazioni corretti l'array di dichiarazioni in ingresso deve essere popolato con i dati ordinati per:
        ''' - contribuente;<br/>
        ''' - dettaglio testata;<br/>
        ''' - categoria;<br/>
        ''' - data inizio;<br/> 
        ''' - data fine.<br/> 
        ''' Gli array interni per il confronto fra nuovo calcolato e principale di riferimento sono ordinati all'interno della procedura per contribuente, dettaglio testata, categoria.<br/>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function CreaRuolo_AUTO_SUPPLETIVO(ByVal ArrayDichiarazioniRidDet() As OggettoDichiarazioneTARSURidDet, ByVal oRuoloPrincipaleCreato As OggettoRuoloCreato) As OggettoRuoloCreato
            Try
                Dim oRuoloPrincipaleNew As New OggettoRuoloCreato
                Dim oArticoliNew As OggettoArticoloRuolo()
                Dim oArticoliOrg As OggettoArticoloRuolo()
                Dim oArticoloRuolo As OggettoArticoloRuolo
                Dim y, x As Integer
                Dim IsTrovato As Boolean = False
                Dim oRuoloCreato As OggettoRuoloCreato
                Dim oTestataRuolo As OggettoTestataRuolo
                Dim oListArticoliCreati As OggettoArticoloRuolo()
                Dim nList As Integer = -1
                Dim nTotArticoli As Integer = 0
                Dim nTotContribuenti As Integer = 0
                Dim nTotMq As Double = 0
                Dim impTotArticoli As Double = 0
                Dim impTotRiduzioni As Double = 0
                Dim impTotDetrazioni As Double = 0
                Dim impTotNetto As Double = 0
                Dim nContribPrec As Integer

                'calcolo il ruolo come nuovo
                oRuoloPrincipaleNew = CreaRuolo_AUTO_PRINCIPALE(ArrayDichiarazioniRidDet)
                'memorizzo gli articoli calcolati precedentemente e quelli calcolati adesso
                oArticoliNew = oRuoloPrincipaleNew.oArrayArticoliRuolo
                oArticoliOrg = oRuoloPrincipaleCreato.oArrayArticoliRuolo
                'ordino gli oggetti
                Array.Sort(oArticoliNew, New Utility.Comparatore(New String() {"IdContribuente", "IdDettaglioTestata", "Categoria"}, New Boolean() {Utility.TipoOrdinamento.Crescente, Utility.TipoOrdinamento.Crescente, Utility.TipoOrdinamento.Crescente}))
                Array.Sort(oArticoliOrg, New Utility.Comparatore(New String() {"IdContribuente", "IdDettaglioTestata", "Categoria"}, New Boolean() {Utility.TipoOrdinamento.Crescente, Utility.TipoOrdinamento.Crescente, Utility.TipoOrdinamento.Crescente}))
                'ciclo sugli articoli nuovi
                For x = 0 To oArticoliNew.GetUpperBound(0)
                    'ciclo sugli articoli originali
                    For y = 0 To oArticoliOrg.GetUpperBound(0)
                        'il contribuente è lo stesso
                        If oArticoliOrg(y).IdContribuente = oArticoliNew(x).IdContribuente Then
                            'la testata è la stessa
                            If oArticoliOrg(y).IdDettaglioTestata = oArticoliNew(x).IdDettaglioTestata Then
                                'la categoria è la stessa
                                If oArticoliOrg(y).Categoria = oArticoliNew(x).Categoria Then
                                    'l'importo è lo stesso?
                                    '*** 20130313 - inserisco sempre l'articolo per differenza importo tra originale e nuovo per quadrare i conti ***
                                    'If FormatNumber(oArticoliNew(x).ImportoNetto, 2) > FormatNumber(oArticoliOrg(y).ImportoNetto, 2) Then
                                    '    'creo l'articolo supplettivo
                                    '    IsTrovato = True
                                    '    oArticoloRuolo = New OggettoArticoloRuolo
                                    '    oArticoloRuolo = ValDatiArticolo(oArticoliNew(x), oArticoliOrg(y).ImportoRuolo, oArticoliOrg(y).ImportoRiduzione, oArticoliOrg(y).ImportoDetassazione)
                                    '    'aggiungo il nuovo articolo all'array
                                    '    nList += 1
                                    '    ReDim Preserve oListArticoliCreati(nList)
                                    '    oListArticoliCreati(nList) = oArticoloRuolo
                                    '    nTotArticoli += 1
                                    '    If nContribPrec <> oArticoliNew(x).IdContribuente Then
                                    '        nTotContribuenti += 1
                                    '    End If
                                    '    nTotMq += oArticoloRuolo.MQ
                                    '    impTotArticoli += oArticoloRuolo.ImportoRuolo
                                    '    impTotRiduzioni += oArticoloRuolo.ImportoRiduzione
                                    '    impTotDetrazioni += oArticoloRuolo.ImportoDetassazione
                                    '    impTotNetto += oArticoloRuolo.ImportoNetto
                                    'Else
                                    '    IsTrovato = True
                                    '    Exit For
                                    'End If
                                    'creo l'articolo supplettivo
                                    IsTrovato = True
                                    oArticoloRuolo = New OggettoArticoloRuolo
                                    oArticoloRuolo = ValDatiArticolo(oArticoliNew(x), oArticoliOrg(y).ImportoRuolo, oArticoliOrg(y).ImportoRiduzione, oArticoliOrg(y).ImportoDetassazione)
                                    'aggiungo il nuovo articolo all'array
                                    nList += 1
                                    ReDim Preserve oListArticoliCreati(nList)
                                    oListArticoliCreati(nList) = oArticoloRuolo
                                    nTotArticoli += 1
                                    If nContribPrec <> oArticoliNew(x).IdContribuente Then
                                        nTotContribuenti += 1
                                    End If
                                    nTotMq += oArticoloRuolo.MQ
                                    impTotArticoli += oArticoloRuolo.ImportoRuolo
                                    impTotRiduzioni += oArticoloRuolo.ImportoRiduzione
                                    impTotDetrazioni += oArticoloRuolo.ImportoDetassazione
                                    impTotNetto += oArticoloRuolo.ImportoNetto
                                    '*** ***
                                End If
                            End If
                        End If
                    Next
                    If IsTrovato = False Then
                        'creo l'articolo supplettivo
                        oArticoloRuolo = New OggettoArticoloRuolo
                        oArticoloRuolo = ValDatiArticolo(oArticoliNew(x), 0, 0, 0)
                        'aggiungo il nuovo articolo all'array
                        nList += 1
                        ReDim Preserve oListArticoliCreati(nList)
                        oListArticoliCreati(nList) = oArticoloRuolo
                        nTotArticoli += 1
                        If nContribPrec <> oArticoliNew(x).IdContribuente Then
                            nTotContribuenti += 1
                        End If
                        nTotMq += oArticoloRuolo.MQ
                        impTotArticoli += oArticoloRuolo.ImportoRuolo
                        impTotRiduzioni += oArticoloRuolo.ImportoRiduzione
                        impTotDetrazioni += oArticoloRuolo.ImportoDetassazione
                        impTotNetto += oArticoloRuolo.ImportoNetto
                    End If
                    nContribPrec = oArticoliNew(x).IdContribuente
                    IsTrovato = False
                Next
                'popolo l'oggetto finale
                oRuoloCreato = New OggettoRuoloCreato
                oTestataRuolo = New OggettoTestataRuolo

                oTestataRuolo.NumeroArticoli = nTotArticoli
                oTestataRuolo.NumeroContribuenti = nTotContribuenti
                oTestataRuolo.Mq = nTotMq
                oTestataRuolo.ImportoArticoli = impTotArticoli
                oTestataRuolo.ImportoNetto = impTotNetto
                oTestataRuolo.ImportoRiduzione = impTotRiduzioni
                oTestataRuolo.ImportoDetassazione = impTotDetrazioni

                oRuoloCreato.oArrayArticoliRuolo = oListArticoliCreati
                oRuoloCreato.objTestataRuolo = oTestataRuolo

                Return oRuoloCreato
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CreaRuolo_AUTO_SUPPLETIVO::" & Err.Message)
                log.Warn("Si è verificato un errore in CreaRuolo_AUTO_SUPPLETIVO::" & Err.Message)
                Dim objErrReturn As OggettoRuoloCreato
                Return objErrReturn
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione, partendo dalle dichiarazioni TARSU, determina gli articoli completi di bimestri e importi che andranno a ruolo.<br/>
        ''' Ciclando su tutte le dichiarazioni TARSU passate alla funzione si determina un nuovo articolo a cambio di:
        ''' - dettaglio testata;<br/>
        ''' - categoria;<br/>
        ''' - data inizio;<br/> 
        ''' - data fine.<br/> 
        ''' Se i dati non cambiano i metri sono sommati all'articolo in corso.<br/>
        ''' Gli importi a ruolo sono derminati richiamando la funzione CalcolaImportiRuolo.<br/>
        ''' </summary>
        ''' <param name="ArrayDichiarazioniRidDet">Array di oggetti di tipo OggettoDichiarazioneTARSURidDet contiene i dati per la generazione degli articoli.</param>
        ''' <returns>
        ''' Oggetto di tipo OggettoRuoloCreato contiene gli articoli creati con relativi totalizzatori di ruolo.<br/>
        ''' Il metodo restituisce <c>Nothing</c> se si è verificato un errore.
        ''' </returns>
        ''' <remarks>
        ''' Per poter creare articoli corretti l'array di dichiarazioni in ingresso deve essere popolato con i dati ordinati per:
        ''' - contribuente;<br/>
        ''' - dettaglio testata;<br/>
        ''' - categoria;<br/>
        ''' - data inizio;<br/> 
        ''' - data fine.<br/> 
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function CreaRuolo_AUTO_PRINCIPALE(ByVal ArrayDichiarazioniRidDet() As OggettoDichiarazioneTARSURidDet) As OggettoRuoloCreato
            Try
                Dim i As Integer
                Dim oDichiarazione As New OggettoDichiarazioneTARSU
                Dim oArrayRiduzioni() As OggettoRiduzione
                Dim oArrayDetrazioni() As OggettoDetassazione
                Dim oRuoloCreato As OggettoRuoloCreato
                Dim oTestataRuolo As OggettoTestataRuolo
                Dim oArrayArticoliCreati As OggettoArticoloRuolo()
                Dim oArticoloRuolo As OggettoArticoloRuolo
                Dim arrayListArticoli As New ArrayList
                Dim CODCONTRIBUENTE As Long
                Dim IDDETTAGLIOTESTATA As Integer = 0
                Dim IDCATEGORIA As String = String.Empty
                Dim DATAINIZIO As Date = Date.MinValue
                Dim DATAFINE As Date = Date.MinValue
                Dim iNumeroArticoli As Integer
                Dim iNumeroContribuenti As Integer
                Dim dblSumTotMQ As Double
                Dim dblSumImportoArticolo As Double
                Dim dblSumImportoNetto As Double
                Dim dblSumImportoRiduzioni As Double
                Dim dblSumImportoDetrazioni As Double
                Dim blnRet
                Dim blnRetVal As Boolean = False
                Dim IsCalcolato As Integer = 0

                oArticoloRuolo = New OggettoArticoloRuolo
                For i = 0 To ArrayDichiarazioniRidDet.Length - 1
                    'prelevo la dichiarazione 
                    oDichiarazione = ArrayDichiarazioniRidDet(i).objDichiarazioneTARSU
                    'prelevo le (eventuali) riduzioni del dettaglio testata (immobile)
                    oArrayRiduzioni = ArrayDichiarazioniRidDet(i).objRiduzione
                    'prelevo le (eventuali) Detrazioni del dettaglio testata (immobile)
                    oArrayDetrazioni = ArrayDichiarazioniRidDet(i).objDetassazione
                    iNumeroContribuenti = iNumeroContribuenti + ContaContrib(1, oDichiarazione, CODCONTRIBUENTE)
                    blnRetVal = isPositionChanged(i, oDichiarazione, IDDETTAGLIOTESTATA, IDCATEGORIA, DATAINIZIO, DATAFINE)

                    CODCONTRIBUENTE = oDichiarazione.IdContribuente
                    IDDETTAGLIOTESTATA = oDichiarazione.IdDettaglioTestata
                    IDCATEGORIA = oDichiarazione.IDCategoria
                    DATAINIZIO = oDichiarazione.DataInizio
                    DATAFINE = oDichiarazione.DataFine

                    If blnRetVal = False Then
                        'prelevo i dati dell'articolo sommando i metri
                        oArticoloRuolo = ValDatiArticolo(oDichiarazione, oArrayRiduzioni, oArrayDetrazioni)
                        IsCalcolato = 0
                    Else
                        'devo calcolare solo se i bimestri e  metri sono >0
                        If oArticoloRuolo.NumeroBimestri > 0 And oArticoloRuolo.MQ > 0 Then
                            'calcolo i bimestri e gli importi
                            oArticoloRuolo = ValImportiArticolo(oArticoloRuolo)
                            IsCalcolato = 1
                            'aggiorno i totalizzatori
                            iNumeroArticoli = iNumeroArticoli + 1
                            dblSumImportoArticolo += oArticoloRuolo.ImportoRuolo
                            dblSumImportoNetto += oArticoloRuolo.ImportoNetto
                            dblSumImportoRiduzioni += oArticoloRuolo.ImportoRiduzione
                            dblSumImportoDetrazioni += oArticoloRuolo.ImportoDetassazione
                            dblSumTotMQ += oArticoloRuolo.MQ
                            'aggiungo il nuovo articolo all'array
                            arrayListArticoli.Add(oArticoloRuolo)
                            oArticoloRuolo = New OggettoArticoloRuolo
                        End If
                        'prelevo i dati dell'articolo sommando i metri
                        oArticoloRuolo = ValDatiArticolo(oDichiarazione, oArrayRiduzioni, oArrayDetrazioni)
                        IsCalcolato = 0
                    End If
                Next
                If IsCalcolato = 0 Then
                    'devo calcolare solo se i bimestri e  metri sono >0
                    If oArticoloRuolo.NumeroBimestri > 0 And oArticoloRuolo.MQ > 0 Then
                        'calcolo i bimestri e gli importi
                        oArticoloRuolo = ValImportiArticolo(oArticoloRuolo)
                        IsCalcolato = 1
                        'aggiorno i totalizzatori
                        iNumeroArticoli = iNumeroArticoli + 1
                        dblSumImportoArticolo += oArticoloRuolo.ImportoRuolo
                        dblSumImportoNetto += oArticoloRuolo.ImportoNetto
                        dblSumImportoRiduzioni += oArticoloRuolo.ImportoRiduzione
                        dblSumImportoDetrazioni += oArticoloRuolo.ImportoDetassazione
                        dblSumTotMQ += oArticoloRuolo.MQ
                        'aggiungo il nuovo articolo all'array
                        arrayListArticoli.Add(oArticoloRuolo)
                    End If
                End If
                oArrayArticoliCreati = CType(arrayListArticoli.ToArray(GetType(OggettoArticoloRuolo)), OggettoArticoloRuolo())

                oRuoloCreato = New OggettoRuoloCreato
                oTestataRuolo = New OggettoTestataRuolo

                oTestataRuolo.NumeroArticoli = iNumeroArticoli
                oTestataRuolo.NumeroContribuenti = iNumeroContribuenti
                oTestataRuolo.Mq = dblSumTotMQ
                oTestataRuolo.ImportoArticoli = dblSumImportoArticolo
                oTestataRuolo.ImportoNetto = dblSumImportoNetto
                oTestataRuolo.ImportoRiduzione = dblSumImportoRiduzioni
                oTestataRuolo.ImportoDetassazione = dblSumImportoDetrazioni

                oRuoloCreato.oArrayArticoliRuolo = oArrayArticoliCreati
                oRuoloCreato.objTestataRuolo = oTestataRuolo

                Return oRuoloCreato

            Catch Err As Exception
                log.Debug("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::" & Err.Message)
                log.Warn("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::" & Err.Message)

                Dim objErrReturn As OggettoRuoloCreato
                Return objErrReturn
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione popola i dati base dell'articolo a ruolo.
        ''' </summary>
        ''' <param name="oMyDichiarazione">Oggetto di tipo OggettoDichiarazioneTARSU contiene i dati da associare all'articolo.</param>
        ''' <param name="oListRiduzioni">Array di oggetti di tipo OggettoRiduzione contiene le riduzioni da associare all'articolo.</param>
        ''' <param name="oListDetrazioni">Array di oggetti di tipo OggettoDetassazione contiene le detassazioni da associare all'articolo.</param>
        ''' <returns>Oggetto di tipo OggettoArticoloRuolo contiene l'articolo creato.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function ValDatiArticolo(ByVal oMyDichiarazione As OggettoDichiarazioneTARSU, ByVal oListRiduzioni() As OggettoRiduzione, ByVal oListDetrazioni() As OggettoDetassazione) As OggettoArticoloRuolo
            Dim oMyArticolo As New OggettoArticoloRuolo
            Try
                oMyArticolo.Ente = oMyDichiarazione.Ente
                oMyArticolo.Anno = oMyDichiarazione.Anno
                oMyArticolo.IdDettaglioTestata = oMyDichiarazione.IdDettaglioTestata
                oMyArticolo.IdTestata = oMyDichiarazione.IdTestata
                oMyArticolo.IdContribuente = oMyDichiarazione.IdContribuente
                oMyArticolo.Categoria = oMyDichiarazione.IDCategoria
                oMyArticolo.Via = oMyDichiarazione.Via
                oMyArticolo.Civico = oMyDichiarazione.Civico
                oMyArticolo.Esponente = oMyDichiarazione.Esponente
                oMyArticolo.Interno = oMyDichiarazione.Interno
                oMyArticolo.Scala = oMyDichiarazione.Scala
                oMyArticolo.DataFine = oMyDichiarazione.DataFine
                oMyArticolo.DataInizio = oMyDichiarazione.DataInizio
                oMyArticolo.Foglio = oMyDichiarazione.Foglio
                oMyArticolo.Numero = oMyDichiarazione.Numero
                oMyArticolo.Subalterno = oMyDichiarazione.Subalterno
                oMyArticolo.ImportoForzato = False
                oMyArticolo.IDTariffa = oMyDichiarazione.IDTariffa
                oMyArticolo.ImpTariffa = oMyDichiarazione.ImportoTariffa
                oMyArticolo.MQ += oMyDichiarazione.MQ
                If oMyDichiarazione.GiorniTARSU > 0 Then
                    oMyArticolo.NumeroBimestri = oMyDichiarazione.GiorniTARSU
                    oMyArticolo.IsTarsuGiornaliera = True
                Else
                    oMyArticolo.NumeroBimestri = GetBimestri(oMyDichiarazione.DataInizio, oMyDichiarazione.DataFine, oMyDichiarazione.Anno)
                    oMyArticolo.IsTarsuGiornaliera = False
                End If
                oMyArticolo.DaAccertamento = False
                oMyArticolo.oRiduzioni = oListRiduzioni
                oMyArticolo.oDetassazioni = oListDetrazioni

                Return oMyArticolo
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::ValDatiArticolo::" & Err.Message)
                log.Warn("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::ValDatiArticolo::" & Err.Message)
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione popola i dati dell'articolo a ruolo; gli importi sono determinati sottraendo i valori passati alla funzione nell'articolo con i corrispettivi originali.
        ''' </summary>
        ''' <param name="oMyArticoloNew">Oggetto di tipo OggettoArticoloRuolo contiene l'articolo a ruolo da associare al nuovo articolo.</param>
        ''' <param name="impRuoloOrg">Decimale contiene l'importo articolo originale.</param>
        ''' <param name="impRidOrg">Decimale contiene l'importo riduzione originale.</param>
        ''' <param name="impDetOrg">Decimale contiene l'importo detassazione originale.</param>
        ''' <returns>Oggetto di tipo OggettoArticoloRuolo contiene l'articolo creato.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function ValDatiArticolo(ByVal oMyArticoloNew As OggettoArticoloRuolo, ByVal impRuoloOrg As Double, ByVal impRidOrg As Double, ByVal impDetOrg As Double) As OggettoArticoloRuolo
            Dim oMyArticolo As New OggettoArticoloRuolo
            Try
                oMyArticolo.Ente = oMyArticoloNew.Ente
                oMyArticolo.Anno = oMyArticoloNew.Anno
                oMyArticolo.IdDettaglioTestata = oMyArticoloNew.IdDettaglioTestata
                oMyArticolo.IdContribuente = oMyArticoloNew.IdContribuente
                oMyArticolo.Categoria = oMyArticoloNew.Categoria
                oMyArticolo.Via = oMyArticoloNew.Via
                oMyArticolo.Civico = oMyArticoloNew.Civico
                oMyArticolo.Esponente = oMyArticoloNew.Esponente
                oMyArticolo.Interno = oMyArticoloNew.Interno
                oMyArticolo.Scala = oMyArticoloNew.Scala
                oMyArticolo.DataFine = oMyArticoloNew.DataFine
                oMyArticolo.DataInizio = oMyArticoloNew.DataInizio
                oMyArticolo.Foglio = oMyArticoloNew.Foglio
                oMyArticolo.Numero = oMyArticoloNew.Numero
                oMyArticolo.Subalterno = oMyArticoloNew.Subalterno
                oMyArticolo.IDTariffa = oMyArticoloNew.IDTariffa
                oMyArticolo.ImpTariffa = oMyArticoloNew.ImpTariffa
                oMyArticolo.MQ = oMyArticoloNew.MQ
                oMyArticolo.NumeroBimestri = oMyArticoloNew.NumeroBimestri
                oMyArticolo.ImportoForzato = True
                oMyArticolo.ImportoRuolo = oMyArticoloNew.ImportoRuolo - impRuoloOrg
                oMyArticolo.ImportoRiduzione = oMyArticoloNew.ImportoRiduzione - impRidOrg
                oMyArticolo.ImportoDetassazione = oMyArticoloNew.ImportoDetassazione - impDetOrg
                If impRuoloOrg = 0 Then
                    oMyArticolo.ImportoNetto = oMyArticoloNew.ImportoNetto
                Else
                    oMyArticolo.ImportoNetto = oMyArticolo.ImportoRuolo
                End If
                oMyArticolo.IsTarsuGiornaliera = oMyArticoloNew.IsTarsuGiornaliera
                oMyArticolo.DaAccertamento = oMyArticoloNew.DaAccertamento
                oMyArticolo.oRiduzioni = oMyArticoloNew.oRiduzioni
                oMyArticolo.oDetassazioni = oMyArticoloNew.oDetassazioni

                Return oMyArticolo
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CreaRuolo_AUTO_SUPPLETIVO::ValDatiArticolo::" & Err.Message)
                log.Warn("Si è verificato un errore in CreaRuolo_AUTO_SUPPLETIVO::ValDatiArticolo::" & Err.Message)
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione richiama la funzione per il calcolo degli importi dell'articolo.
        ''' </summary>
        ''' <param name="oValArticolo">Oggetto di tipo OggettoArticoloRuolo contiene l'articolo sul quale calcolare gli importi.</param>
        ''' <returns>Oggetto di tipo OggettoArticoloRuolo contiene l'articolo con gli importi calcolati.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function ValImportiArticolo(ByVal oValArticolo As OggettoArticoloRuolo) As OggettoArticoloRuolo
            Dim oMyArticolo As New OggettoArticoloRuolo
            Dim oClsImportiRuolo As New ImportiRuolo.ClsImportiRuolo

            Try
                oMyArticolo = oValArticolo
                If oClsImportiRuolo.CalcolaImportiRuolo(oMyArticolo, oMyArticolo.oRiduzioni, oMyArticolo.oDetassazioni) = False Then
                    log.Debug("Si è verificato un errore in CalcolaImportiRuolo")
                    log.Warn("Si è verificato un errore in CalcolaImportiRuolo")

                    Return Nothing
                End If

                Return oMyArticolo
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::ValImportiArticolo::" & Err.Message)
                log.Warn("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::ValImportiArticolo::" & Err.Message)
            End Try
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina se il contribuente attuale è diverso dalla posizione precedente.
        ''' </summary>
        ''' <param name="iCount">Intero indica se si è al primo giro.</param>
        ''' <param name="objDichiarazione">Oggetto di tipo OggettoDichiarazioneTARSU contiene il contribuente attuale.</param>
        ''' <param name="CODCONTRIBUENTE">Intero contiene il contribuente precedente.</param>
        ''' <returns>Intero<br/>
        ''' Il metodo restituisce <c>0</c> se il contribuente è uguale al precedente; mentre restituisce <c>1</c> se è diverso.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function ContaContrib(ByVal iCount As Integer, ByVal objDichiarazione As OggettoDichiarazioneTARSU, ByVal CODCONTRIBUENTE As Integer) As Integer
            'primo giro, sempre 1
            If iCount = 0 Then
                Return 1
            End If

            'se IdContribuente attuale è diverso da IdContribuente della posizione precedente
            If objDichiarazione.IdContribuente <> CODCONTRIBUENTE Then
                Return 1
            End If

            Return 0
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina se i dati fondamentali per l'articolo della dichiarazione corrente sono diversi dalla posizione precedente.
        ''' </summary>
        ''' <param name="iCount">Intero indica se si è al primo giro.</param>
        ''' <param name="objDichiarazione">Oggetto di tipo OggettoDichiarazioneTARSU contiene i dati della dichiarazione.</param>
        ''' <param name="IDDETTAGLIOTESTATA">Intero contiene l'identificativo del dettaglio testata precedente.</param>
        ''' <param name="IDCATEGORIA">Stringa contiene l'identificativo della categoria precedente.</param>
        ''' <param name="DATAINIZIO">Data contiene la data di inizio precedente.</param>
        ''' <param name="DATAFINE">Data contiene la data di inizio precedente.</param>
        ''' <returns>Intero<br/>
        ''' Il metodo restituisce <c>0</c> se il contribuente è uguale al precedente; mentre restituisce <c>1</c> se è diverso.</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Private Function isPositionChanged(ByVal iCount As Integer, ByVal objDichiarazione As OggettoDichiarazioneTARSU, ByVal IDDETTAGLIOTESTATA As Integer, ByVal IDCATEGORIA As String, ByVal DATAINIZIO As Date, ByVal DATAFINE As Date) As Boolean
            'primo giro, sempre false
            If iCount = 0 Then
                Return False
            End If

            'se iddettaglio testata attuale è diverso da iddettaglio testata della posizione precedente
            If objDichiarazione.IdDettaglioTestata <> IDDETTAGLIOTESTATA Then
                Return True
            End If

            'se id categoria attuale è diverso da id categoriadella posizione precedente
            If objDichiarazione.IDCategoria.CompareTo(IDCATEGORIA) <> 0 Then
                Return True
            End If

            'se iDataInizio attuale è diverso da DataInizio della posizione precedente
            If objDichiarazione.DataInizio.CompareTo(DATAINIZIO) <> 0 Then
                Return True
            End If

            'se DataFine attuale è diverso da DataFine della posizione precedente
            If objDichiarazione.DataFine.CompareTo(DATAFINE) Then
                Return True
            End If

            Return False
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina il numero di bimestri validi per l'articolo in base alla formula:<br/>
        ''' Math.Floor(DateDiff(DateInterval.Month, tStart, tEnd) / 2).<br/>
        ''' Si inizia a pagare dal bimestre solare successivo a quello di occupazione e si finisce al bimestre solare successivo la fine occupazione.<br/>
        ''' </summary>
        ''' <param name="tStart">Data contiene la data di partenza per il calcolo.</param>
        ''' <param name="tEnd">Data contiene la data di fine per il calcolo.</param>
        ''' <param name="nAnnoBimestri">Intero contiene l'anno di calcolo.</param>
        ''' <returns>Intero contiene il numero di bimestri risultanti dal calcolo.</returns>
        ''' <remarks>
        ''' Se l'anno di calcolo è successivo alla data di partenza la data di partenza è pari a 31/12/nAnnoBimestri - 1.<br/>
        ''' Se la data di partenza è un mese dispari deve essere considerata come se fosse il primo giorno del mese pari successivo.<br/>
        ''' Se la data di fine non è presente o è successiva all'anno di calcolo è considerata pari a 31/12/nAnnoBimestri
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	22/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function GetBimestri(ByVal tStart As Date, ByVal tEnd As Date, ByVal nAnnoBimestri As Integer) As Integer
            'si inizia a pagare dal bimestre solare successivo a quello di occupazione e si finisce al bimestre solare successivo la fine occupazione
            Dim culture As IFormatProvider
            culture = New System.Globalization.CultureInfo("it-IT", True)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("it-IT")
            Try
                Dim nStartMonth, nEndMonth, nBimestri As Integer

                If tStart.Year < nAnnoBimestri Or (tStart.Month = 1 And tStart.Day = 1) Then
                    tStart = "31/12/" & nAnnoBimestri - 1
                Else
                    'controllo se sono in mese pari o dispari
                    Select Case (tStart.Month Mod 2)
                        Case 0 'non devo fare nulla altrimenti sballa la differenza
                        Case Else
                            'se è un mese dispari deve essere considerata come se fosse il primo del mese pari successivo
                            tStart = tStart.AddMonths(+1)
                    End Select
                End If
                If (Not IsNothing(tEnd) And CStr(tEnd).Replace(".", ":") <> "0:00:00") Or tEnd <> Date.MinValue Then
                    If tEnd.Year > nAnnoBimestri Then
                        tEnd = "31/12/" & nAnnoBimestri
                    End If
                Else
                    tEnd = "31/12/" & nAnnoBimestri
                End If
                'controllo se sono in mese pari o dispari
                Select Case (tEnd.Month Mod 2)
                    Case 0 'non devo fare nulla altrimenti sballa la differenza
                    Case Else
                        'se è un mese dispari deve essere considerata come se fosse il primo del mese pari successivo
                        tEnd = tEnd.AddMonths(+1)
                End Select

                nBimestri = Math.Floor(DateDiff(DateInterval.Month, tStart, tEnd) / 2)

                Return nBimestri
            Catch Err As Exception
                log.Debug("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::GetBimestri::" & Err.Message)
                log.Warn("Si è verificato un errore in CreaRuolo_AUTO_PRINCIPALE::GetBimestri::" & Err.Message)
                Throw New Exception("GetBimestri::" & Err.Message)
                Return 0
            End Try
        End Function
    End Class
End Namespace