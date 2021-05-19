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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.productoTableAdapter()
        Me.btnMenuPrin = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.GbProducto.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbProductos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbProducto
        '
        Me.GbProducto.Controls.Add(Me.btnBuscar)
        Me.GbProducto.Controls.Add(Me.PictureBox1)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(55, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "estado", True))
        Me.txtEstado.Location = New System.Drawing.Point(85, 302)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 9
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
        'txtDescripcionPro
        '
        Me.txtDescripcionPro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripPro", True))
        Me.txtDescripcionPro.Location = New System.Drawing.Point(85, 271)
        Me.txtDescripcionPro.Name = "txtDescripcionPro"
        Me.txtDescripcionPro.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcionPro.TabIndex = 8
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "PrecioProd", True))
        Me.txtPrecio.Location = New System.Drawing.Point(85, 234)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombreProd", True))
        Me.txtNombre.Location = New System.Drawing.Point(85, 199)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "idProducto", True))
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
        Me.GbProductos.Controls.Add(Me.DataGridView1)
        Me.GbProductos.Location = New System.Drawing.Point(265, 81)
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.Size = New System.Drawing.Size(523, 392)
        Me.GbProductos.TabIndex = 1
        Me.GbProductos.TabStop = False
        Me.GbProductos.Text = "Productos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProdDataGridViewTextBoxColumn, Me.PrecioProdDataGridViewTextBoxColumn, Me.DescripProDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(517, 373)
        Me.DataGridView1.TabIndex = 0
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
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'btnMenuPrin
        '
        Me.btnMenuPrin.Location = New System.Drawing.Point(677, 12)
        Me.btnMenuPrin.Name = "btnMenuPrin"
        Me.btnMenuPrin.Size = New System.Drawing.Size(108, 23)
        Me.btnMenuPrin.TabIndex = 2
        Me.btnMenuPrin.Text = "Menu Principal"
        Me.btnMenuPrin.UseVisualStyleBackColor = True
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
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(677, 52)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(108, 23)
        Me.BtnReporte.TabIndex = 3
        Me.BtnReporte.Text = "Reporte"
        Me.BtnReporte.UseVisualStyleBackColor = True
        '
        'FrmProducto1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 491)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.btnMenuPrin)
        Me.Controls.Add(Me.GbProductos)
        Me.Controls.Add(Me.GbProducto)
        Me.Name = "FrmProducto1"
        Me.Text = "FrmProducto1"
        Me.GbProducto.ResumeLayout(False)
        Me.GbProducto.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbProductos.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbProducto As GroupBox
    Friend WithEvents GbProductos As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnMenuPrin As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BtnReporte As Button
End Class
