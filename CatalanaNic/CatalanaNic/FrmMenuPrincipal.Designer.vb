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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GbMenu = New System.Windows.Forms.GroupBox()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNic.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GbMenu
        '
        Me.GbMenu.Controls.Add(Me.lbHora)
        Me.GbMenu.Controls.Add(Me.Button3)
        Me.GbMenu.Controls.Add(Me.Button2)
        Me.GbMenu.Controls.Add(Me.BtnProducto)
        Me.GbMenu.Controls.Add(Me.PictureBox1)
        Me.GbMenu.Location = New System.Drawing.Point(12, 12)
        Me.GbMenu.Name = "GbMenu"
        Me.GbMenu.Size = New System.Drawing.Size(130, 399)
        Me.GbMenu.TabIndex = 1
        Me.GbMenu.TabStop = False
        Me.GbMenu.Text = "Menu"
        '
        'BtnProducto
        '
        Me.BtnProducto.Location = New System.Drawing.Point(25, 139)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(75, 23)
        Me.BtnProducto.TabIndex = 1
        Me.BtnProducto.Text = "Producto"
        Me.BtnProducto.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Ciudad"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(25, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Usuarios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbHora
        '
        Me.lbHora.AutoSize = True
        Me.lbHora.Location = New System.Drawing.Point(6, 367)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(39, 13)
        Me.lbHora.TabIndex = 4
        Me.lbHora.Text = "Label1"
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
        Me.ClientSize = New System.Drawing.Size(785, 423)
        Me.Controls.Add(Me.GbMenu)
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Catalana"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbMenu.ResumeLayout(False)
        Me.GbMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GbMenu As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnProducto As Button
    Friend WithEvents lbHora As Label
    Friend WithEvents Timer1 As Timer
End Class
