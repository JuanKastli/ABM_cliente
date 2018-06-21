<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.saldo = New System.Windows.Forms.TextBox
        Me.CategIva = New System.Windows.Forms.ComboBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Direccion = New System.Windows.Forms.Label
        Me.Dirección = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 110)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CategIva"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 230)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Saldo"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(160, 43)
        Me.id.Margin = New System.Windows.Forms.Padding(4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(132, 22)
        Me.id.TabIndex = 4
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(160, 100)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(132, 22)
        Me.Nombre.TabIndex = 5
        '
        'saldo
        '
        Me.saldo.Location = New System.Drawing.Point(160, 230)
        Me.saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.saldo.Name = "saldo"
        Me.saldo.Size = New System.Drawing.Size(132, 22)
        Me.saldo.TabIndex = 6
        '
        'CategIva
        '
        Me.CategIva.FormattingEnabled = True
        Me.CategIva.Items.AddRange(New Object() {"Responsable" & Global.Microsoft.VisualBasic.ChrW(9), "", "No Responsable", "" & Global.Microsoft.VisualBasic.ChrW(9), "Inscripto", "", "No Inscipto"})
        Me.CategIva.Location = New System.Drawing.Point(160, 166)
        Me.CategIva.Margin = New System.Windows.Forms.Padding(4)
        Me.CategIva.Name = "CategIva"
        Me.CategIva.Size = New System.Drawing.Size(160, 24)
        Me.CategIva.TabIndex = 7
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(46, 358)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 8
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(217, 358)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 9
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Direccion
        '
        Me.Direccion.AutoSize = True
        Me.Direccion.Location = New System.Drawing.Point(46, 285)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(67, 17)
        Me.Direccion.TabIndex = 10
        Me.Direccion.Text = "Direccion"
        '
        'Dirección
        '
        Me.Dirección.Location = New System.Drawing.Point(160, 275)
        Me.Dirección.Name = "Dirección"
        Me.Dirección.Size = New System.Drawing.Size(100, 22)
        Me.Dirección.TabIndex = 11
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 407)
        Me.Controls.Add(Me.Dirección)
        Me.Controls.Add(Me.Direccion)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.CategIva)
        Me.Controls.Add(Me.saldo)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents saldo As System.Windows.Forms.TextBox
    Friend WithEvents CategIva As System.Windows.Forms.ComboBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Direccion As System.Windows.Forms.Label
    Friend WithEvents Dirección As System.Windows.Forms.TextBox

End Class
