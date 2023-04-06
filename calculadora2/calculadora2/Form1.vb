Imports System.Text.RegularExpressions
Public Class Form1

    Dim factorUno As Double
    Dim factorDos As Double
    Dim resultado As Double
    Dim operacion As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPantalla.Select()
        globotip.Enabled = False
        pCalculadora.Location = New Point((ClientSize.Width - pCalculadora.Width) \ 2,
                             (ClientSize.Height - pCalculadora.Height) \ 2)

    End Sub
#Region "Validaciónes"
    Private Sub txtPantalla_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPantalla.KeyPress
        Try
            e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,]").IsMatch(e.KeyChar)
        Catch ex As Exception

        End Try

    End Sub
#End Region
#Region "Procedimientos"
    Public Sub Suma()
        Try
            operacion = "suma"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = $"{factorUno} + "
            txtPantalla.Text = ""
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Resta()
        Try
            operacion = "resta"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = factorUno & " - "
            txtPantalla.Text = ("")
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Multi()
        Try
            operacion = "multi"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = factorUno & " * "
            txtPantalla.Text = ("")
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Divi()
        Try
            operacion = "divi"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = factorUno & " / "
            txtPantalla.Text = ("")
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Cuadrado()
        Try
            operacion = "cuadrado"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = factorUno & " ^ "
            resultado = factorUno ^ 2
            panPantalla.Text = panPantalla.Text & "2" & " = " & resultado.ToString
            txtPantalla.Text = ("")
            operacion = ""
            txtPantalla.Text = ("")
            txtPantalla.Select()
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
            txtPantalla.Select()
        End Try
    End Sub

    Public Sub Cubo()
        Try
            operacion = "cubo"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = factorUno & " ^ "
            resultado = factorUno ^ 3
            panPantalla.Text = panPantalla.Text & "3" & " = " & resultado.ToString
            txtPantalla.Text = ("")
            operacion = ""
            txtPantalla.Text = ("")
            txtPantalla.Select()
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Raiz()
        Try
            operacion = "raiz"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = " √ " & factorUno
            resultado = factorUno ^ (1.0 / 2.0)
            panPantalla.Text = panPantalla.Text & " = " & resultado.ToString
            txtPantalla.Text = ("")
            operacion = ""
            txtPantalla.Text = ("")
            txtPantalla.Select()
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Cubica()
        Try
            operacion = "cubica"
            factorUno = Double.Parse(txtPantalla.Text)
            panPantalla.Text = " ∛ " & factorUno
            resultado = factorUno ^ (1.0 / 3.0)
            panPantalla.Text = panPantalla.Text & " = " & resultado.ToString
            txtPantalla.Text = ("")
            operacion = ""
            txtPantalla.Text = ("")
            txtPantalla.Select()
        Catch ex As Exception
            If txtPantalla.Text = ("") Then
                MessageBox.Show("Favor ingresar un numero.")
            Else
                MessageBox.Show("Favor ingresar un numero valido")
            End If
            panPantalla.Text = ("")
            txtPantalla.Text = ("")
        End Try
    End Sub

    Public Sub Igual()
        Try
            factorDos = Double.Parse(txtPantalla.Text)
            If operacion = "suma" Then
                resultado = factorUno + factorDos
                panPantalla.Text = panPantalla.Text & factorDos.ToString & " = " & resultado.ToString
                txtPantalla.Text = ("")
                operacion = ""
            ElseIf operacion = "resta" Then
                resultado = factorUno - factorDos
                panPantalla.Text = panPantalla.Text & factorDos.ToString & " = " & resultado.ToString
                txtPantalla.Text = ("")
                operacion = ""
            ElseIf operacion = "multi" Then
                resultado = factorUno * factorDos
                panPantalla.Text = panPantalla.Text & factorDos.ToString & " = " & resultado.ToString
                txtPantalla.Text = ("")
                operacion = ""
            ElseIf operacion = "divi" Then
                resultado = factorUno / factorDos
                panPantalla.Text = panPantalla.Text & factorDos.ToString & " = " & resultado.ToString
                txtPantalla.Text = ("")
                operacion = ""
            ElseIf operacion = "cuadrado" Then
                resultado = factorUno ^ 2
                panPantalla.Text = panPantalla.Text & factorDos.ToString & " = " & resultado.ToString
                txtPantalla.Text = ("")
                operacion = ""
            ElseIf operacion = "cubo" Then
                resultado = factorUno ^ 3
                panPantalla.Text = panPantalla.Text & factorDos.ToString & " = " & resultado.ToString
                txtPantalla.Text = ("")
                operacion = ""
            ElseIf operacion = "" Then
                MessageBox.Show("Seleccione una operación aritmética")
            End If
            factorUno = 0
            factorDos = 0

        Catch ex As Exception
            MessageBox.Show("Favor ingresar un numero valido")
            txtPantalla.Clear()
        End Try
    End Sub
    Public Sub Limpiar()
        panPantalla.Text = ("")
        txtPantalla.Text = ("")
        factorUno = 0
        factorDos = 0
    End Sub
