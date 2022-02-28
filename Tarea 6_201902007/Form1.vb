Public Class Form1
    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero + 1
        nuevotexto = numero.ToString()
        Return nuevotexto
    End Function
    Function Disminuir(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero - 1
        nuevotexto = numero.ToString()
        Return nuevotexto
    End Function
    Function Suma(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado
    End Function
    Function Resta(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado
    End Function
    Function Multiplicacion(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado
    End Function
    Function Division(numA As Integer, numB As Integer) As Double
        Dim resultado As Double
        resultado = numA / numB
        Return resultado
    End Function
    Private Sub btn_incrementar1_Click(sender As Object, e As EventArgs) Handles btn_incrementar1.Click
        lbl_contador1.Text = Aumentar(lbl_contador1.Text)
    End Sub

    Private Sub btn_desincrementar1_Click(sender As Object, e As EventArgs) Handles btn_desincrementar1.Click
        lbl_contador1.Text = Disminuir(lbl_contador1.Text)
    End Sub

    Private Sub btn_desincrementar2_Click(sender As Object, e As EventArgs) Handles btn_desincrementar2.Click
        lbl_contador2.Text = Disminuir(lbl_contador2.Text)
    End Sub

    Private Sub btn_incrementar2_Click(sender As Object, e As EventArgs) Handles btn_incrementar2.Click
        lbl_contador2.Text = Aumentar(lbl_contador2.Text)
    End Sub

    Private Sub btn_suma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        Dim txtA = lbl_contador1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbl_contador2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadosuma = Suma(numA, numB)
        lbl_resultado.Text = "El resultado de A + B = " + resultadosuma.ToString()
    End Sub

    Private Sub btn_resta_Click(sender As Object, e As EventArgs) Handles btn_resta.Click
        Dim txtA = lbl_contador1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbl_contador2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoresta = Resta(numA, numB)
        lbl_resultado.Text = "El resultado de A - B = " + resultadoresta.ToString()
    End Sub

    Private Sub btn_multiplicacion_Click(sender As Object, e As EventArgs) Handles btn_multiplicacion.Click
        Dim txtA = lbl_contador1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbl_contador2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadomulti = Multiplicacion(numA, numB)
        lbl_resultado.Text = "El resultado de A * B = " + resultadomulti.ToString()
    End Sub

    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        Dim txtA = lbl_contador1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = lbl_contador2.Text
        Dim numB = Int32.Parse(txtB)

        If (numB <> 0) Then
            Dim resultadodivision = Division(numA, numB)
            lbl_resultado.Text = "El resultado de A / B = " + resultadodivision.ToString()
        Else
            lbl_resultado.Text = "No puede ser 0 en el B"
        End If
    End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        lbl_resultado.Text = "El resultado es: _____________"
        lbl_contador1.Text = "0"
        lbl_contador2.Text = "0"
    End Sub
End Class
