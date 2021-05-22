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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbPWD = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.LbSegundoApellido = New System.Windows.Forms.Label()
        Me.lbPrimerApe = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbIdUsuario = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtPWD = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtSegundoApe = New System.Windows.Forms.TextBox()
        Me.txtPrimerApe = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.UsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GbUsuario = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.UsuarioTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.UsuarioTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbUsuario.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.lbEstado)
        Me.GroupBox1.Controls.Add(Me.lbCorreo)
        Me.GroupBox1.Controls.Add(Me.lbPWD)
        Me.GroupBox1.Controls.Add(Me.lbUserName)
        Me.GroupBox1.Controls.Add(Me.LbSegundoApellido)
        Me.GroupBox1.Controls.Add(Me.lbPrimerApe)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbIdUsuario)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtPWD)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtSegundoApe)
        Me.GroupBox1.Controls.Add(Me.txtPrimerApe)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 558)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(87, 489)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(156, 23)
        Me.btnBuscar.TabIndex = 21
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(168, 518)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 20
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(87, 518)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 19
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 518)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 489)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 17
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(47, 396)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 16
        Me.lbEstado.Text = "Estado"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(47, 364)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lbCorreo.TabIndex = 15
        Me.lbCorreo.Text = "Correo"
        '
        'lbPWD
        '
        Me.lbPWD.AutoSize = True
        Me.lbPWD.Location = New System.Drawing.Point(31, 338)
        Me.lbPWD.Name = "lbPWD"
        Me.lbPWD.Size = New System.Drawing.Size(61, 13)
        Me.lbPWD.TabIndex = 14
        Me.lbPWD.Text = "Contraseña"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Location = New System.Drawing.Point(32, 311)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(60, 13)
        Me.lbUserName.TabIndex = 13
        Me.lbUserName.Text = "User Name"
        '
        'LbSegundoApellido
        '
        Me.LbSegundoApellido.AutoSize = True
        Me.LbSegundoApellido.Location = New System.Drawing.Point(2, 284)
        Me.LbSegundoApellido.Name = "LbSegundoApellido"
        Me.LbSegundoApellido.Size = New System.Drawing.Size(90, 13)
        Me.LbSegundoApellido.TabIndex = 12
        Me.LbSegundoApellido.Text = "Segundo Apellido"
        '
        'lbPrimerApe
        '
        Me.lbPrimerApe.AutoSize = True
        Me.lbPrimerApe.Location = New System.Drawing.Point(19, 257)
        Me.lbPrimerApe.Name = "lbPrimerApe"
        Me.lbPrimerApe.Size = New System.Drawing.Size(76, 13)
        Me.lbPrimerApe.TabIndex = 11
        Me.lbPrimerApe.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.AutoSize = True
        Me.lbIdUsuario.Location = New System.Drawing.Point(74, 203)
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.Size = New System.Drawing.Size(18, 13)
        Me.lbIdUsuario.TabIndex = 9
        Me.lbIdUsuario.Text = "ID"
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(103, 390)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 8
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.CatalanaDataSet
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCorreo
        '
        Me.txtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "email", True))
        Me.txtCorreo.Location = New System.Drawing.Point(103, 364)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 7
        '
        'txtPWD
        '
        Me.txtPWD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "userPwd", True))
        Me.txtPWD.Location = New System.Drawing.Point(103, 338)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(100, 20)
        Me.txtPWD.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "userName", True))
        Me.txtUserName.Location = New System.Drawing.Point(103, 311)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 5
        '
        'txtSegundoApe
        '
        Me.txtSegundoApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "segundoApellido", True))
        Me.txtSegundoApe.Location = New System.Drawing.Point(103, 284)
        Me.txtSegundoApe.Name = "txtSegundoApe"
        Me.txtSegundoApe.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundoApe.TabIndex = 4
        '
        'txtPrimerApe
        '
        Me.txtPrimerApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "primerApellido", True))
        Me.txtPrimerApe.Location = New System.Drawing.Point(103, 257)
        Me.txtPrimerApe.Name = "txtPrimerApe"
        Me.txtPrimerApe.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimerApe.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "primerNombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(103, 230)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'UsuarioBindingSource1
        '
        Me.UsuarioBindingSource1.DataMember = "Usuario"
        Me.UsuarioBindingSource1.DataSource = Me.CatalanaDataSet
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "idUsuario", True))
        Me.txtID.Location = New System.Drawing.Point(103, 203)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(53, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GbUsuario
        '
        Me.GbUsuario.Controls.Add(Me.DataGridView1)
        Me.GbUsuario.Location = New System.Drawing.Point(267, 71)
        Me.GbUsuario.Name = "GbUsuario"
        Me.GbUsuario.Size = New System.Drawing.Size(521, 499)
        Me.GbUsuario.TabIndex = 1
        Me.GbUsuario.TabStop = False
        Me.GbUsuario.Text = "Tabla de usuarios"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarioDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsuarioBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(515, 480)
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
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(683, 42)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(102, 23)
        Me.btnReporte.TabIndex = 2
        Me.btnReporte.Text = "Reporte Usuario"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(683, 13)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(105, 23)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 582)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.GbUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuario"
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbUsuario.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GbUsuario As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As CatalanaDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbPWD As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents LbSegundoApellido As Label
    Friend WithEvents lbPrimerApe As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbIdUsuario As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtPWD As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtSegundoApe As TextBox
    Friend WithEvents txtPrimerApe As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioBindingSource1 As BindingSource
End Class
