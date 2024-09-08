<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoiMatKhau
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPSW = New System.Windows.Forms.TextBox()
        Me.txtNewPSW = New System.Windows.Forms.TextBox()
        Me.txtCfmPSW = New System.Windows.Forms.TextBox()
        Me.btnXacNhanDoiMK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "New password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Confirm new password"
        '
        'txtPSW
        '
        Me.txtPSW.Location = New System.Drawing.Point(145, 7)
        Me.txtPSW.Name = "txtPSW"
        Me.txtPSW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPSW.Size = New System.Drawing.Size(142, 20)
        Me.txtPSW.TabIndex = 1
        '
        'txtNewPSW
        '
        Me.txtNewPSW.Location = New System.Drawing.Point(145, 32)
        Me.txtNewPSW.Name = "txtNewPSW"
        Me.txtNewPSW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPSW.Size = New System.Drawing.Size(142, 20)
        Me.txtNewPSW.TabIndex = 2
        '
        'txtCfmPSW
        '
        Me.txtCfmPSW.Location = New System.Drawing.Point(145, 56)
        Me.txtCfmPSW.Name = "txtCfmPSW"
        Me.txtCfmPSW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCfmPSW.Size = New System.Drawing.Size(142, 20)
        Me.txtCfmPSW.TabIndex = 3
        '
        'btnXacNhanDoiMK
        '
        Me.btnXacNhanDoiMK.Location = New System.Drawing.Point(145, 82)
        Me.btnXacNhanDoiMK.Name = "btnXacNhanDoiMK"
        Me.btnXacNhanDoiMK.Size = New System.Drawing.Size(142, 23)
        Me.btnXacNhanDoiMK.TabIndex = 1
        Me.btnXacNhanDoiMK.Text = "Change password"
        Me.btnXacNhanDoiMK.UseVisualStyleBackColor = True
        '
        'FrmDoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 109)
        Me.Controls.Add(Me.btnXacNhanDoiMK)
        Me.Controls.Add(Me.txtCfmPSW)
        Me.Controls.Add(Me.txtNewPSW)
        Me.Controls.Add(Me.txtPSW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDoiMatKhau"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPSW As TextBox
    Friend WithEvents txtNewPSW As TextBox
    Friend WithEvents txtCfmPSW As TextBox
    Friend WithEvents btnXacNhanDoiMK As Button
End Class
