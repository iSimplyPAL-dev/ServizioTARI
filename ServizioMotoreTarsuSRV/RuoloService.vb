Imports RemotingInterfaceMotoreTarsu
Imports RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti
Imports RemotingInterfaceMotoreTarsu.RemotingInterfaceMotoreTarsu
Imports log4net
Imports System.Threading

Imports Ruolo.Ruolo
Imports Ruolo.ImportiRuolo
Imports CreaCartella.CalcoloMassivo
Imports CreaCartella.CalcoloCartellaSingola

Namespace ServizioMotoreTarsuSRV
    ''' <summary>
    ''' Classe rende disponibili le interfacce di calcolo 
    ''' </summary>
    Public Class RuoloService
        Inherits MarshalByRefObject : Implements IRuoloTARSU : Implements IRuoloTARSUVariabile
        Private Shared ReadOnly log As ILog = LogManager.GetLogger(GetType(RuoloService))

        Public Sub New()
            log.Debug("Istanziata la classe Ruolo Service")
        End Sub

        Public Function CreaRuolo_AUTO_PRINCIPALE(ByVal ArrayDichiarazioniRidDet() As OggettoDichiarazioneTARSURidDet) As OggettoRuoloCreato Implements IRuoloTARSU.CreaRuolo_AUTO_PRINCIPALE
            Try
                log.Debug("Inizio RuoloService::CreaRuolo_AUTO_PRINCIPALE")
                log.Info("Inizio RuoloService::CreaRuolo_AUTO_PRINCIPALE")

                Dim oClsElaboraRuolo As New ClsElaboraRuolo

                Return oClsElaboraRuolo.CreaRuolo_AUTO_PRINCIPALE(ArrayDichiarazioniRidDet)
            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function CreaRuolo_AUTO_SUPPLETIVO(ByVal ArrayDichiarazioniRidDet() As OggettoDichiarazioneTARSURidDet, ByVal objRuoloPrincipaleCreato As OggettoRuoloCreato) As OggettoRuoloCreato Implements IRuoloTARSU.CreaRuolo_AUTO_SUPPLETIVO
            Try
                log.Debug("Inizio RuoloService::CreaRuolo_AUTO_SUPPLETIVO")
                log.Info("Inizio RuoloService::CreaRuolo_AUTO_SUPPLETIVO")

                Dim oClsElaboraRuolo As New ClsElaboraRuolo
                Return oClsElaboraRuolo.CreaRuolo_AUTO_SUPPLETIVO(ArrayDichiarazioniRidDet, objRuoloPrincipaleCreato)
            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function GetBimestri(ByVal tStart As Date, ByVal tEnd As Date, ByVal nAnnoBimestri As Integer) As Integer Implements IRuoloTARSU.GetBimestri
            Try
                log.Debug("Inizio RuoloService::GetBimestri")
                log.Info("Inizio RuoloService::GetBimestri")

                Dim oClsElaboraRuolo As New ClsElaboraRuolo

                Return oClsElaboraRuolo.GetBimestri(tStart, tEnd, nAnnoBimestri)
            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function CalcolaImportiRuolo(ByRef oMyArticolo As OggettoArticoloRuolo, ByVal oMyRiduzioni() As OggettoRiduzione, ByVal oMyDetassazioni() As OggettoDetassazione, Optional ByVal LevelCalcolo As Integer = 0) As Boolean Implements IRuoloTARSU.CalcolaImportiRuolo
            Try
                log.Debug("Inizio RuoloService::CalcolaImportiRuolo")
                log.Info("Inizio RuoloService::CalcolaImportiRuolo")

                Dim oClsElaboraRuolo As New ClsImportiRuolo

                Return oClsElaboraRuolo.CalcolaImportiRuolo(oMyArticolo, oMyRiduzioni, oMyDetassazioni, LevelCalcolo)
            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function GetCartellazioneMassiva(ByVal oArrayOggettoElaborazioneMassivaCartelle() As OggettoElaborazioneMassivaCartelle, ByVal oArrayRate() As OggettoDatiRata, ByVal oArrayAddizionali() As OggettoAddizionale) As OggettoOutputCartellazioneMassiva() Implements IRuoloTARSU.GetCartellazioneMassiva
            Try
                log.Debug("Inizio RuoloService::GetCartellazioneMassiva")
                log.Info("Inizio RuoloService::GetCartellazioneMassiva")

                Dim oClsCalcoloMassivoCartelle As New CalcoloMassivoCartelle

                Return oClsCalcoloMassivoCartelle.GetCartellazioneMassiva(oArrayOggettoElaborazioneMassivaCartelle, oArrayRate, oArrayAddizionali)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function


        Public Function GetCartellazione(ByVal objAnagrafica As OggettoAnagraficaCartellazione, ByVal arrayobjRuolo() As OggettoRuoloPerCalcoloCartelle, ByVal arrayDatiRate() As OggettoDatiRata, ByVal arrayobjAddizionali() As OggettoAddizionale, ByVal objDatiCartellazione As OggettoDatiCartellazione, ByRef objCartella As OggettoCartella, ByRef arrayobjRateCalcolate() As OggettoRataCalcolata, ByRef arrayobjDettaglioCartellaPerAnno() As OggettoDettaglioCartella, ByRef sErrRuolo As String) As Integer Implements IRuoloTARSU.GetCartellazione
            Try
                log.Debug("Inizio RuoloService::GetCartellazione")
                log.Info("Inizio RuoloService::GetCartellazione")

                Dim oClsCalcoloCartellaSingola As New CalcolaCartella

                Return oClsCalcoloCartellaSingola.GetCartellazione(objAnagrafica, arrayobjRuolo, arrayDatiRate, arrayobjAddizionali, objDatiCartellazione, objCartella, arrayobjRateCalcolate, arrayobjDettaglioCartellaPerAnno, sErrRuolo)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function CalcolaAvvisi(ByVal oDatiCalcolo() As MotoreTarsuVARIABILE.Oggetti.ObjAvviso) As MotoreTarsuVARIABILE.Oggetti.ObjAvviso() Implements IRuoloTARSUVariabile.CalcolaAvvisi
            Try
                log.Debug("Inizio RuoloTIAService::CalcolaAvvisi")
                log.Info("Inizio RuoloTIAService::CalcolaAvvisi")

                Dim FncCalcolo As New CreaCartella.TARSUVariabile

                Return FncCalcolo.CalcolaAvvisi(oDatiCalcolo)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function CartellaAvvisi(ByVal oDatiCalcolo() As MotoreTarsuVARIABILE.Oggetti.ObjAvviso, ByVal oListRate() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoDatiRata, ByVal oListAddizionali() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale, ByVal oLottoCartelle As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.ObjLottoCartellazione) As MotoreTarsuVARIABILE.Oggetti.ObjAvviso() Implements IRuoloTARSUVariabile.CartellaAvvisi
            Try
                log.Debug("Inizio RuoloTIAService::CalcolaAvvisi")
                log.Info("Inizio RuoloTIAService::CalcolaAvvisi")

                Dim FncCalcolo As New CreaCartella.TARSUVariabile

                Return FncCalcolo.CartellaAvvisi(oDatiCalcolo, oListAddizionali, oListRate, oLottoCartelle)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        '*** 20131104 - TARES ***
        Public Function CartellaAvvisi(ByVal oRuolo As MotoreTarsuVARIABILE.Oggetti.ObjRuolo, ByVal oLottoCartelle As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.ObjLottoCartellazione) As MotoreTarsuVARIABILE.Oggetti.ObjAvviso() Implements IRuoloTARSUVariabile.CartellaAvvisi
            Try
                log.Debug("Inizio RuoloTIAService::CalcolaAvvisi")
                log.Info("Inizio RuoloTIAService::CalcolaAvvisi")

                Dim FncCalcolo As New CreaCartella.TARSUVariabile

                Return FncCalcolo.CartellaAvvisi(oRuolo.oAvvisi, oRuolo.oAddizionali, oLottoCartelle)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function

        Public Function CalcoloDetVoci(ByVal oAddizionali() As RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti.OggettoAddizionale, ByRef oMyAvviso As RemotingInterfaceMotoreTarsu.MotoreTarsuVARIABILE.Oggetti.ObjAvviso) As RemotingInterfaceMotoreTarsu.MotoreTarsuVARIABILE.Oggetti.ObjDetVoci() Implements IRuoloTARSUVariabile.CalcoloDetVoci
            Try
                log.Debug("Inizio RuoloTIAService::CalcoloDetVoci")
                log.Info("Inizio RuoloTIAService::CalcoloDetVoci")

                Dim FncCalcolo As New CreaCartella.TARSUVariabile

                Return FncCalcolo.CalcoloDetVoci(oAddizionali, oMyAvviso)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function
        '*** ***

        '*** 20120917 - sgravi ***
        Public Function CalcoloPF(ByVal bIsRicalcolo As Boolean, ByRef oMyArticolo As RemotingInterfaceMotoreTarsu.MotoreTarsuVARIABILE.Oggetti.ObjArticolo, ByRef oListArticoli() As RemotingInterfaceMotoreTarsu.MotoreTarsuVARIABILE.Oggetti.ObjArticolo, ByRef nListArticoli As Integer, ByRef impTotaleAvviso As Double) As Boolean Implements RemotingInterfaceMotoreTarsu.RemotingInterfaceMotoreTarsu.IRuoloTARSUVariabile.CalcoloPF
            Try
                log.Debug("Inizio RuoloTIAService::CalcoloPF")
                log.Info("Inizio RuoloTIAService::CalcoloPF")

                Dim FncCalcolo As New CreaCartella.TARSUVariabile

                Return FncCalcolo.CalcoloPF(bIsRicalcolo, oMyArticolo, oListArticoli, nListArticoli, impTotaleAvviso)

            Catch ex As Exception
                Throw New Exception(ex.Message & "::" & ex.StackTrace)
            End Try
        End Function
        '*** ***
    End Class
End Namespace
