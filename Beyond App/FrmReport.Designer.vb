<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReport
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
        Me.GridReport = New System.Windows.Forms.DataGridView()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.btnChayBaoCao = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bdsReport = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridReport
        '
        Me.GridReport.AllowUserToAddRows = False
        Me.GridReport.AllowUserToDeleteRows = False
        Me.GridReport.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridReport.Location = New System.Drawing.Point(12, 7)
        Me.GridReport.Name = "GridReport"
        Me.GridReport.ReadOnly = True
        Me.GridReport.RowHeadersVisible = False
        Me.GridReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridReport.Size = New System.Drawing.Size(266, 400)
        Me.GridReport.TabIndex = 14
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.CustomFormat = "dd-MMM-yy"
        Me.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTuNgay.Location = New System.Drawing.Point(317, 10)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(74, 20)
        Me.dtpTuNgay.TabIndex = 15
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.CustomFormat = "dd-MMM-yy"
        Me.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDenNgay.Location = New System.Drawing.Point(317, 36)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(74, 20)
        Me.dtpDenNgay.TabIndex = 15
        '
        'btnChayBaoCao
        '
        Me.btnChayBaoCao.Location = New System.Drawing.Point(287, 62)
        Me.btnChayBaoCao.Name = "btnChayBaoCao"
        Me.btnChayBaoCao.Size = New System.Drawing.Size(104, 23)
        Me.btnChayBaoCao.TabIndex = 16
        Me.btnChayBaoCao.Text = "Run Report"
        Me.btnChayBaoCao.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "To"
        '
        'bdsReport
        '
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 413)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChayBaoCao)
        Me.Controls.Add(Me.dtpDenNgay)
        Me.Controls.Add(Me.dtpTuNgay)
        Me.Controls.Add(Me.GridReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.GridReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridReport As DataGridView
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents btnChayBaoCao As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bdsReport As BindingSource
End Class
