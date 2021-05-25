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
        Me.gbUser = New System.Windows.Forms.GroupBox()
        Me.btnReporte = New System.Windows.Forms.Button()
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
        Me.UsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtPWD = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtSegundoApe = New System.Windows.Forms.TextBox()
        Me.txtPrimerApe = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GbUsuarioTable = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UsuarioTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.UsuarioTableAdapter()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbUser.SuspendLayout()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbUsuarioTable.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbUser
        '
        Me.gbUser.Controls.Add(Me.btnReporte)
        Me.gbUser.Controls.Add(Me.btnBuscar)
        Me.gbUser.Controls.Add(Me.btnActualizar)
        Me.gbUser.Controls.Add(Me.btnBorrar)
        Me.gbUser.Controls.Add(Me.btnAgregar)
        Me.gbUser.Controls.Add(Me.btnNuevo)
        Me.gbUser.Controls.Add(Me.lbEstado)
        Me.gbUser.Controls.Add(Me.lbCorreo)
        Me.gbUser.Controls.Add(Me.lbPWD)
        Me.gbUser.Controls.Add(Me.lbUserName)
        Me.gbUser.Controls.Add(Me.LbSegundoApellido)
        Me.gbUser.Controls.Add(Me.lbPrimerApe)
        Me.gbUser.Controls.Add(Me.Label2)
        Me.gbUser.Controls.Add(Me.lbIdUsuario)
        Me.gbUser.Controls.Add(Me.txtEstado)
        Me.gbUser.Controls.Add(Me.txtCorreo)
        Me.gbUser.Controls.Add(Me.txtPWD)
        Me.gbUser.Controls.Add(Me.txtUserName)
        Me.gbUser.Controls.Add(Me.txtSegundoApe)
        Me.gbUser.Controls.Add(Me.txtPrimerApe)
        Me.gbUser.Controls.Add(Me.txtNombre)
        Me.gbUser.Controls.Add(Me.txtID)
        Me.gbUser.Controls.Add(Me.PictureBox1)
        Me.gbUser.Location = New System.Drawing.Point(12, 12)
        Me.gbUser.Name = "gbUser"
        Me.gbUser.Size = New System.Drawing.Size(604, 239)
        Me.gbUser.TabIndex = 0
        Me.gbUser.TabStop = False
        Me.gbUser.Text = "Usuario"
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(34, 192)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(102, 23)
        Me.btnReporte.TabIndex = 14
        Me.btnReporte.Text = "Reporte Usuario"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(438, 174)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(156, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(519, 203)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 13
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(438, 203)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 12
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(357, 203)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(357, 174)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(414, 120)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 16
        Me.lbEstado.Text = "Estado"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(185, 115)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lbCorreo.TabIndex = 15
        Me.lbCorreo.Text = "Correo"
        '
        'lbPWD
        '
        Me.lbPWD.AutoSize = True
        Me.lbPWD.Location = New System.Drawing.Point(393, 96)
        Me.lbPWD.Name = "lbPWD"
        Me.lbPWD.Size = New System.Drawing.Size(61, 13)
        Me.lbPWD.TabIndex = 14
        Me.lbPWD.Text = "Contraseña"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Location = New System.Drawing.Point(163, 91)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(60, 13)
        Me.lbUserName.TabIndex = 13
        Me.lbUserName.Text = "User Name"
        '
        'LbSegundoApellido
        '
        Me.LbSegundoApellido.AutoSize = True
        Me.LbSegundoApellido.Location = New System.Drawing.Point(364, 68)
        Me.LbSegundoApellido.Name = "LbSegundoApellido"
        Me.LbSegundoApellido.Size = New System.Drawing.Size(90, 13)
        Me.LbSegundoApellido.TabIndex = 12
        Me.LbSegundoApellido.Text = "Segundo Apellido"
        '
        'lbPrimerApe
        '
        Me.lbPrimerApe.AutoSize = True
        Me.lbPrimerApe.Location = New System.Drawing.Point(378, 40)
        Me.lbPrimerApe.Name = "lbPrimerApe"
        Me.lbPrimerApe.Size = New System.Drawing.Size(76, 13)
        Me.lbPrimerApe.TabIndex = 11
        Me.lbPrimerApe.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'lbIdUsuario
        '
        Me.lbIdUsuario.AutoSize = True
        Me.lbIdUsuario.Location = New System.Drawing.Point(205, 39)
        Me.lbIdUsuario.Name = "lbIdUsuario"
        Me.lbIdUsuario.Size = New System.Drawing.Size(18, 13)
        Me.lbIdUsuario.TabIndex = 9
        Me.lbIdUsuario.Text = "ID"
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(460, 117)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 8
        '
        'UsuarioBindingSource1
        '
        Me.UsuarioBindingSource1.DataMember = "Usuario"
        Me.UsuarioBindingSource1.DataSource = Me.CatalanaDataSet
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCorreo
        '
        Me.txtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "email", True))
        Me.txtCorreo.Location = New System.Drawing.Point(229, 115)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 7
        '
        'txtPWD
        '
        Me.txtPWD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "userPwd", True))
        Me.txtPWD.Location = New System.Drawing.Point(460, 91)
        Me.txtPWD.Name = "txtPWD"
        Me.txtPWD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPWD.Size = New System.Drawing.Size(100, 20)
        Me.txtPWD.TabIndex = 6
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "userName", True))
        Me.txtUserName.Location = New System.Drawing.Point(229, 89)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 5
        '
        'txtSegundoApe
        '
        Me.txtSegundoApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "segundoApellido", True))
        Me.txtSegundoApe.Location = New System.Drawing.Point(460, 65)
        Me.txtSegundoApe.Name = "txtSegundoApe"
        Me.txtSegundoApe.Size = New System.Drawing.Size(100, 20)
        Me.txtSegundoApe.TabIndex = 4
        '
        'txtPrimerApe
        '
        Me.txtPrimerApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "primerApellido", True))
        Me.txtPrimerApe.Location = New System.Drawing.Point(460, 36)
        Me.txtPrimerApe.Name = "txtPrimerApe"
        Me.txtPrimerApe.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimerApe.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "primerNombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(229, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource1, "idUsuario", True))
        Me.txtID.Location = New System.Drawing.Point(229, 32)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.CatalanaDataSet
        '
        'GbUsuarioTable
        '
        Me.GbUsuarioTable.Controls.Add(Me.DataGridView1)
        Me.GbUsuarioTable.Location = New System.Drawing.Point(12, 257)
        Me.GbUsuarioTable.Name = "GbUsuarioTable"
        Me.GbUsuarioTable.Size = New System.Drawing.Size(604, 313)
        Me.GbUsuarioTable.TabIndex = 1
        Me.GbUsuarioTable.TabStop = False
        Me.GbUsuarioTable.Text = "Tabla de usuarios"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuarioDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsuarioBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(598, 294)
        Me.DataGridView1.TabIndex = 0
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "ID Usuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerNombreDataGridViewTextBoxColumn
        '
        Me.PrimerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.HeaderText = "Primer Nombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.Name = "PrimerNombreDataGridViewTextBoxColumn"
        Me.PrimerNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerApellidoDataGridViewTextBoxColumn
        '
        Me.PrimerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.HeaderText = "Primer Apellido"
        Me.PrimerApellidoDataGridViewTextBoxColumn.Name = "PrimerApellidoDataGridViewTextBoxColumn"
        Me.PrimerApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SegundoApellidoDataGridViewTextBoxColumn
        '
        Me.SegundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.HeaderText = "Segundo Apellido"
        Me.SegundoApellidoDataGridViewTextBoxColumn.Name = "SegundoApellidoDataGridViewTextBoxColumn"
        Me.SegundoApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "userName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 582)
        Me.Controls.Add(Me.GbUsuarioTable)
        Me.Controls.Add(Me.gbUser)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuario"
        Me.Text = "Usuario"
        Me.gbUser.ResumeLayout(False)
        Me.gbUser.PerformLayout()
        CType(Me.UsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbUsuarioTable.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbUser As GroupBox
    Friend WithEvents GbUsuarioTable As GroupBox
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
    Friend WithEvents UsuarioBindingSource1 As BindingSource
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
