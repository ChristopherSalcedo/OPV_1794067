Imports System.DirectoryServices
Imports System.Windows

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "1234" Then
            Me.Hide()
            Form2.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrecta")
        End If
    End Sub
End Class
