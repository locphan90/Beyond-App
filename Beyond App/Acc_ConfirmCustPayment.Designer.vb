<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acc_ConfirmCustPayment
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
        Me.flpHinhAnh = New System.Windows.Forms.FlowLayoutPanel()
        Me.GridPayment = New System.Windows.Forms.DataGridView()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.dtpValid = New System.Windows.Forms.DateTimePicker()
        Me.rdoPending = New System.Windows.Forms.RadioButton()
        Me.rdoConfirmed = New System.Windows.Forms.RadioButton()
        Me.btnRefuse = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTransactionInfo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flpHinhAnh
        '
        Me.flpHinhAnh.AutoScroll = True
        Me.flpHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpHinhAnh.Location = New System.Drawing.Point(786, 37)
        Me.flpHinhAnh.Name = "flpHinhAnh"
        Me.flpHinhAnh.Size = New System.Drawing.Size(294, 421)
        Me.flpHinhAnh.TabIndex = 8
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
        Me.GridPayment.Location = New System.Drawing.Point(12, 37)
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.ReadOnly = True
        Me.GridPayment.RowHeadersVisible = False
        Me.GridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPayment.Size = New System.Drawing.Size(768, 585)
        Me.GridPayment.TabIndex = 6
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(722, 628)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(58, 23)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'dtpValid
        '
        Me.dtpValid.Checked = False
        Me.dtpValid.CustomFormat = "dd-MMM-yy"
        Me.dtpValid.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpValid.Location = New System.Drawing.Point(680, 12)
        Me.dtpValid.Name = "dtpValid"
        Me.dtpValid.ShowCheckBox = True
        Me.dtpValid.Size = New System.Drawing.Size(100, 20)
        Me.dtpValid.TabIndex = 5
        '
        'rdoPending
        '
        Me.rdoPending.AutoSize = True
        Me.rdoPending.Checked = True
        Me.rdoPending.Location = New System.Drawing.Point(12, 12)
        Me.rdoPending.Name = "rdoPending"
        Me.rdoPending.Size = New System.Drawing.Size(64, 17)
        Me.rdoPending.TabIndex = 0
        Me.rdoPending.TabStop = True
        Me.rdoPending.Text = "Pending"
        Me.rdoPending.UseVisualStyleBackColor = True
        '
        'rdoConfirmed
        '
        Me.rdoConfirmed.AutoSize = True
        Me.rdoConfirmed.Location = New System.Drawing.Point(82, 12)
        Me.rdoConfirmed.Name = "rdoConfirmed"
        Me.rdoConfirmed.Size = New System.Drawing.Size(72, 17)
        Me.rdoConfirmed.TabIndex = 1
        Me.rdoConfirmed.Text = "Confirmed"
        Me.rdoConfirmed.UseVisualStyleBackColor = True
        '
        'btnRefuse
        '
        Me.btnRefuse.Location = New System.Drawing.Point(12, 628)
        Me.btnRefuse.Name = "btnRefuse"
        Me.btnRefuse.Size = New System.Drawing.Size(58, 23)
        Me.btnRefuse.TabIndex = 9
        Me.btnRefuse.Text = "Refuse"
        Me.btnRefuse.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(160, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(137, 20)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "(Search follow CustName)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(591, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Receipt date >="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1024, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "File attach"
        '
        'bdsView
        '
        '
        'txtTransactionInfo
        '
        Me.txtTransactionInfo.Location = New System.Drawing.Point(203, 629)
        Me.txtTransactionInfo.MaxLength = 300
        Me.txtTransactionInfo.Name = "txtTransactionInfo"
        Me.txtTransactionInfo.Size = New System.Drawing.Size(513, 20)
        Me.txtTransactionInfo.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 633)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Transaction Info"
        '
        'Acc_ConfirmCustPayment
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
        Me.Controls.Add(Me.GridPayment)
        Me.Controls.Add(Me.flpHinhAnh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Acc_ConfirmCustPayment"
        Me.Text = "Confirm Customer Payment"
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flpHinhAnh As FlowLayoutPanel
    Friend WithEvents GridPayment As DataGridView
    Friend WithEvents btnConfirm As Button
    Friend WithEvents dtpValid As DateTimePicker
    Friend WithEvents rdoPending As RadioButton
    Friend WithEvents rdoConfirmed As RadioButton
    Friend WithEvents btnRefuse As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bdsView As BindingSource
    Friend WithEvents txtTransactionInfo As TextBox
    Friend WithEvents Label4 As Label
End Class
