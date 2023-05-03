Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        Dim numero As Integer = Val(TextBox1.Text)
        Dim i, j As Integer
        Dim esPrimo As Boolean
        For i = 2 To numero
            esPrimo = True

            'Comprobamos si es divisible por algún número menor que él mismo'
            For j = 2 To i - 1
                If i Mod j = 0 Then
                    esPrimo = False 'Si es divisible, no es primo'
                    Exit For 'Salimos del bucle interno'
                End If
            Next j

            'Si es primo, lo mostramos en la ventana de salida'
            If esPrimo Then
                Label2.Text = Label2.Text & " " & i
            End If
        Next i

    End Sub
End Class