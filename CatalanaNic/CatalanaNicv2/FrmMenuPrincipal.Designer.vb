<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.GbMenuPrincipal = New System.Windows.Forms.GroupBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbHola = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GbMenuPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbMenuPrincipal
        '
        Me.GbMenuPrincipal.Controls.Add(Me.lbNombre)
        Me.GbMenuPrincipal.Controls.Add(Me.lbHola)
        Me.GbMenuPrincipal.Controls.Add(Me.lbName)
        Me.GbMenuPrincipal.Controls.Add(Me.Button2)
        Me.GbMenuPrincipal.Controls.Add(Me.Button1)
        Me.GbMenuPrincipal.Controls.Add(Me.btnCliente)
        Me.GbMenuPrincipal.Controls.Add(Me.btnCerrarSesion)
        Me.GbMenuPrincipal.Controls.Add(Me.lbHora)
        Me.GbMenuPrincipal.Controls.Add(Me.btnCiudad)
        Me.GbMenuPrincipal.Controls.Add(Me.btnUsuario)
        Me.GbMenuPrincipal.Controls.Add(Me.btnProducto)
        Me.GbMenuPrincipal.Controls.Add(Me.PictureBox1)
        Me.GbMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbMenuPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.GbMenuPrincipal.Name = "GbMenuPrincipal"
        Me.GbMenuPrincipal.Size = New System.Drawing.Size(649, 346)
        Me.GbMenuPrincipal.TabIndex = 0
        Me.GbMenuPrincipal.TabStop = False
        Me.GbMenuPrincipal.Text = "Menu"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(77, 161)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(39, 13)
        Me.lbNombre.TabIndex = 11
        Me.lbNombre.Text = "Label1"
        '
        'lbHola
        '
        Me.lbHola.AutoSize = True
        Me.lbHola.Location = New System.Drawing.Point(17, 161)
        Me.lbHola.Name = "lbHola"
        Me.lbHola.Size = New System.Drawing.Size(63, 13)
        Me.lbHola.TabIndex = 10
        Me.lbHola.Text = "Bienvenido:"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(17, 161)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(0, 13)
        Me.lbName.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Detalle de Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Factura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(158, 135)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(100, 23)
        Me.btnCliente.TabIndex = 5
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(543, 19)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(100, 23)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Location = New System.Drawing.Point(17, 319)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(34, 13)
        Me.lbHora.TabIndex = 4
        Me.lbHora.Text = "Clock"
        '
        'btnCiudad
        '
        Me.btnCiudad.Location = New System.Drawing.Point(158, 106)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(100, 23)
        Me.btnCiudad.TabIndex = 3
        Me.btnCiudad.Text = "Ciudad"
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Location = New System.Drawing.Point(158, 19)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(100, 23)
        Me.btnUsuario.TabIndex = 2
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(158, 77)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(100, 23)
        Me.btnProducto.TabIndex = 1
        Me.btnProducto.Text = "Productos"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 370)
        Me.Controls.Add(Me.GbMenuPrincipal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.GbMenuPrincipal.ResumeLayout(False)
        Me.GbMenuPrincipal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbMenuPrincipal As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lbHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCliente As Button
    Friend WithEvents lbName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbHola As Label
    Friend WithEvents lbNombre As Label
End Class
