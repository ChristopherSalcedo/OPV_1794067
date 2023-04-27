Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cadena As String = InputBox("Ingrese cadena: ")
        For Each c As Char In cadena
            MsgBox(c)
        Next
    End Sub
End Class