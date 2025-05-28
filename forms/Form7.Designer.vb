<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignupdetailsDataSet6 = New hotel_reservation_system_vb.signupdetailsDataSet6()
        Me.RoomStatusTableAdapter = New hotel_reservation_system_vb.signupdetailsDataSet6TableAdapters.RoomStatusTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignupdetailsDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CheckidDataGridViewTextBoxColumn, Me.RnoDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn, Me.CheckoutdateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RoomStatusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(40, 27)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1375, 753)
        Me.DataGridView1.TabIndex = 2
        '
        'CheckidDataGridViewTextBoxColumn
        '
        Me.CheckidDataGridViewTextBoxColumn.DataPropertyName = "check_id"
        Me.CheckidDataGridViewTextBoxColumn.HeaderText = "check_id"
        Me.CheckidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CheckidDataGridViewTextBoxColumn.Name = "CheckidDataGridViewTextBoxColumn"
        Me.CheckidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RnoDataGridViewTextBoxColumn
        '
        Me.RnoDataGridViewTextBoxColumn.DataPropertyName = "R_no"
        Me.RnoDataGridViewTextBoxColumn.HeaderText = "R_no"
        Me.RnoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RnoDataGridViewTextBoxColumn.Name = "RnoDataGridViewTextBoxColumn"
        '
        'CheckindateDataGridViewTextBoxColumn
        '
        Me.CheckindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.HeaderText = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CheckindateDataGridViewTextBoxColumn.Name = "CheckindateDataGridViewTextBoxColumn"
        '
        'CheckoutdateDataGridViewTextBoxColumn
        '
        Me.CheckoutdateDataGridViewTextBoxColumn.DataPropertyName = "checkout_date"
        Me.CheckoutdateDataGridViewTextBoxColumn.HeaderText = "checkout_date"
        Me.CheckoutdateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CheckoutdateDataGridViewTextBoxColumn.Name = "CheckoutdateDataGridViewTextBoxColumn"
        '
        'RoomStatusBindingSource
        '
        Me.RoomStatusBindingSource.DataMember = "RoomStatus"
        Me.RoomStatusBindingSource.DataSource = Me.SignupdetailsDataSet6
        '
        'SignupdetailsDataSet6
        '
        Me.SignupdetailsDataSet6.DataSetName = "signupdetailsDataSet6"
        Me.SignupdetailsDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomStatusTableAdapter
        '
        Me.RoomStatusTableAdapter.ClearBeforeFill = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1456, 809)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignupdetailsDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SignupdetailsDataSet6 As signupdetailsDataSet6
    Friend WithEvents RoomStatusBindingSource As BindingSource
    Friend WithEvents RoomStatusTableAdapter As signupdetailsDataSet6TableAdapters.RoomStatusTableAdapter
    Friend WithEvents CheckidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckoutdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
