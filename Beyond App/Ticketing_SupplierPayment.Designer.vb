<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ticketing_SupplierPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticketing_SupplierPayment))
        Me.GridService = New System.Windows.Forms.DataGridView()
        Me.chk = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtRMK = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRequestPayment = New System.Windows.Forms.Button()
        Me.TabSummary = New System.Windows.Forms.TabControl()
        Me.TabPayment = New System.Windows.Forms.TabPage()
        Me.txtROE = New System.Windows.Forms.TextBox()
        Me.txtCurr = New System.Windows.Forms.TextBox()
        Me.chkUrgent = New System.Windows.Forms.CheckBox()
        Me.cbxFOP = New System.Windows.Forms.ComboBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabReview = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDeleteFile = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.dtpViewTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpViewFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GridFile = New System.Windows.Forms.DataGridView()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.bdsSupplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.GridSupplier = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdMulti = New System.Windows.Forms.OpenFileDialog()
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSummary.SuspendLayout()
        Me.TabPayment.SuspendLayout()
        Me.TabReview.SuspendLayout()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridService
        '
        Me.GridService.AllowUserToAddRows = False
        Me.GridService.AllowUserToDeleteRows = False
        Me.GridService.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridService.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk})
        Me.GridService.Location = New System.Drawing.Point(6, 30)
        Me.GridService.Name = "GridService"
        Me.GridService.RowHeadersVisible = False
        Me.GridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridService.Size = New System.Drawing.Size(757, 483)
        Me.GridService.TabIndex = 5
        '
        'chk
        '
        Me.chk.HeaderText = "C"
        Me.chk.Name = "chk"
        Me.chk.Width = 30
        '
        'txtRMK
        '
        Me.txtRMK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRMK.Location = New System.Drawing.Point(72, 549)
        Me.txtRMK.MaxLength = 255
        Me.txtRMK.Multiline = True
        Me.txtRMK.Name = "txtRMK"
        Me.txtRMK.Size = New System.Drawing.Size(691, 44)
        Me.txtRMK.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 552)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "RMK"
        '
        'btnRequestPayment
        '
        Me.btnRequestPayment.Location = New System.Drawing.Point(651, 599)
        Me.btnRequestPayment.Name = "btnRequestPayment"
        Me.btnRequestPayment.Size = New System.Drawing.Size(112, 23)
        Me.btnRequestPayment.TabIndex = 17
        Me.btnRequestPayment.Text = "Request Payment"
        Me.btnRequestPayment.UseVisualStyleBackColor = True
        '
        'TabSummary
        '
        Me.TabSummary.Controls.Add(Me.TabPayment)
        Me.TabSummary.Controls.Add(Me.TabReview)
        Me.TabSummary.Location = New System.Drawing.Point(305, 2)
        Me.TabSummary.Name = "TabSummary"
        Me.TabSummary.SelectedIndex = 0
        Me.TabSummary.Size = New System.Drawing.Size(776, 654)
        Me.TabSummary.TabIndex = 3
        '
        'TabPayment
        '
        Me.TabPayment.Controls.Add(Me.txtROE)
        Me.TabPayment.Controls.Add(Me.txtCurr)
        Me.TabPayment.Controls.Add(Me.chkUrgent)
        Me.TabPayment.Controls.Add(Me.cbxFOP)
        Me.TabPayment.Controls.Add(Me.lblTotalAmount)
        Me.TabPayment.Controls.Add(Me.Label6)
        Me.TabPayment.Controls.Add(Me.Label5)
        Me.TabPayment.Controls.Add(Me.Label4)
        Me.TabPayment.Controls.Add(Me.Label3)
        Me.TabPayment.Controls.Add(Me.chkPaid)
        Me.TabPayment.Controls.Add(Me.dtpTo)
        Me.TabPayment.Controls.Add(Me.dtpFrom)
        Me.TabPayment.Controls.Add(Me.Label15)
        Me.TabPayment.Controls.Add(Me.Label14)
        Me.TabPayment.Controls.Add(Me.GridService)
        Me.TabPayment.Controls.Add(Me.btnRequestPayment)
        Me.TabPayment.Controls.Add(Me.txtRMK)
        Me.TabPayment.Controls.Add(Me.Label2)
        Me.TabPayment.Location = New System.Drawing.Point(4, 22)
        Me.TabPayment.Name = "TabPayment"
        Me.TabPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPayment.Size = New System.Drawing.Size(768, 628)
        Me.TabPayment.TabIndex = 0
        Me.TabPayment.Text = "Payment"
        Me.TabPayment.UseVisualStyleBackColor = True
        '
        'txtROE
        '
        Me.txtROE.Location = New System.Drawing.Point(278, 520)
        Me.txtROE.MaxLength = 15
        Me.txtROE.Name = "txtROE"
        Me.txtROE.Size = New System.Drawing.Size(64, 20)
        Me.txtROE.TabIndex = 11
        Me.txtROE.Text = "1"
        Me.txtROE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCurr
        '
        Me.txtCurr.Enabled = False
        Me.txtCurr.Location = New System.Drawing.Point(192, 519)
        Me.txtCurr.Name = "txtCurr"
        Me.txtCurr.ReadOnly = True
        Me.txtCurr.Size = New System.Drawing.Size(44, 20)
        Me.txtCurr.TabIndex = 9
        '
        'chkUrgent
        '
        Me.chkUrgent.AutoSize = True
        Me.chkUrgent.Location = New System.Drawing.Point(348, 522)
        Me.chkUrgent.Name = "chkUrgent"
        Me.chkUrgent.Size = New System.Drawing.Size(58, 17)
        Me.chkUrgent.TabIndex = 12
        Me.chkUrgent.Text = "Urgent"
        Me.chkUrgent.UseVisualStyleBackColor = True
        '
        'cbxFOP
        '
        Me.cbxFOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFOP.FormattingEnabled = True
        Me.cbxFOP.Location = New System.Drawing.Point(72, 519)
        Me.cbxFOP.Name = "cbxFOP"
        Me.cbxFOP.Size = New System.Drawing.Size(57, 21)
        Me.cbxFOP.TabIndex = 7
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(491, 523)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalAmount.TabIndex = 14
        Me.lblTotalAmount.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 523)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ROE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 522)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Currency"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 522)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FOP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(412, 523)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total Amount:"
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(243, 7)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 4
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd-MMM-yy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(163, 4)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(74, 20)
        Me.dtpTo.TabIndex = 3
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.CustomFormat = "dd-MMM-yy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(42, 4)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(89, 20)
        Me.dtpFrom.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(137, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "To"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "From"
        '
        'TabReview
        '
        Me.TabReview.Controls.Add(Me.Label10)
        Me.TabReview.Controls.Add(Me.btnDeleteFile)
        Me.TabReview.Controls.Add(Me.btnAttach)
        Me.TabReview.Controls.Add(Me.dtpViewTo)
        Me.TabReview.Controls.Add(Me.dtpViewFrom)
        Me.TabReview.Controls.Add(Me.Label7)
        Me.TabReview.Controls.Add(Me.Label9)
        Me.TabReview.Controls.Add(Me.Label8)
        Me.TabReview.Controls.Add(Me.btnDelete)
        Me.TabReview.Controls.Add(Me.GridFile)
        Me.TabReview.Controls.Add(Me.GridView)
        Me.TabReview.Location = New System.Drawing.Point(4, 22)
        Me.TabReview.Name = "TabReview"
        Me.TabReview.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReview.Size = New System.Drawing.Size(768, 628)
        Me.TabReview.TabIndex = 1
        Me.TabReview.Text = "View"
        Me.TabReview.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 408)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(763, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'btnDeleteFile
        '
        Me.btnDeleteFile.Location = New System.Drawing.Point(695, 599)
        Me.btnDeleteFile.Name = "btnDeleteFile"
        Me.btnDeleteFile.Size = New System.Drawing.Size(70, 23)
        Me.btnDeleteFile.TabIndex = 10
        Me.btnDeleteFile.Text = "Delete File"
        Me.btnDeleteFile.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.Location = New System.Drawing.Point(704, 424)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(58, 23)
        Me.btnAttach.TabIndex = 8
        Me.btnAttach.Text = "Attach"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'dtpViewTo
        '
        Me.dtpViewTo.CustomFormat = "dd-MMM-yy"
        Me.dtpViewTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpViewTo.Location = New System.Drawing.Point(149, 6)
        Me.dtpViewTo.Name = "dtpViewTo"
        Me.dtpViewTo.Size = New System.Drawing.Size(74, 20)
        Me.dtpViewTo.TabIndex = 3
        '
        'dtpViewFrom
        '
        Me.dtpViewFrom.CustomFormat = "dd-MMM-yy"
        Me.dtpViewFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpViewFrom.Location = New System.Drawing.Point(42, 6)
        Me.dtpViewFrom.Name = "dtpViewFrom"
        Me.dtpViewFrom.Size = New System.Drawing.Size(75, 20)
        Me.dtpViewFrom.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 429)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "File attach"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "From"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(704, 382)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GridFile
        '
        Me.GridFile.AllowUserToAddRows = False
        Me.GridFile.AllowUserToDeleteRows = False
        Me.GridFile.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridFile.Location = New System.Drawing.Point(6, 453)
        Me.GridFile.Name = "GridFile"
        Me.GridFile.ReadOnly = True
        Me.GridFile.RowHeadersVisible = False
        Me.GridFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridFile.Size = New System.Drawing.Size(759, 141)
        Me.GridFile.TabIndex = 9
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.AllowUserToDeleteRows = False
        Me.GridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Location = New System.Drawing.Point(6, 32)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.RowHeadersVisible = False
        Me.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView.Size = New System.Drawing.Size(756, 344)
        Me.GridView.TabIndex = 4
        '
        'bdsSupplier
        '
        '
        'bdsView
        '
        '
        'txtSupplier
        '
        Me.txtSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSupplier.Location = New System.Drawing.Point(51, 2)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(248, 20)
        Me.txtSupplier.TabIndex = 1
        '
        'GridSupplier
        '
        Me.GridSupplier.AllowUserToAddRows = False
        Me.GridSupplier.AllowUserToDeleteRows = False
        Me.GridSupplier.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.GridSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSupplier.Location = New System.Drawing.Point(3, 28)
        Me.GridSupplier.Name = "GridSupplier"
        Me.GridSupplier.ReadOnly = True
        Me.GridSupplier.RowHeadersVisible = False
        Me.GridSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSupplier.Size = New System.Drawing.Size(296, 627)
        Me.GridSupplier.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier"
        '
        'ofdMulti
        '
        Me.ofdMulti.FileName = "OpenFileDialog1"
        Me.ofdMulti.Multiselect = True
        '
        'Ticketing_SupplierPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.GridSupplier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 50)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_SupplierPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Supplier Payment"
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSummary.ResumeLayout(False)
        Me.TabPayment.ResumeLayout(False)
        Me.TabPayment.PerformLayout()
        Me.TabReview.ResumeLayout(False)
        Me.TabReview.PerformLayout()
        CType(Me.GridFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridService As DataGridView
    Friend WithEvents txtRMK As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRequestPayment As Button
    Friend WithEvents TabSummary As TabControl
    Friend WithEvents TabPayment As TabPage
    Friend WithEvents TabReview As TabPage
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GridView As DataGridView
    Friend WithEvents bdsSupplier As BindingSource
    Friend WithEvents bdsView As BindingSource
    Friend WithEvents chk As DataGridViewCheckBoxColumn
    Friend WithEvents cbxFOP As ComboBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents chkUrgent As CheckBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents GridSupplier As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurr As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtROE As TextBox
    Friend WithEvents dtpViewTo As DateTimePicker
    Friend WithEvents dtpViewFrom As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAttach As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GridFile As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents btnDeleteFile As Button
    Friend WithEvents ofdMulti As OpenFileDialog
End Class
