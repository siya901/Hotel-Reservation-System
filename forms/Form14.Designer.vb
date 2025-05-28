<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignupdetailsDataSet11 = New hotel_reservation_system_vb.signupdetailsDataSet11()
        Me.PaymentTableAdapter = New hotel_reservation_system_vb.signupdetailsDataSet11TableAdapters.paymentTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignupdetailsDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PidDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.RnoDataGridViewTextBoxColumn, Me.RpriceDataGridViewTextBoxColumn, Me.NoofdaysDataGridViewTextBoxColumn, Me.ModeDataGridViewTextBoxColumn, Me.TotalamountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaymentBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1270, 703)
        Me.DataGridView1.TabIndex = 0
        '
        'PidDataGridViewTextBoxColumn
        '
        Me.PidDataGridViewTextBoxColumn.DataPropertyName = "p_id"
        Me.PidDataGridViewTextBoxColumn.HeaderText = "p_id"
        Me.PidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PidDataGridViewTextBoxColumn.Name = "PidDataGridViewTextBoxColumn"
        Me.PidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'RnoDataGridViewTextBoxColumn
        '
        Me.RnoDataGridViewTextBoxColumn.DataPropertyName = "R_no"
        Me.RnoDataGridViewTextBoxColumn.HeaderText = "R_no"
        Me.RnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RnoDataGridViewTextBoxColumn.Name = "RnoDataGridViewTextBoxColumn"
        '
        'RpriceDataGridViewTextBoxColumn
        '
        Me.RpriceDataGridViewTextBoxColumn.DataPropertyName = "R_price"
        Me.RpriceDataGridViewTextBoxColumn.HeaderText = "R_price"
        Me.RpriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RpriceDataGridViewTextBoxColumn.Name = "RpriceDataGridViewTextBoxColumn"
        '
        'NoofdaysDataGridViewTextBoxColumn
        '
        Me.NoofdaysDataGridViewTextBoxColumn.DataPropertyName = "no_of_days"
        Me.NoofdaysDataGridViewTextBoxColumn.HeaderText = "no_of_days"
        Me.NoofdaysDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoofdaysDataGridViewTextBoxColumn.Name = "NoofdaysDataGridViewTextBoxColumn"
        '
        'ModeDataGridViewTextBoxColumn
        '
        Me.ModeDataGridViewTextBoxColumn.DataPropertyName = "mode"
        Me.ModeDataGridViewTextBoxColumn.HeaderText = "mode"
        Me.ModeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ModeDataGridViewTextBoxColumn.Name = "ModeDataGridViewTextBoxColumn"
        '
        'TotalamountDataGridViewTextBoxColumn
        '
        Me.TotalamountDataGridViewTextBoxColumn.DataPropertyName = "Total_amount"
        Me.TotalamountDataGridViewTextBoxColumn.HeaderText = "Total_amount"
        Me.TotalamountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalamountDataGridViewTextBoxColumn.Name = "TotalamountDataGridViewTextBoxColumn"
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "payment"
        Me.PaymentBindingSource.DataSource = Me.SignupdetailsDataSet11
        '
        'SignupdetailsDataSet11
        '
        Me.SignupdetailsDataSet11.DataSetName = "signupdetailsDataSet11"
        Me.SignupdetailsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 703)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form14"
        Me.Text = "Reservation/Payment details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignupdetailsDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SignupdetailsDataSet11 As signupdetailsDataSet11
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As signupdetailsDataSet11TableAdapters.paymentTableAdapter
    Friend WithEvents PidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoofdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
