<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button17 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(17, 20)
        Button17.Margin = New Padding(4, 5, 4, 5)
        Button17.Name = "Button17"
        Button17.Size = New Size(49, 38)
        Button17.TabIndex = 18
        Button17.Text = "<-"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(538, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 44)
        Button1.TabIndex = 19
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(293, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 36)
        Label1.TabIndex = 20
        Label1.Text = "Primer Numero"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(265, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(219, 36)
        Label2.TabIndex = 21
        Label2.Text = "Segundo Numero"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(490, 128)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 42)
        TextBox1.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(490, 215)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 42)
        TextBox2.TabIndex = 23
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Button17)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button17 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
