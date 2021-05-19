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
        Me.GbMenuPrincipal = New System.Windows.Forms.GroupBox()
        Me.btnCiudad = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.GbMenuPrincipal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbMenuPrincipal
        '
        Me.GbMenuPrincipal.Controls.Add(Me.btnCiudad)
        Me.GbMenuPrincipal.Controls.Add(Me.btnUsuario)
        Me.GbMenuPrincipal.Controls.Add(Me.btnProducto)
        Me.GbMenuPrincipal.Controls.Add(Me.PictureBox1)
        Me.GbMenuPrincipal.Location = New System.Drawing.Point(12, 12)
        Me.GbMenuPrincipal.Name = "GbMenuPrincipal"
        Me.GbMenuPrincipal.Size = New System.Drawing.Size(181, 415)
        Me.GbMenuPrincipal.TabIndex = 0
        Me.GbMenuPrincipal.TabStop = False
        Me.GbMenuPrincipal.Text = "Menu"
        '
        'btnCiudad
        '
        Me.btnCiudad.Location = New System.Drawing.Point(48, 219)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(75, 23)
        Me.btnCiudad.TabIndex = 3
        Me.btnCiudad.Text = "Ciudad"
        Me.btnCiudad.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Location = New System.Drawing.Point(48, 190)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(75, 23)
        Me.btnUsuario.TabIndex = 2
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(48, 161)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(75, 23)
        Me.btnProducto.TabIndex = 1
        Me.btnProducto.Text = "Productos"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(19, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(688, 415)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(100, 23)
        Me.btnCerrarSesion.TabIndex = 1
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GbMenuPrincipal)
        Me.Name = "FrmMenuPrincipal"
        Me.Text = "FrmMenuPrincipal"
        Me.GbMenuPrincipal.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbMenuPrincipal As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCiudad As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnProducto As Button
    Friend WithEvents btnCerrarSesion As Button
End Class
