Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = TextBox1.Text
        Label2.Text = ""
        For i = 2 To numero Step 2 'El incremento es 2 para ir de dos en dos'
            'Mostramos el número par en la ventana de salida'
            Label2.Text = Label2.Text & "   " & i
        Next i
    End Sub

End Class