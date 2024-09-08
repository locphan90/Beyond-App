<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticketing_CustPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridPayment = New System.Windows.Forms.DataGridView()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPayer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAttach = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(818, 23)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cust name"
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
        Me.GridPayment.Location = New System.Drawing.Point(16, 52)
        Me.GridPayment.Name = "GridPayment"
        Me.GridPayment.ReadOnly = True
        Me.GridPayment.RowHeadersVisible = False
        Me.GridPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPayment.Size = New System.Drawing.Size(860, 115)
        Me.GridPayment.TabIndex = 9
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(75, 9)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(10, 13)
        Me.lblCustName.TabIndex = 1
        Me.lblCustName.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Payer"
        '
        'txtPayer
        '
        Me.txtPayer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPayer.Location = New System.Drawing.Point(78, 25)
        Me.txtPayer.MaxLength = 50
        Me.txtPayer.Name = "txtPayer"
        Me.txtPayer.Size = New System.Drawing.Size(254, 20)
        Me.txtPayer.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Amount"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(818, 173)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAttach
        '
        Me.btnAttach.Location = New System.Drawing.Point(754, 173)
        Me.btnAttach.Name = "btnAttach"
        Me.btnAttach.Size = New System.Drawing.Size(58, 23)
        Me.btnAttach.TabIndex = 11
        Me.btnAttach.Text = "Attach"
        Me.btnAttach.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(470, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Note"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(507, 25)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(305, 20)
        Me.txtNote.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(387, 25)
        Me.txtAmount.MaxLength = 15
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bdsView
        '
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Location = New System.Drawing.Point(16, 173)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(81, 23)
        Me.btnPrintReceipt.TabIndex = 10
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'Ticketing_CustPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 208)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtPayer)
        Me.Controls.Add(Me.GridPayment)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAttach)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_CustPayment"
        Me.Text = "Customer Payment"
        CType(Me.GridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GridPayment As DataGridView
    Friend WithEvents lblCustName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPayer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAttach As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents bdsView As BindingSource
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents btnPrintReceipt As Button
End Class
