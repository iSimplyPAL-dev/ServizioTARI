''' <summary>
''' Classe per le funzioni generali di utilità
''' </summary>
Public Class Generale

    Public Function ImportoArrotondato(ByVal importo As Double) As String
        importo = (Int((importo * 100) + 0.5)) / 100
        ImportoArrotondato = CStr(importo)
    End Function

    Public Function ImportoArrotondatoEuroIntero(ByVal importo As String, ByRef ArrotondamentoEuro As Double) As String
        Dim nParteDecimale As Integer
        Dim nCifreDecimali As Integer
        Dim nParteIntera As Integer

        importo = importo.Replace(".", ",")

        If InStr(importo, ",") = 0 Then
            nCifreDecimali = 0
        Else
            nCifreDecimali = CInt(importo.Substring(InStr(importo, ","), importo.Length - InStr(importo, ",")).Length)
        End If

        If nCifreDecimali = 1 Then
            nParteDecimale = CInt(importo.Substring(InStr(importo, ","), 1)) * 10
            nParteIntera = CInt(importo.Substring(0, InStr(importo, ",") - 1))
        ElseIf nCifreDecimali = 0 Then
            nParteDecimale = 0
            nParteIntera = importo
        Else
            nParteDecimale = CInt(importo.Substring(InStr(importo, ","), 2))
            nParteIntera = CInt(importo.Substring(0, InStr(importo, ",") - 1))
        End If

        If nParteDecimale > 49 Then
            'ImportoArrotondatoEuroIntero = Int(CDbl(importo.Replace(",", "."))) + 1
            ImportoArrotondatoEuroIntero = nParteIntera + 1
            ArrotondamentoEuro = (100 - nParteDecimale) / 100
        ElseIf nParteDecimale = 0 Then
            'ImportoArrotondatoEuroIntero = importo.Replace(",", ".")
            ImportoArrotondatoEuroIntero = nParteIntera
            ArrotondamentoEuro = 0
        Else
            'ImportoArrotondatoEuroIntero = Int(CDbl(importo.Replace(",", ".")))
            ImportoArrotondatoEuroIntero = nParteIntera
            ArrotondamentoEuro = (-nParteDecimale) / 100
        End If
    End Function

End Class
