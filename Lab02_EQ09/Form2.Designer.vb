<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.CheckBox()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbTelefono = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.ltbEstado = New System.Windows.Forms.ListBox()
        Me.ltbTelefono = New System.Windows.Forms.ListBox()
        Me.ltbEdad = New System.Windows.Forms.ListBox()
        Me.ltbNombre = New System.Windows.Forms.ListBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 41)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(76, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apellido y Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono:"
        '
        'cbEstado
        '
        Me.cbEstado.AutoSize = True
        Me.cbEstado.Location = New System.Drawing.Point(404, 144)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(62, 17)
        Me.cbEstado.TabIndex = 6
        Me.cbEstado.Text = "Casado"
        Me.cbEstado.UseVisualStyleBackColor = True
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.gbDatos.Controls.Add(Me.txtCantidad)
        Me.gbDatos.Controls.Add(Me.lbCantidad)
        Me.gbDatos.Controls.Add(Me.lbEstado)
        Me.gbDatos.Controls.Add(Me.lbTelefono)
        Me.gbDatos.Controls.Add(Me.lbEdad)
        Me.gbDatos.Controls.Add(Me.lbNombre)
        Me.gbDatos.Controls.Add(Me.ltbEstado)
        Me.gbDatos.Controls.Add(Me.ltbTelefono)
        Me.gbDatos.Controls.Add(Me.ltbEdad)
        Me.gbDatos.Controls.Add(Me.ltbNombre)
        Me.gbDatos.Location = New System.Drawing.Point(42, 183)
        Me.gbDatos.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDatos.Size = New System.Drawing.Size(620, 229)
        Me.gbDatos.TabIndex = 7
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Registro de Datos"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(296, 200)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(188, 204)
        Me.lbCantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(104, 13)
        Me.lbCantidad.TabIndex = 8
        Me.lbCantidad.Text = "Total de Ingresados:"
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(482, 28)
        Me.lbEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(62, 13)
        Me.lbEstado.TabIndex = 7
        Me.lbEstado.Text = "Estado Civil"
        '
        'lbTelefono
        '
        Me.lbTelefono.AutoSize = True
        Me.lbTelefono.Location = New System.Drawing.Point(340, 29)
        Me.lbTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTelefono.Name = "lbTelefono"
        Me.lbTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lbTelefono.TabIndex = 6
        Me.lbTelefono.Text = "Telefono"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Location = New System.Drawing.Point(190, 29)
        Me.lbEdad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(32, 13)
        Me.lbEdad.TabIndex = 5
        Me.lbEdad.Text = "Edad"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(15, 30)
        Me.lbNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(92, 13)
        Me.lbNombre.TabIndex = 4
        Me.lbNombre.Text = "Apellido y Nombre"
        '
        'ltbEstado
        '
        Me.ltbEstado.FormattingEnabled = True
        Me.ltbEstado.Location = New System.Drawing.Point(482, 57)
        Me.ltbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.ltbEstado.Name = "ltbEstado"
        Me.ltbEstado.Size = New System.Drawing.Size(120, 134)
        Me.ltbEstado.TabIndex = 3
        '
        'ltbTelefono
        '
        Me.ltbTelefono.FormattingEnabled = True
        Me.ltbTelefono.Location = New System.Drawing.Point(340, 57)
        Me.ltbTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.ltbTelefono.Name = "ltbTelefono"
        Me.ltbTelefono.Size = New System.Drawing.Size(128, 134)
        Me.ltbTelefono.TabIndex = 2
        '
        'ltbEdad
        '
        Me.ltbEdad.FormattingEnabled = True
        Me.ltbEdad.Location = New System.Drawing.Point(190, 57)
        Me.ltbEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.ltbEdad.Name = "ltbEdad"
        Me.ltbEdad.Size = New System.Drawing.Size(137, 134)
        Me.ltbEdad.TabIndex = 1
        '
        'ltbNombre
        '
        Me.ltbNombre.FormattingEnabled = True
        Me.ltbNombre.Location = New System.Drawing.Point(17, 57)
        Me.ltbNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.ltbNombre.Name = "ltbNombre"
        Me.ltbNombre.Size = New System.Drawing.Size(157, 134)
        Me.ltbNombre.TabIndex = 0
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(150, 89)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(76, 20)
        Me.txtEdad.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(150, 140)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(76, 20)
        Me.txtTelefono.TabIndex = 9
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(550, 36)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(56, 19)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(550, 72)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(56, 19)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(550, 110)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(56, 19)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(550, 144)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(56, 19)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(712, 434)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbEstado As CheckBox
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents lbCantidad As Label
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbTelefono As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents ltbEstado As ListBox
    Friend WithEvents ltbTelefono As ListBox
    Friend WithEvents ltbEdad As ListBox
    Friend WithEvents ltbNombre As ListBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtCantidad As TextBox
End Class
