<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.Rtb_presentacion = New System.Windows.Forms.RichTextBox()
        Me.btnApp = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Rtb_presentacion
        '
        Me.Rtb_presentacion.Location = New System.Drawing.Point(11, 11)
        Me.Rtb_presentacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rtb_presentacion.Name = "Rtb_presentacion"
        Me.Rtb_presentacion.Size = New System.Drawing.Size(320, 409)
        Me.Rtb_presentacion.TabIndex = 0
        Me.Rtb_presentacion.Text = "Desarrollo de Software VIII" & Global.Microsoft.VisualBasic.ChrW(10) & "Grupo: 1LS132" & Global.Microsoft.VisualBasic.ChrW(10) & "Fecha de Entrega: 11 de noviembre de 20" &
    "20 " & Global.Microsoft.VisualBasic.ChrW(10) & "Equipo: 9" & Global.Microsoft.VisualBasic.ChrW(10) & "Integrantes:"
        '
        'btnApp
        '
        Me.btnApp.Location = New System.Drawing.Point(475, 168)
        Me.btnApp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnApp.Name = "btnApp"
        Me.btnApp.Size = New System.Drawing.Size(171, 29)
        Me.btnApp.TabIndex = 1
        Me.btnApp.Text = "APLICACION LIST BOX"
        Me.btnApp.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(626, 30)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 19)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(475, 228)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "APLICACION GRID VIEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 428)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnApp)
        Me.Controls.Add(Me.Rtb_presentacion)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rtb_presentacion As RichTextBox
    Friend WithEvents btnApp As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button1 As Button
End Class
