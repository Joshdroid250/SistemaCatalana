<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Me.GbCliente = New System.Windows.Forms.GroupBox()
        Me.GbRegistroCliente = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.ClienteTableAdapter()
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
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbRegistroCliente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbCliente
        '
        Me.GbCliente.Location = New System.Drawing.Point(12, 12)
        Me.GbCliente.Name = "GbCliente"
        Me.GbCliente.Size = New System.Drawing.Size(200, 454)
        Me.GbCliente.TabIndex = 0
        Me.GbCliente.TabStop = False
        Me.GbCliente.Text = "Cliente"
        '
        'GbRegistroCliente
        '
        Me.GbRegistroCliente.Controls.Add(Me.DataGridView1)
        Me.GbRegistroCliente.Location = New System.Drawing.Point(218, 56)
        Me.GbRegistroCliente.Name = "GbRegistroCliente"
        Me.GbRegistroCliente.Size = New System.Drawing.Size(570, 410)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdClienteDataGridViewTextBoxColumn, Me.NumCedulaDataGridViewTextBoxColumn, Me.PrimerNombreDataGridViewTextBoxColumn, Me.SegundoNombreDataGridViewTextBoxColumn, Me.PrimerApellidoDataGridViewTextBoxColumn, Me.SegundoApellidoDataGridViewTextBoxColumn, Me.DomicilioDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.IdCiudadDataGridViewTextBoxColumn, Me.CelTigoDataGridViewTextBoxColumn, Me.CelClaroDataGridViewTextBoxColumn, Me.CelCootelDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClienteBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(564, 391)
        Me.DataGridView1.TabIndex = 0
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'IdClienteDataGridViewTextBoxColumn
        '
        Me.IdClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.HeaderText = "idCliente"
        Me.IdClienteDataGridViewTextBoxColumn.Name = "IdClienteDataGridViewTextBoxColumn"
        Me.IdClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumCedulaDataGridViewTextBoxColumn
        '
        Me.NumCedulaDataGridViewTextBoxColumn.DataPropertyName = "numCedula"
        Me.NumCedulaDataGridViewTextBoxColumn.HeaderText = "numCedula"
        Me.NumCedulaDataGridViewTextBoxColumn.Name = "NumCedulaDataGridViewTextBoxColumn"
        Me.NumCedulaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimerNombreDataGridViewTextBoxColumn
        '
        Me.PrimerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.HeaderText = "primerNombre"
        Me.PrimerNombreDataGridViewTextBoxColumn.Name = "PrimerNombreDataGridViewTextBoxColumn"
        Me.PrimerNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SegundoNombreDataGridViewTextBoxColumn
        '
        Me.SegundoNombreDataGridViewTextBoxColumn.DataPropertyName = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.HeaderText = "segundoNombre"
        Me.SegundoNombreDataGridViewTextBoxColumn.Name = "SegundoNombreDataGridViewTextBoxColumn"
        Me.SegundoNombreDataGridViewTextBoxColumn.ReadOnly = True
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
        'DomicilioDataGridViewTextBoxColumn
        '
        Me.DomicilioDataGridViewTextBoxColumn.DataPropertyName = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.HeaderText = "domicilio"
        Me.DomicilioDataGridViewTextBoxColumn.Name = "DomicilioDataGridViewTextBoxColumn"
        Me.DomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCiudadDataGridViewTextBoxColumn
        '
        Me.IdCiudadDataGridViewTextBoxColumn.DataPropertyName = "idCiudad"
        Me.IdCiudadDataGridViewTextBoxColumn.HeaderText = "idCiudad"
        Me.IdCiudadDataGridViewTextBoxColumn.Name = "IdCiudadDataGridViewTextBoxColumn"
        Me.IdCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelTigoDataGridViewTextBoxColumn
        '
        Me.CelTigoDataGridViewTextBoxColumn.DataPropertyName = "celTigo"
        Me.CelTigoDataGridViewTextBoxColumn.HeaderText = "celTigo"
        Me.CelTigoDataGridViewTextBoxColumn.Name = "CelTigoDataGridViewTextBoxColumn"
        Me.CelTigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelClaroDataGridViewTextBoxColumn
        '
        Me.CelClaroDataGridViewTextBoxColumn.DataPropertyName = "celClaro"
        Me.CelClaroDataGridViewTextBoxColumn.HeaderText = "celClaro"
        Me.CelClaroDataGridViewTextBoxColumn.Name = "CelClaroDataGridViewTextBoxColumn"
        Me.CelClaroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelCootelDataGridViewTextBoxColumn
        '
        Me.CelCootelDataGridViewTextBoxColumn.DataPropertyName = "celCootel"
        Me.CelCootelDataGridViewTextBoxColumn.HeaderText = "celCootel"
        Me.CelCootelDataGridViewTextBoxColumn.Name = "CelCootelDataGridViewTextBoxColumn"
        Me.CelCootelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(Me.GbRegistroCliente)
        Me.Controls.Add(Me.GbCliente)
        Me.Name = "FrmCliente"
        Me.Text = "FrmCliente"
        Me.GbRegistroCliente.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbCliente As GroupBox
    Friend WithEvents GbRegistroCliente As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As CatalanaDataSetTableAdapters.ClienteTableAdapter
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
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
