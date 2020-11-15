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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.Rtb_presentacion = New System.Windows.Forms.RichTextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormGridViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rtb_presentacion
        '
        Me.Rtb_presentacion.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtb_presentacion.Location = New System.Drawing.Point(32, 59)
        Me.Rtb_presentacion.Margin = New System.Windows.Forms.Padding(2)
        Me.Rtb_presentacion.Name = "Rtb_presentacion"
        Me.Rtb_presentacion.Size = New System.Drawing.Size(281, 281)
        Me.Rtb_presentacion.TabIndex = 0
        Me.Rtb_presentacion.Text = resources.GetString("Rtb_presentacion.Text")
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(626, 30)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(91, 19)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListBoxToolStripMenuItem, Me.FormGridViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(728, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListBoxToolStripMenuItem
        '
        Me.ListBoxToolStripMenuItem.Name = "ListBoxToolStripMenuItem"
        Me.ListBoxToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ListBoxToolStripMenuItem.Text = "Form List Box"
        '
        'FormGridViewToolStripMenuItem
        '
        Me.FormGridViewToolStripMenuItem.Name = "FormGridViewToolStripMenuItem"
        Me.FormGridViewToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.FormGridViewToolStripMenuItem.Text = "Form Grid View"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 428)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Rtb_presentacion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rtb_presentacion As RichTextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormGridViewToolStripMenuItem As ToolStripMenuItem
End Class
