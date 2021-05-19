<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCiudad
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaDataSet = New CatalanaNicv2.CatalanaDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.GbCiudad = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tlbNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.CiudadTableAdapter = New CatalanaNicv2.CatalanaDataSetTableAdapters.ciudadTableAdapter()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCiudad.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 397)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabla Ciudad"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCiudadDataGridViewTextBoxColumn, Me.NombreCiudadDataGridViewTextBoxColumn, Me.EstadoCiudadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CiudadBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(348, 378)
        Me.DataGridView1.TabIndex = 0
        '
        'IdCiudadDataGridViewTextBoxColumn
        '
        Me.IdCiudadDataGridViewTextBoxColumn.DataPropertyName = "idCiudad"
        Me.IdCiudadDataGridViewTextBoxColumn.HeaderText = "idCiudad"
        Me.IdCiudadDataGridViewTextBoxColumn.Name = "IdCiudadDataGridViewTextBoxColumn"
        Me.IdCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreCiudadDataGridViewTextBoxColumn
        '
        Me.NombreCiudadDataGridViewTextBoxColumn.DataPropertyName = "nombreCiudad"
        Me.NombreCiudadDataGridViewTextBoxColumn.HeaderText = "nombreCiudad"
        Me.NombreCiudadDataGridViewTextBoxColumn.Name = "NombreCiudadDataGridViewTextBoxColumn"
        Me.NombreCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoCiudadDataGridViewTextBoxColumn
        '
        Me.EstadoCiudadDataGridViewTextBoxColumn.DataPropertyName = "estadoCiudad"
        Me.EstadoCiudadDataGridViewTextBoxColumn.HeaderText = "estadoCiudad"
        Me.EstadoCiudadDataGridViewTextBoxColumn.Name = "EstadoCiudadDataGridViewTextBoxColumn"
        Me.EstadoCiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadBindingSource
        '
        Me.CiudadBindingSource.DataMember = "ciudad"
        Me.CiudadBindingSource.DataSource = Me.CatalanaDataSet
        '
        'CatalanaDataSet
        '
        Me.CatalanaDataSet.DataSetName = "CatalanaDataSet"
        Me.CatalanaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNicv2.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(44, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(6, 424)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(6, 453)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(87, 453)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(168, 453)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 4
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'GbCiudad
        '
        Me.GbCiudad.Controls.Add(Me.btnBuscar)
        Me.GbCiudad.Controls.Add(Me.txtEstado)
        Me.GbCiudad.Controls.Add(Me.txtNombre)
        Me.GbCiudad.Controls.Add(Me.txtID)
        Me.GbCiudad.Controls.Add(Me.lbEstado)
        Me.GbCiudad.Controls.Add(Me.tlbNombre)
        Me.GbCiudad.Controls.Add(Me.Label1)
        Me.GbCiudad.Controls.Add(Me.btnActualizar)
        Me.GbCiudad.Controls.Add(Me.btnBorrar)
        Me.GbCiudad.Controls.Add(Me.btnAgregar)
        Me.GbCiudad.Controls.Add(Me.btnNuevo)
        Me.GbCiudad.Controls.Add(Me.PictureBox1)
        Me.GbCiudad.Location = New System.Drawing.Point(12, 12)
        Me.GbCiudad.Name = "GbCiudad"
        Me.GbCiudad.Size = New System.Drawing.Size(252, 501)
        Me.GbCiudad.TabIndex = 0
        Me.GbCiudad.TabStop = False
        Me.GbCiudad.Text = "Ciudad"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(87, 424)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(156, 23)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(71, 256)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(123, 20)
        Me.txtEstado.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(71, 226)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(123, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(71, 190)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(123, 20)
        Me.txtID.TabIndex = 8
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(25, 256)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(40, 13)
        Me.lbEstado.TabIndex = 7
        Me.lbEstado.Text = "Estado"
        '
        'tlbNombre
        '
        Me.tlbNombre.AutoSize = True
        Me.tlbNombre.Location = New System.Drawing.Point(25, 226)
        Me.tlbNombre.Name = "tlbNombre"
        Me.tlbNombre.Size = New System.Drawing.Size(44, 13)
        Me.tlbNombre.TabIndex = 6
        Me.tlbNombre.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(513, 87)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(102, 23)
        Me.btnReporte.TabIndex = 2
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(513, 54)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(102, 23)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.Text = "Menu Principal"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 525)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbCiudad)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCiudad"
        Me.Text = "Ciudad"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCiudad.ResumeLayout(False)
        Me.GbCiudad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CatalanaDataSet As CatalanaDataSet
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents CiudadTableAdapter As CatalanaDataSetTableAdapters.ciudadTableAdapter
    Friend WithEvents IdCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents GbCiudad As GroupBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents tlbNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnReporte As Button
    Friend WithEvents btnMenu As Button
End Class
