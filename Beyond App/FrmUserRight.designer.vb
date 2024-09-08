<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUserRight
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
        Me.bdsUser = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsReport = New System.Windows.Forms.BindingSource(Me.components)
        Me.PnlCreateUser = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnChangeUserInfor = New System.Windows.Forms.Button()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.cbxPhongBan = New System.Windows.Forms.ComboBox()
        Me.cbxChucVu = New System.Windows.Forms.ComboBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GridUser = New System.Windows.Forms.DataGridView()
        Me.btnUpdateQuyen = New System.Windows.Forms.Button()
        Me.btnResetPSW = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.TrvRight = New System.Windows.Forms.TreeView()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.bdsUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCreateUser.SuspendLayout()
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bdsUser
        '
        '
        'PnlCreateUser
        '
        Me.PnlCreateUser.BackColor = System.Drawing.Color.AliceBlue
        Me.PnlCreateUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlCreateUser.Controls.Add(Me.btnNew)
        Me.PnlCreateUser.Controls.Add(Me.txtEmail)
        Me.PnlCreateUser.Controls.Add(Me.Label12)
        Me.PnlCreateUser.Controls.Add(Me.btnChangeUserInfor)
        Me.PnlCreateUser.Controls.Add(Me.btnCreateUser)
        Me.PnlCreateUser.Controls.Add(Me.cbxPhongBan)
        Me.PnlCreateUser.Controls.Add(Me.cbxChucVu)
        Me.PnlCreateUser.Controls.Add(Me.txtPhone)
        Me.PnlCreateUser.Controls.Add(Me.txtHoTen)
        Me.PnlCreateUser.Controls.Add(Me.Label1)
        Me.PnlCreateUser.Controls.Add(Me.Label8)
        Me.PnlCreateUser.Controls.Add(Me.Label7)
        Me.PnlCreateUser.Controls.Add(Me.Label6)
        Me.PnlCreateUser.Location = New System.Drawing.Point(5, 11)
        Me.PnlCreateUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PnlCreateUser.Name = "PnlCreateUser"
        Me.PnlCreateUser.Size = New System.Drawing.Size(397, 131)
        Me.PnlCreateUser.TabIndex = 19
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(203, 96)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(58, 23)
        Me.btnNew.TabIndex = 22
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(61, 69)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(328, 21)
        Me.txtEmail.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Email"
        '
        'btnChangeUserInfor
        '
        Me.btnChangeUserInfor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnChangeUserInfor.Location = New System.Drawing.Point(267, 96)
        Me.btnChangeUserInfor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangeUserInfor.Name = "btnChangeUserInfor"
        Me.btnChangeUserInfor.Size = New System.Drawing.Size(58, 23)
        Me.btnChangeUserInfor.TabIndex = 13
        Me.btnChangeUserInfor.Text = "Update"
        Me.btnChangeUserInfor.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateUser.Location = New System.Drawing.Point(331, 96)
        Me.btnCreateUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(58, 23)
        Me.btnCreateUser.TabIndex = 11
        Me.btnCreateUser.Text = "Add"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'cbxPhongBan
        '
        Me.cbxPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPhongBan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPhongBan.FormattingEnabled = True
        Me.cbxPhongBan.Location = New System.Drawing.Point(233, 40)
        Me.cbxPhongBan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxPhongBan.Name = "cbxPhongBan"
        Me.cbxPhongBan.Size = New System.Drawing.Size(156, 23)
        Me.cbxPhongBan.TabIndex = 8
        '
        'cbxChucVu
        '
        Me.cbxChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxChucVu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxChucVu.FormattingEnabled = True
        Me.cbxChucVu.Items.AddRange(New Object() {"", "Ban quản trị", "Quản lý", "Nhân viên"})
        Me.cbxChucVu.Location = New System.Drawing.Point(61, 41)
        Me.cbxChucVu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxChucVu.Name = "cbxChucVu"
        Me.cbxChucVu.Size = New System.Drawing.Size(99, 23)
        Me.cbxChucVu.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(61, 14)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPhone.MaxLength = 10
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(99, 21)
        Me.txtPhone.TabIndex = 6
        '
        'txtHoTen
        '
        Me.txtHoTen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHoTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoTen.Location = New System.Drawing.Point(233, 15)
        Me.txtHoTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(156, 21)
        Me.txtHoTen.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Department"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Role"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "User name"
        '
        'GridUser
        '
        Me.GridUser.AllowUserToAddRows = False
        Me.GridUser.AllowUserToDeleteRows = False
        Me.GridUser.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUser.Location = New System.Drawing.Point(4, 173)
        Me.GridUser.Name = "GridUser"
        Me.GridUser.ReadOnly = True
        Me.GridUser.RowHeadersVisible = False
        Me.GridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridUser.Size = New System.Drawing.Size(395, 448)
        Me.GridUser.TabIndex = 17
        '
        'btnUpdateQuyen
        '
        Me.btnUpdateQuyen.Location = New System.Drawing.Point(704, 628)
        Me.btnUpdateQuyen.Name = "btnUpdateQuyen"
        Me.btnUpdateQuyen.Size = New System.Drawing.Size(107, 25)
        Me.btnUpdateQuyen.TabIndex = 16
        Me.btnUpdateQuyen.Text = "Update permission"
        Me.btnUpdateQuyen.UseVisualStyleBackColor = True
        '
        'btnResetPSW
        '
        Me.btnResetPSW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnResetPSW.Location = New System.Drawing.Point(226, 629)
        Me.btnResetPSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnResetPSW.Name = "btnResetPSW"
        Me.btnResetPSW.Size = New System.Drawing.Size(95, 23)
        Me.btnResetPSW.TabIndex = 20
        Me.btnResetPSW.Text = "Reset password"
        Me.btnResetPSW.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteUser.Location = New System.Drawing.Point(324, 629)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteUser.TabIndex = 21
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'TrvRight
        '
        Me.TrvRight.CheckBoxes = True
        Me.TrvRight.Location = New System.Drawing.Point(408, 11)
        Me.TrvRight.Name = "TrvRight"
        Me.TrvRight.Size = New System.Drawing.Size(403, 610)
        Me.TrvRight.TabIndex = 18
        '
        'txtTimKiem
        '
        Me.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTimKiem.Location = New System.Drawing.Point(4, 147)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(120, 20)
        Me.txtTimKiem.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "(Search follow user name or phone)"
        '
        'FrmUserRight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.PnlCreateUser)
        Me.Controls.Add(Me.GridUser)
        Me.Controls.Add(Me.btnUpdateQuyen)
        Me.Controls.Add(Me.btnResetPSW)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.TrvRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(0, 56)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUserRight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User management"
        CType(Me.bdsUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCreateUser.ResumeLayout(False)
        Me.PnlCreateUser.PerformLayout()
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bdsUser As BindingSource
    Friend WithEvents bdsReport As BindingSource
    Friend WithEvents PnlCreateUser As Panel
    Friend WithEvents btnNew As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnChangeUserInfor As Button
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents cbxChucVu As ComboBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GridUser As DataGridView
    Friend WithEvents btnUpdateQuyen As Button
    Friend WithEvents btnResetPSW As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents TrvRight As TreeView
    Friend WithEvents cbxPhongBan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents Label2 As Label
End Class
