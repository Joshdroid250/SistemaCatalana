<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetFactura
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
        Me.gbDetFactura = New System.Windows.Forms.GroupBox()
        Me.btnMenuPrin = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.DetFactuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.lbdFactu = New System.Windows.Forms.Label()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbIdProduc = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbFactura = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lbDescuentos = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbFactura = New System.Windows.Forms.Label()
        Me.lbIdProducto = New System.Windows.Forms.Label()
        Me.lbId = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductoTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.productoTableAdapter()
        Me.gbDetRegis = New System.Windows.Forms.GroupBox()
        Me.dtvDETFatura = New System.Windows.Forms.DataGridView()
        Me.IdDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetFactuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetFactuTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.DetFactuTableAdapter()
        Me.FacturaTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.FacturaTableAdapter()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet1 = New CatalanaNicv2.CatalanaDataSet()
        Me.FacturaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbDetFactura.SuspendLayout()
        CType(Me.DetFactuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetRegis.SuspendLayout()
        CType(Me.dtvDETFatura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetFactuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDetFactura
        '
        Me.gbDetFactura.Controls.Add(Me.btnMenuPrin)
        Me.gbDetFactura.Controls.Add(Me.txtID)
        Me.gbDetFactura.Controls.Add(Me.btnReporte)
        Me.gbDetFactura.Controls.Add(Me.lbdFactu)
        Me.gbDetFactura.Controls.Add(Me.lbIdProduc)
        Me.gbDetFactura.Controls.Add(Me.cbFactura)
        Me.gbDetFactura.Controls.Add(Me.cbProducto)
        Me.gbDetFactura.Controls.Add(Me.btnBuscar)
        Me.gbDetFactura.Controls.Add(Me.btnActualizar)
        Me.gbDetFactura.Controls.Add(Me.btnBorrar)
        Me.gbDetFactura.Controls.Add(Me.btnAgregar)
        Me.gbDetFactura.Controls.Add(Me.btnNuevo)
        Me.gbDetFactura.Controls.Add(Me.txtDescuento)
        Me.gbDetFactura.Controls.Add(Me.txtPrecio)
        Me.gbDetFactura.Controls.Add(Me.txtCantidad)
        Me.gbDetFactura.Controls.Add(Me.lbDescuentos)
        Me.gbDetFactura.Controls.Add(Me.lbPrecio)
        Me.gbDetFactura.Controls.Add(Me.lbCantidad)
        Me.gbDetFactura.Controls.Add(Me.lbFactura)
        Me.gbDetFactura.Controls.Add(Me.lbIdProducto)
        Me.gbDetFactura.Controls.Add(Me.lbId)
        Me.gbDetFactura.Controls.Add(Me.PictureBox1)
        Me.gbDetFactura.Location = New System.Drawing.Point(12, 12)
        Me.gbDetFactura.Name = "gbDetFactura"
        Me.gbDetFactura.Size = New System.Drawing.Size(619, 244)
        Me.gbDetFactura.TabIndex = 0
        Me.gbDetFactura.TabStop = False
        '
        'btnMenuPrin
        '
        Me.btnMenuPrin.Location = New System.Drawing.Point(456, 214)
        Me.btnMenuPrin.Name = "btnMenuPrin"
        Me.btnMenuPrin.Size = New System.Drawing.Size(87, 23)
        Me.btnMenuPrin.TabIndex = 13
        Me.btnMenuPrin.Text = "Menu Principal"
        Me.btnMenuPrin.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "idDetalle", True))
        Me.txtID.Location = New System.Drawing.Point(239, 38)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'DetFactuBindingSource1
        '
        Me.DetFactuBindingSource1.DataMember = "DetFactu"
        Me.DetFactuBindingSource1.DataSource = Me.CatalanaDataSet
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(456, 184)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(87, 23)
        Me.btnReporte.TabIndex = 9
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'lbdFactu
        '
        Me.lbdFactu.AutoSize = True
        Me.lbdFactu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "idFactura", True))
        Me.lbdFactu.Location = New System.Drawing.Point(345, 71)
        Me.lbdFactu.Name = "lbdFactu"
        Me.lbdFactu.Size = New System.Drawing.Size(10, 13)
        Me.lbdFactu.TabIndex = 21
        Me.lbdFactu.Text = "."
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.CatalanaDataSet
        '
        'lbIdProduc
        '
        Me.lbIdProduc.AutoSize = True
        Me.lbIdProduc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.lbIdProduc.Location = New System.Drawing.Point(548, 41)
        Me.lbIdProduc.Name = "lbIdProduc"
        Me.lbIdProduc.Size = New System.Drawing.Size(10, 13)
        Me.lbIdProduc.TabIndex = 20
        Me.lbIdProduc.Text = "."
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.CatalanaDataSet
        '
        'cbFactura
        '
        Me.cbFactura.DataSource = Me.FacturaBindingSource
        Me.cbFactura.DisplayMember = "idFactura"
        Me.cbFactura.FormattingEnabled = True
        Me.cbFactura.Location = New System.Drawing.Point(239, 64)
        Me.cbFactura.Name = "cbFactura"
        Me.cbFactura.Size = New System.Drawing.Size(99, 21)
        Me.cbFactura.TabIndex = 3
        '
        'cbProducto
        '
        Me.cbProducto.DataSource = Me.ProductoBindingSource
        Me.cbProducto.DisplayMember = "nombreProd"
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(443, 38)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(100, 21)
        Me.cbProducto.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(271, 185)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(179, 22)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(376, 214)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 22)
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(271, 213)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 22)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(190, 212)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 22)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(190, 184)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 22)
        Me.btnNuevo.TabIndex = 7
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "descuento", True))
        Me.txtDescuento.Location = New System.Drawing.Point(443, 94)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "precio", True))
        Me.txtPrecio.Location = New System.Drawing.Point(239, 91)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "cantidad", True))
        Me.txtCantidad.Location = New System.Drawing.Point(443, 68)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'lbDescuentos
        '
        Me.lbDescuentos.AutoSize = True
        Me.lbDescuentos.Location = New System.Drawing.Point(373, 97)
        Me.lbDescuentos.Name = "lbDescuentos"
        Me.lbDescuentos.Size = New System.Drawing.Size(64, 13)
        Me.lbDescuentos.TabIndex = 6
        Me.lbDescuentos.Text = "Descuentos"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(191, 94)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lbPrecio.TabIndex = 5
        Me.lbPrecio.Text = "Precio"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(388, 71)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbCantidad.TabIndex = 4
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbFactura
        '
        Me.lbFactura.AutoSize = True
        Me.lbFactura.Location = New System.Drawing.Point(171, 67)
        Me.lbFactura.Name = "lbFactura"
        Me.lbFactura.Size = New System.Drawing.Size(57, 13)
        Me.lbFactura.TabIndex = 3
        Me.lbFactura.Text = "ID Factura"
        '
        'lbIdProducto
        '
        Me.lbIdProducto.AutoSize = True
        Me.lbIdProducto.Location = New System.Drawing.Point(369, 41)
        Me.lbIdProducto.Name = "lbIdProducto"
        Me.lbIdProducto.Size = New System.Drawing.Size(64, 13)
        Me.lbIdProducto.TabIndex = 2
        Me.lbIdProducto.Text = "ID Producto"
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Location = New System.Drawing.Point(208, 41)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(18, 13)
        Me.lbId.TabIndex = 1
        Me.lbId.Text = "ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(15, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'gbDetRegis
        '
        Me.gbDetRegis.Controls.Add(Me.dtvDETFatura)
        Me.gbDetRegis.Location = New System.Drawing.Point(12, 262)
        Me.gbDetRegis.Name = "gbDetRegis"
        Me.gbDetRegis.Size = New System.Drawing.Size(619, 188)
        Me.gbDetRegis.TabIndex = 1
        Me.gbDetRegis.TabStop = False
        '
        'dtvDETFatura
        '
        Me.dtvDETFatura.AllowUserToAddRows = False
        Me.dtvDETFatura.AllowUserToDeleteRows = False
        Me.dtvDETFatura.AutoGenerateColumns = False
        Me.dtvDETFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvDETFatura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalleDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.IdFacturaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn})
        Me.dtvDETFatura.DataSource = Me.DetFactuBindingSource1
        Me.dtvDETFatura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtvDETFatura.Location = New System.Drawing.Point(3, 16)
        Me.dtvDETFatura.Name = "dtvDETFatura"
        Me.dtvDETFatura.ReadOnly = True
        Me.dtvDETFatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtvDETFatura.Size = New System.Drawing.Size(613, 169)
        Me.dtvDETFatura.TabIndex = 0
        '
        'IdDetalleDataGridViewTextBoxColumn
        '
        Me.IdDetalleDataGridViewTextBoxColumn.DataPropertyName = "idDetalle"
        Me.IdDetalleDataGridViewTextBoxColumn.HeaderText = "idDetalle"
        Me.IdDetalleDataGridViewTextBoxColumn.Name = "IdDetalleDataGridViewTextBoxColumn"
        Me.IdDetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.HeaderText = "idProducto"
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdFacturaDataGridViewTextBoxColumn
        '
        Me.IdFacturaDataGridViewTextBoxColumn.DataPropertyName = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.HeaderText = "idFactura"
        Me.IdFacturaDataGridViewTextBoxColumn.Name = "IdFacturaDataGridViewTextBoxColumn"
        Me.IdFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescuentoDataGridViewTextBoxColumn
        '
        Me.DescuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento"
        Me.DescuentoDataGridViewTextBoxColumn.HeaderText = "descuento"
        Me.DescuentoDataGridViewTextBoxColumn.Name = "DescuentoDataGridViewTextBoxColumn"
        Me.DescuentoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetFactuBindingSource
        '
        Me.DetFactuBindingSource.DataMember = "DetFactu"
        Me.DetFactuBindingSource.DataSource = Me.CatalanaDataSet
        '
        'DetFactuTableAdapter
        '
        Me.DetFactuTableAdapter.ClearBeforeFill = True
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
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
        'FacturaBindingSource1
        '
        Me.FacturaBindingSource1.DataMember = "Factura"
        Me.FacturaBindingSource1.DataSource = Me.CatalanaDataSet1
        '
        'FrmDetFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 450)
        Me.Controls.Add(Me.gbDetRegis)
        Me.Controls.Add(Me.gbDetFactura)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetFactura"
        Me.Text = "Detalle Factura"
        Me.gbDetFactura.ResumeLayout(False)
        Me.gbDetFactura.PerformLayout()
        CType(Me.DetFactuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetRegis.ResumeLayout(False)
        CType(Me.dtvDETFatura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetFactuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDetFactura As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbId As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents lbDescuentos As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbCantidad As Label
    Friend WithEvents lbFactura As Label
    Friend WithEvents lbIdProducto As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lbIdProduc As Label
    Friend WithEvents cbFactura As ComboBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As CatalanaDataSetTableAdapters.productoTableAdapter
    Friend WithEvents gbDetRegis As GroupBox
    Friend WithEvents DetFactuBindingSource As BindingSource
    Friend WithEvents DetFactuTableAdapter As CatalanaDataSetTableAdapters.DetFactuTableAdapter
    Friend WithEvents DecuestoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As CatalanaDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnMenuPrin As Button
    Friend WithEvents dtvDETFatura As DataGridView
    Friend WithEvents IdDetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetFactuBindingSource1 As BindingSource
    Friend WithEvents lbdFactu As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents CatalanaDataSet1 As CatalanaDataSet
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents FacturaBindingSource1 As BindingSource
End Class