#End Region
#Region "Eventos"
    Private Sub btnUno_Click(sender As Object, e As EventArgs) Handles btnUno.Click
        Dim numUno As String
        numUno = "1"
        txtPantalla.Text = txtPantalla.Text & numUno
    End Sub

    Private Sub btnDos_Click(sender As Object, e As EventArgs) Handles btnDos.Click
        Dim numDos As String
        numDos = "2"
        txtPantalla.Text = txtPantalla.Text & numDos
    End Sub

    Private Sub btnTres_Click(sender As Object, e As EventArgs) Handles btnTres.Click
        Dim numTres As String
        numTres = "3"
        txtPantalla.Text = txtPantalla.Text & numTres
    End Sub

    Private Sub btnCuatro_Click(sender As Object, e As EventArgs) Handles btnCuatro.Click
        Dim numCuatro As String
        numCuatro = "4"
        txtPantalla.Text = txtPantalla.Text & numCuatro
    End Sub

    Private Sub btnCinco_Click(sender As Object, e As EventArgs) Handles btnCinco.Click
        Dim numCinco As String
        numCinco = "5"
        txtPantalla.Text = txtPantalla.Text & numCinco
    End Sub

    Private Sub btnSeis_Click(sender As Object, e As EventArgs) Handles btnSeis.Click
        Dim numSeis As String
        numSeis = "6"
        txtPantalla.Text = txtPantalla.Text & numSeis
    End Sub

    Private Sub btnSiete_Click(sender As Object, e As EventArgs) Handles btnSiete.Click
        Dim numSiete As String
        numSiete = "7"
        txtPantalla.Text = txtPantalla.Text & numSiete
    End Sub

    Private Sub btnOcho_Click(sender As Object, e As EventArgs) Handles btnOcho.Click
        Dim numOcho As String
        numOcho = "8"
        txtPantalla.Text = txtPantalla.Text & numOcho
    End Sub

    Private Sub btnNueve_Click(sender As Object, e As EventArgs) Handles btnNueve.Click
        Dim numNueve As String
        numNueve = "9"
        txtPantalla.Text = txtPantalla.Text & numNueve
    End Sub
    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        Dim numCero As String
        numCero = "0"
        txtPantalla.Text = txtPantalla.Text & numCero
    End Sub
    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        Dim coma As String
        coma = ","
        txtPantalla.Text = txtPantalla.Text & coma
    End Sub
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Suma()
    End Sub
    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Resta()
    End Sub
    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Multi()
    End Sub
    Private Sub btnDivi_Click(sender As Object, e As EventArgs) Handles btnDivi.Click
        Divi()
    End Sub
    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        igual()
    End Sub
    Private Sub btnCuadrado_Click(sender As Object, e As EventArgs) Handles btnCuadrado.Click
        Cuadrado()
    End Sub

    Private Sub btnCubo_Click(sender As Object, e As EventArgs) Handles btnCubo.Click
        Cubo()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        Raiz()
    End Sub

    Private Sub btnCubico_Click(sender As Object, e As EventArgs) Handles btnCubico.Click
        Cubica()
    End Sub

    Private Sub txtPantalla_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPantalla.KeyDown
        If e.KeyCode = Keys.Add Then
            Suma()
        ElseIf e.KeyCode = Keys.Subtract Then
            Resta()
        ElseIf e.KeyCode = Keys.Multiply Then
            Multi()
        ElseIf e.KeyCode = Keys.Divide Then
            Divi()
        ElseIf e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            Limpiar()
        ElseIf e.KeyCode = Keys.Enter Then
            Igual()
        End If
    End Sub

    Private Sub cbAyuda_CheckedChanged(sender As Object, e As EventArgs) Handles cbAyuda.CheckedChanged
        If cbAyuda.Checked Then
            globotip.Enabled = True
        Else
            globotip.Enabled = False
        End If
    End Sub
    Private Sub PanelEx1_Click(sender As Object, e As EventArgs) Handles pCalculadora.Click
        txtPantalla.Select()
    End Sub

#End Region

End Class
