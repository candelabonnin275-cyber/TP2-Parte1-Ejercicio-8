Public Class Form1
    Dim Numero As Integer
    Dim Contador As Integer
    Dim Factorial As Integer

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Numero = txtIngreso.Text
        Contador = 0
        Factorial = 1
        Do While Contador < Numero
            Contador = Contador + 1
            Factorial = Factorial * Contador
        Loop
    End Sub
End Class
