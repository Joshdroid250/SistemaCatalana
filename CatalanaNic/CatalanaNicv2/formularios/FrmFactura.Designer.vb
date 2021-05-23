<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFactura
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
        Me.gbFactura = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lbIdUser = New System.Windows.Forms.Label()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.lbIdCliente = New System.Windows.Forms.Label()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbRegistroFactura = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.ClienteTableAdapter()
        Me.UsuarioTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.UsuarioTableAdapter()
        Me.FacturaTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.FacturaTableAdapter()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.gbFactura.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRegistroFactura.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFactura
        '
        Me.gbFactura.Controls.Add(Me.btnNuevo)
        Me.gbFactura.Controls.Add(Me.lbIdUser)
        Me.gbFactura.Controls.Add(Me.lbIdCliente)
        Me.gbFactura.Controls.Add(Me.cbUsuario)
        Me.gbFactura.Controls.Add(Me.cbCliente)
        Me.gbFactura.Controls.Add(Me.btnBuscar)
        Me.gbFactura.Controls.Add(Me.btnActualizar)
        Me.gbFactura.Controls.Add(Me.btnBorrar)
        Me.gbFactura.Controls.Add(Me.btnAgregar)
        Me.gbFactura.Controls.Add(Me.txtID)
        Me.gbFactura.Controls.Add(Me.Dtpfecha)
        Me.gbFactura.Controls.Add(Me.Label4)
        Me.gbFactura.Controls.Add(Me.Label3)
        Me.gbFactura.Controls.Add(Me.Label2)
        Me.gbFactura.Controls.Add(Me.Label1)
        Me.gbFactura.Controls.Add(Me.PictureBox1)
        Me.gbFactura.Location = New System.Drawing.Point(12, 12)
        Me.gbFactura.Name = "gbFactura"
        Me.gbFactura.Size = New System.Drawing.Size(292, 501)
        Me.gbFactura.TabIndex = 0
        Me.gbFactura.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(9, 429)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lbIdUser
        '
        Me.lbIdUser.AutoSize = True
        Me.lbIdUser.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "idUsuario", True))
        Me.lbIdUser.Location = New System.Drawing.Point(127, 266)
        Me.lbIdUser.Name = "lbIdUser"
        Me.lbIdUser.Size = New System.Drawing.Size(10, 13)
        Me.lbIdUser.TabIndex = 17
        Me.lbIdUser.Text = "."
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
        'lbIdCliente
        '
        Me.lbIdCliente.AutoSize = True
        Me.lbIdCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource1, "idCliente", True))
        Me.lbIdCliente.Location = New System.Drawing.Point(127, 239)
        Me.lbIdCliente.Name = "lbIdCliente"
        Me.lbIdCliente.Size = New System.Drawing.Size(10, 13)
        Me.lbIdCliente.TabIndex = 16
        Me.lbIdCliente.Text = "."
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "Cliente"
        Me.ClienteBindingSource1.DataSource = Me.CatalanaDataSet
        '
        'cbUsuario
        '
        Me.cbUsuario.DataSource = Me.UsuarioBindingSource
        Me.cbUsuario.DisplayMember = "primerNombre"
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(143, 263)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(121, 21)
        Me.cbUsuario.TabIndex = 15
        '
        'cbCliente
        '
        Me.cbCliente.DataSource = Me.ClienteBindingSource1
        Me.cbCliente.DisplayMember = "idCliente"
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(143, 236)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cbCliente.TabIndex = 14
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(101, 429)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(171, 23)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(197, 458)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(101, 458)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 10
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(9, 458)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 9
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(143, 210)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 6
        '
        'Dtpfecha
        '
        Me.Dtpfecha.CustomFormat = "dd-MM-yy"
        Me.Dtpfecha.Location = New System.Drawing.Point(72, 290)
        Me.Dtpfecha.Name = "Dtpfecha"
        Me.Dtpfecha.Size = New System.Drawing.Size(192, 20)
        Me.Dtpfecha.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "idUsuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IdCliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(51, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "Cliente"
        Me.ClienteBindingSource.DataSource = Me.CatalanaDataSet
        '
        'gbRegistroFactura
        '
        Me.gbRegistroFactura.Controls.Add(Me.DataGridView1)
        Me.gbRegistroFactura.Location = New System.Drawing.Point(310, 98)
        Me.gbRegistroFactura.Name = "gbRegistroFactura"
        Me.gbRegistroFactura.Size = New System.Drawing.Size(435, 421)
        Me.gbRegistroFactura.TabIndex = 1
        Me.gbRegistroFactura.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFacturaDataGridViewTextBoxColumn, Me.IdUsuarioDataGridViewTextBoxColumn, Me.IdClienteDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FacturaBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(429, 402)
        Me.DataGridView1.TabIndex = 0
        '
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.CatalanaDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(666, 69)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 2
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'FrmFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 531)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.gbRegistroFactura)
        Me.Controls.Add(Me.gbFactura)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFactura"
        Me.Text = "Factura"
        Me.gbFactura.ResumeLayout(False)
        Me.gbFactura.PerformLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRegistroFactura.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbFactura As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbIdUser As Label
    Friend WithEvents lbIdCliente As Label
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Dtpfecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbRegistroFactura As GroupBox
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As CatalanaDataSetTableAdapters.ClienteTableAdapter
    Friend WithEvents ClienteBindingSource1 As BindingSource
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As CatalanaDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As CatalanaDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnReporte As Button
End Class
