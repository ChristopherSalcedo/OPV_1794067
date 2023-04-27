<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        TextBox2 = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
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
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(471, 222)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 42)
        TextBox2.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(313, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(601, 36)
        Label2.TabIndex = 25
        Label2.Text = "Ingrese una lista de numeros separados por comas:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(521, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 44)
        Button1.TabIndex = 24
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Button17)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form9"
        Text = "Form9"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button17 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
