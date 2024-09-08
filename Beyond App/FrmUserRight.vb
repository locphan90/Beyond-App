Imports System.Data.SqlClient

Public Class FrmUserRight
    Dim dtrUser As DataRowView
    Dim dtrReport As DataRowView
    Private Sub LoadGridUser()
        Dim dtl As DataTable = GetDataTable("Select RecID, Hoten, Phone, ChucVu, Email, PhongBan from tbluser where RecID>0 and Status='OK' order by Hoten")
        bdsUser.DataSource = dtl
        GridUser.DataSource = bdsUser
        GridUser.Columns("RecID").Visible = False
        GridUser.Columns("Hoten").Width = 185
        GridUser.Columns("Phone").Width = 80
    End Sub

    Private Sub hasDropdownItems(ByVal isContinue As Boolean, ByVal items As ToolStripItemCollection, ByVal node As TreeNode)
        If isContinue = False Then Exit Sub
        For Each ts In items
            If TypeOf ts Is ToolStripMenuItem Then
                node.Nodes.Add(ts.Name, ts.Text)
                hasDropdownItems(ts.HasDropDownItems, ts.DropDownItems, FindNode(ts.Name, Me.TrvRight.Nodes))
            End If
        Next ts
    End Sub

    Private Function FindNode(ByVal pNodeName As String, ByVal pTree As TreeNodeCollection) As TreeNode
        Dim n As TreeNode
        For Each n In pTree
            If n.Name = pNodeName Then
                Return n
            Else
                If n.Nodes.Count > 0 Then
                    Dim t As TreeNode = FindNode(pNodeName, n.Nodes)
                    If Not t Is Nothing Then Return t
                End If
            End If
        Next
        Return Nothing
    End Function


    Private Sub loadAllCheckedNode(ByVal nodes As TreeNodeCollection, UID As Integer)
        Dim dtl As DataTable = GetDataTable(" select CtrlName from UserRight where status <> 'XX' and CtrlType = 'Menu' and UserID =" & UID)
        For Each row As DataRow In dtl.Rows
            If FindNode(row("CtrlName"), nodes) Is Nothing Then
            Else
                FindNode(row("CtrlName"), nodes).Checked = True
            End If
        Next row
    End Sub

    Private Sub loadRolesAvaiabled(Optional ByVal UID As Integer = -1)
        Dim mainForm As frmMain = Me.Owner
        TrvRight.Nodes.Clear()
        For Each ts In FrmMain.MenuControl.Items
            If TypeOf ts Is ToolStripMenuItem Then
                Me.TrvRight.Nodes.Add(ts.Name, ts.Text)
                hasDropdownItems(True, ts.DropDownItems, FindNode(ts.Name, Me.TrvRight.Nodes))
            End If
        Next ts

        If UID <> -1 Then
            loadAllCheckedNode(Me.TrvRight.Nodes, UID)
        End If
    End Sub

    Private Sub processAllCheckedNode(ByVal nodes As TreeNodeCollection, ByVal UserID As Integer, ByVal Para As SqlParameter(), ByVal dtlUserRight As DataTable)
        Dim node As TreeNode
        Dim needInsertNewRow As Boolean = False
        For Each node In nodes
            If node.Checked Then
                needInsertNewRow = False
                For Each row As DataRow In dtlUserRight.Rows
                    If row("CtrlName") = node.Name Then
                        ExeNonequery(" update UserRight set status='OK', lstupdate=getdate(), lstuser=" & myStaff.UserID & " where UserID=@UserID and CtrlName=N'" & node.Name & "' ", Para)
                        needInsertNewRow = True
                        Exit For
                    End If
                Next
                If needInsertNewRow = False Then
                    ExeNonequery(" insert into UserRight (UserID, CtrlType, CtrlName, FstUser, FstUpdate) values (@UserID, 'Menu', N'" & node.Name & "', " & myStaff.UserID & ", getdate()) ", Para)
                End If
            End If
            If node.Nodes.Count > 0 Then
                processAllCheckedNode(node.Nodes, UserID, Para, dtlUserRight)
            End If
        Next
    End Sub

    Private Sub FrmUserRight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridUser()
        btnNew_Click(sender, e)
        BuildControl("Select Val2 from MISC where CAT='PHONGBAN' and Status='OK' order by val", "Val2", "Val2", cbxPhongBan)
        BuildControl("Select Val2 from MISC where CAT='CHUCVU' and Status='OK' order by val", "Val2", "Val2", cbxChucVu)
    End Sub

    Private Sub bdsUser_CurrentChanged(sender As Object, e As EventArgs) Handles bdsUser.CurrentChanged
        If bdsUser.Count > 0 Then
            dtrUser = bdsUser.Current
            txtPhone.Text = dtrUser("Phone")
            txtHoTen.Text = dtrUser("HoTen")
            cbxChucVu.Text = dtrUser("ChucVu")
            txtEmail.Text = dtrUser("email")
            cbxPhongBan.Text = dtrUser("PhongBan")
            btnCreateUser.Enabled = False
            btnChangeUserInfor.Enabled = True
            btnResetPSW.Enabled = True
            btnDeleteUser.Enabled = True
            loadRolesAvaiabled(dtrUser("RecID"))
        Else
            dtrUser = Nothing
        End If
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Dim i As Integer = ExeScalar("Select count(*) from tbluser where Status='OK' and Phone='" & txtPhone.Text & "'")
        If i > 0 Then
            MsgBox("User này đã tồn tại, vui lòng kiểm tra lại thông tin!")
            Exit Sub
        End If
        Dim defaultPSW As String = "123456"
        Dim strSQL As String
        strSQL = "insert tblUser (Phone, PSW, Hoten, ChucVu, Email, PhongBan, FstUser) values (@Phone, @PSW, @Hoten, @ChucVu, @Email, @PhongBan, @FstUser);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@Phone", Me.txtPhone.Text),
                New SqlParameter("@PSW", md5(defaultPSW)),
                New SqlParameter("@Hoten", Me.txtHoTen.Text),
                New SqlParameter("@ChucVu", Me.cbxChucVu.Text),
                New SqlParameter("@Email", Me.txtEmail.Text),
                New SqlParameter("@PhongBan", cbxPhongBan.Text),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("tblUser", RecID)
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtHoTen.Text = ""
        cbxPhongBan.SelectedValue = 0
        cbxChucVu.Text = ""
        LoadGridUser()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtPhone.Text = ""
        txtHoTen.Text = ""
        cbxChucVu.Text = ""
        txtEmail.Text = ""
        cbxPhongBan.Text = ""
        btnCreateUser.Enabled = True
        btnChangeUserInfor.Enabled = False
        btnResetPSW.Enabled = False
        btnDeleteUser.Enabled = False
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@UserID", dtrUser("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa user này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update tblUser set Status='XX' where recID=@UserID", Para)
            GhiLog("tblUser", dtrUser("RecID"))
        End If
        LoadGridUser()
    End Sub

    Private Sub btnResetPSW_Click(sender As Object, e As EventArgs) Handles btnResetPSW.Click
        Dim defaultPSW As String = "123456"
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@UserID", dtrUser("RecID")),
            New SqlParameter("@defaultPSW", md5(defaultPSW))
        }
        ExeNonequery("update tblUser set PSW=@defaultPSW where recID=@UserID", Para)
        GhiLog("tblUser", dtrUser("RecID"))
        MsgBox("Đã reset mật khẩu thành 123456")
    End Sub

    Private Sub btnChangeUserInfor_Click(sender As Object, e As EventArgs) Handles btnChangeUserInfor.Click
        Dim strSQL As String = "update tblUser set Phone=@Phone, HoTen=@HoTen, ChucVu=@ChucVu, Email=@Email, PhongBan=@PhongBan where recID=@UserID"
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@Phone", txtPhone.Text),
            New SqlParameter("@HoTen", txtHoTen.Text),
            New SqlParameter("@ChucVu", cbxChucVu.Text),
            New SqlParameter("@Email", txtEmail.Text),
            New SqlParameter("@PhongBan", cbxPhongBan.Text),
            New SqlParameter("@UserID", dtrUser("RecID"))
        }
        ExeNonequery(strSQL, Para)
        GhiLog("tblUser", dtrUser("RecID"))
        MsgBox("Đã cập nhật!")
        LoadGridUser()
        bdsUser_CurrentChanged(sender, e)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateQuyen.Click
        Try
            Dim UserID As Int16 = GridUser.CurrentRow.Cells("RecID").Value
            Dim Para() As SqlParameter
            Para = New SqlParameter() _
                {
                    New SqlParameter("@UserID", UserID)
                }
            ExeNonequery(" update UserRight set status = 'XX', lstupdate=getdate(), lstuser=" & myStaff.UserID & " where UserID=@UserID and CtrlType ='Menu' ", Para)
            Dim dtlUserRight As DataTable = GetDataTable(" select CtrlName from UserRight where UserID=" & UserID)
            processAllCheckedNode(Me.TrvRight.Nodes, UserID, Para, dtlUserRight)
            MsgBox("Đã cập nhật quyền")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridUser.CellClick
        bdsUser_CurrentChanged(sender, e)
    End Sub

    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        bdsUser.Filter = "HoTen like '%" & txtTimKiem.Text & "%' or Phone like '%" & txtTimKiem.Text & "%'"
    End Sub
End Class