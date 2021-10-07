Public Class operaciones


    Public Function retornamayor(ByVal vala As Integer, ByVal valb As Integer)

        'compara si son diferentes
        If (vala > valb) Then

            Return vala
        ElseIf (valb > vala) Then

            Return valb

        End If

        If vala = valb Then
            MsgBox("los valores son iguales")
            Return ".i."
        End If

    End Function

    Public Function retornamenor(ByVal vala As Integer, ByVal valb As Integer)
        'compara si son diferentes
        If (vala > valb) Then
            Return valb
        ElseIf (valb > vala) Then

            Return vala

        End If

        If vala = valb Then
            MsgBox("los valores son iguales")
            Return ".i."


        End If
    End Function

    Public Function retornacifra(ByVal val As Integer)
        Return Math.Abs(val) Mod 10
    End Function

    Public Function pagarsalario(ByVal horas As Integer, ByVal cantidaddehoras As Integer)
        Dim extras, valorextras, valorhoras, valortotalxhoras As Integer
        If cantidaddehoras > 40 Then
            extras = cantidaddehoras - 40
            valorextras = extras * (horas * 1.25)
            valorhoras = 40 * horas
            valortotalxhoras = valorextras + valorhoras
        Else
            valortotalxhoras = horas * cantidaddehoras
        End If
        Return valortotalxhoras
    End Function

    Public Function determinarcarcambio(ByVal cambio As Integer)
        Dim bill, b50, b20, b10, b5, b2, b1, b500, b200, b100, b5c As Integer
        Dim array(10) As Integer

        b50 = Math.DivRem(cambio, 50000, bill)
        b20 = Math.DivRem(bill, 20000, bill)
        b10 = Math.DivRem(bill, 10000, bill)
        b5 = Math.DivRem(bill, 5000, bill)
        b2 = Math.DivRem(bill, 2000, bill)
        b1 = Math.DivRem(bill, 1000, bill)
        b500 = Math.DivRem(bill, 500, bill)
        b200 = Math.DivRem(bill, 200, bill)
        b100 = Math.DivRem(bill, 100, bill)
        b5c = Math.DivRem(bill, 50, bill)

        array(0) = b50
        array(1) = b20
        array(2) = b10
        array(3) = b5
        array(4) = b2
        array(5) = b1
        array(6) = b500
        array(7) = b200
        array(8) = b100
        array(9) = b5c


        Return array
    End Function

   

End Class
