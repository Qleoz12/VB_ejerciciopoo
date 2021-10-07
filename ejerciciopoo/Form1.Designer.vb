<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.resultadomenor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.resultadodigito = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numero3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.horas = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.valorxhora = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.valorapagartrabajador = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cantidaddinero = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.billeteone = New System.Windows.Forms.Label()
        Me.billetetwo = New System.Windows.Forms.Label()
        Me.billetethree = New System.Windows.Forms.Label()
        Me.billetefour = New System.Windows.Forms.Label()
        Me.billetefive = New System.Windows.Forms.Label()
        Me.billetesix = New System.Windows.Forms.Label()
        Me.billeteseven = New System.Windows.Forms.Label()
        Me.billeteeight = New System.Windows.Forms.Label()
        Me.billetenine = New System.Windows.Forms.Label()
        Me.billeteten = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(505, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "comparar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "numero 1"
        '
        'numero1
        '
        Me.numero1.Location = New System.Drawing.Point(135, 27)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(100, 20)
        Me.numero1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "numero2"
        '
        'numero2
        '
        Me.numero2.Location = New System.Drawing.Point(135, 74)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(100, 20)
        Me.numero2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "numero mayor"
        '
        'resultado
        '
        Me.resultado.Enabled = False
        Me.resultado.Location = New System.Drawing.Point(364, 27)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(100, 20)
        Me.resultado.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "numero menor"
        '
        'resultadomenor
        '
        Me.resultadomenor.Enabled = False
        Me.resultadomenor.Location = New System.Drawing.Point(364, 70)
        Me.resultadomenor.Name = "resultadomenor"
        Me.resultadomenor.Size = New System.Drawing.Size(100, 20)
        Me.resultadomenor.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ultimo digito"
        '
        'resultadodigito
        '
        Me.resultadodigito.Enabled = False
        Me.resultadodigito.Location = New System.Drawing.Point(364, 156)
        Me.resultadodigito.Name = "resultadodigito"
        Me.resultadodigito.Size = New System.Drawing.Size(100, 20)
        Me.resultadodigito.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ingrese una cifra"
        '
        'numero3
        '
        Me.numero3.Location = New System.Drawing.Point(135, 160)
        Me.numero3.Name = "numero3"
        Me.numero3.Size = New System.Drawing.Size(100, 20)
        Me.numero3.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Horas trabajadas"
        '
        'horas
        '
        Me.horas.Location = New System.Drawing.Point(135, 268)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(100, 20)
        Me.horas.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Valor por hora"
        '
        'valorxhora
        '
        Me.valorxhora.Location = New System.Drawing.Point(135, 305)
        Me.valorxhora.Name = "valorxhora"
        Me.valorxhora.Size = New System.Drawing.Size(100, 20)
        Me.valorxhora.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(276, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Valor a pagar"
        '
        'valorapagartrabajador
        '
        Me.valorapagartrabajador.Enabled = False
        Me.valorapagartrabajador.Location = New System.Drawing.Point(364, 282)
        Me.valorapagartrabajador.Name = "valorapagartrabajador"
        Me.valorapagartrabajador.Size = New System.Drawing.Size(100, 20)
        Me.valorapagartrabajador.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(505, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "digito?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(505, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 23)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "pagar a empleado ? "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 431)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Dinero"
        '
        'Cantidaddinero
        '
        Me.Cantidaddinero.Location = New System.Drawing.Point(135, 424)
        Me.Cantidaddinero.Name = "Cantidaddinero"
        Me.Cantidaddinero.Size = New System.Drawing.Size(100, 20)
        Me.Cantidaddinero.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(276, 383)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "50.000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(276, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "20.000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(276, 427)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "10.000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(276, 450)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "5.000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(276, 474)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "2.000"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(376, 383)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "1000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(376, 405)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "500"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(376, 427)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(25, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "200"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(376, 450)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "100"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(376, 474)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "50"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(505, 450)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "cambio colombiano ? "
        Me.Button4.UseVisualStyleBackColor = True
        '
        'billeteone
        '
        Me.billeteone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billeteone.Location = New System.Drawing.Point(322, 383)
        Me.billeteone.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billeteone.Name = "billeteone"
        Me.billeteone.Size = New System.Drawing.Size(38, 13)
        Me.billeteone.TabIndex = 34
        '
        'billetetwo
        '
        Me.billetetwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billetetwo.Location = New System.Drawing.Point(322, 404)
        Me.billetetwo.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billetetwo.Name = "billetetwo"
        Me.billetetwo.Size = New System.Drawing.Size(38, 13)
        Me.billetetwo.TabIndex = 35
        '
        'billetethree
        '
        Me.billetethree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billetethree.Location = New System.Drawing.Point(322, 426)
        Me.billetethree.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billetethree.Name = "billetethree"
        Me.billetethree.Size = New System.Drawing.Size(38, 13)
        Me.billetethree.TabIndex = 36
        '
        'billetefour
        '
        Me.billetefour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billetefour.Location = New System.Drawing.Point(322, 449)
        Me.billetefour.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billetefour.Name = "billetefour"
        Me.billetefour.Size = New System.Drawing.Size(38, 13)
        Me.billetefour.TabIndex = 37
        '
        'billetefive
        '
        Me.billetefive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billetefive.Location = New System.Drawing.Point(322, 474)
        Me.billetefive.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billetefive.Name = "billetefive"
        Me.billetefive.Size = New System.Drawing.Size(38, 13)
        Me.billetefive.TabIndex = 38
        '
        'billetesix
        '
        Me.billetesix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billetesix.Location = New System.Drawing.Point(413, 383)
        Me.billetesix.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billetesix.Name = "billetesix"
        Me.billetesix.Size = New System.Drawing.Size(38, 13)
        Me.billetesix.TabIndex = 39
        '
        'billeteseven
        '
        Me.billeteseven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billeteseven.Location = New System.Drawing.Point(413, 405)
        Me.billeteseven.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billeteseven.Name = "billeteseven"
        Me.billeteseven.Size = New System.Drawing.Size(38, 13)
        Me.billeteseven.TabIndex = 40
        '
        'billeteeight
        '
        Me.billeteeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billeteeight.Location = New System.Drawing.Point(413, 426)
        Me.billeteeight.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billeteeight.Name = "billeteeight"
        Me.billeteeight.Size = New System.Drawing.Size(38, 13)
        Me.billeteeight.TabIndex = 41
        '
        'billetenine
        '
        Me.billetenine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billetenine.Location = New System.Drawing.Point(413, 449)
        Me.billetenine.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billetenine.Name = "billetenine"
        Me.billetenine.Size = New System.Drawing.Size(38, 13)
        Me.billetenine.TabIndex = 42
        '
        'billeteten
        '
        Me.billeteten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billeteten.Location = New System.Drawing.Point(413, 473)
        Me.billeteten.MinimumSize = New System.Drawing.Size(10, 10)
        Me.billeteten.Name = "billeteten"
        Me.billeteten.Size = New System.Drawing.Size(38, 13)
        Me.billeteten.TabIndex = 43
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 535)
        Me.Controls.Add(Me.billeteten)
        Me.Controls.Add(Me.billetenine)
        Me.Controls.Add(Me.billeteeight)
        Me.Controls.Add(Me.billeteseven)
        Me.Controls.Add(Me.billetesix)
        Me.Controls.Add(Me.billetefive)
        Me.Controls.Add(Me.billetefour)
        Me.Controls.Add(Me.billetethree)
        Me.Controls.Add(Me.billetetwo)
        Me.Controls.Add(Me.billeteone)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cantidaddinero)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.valorapagartrabajador)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.valorxhora)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.numero3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.resultadodigito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.resultadomenor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numero1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numero2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents resultado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents resultadomenor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents resultadodigito As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numero3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents horas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents valorxhora As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents valorapagartrabajador As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cantidaddinero As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents billeteone As System.Windows.Forms.Label
    Friend WithEvents billetetwo As System.Windows.Forms.Label
    Friend WithEvents billetethree As System.Windows.Forms.Label
    Friend WithEvents billetefour As System.Windows.Forms.Label
    Friend WithEvents billetefive As System.Windows.Forms.Label
    Friend WithEvents billetesix As System.Windows.Forms.Label
    Friend WithEvents billeteseven As System.Windows.Forms.Label
    Friend WithEvents billeteeight As System.Windows.Forms.Label
    Friend WithEvents billetenine As System.Windows.Forms.Label
    Friend WithEvents billeteten As System.Windows.Forms.Label

End Class
