<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.GbProductos = New System.Windows.Forms.GroupBox()
        Me.txtDescripPro = New System.Windows.Forms.TextBox()
        Me.ProductoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaNicDataSet = New CatalanaNic.CatalanaNicDataSet()
        Me.lbDescripPro = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.lbIdProducto = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gbregistro = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalanaNicDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New CatalanaNic.CatalanaNicDataSetTableAdapters.ProductoTableAdapter()
        Me.TableAdapterManager = New CatalanaNic.CatalanaNicDataSetTableAdapters.TableAdapterManager()
        Me.DetFactuTableAdapter = New CatalanaNic.CatalanaNicDataSetTableAdapters.DetFactuTableAdapter()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKDetFactuProduc7F2BE32FBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GbProductos.SuspendLayout()
        CType(Me.ProductoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaNicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbregistro.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaNicDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKDetFactuProduc7F2BE32FBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbProductos
        '
        Me.GbProductos.Controls.Add(Me.txtDescripPro)
        Me.GbProductos.Controls.Add(Me.lbDescripPro)
        Me.GbProductos.Controls.Add(Me.PictureBox1)
        Me.GbProductos.Controls.Add(Me.btnEditar)
        Me.GbProductos.Controls.Add(Me.txtIdProducto)
        Me.GbProductos.Controls.Add(Me.lbIdProducto)
        Me.GbProductos.Controls.Add(Me.BtnNuevo)
        Me.GbProductos.Controls.Add(Me.btnBorrar)
        Me.GbProductos.Controls.Add(Me.btnAgregar)
        Me.GbProductos.Controls.Add(Me.txtEstado)
        Me.GbProductos.Controls.Add(Me.txtPrecio)
        Me.GbProductos.Controls.Add(Me.txtNombre)
        Me.GbProductos.Controls.Add(Me.Label3)
        Me.GbProductos.Controls.Add(Me.Label2)
        Me.GbProductos.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GbProductos, "GbProductos")
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.TabStop = False
        '
        'txtDescripPro
        '
        Me.txtDescripPro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource3, "descripPro", True))
        resources.ApplyResources(Me.txtDescripPro, "txtDescripPro")
        Me.txtDescripPro.Name = "txtDescripPro"
        '
        'ProductoBindingSource3
        '
        Me.ProductoBindingSource3.DataMember = "Producto"
        Me.ProductoBindingSource3.DataSource = Me.CatalanaNicDataSet
        '
        'CatalanaNicDataSet
        '
        Me.CatalanaNicDataSet.DataSetName = "CatalanaNicDataSet"
        Me.CatalanaNicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbDescripPro
        '
        resources.ApplyResources(Me.lbDescripPro, "lbDescripPro")
        Me.lbDescripPro.Name = "lbDescripPro"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNic.My.Resources.Resources.Icon_catalana
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnEditar
        '
        resources.ApplyResources(Me.btnEditar, "btnEditar")
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'txtIdProducto
        '
        Me.txtIdProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource3, "idProducto", True))
        resources.ApplyResources(Me.txtIdProducto, "txtIdProducto")
        Me.txtIdProducto.Name = "txtIdProducto"
        '
        'lbIdProducto
        '
        resources.ApplyResources(Me.lbIdProducto, "lbIdProducto")
        Me.lbIdProducto.Name = "lbIdProducto"
        '
        'BtnNuevo
        '
        resources.ApplyResources(Me.BtnNuevo, "BtnNuevo")
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        resources.ApplyResources(Me.btnBorrar, "btnBorrar")
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource3, "estado", True))
        resources.ApplyResources(Me.txtEstado, "txtEstado")
        Me.txtEstado.Name = "txtEstado"
        '
        'txtPrecio
        '
        Me.txtPrecio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource3, "precio", True))
        resources.ApplyResources(Me.txtPrecio, "txtPrecio")
        Me.txtPrecio.Name = "txtPrecio"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource3, "nombreProd", True))
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.Name = "txtNombre"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.CatalanaNicDataSet
        '
        'Gbregistro
        '
        Me.Gbregistro.Controls.Add(Me.DataGridView1)
        resources.ApplyResources(Me.Gbregistro, "Gbregistro")
        Me.Gbregistro.Name = "Gbregistro"
        Me.Gbregistro.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProductoDataGridViewTextBoxColumn, Me.NombreProdDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.DescripProDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductoBindingSource3
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        '
        'IdProductoDataGridViewTextBoxColumn
        '
        Me.IdProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto"
        resources.ApplyResources(Me.IdProductoDataGridViewTextBoxColumn, "IdProductoDataGridViewTextBoxColumn")
        Me.IdProductoDataGridViewTextBoxColumn.Name = "IdProductoDataGridViewTextBoxColumn"
        Me.IdProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreProdDataGridViewTextBoxColumn
        '
        Me.NombreProdDataGridViewTextBoxColumn.DataPropertyName = "nombreProd"
        resources.ApplyResources(Me.NombreProdDataGridViewTextBoxColumn, "NombreProdDataGridViewTextBoxColumn")
        Me.NombreProdDataGridViewTextBoxColumn.Name = "NombreProdDataGridViewTextBoxColumn"
        Me.NombreProdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        resources.ApplyResources(Me.PrecioDataGridViewTextBoxColumn, "PrecioDataGridViewTextBoxColumn")
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        resources.ApplyResources(Me.EstadoDataGridViewTextBoxColumn, "EstadoDataGridViewTextBoxColumn")
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripProDataGridViewTextBoxColumn
        '
        Me.DescripProDataGridViewTextBoxColumn.DataPropertyName = "descripPro"
        resources.ApplyResources(Me.DescripProDataGridViewTextBoxColumn, "DescripProDataGridViewTextBoxColumn")
        Me.DescripProDataGridViewTextBoxColumn.Name = "DescripProDataGridViewTextBoxColumn"
        Me.DescripProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'CatalanaNicDataSetBindingSource
        '
        Me.CatalanaNicDataSetBindingSource.DataSource = Me.CatalanaNicDataSet
        Me.CatalanaNicDataSetBindingSource.Position = 0
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CiudadTableAdapter = Nothing
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DetFactuTableAdapter = Nothing
        Me.TableAdapterManager.FacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = CatalanaNic.CatalanaNicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'DetFactuTableAdapter
        '
        Me.DetFactuTableAdapter.ClearBeforeFill = True
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "Producto"
        Me.ProductoBindingSource1.DataSource = Me.CatalanaNicDataSetBindingSource
        '
        'ProductoBindingSource2
        '
        Me.ProductoBindingSource2.DataMember = "Producto"
        Me.ProductoBindingSource2.DataSource = Me.CatalanaNicDataSetBindingSource
        '
        'FKDetFactuProduc7F2BE32FBindingSource
        '
        Me.FKDetFactuProduc7F2BE32FBindingSource.DataMember = "FK__DetFactu__Produc__7F2BE32F"
        Me.FKDetFactuProduc7F2BE32FBindingSource.DataSource = Me.ProductoBindingSource
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.Name = "txtBuscar"
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmProducto
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Gbregistro)
        Me.Controls.Add(Me.GbProductos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProducto"
        Me.GbProductos.ResumeLayout(False)
        Me.GbProductos.PerformLayout()
        CType(Me.ProductoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaNicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbregistro.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaNicDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKDetFactuProduc7F2BE32FBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbProductos As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Gbregistro As GroupBox
    Friend WithEvents CatalanaNicDataSetBindingSource As BindingSource
    Friend WithEvents CatalanaNicDataSet As CatalanaNicDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As CatalanaNicDataSetTableAdapters.ProductoTableAdapter
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TableAdapterManager As CatalanaNicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents lbIdProducto As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents FKDetFactuProduc7F2BE32FBindingSource As BindingSource
    Friend WithEvents DetFactuTableAdapter As CatalanaNicDataSetTableAdapters.DetFactuTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreProdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource2 As BindingSource
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents ProductoBindingSource3 As BindingSource
    Friend WithEvents txtDescripPro As TextBox
    Friend WithEvents lbDescripPro As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
End Class
