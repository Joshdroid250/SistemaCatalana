﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.gb = New System.Windows.Forms.GroupBox()
        Me.lbdFactu = New System.Windows.Forms.Label()
        Me.lbIdProduc = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.cbFactura = New System.Windows.Forms.ComboBox()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescuentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetFactuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetFactuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetFactuTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.DetFactuTableAdapter()
        Me.FacturaTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.FacturaTableAdapter()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnMenuPrin = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.gb.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetRegis.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetFactuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetFactuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb
        '
        Me.gb.Controls.Add(Me.txtID)
        Me.gb.Controls.Add(Me.lbdFactu)
        Me.gb.Controls.Add(Me.lbIdProduc)
        Me.gb.Controls.Add(Me.cbFactura)
        Me.gb.Controls.Add(Me.cbProducto)
        Me.gb.Controls.Add(Me.btnBuscar)
        Me.gb.Controls.Add(Me.btnActualizar)
        Me.gb.Controls.Add(Me.btnBorrar)
        Me.gb.Controls.Add(Me.btnAgregar)
        Me.gb.Controls.Add(Me.btnNuevo)
        Me.gb.Controls.Add(Me.txtDescuento)
        Me.gb.Controls.Add(Me.txtPrecio)
        Me.gb.Controls.Add(Me.txtCantidad)
        Me.gb.Controls.Add(Me.lbDescuentos)
        Me.gb.Controls.Add(Me.lbPrecio)
        Me.gb.Controls.Add(Me.lbCantidad)
        Me.gb.Controls.Add(Me.lbFactura)
        Me.gb.Controls.Add(Me.lbIdProducto)
        Me.gb.Controls.Add(Me.lbId)
        Me.gb.Controls.Add(Me.PictureBox1)
        Me.gb.Location = New System.Drawing.Point(12, 12)
        Me.gb.Name = "gb"
        Me.gb.Size = New System.Drawing.Size(294, 426)
        Me.gb.TabIndex = 0
        Me.gb.TabStop = False
        '
        'lbdFactu
        '
        Me.lbdFactu.AutoSize = True
        Me.lbdFactu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "idFactura", True))
        Me.lbdFactu.Location = New System.Drawing.Point(225, 243)
        Me.lbdFactu.Name = "lbdFactu"
        Me.lbdFactu.Size = New System.Drawing.Size(10, 13)
        Me.lbdFactu.TabIndex = 21
        Me.lbdFactu.Text = "."
        '
        'lbIdProduc
        '
        Me.lbIdProduc.AutoSize = True
        Me.lbIdProduc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
        Me.lbIdProduc.Location = New System.Drawing.Point(224, 212)
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
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbFactura
        '
        Me.cbFactura.DataSource = Me.FacturaBindingSource
        Me.cbFactura.DisplayMember = "idFactura"
        Me.cbFactura.FormattingEnabled = True
        Me.cbFactura.Location = New System.Drawing.Point(119, 236)
        Me.cbFactura.Name = "cbFactura"
        Me.cbFactura.Size = New System.Drawing.Size(99, 21)
        Me.cbFactura.TabIndex = 19
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.CatalanaDataSet
        '
        'cbProducto
        '
        Me.cbProducto.DataSource = Me.ProductoBindingSource
        Me.cbProducto.DisplayMember = "nombreProd"
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(119, 209)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(100, 21)
        Me.cbProducto.TabIndex = 18
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(109, 354)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(179, 23)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar por ID"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(213, 383)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(109, 383)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 383)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 354)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "descuento", True))
        Me.txtDescuento.Location = New System.Drawing.Point(119, 312)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 12
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "precio", True))
        Me.txtPrecio.Location = New System.Drawing.Point(118, 286)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 11
        '
        'txtCantidad
        '
        Me.txtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "cantidad", True))
        Me.txtCantidad.Location = New System.Drawing.Point(119, 260)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 10
        '
        'lbDescuentos
        '
        Me.lbDescuentos.AutoSize = True
        Me.lbDescuentos.Location = New System.Drawing.Point(49, 315)
        Me.lbDescuentos.Name = "lbDescuentos"
        Me.lbDescuentos.Size = New System.Drawing.Size(64, 13)
        Me.lbDescuentos.TabIndex = 6
        Me.lbDescuentos.Text = "Descuentos"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(70, 289)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lbPrecio.TabIndex = 5
        Me.lbPrecio.Text = "Precio"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(64, 263)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbCantidad.TabIndex = 4
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbFactura
        '
        Me.lbFactura.AutoSize = True
        Me.lbFactura.Location = New System.Drawing.Point(52, 239)
        Me.lbFactura.Name = "lbFactura"
        Me.lbFactura.Size = New System.Drawing.Size(57, 13)
        Me.lbFactura.TabIndex = 3
        Me.lbFactura.Text = "ID Factura"
        '
        'lbIdProducto
        '
        Me.lbIdProducto.AutoSize = True
        Me.lbIdProducto.Location = New System.Drawing.Point(45, 212)
        Me.lbIdProducto.Name = "lbIdProducto"
        Me.lbIdProducto.Size = New System.Drawing.Size(64, 13)
        Me.lbIdProducto.TabIndex = 2
        Me.lbIdProducto.Text = "ID Producto"
        '
        'lbId
        '
        Me.lbId.AutoSize = True
        Me.lbId.Location = New System.Drawing.Point(89, 185)
        Me.lbId.Name = "lbId"
        Me.lbId.Size = New System.Drawing.Size(18, 13)
        Me.lbId.TabIndex = 1
        Me.lbId.Text = "ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(68, 19)
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
        Me.gbDetRegis.Controls.Add(Me.DataGridView1)
        Me.gbDetRegis.Location = New System.Drawing.Point(312, 81)
        Me.gbDetRegis.Name = "gbDetRegis"
        Me.gbDetRegis.Size = New System.Drawing.Size(476, 357)
        Me.gbDetRegis.TabIndex = 1
        Me.gbDetRegis.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDetalleDataGridViewTextBoxColumn, Me.IdProductoDataGridViewTextBoxColumn, Me.IdFacturaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.DescuentoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetFactuBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(470, 338)
        Me.DataGridView1.TabIndex = 0
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
        'DetFactuBindingSource1
        '
        Me.DetFactuBindingSource1.DataMember = "DetFactu"
        Me.DetFactuBindingSource1.DataSource = Me.CatalanaDataSet
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
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(577, 52)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(75, 23)
        Me.btnReporte.TabIndex = 2
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'btnMenuPrin
        '
        Me.btnMenuPrin.Location = New System.Drawing.Point(687, 52)
        Me.btnMenuPrin.Name = "btnMenuPrin"
        Me.btnMenuPrin.Size = New System.Drawing.Size(87, 23)
        Me.btnMenuPrin.TabIndex = 3
        Me.btnMenuPrin.Text = "Menu Principal"
        Me.btnMenuPrin.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetFactuBindingSource1, "idDetalle", True))
        Me.txtID.Location = New System.Drawing.Point(119, 183)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 22
        '
        'FrmDetFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMenuPrin)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.gbDetRegis)
        Me.Controls.Add(Me.gb)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetFactura"
        Me.Text = "Detalle Factura"
        Me.gb.ResumeLayout(False)
        Me.gb.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetRegis.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetFactuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetFactuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb As GroupBox
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescuentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetFactuBindingSource1 As BindingSource
    Friend WithEvents lbdFactu As Label
    Friend WithEvents txtID As TextBox
End Class
