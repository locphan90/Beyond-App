<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acc_TopUp
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GridTopUp = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxSupName = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridTongHop = New System.Windows.Forms.DataGridView()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCurr = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.GridTopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridTongHop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(816, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(752, 34)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(58, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(688, 34)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(58, 23)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(817, 297)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GridTopUp
        '
        Me.GridTopUp.AllowUserToAddRows = False
        Me.GridTopUp.AllowUserToDeleteRows = False
        Me.GridTopUp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTopUp.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridTopUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTopUp.Location = New System.Drawing.Point(15, 63)
        Me.GridTopUp.Name = "GridTopUp"
        Me.GridTopUp.ReadOnly = True
        Me.GridTopUp.RowHeadersVisible = False
        Me.GridTopUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridTopUp.Size = New System.Drawing.Size(860, 228)
        Me.GridTopUp.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Supplier name"
        '
        'cbxSupName
        '
        Me.cbxSupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupName.FormattingEnabled = True
        Me.cbxSupName.Location = New System.Drawing.Point(92, 6)
        Me.cbxSupName.Name = "cbxSupName"
        Me.cbxSupName.Size = New System.Drawing.Size(322, 21)
        Me.cbxSupName.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(654, 8)
        Me.txtAmount.MaxLength = 15
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount.TabIndex = 7
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(605, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Amount"
        '
        'dtpDate
        '
        Me.dtpDate.Checked = False
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(773, 8)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpDate.TabIndex = 9
        Me.dtpDate.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(737, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date"
        '
        'cbxType
        '
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"FIT", "GIT"})
        Me.cbxType.Location = New System.Drawing.Point(457, 8)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(48, 21)
        Me.cbxType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type"
        '
        'GridTongHop
        '
        Me.GridTongHop.AllowUserToAddRows = False
        Me.GridTongHop.AllowUserToDeleteRows = False
        Me.GridTongHop.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTongHop.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTongHop.Location = New System.Drawing.Point(14, 327)
        Me.GridTongHop.Name = "GridTongHop"
        Me.GridTongHop.ReadOnly = True
        Me.GridTongHop.RowHeadersVisible = False
        Me.GridTongHop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridTongHop.Size = New System.Drawing.Size(860, 222)
        Me.GridTongHop.TabIndex = 15
        '
        'bdsView
        '
        '
        'cbxCurr
        '
        Me.cbxCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurr.FormattingEnabled = True
        Me.cbxCurr.Location = New System.Drawing.Point(542, 8)
        Me.cbxCurr.Name = "cbxCurr"
        Me.cbxCurr.Size = New System.Drawing.Size(57, 21)
        Me.cbxCurr.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(511, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Curr"
        '
        'Acc_TopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.cbxCurr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cbxType)
        Me.Controls.Add(Me.cbxSupName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GridTongHop)
        Me.Controls.Add(Me.GridTopUp)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Acc_TopUp"
        Me.Text = "Top Up"
        CType(Me.GridTopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridTongHop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GridTopUp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxSupName As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GridTongHop As DataGridView
    Friend WithEvents bdsView As BindingSource
    Friend WithEvents cbxCurr As ComboBox
    Friend WithEvents Label10 As Label
End Class
