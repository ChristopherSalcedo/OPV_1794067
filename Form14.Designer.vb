﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button17
        ' 
        Button17.Location = New Point(12, 12)
        Button17.Name = "Button17"
        Button17.Size = New Size(34, 23)
        Button17.TabIndex = 18
        Button17.Text = "<-"
        Button17.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(76, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(649, 166)
        Label2.TabIndex = 26
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(350, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(112, 31)
        TextBox1.TabIndex = 25
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(361, 156)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 29)
        Button1.TabIndex = 24
        Button1.Text = "Generar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(341, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 23
        Label1.Text = "Numeros Pares"' 
        ' Form14
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Button17)
        Name = "Form14"
        Text = "Form14"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button17 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
