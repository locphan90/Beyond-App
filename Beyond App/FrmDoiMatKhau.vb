Imports System.Data.SqlClient
Public Class FrmDoiMatKhau
    Private Sub btnXacNhanDoiMK_Click(sender As Object, e As EventArgs) Handles btnXacNhanDoiMK.Click
        If txtCfmPSW.Text <> "" And txtNewPSW.Text <> "" And txtPSW.Text <> "" Then
            If myStaff.PSW = md5(txtPSW.Text) Then
                If txtNewPSW.Text = txtCfmPSW.Text Then
                    Dim Para() As SqlParameter
                    Para = New SqlParameter() _
                        {
                            New SqlParameter("@RecID", myStaff.UserID),
                            New SqlParameter("@LstUser", myStaff.UserID),
                            New SqlParameter("@LstUpdate", Date.Now),
                            New SqlParameter("@PSW", md5(txtNewPSW.Text))
                        }
                    ExeNonequery("update tblUser set PSW=@PSW where recID=@RecID", Para)
                    GhiLog("tblUser", myStaff.UserID)
                    MsgBox("Đã thay đổi mật khẩu!")
                Else
                    MsgBox("Mật khẩu mới và xác nhận lại mật khẩu không giống nhau!")
                End If
            Else
                MsgBox("Mật khẩu hiện tại không đúng!")
            End If
        Else
            MsgBox("Chưa nhập đầy đủ thông tin!")
        End If
        Me.Close()
    End Sub

    Private Sub FrmDoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPSW.Select()
    End Sub
End Class