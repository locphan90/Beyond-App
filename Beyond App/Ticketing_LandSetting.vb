Imports System.Data.SqlClient

Public Class Ticketing_LandSetting
    Dim dtr As DataRowView

    Private Sub Ticketing_LandSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildControl("Select RecID, SupplierName from Supplier where Status='OK' and Type='Land' order by SupplierName", "RecID", "SupplierName", cbxSupplier)
        LoadGridSetting()
    End Sub

    Private Sub LoadGridSetting()
        Dim dtl As DataTable = GetDataTable("Select l.RecID, SupplierName, l.Type, Price from LandSetting l left join Supplier s on s.RecID=l.SupplierID where l.Status='OK' order by SupplierName, Type")
        bdsView.DataSource = dtl
        GridSetting.DataSource = bdsView
        GridSetting.Columns("RecID").Visible = False
        GridSetting.Columns("SupplierName").Width = 200
        GridSetting.Columns("Type").Width = 50
        GridSetting.Columns("Price").Width = 70
        GridSetting.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridSetting.Columns("Price").DefaultCellStyle.Format = "#,##"
    End Sub
    Private Sub GridSetting_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridSetting.DataBindingComplete
        GridSetting.ClearSelection()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strSQL As String
        strSQL = "insert LandSetting (SupplierID, Type, Price, FstUser) values (@SupplierID, @Type, @Price, @FstUser);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
{
                New SqlParameter("@SupplierID", cbxSupplier.SelectedValue),
                New SqlParameter("@Type", cbxType.Text),
                New SqlParameter("@price", CDec(txtPrice.Text)),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("LandSetting", RecID)
        LoadGridSetting()
        txtPrice.Text = "0"
        cbxType.Text = ""
    End Sub

    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtPrice.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If bdsView.Count = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", dtr("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update LandSetting set Status='XX' where recID=@RecID", Para)
            GhiLog("LandSetting", dtr("RecID"))
        End If
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
        End If
    End Sub
End Class