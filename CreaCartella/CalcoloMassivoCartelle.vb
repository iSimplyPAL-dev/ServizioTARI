Imports RemotingInterfaceMotoreTarsu
Imports RemotingInterfaceMotoreTarsu.MotoreTarsu.Oggetti

Namespace CalcoloMassivo

    ''' -----------------------------------------------------------------------------
    ''' Project	 : CreaCartella
    ''' Class	 : CalcoloMassivo
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' La classe CalcoloMassivoCartelle determina tutte le cartelle di pagamento per un determinato blocco di articoli.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[monicatarello]	23/09/2008	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Class CalcoloMassivoCartelle
        Public Sub New()
        End Sub

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La funzione determina, ciclando sull'array in ingresso, le singole cartelle di pagamento richiamando la funzione <c>GetCartellazione</c>.
        ''' </summary>
        ''' <param name="oArrayOggettoElaborazioneMassivaCartelle">Array di oggetti di tipo OggettoElaborazioneMassivaCartelle contiene i contribuenti e gli articoli per i quali calcolare la cartella.</param>
        ''' <param name="oArrayRate">Array di oggetti di tipo OggettoDatiRata contiene i dati generali delle rate da calcolare.</param>
        ''' <param name="oArrayAddizionali">Array di oggetti di tipo OggettoAddizionale contiene i dati generali delle addizionali da calcolare.</param>
        ''' <returns>Array di oggetti di tipo OggettoOutputCartellazioneMassiva</returns>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Function GetCartellazioneMassiva(ByVal oArrayOggettoElaborazioneMassivaCartelle() As OggettoElaborazioneMassivaCartelle, ByVal oArrayRate() As OggettoDatiRata, ByVal oArrayAddizionali() As OggettoAddizionale) As OggettoOutputCartellazioneMassiva()
            Dim iCount As Integer
            Dim oCalcolaCartella As New CreaCartella.CalcoloCartellaSingola.CalcolaCartella
            Dim oCartella As OggettoCartella
            Dim oArrayRateCalcolate() As OggettoRataCalcolata
            Dim oArrayOggettoDettaglioCartella() As OggettoDettaglioCartella
            Dim sErrRuolo As String
            Dim nResult As Integer
            Dim oListAvvisi As OggettoOutputCartellazioneMassiva
            Dim oArrayOutput As New ArrayList

            For iCount = 0 To oArrayOggettoElaborazioneMassivaCartelle.Length - 1
                If oCalcolaCartella.GetCartellazione(oArrayOggettoElaborazioneMassivaCartelle(iCount).oOggettoAnagraficaCartellazione, oArrayOggettoElaborazioneMassivaCartelle(iCount).oOggettoRuoloPerCalcoloCartelle, oArrayRate, oArrayAddizionali, oArrayOggettoElaborazioneMassivaCartelle(iCount).oOggettoDatiCartellazione, oCartella, oArrayRateCalcolate, oArrayOggettoDettaglioCartella, sErrRuolo) = 0 Then
                Else
                    oListAvvisi = New OggettoOutputCartellazioneMassiva
                    oListAvvisi.oCartella = oCartella
                    oListAvvisi.oListDettaglioCartella = oArrayOggettoDettaglioCartella
                    oListAvvisi.oListRate = oArrayRateCalcolate
                    oArrayOutput.Add(oListAvvisi)
                End If
            Next

            Return CType(oArrayOutput.ToArray(GetType(OggettoOutputCartellazioneMassiva)), OggettoOutputCartellazioneMassiva())
        End Function
    End Class
End Namespace
