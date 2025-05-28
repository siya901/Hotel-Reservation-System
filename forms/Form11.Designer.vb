<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdprooftypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproofnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignupdetailsDataSet9 = New hotel_reservation_system_vb.signupdetailsDataSet9()
        Me.ReservationTableAdapter = New hotel_reservation_system_vb.signupdetailsDataSet9TableAdapters.ReservationTableAdapter()
        Me.SignupdetailsDataSet13 = New hotel_reservation_system_vb.signupdetailsDataSet13()
        Me.ReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter1 = New hotel_reservation_system_vb.signupdetailsDataSet13TableAdapters.reservationTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignupdetailsDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignupdetailsDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RidDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PincodeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.IdprooftypeDataGridViewTextBoxColumn, Me.IdproofnoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(43, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1323, 636)
        Me.DataGridView1.TabIndex = 0
        '
        'RidDataGridViewTextBoxColumn
        '
        Me.RidDataGridViewTextBoxColumn.DataPropertyName = "R_id"
        Me.RidDataGridViewTextBoxColumn.HeaderText = "R_id"
        Me.RidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RidDataGridViewTextBoxColumn.Name = "RidDataGridViewTextBoxColumn"
        Me.RidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "F_name"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "F_name"
        Me.FnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "L_name"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "L_name"
        Me.LnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "Pin_code"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "Pin_code"
        Me.PincodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'IdprooftypeDataGridViewTextBoxColumn
        '
        Me.IdprooftypeDataGridViewTextBoxColumn.DataPropertyName = "Id_proof_type"
        Me.IdprooftypeDataGridViewTextBoxColumn.HeaderText = "Id_proof_type"
        Me.IdprooftypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdprooftypeDataGridViewTextBoxColumn.Name = "IdprooftypeDataGridViewTextBoxColumn"
        '
        'IdproofnoDataGridViewTextBoxColumn
        '
        Me.IdproofnoDataGridViewTextBoxColumn.DataPropertyName = "Id_proof_no"
        Me.IdproofnoDataGridViewTextBoxColumn.HeaderText = "Id_proof_no"
        Me.IdproofnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdproofnoDataGridViewTextBoxColumn.Name = "IdproofnoDataGridViewTextBoxColumn"
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.SignupdetailsDataSet9
        '
        'SignupdetailsDataSet9
        '
        Me.SignupdetailsDataSet9.DataSetName = "signupdetailsDataSet9"
        Me.SignupdetailsDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'SignupdetailsDataSet13
        '
        Me.SignupdetailsDataSet13.DataSetName = "signupdetailsDataSet13"
        Me.SignupdetailsDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource1
        '
        Me.ReservationBindingSource1.DataMember = "reservation"
        Me.ReservationBindingSource1.DataSource = Me.SignupdetailsDataSet13
        '
        'ReservationTableAdapter1
        '
        Me.ReservationTableAdapter1.ClearBeforeFill = True
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1420, 701)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form11"
        Me.Text = "Reservation details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignupdetailsDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignupdetailsDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SignupdetailsDataSet9 As signupdetailsDataSet9
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As signupdetailsDataSet9TableAdapters.ReservationTableAdapter
    Friend WithEvents RidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdprooftypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdproofnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SignupdetailsDataSet13 As signupdetailsDataSet13
    Friend WithEvents ReservationBindingSource1 As BindingSource
    Friend WithEvents ReservationTableAdapter1 As signupdetailsDataSet13TableAdapters.reservationTableAdapter
End Class
