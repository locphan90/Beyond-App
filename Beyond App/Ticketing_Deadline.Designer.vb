<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticketing_Deadline
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
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.GridDeadline = New System.Windows.Forms.DataGridView()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoInvidual = New System.Windows.Forms.RadioButton()
        Me.rdoDepartment = New System.Windows.Forms.RadioButton()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridDeadline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(172, 5)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpTo.TabIndex = 3
        Me.dtpTo.Value = New Date(2024, 9, 3, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(40, 6)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpFrom.TabIndex = 1
        Me.dtpFrom.Value = New Date(2024, 9, 3, 0, 0, 0, 0)
        '
        'GridDeadline
        '
        Me.GridDeadline.AllowUserToAddRows = False
        Me.GridDeadline.AllowUserToDeleteRows = False
        Me.GridDeadline.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridDeadline.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridDeadline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDeadline.Location = New System.Drawing.Point(7, 31)
        Me.GridDeadline.Name = "GridDeadline"
        Me.GridDeadline.ReadOnly = True
        Me.GridDeadline.RowHeadersVisible = False
        Me.GridDeadline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDeadline.Size = New System.Drawing.Size(929, 504)
        Me.GridDeadline.TabIndex = 6
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(878, 541)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(58, 23)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'rdoInvidual
        '
        Me.rdoInvidual.AutoSize = True
        Me.rdoInvidual.Checked = True
        Me.rdoInvidual.Location = New System.Drawing.Point(278, 7)
        Me.rdoInvidual.Name = "rdoInvidual"
        Me.rdoInvidual.Size = New System.Drawing.Size(62, 17)
        Me.rdoInvidual.TabIndex = 4
        Me.rdoInvidual.TabStop = True
        Me.rdoInvidual.Text = "Invidual"
        Me.rdoInvidual.UseVisualStyleBackColor = True
        '
        'rdoDepartment
        '
        Me.rdoDepartment.AutoSize = True
        Me.rdoDepartment.Location = New System.Drawing.Point(346, 7)
        Me.rdoDepartment.Name = "rdoDepartment"
        Me.rdoDepartment.Size = New System.Drawing.Size(80, 17)
        Me.rdoDepartment.TabIndex = 5
        Me.rdoDepartment.Text = "Department"
        Me.rdoDepartment.UseVisualStyleBackColor = True
        '
        'bdsView
        '
        '
        'Ticketing_Deadline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 570)
        Me.Controls.Add(Me.rdoDepartment)
        Me.Controls.Add(Me.rdoInvidual)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.GridDeadline)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.dtpTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_Deadline"
        Me.Text = "Deadline"
        CType(Me.GridDeadline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents GridDeadline As DataGridView
    Friend WithEvents btnDone As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdoInvidual As RadioButton
    Friend WithEvents rdoDepartment As RadioButton
    Friend WithEvents bdsView As BindingSource
End Class
