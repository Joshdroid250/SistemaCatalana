<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.GbUsuario = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaNicDataSet = New CatalanaNic.CatalanaNicDataSet()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtIDUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.lbSegundoApellido = New System.Windows.Forms.Label()
        Me.lbPrimerApellido = New System.Windows.Forms.Label()
        Me.LbPrimerNombre = New System.Windows.Forms.Label()
        Me.lbIdUsuario = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GBRUsuarios = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserPwdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioTableAdapter = New CatalanaNic.CatalanaNicDataSetTableAdapters.UsuarioTableAdapter()
        Me.GbUsuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaNicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBRUsuarios.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbUsuario
        '
        Me.GbUsuario.Controls.Add(Me.PictureBox1)
        Me.GbUsuario.Controls.Add(Me.txtEstado)
        Me.GbUsuario.Controls.Add(Me.txtCorreo)
        Me.GbUsuario.Controls.Add(Me.txtContraseña)
        Me.GbUsuario.Controls.Add(Me.txtUserName)
        Me.GbUsuario.Controls.Add(Me.txtSegundoApellido)
        Me.GbUsuario.Controls.Add(Me.txtPrimerApellido)
        Me.GbUsuario.Controls.Add(Me.txtPrimerNombre)
        Me.GbUsuario.Controls.Add(Me.txtIDUsuario)
        Me.GbUsuario.Controls.Add(Me.Label8)
        Me.GbUsuario.Controls.Add(Me.Label7)
        Me.GbUsuario.Controls.Add(Me.Label6)
        Me.GbUsuario.Controls.Add(Me.lbUserName)
        Me.GbUsuario.Controls.Add(Me.lbSegundoApellido)
        Me.GbUsuario.Controls.Add(Me.lbPrimerApellido)
        Me.GbUsuario.Controls.Add(Me.LbPrimerNombre)
        Me.GbUsuario.Controls.Add(Me.lbIdUsuario)
        Me.GbUsuario.Controls.Add(Me.btnEditar)
        Me.GbUsuario.Controls.Add(Me.btnBorrar)
        Me.GbUsuario.Controls.Add(Me.btnAgregar)
        Me.GbUsuario.Controls.Add(Me.btnNuevo)
        Me.GbUsuario.Location = New System.Drawing.Point(12, 4)
        Me.GbUsuario.Name = "GbUsuario"
        Me.GbUsuario.Size = New System.Drawing.Size(262, 397)
        Me.GbUsuario.TabIndex = 0
        Me.GbUsuario.TabStop = False
        Me.GbUsuario.Text = "Usuarios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNic.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(70, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(105, 295)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(96, 20)
        Me.txtEstado.TabIndex = 19
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.CatalanaNicDataSet
        '
        'CatalanaNicDataSet
        '
        Me.CatalanaNicDataSet.DataSetName = "CatalanaNicDataSet"
        Me.CatalanaNicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCorreo
        '
        Me.txtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "email", True))
        Me.txtCorreo.Location = New System.Drawing.Point(105, 269)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(96, 20)
        Me.txtCorreo.TabIndex = 18
        '
        'txtContraseña
        '
        Me.txtContraseña.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "userPwd", True))
        Me.txtContraseña.Location = New System.Drawing.Point(105, 243)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(96, 20)
        Me.txtContraseña.TabIndex = 17
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "userName", True))
        Me.txtUserName.Location = New System.Drawing.Point(105, 217)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(96, 20)
        Me.txtUserName.TabIndex = 16
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "segundoApellido", True))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(105, 191)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(96, 20)
        Me.txtSegundoApellido.TabIndex = 15
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "primerApellido", True))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(105, 165)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(96, 20)
        Me.txtPrimerApellido.TabIndex = 14
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "primerNombre", True))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(105, 139)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(96, 20)
        Me.txtPrimerNombre.TabIndex = 13
        '
        'txtIDUsuario
        '
        Me.txtIDUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "idUsuario", True))
        Me.txtIDUsuario.Location = New System.Drawing.Point(105, 113)
        Me.txtIDUsuario.Name = "txtIDUsuario"
        Me.txtIDUsuario.Size = New System.Drawing.Size(96, 20)
        Me.txtIDUsuario.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(58, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Correo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Contraseña:"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Location = New System.Drawing.Point(-2, 220)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(99, 13)
        Me.lbUserName.TabIndex = 8
        Me.lbUserName.Text = "Nombre de usuario:"
        '
        'lbSegundoApellido
        '
        Me.lbSegundoApellido.AutoSize = True
        Me.lbSegundoApellido.Location = New System.Drawing.Point(6, 191)
        Me.lbSegundoApellido.Name = "lbSegundoApellido"
        Me.lbSegundoApellido.Size = New System.Drawing.Size(93, 13)
        Me.lbSegundoApellido.TabIndex = 7
        Me.lbSegundoApellido.Text = "Segundo Apellido:"
        '
        'lbPrimerApellido
        '
        Me.lbPrimerApellido.AutoSize = True
        Me.lbPrimerApellido.Location = New System.Drawing.Point(20, 165)
        Me.lbPrimerApellido.Name = "lbPrimerApellido"
        Me.lbPrimerApellido.Size = New System.Drawing.Size(79, 13)
        Me.lbPrimerApellido.TabIndex = 6
        Me.lbPrimerApellido.Text = "Primer Apellido:"
        '
        'LbPrimerNombre
        '
        Me.LbPrimerNombre.AutoSize = True
        Me.LbPrimerNombre.Location = New System.Drawing.Point(20, 139)
        Me.LbPrimerNombre.Name = "LbPrimerNombre"
        Me.LbPrimerNombre.Size = New System.Drawing.Size(79, 13)
        Me.LbPrimerNombre.TabIndex = 5
        Me.LbPrimerNombre.Text = "Primer Nombre:"
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.AutoSize = True
        Me.lbIdUsuario.Location = New System.Drawing.Point(42, 113)
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.Size = New System.Drawing.Size(55, 13)
        Me.lbIdUsuario.TabIndex = 4
        Me.lbIdUsuario.Text = "IdUsuario:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(168, 345)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(87, 345)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 345)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 316)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GBRUsuarios
        '
        Me.GBRUsuarios.Controls.Add(Me.DataGridView1)
        Me.GBRUsuarios.Location = New System.Drawing.Point(280, 86)
        Me.GBRUsuarios.Name = "GBRUsuarios"
        Me.GBRUsuarios.Size = New System.Drawing.Size(508, 315)
        Me.GBRUsuarios.TabIndex = 1
        Me.GBRUsuarios.TabStop = False
        Me.GBRUsuarios.Text = "Registro de Usuario "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarioDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.UserPwdDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsuarioBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(502, 296)
        Me.DataGridView1.TabIndex = 0
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerNombreDataGridViewTextBoxColumn
        '
        Me.PrimerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.HeaderText = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.Name = "PrimerNombreDataGridViewTextBoxColumn"
        Me.PrimerNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerApellidoDataGridViewTextBoxColumn
        '
        Me.PrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.HeaderText = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.Name = "PrimerApellidoDataGridViewTextBoxColumn"
        Me.PrimerApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SegundoApellidoDataGridViewTextBoxColumn
        '
        Me.SegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.HeaderText = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.Name = "SegundoApellidoDataGridViewTextBoxColumn"
        Me.SegundoApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "userName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "userName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserPwdDataGridViewTextBoxColumn
        '
        Me.UserPwdDataGridViewTextBoxColumn.DataPropertyName = "userPwd"
        Me.UserPwdDataGridViewTextBoxColumn.HeaderText = "userPwd"
        Me.UserPwdDataGridViewTextBoxColumn.Name = "UserPwdDataGridViewTextBoxColumn"
        Me.UserPwdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 410)
        Me.Controls.Add(Me.GBRUsuarios)
        Me.Controls.Add(Me.GbUsuario)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 449)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(816, 449)
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
        Me.GbUsuario.ResumeLayout(False)
        Me.GbUsuario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaNicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBRUsuarios.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbUsuario As GroupBox
    Friend WithEvents GBRUsuarios As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CatalanaNicDataSet As CatalanaNicDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As CatalanaNicDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserPwdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents txtIDUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents lbSegundoApellido As Label
    Friend WithEvents lbPrimerApellido As Label
    Friend WithEvents LbPrimerNombre As Label
    Friend WithEvents lbIdUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
