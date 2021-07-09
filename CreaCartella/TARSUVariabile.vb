Imports log4net
Imports RemotingInterfaceMotoreTarsu.MotoreTarsuVARIABILE.Oggetti
''' <summary>
''' La classe determina i singoli avvisi e relativi articoli da mandare a ruolo.
''' </summary>
Public Class TARSUVariabile
    Private Shared Log As ILog = LogManager.GetLogger(GetType(TARSUVariabile))

    Public Sub New()
        Log.Debug("Istanziata la classe TARSUVariabile")
    End Sub

#Region "Calcolo Avvisi"
    Public Function CalcolaAvvisi(ByVal oDatiCalcolo() As ObjAvviso) As ObjAvviso()
        Dim x, y, nListAvvisi, nListArticoli, nContribPrec, nDettaglioTestataPrec, IsCalcolato As Integer
        Dim sCategoriaPrec, sTipoPartitaPrec As String
        Dim tDataInizioPrec, tDataFinePrec As Date
        Dim oListAvvisi() As ObjAvviso = Nothing
        Dim oMyAvviso As ObjAvviso = Nothing
        Dim oArticoloRuolo As New ObjArticolo
        Dim oListArticoli() As ObjArticolo = Nothing
        Dim FncAdd As New CalcoloCartellaSingola.CalcolaCartella
        Dim oAnagConv As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAnagraficaCartellazione
        'Dim oArtConv() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRuoloPerCalcoloCartelle
        Dim oDatiCartelleConv As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiCartellazione
        Dim oAvvisoConv As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoCartella
        'Dim sMyErr As String
        Dim impTotaleAvviso As Double

        Try
            nListAvvisi = -1 : nListArticoli = -1
            sCategoriaPrec = "" : sTipoPartitaPrec = ""
            'ciclo su tutti i dati in ingresso
            For x = 0 To oDatiCalcolo.GetUpperBound(0)
                'se cambia il contribuente
                If oDatiCalcolo(x).IdContribuente <> nContribPrec Then
                    If Not IsNothing(oMyAvviso) Then
                        'se non ho ancora calcolato gli importi li calcolo
                        If IsCalcolato = 0 Then
                            If CalcoloPF(False, oArticoloRuolo, oListArticoli, nListArticoli, impTotaleAvviso) = False Then
                                Return Nothing
                            End If
                            IsCalcolato = 1
                        End If
                        'aggiungo gli articoli all'avviso
                        oMyAvviso.oArticoli = oListArticoli
                        oMyAvviso.impTotale = impTotaleAvviso
                        ''*** 20131024 - TARES ***
                        oMyAvviso.impdovuto = impTotaleAvviso
                        'If CalcoloPM(False, oDatiCalcolo(x).oMaggiorazione.otariffa, oDatiCalcolo(x).oMaggiorazione.oriduzioni, oListArticoli, nListArticoli) Then
                        '    Return Nothing
                        'End If
                        ''*** ***
                        'ridimensiono l'array degli avvisi calcolati
                        nListAvvisi += 1
                        ReDim Preserve oListAvvisi(nListAvvisi)
                        oListAvvisi(nListAvvisi) = oMyAvviso
                    End If
                    'genero nuovo avviso
                    oMyAvviso = New ObjAvviso
                    nListArticoli = -1 : impTotaleAvviso = 0
                    'valorizzo i dati dell'avviso
                    oMyAvviso.IdContribuente = oDatiCalcolo(x).IdContribuente
                    oMyAvviso.IdEnte = oDatiCalcolo(x).IdEnte
                    oMyAvviso.sAnnoRiferimento = oDatiCalcolo(x).sAnnoRiferimento
                    oMyAvviso.sCognome = oDatiCalcolo(x).sCognome
                    oMyAvviso.sNome = oDatiCalcolo(x).sNome
                    oMyAvviso.sCodFiscale = oDatiCalcolo(x).sCodFiscale
                    oMyAvviso.sPIVA = oDatiCalcolo(x).sPIVA
                    oMyAvviso.sIndirizzoRes = oDatiCalcolo(x).sIndirizzoRes
                    oMyAvviso.sCivicoRes = oDatiCalcolo(x).sCivicoRes
                    oMyAvviso.sFrazRes = oDatiCalcolo(x).sFrazRes
                    oMyAvviso.sCAPRes = oDatiCalcolo(x).sCAPRes
                    oMyAvviso.sComuneRes = oDatiCalcolo(x).sComuneRes
                    oMyAvviso.sProvRes = oDatiCalcolo(x).sProvRes
                    oMyAvviso.sNominativoCO = oDatiCalcolo(x).sNominativoCO
                    oMyAvviso.sIndirizzoCO = oDatiCalcolo(x).sIndirizzoCO
                    oMyAvviso.sCivicoCO = oDatiCalcolo(x).sCivicoCO
                    oMyAvviso.sFrazCO = oDatiCalcolo(x).sFrazCO
                    oMyAvviso.sCAPCO = oDatiCalcolo(x).sCAPCO
                    oMyAvviso.sComuneCO = oDatiCalcolo(x).sComuneCO
                    oMyAvviso.sProvCO = oDatiCalcolo(x).sProvCO
                    'associo le tessere all'avviso
                    oMyAvviso.oTessere = oDatiCalcolo(x).oTessere
                End If
                'ciclo su tutte le unità immobiliari del contribuente
                For y = 0 To oDatiCalcolo(x).oUI.GetUpperBound(0)
                    'devo calcolare la parte fissa che sarebbe l'articolo di ruolo
                    If isPositionChanged(y, oDatiCalcolo(x).oUI(y), nDettaglioTestataPrec, sCategoriaPrec, tDataInizioPrec, tDataFinePrec, sTipoPartitaPrec) = False Then
                        'prelevo i dati dell'articolo sommando i metri
                        oArticoloRuolo = ValDatiArticolo(oDatiCalcolo(x).IdEnte, oDatiCalcolo(x).sAnnoRiferimento, oDatiCalcolo(x).IdContribuente, oDatiCalcolo(x).oUI(y), oDatiCalcolo(x).oUI(y).oRiduzioni, oDatiCalcolo(x).oUI(y).oDetassazioni, oArticoloRuolo)
                        IsCalcolato = 0
                    Else
                        If CalcoloPF(False, oArticoloRuolo, oListArticoli, nListArticoli, impTotaleAvviso) = False Then
                            Return Nothing
                        End If
                        'prelevo i dati dell'articolo sommando i metri
                        oArticoloRuolo = ValDatiArticolo(oDatiCalcolo(x).IdEnte, oDatiCalcolo(x).sAnnoRiferimento, oDatiCalcolo(x).IdContribuente, oDatiCalcolo(x).oUI(y), oDatiCalcolo(x).oUI(y).oRiduzioni, oDatiCalcolo(x).oUI(y).oDetassazioni, oArticoloRuolo)
                        IsCalcolato = 0
                    End If
                    nContribPrec = oDatiCalcolo(x).IdContribuente
                    nDettaglioTestataPrec = oDatiCalcolo(x).oUI(y).Id
                    sCategoriaPrec = oDatiCalcolo(x).oUI(y).IdCategoria
                    tDataInizioPrec = oDatiCalcolo(x).oUI(y).tDataInizio
                    tDataFinePrec = oDatiCalcolo(x).oUI(y).tDataFine
                    sTipoPartitaPrec = oDatiCalcolo(x).oUI(y).tipopartita
                Next
                'se non ho ancora calcolato gli importi li calcolo
                If IsCalcolato = 0 Then
                    'Log.Debug("TARSUVariabile::CalcolaAvvisi:: devo calcolare l'ultimo")
                    If CalcoloPF(False, oArticoloRuolo, oListArticoli, nListArticoli, impTotaleAvviso) = False Then
                        Return Nothing
                    End If
                    IsCalcolato = 1
                End If
                'devo calcolare la parte variabile che sarebbero gli scaglioni per i conferimenti delle tessere
                oMyAvviso.oScaglioni = CalcoloPVScaglioni()
                '*** 20140630 - SUPPLETIVO/CONGUAGLIO ***
                'in caso di conguaglio devo togliere il già fatturato che è dato da un rigo per ogni tipo partita con la somma dell'importo
                If Not (oDatiCalcolo(x).oArticoliPrec) Is Nothing Then
                    Dim bTrovato As Boolean = False
                    If Not oListArticoli Is Nothing Then
                        'se nell'avviso ho già articoli da già fatturato non li devo reinserire
                        For Each myArt As ObjArticolo In oListArticoli
                            If myArt.sVia = ObjArticolo.PARTEPRECEMESSO_DESCR Then
                                bTrovato = True
                            End If
                        Next
                        If bTrovato = False Then
                            nListArticoli = oListArticoli.GetUpperBound(0)
                            For Each oArticoloRuolo In oDatiCalcolo(x).oArticoliPrec
                                If oArticoloRuolo.IdContribuente > 0 Then
                                    'ridimensiono l'array degli avvisi calcolati
                                    nListArticoli += 1
                                    ReDim Preserve oListArticoli(nListArticoli)
                                    oListArticoli(nListArticoli) = oArticoloRuolo
                                    impTotaleAvviso += oArticoloRuolo.impNetto
                                End If
                            Next
                        End If
                    End If
                    oArticoloRuolo = Nothing
                    End If
                '*** ***
            Next
            If Not IsNothing(oMyAvviso) Then
                'aggiungo gli articoli all'avviso
                Log.Debug("TARSUVariabile::CalcolaAvvisi:: aggiungo l'ultimo")
                oMyAvviso.oArticoli = oListArticoli
                oMyAvviso.impTotale = impTotaleAvviso
                ''*** 20131024 - TARES ***
                oMyAvviso.impDovuto = impTotaleAvviso
                'If CalcoloPM(False, oDatiCalcolo(x).oMaggiorazione.otariffa, oDatiCalcolo(x).oMaggiorazione.oriduzioni, oListArticoli, nListArticoli) Then
                '    Return Nothing
                'End If
                ''*** ***
                'ridimensiono l'array degli avvisi calcolati
                nListAvvisi += 1
                ReDim Preserve oListAvvisi(nListAvvisi)
                oListAvvisi(nListAvvisi) = oMyAvviso
            End If
            Return oListAvvisi
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcolaAvvisi::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Public Function CalcolaAvvisiSuppletivo(ByVal oDatiCalcolo() As ObjAvviso, ByVal oDatiPrincipale() As ObjAvviso) As ObjAvviso()
        '*** FINIRE IMPLEMENTAZIONE ***
        'Dim x, y, nListAvvisi, nListArticoli, nContribPrec, nDettaglioTestataPrec, IsCalcolato As Integer
        'Dim sCategoriaPrec As String
        'Dim tDataInizioPrec, tDataFinePrec As Date
        'Dim oListAvvisi() As ObjAvviso
        'Dim oMyAvviso As ObjAvviso
        'Dim oArticoloRuolo As New ObjArticolo
        'Dim oListArticoli() As ObjArticolo
        'Dim FncAdd As New CalcoloCartellaSingola.CalcolaCartella
        'Dim oAnagConv As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAnagraficaCartellazione
        'Dim oArtConv() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRuoloPerCalcoloCartelle
        'Dim oDatiCartelleConv As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiCartellazione
        'Dim oAvvisoConv As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoCartella
        'Dim sMyErr As String
        'Dim impTotaleAvviso As Double

        'Try
        '    nListAvvisi = -1 : nListArticoli = -1
        '    'ciclo su tutti i dati in ingresso
        '    For x = 0 To oDatiCalcolo.GetUpperBound(0)
        '        'se cambia il contribuente
        '        If oDatiCalcolo(x).IdContribuente <> nContribPrec Then
        '            If Not IsNothing(oMyAvviso) Then
        '                'se non ho ancora calcolato gli importi li calcolo
        '                If IsCalcolato = 0 Then
        '                    If CalcoloPF(oDatiCalcolo(x - 1), oArticoloRuolo, oListArticoli, nListArticoli, impTotaleAvviso) = False Then
        '                        Return Nothing
        '                    End If
        '                    IsCalcolato = 1
        '                End If
        '                'confronto principale con suppletivo
        '                For z = 0 To oDatiPrincipale.GetUpperBound(0)
        '                    'il contribuente è lo stesso
        '                    If oDatiPrincipale(z).IdContribuente = nContribPrec Then
        '                        'ciclo sugli articoli calcolati
        '                        For x = 0 To oListArticoli.GetUpperBound(0)
        '                            IsTrovatoPrincipale = 0
        '                            'ciclo sugli articoli originali
        '                            For y = 0 To oDatiPrincipale(z).oArticoli.GetUpperBound(0)
        '                                'controllo se devo calcolare la parte fissa che sarebbe l'articolo di ruolo
        '                                If oDatiPrincipale(z).oArticoli(y).nDettaglioTestata = oListArticoli(x).nDettaglioTestata Then
        '                                    sCategoriaPrec = oListArticoli(x).sCategoria
        '                                    impnettoprec = oListArticoli(x).impNetto
        '                                    If isPositionChanged(y, oDatiPrincipale(z).oArticoli(y), "", sCategoriaPrec, "", "", impnettoprec) = False Then
        '                                        IsTrovatoPrincipale = 2
        '				    exit for y
        '                                    Else
        '                                        If CalcoloPF(oDatiPrincipale(z).oArticoli(y), oListArticoli(x), oListArticoliSup, impTotaleAvviso) = False Then
        '                                            Return Nothing
        '                                        End If
        '                                        IsTrovatoPrincipale = 1
        '                                    End If
        '                                End If
        '                            Next
        '                        Next
        '                        If IsTrovatoPrincipale = 0 Then
        '                            'creo l'articolo supplettivo
        '                            If CalcoloPF(oDatiPrincipale(z).oArticoli(y), Nothing, oListArticoliSup, impTotaleAvviso) = False Then
        '                                Return Nothing
        '                            End If
        '                        End If
        '                    End If
        '                Next
        '                'aggiungo gli articoli all'avviso
        '                oMyAvviso.oArticoli = oListArticoliSup
        '                oMyAvviso.impTotale = impTotaleAvviso
        '                'ridimensiono l'array degli avvisi calcolati
        '                nListAvvisi += 1
        '                ReDim Preserve oListAvvisi(nListAvvisi)
        '                oListAvvisi(nListAvvisi) = oMyAvviso
        '            End If
        '            'genero nuovo avviso
        '            oMyAvviso = New ObjAvviso
        '            nListArticoli = -1 : impTotaleAvviso = 0
        '            'valorizzo i dati dell'avviso
        '            oMyAvviso.IdContribuente = oDatiCalcolo(x).IdContribuente
        '            oMyAvviso.IdEnte = oDatiCalcolo(x).IdEnte
        '            oMyAvviso.sAnnoRiferimento = oDatiCalcolo(x).sAnnoRiferimento
        '            oMyAvviso.sCognome = oDatiCalcolo(x).sCognome
        '            oMyAvviso.sNome = oDatiCalcolo(x).sNome
        '            oMyAvviso.sCodFiscale = oDatiCalcolo(x).sCodFiscale
        '            oMyAvviso.sPIVA = oDatiCalcolo(x).sPIVA
        '            oMyAvviso.sIndirizzoRes = oDatiCalcolo(x).sIndirizzoRes
        '            oMyAvviso.sCivicoRes = oDatiCalcolo(x).sCivicoRes
        '            oMyAvviso.sFrazRes = oDatiCalcolo(x).sFrazRes
        '            oMyAvviso.sCAPRes = oDatiCalcolo(x).sCAPRes
        '            oMyAvviso.sComuneRes = oDatiCalcolo(x).sComuneRes
        '            oMyAvviso.sProvRes = oDatiCalcolo(x).sProvRes
        '            oMyAvviso.sNominativoCO = oDatiCalcolo(x).sNominativoCO
        '            oMyAvviso.sIndirizzoCO = oDatiCalcolo(x).sIndirizzoCO
        '            oMyAvviso.sCivicoCO = oDatiCalcolo(x).sCivicoCO
        '            oMyAvviso.sFrazCO = oDatiCalcolo(x).sFrazCO
        '            oMyAvviso.sCAPCO = oDatiCalcolo(x).sCAPCO
        '            oMyAvviso.sComuneCO = oDatiCalcolo(x).sComuneCO
        '            oMyAvviso.sProvCO = oDatiCalcolo(x).sProvCO
        '            'associo le tessere all'avviso
        '            oMyAvviso.oTessere = oDatiCalcolo(x).oTessere
        '        End If
        '        'ciclo su tutte le unità immobiliari del contribuente
        '        For y = 0 To oDatiCalcolo(x).oUI.GetUpperBound(0)
        '            'devo calcolare la parte fissa che sarebbe l'articolo di ruolo
        '            If isPositionChanged(y, oDatiCalcolo(x).oUI(y), nDettaglioTestataPrec, sCategoriaPrec, tDataInizioPrec, tDataFinePrec) = False Then
        '                'prelevo i dati dell'articolo sommando i metri
        '                oArticoloRuolo = ValDatiArticolo(oDatiCalcolo(x).IdEnte, oDatiCalcolo(x).sAnnoRiferimento, oDatiCalcolo(x).IdContribuente, oDatiCalcolo(x).oUI(y), oDatiCalcolo(x).oUI(y).oRiduzioni, oDatiCalcolo(x).oUI(y).oDetassazioni)
        '                IsCalcolato = 0
        '            Else
        '                Dim ociccio As ObjAvviso
        '                ociccio = oDatiCalcolo(x)
        '                If CalcoloPF(ociccio, oArticoloRuolo, oListArticoli, nListArticoli, impTotaleAvviso) = False Then
        '                    Return Nothing
        '                End If
        '                'prelevo i dati dell'articolo sommando i metri
        '                oArticoloRuolo = ValDatiArticolo(oDatiCalcolo(x).IdEnte, oDatiCalcolo(x).sAnnoRiferimento, oDatiCalcolo(x).IdContribuente, oDatiCalcolo(x).oUI(y), oDatiCalcolo(x).oUI(y).oRiduzioni, oDatiCalcolo(x).oUI(y).oDetassazioni)
        '                IsCalcolato = 0
        '            End If
        '            nContribPrec = oDatiCalcolo(x).IdContribuente
        '            nDettaglioTestataPrec = oDatiCalcolo(x).oUI(y).IdDettaglioTestata
        '            sCategoriaPrec = oDatiCalcolo(x).oUI(y).IdCategoria
        '            tDataInizioPrec = oDatiCalcolo(x).oUI(y).tDataInizio
        '            tDataFinePrec = oDatiCalcolo(x).oUI(y).tDataFine
        '        Next
        '        'devo calcolare la parte variabile che sarebbero gli scaglioni per i conferimenti delle tessere
        '        oMyAvviso.oScaglioni = CalcoloPV()
        '    Next
        '    If Not IsNothing(oMyAvviso) Then
        '        'se non ho ancora calcolato gli importi li calcolo
        '        If IsCalcolato = 0 Then
        '            If CalcoloPF(oDatiCalcolo(x - 1), oArticoloRuolo, oListArticoli, nListArticoli, impTotaleAvviso) = False Then
        '                Return Nothing
        '            End If
        '            IsCalcolato = 1
        '        End If
        '        'confronto principale con suppletivo
        '        For z = 0 To oDatiPrincipale.GetUpperBound(0)
        '            'il contribuente è lo stesso
        '            If oDatiPrincipale(z).IdContribuente = nContribPrec Then
        '                'ciclo sugli articoli calcolati
        '                For x = 0 To oListArticoli.GetUpperBound(0)
        '                    IsTrovatoPrincipale = 0
        '                    'ciclo sugli articoli originali
        '                    For y = 0 To oDatiPrincipale(z).oArticoli.GetUpperBound(0)
        '                        'controllo se devo calcolare la parte fissa che sarebbe l'articolo di ruolo
        '                        If oDatiPrincipale(z).oArticoli(y).nDettaglioTestata = oListArticoli(x).nDettaglioTestata Then
        '                            sCategoriaPrec = oListArticoli(x).sCategoria
        '                            impnettoprec = oListArticoli(x).impNetto
        '                            If isPositionChanged(y, oDatiPrincipale(z).oArticoli(y), "", sCategoriaPrec, "", "", impnettoprec) = False Then
        '                                IsTrovatoPrincipale = 2
        '				    exit for y
        '                            Else
        '                                If CalcoloPF(oDatiPrincipale(z).oArticoli(y), oListArticoli(x), oListArticoliSup, impTotaleAvviso) = False Then
        '                                    Return Nothing
        '                                End If
        '                                IsTrovatoPrincipale = 1
        '                            End If
        '                        End If
        '                    Next
        '                Next
        '                If IsTrovatoPrincipale = 0 Then
        '                    'creo l'articolo supplettivo
        '                    If CalcoloPF(oDatiPrincipale(z).oArticoli(y), Nothing, oListArticoliSup, impTotaleAvviso) = False Then
        '                        Return Nothing
        '                    End If
        '                End If
        '            End If
        '        Next
        '        'aggiungo gli articoli all'avviso
        '        oMyAvviso.oArticoli = oListArticoliSup
        '        oMyAvviso.impTotale = impTotaleAvviso
        '        'ridimensiono l'array degli avvisi calcolati
        '        nListAvvisi += 1
        '        ReDim Preserve oListAvvisi(nListAvvisi)
        '        oListAvvisi(nListAvvisi) = oMyAvviso
        '    End If
        '    Return oListAvvisi
        'Catch Err As Exception
        '    Log.Debug("Si è verificato un errore in TARSUVariabile::CalcolaAvvisiSuppletivo::" & Err.Message)
        '    Return Nothing
        'End Try
    End Function

    '*** 20120917 - sgravi ***
    'Public Function CalcoloPF(ByVal bIsRicalcolo As Boolean, ByRef oMyArticolo As ObjArticolo, ByRef oListArticoli() As ObjArticolo, ByRef nListArticoli As Integer, ByRef impTotaleAvviso As Double) As Boolean
    '    Dim oConvArt As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoArticoloRuolo
    '    Dim FncCalcolo As New Ruolo.ImportiRuolo.ClsImportiRuolo
    '    Dim TypePartita As String = oMyArticolo.TipoPartita

    '    Try
    '        'devo calcolare solo se i bimestri e  metri sono >0
    '        If oMyArticolo.nMQ > 0 And oMyArticolo.nBimestri > 0 Then
    '            'converto l'oggetto TARSU VARIABILE in oggetto TARSU in modo da riutilizzare la funzione già presente
    '            oConvArt = ConvArticolo(oMyArticolo)
    '            'calcolo i bimestri e gli importi
    '            If oMyArticolo.bIsImportoForzato = 0 Then
    '                If FncCalcolo.CalcolaImportiRuolo(oConvArt, ConvRid(oMyArticolo.oRiduzioni), ConvDet(oMyArticolo.oDetassazioni)) = False Then
    '                    Return False
    '                End If
    '            Else
    '                If FncCalcolo.CalcolaImportiRuolo(oConvArt, ConvRid(oMyArticolo.oRiduzioni), ConvDet(oMyArticolo.oDetassazioni), 2) = False Then
    '                    Return False
    '                End If
    '            End If
    '            'riconverto gli oggetti
    '            oMyArticolo = ConvArticolo(oConvArt, oMyArticolo)
    '            oMyArticolo.TipoPartita = TypePartita
    '            impTotaleAvviso += oMyArticolo.impNetto
    '            If bIsRicalcolo = False Then
    '                'aggiungo il nuovo articolo all'array
    '                nListArticoli += 1
    '                ReDim Preserve oListArticoli(nListArticoli)
    '                oListArticoli(nListArticoli) = oMyArticolo
    '            End If
    '        End If
    '        oMyArticolo = New ObjArticolo
    '        Return True
    '    Catch Err As Exception
    '        Log.Debug("Si è verificato un errore in TARSUVariabile::CalcoloPF::" & Err.Message)
    '        Return False
    '    End Try
    'End Function
    Public Function CalcoloPF(ByVal bIsRicalcolo As Boolean, ByRef oMyArticolo As ObjArticolo, ByRef oListArticoli() As ObjArticolo, ByRef nListArticoli As Integer, ByRef impTotaleAvviso As Double) As Boolean
        Dim oConvArt As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoArticoloRuolo
        Dim FncCalcolo As New Ruolo.ImportiRuolo.ClsImportiRuolo
        Dim TypePartita As String = oMyArticolo.TipoPartita

        Try
            'converto l'oggetto TARSU VARIABILE in oggetto TARSU in modo da riutilizzare la funzione già presente
            oConvArt = ConvArticolo(oMyArticolo)
                'calcolo i bimestri e gli importi
                If oMyArticolo.bIsImportoForzato = 0 Then
                    If FncCalcolo.CalcolaImportiRuolo(oConvArt, ConvRid(oMyArticolo.oRiduzioni), ConvDet(oMyArticolo.oDetassazioni)) = False Then
                        Return False
                    End If
                Else
                    If FncCalcolo.CalcolaImportiRuolo(oConvArt, ConvRid(oMyArticolo.oRiduzioni), ConvDet(oMyArticolo.oDetassazioni), 2) = False Then
                        Return False
                    End If
                End If
                'riconverto gli oggetti
                oMyArticolo = ConvArticolo(oConvArt, oMyArticolo)
                oMyArticolo.TipoPartita = TypePartita
                impTotaleAvviso += oMyArticolo.impNetto
                If bIsRicalcolo = False Then
                    'aggiungo il nuovo articolo all'array
                    nListArticoli += 1
                    ReDim Preserve oListArticoli(nListArticoli)
                    oListArticoli(nListArticoli) = oMyArticolo
                End If
            oMyArticolo = New ObjArticolo
            Return True
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcoloPF::" & Err.Message)
            Return False
        End Try
    End Function

    Private Function CalcoloPVScaglioni() As ObjScaglione()
        Dim oListScaglioni() As ObjScaglione = Nothing
        Try
            Return oListScaglioni
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcoloPV::" & Err.Message)
            Return Nothing
        End Try
    End Function

    ''*** 20131024 - TARES ***
    'Public Function CalcoloPM(ByVal bIsRicalcolo As Boolean, ByVal oMaggiorazione As ObjTariffa, ByVal oRiduzioni() As ObjRidEseApplicati, ByRef oListArticoli() As ObjArticolo, ByRef nListArticoli As Integer) As Boolean
    '    Dim oConvArt As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoArticoloRuolo
    '    Dim FncCalcolo As New Ruolo.ImportiRuolo.ClsImportiRuolo
    '    Dim nMQ As Double = 0
    '    Dim myArticolo As New ObjArticolo

    '    Try
    '        'devo sommare i metri di tutti gli articoli
    '        For Each myArticolo In oListArticoli
    '            If myArticolo.stipopartita = PARTEFISSA Then
    '                nMQ += myArticolo.nMQ
    '            End If
    '        Next
    '        myArticolo.bIsTarsuGiornaliera = True
    '        myArticolo.nBimestri = 365
    '        myArticolo.impTariffa = CDbl(oMaggiorazione.sValore)
    '        myArticolo.oRiduzioni = oRiduzioni

    '        If myArticolo.nMQ > 0 Then
    '            'converto l'oggetto TARSU VARIABILE in oggetto TARSU in modo da riutilizzare la funzione già presente
    '            oConvArt = ConvArticolo(myArticolo)
    '            'calcolo i bimestri e gli importi
    '            If myArticolo.bIsImportoForzato = 0 Then
    '                If FncCalcolo.CalcolaImportiRuolo(oConvArt, ConvRid(myArticolo.oRiduzioni), ConvDet(myArticolo.oDetassazioni)) = False Then
    '                    Return False
    '                End If
    '            Else
    '                If FncCalcolo.CalcolaImportiRuolo(oConvArt, ConvRid(myArticolo.oRiduzioni), ConvDet(myArticolo.oDetassazioni), 2) = False Then
    '                    Return False
    '                End If
    '            End If
    '            'riconverto gli oggetti
    '            myArticolo = ConvArticolo(oConvArt, myArticolo)
    '            '*** 20131024 - TARES ***
    '            myArticolo.stipopartita = PARTEMAGGIORAZIONE
    '            '*** ***
    '            If bIsRicalcolo = False Then
    '                'aggiungo il nuovo articolo all'array
    '                nListArticoli += 1
    '                ReDim Preserve oListArticoli(nListArticoli)
    '                oListArticoli(nListArticoli) = myArticolo
    '                myArticolo = New ObjArticolo
    '            End If
    '        End If
    '        Return True
    '    Catch Err As Exception
    '        Log.Debug("Si è verificato un errore in TARSUVariabile::CalcoloPM::" & Err.Message)
    '        Return False
    '    End Try
    'End Function
    ''*** ***

    Private Function isPositionChanged(ByVal iCount As Integer, ByVal oMyUI As ObjUnitaImmobiliare, ByVal IDDETTAGLIOTESTATA As Integer, ByVal IDCATEGORIA As String, ByVal DATAINIZIO As Date, ByVal DATAFINE As Date, ByVal TipoPartita As String) As Boolean
        'primo giro, sempre false
        If iCount = 0 Then
            Return False
        End If

        'se tipopartita<>PF è sempre isPositionChanged
        If oMyUI.TipoPartita <> ObjArticolo.PARTEFISSA Then
            Return True
        Else
            'se iddettaglio testata attuale è diverso da iddettaglio testata della posizione precedente
            If oMyUI.Id <> IDDETTAGLIOTESTATA Then
                Return True
            End If

            'se id categoria attuale è diverso da id categoriadella posizione precedente
            If oMyUI.IdCategoria.CompareTo(IDCATEGORIA) <> 0 Then
                Return True
            End If

            'se iDataInizio attuale è diverso da DataInizio della posizione precedente
            If oMyUI.tDataInizio.CompareTo(DATAINIZIO) <> 0 Then
                Return True
            End If

            'se DataFine attuale è diverso da DataFine della posizione precedente
            If oMyUI.tDataFine.CompareTo(DATAFINE) Then
                Return True
            End If
            If oMyUI.TipoPartita <> TipoPartita Then
                Return True
            End If
            Return False
        End If
    End Function

    Private Function ValDatiArticolo(ByVal sIdEnte As String, ByVal sAnno As String, ByVal nIdContribuente As Integer, ByVal oMyUI As ObjUnitaImmobiliare, ByVal oListRiduzioni() As ObjRidEseApplicati, ByVal oListDetrazioni() As ObjRidEseApplicati, ByVal oArticoloPrec As ObjArticolo) As ObjArticolo
        Dim FncCalcolo As New Ruolo.Ruolo.ClsElaboraRuolo
        Dim oMyArticolo As New ObjArticolo

        Try
            If Not oArticoloPrec Is Nothing Then
                oMyArticolo = oArticoloPrec
            End If
            oMyArticolo.Id = oMyUI.Id
            oMyArticolo.IdEnte = sIdEnte
            oMyArticolo.sAnno = sAnno
            oMyArticolo.TipoPartita = oMyUI.TipoPartita
            oMyArticolo.IdDettaglioTestata = oMyUI.IdDettaglioTestata
            oMyArticolo.IdContribuente = nIdContribuente
            oMyArticolo.sCategoria = oMyUI.IdCategoria
            oMyArticolo.sVia = oMyUI.sVia
            oMyArticolo.sCivico = oMyUI.sCivico
            oMyArticolo.sEsponente = oMyUI.sEsponente
            oMyArticolo.sInterno = oMyUI.sInterno
            oMyArticolo.sScala = oMyUI.sScala
            oMyArticolo.tDataFine = oMyUI.tDataFine
            oMyArticolo.tDataInizio = oMyUI.tDataInizio
            oMyArticolo.sFoglio = oMyUI.sFoglio
            oMyArticolo.sNumero = oMyUI.sNumero
            oMyArticolo.sSubalterno = oMyUI.sSubalterno
            oMyArticolo.bIsImportoForzato = oMyUI.bIsImportoForzato
            oMyArticolo.impRuolo = oMyUI.impruolo
            oMyArticolo.nIdTariffa = oMyUI.IdTariffa
            oMyArticolo.impTariffa = oMyUI.impTariffa
            oMyArticolo.nMQ += oMyUI.nMQ
            oMyArticolo.nIdTitoloOccupaz = oMyUI.nIdTitoloOccupaz
            oMyArticolo.nIdNaturaOccupaz = oMyUI.nIdNaturaOccupaz
            oMyArticolo.nIdDestUso = oMyUI.nIdDestUso
            oMyArticolo.nIdAssenzaDatiCatastali = oMyUI.nIdAssenzaDatiCatastali
            oMyArticolo.nComponenti = oMyUI.nNComponenti
            '*** 20140701 - IMU/TARES ***
            oMyArticolo.nComponentiPV = oMyUI.nComponentiPV
            oMyArticolo.bForzaPV = oMyUI.bForzaPV
            '*** ***
            'If oMyUI.TipoPartita = ObjArticolo.PARTEFISSA Then
            If oMyUI.sCatAteco = "" Then
                oMyArticolo.sDescrCategoria = oMyArticolo.sCategoria
            Else
                oMyArticolo.sDescrCategoria = oMyUI.sCatAteco
                If oMyArticolo.sDescrCategoria.IndexOf("DOM") >= 0 Then
                    oMyArticolo.sDescrCategoria += " " + oMyUI.nNComponenti.ToString() + " COMPONENTI"
                End If
            End If
            'End If
            oMyArticolo.nCodVia = CInt(oMyUI.sCodVia)
            If oMyUI.nGGTarsu > 0 Then
                oMyArticolo.nBimestri = oMyUI.nGGTarsu
                oMyArticolo.bIsTarsuGiornaliera = True
            Else
                oMyArticolo.nBimestri = FncCalcolo.GetBimestri(oMyUI.tDataInizio, oMyUI.tDataFine, CInt(sAnno))
                oMyArticolo.bIsTarsuGiornaliera = False
            End If
            If Not oListRiduzioni Is Nothing Then
                oMyArticolo.oRiduzioni = oListRiduzioni
            End If
            If Not oListDetrazioni Is Nothing Then
                oMyArticolo.oDetassazioni = oListDetrazioni
            End If
            '*** 20141211 - legami PF-PV ***
            oMyArticolo.idoggetto = oMyUI.Id
            oMyArticolo.listpfvspv = oMyUI.ListPFvsPV
            '*** ***

            'BD 09/07/2021
            oMyArticolo.ImportoFissoRid = oMyUI.ImportoFissoRid
            'BD 09/07/2021

            Return oMyArticolo
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in CreaRuolooMyArticolo.AUTOoMyArticolo.PRINCIPALE::ValDatiArticolo::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvArticolo(ByVal oMyArticolo As ObjArticolo) As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoArticoloRuolo
        Dim oMyReturn As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoArticoloRuolo

        Try
            oMyReturn.IsTarsuGiornaliera = oMyArticolo.bIsTarsuGiornaliera
            oMyReturn.MQ = oMyArticolo.nMQ
            oMyReturn.ImpTariffa = oMyArticolo.impTariffa
            oMyReturn.NumeroBimestri = oMyArticolo.nBimestri
            oMyReturn.ImportoRuolo = oMyArticolo.impRuolo
            oMyReturn.ImportoRiduzione = oMyArticolo.impRiduzione
            oMyReturn.ImportoDetassazione = oMyArticolo.impDetassazione
            oMyReturn.ImportoForzato = oMyArticolo.bIsImportoForzato
            oMyReturn.ImportoNetto = oMyArticolo.impNetto
            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvArticolo::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvArticolo(ByVal oArtRuolo As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoArticoloRuolo, ByVal oArticoloOrg As ObjArticolo) As ObjArticolo
        Dim oMyReturn As New ObjArticolo

        Try
            oMyReturn = oArticoloOrg
            oMyReturn.bIsTarsuGiornaliera = oArtRuolo.IsTarsuGiornaliera
            oMyReturn.nMQ = oArtRuolo.MQ
            oMyReturn.impTariffa = oArtRuolo.ImpTariffa
            oMyReturn.nBimestri = oArtRuolo.NumeroBimestri
            oMyReturn.impRuolo = oArtRuolo.ImportoRuolo
            oMyReturn.impRiduzione = oArtRuolo.ImportoRiduzione
            oMyReturn.impDetassazione = oArtRuolo.ImportoDetassazione
            oMyReturn.bIsImportoForzato = oArtRuolo.ImportoForzato
            oMyReturn.impNetto = oArtRuolo.ImportoNetto
            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvArticolo::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvArticolo(ByVal oListArticoli() As ObjArticolo) As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRuoloPerCalcoloCartelle()
        Dim oMyReturn() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRuoloPerCalcoloCartelle
        Dim x As Integer

        Try
            For x = 0 To oListArticoli.GetUpperBound(0)
                ReDim Preserve oMyReturn(x)
                oMyReturn(x).Anno = oListArticoli(x).sAnno
                oMyReturn(x).ImportoNetto += oListArticoli(x).impNetto
                oMyReturn(x).ImportoInteressi += 0
                oMyReturn(x).ImportoSanzioni += 0
                oMyReturn(x).ImportoSpese += 0
            Next
            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvArticolo::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvRid(ByVal oMyRid() As ObjRidEseApplicati) As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRiduzione()
        Dim oMyReturn() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRiduzione
        Dim x As Integer
        Try
            If Not oMyRid Is Nothing Then
                For x = 0 To oMyRid.GetUpperBound(0)
                    ReDim Preserve oMyReturn(x)
                    oMyReturn(x) = New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRiduzione
                    oMyReturn(x).IdRiduzione = oMyRid(x).IdRiferimento
                    oMyReturn(x).sTipoValoreRid = oMyRid(x).sTipoValore
                    oMyReturn(x).sValore = oMyRid(x).sValore
                Next
            End If
            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvRid::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvDet(ByVal oMyDet() As ObjRidEseApplicati) As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDetassazione()
        Dim oMyReturn() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDetassazione
        Dim x As Integer
        Try
            If Not oMyDet Is Nothing Then
                For x = 0 To oMyDet.GetUpperBound(0)
                    ReDim Preserve oMyReturn(x)
                    oMyReturn(x) = New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDetassazione
                    oMyReturn(x).IdDetassazione = oMyDet(x).IdRiferimento
                    oMyReturn(x).sTipoValoreDet = oMyDet(x).sTipoValore
                    oMyReturn(x).sValore = oMyDet(x).sValore
                Next
            End If
            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvDet::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvAnag(ByVal oMyAvviso As ObjAvviso) As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAnagraficaCartellazione
        Dim oMyReturn As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAnagraficaCartellazione
        Try
            oMyReturn.CodiceEnte = oMyAvviso.IdEnte
            oMyReturn.IdContribuente = oMyAvviso.IdContribuente
            oMyReturn.Cognome = oMyAvviso.sCognome
            oMyReturn.Nome = oMyAvviso.sNome
            oMyReturn.CodiceFiscale = oMyAvviso.sCodFiscale
            oMyReturn.PartitaIVA = oMyAvviso.sPIVA
            oMyReturn.IndirizzoRes = oMyAvviso.sIndirizzoRes
            oMyReturn.CivicoRes = oMyAvviso.sCivicoRes
            oMyReturn.CAPRes = oMyAvviso.sCAPRes
            oMyReturn.ComuneRes = oMyAvviso.sComuneRes
            oMyReturn.ProvRes = oMyAvviso.sProvRes
            oMyReturn.FrazRes = oMyAvviso.sFrazRes
            oMyReturn.NominativoCO = oMyAvviso.sNominativoCO
            oMyReturn.IndirizzoCO = oMyAvviso.sIndirizzoCO
            oMyReturn.CAPCO = oMyAvviso.sCAPCO
            oMyReturn.ComuneCO = oMyAvviso.sComuneCO
            oMyReturn.ProvCO = oMyAvviso.sProvCO
            oMyReturn.FrazCO = oMyAvviso.sFrazCO

            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvAnag::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvDatiCartelle(ByVal oMyAvviso As ObjAvviso) As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiCartellazione
        Dim oMyReturn As New RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiCartellazione
        Try
            oMyReturn.LottoCartellazione = oMyAvviso.nLottoCartellazione
            oMyReturn.AnnoRiferimento = oMyAvviso.sAnnoRiferimento
            oMyReturn.DataEmissione = oMyAvviso.tDataEmissione
            oMyReturn.CodiceCartella = oMyAvviso.sCodiceCartella
            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvDatiCartelle::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function ConvAvviso(ByVal oMyAvviso As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoCartella, ByVal oMyRate() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoRataCalcolata, ByVal oMyDettaglio() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDettaglioCartella) As ObjAvviso
        Dim oMyReturn As New ObjAvviso
        Dim oListRate() As ObjRata
        Dim oListDettaglio() As ObjDetVoci
        Dim x As Integer
        Try
            oMyReturn.sCodiceCartella = oMyAvviso.CodiceCartella
            oMyReturn.tDataEmissione = oMyAvviso.DataEmissione
            oMyReturn.IdEnte = oMyAvviso.CodiceEnte
            oMyReturn.IdContribuente = oMyAvviso.IdContribuente
            oMyReturn.sAnnoRiferimento = oMyAvviso.AnnoRiferimento
            oMyReturn.nLottoCartellazione = oMyAvviso.LottoCartellazione
            oMyReturn.sAnniPresenzaRuolo = ""
            oMyReturn.sCognome = oMyAvviso.Cognome
            oMyReturn.sNome = oMyAvviso.Nome
            oMyReturn.sCodFiscale = oMyAvviso.CodiceFiscale
            oMyReturn.sPIVA = oMyAvviso.PartitaIVA
            oMyReturn.sIndirizzoRes = oMyAvviso.IndirizzoRes
            oMyReturn.sCivicoRes = oMyAvviso.CivicoRes
            oMyReturn.sCAPRes = oMyAvviso.CAPRes
            oMyReturn.sComuneRes = oMyAvviso.ComuneRes
            oMyReturn.sProvRes = oMyAvviso.ProvRes
            oMyReturn.sFrazRes = oMyAvviso.FrazRes
            oMyReturn.sNominativoCO = oMyAvviso.NominativoCO
            oMyReturn.sIndirizzoCO = oMyAvviso.IndirizzoCO
            oMyReturn.sCAPCO = oMyAvviso.CAPCO
            oMyReturn.sComuneCO = oMyAvviso.ComuneCO
            oMyReturn.sProvCO = oMyAvviso.ProvCO
            oMyReturn.sFrazCO = oMyAvviso.FrazCO
            oMyReturn.impTotale = oMyAvviso.ImportoTotale
            oMyReturn.impArrotondamento = oMyAvviso.ImportoArrotondamento
            oMyReturn.impCarico = oMyAvviso.ImportoCarico

            If Not IsNothing(oMyRate) Then
                For x = 0 To oMyRate.GetUpperBound(0)
                    ReDim Preserve oListRate(x)
                    oListRate(x).sNRata = oMyRate(x).NumeroRata
                    oListRate(x).tDataScadenza = oMyRate(x).DataScadenza
                    oListRate(x).sCodBollettino = oMyRate(x).CodiceBollettino
                    oListRate(x).sCodeline = oMyRate(x).Codeline
                    oListRate(x).sDescrRata = oMyRate(x).DescrizioneRata
                    oListRate(x).impRata = oMyRate(x).ImportoRata
                    oListRate(x).sContoCorrente = oMyRate(x).NumeroCC
                    oListRate(x).sCodiceBarcode = oMyRate(x).CodiceBarcode
                Next
                oMyReturn.oRate = oListRate
            End If

            If Not IsNothing(oMyDettaglio) Then
                For x = 0 To oMyDettaglio.GetUpperBound(0)
                    ReDim Preserve oListDettaglio(x)
                    oListDettaglio(x).sCapitolo = oMyDettaglio(x).CodiceCapitolo
                    oListDettaglio(x).impDettaglio = oMyDettaglio(x).ImportoVoce
                Next
                oMyReturn.oDetVoci = oListDettaglio
            End If

            Return oMyReturn
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::ConvAvviso::" & Err.Message)
            Return Nothing
        End Try
    End Function
#End Region

#Region "Cartella Avvisi"
    Public Function CartellaAvvisi(ByVal oDatiCalcolo() As ObjAvviso, ByVal oAddizionali() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale, ByVal oRate() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiRata, ByVal oLotto As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.ObjLottoCartellazione) As ObjAvviso()
        Dim x, nProgressivoCartella As Integer

        Try
            'ciclo su tutti i dati in ingresso
            For x = 0 To oDatiCalcolo.GetUpperBound(0)
                If Not IsNothing(oLotto) Then
                    oDatiCalcolo(x).tDataEmissione = Date.Now
                    oDatiCalcolo(x).nLottoCartellazione = oLotto.NumeroLotto
                    nProgressivoCartella = x + oLotto.Primacartella
                    oDatiCalcolo(x).sCodiceCartella = CreaCodiceCartella("100", oDatiCalcolo(x).sAnnoRiferimento, nProgressivoCartella)
                    If oDatiCalcolo(x).sCodiceCartella = "" Then
                        Return Nothing
                    End If
                End If
                'calcolo le addizionali
                oDatiCalcolo(x).oDetVoci = CalcoloDetVoci(oAddizionali, oDatiCalcolo(x))
                'calcolo le rate
                oDatiCalcolo(x).oRate = CalcoloRate(oRate, oDatiCalcolo(x))
            Next

            Return oDatiCalcolo
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcolaAvvisi::" & Err.Message)
            Return Nothing
        End Try
    End Function

    '*** 20131104 - TARES ***
    Public Function CartellaAvvisi(ByVal oDatiCalcolo() As ObjAvviso, ByVal oAddizionali() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale, ByVal oLotto As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.ObjLottoCartellazione) As ObjAvviso()
        Dim x, nProgressivoCartella As Integer

        Try
            'ciclo su tutti i dati in ingresso
            For x = 0 To oDatiCalcolo.GetUpperBound(0)
                If Not IsNothing(oLotto) Then
                    oDatiCalcolo(x).tDataEmissione = Date.Now
                    oDatiCalcolo(x).nLottoCartellazione = oLotto.NumeroLotto
                    nProgressivoCartella = x + oLotto.Primacartella
                    oDatiCalcolo(x).sCodiceCartella = CreaCodiceCartella("100", oDatiCalcolo(x).sAnnoRiferimento, nProgressivoCartella)
                    If oDatiCalcolo(x).sCodiceCartella = "" Then
                        Return Nothing
                    End If
                End If
                'calcolo le addizionali
                oDatiCalcolo(x).oDetVoci = CalcoloDetVoci(oAddizionali, oDatiCalcolo(x))
            Next

            Return oDatiCalcolo
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcolaAvvisi::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Public Function RateAvvisi(ByVal oDatiCalcolo() As ObjAvviso, ByVal oRate() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiRata) As ObjAvviso()
        Dim x As Integer

        Try
            'ciclo su tutti i dati in ingresso
            For x = 0 To oDatiCalcolo.GetUpperBound(0)
                'calcolo le rate
                oDatiCalcolo(x).oRate = CalcoloRate(oRate, oDatiCalcolo(x))
            Next

            Return oDatiCalcolo
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::RateAvvisi::" & Err.Message)
            Return Nothing
        End Try
    End Function
    '*** ***

    Private Function CreaCodiceCartella(ByVal sConcessione As String, ByVal sAnno As String, ByVal nProgressivo As Integer) As String
        Try
            Dim n1, n2, n3, ncin As Long

            CreaCodiceCartella = sConcessione & sAnno & nProgressivo.ToString.PadLeft(8, "0")
            n1 = CLng(CreaCodiceCartella)
            n2 = Int(n1 / 93)
            n3 = n2 * 93
            ncin = n1 - n3

            CreaCodiceCartella += ncin.ToString.PadLeft(2, "0")
        Catch ex As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CreaCodiceCartella::" & ex.Message)
            Return ""
        End Try
    End Function

    Public Function CalcoloDetVoci(ByVal oAddizionali() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale, ByRef oMyAvviso As ObjAvviso) As ObjDetVoci()
        Log.Debug("entro calcolodetvoci")
        Dim oMyDetVoce As New ObjDetVoci
        Dim oListDetVoci() As ObjDetVoci
        Dim x, nList As Integer
        Dim impBaseCalcolo, impMaggiorazione, impAddizionale, impTotale, impArrotondamento As Double
        Dim FncGen As New Generale

        Try
            nList = -1
            If Not oMyAvviso.oArticoli Is Nothing Then
                'inserisco nel dettaglio la sommatoria di importo netto degli articoli
                For x = 0 To oMyAvviso.oArticoli.GetUpperBound(0)
                    '*** 20131104 - TARES ***
                    If oMyAvviso.oArticoli(x).TipoPartita <> ObjArticolo.PARTEMAGGIORAZIONE Then
                        impBaseCalcolo += FormatNumber(oMyAvviso.oArticoli(x).impNetto, 2)
                    Else
                        impMaggiorazione += FormatNumber(oMyAvviso.oArticoli(x).impNetto, 2)
                    End If
                Next
                impTotale += oMyAvviso.impTotale
            End If
            'If impBaseCalcolo > 0 Then
            oMyDetVoce = New ObjDetVoci
            oMyDetVoce.sAnno = oMyAvviso.sAnnoRiferimento
            oMyDetVoce.sCapitolo = ObjDetVoci.Capitolo.Imposta
            oMyDetVoce.IdAvviso = oMyAvviso.ID
            oMyDetVoce.impDettaglio = impBaseCalcolo

            nList += 1
            ReDim Preserve oListDetVoci(nList)
            oListDetVoci(nList) = oMyDetVoce

            'calcolo delle addizionali
            If Not oAddizionali Is Nothing Then
                For Each myItem As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale In oAddizionali
                    '**** 201809 - Cartelle Insoluti ***
                    If myItem.TipoCalcolo = RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale.Tipo.Importo Then
                        impAddizionale = myItem.Valore
                    Else
                        impAddizionale = FormatNumber((impBaseCalcolo * myItem.Valore / 100), 2)
                    End If
                    oMyDetVoce = New ObjDetVoci
                    oMyDetVoce.sAnno = oMyAvviso.sAnnoRiferimento
                    oMyDetVoce.sCapitolo = myItem.CodiceCapitolo
                    oMyDetVoce.IdAvviso = oMyAvviso.ID
                    oMyDetVoce.impDettaglio = impAddizionale
                    If impAddizionale <> 0 Then
                        nList += 1
                        ReDim Preserve oListDetVoci(nList)
                        oListDetVoci(nList) = oMyDetVoce
                    End If
                    impTotale += impAddizionale
                Next
            End If
            'End If
            '*** 20131104 - TARES ***
            If impMaggiorazione > 0 Then
                oMyDetVoce = New ObjDetVoci
                oMyDetVoce.sAnno = oMyAvviso.sAnnoRiferimento
                oMyDetVoce.sCapitolo = ObjDetVoci.Capitolo.Maggiorazione
                oMyDetVoce.IdAvviso = oMyAvviso.ID
                oMyDetVoce.impDettaglio = impMaggiorazione

                nList += 1
                ReDim Preserve oListDetVoci(nList)
                oListDetVoci(nList) = oMyDetVoce
            End If
            '*** ***
            'calcolo l'arrotondamento all'euro
            oMyAvviso.impCarico = FncGen.ImportoArrotondatoEuroIntero(impTotale, impArrotondamento)
            oMyAvviso.impDovuto = FormatNumber(oMyAvviso.impCarico - oMyAvviso.impPagato, 2)
            oMyAvviso.impTotale = impTotale
            oMyAvviso.impArrotondamento = impArrotondamento
            'inserisco la posizione dell'arrotondamento
            If impArrotondamento <> 0 Then
                oMyDetVoce = New ObjDetVoci
                oMyDetVoce.sAnno = oMyAvviso.sAnnoRiferimento
                oMyDetVoce.sCapitolo = ObjDetVoci.Capitolo.Arrotondamento
                oMyDetVoce.IdAvviso = oMyAvviso.ID
                oMyDetVoce.impDettaglio = impArrotondamento

                nList += 1
                ReDim Preserve oListDetVoci(nList)
                oListDetVoci(nList) = oMyDetVoce
            End If
            oMyAvviso.oDetVoci = oListDetVoci
            Return oListDetVoci
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcoloDetVoci::" & Err.Message)
            Return Nothing
        End Try
    End Function

    Private Function CalcoloRate(ByVal oRate() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiRata, ByVal oMyAvviso As ObjAvviso) As ObjRata()
        Dim oMyRata As New ObjRata
        Dim oListRate() As ObjRata
        Dim nRate, x, nList As Integer
        Dim FncGen As New Generale
        Dim FncBollettino As New CalcoloCartellaSingola.CalcolaCartella
        Dim impRataSingola, impUltimaRata As Double
        Dim bUltimaRata As Boolean = False

        Try
            nList = -1
            If oRate.GetUpperBound(0) = 0 Then
                nRate = 1
            Else
                nRate = oRate.GetUpperBound(0)
            End If
            'le rate devono essere calcolate sul dovuto
            impRataSingola = FncGen.ImportoArrotondatoEuroIntero((FncGen.ImportoArrotondato(oMyAvviso.impdovuto / nRate)), 0)
            'impRataSingola = FncGen.ImportoArrotondatoEuroIntero((FncGen.ImportoArrotondato(oMyAvviso.impCarico / nRate)), 0)
            impUltimaRata = oMyAvviso.impCarico - (impRataSingola * (nRate - 1))

            'popolo l'oggetto rate calcolate tranne l'unica soluzione
            For x = 0 To oRate.GetUpperBound(0)
                oMyRata = New ObjRata
                oMyRata.sNRata = oRate(x).NumeroRata
                oMyRata.IdAvviso = oMyAvviso.ID
                oMyRata.tDataScadenza = oRate(x).DataScadenza
                oMyRata.sDescrRata = oRate(x).DescrizioneRata
                oMyRata.sContoCorrente = oRate(x).NumeroContoCorrente
                If oRate(x).NumeroRata = "U" Then
                    oMyRata.impRata = oMyAvviso.impCarico
                    oMyRata.sCodBollettino = FncBollettino.CodiceBollettino(oMyAvviso.IdEnte, "00", oMyAvviso.sAnnoRiferimento, oMyAvviso.sCodiceCartella)
                Else
                    If (x = nRate Or x = nRate - 1) And bUltimaRata = False Then
                        oMyRata.impRata = impUltimaRata
                        bUltimaRata = True
                    Else
                        oMyRata.impRata = impRataSingola
                    End If
                    oMyRata.sCodBollettino = FncBollettino.CodiceBollettino(oMyAvviso.IdEnte, oMyRata.sNRata.PadLeft(2, "0"), oMyAvviso.sAnnoRiferimento, oMyAvviso.sCodiceCartella)
                End If
                oMyRata.sCodeline = FncBollettino.Codeline(oMyRata.sCodBollettino, oRate(x).NumeroContoCorrente, oMyRata.impRata)
                oMyRata.sCodiceBarcode = FncBollettino.GetDataForBarcode(oMyRata.sCodBollettino, CStr(oMyRata.impRata), oMyRata.sContoCorrente)

                nList += 1
                ReDim Preserve oListRate(nList)
                oListRate(nList) = oMyRata
            Next

            Return oListRate
        Catch Err As Exception
            Log.Debug("Si è verificato un errore in TARSUVariabile::CalcoloRata::" & Err.Message)
            Return Nothing
        End Try
    End Function
#End Region
End Class
