<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignupdetailsDataSet12 = New hotel_reservation_system_vb.signupdetailsDataSet12()
        Me.PaymentTableAdapter = New hotel_reservation_system_vb.signupdetailsDataSet12TableAdapters.paymentTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignupdetailsDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PidDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.RnoDataGridViewTextBoxColumn, Me.RpriceDataGridViewTextBoxColumn, Me.NoofdaysDataGridViewTextBoxColumn, Me.ModeDataGridViewTextBoxColumn, Me.TotalamountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaymentBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(102, 48)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1493, 788)
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
        Me.PaymentBindingSource.DataSource = Me.SignupdetailsDataSet12
        '
        'SignupdetailsDataSet12
        '
        Me.SignupdetailsDataSet12.DataSetName = "signupdetailsDataSet12"
        Me.SignupdetailsDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1678, 900)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payment details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignupdetailsDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SignupdetailsDataSet12 As signupdetailsDataSet12
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As signupdetailsDataSet12TableAdapters.paymentTableAdapter
    Friend WithEvents PidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoofdaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalamountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
