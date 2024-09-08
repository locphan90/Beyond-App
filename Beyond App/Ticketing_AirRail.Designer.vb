<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticketing_AirRail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticketing_AirRail))
        Me.txtPNR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtROE = New System.Windows.Forms.TextBox()
        Me.txtBasefareSell = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtItinerary = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GridPNR = New System.Windows.Forms.DataGridView()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtSearchPNR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPaxName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.chkKeepPNRCode = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxCurr = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBasefareNet = New System.Windows.Forms.TextBox()
        Me.txtTotalServiceFee = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFuelSurcharge = New System.Windows.Forms.TextBox()
        Me.cbxCust = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxServiceType = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.GridService = New System.Windows.Forms.DataGridView()
        Me.Xoa = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkInvService = New System.Windows.Forms.CheckBox()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.cbxServiceCurr = New System.Windows.Forms.ComboBox()
        Me.txtServiceQty = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtServiceRMK = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTotalServiceCharge = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbxPaxType = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxTicketType = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtAgentComm = New System.Windows.Forms.TextBox()
        Me.txtPersonComm = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbxRoutingType = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxCustType = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblBalanceNumber = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GridTicketking = New System.Windows.Forms.DataGridView()
        Me.txtTKNO = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.chkInvoice = New System.Windows.Forms.CheckBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnDeletePNR = New System.Windows.Forms.Button()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.bdsPNR = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsTicketing = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpFlightDate = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.chkInvidual = New System.Windows.Forms.CheckBox()
        CType(Me.GridPNR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridTicketking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsPNR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsTicketing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPNR
        '
        Me.txtPNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNR.Location = New System.Drawing.Point(70, 37)
        Me.txtPNR.MaxLength = 6
        Me.txtPNR.Name = "txtPNR"
        Me.txtPNR.Size = New System.Drawing.Size(68, 20)
        Me.txtPNR.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PNR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Basefare sell"
        '
        'txtROE
        '
        Me.txtROE.Location = New System.Drawing.Point(504, 7)
        Me.txtROE.MaxLength = 15
        Me.txtROE.Name = "txtROE"
        Me.txtROE.Size = New System.Drawing.Size(59, 20)
        Me.txtROE.TabIndex = 7
        Me.txtROE.Text = "0"
        Me.txtROE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBasefareSell
        '
        Me.txtBasefareSell.Location = New System.Drawing.Point(396, 94)
        Me.txtBasefareSell.MaxLength = 15
        Me.txtBasefareSell.Name = "txtBasefareSell"
        Me.txtBasefareSell.Size = New System.Drawing.Size(77, 20)
        Me.txtBasefareSell.TabIndex = 33
        Me.txtBasefareSell.Text = "0"
        Me.txtBasefareSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Itinerary"
        '
        'txtItinerary
        '
        Me.txtItinerary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItinerary.Location = New System.Drawing.Point(70, 65)
        Me.txtItinerary.MaxLength = 50
        Me.txtItinerary.Name = "txtItinerary"
        Me.txtItinerary.Size = New System.Drawing.Size(246, 20)
        Me.txtItinerary.TabIndex = 20
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(894, 334)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(58, 23)
        Me.btnNew.TabIndex = 55
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(958, 334)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(58, 23)
        Me.btnUpdate.TabIndex = 56
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1022, 334)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 57
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GridPNR
        '
        Me.GridPNR.AllowUserToAddRows = False
        Me.GridPNR.AllowUserToDeleteRows = False
        Me.GridPNR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPNR.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridPNR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPNR.Location = New System.Drawing.Point(12, 403)
        Me.GridPNR.Name = "GridPNR"
        Me.GridPNR.ReadOnly = True
        Me.GridPNR.RowHeadersVisible = False
        Me.GridPNR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridPNR.Size = New System.Drawing.Size(548, 217)
        Me.GridPNR.TabIndex = 63
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(118, 374)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpTo.TabIndex = 59
        Me.dtpTo.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(12, 374)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpFrom.TabIndex = 58
        Me.dtpFrom.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'txtSearchPNR
        '
        Me.txtSearchPNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchPNR.Location = New System.Drawing.Point(263, 374)
        Me.txtSearchPNR.Name = "txtSearchPNR"
        Me.txtSearchPNR.Size = New System.Drawing.Size(77, 20)
        Me.txtSearchPNR.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(227, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "PNR"
        '
        'cbxSupplier
        '
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(70, 10)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(181, 21)
        Me.cbxSupplier.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Supplier"
        '
        'txtPaxName
        '
        Me.txtPaxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaxName.Location = New System.Drawing.Point(711, 192)
        Me.txtPaxName.Multiline = True
        Me.txtPaxName.Name = "txtPaxName"
        Me.txtPaxName.Size = New System.Drawing.Size(178, 136)
        Me.txtPaxName.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(713, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Pax name"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(289, 92)
        Me.txtQuantity.MaxLength = 15
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(27, 20)
        Me.txtQuantity.TabIndex = 31
        Me.txtQuantity.Text = "0"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkKeepPNRCode
        '
        Me.chkKeepPNRCode.AutoSize = True
        Me.chkKeepPNRCode.BackColor = System.Drawing.Color.MintCream
        Me.chkKeepPNRCode.Location = New System.Drawing.Point(147, 39)
        Me.chkKeepPNRCode.Name = "chkKeepPNRCode"
        Me.chkKeepPNRCode.Size = New System.Drawing.Size(104, 17)
        Me.chkKeepPNRCode.TabIndex = 12
        Me.chkKeepPNRCode.Text = "Keep PNR code"
        Me.chkKeepPNRCode.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(711, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Total service fee "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(373, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Curr"
        '
        'cbxCurr
        '
        Me.cbxCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurr.FormattingEnabled = True
        Me.cbxCurr.Location = New System.Drawing.Point(405, 7)
        Me.cbxCurr.Name = "cbxCurr"
        Me.cbxCurr.Size = New System.Drawing.Size(57, 21)
        Me.cbxCurr.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(373, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Customer code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(479, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Basefare net"
        '
        'txtBasefareNet
        '
        Me.txtBasefareNet.Location = New System.Drawing.Point(552, 94)
        Me.txtBasefareNet.MaxLength = 15
        Me.txtBasefareNet.Name = "txtBasefareNet"
        Me.txtBasefareNet.Size = New System.Drawing.Size(77, 20)
        Me.txtBasefareNet.TabIndex = 35
        Me.txtBasefareNet.Text = "0"
        Me.txtBasefareNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalServiceFee
        '
        Me.txtTotalServiceFee.Location = New System.Drawing.Point(833, 119)
        Me.txtTotalServiceFee.MaxLength = 15
        Me.txtTotalServiceFee.Name = "txtTotalServiceFee"
        Me.txtTotalServiceFee.ReadOnly = True
        Me.txtTotalServiceFee.Size = New System.Drawing.Size(77, 20)
        Me.txtTotalServiceFee.TabIndex = 42
        Me.txtTotalServiceFee.Text = "0"
        Me.txtTotalServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(635, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(25, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Tax"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(666, 93)
        Me.txtTax.MaxLength = 15
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(77, 20)
        Me.txtTax.TabIndex = 37
        Me.txtTax.Text = "0"
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(750, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Fuel surcharge"
        '
        'txtFuelSurcharge
        '
        Me.txtFuelSurcharge.Location = New System.Drawing.Point(833, 93)
        Me.txtFuelSurcharge.MaxLength = 15
        Me.txtFuelSurcharge.Name = "txtFuelSurcharge"
        Me.txtFuelSurcharge.Size = New System.Drawing.Size(77, 20)
        Me.txtFuelSurcharge.TabIndex = 39
        Me.txtFuelSurcharge.Text = "0"
        Me.txtFuelSurcharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxCust
        '
        Me.cbxCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCust.FormattingEnabled = True
        Me.cbxCust.Location = New System.Drawing.Point(456, 34)
        Me.cbxCust.Name = "cbxCust"
        Me.cbxCust.Size = New System.Drawing.Size(86, 21)
        Me.cbxCust.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Type"
        '
        'cbxServiceType
        '
        Me.cbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServiceType.FormattingEnabled = True
        Me.cbxServiceType.Location = New System.Drawing.Point(150, 23)
        Me.cbxServiceType.Name = "cbxServiceType"
        Me.cbxServiceType.Size = New System.Drawing.Size(156, 21)
        Me.cbxServiceType.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(539, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(588, 22)
        Me.txtAmount.MaxLength = 15
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(77, 20)
        Me.txtAmount.TabIndex = 10
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GridService
        '
        Me.GridService.AllowUserToAddRows = False
        Me.GridService.AllowUserToDeleteRows = False
        Me.GridService.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridService.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridService.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Xoa})
        Me.GridService.Location = New System.Drawing.Point(6, 77)
        Me.GridService.Name = "GridService"
        Me.GridService.ReadOnly = True
        Me.GridService.RowHeadersVisible = False
        Me.GridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridService.Size = New System.Drawing.Size(684, 127)
        Me.GridService.TabIndex = 14
        '
        'Xoa
        '
        Me.Xoa.HeaderText = ""
        Me.Xoa.Image = Global.Beyond_App.My.Resources.Resources.close
        Me.Xoa.Name = "Xoa"
        Me.Xoa.ReadOnly = True
        Me.Xoa.Width = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.chkInvService)
        Me.GroupBox1.Controls.Add(Me.btnAddService)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cbxType)
        Me.GroupBox1.Controls.Add(Me.cbxServiceType)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.GridService)
        Me.GroupBox1.Controls.Add(Me.cbxServiceCurr)
        Me.GroupBox1.Controls.Add(Me.txtServiceQty)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtServiceRMK)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 210)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other services/Charge"
        '
        'chkInvService
        '
        Me.chkInvService.AutoSize = True
        Me.chkInvService.Location = New System.Drawing.Point(317, 25)
        Me.chkInvService.Name = "chkInvService"
        Me.chkInvService.Size = New System.Drawing.Size(61, 17)
        Me.chkInvService.TabIndex = 4
        Me.chkInvService.Text = "Invoice"
        Me.chkInvService.UseVisualStyleBackColor = True
        '
        'btnAddService
        '
        Me.btnAddService.Image = CType(resources.GetObject("btnAddService.Image"), System.Drawing.Image)
        Me.btnAddService.Location = New System.Drawing.Point(671, 22)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(20, 20)
        Me.btnAddService.TabIndex = 11
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "RMK"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(109, 26)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(35, 13)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "Name"
        '
        'cbxType
        '
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Service", "Charge"})
        Me.cbxType.Location = New System.Drawing.Point(41, 24)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(62, 21)
        Me.cbxType.TabIndex = 1
        '
        'cbxServiceCurr
        '
        Me.cbxServiceCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServiceCurr.FormattingEnabled = True
        Me.cbxServiceCurr.Location = New System.Drawing.Point(418, 22)
        Me.cbxServiceCurr.Name = "cbxServiceCurr"
        Me.cbxServiceCurr.Size = New System.Drawing.Size(46, 21)
        Me.cbxServiceCurr.TabIndex = 6
        '
        'txtServiceQty
        '
        Me.txtServiceQty.Location = New System.Drawing.Point(506, 22)
        Me.txtServiceQty.MaxLength = 15
        Me.txtServiceQty.Name = "txtServiceQty"
        Me.txtServiceQty.Size = New System.Drawing.Size(27, 20)
        Me.txtServiceQty.TabIndex = 8
        Me.txtServiceQty.Text = "1"
        Me.txtServiceQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(477, 26)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(23, 13)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Qty"
        '
        'txtServiceRMK
        '
        Me.txtServiceRMK.Location = New System.Drawing.Point(41, 51)
        Me.txtServiceRMK.Name = "txtServiceRMK"
        Me.txtServiceRMK.Size = New System.Drawing.Size(649, 20)
        Me.txtServiceRMK.TabIndex = 13
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(384, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(26, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Curr"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(711, 148)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 13)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Total service charge"
        '
        'txtTotalServiceCharge
        '
        Me.txtTotalServiceCharge.Location = New System.Drawing.Point(833, 145)
        Me.txtTotalServiceCharge.MaxLength = 15
        Me.txtTotalServiceCharge.Name = "txtTotalServiceCharge"
        Me.txtTotalServiceCharge.ReadOnly = True
        Me.txtTotalServiceCharge.Size = New System.Drawing.Size(77, 20)
        Me.txtTotalServiceCharge.TabIndex = 44
        Me.txtTotalServiceCharge.Text = "0"
        Me.txtTotalServiceCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(118, 97)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Pax Type"
        '
        'cbxPaxType
        '
        Me.cbxPaxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPaxType.FormattingEnabled = True
        Me.cbxPaxType.Items.AddRange(New Object() {"ADL", "CHD", "INF"})
        Me.cbxPaxType.Location = New System.Drawing.Point(176, 91)
        Me.cbxPaxType.Name = "cbxPaxType"
        Me.cbxPaxType.Size = New System.Drawing.Size(52, 21)
        Me.cbxPaxType.TabIndex = 29
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(468, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "ROE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Ticket type"
        '
        'cbxTicketType
        '
        Me.cbxTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTicketType.FormattingEnabled = True
        Me.cbxTicketType.Items.AddRange(New Object() {"S", "V", "R", "E"})
        Me.cbxTicketType.Location = New System.Drawing.Point(70, 91)
        Me.cbxTicketType.Name = "cbxTicketType"
        Me.cbxTicketType.Size = New System.Drawing.Size(42, 21)
        Me.cbxTicketType.TabIndex = 27
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 337)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 13)
        Me.Label28.TabIndex = 49
        Me.Label28.Text = "Agent comm"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(161, 337)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 51
        Me.Label29.Text = "Person comm"
        '
        'txtAgentComm
        '
        Me.txtAgentComm.Location = New System.Drawing.Point(78, 334)
        Me.txtAgentComm.MaxLength = 15
        Me.txtAgentComm.Name = "txtAgentComm"
        Me.txtAgentComm.Size = New System.Drawing.Size(77, 20)
        Me.txtAgentComm.TabIndex = 50
        Me.txtAgentComm.Text = "0"
        Me.txtAgentComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPersonComm
        '
        Me.txtPersonComm.Location = New System.Drawing.Point(238, 334)
        Me.txtPersonComm.MaxLength = 15
        Me.txtPersonComm.Name = "txtPersonComm"
        Me.txtPersonComm.Size = New System.Drawing.Size(77, 20)
        Me.txtPersonComm.TabIndex = 52
        Me.txtPersonComm.Text = "0"
        Me.txtPersonComm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(359, 334)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(346, 20)
        Me.txtNote.TabIndex = 54
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(321, 337)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 13)
        Me.Label30.TabIndex = 53
        Me.Label30.Text = "Note"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1069, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(76, 626)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(58, 23)
        Me.btnPayment.TabIndex = 66
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(257, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Routing type"
        '
        'cbxRoutingType
        '
        Me.cbxRoutingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRoutingType.FormattingEnabled = True
        Me.cbxRoutingType.Items.AddRange(New Object() {"OW", "RT", "CT"})
        Me.cbxRoutingType.Location = New System.Drawing.Point(325, 34)
        Me.cbxRoutingType.Name = "cbxRoutingType"
        Me.cbxRoutingType.Size = New System.Drawing.Size(42, 21)
        Me.cbxRoutingType.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(260, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Cust type"
        '
        'cbxCustType
        '
        Me.cbxCustType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCustType.FormattingEnabled = True
        Me.cbxCustType.Items.AddRange(New Object() {"FIT", "GIT"})
        Me.cbxCustType.Location = New System.Drawing.Point(325, 7)
        Me.cbxCustType.Name = "cbxCustType"
        Me.cbxCustType.Size = New System.Drawing.Size(42, 21)
        Me.cbxCustType.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.IndianRed
        Me.Label16.Location = New System.Drawing.Point(569, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Balance Number"
        '
        'lblBalanceNumber
        '
        Me.lblBalanceNumber.AutoSize = True
        Me.lblBalanceNumber.ForeColor = System.Drawing.Color.IndianRed
        Me.lblBalanceNumber.Location = New System.Drawing.Point(661, 10)
        Me.lblBalanceNumber.Name = "lblBalanceNumber"
        Me.lblBalanceNumber.Size = New System.Drawing.Size(10, 13)
        Me.lblBalanceNumber.TabIndex = 9
        Me.lblBalanceNumber.Text = "-"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1020, 626)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 68
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'GridTicketking
        '
        Me.GridTicketking.AllowUserToAddRows = False
        Me.GridTicketking.AllowUserToDeleteRows = False
        Me.GridTicketking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridTicketking.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridTicketking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTicketking.Location = New System.Drawing.Point(566, 403)
        Me.GridTicketking.Name = "GridTicketking"
        Me.GridTicketking.ReadOnly = True
        Me.GridTicketking.RowHeadersVisible = False
        Me.GridTicketking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridTicketking.Size = New System.Drawing.Size(512, 217)
        Me.GridTicketking.TabIndex = 64
        '
        'txtTKNO
        '
        Me.txtTKNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTKNO.Location = New System.Drawing.Point(895, 192)
        Me.txtTKNO.Multiline = True
        Me.txtTKNO.Name = "txtTKNO"
        Me.txtTKNO.Size = New System.Drawing.Size(185, 136)
        Me.txtTKNO.TabIndex = 48
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(12, 626)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(58, 23)
        Me.btnImport.TabIndex = 65
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(892, 175)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 13)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Ticket Number"
        '
        'chkInvoice
        '
        Me.chkInvoice.AutoSize = True
        Me.chkInvoice.Location = New System.Drawing.Point(638, 69)
        Me.chkInvoice.Name = "chkInvoice"
        Me.chkInvoice.Size = New System.Drawing.Size(61, 17)
        Me.chkInvoice.TabIndex = 25
        Me.chkInvoice.Text = "Invoice"
        Me.chkInvoice.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomerName.Location = New System.Drawing.Point(634, 35)
        Me.txtCustomerName.MaxLength = 100
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(276, 20)
        Me.txtCustomerName.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(548, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Customer name"
        '
        'btnDeletePNR
        '
        Me.btnDeletePNR.Location = New System.Drawing.Point(485, 626)
        Me.btnDeletePNR.Name = "btnDeletePNR"
        Me.btnDeletePNR.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletePNR.TabIndex = 67
        Me.btnDeletePNR.Text = "Delete PNR"
        Me.btnDeletePNR.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Beyond_App.My.Resources.Resources.close
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 35
        '
        'bdsPNR
        '
        '
        'bdsTicketing
        '
        '
        'dtpFlightDate
        '
        Me.dtpFlightDate.Checked = False
        Me.dtpFlightDate.CustomFormat = "dd-MMM-yy"
        Me.dtpFlightDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFlightDate.Location = New System.Drawing.Point(395, 66)
        Me.dtpFlightDate.Name = "dtpFlightDate"
        Me.dtpFlightDate.Size = New System.Drawing.Size(78, 20)
        Me.dtpFlightDate.TabIndex = 22
        Me.dtpFlightDate.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(322, 69)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 13)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "Dept date"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(479, 69)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 13)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "Return date"
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Checked = False
        Me.dtpReturnDate.CustomFormat = "dd-MMM-yy"
        Me.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturnDate.Location = New System.Drawing.Point(551, 66)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(78, 20)
        Me.dtpReturnDate.TabIndex = 24
        Me.dtpReturnDate.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'chkInvidual
        '
        Me.chkInvidual.AutoSize = True
        Me.chkInvidual.Checked = True
        Me.chkInvidual.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInvidual.Location = New System.Drawing.Point(346, 376)
        Me.chkInvidual.Name = "chkInvidual"
        Me.chkInvidual.Size = New System.Drawing.Size(63, 17)
        Me.chkInvidual.TabIndex = 62
        Me.chkInvidual.Text = "Invidual"
        Me.chkInvidual.UseVisualStyleBackColor = True
        '
        'Ticketing_AirRail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.chkInvidual)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.btnDeletePNR)
        Me.Controls.Add(Me.chkInvoice)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.cbxCustType)
        Me.Controls.Add(Me.cbxRoutingType)
        Me.Controls.Add(Me.cbxTicketType)
        Me.Controls.Add(Me.cbxPaxType)
        Me.Controls.Add(Me.cbxCurr)
        Me.Controls.Add(Me.cbxCust)
        Me.Controls.Add(Me.chkKeepPNRCode)
        Me.Controls.Add(Me.cbxSupplier)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.dtpFlightDate)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.GridTicketking)
        Me.Controls.Add(Me.GridPNR)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtTotalServiceCharge)
        Me.Controls.Add(Me.txtTotalServiceFee)
        Me.Controls.Add(Me.txtFuelSurcharge)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtPersonComm)
        Me.Controls.Add(Me.txtAgentComm)
        Me.Controls.Add(Me.txtBasefareNet)
        Me.Controls.Add(Me.txtBasefareSell)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.txtROE)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblBalanceNumber)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItinerary)
        Me.Controls.Add(Me.txtTKNO)
        Me.Controls.Add(Me.txtPaxName)
        Me.Controls.Add(Me.txtSearchPNR)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.txtPNR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_AirRail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Air/Rail"
        CType(Me.GridPNR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridTicketking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsPNR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsTicketing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPNR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtROE As TextBox
    Friend WithEvents txtBasefareSell As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtItinerary As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GridPNR As DataGridView
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents txtSearchPNR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxSupplier As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPaxName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents chkKeepPNRCode As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbxCurr As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBasefareNet As TextBox
    Friend WithEvents txtTotalServiceFee As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtFuelSurcharge As TextBox
    Friend WithEvents cbxCust As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cbxServiceType As ComboBox
    Friend WithEvents btnAddService As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents GridService As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtTotalServiceCharge As TextBox
    Friend WithEvents txtServiceQty As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cbxPaxType As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtServiceRMK As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxTicketType As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtAgentComm As TextBox
    Friend WithEvents txtPersonComm As TextBox
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents cbxRoutingType As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbxCustType As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblBalanceNumber As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents GridTicketking As DataGridView
    Friend WithEvents txtTKNO As TextBox
    Friend WithEvents btnImport As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents chkInvService As CheckBox
    Friend WithEvents chkInvoice As CheckBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents bdsPNR As BindingSource
    Friend WithEvents bdsTicketing As BindingSource
    Friend WithEvents btnDeletePNR As Button
    Friend WithEvents Xoa As DataGridViewImageColumn
    Friend WithEvents ofdFile As OpenFileDialog
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents cbxServiceCurr As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cbxType As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents dtpFlightDate As DateTimePicker
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents chkInvidual As CheckBox
End Class
