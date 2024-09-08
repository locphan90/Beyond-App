<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticketing_CharterBuy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticketing_CharterBuy))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.clbBus = New System.Windows.Forms.CheckedListBox()
        Me.GridCode = New System.Windows.Forms.DataGridView()
        Me.GridLand = New System.Windows.Forms.DataGridView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dtpDeptDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescr = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRefPrice = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtContractorFee = New System.Windows.Forms.TextBox()
        Me.txtRefPriceY = New System.Windows.Forms.TextBox()
        Me.txtRefPriceC = New System.Windows.Forms.TextBox()
        Me.txtTotalAirAmount = New System.Windows.Forms.TextBox()
        Me.txtQtyY = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtQtyC = New System.Windows.Forms.TextBox()
        Me.btnUpdateAir = New System.Windows.Forms.Button()
        Me.btnDeleteInfo = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxAirSupplier = New System.Windows.Forms.ComboBox()
        Me.cbxSupplier = New System.Windows.Forms.ComboBox()
        Me.cbxCurrAir = New System.Windows.Forms.ComboBox()
        Me.cbxCurrLand = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.bdsCode = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsLand = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.bdsCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsLand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCode.Location = New System.Drawing.Point(50, 12)
        Me.txtCode.MaxLength = 10
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(97, 20)
        Me.txtCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Type"
        '
        'cbxType
        '
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"3 sao", "4 sao", "5 sao", "Khác"})
        Me.cbxType.Location = New System.Drawing.Point(200, 58)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(48, 21)
        Me.cbxType.TabIndex = 4
        '
        'clbBus
        '
        Me.clbBus.CheckOnClick = True
        Me.clbBus.ColumnWidth = 33
        Me.clbBus.FormattingEnabled = True
        Me.clbBus.Location = New System.Drawing.Point(483, 58)
        Me.clbBus.MultiColumn = True
        Me.clbBus.Name = "clbBus"
        Me.clbBus.Size = New System.Drawing.Size(213, 34)
        Me.clbBus.TabIndex = 14
        '
        'GridCode
        '
        Me.GridCode.AllowUserToAddRows = False
        Me.GridCode.AllowUserToDeleteRows = False
        Me.GridCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridCode.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridCode.Location = New System.Drawing.Point(12, 130)
        Me.GridCode.Name = "GridCode"
        Me.GridCode.ReadOnly = True
        Me.GridCode.RowHeadersVisible = False
        Me.GridCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridCode.Size = New System.Drawing.Size(282, 499)
        Me.GridCode.TabIndex = 12
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
        Me.GridLand.Location = New System.Drawing.Point(9, 98)
        Me.GridLand.Name = "GridLand"
        Me.GridLand.ReadOnly = True
        Me.GridLand.RowHeadersVisible = False
        Me.GridLand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridLand.Size = New System.Drawing.Size(751, 222)
        Me.GridLand.TabIndex = 16
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(236, 64)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(58, 23)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(236, 633)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dtpDeptDate
        '
        Me.dtpDeptDate.Checked = False
        Me.dtpDeptDate.CustomFormat = "dd-MMM-yy"
        Me.dtpDeptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeptDate.Location = New System.Drawing.Point(69, 38)
        Me.dtpDeptDate.Name = "dtpDeptDate"
        Me.dtpDeptDate.Size = New System.Drawing.Size(78, 20)
        Me.dtpDeptDate.TabIndex = 3
        Me.dtpDeptDate.Value = New Date(2024, 9, 6, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dept date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descr"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(50, 65)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(180, 20)
        Me.txtDescr.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Location = New System.Drawing.Point(10, 102)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "(Search follow code)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRefPrice)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtContractorFee)
        Me.GroupBox2.Controls.Add(Me.txtRefPriceY)
        Me.GroupBox2.Controls.Add(Me.txtRefPriceC)
        Me.GroupBox2.Controls.Add(Me.txtTotalAirAmount)
        Me.GroupBox2.Controls.Add(Me.txtQtyY)
        Me.GroupBox2.Controls.Add(Me.txtQty)
        Me.GroupBox2.Controls.Add(Me.txtQtyC)
        Me.GroupBox2.Controls.Add(Me.clbBus)
        Me.GroupBox2.Controls.Add(Me.btnUpdateAir)
        Me.GroupBox2.Controls.Add(Me.btnDeleteInfo)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cbxAirSupplier)
        Me.GroupBox2.Controls.Add(Me.cbxSupplier)
        Me.GroupBox2.Controls.Add(Me.cbxCurrAir)
        Me.GroupBox2.Controls.Add(Me.cbxCurrLand)
        Me.GroupBox2.Controls.Add(Me.cbxType)
        Me.GroupBox2.Controls.Add(Me.GridLand)
        Me.GroupBox2.Location = New System.Drawing.Point(306, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 649)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buy information"
        '
        'txtRefPrice
        '
        Me.txtRefPrice.Location = New System.Drawing.Point(416, 58)
        Me.txtRefPrice.MaxLength = 15
        Me.txtRefPrice.Name = "txtRefPrice"
        Me.txtRefPrice.Size = New System.Drawing.Size(61, 20)
        Me.txtRefPrice.TabIndex = 12
        Me.txtRefPrice.Text = "0"
        Me.txtRefPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(353, 58)
        Me.txtPrice.MaxLength = 15
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(61, 20)
        Me.txtPrice.TabIndex = 10
        Me.txtPrice.Text = "0"
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContractorFee
        '
        Me.txtContractorFee.Location = New System.Drawing.Point(679, 388)
        Me.txtContractorFee.MaxLength = 15
        Me.txtContractorFee.Name = "txtContractorFee"
        Me.txtContractorFee.Size = New System.Drawing.Size(81, 20)
        Me.txtContractorFee.TabIndex = 35
        Me.txtContractorFee.Text = "0"
        Me.txtContractorFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRefPriceY
        '
        Me.txtRefPriceY.Location = New System.Drawing.Point(505, 388)
        Me.txtRefPriceY.MaxLength = 15
        Me.txtRefPriceY.Name = "txtRefPriceY"
        Me.txtRefPriceY.Size = New System.Drawing.Size(81, 20)
        Me.txtRefPriceY.TabIndex = 31
        Me.txtRefPriceY.Text = "0"
        Me.txtRefPriceY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRefPriceC
        '
        Me.txtRefPriceC.Location = New System.Drawing.Point(378, 388)
        Me.txtRefPriceC.MaxLength = 15
        Me.txtRefPriceC.Name = "txtRefPriceC"
        Me.txtRefPriceC.Size = New System.Drawing.Size(81, 20)
        Me.txtRefPriceC.TabIndex = 27
        Me.txtRefPriceC.Text = "0"
        Me.txtRefPriceC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAirAmount
        '
        Me.txtTotalAirAmount.Location = New System.Drawing.Point(592, 388)
        Me.txtTotalAirAmount.MaxLength = 15
        Me.txtTotalAirAmount.Name = "txtTotalAirAmount"
        Me.txtTotalAirAmount.Size = New System.Drawing.Size(81, 20)
        Me.txtTotalAirAmount.TabIndex = 33
        Me.txtTotalAirAmount.Text = "0"
        Me.txtTotalAirAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtyY
        '
        Me.txtQtyY.Location = New System.Drawing.Point(465, 388)
        Me.txtQtyY.MaxLength = 15
        Me.txtQtyY.Name = "txtQtyY"
        Me.txtQtyY.Size = New System.Drawing.Size(34, 20)
        Me.txtQtyY.TabIndex = 29
        Me.txtQtyY.Text = "0"
        Me.txtQtyY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(254, 58)
        Me.txtQty.MaxLength = 15
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(39, 20)
        Me.txtQty.TabIndex = 6
        Me.txtQty.Text = "0"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtyC
        '
        Me.txtQtyC.Location = New System.Drawing.Point(338, 389)
        Me.txtQtyC.MaxLength = 15
        Me.txtQtyC.Name = "txtQtyC"
        Me.txtQtyC.Size = New System.Drawing.Size(34, 20)
        Me.txtQtyC.TabIndex = 25
        Me.txtQtyC.Text = "0"
        Me.txtQtyC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnUpdateAir
        '
        Me.btnUpdateAir.Location = New System.Drawing.Point(679, 414)
        Me.btnUpdateAir.Name = "btnUpdateAir"
        Me.btnUpdateAir.Size = New System.Drawing.Size(82, 23)
        Me.btnUpdateAir.TabIndex = 36
        Me.btnUpdateAir.Text = "Update Air"
        Me.btnUpdateAir.UseVisualStyleBackColor = True
        '
        'btnDeleteInfo
        '
        Me.btnDeleteInfo.Location = New System.Drawing.Point(702, 326)
        Me.btnDeleteInfo.Name = "btnDeleteInfo"
        Me.btnDeleteInfo.Size = New System.Drawing.Size(58, 23)
        Me.btnDeleteInfo.TabIndex = 17
        Me.btnDeleteInfo.Text = "Delete"
        Me.btnDeleteInfo.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(702, 58)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(480, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Bus number"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label23.Location = New System.Drawing.Point(7, 621)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(363, 24)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Note: Ref Price, Contractor Fee push VND"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(676, 372)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Contractor Fee"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(413, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Ref Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Price"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(589, 372)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Total Air Amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(462, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Qty Y"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 350)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(691, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = resources.GetString("Label12.Text")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(6, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "  LAND  "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(251, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Qty"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(6, 350)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "    AIR   "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(502, 372)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Ref price (Y)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(374, 372)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Ref price (C)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(335, 372)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Qty C"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 372)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Air Supplier"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Land Supplier"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(281, 371)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(26, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Curr"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(296, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Curr"
        '
        'cbxAirSupplier
        '
        Me.cbxAirSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAirSupplier.FormattingEnabled = True
        Me.cbxAirSupplier.Location = New System.Drawing.Point(10, 388)
        Me.cbxAirSupplier.Name = "cbxAirSupplier"
        Me.cbxAirSupplier.Size = New System.Drawing.Size(268, 21)
        Me.cbxAirSupplier.TabIndex = 21
        '
        'cbxSupplier
        '
        Me.cbxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSupplier.FormattingEnabled = True
        Me.cbxSupplier.Location = New System.Drawing.Point(11, 58)
        Me.cbxSupplier.Name = "cbxSupplier"
        Me.cbxSupplier.Size = New System.Drawing.Size(183, 21)
        Me.cbxSupplier.TabIndex = 2
        '
        'cbxCurrAir
        '
        Me.cbxCurrAir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurrAir.FormattingEnabled = True
        Me.cbxCurrAir.Items.AddRange(New Object() {"3 sao", "4 sao", "5 sao", "Khác"})
        Me.cbxCurrAir.Location = New System.Drawing.Point(284, 389)
        Me.cbxCurrAir.Name = "cbxCurrAir"
        Me.cbxCurrAir.Size = New System.Drawing.Size(48, 21)
        Me.cbxCurrAir.TabIndex = 23
        '
        'cbxCurrLand
        '
        Me.cbxCurrLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCurrLand.FormattingEnabled = True
        Me.cbxCurrLand.Items.AddRange(New Object() {"3 sao", "4 sao", "5 sao", "Khác"})
        Me.cbxCurrLand.Location = New System.Drawing.Point(299, 58)
        Me.cbxCurrLand.Name = "cbxCurrLand"
        Me.cbxCurrLand.Size = New System.Drawing.Size(48, 21)
        Me.cbxCurrLand.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(292, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "---------------------------------------------------------------------------------" &
    "--------------"
        '
        'btnSell
        '
        Me.btnSell.Location = New System.Drawing.Point(11, 633)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(58, 23)
        Me.btnSell.TabIndex = 13
        Me.btnSell.Text = "Sell"
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(156, 41)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(50, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "End date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(216, 36)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(78, 20)
        Me.dtpEndDate.TabIndex = 5
        Me.dtpEndDate.Value = New Date(2024, 9, 6, 0, 0, 0, 0)
        '
        'bdsCode
        '
        '
        'bdsLand
        '
        '
        'Ticketing_CharterBuy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.btnSell)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpDeptDate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.GridCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_CharterBuy"
        Me.Text = "Charter Buy"
        CType(Me.GridCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.bdsCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsLand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxType As ComboBox
    Friend WithEvents clbBus As CheckedListBox
    Friend WithEvents GridCode As DataGridView
    Friend WithEvents GridLand As DataGridView
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dtpDeptDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescr As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQtyC As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtQtyY As TextBox
    Friend WithEvents btnUpdateAir As Button
    Friend WithEvents btnDeleteInfo As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbxAirSupplier As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cbxSupplier As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTotalAirAmount As TextBox
    Friend WithEvents bdsCode As BindingSource
    Friend WithEvents bdsLand As BindingSource
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtContractorFee As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtRefPriceY As TextBox
    Friend WithEvents txtRefPriceC As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtRefPrice As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cbxCurrLand As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cbxCurrAir As ComboBox
    Friend WithEvents btnSell As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents dtpEndDate As DateTimePicker
End Class
