<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GbCliente = New System.Windows.Forms.GroupBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.txtCedu = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet1 = New CatalanaNicv2.CatalanaDataSet()
        Me.lbNumCedu = New System.Windows.Forms.Label()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.lbCity = New System.Windows.Forms.Label()
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtcellCootel = New System.Windows.Forms.TextBox()
        Me.txtcellTigo = New System.Windows.Forms.TextBox()
        Me.txtcellClaro = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbClaro = New System.Windows.Forms.Label()
        Me.lbCeltigo = New System.Windows.Forms.Label()
        Me.lbCiudad = New System.Windows.Forms.Label()
        Me.lbCorreo = New System.Windows.Forms.Label()
        Me.lbDomicilio = New System.Windows.Forms.Label()
        Me.lbSegundoApe = New System.Windows.Forms.Label()
        Me.lbApellido = New System.Windows.Forms.Label()
        Me.lbSegundoName = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cbCiudad = New System.Windows.Forms.ComboBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.PBCatalana = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GbRegistroCliente = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.ClienteTableAdapter()
        Me.ClienteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.ciudadTableAdapter()
        Me.ClienteBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumCedulaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelTigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelClaroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelCootelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbCliente.SuspendLayout()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCatalana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbRegistroCliente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbCliente
        '
        Me.GbCliente.Controls.Add(Me.btnReporte)
        Me.GbCliente.Controls.Add(Me.txtCedu)
        Me.GbCliente.Controls.Add(Me.lbNumCedu)
        Me.GbCliente.Controls.Add(Me.btnBuscarID)
        Me.GbCliente.Controls.Add(Me.lbCity)
        Me.GbCliente.Controls.Add(Me.txtNombre)
        Me.GbCliente.Controls.Add(Me.txtID)
        Me.GbCliente.Controls.Add(Me.txtEstado)
        Me.GbCliente.Controls.Add(Me.txtcellCootel)
        Me.GbCliente.Controls.Add(Me.txtcellTigo)
        Me.GbCliente.Controls.Add(Me.txtcellClaro)
        Me.GbCliente.Controls.Add(Me.txtCorreo)
        Me.GbCliente.Controls.Add(Me.txtDomicilio)
        Me.GbCliente.Controls.Add(Me.txtSegundoApellido)
        Me.GbCliente.Controls.Add(Me.txtApellido)
        Me.GbCliente.Controls.Add(Me.txtSegundoName)
        Me.GbCliente.Controls.Add(Me.Label12)
        Me.GbCliente.Controls.Add(Me.Label11)
        Me.GbCliente.Controls.Add(Me.lbClaro)
        Me.GbCliente.Controls.Add(Me.lbCeltigo)
        Me.GbCliente.Controls.Add(Me.lbCiudad)
        Me.GbCliente.Controls.Add(Me.lbCorreo)
        Me.GbCliente.Controls.Add(Me.lbDomicilio)
        Me.GbCliente.Controls.Add(Me.lbSegundoApe)
        Me.GbCliente.Controls.Add(Me.lbApellido)
        Me.GbCliente.Controls.Add(Me.lbSegundoName)
        Me.GbCliente.Controls.Add(Me.lbNombre)
        Me.GbCliente.Controls.Add(Me.lbID)
        Me.GbCliente.Controls.Add(Me.cbCiudad)
        Me.GbCliente.Controls.Add(Me.btnActualizar)
        Me.GbCliente.Controls.Add(Me.btnBorrar)
        Me.GbCliente.Controls.Add(Me.btnAgregar)
        Me.GbCliente.Controls.Add(Me.PBCatalana)
        Me.GbCliente.Controls.Add(Me.btnNuevo)
        Me.GbCliente.Location = New System.Drawing.Point(12, 12)
        Me.GbCliente.Name = "GbCliente"
        Me.GbCliente.Size = New System.Drawing.Size(752, 292)
        Me.GbCliente.TabIndex = 0
        Me.GbCliente.TabStop = False
        Me.GbCliente.Text = "Cliente"
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(428, 250)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 5
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'txtCedu
        '
        Me.txtCedu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "numCedula", True))
        Me.txtCedu.Location = New System.Drawing.Point(308, 44)
        Me.txtCedu.Name = "txtCedu"
        Me.txtCedu.Size = New System.Drawing.Size(121, 20)
        Me.txtCedu.TabIndex = 2
        '
        'ClienteBindingSource4
        '
        Me.ClienteBindingSource4.DataMember = "Cliente"
        Me.ClienteBindingSource4.DataSource = Me.CatalanaDataSet1
        '
        'CatalanaDataSet1
        '
        Me.CatalanaDataSet1.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbNumCedu
        '
        Me.lbNumCedu.AutoSize = True
        Me.lbNumCedu.Location = New System.Drawing.Point(208, 47)
        Me.lbNumCedu.Name = "lbNumCedu"
        Me.lbNumCedu.Size = New System.Drawing.Size(94, 13)
        Me.lbNumCedu.TabIndex = 32
        Me.lbNumCedu.Text = "Numero de cedula"
        '
        'btnBuscarID
        '
        Me.btnBuscarID.Location = New System.Drawing.Point(509, 250)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(234, 23)
        Me.btnBuscarID.TabIndex = 18
        Me.btnBuscarID.Text = "Buscar por ID"
        Me.btnBuscarID.UseVisualStyleBackColor = True
        '
        'lbCity
        '
        Me.lbCity.AutoSize = True
        Me.lbCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "idCiudad", True))
        Me.lbCity.Location = New System.Drawing.Point(189, 152)
        Me.lbCity.Name = "lbCity"
        Me.lbCity.Size = New System.Drawing.Size(10, 13)
        Me.lbCity.TabIndex = 29
        Me.lbCity.Text = "."
        Me.lbCity.Visible = False
        '
        'CiudadBindingSource
        '
        Me.CiudadBindingSource.DataMember = "ciudad"
        Me.CiudadBindingSource.DataSource = Me.CatalanaDataSetBindingSource
        '
        'CatalanaDataSetBindingSource
        '
        Me.CatalanaDataSetBindingSource.DataSource = Me.CatalanaDataSet
        Me.CatalanaDataSetBindingSource.Position = 0
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "primerNombre", True))
        Me.txtNombre.Location = New System.Drawing.Point(62, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "idCliente", True))
        Me.txtID.Location = New System.Drawing.Point(62, 44)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 1
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(62, 204)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(121, 20)
        Me.txtEstado.TabIndex = 13
        '
        'txtcellCootel
        '
        Me.txtcellCootel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "celCootel", True))
        Me.txtcellCootel.Location = New System.Drawing.Point(62, 178)
        Me.txtcellCootel.Name = "txtcellCootel"
        Me.txtcellCootel.Size = New System.Drawing.Size(121, 20)
        Me.txtcellCootel.TabIndex = 11
        '
        'txtcellTigo
        '
        Me.txtcellTigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "celTigo", True))
        Me.txtcellTigo.Location = New System.Drawing.Point(308, 149)
        Me.txtcellTigo.Name = "txtcellTigo"
        Me.txtcellTigo.Size = New System.Drawing.Size(121, 20)
        Me.txtcellTigo.TabIndex = 10
        '
        'txtcellClaro
        '
        Me.txtcellClaro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "celClaro", True))
        Me.txtcellClaro.Location = New System.Drawing.Point(308, 175)
        Me.txtcellClaro.Name = "txtcellClaro"
        Me.txtcellClaro.Size = New System.Drawing.Size(121, 20)
        Me.txtcellClaro.TabIndex = 12
        '
        'txtCorreo
        '
        Me.txtCorreo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "email", True))
        Me.txtCorreo.Location = New System.Drawing.Point(308, 122)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(121, 20)
        Me.txtCorreo.TabIndex = 8
        '
        'txtDomicilio
        '
        Me.txtDomicilio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "domicilio", True))
        Me.txtDomicilio.Location = New System.Drawing.Point(62, 122)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(121, 20)
        Me.txtDomicilio.TabIndex = 7
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "segundoApellido", True))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(308, 96)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(121, 20)
        Me.txtSegundoApellido.TabIndex = 6
        '
        'txtApellido
        '
        Me.txtApellido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "primerApellido", True))
        Me.txtApellido.Location = New System.Drawing.Point(62, 96)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(121, 20)
        Me.txtApellido.TabIndex = 5
        '
        'txtSegundoName
        '
        Me.txtSegundoName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource4, "segundoNombre", True))
        Me.txtSegundoName.Location = New System.Drawing.Point(308, 70)
        Me.txtSegundoName.Name = "txtSegundoName"
        Me.txtSegundoName.Size = New System.Drawing.Size(121, 20)
        Me.txtSegundoName.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Estado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "CelCootel"
        '
        'lbClaro
        '
        Me.lbClaro.AutoSize = True
        Me.lbClaro.Location = New System.Drawing.Point(256, 178)
        Me.lbClaro.Name = "lbClaro"
        Me.lbClaro.Size = New System.Drawing.Size(46, 13)
        Me.lbClaro.TabIndex = 15
        Me.lbClaro.Text = "CelClaro"
        '
        'lbCeltigo
        '
        Me.lbCeltigo.AutoSize = True
        Me.lbCeltigo.Location = New System.Drawing.Point(260, 152)
        Me.lbCeltigo.Name = "lbCeltigo"
        Me.lbCeltigo.Size = New System.Drawing.Size(42, 13)
        Me.lbCeltigo.TabIndex = 14
        Me.lbCeltigo.Text = "celTigo"
        '
        'lbCiudad
        '
        Me.lbCiudad.AutoSize = True
        Me.lbCiudad.Location = New System.Drawing.Point(16, 152)
        Me.lbCiudad.Name = "lbCiudad"
        Me.lbCiudad.Size = New System.Drawing.Size(40, 13)
        Me.lbCiudad.TabIndex = 13
        Me.lbCiudad.Text = "Ciudad"
        '
        'lbCorreo
        '
        Me.lbCorreo.AutoSize = True
        Me.lbCorreo.Location = New System.Drawing.Point(266, 125)
        Me.lbCorreo.Name = "lbCorreo"
        Me.lbCorreo.Size = New System.Drawing.Size(38, 13)
        Me.lbCorreo.TabIndex = 12
        Me.lbCorreo.Text = "Correo"
        '
        'lbDomicilio
        '
        Me.lbDomicilio.AutoSize = True
        Me.lbDomicilio.Location = New System.Drawing.Point(12, 125)
        Me.lbDomicilio.Name = "lbDomicilio"
        Me.lbDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbDomicilio.TabIndex = 11
        Me.lbDomicilio.Text = "Domicilio"
        '
        'lbSegundoApe
        '
        Me.lbSegundoApe.AutoSize = True
        Me.lbSegundoApe.Location = New System.Drawing.Point(210, 99)
        Me.lbSegundoApe.Name = "lbSegundoApe"
        Me.lbSegundoApe.Size = New System.Drawing.Size(92, 13)
        Me.lbSegundoApe.TabIndex = 10
        Me.lbSegundoApe.Text = "Segundo Apellidio"
        '
        'lbApellido
        '
        Me.lbApellido.AutoSize = True
        Me.lbApellido.Location = New System.Drawing.Point(12, 99)
        Me.lbApellido.Name = "lbApellido"
        Me.lbApellido.Size = New System.Drawing.Size(44, 13)
        Me.lbApellido.TabIndex = 9
        Me.lbApellido.Text = "Apellido"
        '
        'lbSegundoName
        '
        Me.lbSegundoName.AutoSize = True
        Me.lbSegundoName.Location = New System.Drawing.Point(210, 73)
        Me.lbSegundoName.Name = "lbSegundoName"
        Me.lbSegundoName.Size = New System.Drawing.Size(90, 13)
        Me.lbSegundoName.TabIndex = 8
        Me.lbSegundoName.Text = "Segundo Nombre"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(12, 73)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 7
        Me.lbNombre.Text = "Nombre"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(38, 44)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(18, 13)
        Me.lbID.TabIndex = 6
        Me.lbID.Text = "ID"
        '
        'cbCiudad
        '
        Me.cbCiudad.DataSource = Me.CiudadBindingSource
        Me.cbCiudad.DisplayMember = "nombreCiudad"
        Me.cbCiudad.FormattingEnabled = True
        Me.cbCiudad.Location = New System.Drawing.Point(62, 148)
        Me.cbCiudad.Name = "cbCiudad"
        Me.cbCiudad.Size = New System.Drawing.Size(121, 21)
        Me.cbCiudad.TabIndex = 9
        Me.cbCiudad.ValueMember = "idCiudad"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(347, 250)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 17
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(266, 250)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 16
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(185, 250)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'PBCatalana
        '
        Me.PBCatalana.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PBCatalana.Location = New System.Drawing.Point(590, 16)
        Me.PBCatalana.Name = "PBCatalana"
        Me.PBCatalana.Size = New System.Drawing.Size(149, 149)
        Me.PBCatalana.TabIndex = 1
        Me.PBCatalana.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(104, 250)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GbRegistroCliente
        '
        Me.GbRegistroCliente.Controls.Add(Me.DataGridView1)
        Me.GbRegistroCliente.Location = New System.Drawing.Point(12, 310)
        Me.GbRegistroCliente.Name = "GbRegistroCliente"
        Me.GbRegistroCliente.Size = New System.Drawing.Size(752, 259)
        Me.GbRegistroCliente.TabIndex = 1
        Me.GbRegistroCliente.TabStop = False
        Me.GbRegistroCliente.Text = "Tabla Cliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NumCedulaDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.SegundoNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.IdCiudadDataGridViewTextBoxColumn, Me.CelTigoDataGridViewTextBoxColumn, Me.CelClaroDataGridViewTextBoxColumn, Me.CelCootelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClienteBindingSource4
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(746, 240)
        Me.DataGridView1.TabIndex = 0
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "Cliente"
        Me.ClienteBindingSource1.DataSource = Me.CatalanaDataSet
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.CatalanaDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingSource2
        '
        Me.ClienteBindingSource2.DataMember = "Cliente"
        Me.ClienteBindingSource2.DataSource = Me.CatalanaDataSet
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'ClienteBindingSource3
        '
        Me.ClienteBindingSource3.DataMember = "Cliente"
        Me.ClienteBindingSource3.DataSource = Me.CatalanaDataSet1
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "ID CLIENTE"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumCedulaDataGridViewTextBoxColumn
        '
        Me.NumCedulaDataGridViewTextBoxColumn.DataPropertyName = "numCedula"
        Me.NumCedulaDataGridViewTextBoxColumn.HeaderText = "Numero de Cedula"
        Me.NumCedulaDataGridViewTextBoxColumn.Name = "NumCedulaDataGridViewTextBoxColumn"
        Me.NumCedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerNombreDataGridViewTextBoxColumn
        '
        Me.PrimerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.HeaderText = "Primer Nombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.Name = "PrimerNombreDataGridViewTextBoxColumn"
        Me.PrimerNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SegundoNombreDataGridViewTextBoxColumn
        '
        Me.SegundoNombreDataGridViewTextBoxColumn.DataPropertyName = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.HeaderText = "Segundo Nombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.Name = "SegundoNombreDataGridViewTextBoxColumn"
        Me.SegundoNombreDataGridViewTextBoxColumn.ReadOnly = True
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
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Correo"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCiudadDataGridViewTextBoxColumn
        '
        Me.IdCiudadDataGridViewTextBoxColumn.DataPropertyName = "idCiudad"
        Me.IdCiudadDataGridViewTextBoxColumn.HeaderText = "ID Ciudad"
        Me.IdCiudadDataGridViewTextBoxColumn.Name = "IdCiudadDataGridViewTextBoxColumn"
        Me.IdCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelTigoDataGridViewTextBoxColumn
        '
        Me.CelTigoDataGridViewTextBoxColumn.DataPropertyName = "celTigo"
        Me.CelTigoDataGridViewTextBoxColumn.HeaderText = "Cel Tigo"
        Me.CelTigoDataGridViewTextBoxColumn.Name = "CelTigoDataGridViewTextBoxColumn"
        Me.CelTigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelClaroDataGridViewTextBoxColumn
        '
        Me.CelClaroDataGridViewTextBoxColumn.DataPropertyName = "celClaro"
        Me.CelClaroDataGridViewTextBoxColumn.HeaderText = "Cel Claro"
        Me.CelClaroDataGridViewTextBoxColumn.Name = "CelClaroDataGridViewTextBoxColumn"
        Me.CelClaroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelCootelDataGridViewTextBoxColumn
        '
        Me.CelCootelDataGridViewTextBoxColumn.DataPropertyName = "celCootel"
        Me.CelCootelDataGridViewTextBoxColumn.HeaderText = "Cel Cootel"
        Me.CelCootelDataGridViewTextBoxColumn.Name = "CelCootelDataGridViewTextBoxColumn"
        Me.CelCootelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 576)
        Me.Controls.Add(Me.GbRegistroCliente)
        Me.Controls.Add(Me.GbCliente)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GbCliente.ResumeLayout(False)
        Me.GbCliente.PerformLayout()
        CType(Me.ClienteBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCatalana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbRegistroCliente.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbCliente As GroupBox
    Friend WithEvents GbRegistroCliente As GroupBox
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As CatalanaDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource1 As BindingSource
    Friend WithEvents PBCatalana As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents cbCiudad As ComboBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ClienteBindingSource2 As BindingSource
    Friend WithEvents CatalanaDataSetBindingSource As BindingSource
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents CiudadTableAdapter As CatalanaDataSetTableAdapters.ciudadTableAdapter
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtcellCootel As TextBox
    Friend WithEvents txtcellTigo As TextBox
    Friend WithEvents txtcellClaro As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtSegundoName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbClaro As Label
    Friend WithEvents lbCeltigo As Label
    Friend WithEvents lbCiudad As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents lbDomicilio As Label
    Friend WithEvents lbSegundoApe As Label
    Friend WithEvents lbApellido As Label
    Friend WithEvents lbSegundoName As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbID As Label
    Friend WithEvents lbCity As Label
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents CatalanaDataSet1 As CatalanaDataSet
    Friend WithEvents ClienteBindingSource3 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ClienteBindingSource4 As BindingSource
    Friend WithEvents txtCedu As TextBox
    Friend WithEvents lbNumCedu As Label
    Friend WithEvents btnReporte As Button
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumCedulaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimerApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SegundoApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelTigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelClaroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelCootelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
