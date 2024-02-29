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
        Me.labelEmpleado = New System.Windows.Forms.Label()
        Me.labelid = New System.Windows.Forms.Label()
        Me.textBoxID = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.textBoxNombre = New System.Windows.Forms.TextBox()
        Me.textBoxApellido = New System.Windows.Forms.TextBox()
        Me.labelApellido = New System.Windows.Forms.Label()
        Me.textBoxEdad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxCargo = New System.Windows.Forms.TextBox()
        Me.labelCargo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.textBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelEmpleado
        '
        Me.labelEmpleado.AutoSize = True
        Me.labelEmpleado.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEmpleado.Location = New System.Drawing.Point(236, 9)
        Me.labelEmpleado.Name = "labelEmpleado"
        Me.labelEmpleado.Size = New System.Drawing.Size(208, 16)
        Me.labelEmpleado.TabIndex = 0
        Me.labelEmpleado.Text = "Ingresa el empleado:"
        '
        'labelid
        '
        Me.labelid.AutoSize = True
        Me.labelid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.labelid.Location = New System.Drawing.Point(170, 35)
        Me.labelid.Name = "labelid"
        Me.labelid.Size = New System.Drawing.Size(106, 20)
        Me.labelid.TabIndex = 1
        Me.labelid.Text = "Id Empleado:"
        '
        'textBoxID
        '
        Me.textBoxID.Location = New System.Drawing.Point(279, 39)
        Me.textBoxID.Name = "textBoxID"
        Me.textBoxID.Size = New System.Drawing.Size(189, 20)
        Me.textBoxID.TabIndex = 2
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.labelNombre.Location = New System.Drawing.Point(183, 80)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(73, 20)
        Me.labelNombre.TabIndex = 3
        Me.labelNombre.Text = "Nombre:"
        '
        'textBoxNombre
        '
        Me.textBoxNombre.Location = New System.Drawing.Point(274, 85)
        Me.textBoxNombre.Name = "textBoxNombre"
        Me.textBoxNombre.Size = New System.Drawing.Size(189, 20)
        Me.textBoxNombre.TabIndex = 4
        '
        'textBoxApellido
        '
        Me.textBoxApellido.Location = New System.Drawing.Point(265, 138)
        Me.textBoxApellido.Name = "textBoxApellido"
        Me.textBoxApellido.Size = New System.Drawing.Size(189, 20)
        Me.textBoxApellido.TabIndex = 6
        '
        'labelApellido
        '
        Me.labelApellido.AutoSize = True
        Me.labelApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.labelApellido.Location = New System.Drawing.Point(183, 134)
        Me.labelApellido.Name = "labelApellido"
        Me.labelApellido.Size = New System.Drawing.Size(73, 20)
        Me.labelApellido.TabIndex = 5
        Me.labelApellido.Text = "Apellido:"
        '
        'textBoxEdad
        '
        Me.textBoxEdad.Location = New System.Drawing.Point(272, 188)
        Me.textBoxEdad.Name = "textBoxEdad"
        Me.textBoxEdad.Size = New System.Drawing.Size(189, 20)
        Me.textBoxEdad.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(199, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Edad"
        '
        'textBoxCargo
        '
        Me.textBoxCargo.Location = New System.Drawing.Point(272, 237)
        Me.textBoxCargo.Name = "textBoxCargo"
        Me.textBoxCargo.Size = New System.Drawing.Size(189, 20)
        Me.textBoxCargo.TabIndex = 10
        '
        'labelCargo
        '
        Me.labelCargo.AutoSize = True
        Me.labelCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.labelCargo.Location = New System.Drawing.Point(192, 235)
        Me.labelCargo.Name = "labelCargo"
        Me.labelCargo.Size = New System.Drawing.Size(59, 20)
        Me.labelCargo.TabIndex = 9
        Me.labelCargo.Text = "Cargo:"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 368)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 21)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "X"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 12)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(72, 21)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar ventana"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(510, 39)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 28)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'textBoxTelefono
        '
        Me.textBoxTelefono.Location = New System.Drawing.Point(274, 284)
        Me.textBoxTelefono.Name = "textBoxTelefono"
        Me.textBoxTelefono.Size = New System.Drawing.Size(189, 20)
        Me.textBoxTelefono.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(188, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Telefono"
        '
        'textBoxDireccion
        '
        Me.textBoxDireccion.Location = New System.Drawing.Point(281, 335)
        Me.textBoxDireccion.Name = "textBoxDireccion"
        Me.textBoxDireccion.Size = New System.Drawing.Size(189, 20)
        Me.textBoxDireccion.TabIndex = 17
        Me.textBoxDireccion.Text = "e"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(186, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Direccion"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(510, 95)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(87, 28)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 401)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.textBoxDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textBoxTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.textBoxCargo)
        Me.Controls.Add(Me.labelCargo)
        Me.Controls.Add(Me.textBoxEdad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textBoxApellido)
        Me.Controls.Add(Me.labelApellido)
        Me.Controls.Add(Me.textBoxNombre)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.textBoxID)
        Me.Controls.Add(Me.labelid)
        Me.Controls.Add(Me.labelEmpleado)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelEmpleado As Label
    Friend WithEvents labelid As Label
    Friend WithEvents textBoxID As TextBox
    Friend WithEvents labelNombre As Label
    Friend WithEvents textBoxNombre As TextBox
    Friend WithEvents textBoxApellido As TextBox
    Friend WithEvents labelApellido As Label
    Friend WithEvents textBoxEdad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxCargo As TextBox
    Friend WithEvents labelCargo As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents textBoxTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textBoxDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnModificar As Button
End Class
