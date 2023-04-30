Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numeros As String = TextBox2.Text
        Dim numerosseparados() As String = numeros.Split(",")
        Dim suma As Double = 0
        For Each numero As String In numerosseparados
            suma += Val(numero)
        Next
        MessageBox.Show("La suma de los numeros es " & suma)
    End Sub
End Class