Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ""
        Dim i As Integer = 10

        While i > 0
            Label2.Text = Label2.Text + "  " + CStr(i)
            i -= 1
        End While
    End Sub
End Class