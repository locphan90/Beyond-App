<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PadUserManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuControl = New System.Windows.Forms.MenuStrip()
        Me.PadUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarDangNhap = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarDoiMatKhau = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadTicketing = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarAirRail = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarCharter = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarCharterBuy = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarCharterSell = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarDeadlineToFollow = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarSupplierPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarLandSetting = New System.Windows.Forms.ToolStripMenuItem()
        Me.PadAccounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarAccTopUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarCustomerPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarAccSupplierPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlDeadline = New System.Windows.Forms.Panel()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.lklRefresh = New System.Windows.Forms.LinkLabel()
        Me.lblTenUser = New System.Windows.Forms.Label()
        Me.GridDeadline = New System.Windows.Forms.DataGridView()
        Me.tmrDeadline = New System.Windows.Forms.Timer(Me.components)
        Me.BarTicketingReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuControl.SuspendLayout()
        Me.pnlDeadline.SuspendLayout()
        CType(Me.GridDeadline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 715)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1294, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(33, 17)
        Me.lblUser.Text = "User:"
        '
        'PadUserManagement
        '
        Me.PadUserManagement.Name = "PadUserManagement"
        Me.PadUserManagement.Size = New System.Drawing.Size(116, 20)
        Me.PadUserManagement.Text = "User management"
        '
        'MenuControl
        '
        Me.MenuControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PadUserManagement, Me.PadUser, Me.PadTicketing, Me.PadAccounting})
        Me.MenuControl.Location = New System.Drawing.Point(0, 0)
        Me.MenuControl.Name = "MenuControl"
        Me.MenuControl.Size = New System.Drawing.Size(1294, 24)
        Me.MenuControl.TabIndex = 0
        Me.MenuControl.Text = "MenuStrip1"
        '
        'PadUser
        '
        Me.PadUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PadUser.BackColor = System.Drawing.Color.LawnGreen
        Me.PadUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarDangNhap, Me.BarDoiMatKhau})
        Me.PadUser.Name = "PadUser"
        Me.PadUser.Size = New System.Drawing.Size(42, 20)
        Me.PadUser.Text = "User"
        '
        'BarDangNhap
        '
        Me.BarDangNhap.Name = "BarDangNhap"
        Me.BarDangNhap.Size = New System.Drawing.Size(168, 22)
        Me.BarDangNhap.Text = "Log in"
        '
        'BarDoiMatKhau
        '
        Me.BarDoiMatKhau.Name = "BarDoiMatKhau"
        Me.BarDoiMatKhau.Size = New System.Drawing.Size(168, 22)
        Me.BarDoiMatKhau.Text = "Change password"
        Me.BarDoiMatKhau.Visible = False
        '
        'PadTicketing
        '
        Me.PadTicketing.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarAirRail, Me.BarGroup, Me.BarCharter, Me.BarDeadlineToFollow, Me.BarSupplierPayment, Me.BarCustomer, Me.BarSupplier, Me.BarLandSetting, Me.BarTicketingReport})
        Me.PadTicketing.Name = "PadTicketing"
        Me.PadTicketing.Size = New System.Drawing.Size(67, 20)
        Me.PadTicketing.Text = "Ticketing"
        '
        'BarAirRail
        '
        Me.BarAirRail.Name = "BarAirRail"
        Me.BarAirRail.Size = New System.Drawing.Size(180, 22)
        Me.BarAirRail.Text = "Air/Rail"
        '
        'BarGroup
        '
        Me.BarGroup.Name = "BarGroup"
        Me.BarGroup.Size = New System.Drawing.Size(180, 22)
        Me.BarGroup.Text = "Group"
        '
        'BarCharter
        '
        Me.BarCharter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarCharterBuy, Me.BarCharterSell})
        Me.BarCharter.Name = "BarCharter"
        Me.BarCharter.Size = New System.Drawing.Size(180, 22)
        Me.BarCharter.Text = "Charter"
        '
        'BarCharterBuy
        '
        Me.BarCharterBuy.Name = "BarCharterBuy"
        Me.BarCharterBuy.Size = New System.Drawing.Size(94, 22)
        Me.BarCharterBuy.Text = "Buy"
        '
        'BarCharterSell
        '
        Me.BarCharterSell.Name = "BarCharterSell"
        Me.BarCharterSell.Size = New System.Drawing.Size(94, 22)
        Me.BarCharterSell.Text = "Sell"
        '
        'BarDeadlineToFollow
        '
        Me.BarDeadlineToFollow.Name = "BarDeadlineToFollow"
        Me.BarDeadlineToFollow.Size = New System.Drawing.Size(180, 22)
        Me.BarDeadlineToFollow.Text = "Deadline To Follow"
        '
        'BarSupplierPayment
        '
        Me.BarSupplierPayment.Name = "BarSupplierPayment"
        Me.BarSupplierPayment.Size = New System.Drawing.Size(180, 22)
        Me.BarSupplierPayment.Text = "Supplier Payment"
        '
        'BarCustomer
        '
        Me.BarCustomer.Name = "BarCustomer"
        Me.BarCustomer.Size = New System.Drawing.Size(180, 22)
        Me.BarCustomer.Text = "Customer"
        '
        'BarSupplier
        '
        Me.BarSupplier.Name = "BarSupplier"
        Me.BarSupplier.Size = New System.Drawing.Size(180, 22)
        Me.BarSupplier.Text = "Supplier"
        '
        'BarLandSetting
        '
        Me.BarLandSetting.Name = "BarLandSetting"
        Me.BarLandSetting.Size = New System.Drawing.Size(180, 22)
        Me.BarLandSetting.Text = "Land Setting"
        '
        'PadAccounting
        '
        Me.PadAccounting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarAccTopUp, Me.BarCustomerPayment, Me.BarAccSupplierPayment})
        Me.PadAccounting.Name = "PadAccounting"
        Me.PadAccounting.Size = New System.Drawing.Size(81, 20)
        Me.PadAccounting.Text = "Accounting"
        '
        'BarAccTopUp
        '
        Me.BarAccTopUp.Name = "BarAccTopUp"
        Me.BarAccTopUp.Size = New System.Drawing.Size(180, 22)
        Me.BarAccTopUp.Text = "Top Up"
        '
        'BarCustomerPayment
        '
        Me.BarCustomerPayment.Name = "BarCustomerPayment"
        Me.BarCustomerPayment.Size = New System.Drawing.Size(180, 22)
        Me.BarCustomerPayment.Text = "Customer Payment"
        '
        'BarAccSupplierPayment
        '
        Me.BarAccSupplierPayment.Name = "BarAccSupplierPayment"
        Me.BarAccSupplierPayment.Size = New System.Drawing.Size(180, 22)
        Me.BarAccSupplierPayment.Text = "Supplier Payment"
        '
        'pnlDeadline
        '
        Me.pnlDeadline.Controls.Add(Me.btnDone)
        Me.pnlDeadline.Controls.Add(Me.lklRefresh)
        Me.pnlDeadline.Controls.Add(Me.lblTenUser)
        Me.pnlDeadline.Controls.Add(Me.GridDeadline)
        Me.pnlDeadline.Location = New System.Drawing.Point(998, 27)
        Me.pnlDeadline.Name = "pnlDeadline"
        Me.pnlDeadline.Size = New System.Drawing.Size(296, 364)
        Me.pnlDeadline.TabIndex = 11
        Me.pnlDeadline.Visible = False
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(235, 338)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(58, 23)
        Me.btnDone.TabIndex = 4
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'lklRefresh
        '
        Me.lklRefresh.AutoSize = True
        Me.lklRefresh.Location = New System.Drawing.Point(2, 345)
        Me.lklRefresh.Name = "lklRefresh"
        Me.lklRefresh.Size = New System.Drawing.Size(44, 13)
        Me.lklRefresh.TabIndex = 3
        Me.lklRefresh.TabStop = True
        Me.lklRefresh.Text = "Refresh"
        '
        'lblTenUser
        '
        Me.lblTenUser.AutoSize = True
        Me.lblTenUser.Location = New System.Drawing.Point(3, 7)
        Me.lblTenUser.Name = "lblTenUser"
        Me.lblTenUser.Size = New System.Drawing.Size(49, 13)
        Me.lblTenUser.TabIndex = 2
        Me.lblTenUser.Text = "Deadline"
        '
        'GridDeadline
        '
        Me.GridDeadline.AllowUserToAddRows = False
        Me.GridDeadline.AllowUserToDeleteRows = False
        Me.GridDeadline.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridDeadline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDeadline.Location = New System.Drawing.Point(3, 25)
        Me.GridDeadline.Name = "GridDeadline"
        Me.GridDeadline.RowHeadersVisible = False
        Me.GridDeadline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDeadline.Size = New System.Drawing.Size(290, 307)
        Me.GridDeadline.TabIndex = 1
        '
        'tmrDeadline
        '
        Me.tmrDeadline.Interval = 36000
        '
        'BarTicketingReport
        '
        Me.BarTicketingReport.Name = "BarTicketingReport"
        Me.BarTicketingReport.Size = New System.Drawing.Size(180, 22)
        Me.BarTicketingReport.Text = "Report"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1294, 737)
        Me.Controls.Add(Me.pnlDeadline)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuControl
        Me.Name = "FrmMain"
        Me.Text = "Beyond Application"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuControl.ResumeLayout(False)
        Me.MenuControl.PerformLayout()
        Me.pnlDeadline.ResumeLayout(False)
        Me.pnlDeadline.PerformLayout()
        CType(Me.GridDeadline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents PadUserManagement As ToolStripMenuItem
    Friend WithEvents MenuControl As MenuStrip
    Friend WithEvents PadUser As ToolStripMenuItem
    Friend WithEvents BarDangNhap As ToolStripMenuItem
    Friend WithEvents BarDoiMatKhau As ToolStripMenuItem
    Friend WithEvents PadTicketing As ToolStripMenuItem
    Friend WithEvents BarAirRail As ToolStripMenuItem
    Friend WithEvents BarGroup As ToolStripMenuItem
    Friend WithEvents BarCharter As ToolStripMenuItem
    Friend WithEvents PadAccounting As ToolStripMenuItem
    Friend WithEvents BarSupplier As ToolStripMenuItem
    Friend WithEvents BarAccTopUp As ToolStripMenuItem
    Friend WithEvents BarCustomer As ToolStripMenuItem
    Friend WithEvents BarCustomerPayment As ToolStripMenuItem
    Friend WithEvents BarLandSetting As ToolStripMenuItem
    Friend WithEvents BarCharterBuy As ToolStripMenuItem
    Friend WithEvents BarCharterSell As ToolStripMenuItem
    Friend WithEvents BarSupplierPayment As ToolStripMenuItem
    Friend WithEvents BarAccSupplierPayment As ToolStripMenuItem
    Friend WithEvents BarDeadlineToFollow As ToolStripMenuItem
    Friend WithEvents pnlDeadline As Panel
    Friend WithEvents lklRefresh As LinkLabel
    Friend WithEvents lblTenUser As Label
    Friend WithEvents GridDeadline As DataGridView
    Friend WithEvents btnDone As Button
    Friend WithEvents tmrDeadline As Timer
    Friend WithEvents BarTicketingReport As ToolStripMenuItem
End Class
