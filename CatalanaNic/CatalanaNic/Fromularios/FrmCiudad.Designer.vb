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
        Me.GbRCiudad = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatalanaNicDataSet = New CatalanaNic.CatalanaNicDataSet()
        Me.GbCiudad = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtEstadoCiu = New System.Windows.Forms.TextBox()
        Me.txtNombreCiu = New System.Windows.Forms.TextBox()
        Me.txtIdciudad = New System.Windows.Forms.TextBox()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.lbNombreCu = New System.Windows.Forms.Label()
        Me.lbIdCiudad = New System.Windows.Forms.Label()
        Me.CiudadTableAdapter = New CatalanaNic.CatalanaNicDataSetTableAdapters.CiudadTableAdapter()
        Me.GbRCiudad.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalanaNicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCiudad.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbRCiudad
        '
        Me.GbRCiudad.Controls.Add(Me.DataGridView1)
        Me.GbRCiudad.Location = New System.Drawing.Point(405, 87)
        Me.GbRCiudad.Name = "GbRCiudad"
        Me.GbRCiudad.Size = New System.Drawing.Size(337, 305)
        Me.GbRCiudad.TabIndex = 0
        Me.GbRCiudad.TabStop = False
        Me.GbRCiudad.Text = "Registro Ciudad"
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
        Me.DataGridView1.Size = New System.Drawing.Size(331, 286)
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
        Me.CiudadBindingSource.DataMember = "Ciudad"
        Me.CiudadBindingSource.DataSource = Me.CatalanaNicDataSet
        '
        'CatalanaNicDataSet
        '
        Me.CatalanaNicDataSet.DataSetName = "CatalanaNicDataSet"
        Me.CatalanaNicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GbCiudad
        '
        Me.GbCiudad.Controls.Add(Me.PictureBox1)
        Me.GbCiudad.Controls.Add(Me.btnEditar)
        Me.GbCiudad.Controls.Add(Me.BtnBorrar)
        Me.GbCiudad.Controls.Add(Me.btnAgregar)
        Me.GbCiudad.Controls.Add(Me.btnNuevo)
        Me.GbCiudad.Controls.Add(Me.txtEstadoCiu)
        Me.GbCiudad.Controls.Add(Me.txtNombreCiu)
        Me.GbCiudad.Controls.Add(Me.txtIdciudad)
        Me.GbCiudad.Controls.Add(Me.LbEstado)
        Me.GbCiudad.Controls.Add(Me.lbNombreCu)
        Me.GbCiudad.Controls.Add(Me.lbIdCiudad)
        Me.GbCiudad.Location = New System.Drawing.Point(12, 12)
        Me.GbCiudad.Name = "GbCiudad"
        Me.GbCiudad.Size = New System.Drawing.Size(370, 380)
        Me.GbCiudad.TabIndex = 1
        Me.GbCiudad.TabStop = False
        Me.GbCiudad.Text = "Ciudad"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CatalanaNic.My.Resources.Resources.Icon_catalana
        Me.PictureBox1.Location = New System.Drawing.Point(111, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(222, 333)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(120, 333)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 8
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(21, 333)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(21, 293)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtEstadoCiu
        '
        Me.txtEstadoCiu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "estadoCiudad", True))
        Me.txtEstadoCiu.Location = New System.Drawing.Point(90, 243)
        Me.txtEstadoCiu.Name = "txtEstadoCiu"
        Me.txtEstadoCiu.Size = New System.Drawing.Size(172, 20)
        Me.txtEstadoCiu.TabIndex = 5
        '
        'txtNombreCiu
        '
        Me.txtNombreCiu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "nombreCiudad", True))
        Me.txtNombreCiu.Location = New System.Drawing.Point(90, 201)
        Me.txtNombreCiu.Name = "txtNombreCiu"
        Me.txtNombreCiu.Size = New System.Drawing.Size(172, 20)
        Me.txtNombreCiu.TabIndex = 4
        '
        'txtIdciudad
        '
        Me.txtIdciudad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CiudadBindingSource, "idCiudad", True))
        Me.txtIdciudad.Location = New System.Drawing.Point(90, 158)
        Me.txtIdciudad.Name = "txtIdciudad"
        Me.txtIdciudad.Size = New System.Drawing.Size(172, 20)
        Me.txtIdciudad.TabIndex = 3
        '
        'LbEstado
        '
        Me.LbEstado.AutoSize = True
        Me.LbEstado.Location = New System.Drawing.Point(27, 243)
        Me.LbEstado.Name = "LbEstado"
        Me.LbEstado.Size = New System.Drawing.Size(42, 13)
        Me.LbEstado.TabIndex = 2
        Me.LbEstado.Text = "estado:"
        '
        'lbNombreCu
        '
        Me.lbNombreCu.AutoSize = True
        Me.lbNombreCu.Location = New System.Drawing.Point(27, 201)
        Me.lbNombreCu.Name = "lbNombreCu"
        Me.lbNombreCu.Size = New System.Drawing.Size(47, 13)
        Me.lbNombreCu.TabIndex = 1
        Me.lbNombreCu.Text = "Nombre:"
        '
        'lbIdCiudad
        '
        Me.lbIdCiudad.AutoSize = True
        Me.lbIdCiudad.Location = New System.Drawing.Point(27, 158)
        Me.lbIdCiudad.Name = "lbIdCiudad"
        Me.lbIdCiudad.Size = New System.Drawing.Size(51, 13)
        Me.lbIdCiudad.TabIndex = 0
        Me.lbIdCiudad.Text = "idCiudad:"
        '
        'CiudadTableAdapter
        '
        Me.CiudadTableAdapter.ClearBeforeFill = True
        '
        'FrmCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 407)
        Me.Controls.Add(Me.GbCiudad)
        Me.Controls.Add(Me.GbRCiudad)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(768, 446)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(768, 446)
        Me.Name = "FrmCiudad"
        Me.Text = "Ciudad"
        Me.GbRCiudad.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalanaNicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCiudad.ResumeLayout(False)
        Me.GbCiudad.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbRCiudad As GroupBox
    Friend WithEvents GbCiudad As GroupBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtEstadoCiu As TextBox
    Friend WithEvents txtNombreCiu As TextBox
    Friend WithEvents txtIdciudad As TextBox
    Friend WithEvents LbEstado As Label
    Friend WithEvents lbNombreCu As Label
    Friend WithEvents lbIdCiudad As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CatalanaNicDataSet As CatalanaNicDataSet
    Friend WithEvents CiudadBindingSource As BindingSource
    Friend WithEvents CiudadTableAdapter As CatalanaNicDataSetTableAdapters.CiudadTableAdapter
    Friend WithEvents IdCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
