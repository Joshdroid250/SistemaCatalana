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
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.lbIva = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PicBLogo = New System.Windows.Forms.PictureBox()
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
        Me.btnMenuPrin = New System.Windows.Forms.Button()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.PicBFoto = New System.Windows.Forms.PictureBox()
        Me.Gbfoto = New System.Windows.Forms.GroupBox()
        Me.btnBorPIC = New System.Windows.Forms.Button()
        Me.btnAgregarFoto = New System.Windows.Forms.Button()
        Me.lbFoto = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fotoPro = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet1 = New CatalanaNicv2.CatalanaDataSet()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.ProductoTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.productoTableAdapter()
        Me.GbProducto.SuspendLayout()
        CType(Me.PicBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbProductos.SuspendLayout()
        CType(Me.dataVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbfoto.SuspendLayout()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbProducto
        '
        Me.GbProducto.Controls.Add(Me.txtIva)
        Me.GbProducto.Controls.Add(Me.lbIva)
        Me.GbProducto.Controls.Add(Me.btnBuscar)
        Me.GbProducto.Controls.Add(Me.PicBLogo)
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
        Me.GbProducto.Size = New System.Drawing.Size(253, 467)
        Me.GbProducto.TabIndex = 0
        Me.GbProducto.TabStop = False
        Me.GbProducto.Text = "Registro de productos"
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
        Me.btnBuscar.Location = New System.Drawing.Point(87, 403)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(154, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'PicBLogo
        '
        Me.PicBLogo.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PicBLogo.Location = New System.Drawing.Point(55, 19)
        Me.PicBLogo.Name = "PicBLogo"
        Me.PicBLogo.Size = New System.Drawing.Size(130, 118)
        Me.PicBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBLogo.TabIndex = 14
        Me.PicBLogo.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 403)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(166, 438)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 12
        Me.btnEditar.Text = "Actualizar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(85, 438)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 438)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(85, 302)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 9
        '
        'txtDescripcionPro
        '
        Me.txtDescripcionPro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "descripPro", True))
        Me.txtDescripcionPro.Location = New System.Drawing.Point(85, 271)
        Me.txtDescripcionPro.Name = "txtDescripcionPro"
        Me.txtDescripcionPro.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcionPro.TabIndex = 8
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "PrecioProd", True))
        Me.txtPrecio.Location = New System.Drawing.Point(85, 234)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "nombreProd", True))
        Me.txtNombre.Location = New System.Drawing.Point(85, 199)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource1, "idProducto", True))
        Me.txtID.Location = New System.Drawing.Point(85, 156)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(35, 302)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(43, 13)
        Me.lbEstado.TabIndex = 4
        Me.lbEstado.Text = "Estado:"
        '
        'lbDescripcion
        '
        Me.lbDescripcion.AutoSize = True
        Me.lbDescripcion.Location = New System.Drawing.Point(16, 271)
        Me.lbDescripcion.Name = "lbDescripcion"
        Me.lbDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbDescripcion.TabIndex = 3
        Me.lbDescripcion.Text = "Descripcion:"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(42, 234)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(40, 13)
        Me.lbPrecio.TabIndex = 2
        Me.lbPrecio.Text = "Precio:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(35, 199)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(47, 13)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Nombre:"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Location = New System.Drawing.Point(61, 156)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(21, 13)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "ID:"
        '
        'GbProductos
        '
        Me.GbProductos.Controls.Add(Me.dataVProductos)
        Me.GbProductos.Location = New System.Drawing.Point(265, 211)
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.Size = New System.Drawing.Size(704, 262)
        Me.GbProductos.TabIndex = 1
        Me.GbProductos.TabStop = False
        Me.GbProductos.Text = "Productos"
        '
        'dataVProductos
        '
        Me.dataVProductos.AllowUserToAddRows = False
        Me.dataVProductos.AllowUserToDeleteRows = False
        Me.dataVProductos.AutoGenerateColumns = False
        Me.dataVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataVProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProdDataGridViewTextBoxColumn, Me.PrecioProdDataGridViewTextBoxColumn, Me.iva, Me.DescripProDataGridViewTextBoxColumn, Me.fotoPro, Me.EstadoDataGridViewTextBoxColumn})
        Me.dataVProductos.DataSource = Me.ProductoBindingSource1
        Me.dataVProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataVProductos.Location = New System.Drawing.Point(3, 16)
        Me.dataVProductos.Name = "dataVProductos"
        Me.dataVProductos.ReadOnly = True
        Me.dataVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataVProductos.Size = New System.Drawing.Size(698, 243)
        Me.dataVProductos.TabIndex = 0
        '
        'btnMenuPrin
        '
        Me.btnMenuPrin.Location = New System.Drawing.Point(858, 153)
        Me.btnMenuPrin.Name = "btnMenuPrin"
        Me.btnMenuPrin.Size = New System.Drawing.Size(108, 23)
        Me.btnMenuPrin.TabIndex = 2
        Me.btnMenuPrin.Text = "Menu Principal"
        Me.btnMenuPrin.UseVisualStyleBackColor = True
        '
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(858, 182)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(108, 23)
        Me.BtnReporte.TabIndex = 3
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'PicBFoto
        '
        Me.PicBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBFoto.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductoBindingSource1, "fotoPro", True))
        Me.PicBFoto.Location = New System.Drawing.Point(412, 34)
        Me.PicBFoto.Name = "PicBFoto"
        Me.PicBFoto.Size = New System.Drawing.Size(130, 103)
        Me.PicBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBFoto.TabIndex = 4
        Me.PicBFoto.TabStop = False
        '
        'Gbfoto
        '
        Me.Gbfoto.Controls.Add(Me.btnBorPIC)
        Me.Gbfoto.Controls.Add(Me.btnAgregarFoto)
        Me.Gbfoto.Controls.Add(Me.lbFoto)
        Me.Gbfoto.Controls.Add(Me.PicBFoto)
        Me.Gbfoto.Location = New System.Drawing.Point(265, 12)
        Me.Gbfoto.Name = "Gbfoto"
        Me.Gbfoto.Size = New System.Drawing.Size(577, 193)
        Me.Gbfoto.TabIndex = 5
        Me.Gbfoto.TabStop = False
        Me.Gbfoto.Text = "Foto"
        '
        'btnBorPIC
        '
        Me.btnBorPIC.Location = New System.Drawing.Point(183, 102)
        Me.btnBorPIC.Name = "btnBorPIC"
        Me.btnBorPIC.Size = New System.Drawing.Size(85, 23)
        Me.btnBorPIC.TabIndex = 7
        Me.btnBorPIC.Text = "Borrar Imagen"
        Me.btnBorPIC.UseVisualStyleBackColor = True
        '
        'btnAgregarFoto
        '
        Me.btnAgregarFoto.Location = New System.Drawing.Point(183, 71)
        Me.btnAgregarFoto.Name = "btnAgregarFoto"
        Me.btnAgregarFoto.Size = New System.Drawing.Size(85, 23)
        Me.btnAgregarFoto.TabIndex = 6
        Me.btnAgregarFoto.Text = "..."
        Me.btnAgregarFoto.UseVisualStyleBackColor = True
        '
        'lbFoto
        '
        Me.lbFoto.AutoSize = True
        Me.lbFoto.Location = New System.Drawing.Point(116, 71)
        Me.lbFoto.Name = "lbFoto"
        Me.lbFoto.Size = New System.Drawing.Size(28, 13)
        Me.lbFoto.TabIndex = 5
        Me.lbFoto.Text = "foto:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'iva
        '
        Me.iva.DataPropertyName = "iva"
        Me.iva.HeaderText = "iva"
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        '
        'fotoPro
        '
        Me.fotoPro.DataPropertyName = "fotoPro"
        Me.fotoPro.HeaderText = "fotoPro"
        Me.fotoPro.Name = "fotoPro"
        Me.fotoPro.ReadOnly = True
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
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProdDataGridViewTextBoxColumn
        '
        Me.NombreProdDataGridViewTextBoxColumn.DataPropertyName = "nombreProd"
        Me.NombreProdDataGridViewTextBoxColumn.HeaderText = "nombreProd"
        Me.NombreProdDataGridViewTextBoxColumn.Name = "NombreProdDataGridViewTextBoxColumn"
        Me.NombreProdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioProdDataGridViewTextBoxColumn
        '
        Me.PrecioProdDataGridViewTextBoxColumn.DataPropertyName = "PrecioProd"
        Me.PrecioProdDataGridViewTextBoxColumn.HeaderText = "PrecioProd"
        Me.PrecioProdDataGridViewTextBoxColumn.Name = "PrecioProdDataGridViewTextBoxColumn"
        Me.PrecioProdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripProDataGridViewTextBoxColumn
        '
        Me.DescripProDataGridViewTextBoxColumn.DataPropertyName = "descripPro"
        Me.DescripProDataGridViewTextBoxColumn.HeaderText = "descripPro"
        Me.DescripProDataGridViewTextBoxColumn.Name = "DescripProDataGridViewTextBoxColumn"
        Me.DescripProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
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
        'FrmProducto1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 491)
        Me.Controls.Add(Me.Gbfoto)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.btnMenuPrin)
        Me.Controls.Add(Me.GbProductos)
        Me.Controls.Add(Me.GbProducto)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(997, 530)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(997, 530)
        Me.Name = "FrmProducto1"
        Me.Text = "Producto"
        Me.GbProducto.ResumeLayout(False)
        Me.GbProducto.PerformLayout()
        CType(Me.PicBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbProductos.ResumeLayout(False)
        CType(Me.dataVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbfoto.ResumeLayout(False)
        Me.Gbfoto.PerformLayout()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbFoto As Label
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
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
