Namespace MotoreTarsu.Oggetti
    <Serializable()> _
    Public Class OggettoOutputCartellazioneMassiva
        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' La classe OggettoOutputCartellazioneMassiva contiene i dati completi della cartella con articoli di ruolo, rate calcolate e dettaglio.
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[monicatarello]	23/09/2008	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public oCartella As OggettoCartella
        Public oListRate() As OggettoRataCalcolata
        Public oListDettaglioCartella() As OggettoDettaglioCartella
        Public oListTessere() As MotoreTarsuVARIABILE.Oggetti.ObjTessera
        Public oListArticoli() As OggettoArticoloRuolo
    End Class
End Namespace

