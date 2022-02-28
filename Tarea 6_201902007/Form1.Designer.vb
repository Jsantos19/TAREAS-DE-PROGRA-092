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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_desincrementar1 = New System.Windows.Forms.Button()
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.lbl_contador1 = New System.Windows.Forms.Label()
        Me.btn_incrementar1 = New System.Windows.Forms.Button()
        Me.btn_desincrementar2 = New System.Windows.Forms.Button()
        Me.btn_incrementar2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_contador2 = New System.Windows.Forms.Label()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.btn_multiplicacion = New System.Windows.Forms.Button()
        Me.btn_division = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'btn_desincrementar1
        '
        Me.btn_desincrementar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_desincrementar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desincrementar1.Location = New System.Drawing.Point(103, 101)
        Me.btn_desincrementar1.Name = "btn_desincrementar1"
        Me.btn_desincrementar1.Size = New System.Drawing.Size(46, 51)
        Me.btn_desincrementar1.TabIndex = 1
        Me.btn_desincrementar1.Text = "-"
        Me.btn_desincrementar1.UseVisualStyleBackColor = True
        '
        'btn_suma
        '
        Me.btn_suma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suma.Location = New System.Drawing.Point(397, 86)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(182, 37)
        Me.btn_suma.TabIndex = 2
        Me.btn_suma.Text = "Suma"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'lbl_contador1
        '
        Me.lbl_contador1.AutoSize = True
        Me.lbl_contador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador1.Location = New System.Drawing.Point(192, 107)
        Me.lbl_contador1.Name = "lbl_contador1"
        Me.lbl_contador1.Size = New System.Drawing.Size(37, 39)
        Me.lbl_contador1.TabIndex = 3
        Me.lbl_contador1.Text = "0"
        '
        'btn_incrementar1
        '
        Me.btn_incrementar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_incrementar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_incrementar1.Location = New System.Drawing.Point(284, 101)
        Me.btn_incrementar1.Name = "btn_incrementar1"
        Me.btn_incrementar1.Size = New System.Drawing.Size(46, 51)
        Me.btn_incrementar1.TabIndex = 4
        Me.btn_incrementar1.Text = "+"
        Me.btn_incrementar1.UseVisualStyleBackColor = True
        '
        'btn_desincrementar2
        '
        Me.btn_desincrementar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_desincrementar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_desincrementar2.Location = New System.Drawing.Point(103, 257)
        Me.btn_desincrementar2.Name = "btn_desincrementar2"
        Me.btn_desincrementar2.Size = New System.Drawing.Size(46, 51)
        Me.btn_desincrementar2.TabIndex = 5
        Me.btn_desincrementar2.Text = "-"
        Me.btn_desincrementar2.UseVisualStyleBackColor = True
        '
        'btn_incrementar2
        '
        Me.btn_incrementar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_incrementar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_incrementar2.Location = New System.Drawing.Point(284, 257)
        Me.btn_incrementar2.Name = "btn_incrementar2"
        Me.btn_incrementar2.Size = New System.Drawing.Size(46, 51)
        Me.btn_incrementar2.TabIndex = 6
        Me.btn_incrementar2.Text = "+"
        Me.btn_incrementar2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 39)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "B"
        '
        'lbl_contador2
        '
        Me.lbl_contador2.AutoSize = True
        Me.lbl_contador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contador2.Location = New System.Drawing.Point(192, 263)
        Me.lbl_contador2.Name = "lbl_contador2"
        Me.lbl_contador2.Size = New System.Drawing.Size(37, 39)
        Me.lbl_contador2.TabIndex = 8
        Me.lbl_contador2.Text = "0"
        '
        'btn_resta
        '
        Me.btn_resta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_resta.Location = New System.Drawing.Point(397, 145)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(182, 37)
        Me.btn_resta.TabIndex = 9
        Me.btn_resta.Text = "Resta"
        Me.btn_resta.UseVisualStyleBackColor = True
        '
        'btn_multiplicacion
        '
        Me.btn_multiplicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_multiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiplicacion.Location = New System.Drawing.Point(397, 201)
        Me.btn_multiplicacion.Name = "btn_multiplicacion"
        Me.btn_multiplicacion.Size = New System.Drawing.Size(182, 37)
        Me.btn_multiplicacion.TabIndex = 10
        Me.btn_multiplicacion.Text = "Multiplicación"
        Me.btn_multiplicacion.UseVisualStyleBackColor = True
        '
        'btn_division
        '
        Me.btn_division.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_division.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_division.Location = New System.Drawing.Point(397, 259)
        Me.btn_division.Name = "btn_division"
        Me.btn_division.Size = New System.Drawing.Size(182, 37)
        Me.btn_division.TabIndex = 11
        Me.btn_division.Text = "División"
        Me.btn_division.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar.Location = New System.Drawing.Point(397, 319)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(182, 37)
        Me.btn_limpiar.TabIndex = 12
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 39)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "201902007"
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_resultado.Location = New System.Drawing.Point(12, 421)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(502, 39)
        Me.lbl_resultado.TabIndex = 15
        Me.lbl_resultado.Text = "El resultado es: ___________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(600, 491)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_division)
        Me.Controls.Add(Me.btn_multiplicacion)
        Me.Controls.Add(Me.btn_resta)
        Me.Controls.Add(Me.lbl_contador2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_incrementar2)
        Me.Controls.Add(Me.btn_desincrementar2)
        Me.Controls.Add(Me.btn_incrementar1)
        Me.Controls.Add(Me.lbl_contador1)
        Me.Controls.Add(Me.btn_suma)
        Me.Controls.Add(Me.btn_desincrementar1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_desincrementar1 As Button
    Friend WithEvents btn_suma As Button
    Friend WithEvents lbl_contador1 As Label
    Friend WithEvents btn_incrementar1 As Button
    Friend WithEvents btn_desincrementar2 As Button
    Friend WithEvents btn_incrementar2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_contador2 As Label
    Friend WithEvents btn_resta As Button
    Friend WithEvents btn_multiplicacion As Button
    Friend WithEvents btn_division As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_resultado As Label
End Class
