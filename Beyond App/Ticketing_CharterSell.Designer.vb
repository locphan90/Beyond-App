<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticketing_CharterSell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticketing_CharterSell))
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLandAmt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtyC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQtyY = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmtC = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAmtY = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTKNO = New System.Windows.Forms.TextBox()
        Me.txtPaxName = New System.Windows.Forms.TextBox()
        Me.GridCharterSell = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxServiceType = New System.Windows.Forms.ComboBox()
        Me.cbxServiceName = New System.Windows.Forms.ComboBox()
        Me.txtServiceAmount = New System.Windows.Forms.TextBox()
        Me.GridService = New System.Windows.Forms.DataGridView()
        Me.Xoa = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtServiceQty = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtServiceRMK = New System.Windows.Forms.TextBox()
        Me.GridLand = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnLandAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxBus = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBusAmt = New System.Windows.Forms.TextBox()
        Me.cbxLandType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLandQty = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLandRMK = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblRefAmtY = New System.Windows.Forms.Label()
        Me.lblQtyY = New System.Windows.Forms.Label()
        Me.lblRefAmtC = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblQtyC = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GridRefLand = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtTtlAmtAir = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtTtlAmtService = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtTtlAmtLand = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtTtlAmt = New System.Windows.Forms.TextBox()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPNR = New System.Windows.Forms.TextBox()
        CType(Me.GridCharterSell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GridRefLand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustName
        '
        Me.txtCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustName.Location = New System.Drawing.Point(12, 19)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(172, 20)
        Me.txtCustName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cust name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(266, 19)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(84, 20)
        Me.txtPhone.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Land Amt"
        '
        'txtLandAmt
        '
        Me.txtLandAmt.Location = New System.Drawing.Point(225, 21)
        Me.txtLandAmt.MaxLength = 15
        Me.txtLandAmt.Name = "txtLandAmt"
        Me.txtLandAmt.Size = New System.Drawing.Size(83, 20)
        Me.txtLandAmt.TabIndex = 5
        Me.txtLandAmt.Text = "0"
        Me.txtLandAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Qty C"
        '
        'txtQtyC
        '
        Me.txtQtyC.Location = New System.Drawing.Point(356, 18)
        Me.txtQtyC.MaxLength = 15
        Me.txtQtyC.Name = "txtQtyC"
        Me.txtQtyC.Size = New System.Drawing.Size(33, 20)
        Me.txtQtyC.TabIndex = 7
        Me.txtQtyC.Text = "0"
        Me.txtQtyC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Qty Y"
        '
        'txtQtyY
        '
        Me.txtQtyY.Location = New System.Drawing.Point(478, 18)
        Me.txtQtyY.MaxLength = 15
        Me.txtQtyY.Name = "txtQtyY"
        Me.txtQtyY.Size = New System.Drawing.Size(33, 20)
        Me.txtQtyY.TabIndex = 11
        Me.txtQtyY.Text = "0"
        Me.txtQtyY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(395, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Amt C"
        '
        'txtAmtC
        '
        Me.txtAmtC.Location = New System.Drawing.Point(395, 18)
        Me.txtAmtC.MaxLength = 15
        Me.txtAmtC.Name = "txtAmtC"
        Me.txtAmtC.Size = New System.Drawing.Size(77, 20)
        Me.txtAmtC.TabIndex = 9
        Me.txtAmtC.Text = "0"
        Me.txtAmtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(514, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Amt Y"
        '
        'txtAmtY
        '
        Me.txtAmtY.Location = New System.Drawing.Point(517, 19)
        Me.txtAmtY.MaxLength = 15
        Me.txtAmtY.Name = "txtAmtY"
        Me.txtAmtY.Size = New System.Drawing.Size(77, 20)
        Me.txtAmtY.TabIndex = 13
        Me.txtAmtY.Text = "0"
        Me.txtAmtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(298, 446)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 13)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Ticket Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Pax name"
        '
        'txtTKNO
        '
        Me.txtTKNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTKNO.Location = New System.Drawing.Point(301, 462)
        Me.txtTKNO.Multiline = True
        Me.txtTKNO.Name = "txtTKNO"
        Me.txtTKNO.Size = New System.Drawing.Size(300, 158)
        Me.txtTKNO.TabIndex = 27
        '
        'txtPaxName
        '
        Me.txtPaxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaxName.Location = New System.Drawing.Point(12, 462)
        Me.txtPaxName.Multiline = True
        Me.txtPaxName.Name = "txtPaxName"
        Me.txtPaxName.Size = New System.Drawing.Size(282, 158)
        Me.txtPaxName.TabIndex = 25
        '
        'GridCharterSell
        '
        Me.GridCharterSell.AllowUserToAddRows = False
        Me.GridCharterSell.AllowUserToDeleteRows = False
        Me.GridCharterSell.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCharterSell.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridCharterSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCharterSell.Location = New System.Drawing.Point(607, 183)
        Me.GridCharterSell.Name = "GridCharterSell"
        Me.GridCharterSell.ReadOnly = True
        Me.GridCharterSell.RowHeadersVisible = False
        Me.GridCharterSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCharterSell.Size = New System.Drawing.Size(467, 439)
        Me.GridCharterSell.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.btnAddService)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cbxServiceType)
        Me.GroupBox1.Controls.Add(Me.cbxServiceName)
        Me.GroupBox1.Controls.Add(Me.txtServiceAmount)
        Me.GroupBox1.Controls.Add(Me.GridService)
        Me.GroupBox1.Controls.Add(Me.txtServiceQty)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtServiceRMK)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 226)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 176)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other services/Charge"
        '
        'btnAddService
        '
        Me.btnAddService.Image = CType(resources.GetObject("btnAddService.Image"), System.Drawing.Image)
        Me.btnAddService.Location = New System.Drawing.Point(559, 22)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(20, 20)
        Me.btnAddService.TabIndex = 8
        Me.btnAddService.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 9
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Type"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(378, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Amount"
        '
        'cbxServiceType
        '
        Me.cbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServiceType.FormattingEnabled = True
        Me.cbxServiceType.Items.AddRange(New Object() {"Service", "Charge"})
        Me.cbxServiceType.Location = New System.Drawing.Point(41, 24)
        Me.cbxServiceType.Name = "cbxServiceType"
        Me.cbxServiceType.Size = New System.Drawing.Size(62, 21)
        Me.cbxServiceType.TabIndex = 1
        '
        'cbxServiceName
        '
        Me.cbxServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxServiceName.FormattingEnabled = True
        Me.cbxServiceName.Location = New System.Drawing.Point(150, 23)
        Me.cbxServiceName.Name = "cbxServiceName"
        Me.cbxServiceName.Size = New System.Drawing.Size(160, 21)
        Me.cbxServiceName.TabIndex = 3
        '
        'txtServiceAmount
        '
        Me.txtServiceAmount.Location = New System.Drawing.Point(427, 23)
        Me.txtServiceAmount.MaxLength = 15
        Me.txtServiceAmount.Name = "txtServiceAmount"
        Me.txtServiceAmount.Size = New System.Drawing.Size(77, 20)
        Me.txtServiceAmount.TabIndex = 7
        Me.txtServiceAmount.Text = "0"
        Me.txtServiceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.GridService.Location = New System.Drawing.Point(7, 77)
        Me.GridService.Name = "GridService"
        Me.GridService.ReadOnly = True
        Me.GridService.RowHeadersVisible = False
        Me.GridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridService.Size = New System.Drawing.Size(572, 93)
        Me.GridService.TabIndex = 11
        '
        'Xoa
        '
        Me.Xoa.HeaderText = ""
        Me.Xoa.Image = Global.Beyond_App.My.Resources.Resources.close
        Me.Xoa.Name = "Xoa"
        Me.Xoa.ReadOnly = True
        Me.Xoa.Width = 35
        '
        'txtServiceQty
        '
        Me.txtServiceQty.Location = New System.Drawing.Point(345, 23)
        Me.txtServiceQty.MaxLength = 15
        Me.txtServiceQty.Name = "txtServiceQty"
        Me.txtServiceQty.Size = New System.Drawing.Size(27, 20)
        Me.txtServiceQty.TabIndex = 5
        Me.txtServiceQty.Text = "1"
        Me.txtServiceQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(316, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(23, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Qty"
        '
        'txtServiceRMK
        '
        Me.txtServiceRMK.Location = New System.Drawing.Point(41, 51)
        Me.txtServiceRMK.Name = "txtServiceRMK"
        Me.txtServiceRMK.Size = New System.Drawing.Size(538, 20)
        Me.txtServiceRMK.TabIndex = 10
        '
        'GridLand
        '
        Me.GridLand.AllowUserToAddRows = False
        Me.GridLand.AllowUserToDeleteRows = False
        Me.GridLand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridLand.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridLand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridLand.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        Me.GridLand.Location = New System.Drawing.Point(6, 77)
        Me.GridLand.Name = "GridLand"
        Me.GridLand.ReadOnly = True
        Me.GridLand.RowHeadersVisible = False
        Me.GridLand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridLand.Size = New System.Drawing.Size(579, 93)
        Me.GridLand.TabIndex = 12
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Beyond_App.My.Resources.Resources.close
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 35
        '
        'btnLandAdd
        '
        Me.btnLandAdd.Image = CType(resources.GetObject("btnLandAdd.Image"), System.Drawing.Image)
        Me.btnLandAdd.Location = New System.Drawing.Point(562, 22)
        Me.btnLandAdd.Name = "btnLandAdd"
        Me.btnLandAdd.Size = New System.Drawing.Size(20, 20)
        Me.btnLandAdd.TabIndex = 13
        Me.btnLandAdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(314, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bus"
        '
        'cbxBus
        '
        Me.cbxBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxBus.FormattingEnabled = True
        Me.cbxBus.Location = New System.Drawing.Point(345, 21)
        Me.cbxBus.Name = "cbxBus"
        Me.cbxBus.Size = New System.Drawing.Size(39, 21)
        Me.cbxBus.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(390, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Bus Amt"
        '
        'txtBusAmt
        '
        Me.txtBusAmt.Location = New System.Drawing.Point(436, 22)
        Me.txtBusAmt.MaxLength = 15
        Me.txtBusAmt.Name = "txtBusAmt"
        Me.txtBusAmt.Size = New System.Drawing.Size(68, 20)
        Me.txtBusAmt.TabIndex = 9
        Me.txtBusAmt.Text = "0"
        Me.txtBusAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxLandType
        '
        Me.cbxLandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLandType.FormattingEnabled = True
        Me.cbxLandType.Items.AddRange(New Object() {"3 sao", "4 sao", "5 sao", "Khác"})
        Me.cbxLandType.Location = New System.Drawing.Point(40, 21)
        Me.cbxLandType.Name = "cbxLandType"
        Me.cbxLandType.Size = New System.Drawing.Size(60, 21)
        Me.cbxLandType.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox2.Controls.Add(Me.GridLand)
        Me.GroupBox2.Controls.Add(Me.cbxLandType)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnLandAdd)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbxBus)
        Me.GroupBox2.Controls.Add(Me.txtLandAmt)
        Me.GroupBox2.Controls.Add(Me.txtLandQty)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtBusAmt)
        Me.GroupBox2.Controls.Add(Me.txtLandRMK)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 176)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Land"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "RMK"
        '
        'txtLandQty
        '
        Me.txtLandQty.Location = New System.Drawing.Point(134, 21)
        Me.txtLandQty.MaxLength = 15
        Me.txtLandQty.Name = "txtLandQty"
        Me.txtLandQty.Size = New System.Drawing.Size(27, 20)
        Me.txtLandQty.TabIndex = 3
        Me.txtLandQty.Text = "1"
        Me.txtLandQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(106, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Qty"
        '
        'txtLandRMK
        '
        Me.txtLandRMK.Location = New System.Drawing.Point(40, 51)
        Me.txtLandRMK.Name = "txtLandRMK"
        Me.txtLandRMK.Size = New System.Drawing.Size(543, 20)
        Me.txtLandRMK.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(539, 626)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(475, 626)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(58, 23)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(411, 626)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(58, 23)
        Me.btnNew.TabIndex = 28
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1016, 628)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(952, 628)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(58, 23)
        Me.btnPayment.TabIndex = 33
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblRefAmtY)
        Me.Panel1.Controls.Add(Me.lblQtyY)
        Me.Panel1.Controls.Add(Me.lblRefAmtC)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lblQtyC)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.GridRefLand)
        Me.Panel1.Location = New System.Drawing.Point(607, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 174)
        Me.Panel1.TabIndex = 31
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(14, 151)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Ref Amt Y"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Ref Amt C"
        '
        'lblRefAmtY
        '
        Me.lblRefAmtY.AutoSize = True
        Me.lblRefAmtY.Location = New System.Drawing.Point(75, 151)
        Me.lblRefAmtY.Name = "lblRefAmtY"
        Me.lblRefAmtY.Size = New System.Drawing.Size(10, 13)
        Me.lblRefAmtY.TabIndex = 7
        Me.lblRefAmtY.Text = "-"
        '
        'lblQtyY
        '
        Me.lblQtyY.AutoSize = True
        Me.lblQtyY.Location = New System.Drawing.Point(75, 105)
        Me.lblQtyY.Name = "lblQtyY"
        Me.lblQtyY.Size = New System.Drawing.Size(10, 13)
        Me.lblQtyY.TabIndex = 5
        Me.lblQtyY.Text = "-"
        '
        'lblRefAmtC
        '
        Me.lblRefAmtC.AutoSize = True
        Me.lblRefAmtC.Location = New System.Drawing.Point(75, 62)
        Me.lblRefAmtC.Name = "lblRefAmtC"
        Me.lblRefAmtC.Size = New System.Drawing.Size(10, 13)
        Me.lblRefAmtC.TabIndex = 3
        Me.lblRefAmtC.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 105)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Qty Y"
        '
        'lblQtyC
        '
        Me.lblQtyC.AutoSize = True
        Me.lblQtyC.Location = New System.Drawing.Point(75, 16)
        Me.lblQtyC.Name = "lblQtyC"
        Me.lblQtyC.Size = New System.Drawing.Size(10, 13)
        Me.lblQtyC.TabIndex = 1
        Me.lblQtyC.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Qty C"
        '
        'GridRefLand
        '
        Me.GridRefLand.AllowUserToAddRows = False
        Me.GridRefLand.AllowUserToDeleteRows = False
        Me.GridRefLand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridRefLand.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridRefLand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridRefLand.Location = New System.Drawing.Point(194, 4)
        Me.GridRefLand.Name = "GridRefLand"
        Me.GridRefLand.ReadOnly = True
        Me.GridRefLand.RowHeadersVisible = False
        Me.GridRefLand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridRefLand.Size = New System.Drawing.Size(270, 165)
        Me.GridRefLand.TabIndex = 8
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(12, 403)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Total Amt Air"
        '
        'txtTtlAmtAir
        '
        Me.txtTtlAmtAir.Location = New System.Drawing.Point(12, 419)
        Me.txtTtlAmtAir.MaxLength = 15
        Me.txtTtlAmtAir.Name = "txtTtlAmtAir"
        Me.txtTtlAmtAir.ReadOnly = True
        Me.txtTtlAmtAir.Size = New System.Drawing.Size(90, 20)
        Me.txtTtlAmtAir.TabIndex = 17
        Me.txtTtlAmtAir.Text = "0"
        Me.txtTtlAmtAir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(101, 403)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Total Amt Land"
        '
        'txtTtlAmtService
        '
        Me.txtTtlAmtService.Location = New System.Drawing.Point(204, 419)
        Me.txtTtlAmtService.MaxLength = 15
        Me.txtTtlAmtService.Name = "txtTtlAmtService"
        Me.txtTtlAmtService.ReadOnly = True
        Me.txtTtlAmtService.Size = New System.Drawing.Size(90, 20)
        Me.txtTtlAmtService.TabIndex = 21
        Me.txtTtlAmtService.Text = "0"
        Me.txtTtlAmtService.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(201, 403)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(91, 13)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "Total Amt Service"
        '
        'txtTtlAmtLand
        '
        Me.txtTtlAmtLand.Location = New System.Drawing.Point(108, 419)
        Me.txtTtlAmtLand.MaxLength = 15
        Me.txtTtlAmtLand.Name = "txtTtlAmtLand"
        Me.txtTtlAmtLand.ReadOnly = True
        Me.txtTtlAmtLand.Size = New System.Drawing.Size(90, 20)
        Me.txtTtlAmtLand.TabIndex = 19
        Me.txtTtlAmtLand.Text = "0"
        Me.txtTtlAmtLand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(298, 403)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 13)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "Total"
        '
        'txtTtlAmt
        '
        Me.txtTtlAmt.Location = New System.Drawing.Point(300, 419)
        Me.txtTtlAmt.MaxLength = 15
        Me.txtTtlAmt.Name = "txtTtlAmt"
        Me.txtTtlAmt.ReadOnly = True
        Me.txtTtlAmt.Size = New System.Drawing.Size(90, 20)
        Me.txtTtlAmt.TabIndex = 23
        Me.txtTtlAmt.Text = "0"
        Me.txtTtlAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bdsView
        '
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(190, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "PNR"
        '
        'txtPNR
        '
        Me.txtPNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNR.Location = New System.Drawing.Point(190, 19)
        Me.txtPNR.MaxLength = 6
        Me.txtPNR.Name = "txtPNR"
        Me.txtPNR.Size = New System.Drawing.Size(70, 20)
        Me.txtPNR.TabIndex = 3
        '
        'Ticketing_CharterSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GridCharterSell)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTKNO)
        Me.Controls.Add(Me.txtPaxName)
        Me.Controls.Add(Me.txtQtyY)
        Me.Controls.Add(Me.txtQtyC)
        Me.Controls.Add(Me.txtAmtY)
        Me.Controls.Add(Me.txtTtlAmtLand)
        Me.Controls.Add(Me.txtTtlAmt)
        Me.Controls.Add(Me.txtTtlAmtService)
        Me.Controls.Add(Me.txtTtlAmtAir)
        Me.Controls.Add(Me.txtAmtC)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPNR)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtCustName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_CharterSell"
        Me.Text = "Chater Sell"
        CType(Me.GridCharterSell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridRefLand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLandAmt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtyC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQtyY As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAmtC As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAmtY As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTKNO As TextBox
    Friend WithEvents txtPaxName As TextBox
    Friend WithEvents GridCharterSell As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddService As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxServiceType As ComboBox
    Friend WithEvents cbxServiceName As ComboBox
    Friend WithEvents txtServiceAmount As TextBox
    Friend WithEvents GridService As DataGridView
    Friend WithEvents Xoa As DataGridViewImageColumn
    Friend WithEvents txtServiceQty As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtServiceRMK As TextBox
    Friend WithEvents GridLand As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents btnLandAdd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxBus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBusAmt As TextBox
    Friend WithEvents cbxLandType As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtLandRMK As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtLandQty As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnPayment As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GridRefLand As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents lblRefAmtY As Label
    Friend WithEvents lblQtyY As Label
    Friend WithEvents lblRefAmtC As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblQtyC As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtTtlAmtAir As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtTtlAmtService As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtTtlAmtLand As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtTtlAmt As TextBox
    Friend WithEvents bdsView As BindingSource
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPNR As TextBox
End Class
