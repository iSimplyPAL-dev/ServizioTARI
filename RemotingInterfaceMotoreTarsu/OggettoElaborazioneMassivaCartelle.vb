Namespace MotoreTarsu.Oggetti
    <Serializable()> _
    Public Class OggettoElaborazioneMassivaCartelle
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoElaborazioneMassivaCartelle contiene i dati dell'anagrafica, degli articoli a ruolo e gli idenficativi della cartella da generare.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public oOggettoAnagraficaCartellazione As OggettoAnagraficaCartellazione
        Public oOggettoRuoloPerCalcoloCartelle() As OggettoRuoloPerCalcoloCartelle
        Public oOggettoDatiCartellazione As OggettoDatiCartellazione
    End Class
End Namespace