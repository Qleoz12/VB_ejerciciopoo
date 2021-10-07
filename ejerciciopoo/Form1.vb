Public Class Form1
    Dim matematico As New operaciones


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim valor1, valor2 As Integer

        valor1 = numero1.Text
        valor2 = numero2.Text

        resultado.Text = matematico.retornamayor(valor1, valor2)
        resultadomenor.Text = matematico.retornamenor(valor1, valor2)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numero1.TextChanged

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valorcifra As Integer
        valorcifra = numero3.Text
        resultadodigito.Text = matematico.retornacifra(valorcifra)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valor1, valor2, valorsalario As Integer

        valor1 = horas.Text
        valor2 = valorxhora.Text
        valorsalario = matematico.pagarsalario(valor2, valor1)
        valorapagartrabajador.Text = valorsalario


    End Sub


    Private Sub numero2_TextChanged(sender As Object, e As EventArgs) Handles numero2.TextChanged
        Dim valor1, valor2 As Integer
        valor1 = numero1.TextLength
        valor2 = numero2.TextLength


        If valor1 > 0 And valor2 > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub numero3_TextChanged(sender As Object, e As EventArgs) Handles numero3.TextChanged
        Dim valorcifra As Integer
        valorcifra = numero3.TextLength

        If valorcifra > 0 Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub valorxhora_TextChanged(sender As Object, e As EventArgs) Handles valorxhora.TextChanged
        Dim valor1, valor2, valuevalor1 As Integer
        valor1 = horas.TextLength
        valuevalor1 = horas.Text
        valor2 = valorxhora.TextLength


        If valor1 > 0 And valor2 > 0 And valuevalor1 > 0 And valuevalor1 < 61 Then
            Button3.Enabled = True
        ElseIf valuevalor1 > 60 Then
            MsgBox("por favor digite valores entre 0 - 60 en el campo de Horas trabajadas")
            horas.Text = 0
            horas.Focus()
        ElseIf valuevalor1 < 0 Then
            MsgBox("por favor digite valores entre 0 - 60 en el campo de Horas trabajadas")
            horas.Text = 0
            horas.Focus()
        Else
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valorMoney As Integer
        valorMoney = Cantidaddinero.Text
        Dim arraynumerico(9) As Integer
        arraynumerico = matematico.determinarcarcambio(valorMoney)
        billeteone.Text = arraynumerico(0)
        billetetwo.Text = arraynumerico(1)
        billetethree.Text = arraynumerico(2)
        billetefour.Text = arraynumerico(3)
        billetefive.Text = arraynumerico(4)
        billetesix.Text = arraynumerico(5)
        billeteseven.Text = arraynumerico(6)
        billeteeight.Text = arraynumerico(7)
        billetenine.Text = arraynumerico(8)
        billeteten.Text = arraynumerico(9)


    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles billeteone.Click

    End Sub
End Class
