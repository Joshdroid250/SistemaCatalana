<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto1
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
        Me.GbProducto = New System.Windows.Forms.GroupBox()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.Gbfoto = New System.Windows.Forms.GroupBox()
        Me.btnBorPIC = New System.Windows.Forms.Button()
        Me.btnAgregarFoto = New System.Windows.Forms.Button()
        Me.PicBFoto = New System.Windows.Forms.PictureBox()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet1 = New CatalanaNicv2.CatalanaDataSet()
        Me.btnMenuPrin = New System.Windows.Forms.Button()
        Me.PicBLogo = New System.Windows.Forms.PictureBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.lbIva = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtDescripcionPro = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.lbDescripcion = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.GbProductos = New System.Windows.Forms.GroupBox()
        Me.dataVProductos = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.ProductoTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.productoTableAdapter()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoPro = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GbProducto.SuspendLayout()
        Me.Gbfoto.SuspendLayout()
        CType(Me.PicBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbProductos.SuspendLayout()
        CType(Me.dataVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbProducto
        '
        Me.GbProducto.Controls.Add(Me.BtnReporte)
        Me.GbProducto.Controls.Add(Me.Gbfoto)
        Me.GbProducto.Controls.Add(Me.btnMenuPrin)
        Me.GbProducto.Controls.Add(Me.PicBLogo)
        Me.GbProducto.Controls.Add(Me.txtIva)
        Me.GbProducto.Controls.Add(Me.lbIva)
        Me.GbProducto.Controls.Add(Me.btnBuscar)
        Me.GbProducto.Controls.Add(Me.btnNuevo)
        Me.GbProducto.Controls.Add(Me.btnEditar)
        Me.GbProducto.Controls.Add(Me.btnBorrar)
        Me.GbProducto.Controls.Add(Me.btnAgregar)
        Me.GbProducto.Controls.Add(Me.txtEstado)
        Me.GbProducto.Controls.Add(Me.txtDescripcionPro)
        Me.GbProducto.Controls.Add(Me.txtPrecio)
        Me.GbProducto.Controls.Add(Me.txtNombre)
        Me.GbProducto.Controls.Add(Me.txtID)
        Me.GbProducto.Controls.Add(Me.lbEstado)
        Me.GbProducto.Controls.Add(Me.lbDescripcion)
        Me.GbProducto.Controls.Add(Me.lbPrecio)
        Me.GbProducto.Controls.Add(Me.lbNombre)
        Me.GbProducto.Controls.Add(Me.lbID)
        Me.GbProducto.Location = New System.Drawing.Point(6, 12)
        Me.GbProducto.Name = "GbProducto"
        Me.GbProducto.Size = New System.Drawing.Size(751, 236)
        Me.GbProducto.TabIndex = 0
        Me.GbProducto.TabStop = False
        Me.GbProducto.Text = "Registro de productos"
        '
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(376, 159)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(108, 23)
        Me.BtnReporte.TabIndex = 3
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'Gbfoto
        '
        Me.Gbfoto.Controls.Add(Me.btnBorPIC)
        Me.Gbfoto.Controls.Add(Me.btnAgregarFoto)
        Me.Gbfoto.Controls.Add(Me.PicBFoto)
        Me.Gbfoto.Location = New System.Drawing.Point(341, 19)
        Me.Gbfoto.Name = "Gbfoto"
        Me.Gbfoto.Size = New System.Drawing.Size(275, 134)
        Me.Gbfoto.TabIndex = 5
        Me.Gbfoto.TabStop = False
        Me.Gbfoto.Text = "Foto"
        '
        'btnBorPIC
        '
        Me.btnBorPIC.Location = New System.Drawing.Point(21, 56)
        Me.btnBorPIC.Name = "btnBorPIC"
        Me.btnBorPIC.Size = New System.Drawing.Size(85, 23)
        Me.btnBorPIC.TabIndex = 7
        Me.btnBorPIC.Text = "Borrar Imagen"
        Me.btnBorPIC.UseVisualStyleBackColor = True
        '
        'btnAgregarFoto
        '
        Me.btnAgregarFoto.Location = New System.Drawing.Point(21, 95)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(85, 23)
        Me.btnAgregarFoto.TabIndex = 6
        Me.btnAgregarFoto.Text = "..."
        Me.btnAgregarFoto.UseVisualStyleBackColor = True
        '
        'PicBFoto
        '
        Me.PicBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBFoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductoBindingSource1, "fotoPro", True))
        Me.PicBFoto.Location = New System.Drawing.Point(148, 18)
        Me.PicBFoto.Name = "PicBFoto"
        Me.PicBFoto.Size = New System.Drawing.Size(117, 108)
        Me.PicBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBFoto.TabIndex = 4
        Me.PicBFoto.TabStop = False
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "producto"
        Me.ProductoBindingSource1.DataSource = Me.CatalanaDataSet1
        '
        'CatalanaDataSet1
        '
        Me.CatalanaDataSet1.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnMenuPrin
        '
        Me.btnMenuPrin.Location = New System.Drawing.Point(508, 159)
        Me.btnMenuPrin.Name = "btnMenuPrin"
        Me.btnMenuPrin.Size = New System.Drawing.Size(108, 23)
        Me.btnMenuPrin.TabIndex = 2
        Me.btnMenuPrin.Text = "Menu Principal"
        Me.btnMenuPrin.UseVisualStyleBackColor = True
        '
        'PicBLogo
        '
        Me.PicBLogo.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PicBLogo.Location = New System.Drawing.Point(622, 25)
        Me.PicBLogo.Name = "PicBLogo"
        Me.PicBLogo.Size = New System.Drawing.Size(123, 128)
        Me.PicBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBLogo.TabIndex = 14
        Me.PicBLogo.TabStop = False
        '
        'txtIva
        '
        Me.txtIva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "iva", True))
        Me.txtIva.Location = New System.Drawing.Point(87, 337)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(98, 20)
        Me.txtIva.TabIndex = 17
        '
        'lbIva
        '
        Me.lbIva.AutoSize = True
        Me.lbIva.Location = New System.Drawing.Point(52, 337)
        Me.lbIva.Name = "lbIva"
        Me.lbIva.Size = New System.Drawing.Size(24, 13)
        Me.lbIva.TabIndex = 16
        Me.lbIva.Text = "iva:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(462, 207)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(154, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(138, 207)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(381, 207)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Actualizar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(300, 207)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(219, 207)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(55, 121)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 9
        '
        'txtDescripcionPro
        '
        Me.txtDescripcionPro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "descripPro", True))
        Me.txtDescripcionPro.Location = New System.Drawing.Point(235, 81)
        Me.txtDescripcionPro.Name = "txtDescripcionPro"
        Me.txtDescripcionPro.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcionPro.TabIndex = 8
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "PrecioProd", True))
        Me.txtPrecio.Location = New System.Drawing.Point(55, 81)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "nombreProd", True))
        Me.txtNombre.Location = New System.Drawing.Point(235, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "idProducto", True))
        Me.txtID.Location = New System.Drawing.Point(55, 37)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(6, 124)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 4
        Me.lbEstado.Text = "Estado:"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(163, 85)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 3
        Me.lbDescripcion.Text = "Descripcion:"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(6, 85)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lbPrecio.TabIndex = 2
        Me.lbPrecio.Text = "Precio:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(182, 40)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Nombre:"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(25, 40)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(21, 13)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "ID:"
        '
        'GbProductos
        '
        Me.GbProductos.Controls.Add(Me.dataVProductos)
        Me.GbProductos.Location = New System.Drawing.Point(6, 254)
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.Size = New System.Drawing.Size(751, 325)
        Me.GbProductos.TabIndex = 1
        Me.GbProductos.TabStop = False
        Me.GbProductos.Text = "Productos"
        '
        'dataVProductos
        '
        Me.dataVProductos.AllowUserToAddRows = False
        Me.dataVProductos.AllowUserToDeleteRows = False
        Me.dataVProductos.AutoGenerateColumns = False
        Me.dataVProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dataVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataVProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProdDataGridViewTextBoxColumn, Me.PrecioProdDataGridViewTextBoxColumn, Me.iva, Me.DescripProDataGridViewTextBoxColumn, Me.fotoPro})
        Me.dataVProductos.DataSource = Me.ProductoBindingSource1
        Me.dataVProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataVProductos.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dataVProductos.Location = New System.Drawing.Point(3, 16)
        Me.dataVProductos.Name = "dataVProductos"
        Me.dataVProductos.ReadOnly = True
        Me.dataVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataVProductos.Size = New System.Drawing.Size(745, 306)
        Me.dataVProductos.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.CatalanaDataSet
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProdDataGridViewTextBoxColumn
        '
        Me.NombreProdDataGridViewTextBoxColumn.DataPropertyName = "nombreProd"
        Me.NombreProdDataGridViewTextBoxColumn.HeaderText = "Nombre de producto"
        Me.NombreProdDataGridViewTextBoxColumn.Name = "NombreProdDataGridViewTextBoxColumn"
        Me.NombreProdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioProdDataGridViewTextBoxColumn
        '
        Me.PrecioProdDataGridViewTextBoxColumn.DataPropertyName = "PrecioProd"
        Me.PrecioProdDataGridViewTextBoxColumn.HeaderText = "Precio de producto"
        Me.PrecioProdDataGridViewTextBoxColumn.Name = "PrecioProdDataGridViewTextBoxColumn"
        Me.PrecioProdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'iva
        '
        Me.iva.DataPropertyName = "iva"
        Me.iva.HeaderText = "Iva"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        '
        'DescripProDataGridViewTextBoxColumn
        '
        Me.DescripProDataGridViewTextBoxColumn.DataPropertyName = "descripPro"
        Me.DescripProDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripProDataGridViewTextBoxColumn.Name = "DescripProDataGridViewTextBoxColumn"
        Me.DescripProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'fotoPro
        '
        Me.fotoPro.DataPropertyName = "fotoPro"
        Me.fotoPro.HeaderText = "Foto"
        Me.fotoPro.Name = "fotoPro"
        Me.fotoPro.ReadOnly = True
        '
        'FrmProducto1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 591)
        Me.Controls.Add(Me.GbProductos)
        Me.Controls.Add(Me.GbProducto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProducto1"
        Me.Text = "Producto"
        Me.GbProducto.ResumeLayout(False)
        Me.GbProducto.PerformLayout()
        Me.Gbfoto.ResumeLayout(False)
        CType(Me.PicBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbProductos.ResumeLayout(False)
        CType(Me.dataVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbProducto As GroupBox
    Friend WithEvents GbProductos As GroupBox
    Friend WithEvents dataVProductos As DataGridView
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As CatalanaDataSetTableAdapters.productoTableAdapter
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtDescripcionPro As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents lbDescripcion As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbID As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PicBLogo As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnMenuPrin As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BtnReporte As Button
    Friend WithEvents PicBFoto As PictureBox
    Friend WithEvents Gbfoto As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbIva As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents btnAgregarFoto As Button
    Friend WithEvents btnBorPIC As Button
    Friend WithEvents CatalanaDataSet1 As CatalanaDataSet
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents DescripProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents fotoPro As DataGridViewImageColumn
End Class
