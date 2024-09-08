Imports System.Data.SqlClient

Public Class FrmLogIn
    Public Sub SetAllMenuStatus(ByVal varStatus As Boolean)
        Dim mnu As Object, MnuI As ToolStripItem
        For Each mnu In FrmMain.MenuControl.Items
            mnu.Enabled = varStatus
            For Each MnuI In mnu.DropDownItems
                MnuI.Enabled = varStatus
            Next
        Next
    End Sub

    Private Sub enableUserMenus(ByVal items As ToolStripItemCollection, ByVal role As String)
        For Each item In items
            If TypeOf item Is ToolStripMenuItem Then
                If item.HasDropDownItems Then
                    enableUserMenus(item.DropDownItems, role)
                End If
            End If
        Next item
        For Each item In items
            If TypeOf item Is ToolStripMenuItem Then
                If item.Name = role Then
                    item.Enabled = True
                End If
            End If
        Next item
    End Sub

    Private Sub BtnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If FrmMain.BarDangNhap.Text = "Log in" Then
            If ExeScalar("Select count(*) from tblUser where Phone='" & txtPhone.Text & "' and PSW='" & md5(txtPSW.Text) & "' and Status='OK'") > 0 Then
                myStaff.UserID = ExeScalar("Select RecID from tbluser where Phone='" & txtPhone.Text & "' and status='OK'")
                If UCase(myStaff.ChucVu) = "ADMIN" Then
                    SetAllMenuStatus(True)
                Else
                    SetAllMenuStatus(False)
                End If
                Dim dtl As DataTable = GetDataTable(" select CtrlName from UserRight where status = 'OK' and CtrlType = 'Menu' and UserID =" & myStaff.UserID)
                For Each row As DataRow In dtl.Rows
                    enableUserMenus(FrmMain.MenuControl.Items, row("CtrlName"))
                Next row
                SaveSetting("Beyond Application", "Login", "UNAME", myStaff.Phone)
                FrmMain.lblUser.Text = "User: " & myStaff.UserName
                FrmMain.BarDangNhap.Text = "Log out"
                FrmMain.BarDoiMatKhau.Visible = True
                Me.Close()
                FrmMain.LoadGridDeadline()
            Else
                MsgBox("Sai tên đăng nhập hoặc mật khẩu")
            End If
        Else
            FrmMain.LogIn_Out()
        End If

    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPhone.Text = GetSetting("Beyond Application", "Login", "UNAME")
        txtPSW.Select()
    End Sub
End Class