<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acc_ConfirmSupPayment
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
        Me.txtTransactionInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.rdoConfirmed = New System.Windows.Forms.RadioButton()
        Me.rdoPending = New System.Windows.Forms.RadioButton()
        Me.dtpValid = New System.Windows.Forms.DateTimePicker()
        Me.btnRefuse = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.GridPayment = New System.Windows.Forms.DataGridView()
        Me.GridFile = New System.Windows.Forms.DataGridView()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTransactionInfo
        '
        Me.txtTransactionInfo.Location = New System.Drawing.Point(199, 628)
        Me.txtTransactionInfo.MaxLength = 300
        Me.txtTransactionInfo.Name = "txtTransactionInfo"
        Me.txtTransactionInfo.Size = New System.Drawing.Size(513, 20)
        Me.txtTransactionInfo.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1020, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "File attach"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Request date >="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 632)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Transaction Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "(Search follow Supplier)"
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(156, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 20)
        Me.txtSearch.TabIndex = 2
        '
        'rdoConfirmed
        '
        Me.rdoConfirmed.AutoSize = True
        Me.rdoConfirmed.Location = New System.Drawing.Point(78, 11)
        Me.rdoConfirmed.Name = "rdoConfirmed"
        Me.rdoConfirmed.Size = New System.Drawing.Size(72, 17)
        Me.rdoConfirmed.TabIndex = 1
        Me.rdoConfirmed.Text = "Confirmed"
        Me.rdoConfirmed.UseVisualStyleBackColor = True
        '
        'rdoPending
        '
        Me.rdoPending.AutoSize = True
        Me.rdoPending.Checked = True
        Me.rdoPending.Location = New System.Drawing.Point(8, 11)
        Me.rdoPending.Name = "rdoPending"
        Me.rdoPending.Size = New System.Drawing.Size(64, 17)
        Me.rdoPending.TabIndex = 0
        Me.rdoPending.TabStop = True
        Me.rdoPending.Text = "Pending"
        Me.rdoPending.UseVisualStyleBackColor = True
        '
        'dtpValid
        '
        Me.dtpValid.Checked = False
        Me.dtpValid.CustomFormat = "dd-MMM-yy"
        Me.dtpValid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValid.Location = New System.Drawing.Point(676, 11)
        Me.dtpValid.Name = "dtpValid"
        Me.dtpValid.ShowCheckBox = True
        Me.dtpValid.Size = New System.Drawing.Size(100, 20)
        Me.dtpValid.TabIndex = 5
        '
        'btnRefuse
        '
        Me.btnRefuse.Location = New System.Drawing.Point(8, 627)
        Me.btnRefuse.Name = "btnRefuse"
        Me.btnRefuse.Size = New System.Drawing.Size(58, 23)
        Me.btnRefuse.TabIndex = 9
        Me.btnRefuse.Text = "Refuse"
        Me.btnRefuse.UseVisualStyleBackColor = True
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(718, 627)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(58, 23)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'GridPayment
        '
        Me.GridPayment.AllowUserToAddRows = False
        Me.GridPayment.AllowUserToDeleteRows = False
        Me.GridPayment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPayment.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPayment.Location = New System.Drawing.Point(8, 36)
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.ReadOnly = True
        Me.GridPayment.RowHeadersVisible = False
        Me.GridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPayment.Size = New System.Drawing.Size(768, 585)
        Me.GridPayment.TabIndex = 6
        '
        'GridFile
        '
        Me.GridFile.AllowUserToAddRows = False
        Me.GridFile.AllowUserToDeleteRows = False
        Me.GridFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridFile.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFile.Location = New System.Drawing.Point(782, 36)
        Me.GridFile.Name = "GridFile"
        Me.GridFile.ReadOnly = True
        Me.GridFile.RowHeadersVisible = False
        Me.GridFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridFile.Size = New System.Drawing.Size(294, 196)
        Me.GridFile.TabIndex = 7
        '
        'bdsView
        '
        '
        'Acc_ConfirmSupPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.txtTransactionInfo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.rdoConfirmed)
        Me.Controls.Add(Me.rdoPending)
        Me.Controls.Add(Me.dtpValid)
        Me.Controls.Add(Me.btnRefuse)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.GridFile)
        Me.Controls.Add(Me.GridPayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Acc_ConfirmSupPayment"
        Me.Text = "Confirm Supplier Payment"
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTransactionInfo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents rdoConfirmed As RadioButton
    Friend WithEvents rdoPending As RadioButton
    Friend WithEvents dtpValid As DateTimePicker
    Friend WithEvents btnRefuse As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents GridPayment As DataGridView
    Friend WithEvents GridFile As DataGridView
    Friend WithEvents bdsView As BindingSource
End Class
