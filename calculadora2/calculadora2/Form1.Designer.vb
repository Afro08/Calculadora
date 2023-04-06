<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits DevComponents.DotNetBar.RibbonForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.globotip = New DevComponents.DotNetBar.BalloonTip()
        Me.btnLimpiar = New DevComponents.DotNetBar.ButtonX()
        Me.btnIgual = New DevComponents.DotNetBar.ButtonX()
        Me.btnResta = New DevComponents.DotNetBar.ButtonX()
        Me.btnSuma = New DevComponents.DotNetBar.ButtonX()
        Me.btnDivi = New DevComponents.DotNetBar.ButtonX()
        Me.btnMulti = New DevComponents.DotNetBar.ButtonX()
        Me.btnCuadrado = New DevComponents.DotNetBar.ButtonX()
        Me.btnCubo = New DevComponents.DotNetBar.ButtonX()
        Me.btnRaiz = New DevComponents.DotNetBar.ButtonX()
        Me.btnCubico = New DevComponents.DotNetBar.ButtonX()
        Me.BindingNavigatorPositionItem = New DevComponents.DotNetBar.TextBoxItem()
        Me.pCalculadora = New DevComponents.DotNetBar.PanelEx()
        Me.panPantalla = New DevComponents.DotNetBar.PanelEx()
        Me.cbAyuda = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtPantalla = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnSiete = New DevComponents.DotNetBar.ButtonX()
        Me.btnOcho = New DevComponents.DotNetBar.ButtonX()
        Me.btnNueve = New DevComponents.DotNetBar.ButtonX()
        Me.btnCuatro = New DevComponents.DotNetBar.ButtonX()
        Me.btnCinco = New DevComponents.DotNetBar.ButtonX()
        Me.btnSeis = New DevComponents.DotNetBar.ButtonX()
        Me.btnUno = New DevComponents.DotNetBar.ButtonX()
        Me.btnDos = New DevComponents.DotNetBar.ButtonX()
        Me.btnTres = New DevComponents.DotNetBar.ButtonX()
        Me.btnCero = New DevComponents.DotNetBar.ButtonX()
        Me.btnComa = New DevComponents.DotNetBar.ButtonX()
        Me.pCalculadora.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnLimpiar, "Borrar")
        Me.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLimpiar.Location = New System.Drawing.Point(191, 143)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(31, 27)
        Me.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "C"
        '
        'btnIgual
        '
        Me.btnIgual.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnIgual, "Igual")
        Me.btnIgual.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnIgual.Location = New System.Drawing.Point(152, 247)
        Me.btnIgual.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(31, 27)
        Me.btnIgual.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnIgual.TabIndex = 3
        Me.btnIgual.Text = "="
        '
        'btnResta
        '
        Me.btnResta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnResta, "Resta")
        Me.btnResta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnResta.Location = New System.Drawing.Point(114, 280)
        Me.btnResta.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(31, 27)
        Me.btnResta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnResta.TabIndex = 5
        Me.btnResta.Text = "-"
        '
        'btnSuma
        '
        Me.btnSuma.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnSuma, "Suma")
        Me.btnSuma.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSuma.Location = New System.Drawing.Point(75, 280)
        Me.btnSuma.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(31, 27)
        Me.btnSuma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSuma.TabIndex = 6
        Me.btnSuma.Text = "+"
        '
        'btnDivi
        '
        Me.btnDivi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnDivi, "División")
        Me.btnDivi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDivi.Location = New System.Drawing.Point(191, 280)
        Me.btnDivi.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnDivi.Name = "btnDivi"
        Me.btnDivi.Size = New System.Drawing.Size(31, 27)
        Me.btnDivi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDivi.TabIndex = 7
        Me.btnDivi.Text = "/"
        '
        'btnMulti
        '
        Me.btnMulti.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnMulti, "Multiplicación")
        Me.btnMulti.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnMulti.Location = New System.Drawing.Point(152, 280)
        Me.btnMulti.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(31, 27)
        Me.btnMulti.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnMulti.TabIndex = 15
        Me.btnMulti.Text = "*"
        '
        'btnCuadrado
        '
        Me.btnCuadrado.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnCuadrado, "Eleva al cuadrado")
        Me.btnCuadrado.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCuadrado.Location = New System.Drawing.Point(191, 247)
        Me.btnCuadrado.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCuadrado.Name = "btnCuadrado"
        Me.btnCuadrado.Size = New System.Drawing.Size(31, 27)
        Me.btnCuadrado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCuadrado.TabIndex = 23
        Me.btnCuadrado.Text = "x2"
        '
        'btnCubo
        '
        Me.btnCubo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnCubo, "Eleva al cubo")
        Me.btnCubo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCubo.Location = New System.Drawing.Point(191, 212)
        Me.btnCubo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCubo.Name = "btnCubo"
        Me.btnCubo.Size = New System.Drawing.Size(31, 27)
        Me.btnCubo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCubo.TabIndex = 24
        Me.btnCubo.Text = "x3"
        '
        'btnRaiz
        '
        Me.btnRaiz.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnRaiz, "Raíz cuadrada")
        Me.btnRaiz.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnRaiz.Location = New System.Drawing.Point(229, 280)
        Me.btnRaiz.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(31, 27)
        Me.btnRaiz.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnRaiz.TabIndex = 25
        Me.btnRaiz.Text = "√"
        '
        'btnCubico
        '
        Me.btnCubico.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.globotip.SetBalloonText(Me.btnCubico, "Raíz cúbica")
        Me.btnCubico.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCubico.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCubico.Location = New System.Drawing.Point(229, 247)
        Me.btnCubico.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCubico.Name = "btnCubico"
        Me.btnCubico.Size = New System.Drawing.Size(31, 27)
        Me.btnCubico.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCubico.TabIndex = 26
        Me.btnCubico.Text = "∛"
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.BeginGroup = True
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxWidth = 54
        Me.BindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText
        '
        'pCalculadora
        '
        Me.pCalculadora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pCalculadora.AutoSize = True
        Me.pCalculadora.CanvasColor = System.Drawing.SystemColors.Control
        Me.pCalculadora.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pCalculadora.Controls.Add(Me.btnCubico)
        Me.pCalculadora.Controls.Add(Me.btnRaiz)
        Me.pCalculadora.Controls.Add(Me.btnCubo)
        Me.pCalculadora.Controls.Add(Me.btnCuadrado)
        Me.pCalculadora.Controls.Add(Me.panPantalla)
        Me.pCalculadora.Controls.Add(Me.cbAyuda)
        Me.pCalculadora.Controls.Add(Me.txtPantalla)
        Me.pCalculadora.Controls.Add(Me.btnSiete)
        Me.pCalculadora.Controls.Add(Me.btnMulti)
        Me.pCalculadora.Controls.Add(Me.btnOcho)
        Me.pCalculadora.Controls.Add(Me.btnNueve)
        Me.pCalculadora.Controls.Add(Me.btnCuatro)
        Me.pCalculadora.Controls.Add(Me.btnCinco)
        Me.pCalculadora.Controls.Add(Me.btnSeis)
        Me.pCalculadora.Controls.Add(Me.btnUno)
        Me.pCalculadora.Controls.Add(Me.btnDos)
        Me.pCalculadora.Controls.Add(Me.btnDivi)
        Me.pCalculadora.Controls.Add(Me.btnSuma)
        Me.pCalculadora.Controls.Add(Me.btnResta)
        Me.pCalculadora.Controls.Add(Me.btnTres)
        Me.pCalculadora.Controls.Add(Me.btnIgual)
        Me.pCalculadora.Controls.Add(Me.btnLimpiar)
        Me.pCalculadora.Controls.Add(Me.btnCero)
        Me.pCalculadora.Controls.Add(Me.btnComa)
        Me.pCalculadora.DisabledBackColor = System.Drawing.Color.Empty
        Me.pCalculadora.Location = New System.Drawing.Point(704, 229)
        Me.pCalculadora.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.pCalculadora.Name = "pCalculadora"
        Me.pCalculadora.Size = New System.Drawing.Size(313, 383)
        Me.pCalculadora.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pCalculadora.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pCalculadora.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pCalculadora.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pCalculadora.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pCalculadora.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pCalculadora.Style.GradientAngle = 90
        Me.pCalculadora.TabIndex = 0
        '
        'panPantalla
        '
        Me.panPantalla.CanvasColor = System.Drawing.SystemColors.Highlight
        Me.panPantalla.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPantalla.DisabledBackColor = System.Drawing.Color.Empty
        Me.panPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panPantalla.Location = New System.Drawing.Point(21, 47)
        Me.panPantalla.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.panPantalla.Name = "panPantalla"
        Me.panPantalla.Size = New System.Drawing.Size(275, 39)
        Me.panPantalla.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPantalla.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panPantalla.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panPantalla.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPantalla.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panPantalla.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPantalla.Style.GradientAngle = 90
        Me.panPantalla.TabIndex = 19
        '
        'cbAyuda
        '
        Me.cbAyuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.cbAyuda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbAyuda.Location = New System.Drawing.Point(3, 342)
        Me.cbAyuda.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbAyuda.Name = "cbAyuda"
        Me.cbAyuda.Size = New System.Drawing.Size(117, 25)
        Me.cbAyuda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbAyuda.TabIndex = 18
        Me.cbAyuda.Text = "Ayuda"
        '
        'txtPantalla
        '
        '
        '
        '
        Me.txtPantalla.Border.Class = "TextBoxBorder"
        Me.txtPantalla.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPantalla.Location = New System.Drawing.Point(21, 113)
        Me.txtPantalla.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPantalla.Name = "txtPantalla"
        Me.txtPantalla.PreventEnterBeep = True
        Me.txtPantalla.Size = New System.Drawing.Size(275, 21)
        Me.txtPantalla.TabIndex = 17
        '
        'btnSiete
        '
        Me.btnSiete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSiete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSiete.Location = New System.Drawing.Point(75, 143)
        Me.btnSiete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSiete.Name = "btnSiete"
        Me.btnSiete.Size = New System.Drawing.Size(31, 27)
        Me.btnSiete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSiete.TabIndex = 16
        Me.btnSiete.Text = "7"
        '
        'btnOcho
        '
        Me.btnOcho.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnOcho.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOcho.Location = New System.Drawing.Point(114, 143)
        Me.btnOcho.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnOcho.Name = "btnOcho"
        Me.btnOcho.Size = New System.Drawing.Size(31, 27)
        Me.btnOcho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnOcho.TabIndex = 14
        Me.btnOcho.Text = "8"
        '
        'btnNueve
        '
        Me.btnNueve.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNueve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNueve.Location = New System.Drawing.Point(152, 143)
        Me.btnNueve.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnNueve.Name = "btnNueve"
        Me.btnNueve.Size = New System.Drawing.Size(31, 27)
        Me.btnNueve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnNueve.TabIndex = 13
        Me.btnNueve.Text = "9"
        '
        'btnCuatro
        '
        Me.btnCuatro.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCuatro.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCuatro.Location = New System.Drawing.Point(75, 177)
        Me.btnCuatro.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCuatro.Name = "btnCuatro"
        Me.btnCuatro.Size = New System.Drawing.Size(31, 27)
        Me.btnCuatro.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCuatro.TabIndex = 12
        Me.btnCuatro.Text = "4"
        '
        'btnCinco
        '
        Me.btnCinco.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCinco.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCinco.Location = New System.Drawing.Point(114, 177)
        Me.btnCinco.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCinco.Name = "btnCinco"
        Me.btnCinco.Size = New System.Drawing.Size(31, 27)
        Me.btnCinco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCinco.TabIndex = 11
        Me.btnCinco.Text = "5"
        '
        'btnSeis
        '
        Me.btnSeis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSeis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSeis.Location = New System.Drawing.Point(152, 177)
        Me.btnSeis.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSeis.Name = "btnSeis"
        Me.btnSeis.Size = New System.Drawing.Size(31, 27)
        Me.btnSeis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSeis.TabIndex = 10
        Me.btnSeis.Text = "6"
        '
        'btnUno
        '
        Me.btnUno.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUno.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnUno.Location = New System.Drawing.Point(75, 212)
        Me.btnUno.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnUno.Name = "btnUno"
        Me.btnUno.Size = New System.Drawing.Size(31, 27)
        Me.btnUno.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnUno.TabIndex = 9
        Me.btnUno.Text = "1"
        '
        'btnDos
        '
        Me.btnDos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnDos.Location = New System.Drawing.Point(114, 212)
        Me.btnDos.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnDos.Name = "btnDos"
        Me.btnDos.Size = New System.Drawing.Size(31, 27)
        Me.btnDos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnDos.TabIndex = 8
        Me.btnDos.Text = "2"
        '
        'btnTres
        '
        Me.btnTres.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnTres.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnTres.Location = New System.Drawing.Point(152, 212)
        Me.btnTres.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnTres.Name = "btnTres"
        Me.btnTres.Size = New System.Drawing.Size(31, 27)
        Me.btnTres.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnTres.TabIndex = 4
        Me.btnTres.Text = "3"
        '
        'btnCero
        '
        Me.btnCero.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCero.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCero.Location = New System.Drawing.Point(114, 247)
        Me.btnCero.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnCero.Name = "btnCero"
        Me.btnCero.Size = New System.Drawing.Size(31, 27)
        Me.btnCero.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCero.TabIndex = 1
        Me.btnCero.Text = "0"
        '
        'btnComa
        '
        Me.btnComa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnComa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnComa.Location = New System.Drawing.Point(75, 247)
        Me.btnComa.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(31, 27)
        Me.btnComa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnComa.TabIndex = 0
        Me.btnComa.Text = ","
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 479)
        Me.Controls.Add(Me.pCalculadora)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.pCalculadora.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents globotip As DevComponents.DotNetBar.BalloonTip
    Friend WithEvents BindingNavigatorPositionItem As DevComponents.DotNetBar.TextBoxItem
    Friend WithEvents pCalculadora As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panPantalla As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cbAyuda As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents txtPantalla As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnSiete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMulti As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnOcho As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNueve As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCuatro As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCinco As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSeis As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnUno As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDos As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDivi As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSuma As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnResta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnTres As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnIgual As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLimpiar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCero As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnComa As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCubo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCuadrado As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCubico As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnRaiz As DevComponents.DotNetBar.ButtonX
End Class
