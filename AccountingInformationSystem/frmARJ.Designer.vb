<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmARJ
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtParticulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtDate, Me.txtParticulars, Me.txtSupplier, Me.txtDebit, Me.txtCredit})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(854, 343)
        Me.DataGridView1.TabIndex = 0
        '
        'txtDate
        '
        Me.txtDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.txtDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.txtDate.HeaderText = "Date"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtParticulars
        '
        Me.txtParticulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtParticulars.HeaderText = "Particulars"
        Me.txtParticulars.Name = "txtParticulars"
        '
        'txtSupplier
        '
        Me.txtSupplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtSupplier.HeaderText = "Supplier"
        Me.txtSupplier.Name = "txtSupplier"
        '
        'txtDebit
        '
        Me.txtDebit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtDebit.HeaderText = "Debit"
        Me.txtDebit.Name = "txtDebit"
        '
        'txtCredit
        '
        Me.txtCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.txtCredit.HeaderText = "Credit"
        Me.txtCredit.Name = "txtCredit"
        '
        'frmARJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 343)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmARJ"
        Me.Text = "frmARJ"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtDate As DataGridViewTextBoxColumn
    Friend WithEvents txtParticulars As DataGridViewTextBoxColumn
    Friend WithEvents txtSupplier As DataGridViewTextBoxColumn
    Friend WithEvents txtDebit As DataGridViewTextBoxColumn
    Friend WithEvents txtCredit As DataGridViewTextBoxColumn
End Class
