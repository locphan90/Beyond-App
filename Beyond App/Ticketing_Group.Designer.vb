<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ticketing_Group
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ticketing_Group))
        Me.dtpDepo1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDepo2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDepo3 = New System.Windows.Forms.DateTimePicker()
        Me.dtpReduceSeat = New System.Windows.Forms.DateTimePicker()
        Me.dtpName = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpDeadline = New System.Windows.Forms.GroupBox()
        Me.txtRMK5 = New System.Windows.Forms.TextBox()
        Me.txtRMK4 = New System.Windows.Forms.TextBox()
        Me.txtRMK3 = New System.Windows.Forms.TextBox()
        Me.txtRMK2 = New System.Windows.Forms.TextBox()
        Me.txtRMK1 = New System.Windows.Forms.TextBox()
        Me.cbxAgent = New System.Windows.Forms.ComboBox()
        Me.txtContractNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPNR = New System.Windows.Forms.TextBox()
        Me.txtTKNO = New System.Windows.Forms.TextBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeptDate = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtItinerary = New System.Windows.Forms.TextBox()
        Me.txtNetAmt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSellAmt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.GridGroup = New System.Windows.Forms.DataGridView()
        Me.cbxRoutingType = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblAgent = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSearchPNR = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRMK = New System.Windows.Forms.TextBox()
        Me.bdsView = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpDeadline.SuspendLayout()
        CType(Me.GridGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDepo1
        '
        Me.dtpDepo1.Checked = False
        Me.dtpDepo1.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepo1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepo1.Location = New System.Drawing.Point(79, 18)
        Me.dtpDepo1.Name = "dtpDepo1"
        Me.dtpDepo1.ShowCheckBox = True
        Me.dtpDepo1.Size = New System.Drawing.Size(100, 20)
        Me.dtpDepo1.TabIndex = 1
        Me.dtpDepo1.Value = New Date(2024, 9, 3, 0, 0, 0, 0)
        '
        'dtpDepo2
        '
        Me.dtpDepo2.Checked = False
        Me.dtpDepo2.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepo2.Location = New System.Drawing.Point(79, 44)
        Me.dtpDepo2.Name = "dtpDepo2"
        Me.dtpDepo2.ShowCheckBox = True
        Me.dtpDepo2.Size = New System.Drawing.Size(100, 20)
        Me.dtpDepo2.TabIndex = 4
        Me.dtpDepo2.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'dtpDepo3
        '
        Me.dtpDepo3.Checked = False
        Me.dtpDepo3.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDepo3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDepo3.Location = New System.Drawing.Point(79, 69)
        Me.dtpDepo3.Name = "dtpDepo3"
        Me.dtpDepo3.ShowCheckBox = True
        Me.dtpDepo3.Size = New System.Drawing.Size(100, 20)
        Me.dtpDepo3.TabIndex = 7
        Me.dtpDepo3.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'dtpReduceSeat
        '
        Me.dtpReduceSeat.Checked = False
        Me.dtpReduceSeat.CustomFormat = "dd-MMM-yyyy"
        Me.dtpReduceSeat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReduceSeat.Location = New System.Drawing.Point(79, 95)
        Me.dtpReduceSeat.Name = "dtpReduceSeat"
        Me.dtpReduceSeat.ShowCheckBox = True
        Me.dtpReduceSeat.Size = New System.Drawing.Size(100, 20)
        Me.dtpReduceSeat.TabIndex = 10
        Me.dtpReduceSeat.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'dtpName
        '
        Me.dtpName.Checked = False
        Me.dtpName.CustomFormat = "dd-MMM-yyyy"
        Me.dtpName.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpName.Location = New System.Drawing.Point(79, 121)
        Me.dtpName.Name = "dtpName"
        Me.dtpName.ShowCheckBox = True
        Me.dtpName.Size = New System.Drawing.Size(100, 20)
        Me.dtpName.TabIndex = 13
        Me.dtpName.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deposit 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Deposit 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Deposit 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Reduce seat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Name"
        '
        'grpDeadline
        '
        Me.grpDeadline.Controls.Add(Me.txtRMK5)
        Me.grpDeadline.Controls.Add(Me.txtRMK4)
        Me.grpDeadline.Controls.Add(Me.txtRMK3)
        Me.grpDeadline.Controls.Add(Me.txtRMK2)
        Me.grpDeadline.Controls.Add(Me.txtRMK1)
        Me.grpDeadline.Controls.Add(Me.dtpDepo2)
        Me.grpDeadline.Controls.Add(Me.Label5)
        Me.grpDeadline.Controls.Add(Me.dtpDepo1)
        Me.grpDeadline.Controls.Add(Me.Label4)
        Me.grpDeadline.Controls.Add(Me.dtpDepo3)
        Me.grpDeadline.Controls.Add(Me.Label3)
        Me.grpDeadline.Controls.Add(Me.dtpReduceSeat)
        Me.grpDeadline.Controls.Add(Me.Label2)
        Me.grpDeadline.Controls.Add(Me.dtpName)
        Me.grpDeadline.Controls.Add(Me.Label1)
        Me.grpDeadline.Location = New System.Drawing.Point(558, 6)
        Me.grpDeadline.Name = "grpDeadline"
        Me.grpDeadline.Size = New System.Drawing.Size(514, 150)
        Me.grpDeadline.TabIndex = 25
        Me.grpDeadline.TabStop = False
        Me.grpDeadline.Text = "Deadline"
        '
        'txtRMK5
        '
        Me.txtRMK5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRMK5.Location = New System.Drawing.Point(185, 121)
        Me.txtRMK5.MaxLength = 500
        Me.txtRMK5.Name = "txtRMK5"
        Me.txtRMK5.Size = New System.Drawing.Size(323, 20)
        Me.txtRMK5.TabIndex = 14
        '
        'txtRMK4
        '
        Me.txtRMK4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRMK4.Location = New System.Drawing.Point(185, 95)
        Me.txtRMK4.MaxLength = 500
        Me.txtRMK4.Name = "txtRMK4"
        Me.txtRMK4.Size = New System.Drawing.Size(323, 20)
        Me.txtRMK4.TabIndex = 11
        '
        'txtRMK3
        '
        Me.txtRMK3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRMK3.Location = New System.Drawing.Point(185, 69)
        Me.txtRMK3.MaxLength = 500
        Me.txtRMK3.Name = "txtRMK3"
        Me.txtRMK3.Size = New System.Drawing.Size(323, 20)
        Me.txtRMK3.TabIndex = 8
        '
        'txtRMK2
        '
        Me.txtRMK2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRMK2.Location = New System.Drawing.Point(185, 44)
        Me.txtRMK2.MaxLength = 500
        Me.txtRMK2.Name = "txtRMK2"
        Me.txtRMK2.Size = New System.Drawing.Size(323, 20)
        Me.txtRMK2.TabIndex = 5
        '
        'txtRMK1
        '
        Me.txtRMK1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRMK1.Location = New System.Drawing.Point(185, 18)
        Me.txtRMK1.MaxLength = 500
        Me.txtRMK1.Name = "txtRMK1"
        Me.txtRMK1.Size = New System.Drawing.Size(323, 20)
        Me.txtRMK1.TabIndex = 2
        '
        'cbxAgent
        '
        Me.cbxAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAgent.FormattingEnabled = True
        Me.cbxAgent.Location = New System.Drawing.Point(227, 6)
        Me.cbxAgent.Name = "cbxAgent"
        Me.cbxAgent.Size = New System.Drawing.Size(77, 21)
        Me.cbxAgent.TabIndex = 3
        '
        'txtContractNo
        '
        Me.txtContractNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContractNo.Location = New System.Drawing.Point(78, 9)
        Me.txtContractNo.MaxLength = 50
        Me.txtContractNo.Name = "txtContractNo"
        Me.txtContractNo.Size = New System.Drawing.Size(77, 20)
        Me.txtContractNo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Agent"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Comtract No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "PNR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "TKNO"
        '
        'txtPNR
        '
        Me.txtPNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPNR.Location = New System.Drawing.Point(78, 35)
        Me.txtPNR.MaxLength = 6
        Me.txtPNR.Name = "txtPNR"
        Me.txtPNR.Size = New System.Drawing.Size(77, 20)
        Me.txtPNR.TabIndex = 6
        '
        'txtTKNO
        '
        Me.txtTKNO.Location = New System.Drawing.Point(78, 111)
        Me.txtTKNO.MaxLength = 500
        Me.txtTKNO.Multiline = True
        Me.txtTKNO.Name = "txtTKNO"
        Me.txtTKNO.Size = New System.Drawing.Size(474, 45)
        Me.txtTKNO.TabIndex = 22
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = False
        Me.dtpEndDate.CustomFormat = "dd-MMM-yy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(361, 33)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(78, 20)
        Me.dtpEndDate.TabIndex = 10
        Me.dtpEndDate.Value = New Date(2024, 9, 3, 0, 0, 0, 0)
        '
        'dtpDeptDate
        '
        Me.dtpDeptDate.Checked = False
        Me.dtpDeptDate.CustomFormat = "dd-MMM-yy"
        Me.dtpDeptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeptDate.Location = New System.Drawing.Point(227, 33)
        Me.dtpDeptDate.Name = "dtpDeptDate"
        Me.dtpDeptDate.Size = New System.Drawing.Size(77, 20)
        Me.dtpDeptDate.TabIndex = 8
        Me.dtpDeptDate.Value = New Date(2024, 9, 3, 0, 0, 0, 0)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(310, 38)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(50, 13)
        Me.Label34.TabIndex = 9
        Me.Label34.Text = "End date"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(161, 39)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(54, 13)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Dept date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(161, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Itinerary"
        '
        'txtItinerary
        '
        Me.txtItinerary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItinerary.Location = New System.Drawing.Point(227, 58)
        Me.txtItinerary.MaxLength = 100
        Me.txtItinerary.Name = "txtItinerary"
        Me.txtItinerary.Size = New System.Drawing.Size(325, 20)
        Me.txtItinerary.TabIndex = 14
        '
        'txtNetAmt
        '
        Me.txtNetAmt.Location = New System.Drawing.Point(227, 84)
        Me.txtNetAmt.MaxLength = 15
        Me.txtNetAmt.Name = "txtNetAmt"
        Me.txtNetAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtNetAmt.TabIndex = 18
        Me.txtNetAmt.Text = "0"
        Me.txtNetAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(161, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Net Amt"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(310, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Sell Amt"
        '
        'txtSellAmt
        '
        Me.txtSellAmt.Location = New System.Drawing.Point(361, 84)
        Me.txtSellAmt.MaxLength = 15
        Me.txtSellAmt.Name = "txtSellAmt"
        Me.txtSellAmt.Size = New System.Drawing.Size(77, 20)
        Me.txtSellAmt.TabIndex = 20
        Me.txtSellAmt.Text = "0"
        Me.txtSellAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(78, 87)
        Me.txtQuantity.MaxLength = 15
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(77, 20)
        Me.txtQuantity.TabIndex = 16
        Me.txtQuantity.Text = "0"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GridGroup
        '
        Me.GridGroup.AllowUserToAddRows = False
        Me.GridGroup.AllowUserToDeleteRows = False
        Me.GridGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridGroup.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridGroup.Location = New System.Drawing.Point(11, 224)
        Me.GridGroup.Name = "GridGroup"
        Me.GridGroup.ReadOnly = True
        Me.GridGroup.RowHeadersVisible = False
        Me.GridGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridGroup.Size = New System.Drawing.Size(1061, 401)
        Me.GridGroup.TabIndex = 34
        '
        'cbxRoutingType
        '
        Me.cbxRoutingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRoutingType.FormattingEnabled = True
        Me.cbxRoutingType.Items.AddRange(New Object() {"OW", "RT", "CT"})
        Me.cbxRoutingType.Location = New System.Drawing.Point(78, 60)
        Me.cbxRoutingType.Name = "cbxRoutingType"
        Me.cbxRoutingType.Size = New System.Drawing.Size(77, 21)
        Me.cbxRoutingType.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Routing type"
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.Location = New System.Drawing.Point(310, 12)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(10, 13)
        Me.lblAgent.TabIndex = 4
        Me.lblAgent.Text = "-"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1014, 159)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 23)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(950, 159)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(58, 23)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(886, 159)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(58, 23)
        Me.btnNew.TabIndex = 26
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1014, 631)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(58, 23)
        Me.btnDelete.TabIndex = 35
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1069, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'dtpFrom
        '
        Me.dtpFrom.Checked = False
        Me.dtpFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(11, 198)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShowCheckBox = True
        Me.dtpFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpFrom.TabIndex = 30
        Me.dtpFrom.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'dtpTo
        '
        Me.dtpTo.Checked = False
        Me.dtpTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(117, 198)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpTo.TabIndex = 31
        Me.dtpTo.Value = New Date(2000, 1, 1, 14, 23, 0, 0)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(226, 201)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "PNR"
        '
        'txtSearchPNR
        '
        Me.txtSearchPNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchPNR.Location = New System.Drawing.Point(262, 198)
        Me.txtSearchPNR.Name = "txtSearchPNR"
        Me.txtSearchPNR.Size = New System.Drawing.Size(77, 20)
        Me.txtSearchPNR.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Remark"
        '
        'txtRMK
        '
        Me.txtRMK.Location = New System.Drawing.Point(78, 161)
        Me.txtRMK.MaxLength = 500
        Me.txtRMK.Multiline = True
        Me.txtRMK.Name = "txtRMK"
        Me.txtRMK.Size = New System.Drawing.Size(474, 20)
        Me.txtRMK.TabIndex = 24
        '
        'bdsView
        '
        '
        'Ticketing_Group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtSearchPNR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbxRoutingType)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GridGroup)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSellAmt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNetAmt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpDeptDate)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.cbxAgent)
        Me.Controls.Add(Me.grpDeadline)
        Me.Controls.Add(Me.txtRMK)
        Me.Controls.Add(Me.txtTKNO)
        Me.Controls.Add(Me.txtItinerary)
        Me.Controls.Add(Me.txtPNR)
        Me.Controls.Add(Me.txtContractNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAgent)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ticketing_Group"
        Me.Text = "Group"
        Me.grpDeadline.ResumeLayout(False)
        Me.grpDeadline.PerformLayout()
        CType(Me.GridGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDepo1 As DateTimePicker
    Friend WithEvents dtpDepo2 As DateTimePicker
    Friend WithEvents dtpDepo3 As DateTimePicker
    Friend WithEvents dtpReduceSeat As DateTimePicker
    Friend WithEvents dtpName As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grpDeadline As GroupBox
    Friend WithEvents txtRMK5 As TextBox
    Friend WithEvents txtRMK4 As TextBox
    Friend WithEvents txtRMK3 As TextBox
    Friend WithEvents txtRMK2 As TextBox
    Friend WithEvents txtRMK1 As TextBox
    Friend WithEvents cbxAgent As ComboBox
    Friend WithEvents txtContractNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPNR As TextBox
    Friend WithEvents txtTKNO As TextBox
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents dtpDeptDate As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtItinerary As TextBox
    Friend WithEvents txtNetAmt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSellAmt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents GridGroup As DataGridView
    Friend WithEvents cbxRoutingType As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblAgent As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents txtSearchPNR As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtRMK As TextBox
    Friend WithEvents bdsView As BindingSource
End Class
