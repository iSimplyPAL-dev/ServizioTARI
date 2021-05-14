Imports System
Imports System.Collections
Imports RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti

Namespace RemotingInterfaceMotoreTarsu

    Public Interface IRuoloTARSU

        Function CreaRuolo_AUTO_PRINCIPALE(ByVal ArrayDichiarazioniRidDet() As OggettoDichiarazioneTARSURidDet) As OggettoRuoloCreato
        Function CreaRuolo_AUTO_SUPPLETIVO(ByVal ArrayDichiarazioniRidDet() As OggettoDichiarazioneTARSURidDet, ByVal objRuoloPrincipaleCreato As OggettoRuoloCreato) As OggettoRuoloCreato
        Function GetBimestri(ByVal tStart As Date, ByVal tEnd As Date, ByVal nAnnoBimestri As Integer) As Integer
        Function CalcolaImportiRuolo(ByRef oMyArticolo As OggettoArticoloRuolo, ByVal oMyRiduzioni() As OggettoRiduzione, ByVal oMyDetassazioni() As OggettoDetassazione, Optional ByVal LevelCalcolo As Integer = 0) As Boolean
        Function GetCartellazioneMassiva(ByVal oArrayOggettoElaborazioneMassivaCartelle() As OggettoElaborazioneMassivaCartelle, ByVal oArrayRate() As OggettoDatiRata, ByVal oArrayAddizionali() As OggettoAddizionale) As OggettoOutputCartellazioneMassiva()
        Function GetCartellazione(ByVal objAnagrafica As OggettoAnagraficaCartellazione, ByVal arrayobjRuolo() As OggettoRuoloPerCalcoloCartelle, ByVal arrayDatiRate() As OggettoDatiRata, ByVal arrayobjAddizionali() As OggettoAddizionale, ByVal objDatiCartellazione As OggettoDatiCartellazione, ByRef objCartella As OggettoCartella, ByRef arrayobjRateCalcolate() As OggettoRataCalcolata, ByRef arrayobjDettaglioCartellaPerAnno() As OggettoDettaglioCartella, ByRef sErrRuolo As String) As Integer

    End Interface

    Public Interface IRuoloTARSUVariabile
        Function CalcolaAvvisi(ByVal oDatiCalcolo() As MotoreTarsuVARIABILE.Oggetti.ObjAvviso) As MotoreTarsuVARIABILE.Oggetti.ObjAvviso()
        '*** 20120917 - sgravi ***
        Function CartellaAvvisi(ByVal oDatiCalcolo() As MotoreTarsuVARIABILE.Oggetti.ObjAvviso, ByVal oListRate() As OggettoDatiRata, ByVal oListAddizionali() As OggettoAddizionale, ByVal oLotto As ObjLottoCartellazione) As MotoreTarsuVARIABILE.Oggetti.ObjAvviso()
        Function CalcoloPF(ByVal bIsRicalcolo As Boolean, ByRef oMyArticolo As MotoreTarsuVARIABILE.Oggetti.ObjArticolo, ByRef oListArticoli() As MotoreTarsuVARIABILE.Oggetti.ObjArticolo, ByRef nListArticoli As Integer, ByRef impTotaleAvviso As Double) As Boolean
        '*** ***
		'*** 20131104 - TARES ***
		Function CartellaAvvisi(ByVal oRuolo As MotoreTarsuVARIABILE.Oggetti.ObjRuolo, ByVal oLotto As ObjLottoCartellazione) As MotoreTarsuVARIABILE.Oggetti.ObjAvviso()
		Function CalcoloDetVoci(ByVal oAddizionali() As OggettoAddizionale, ByRef oMyAvviso As MotoreTarsuVARIABILE.Oggetti.ObjAvviso) As MotoreTarsuVARIABILE.Oggetti.ObjDetVoci()
		'*** ***
	End Interface
End Namespace