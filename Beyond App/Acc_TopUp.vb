Imports System.Data.SqlClient

Public Class Acc_TopUp
    Dim dtr As DataRowView
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtAmount.Text = 0
        cbxSupName.SelectedValue = -1
        cbxType.SelectedText = "GIT"
        dtpDate.Value = Date.Now
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        cbxSupName.Select()
    End Sub

    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtAmount.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtAmount.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub LoadGridTopUp()
        Dim dtl As DataTable = GetDataTable("Select t.RecID, SupplierID, SupplierName, Amount, CustType, ValidDate from TopUp t left join Supplier s on s.RecID=t.SupplierID where t.Status='OK' order by SupplierName, CustType, ValidDate")
        bdsView.DataSource = dtl
        GridTopUp.DataSource = bdsView
        GridTopUp.Columns("RecID").Visible = False
        GridTopUp.Columns("SupplierID").Visible = False
        GridTopUp.Columns("SupplierName").Width = 350
        GridTopUp.Columns("Amount").Width = 90
        GridTopUp.Columns("CustType").Width = 70
        GridTopUp.Columns("ValidDate").Width = 70
        GridTopUp.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTopUp.Columns("Amount").DefaultCellStyle.Format = "#,##"
        GridTopUp.Columns("ValidDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTopUp.Columns("ValidDate").DefaultCellStyle.Format = "dd-MMM-yyyy"
    End Sub

    Private Sub GridTopUp_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridTopUp.DataBindingComplete
        GridTopUp.ClearSelection()
    End Sub

    Private Sub GridTongHop_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridTongHop.DataBindingComplete
        GridTongHop.ClearSelection()
    End Sub

    Private Sub LoadGridTongHop()
        Dim dtl As DataTable = GetDataTable("Select SupplierName, isnull(sum(Amount),0) TotalTopUp, isnull((select Sum((BasefareNet + tax + FuelSurcharge)*Qty) from Ticketing where status='OK' and SupplierID=s.RecID and t.CustType=CustType),0) Used, 0 Remaining, Curr, CustType from TopUp t left join Supplier s on s.RecID=t.SupplierID where t.Status='OK' group by s.RecID, CustType, SupplierName, Curr")
        GridTongHop.DataSource = dtl
        GridTongHop.Columns("SupplierName").Width = 350
        GridTongHop.Columns("TotalTopUp").Width = 90
        GridTongHop.Columns("Used").Width = 90
        GridTongHop.Columns("CustType").Width = 90
        GridTongHop.Columns("TotalTopUp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTongHop.Columns("TotalTopUp").DefaultCellStyle.Format = "#,##"
        GridTongHop.Columns("Used").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTongHop.Columns("Used").DefaultCellStyle.Format = "#,##"
        For i As Integer = 0 To GridTongHop.RowCount - 1
            GridTongHop.Rows(i).Cells("Remaining").Value = GridTongHop.Rows(i).Cells("TotalTopUp").Value - GridTongHop.Rows(i).Cells("Used").Value
        Next
        GridTongHop.Columns("Remaining").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTongHop.Columns("Remaining").DefaultCellStyle.Format = "#,##"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strSQL As String
        strSQL = "Insert TopUp (SupplierID, Amount, CustType, ValidDate, FstUser, Curr) values (@SupplierID, @Amount, @CustType, @ValidDate, @FstUser, @Curr);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@SupplierID", cbxSupName.SelectedValue),
                New SqlParameter("@Amount", CDbl(txtAmount.Text)),
                New SqlParameter("@CustType", cbxType.Text),
                New SqlParameter("@ValidDate", dtpDate.Value),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@Curr", cbxCurr.Text)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("TopUp", RecID)
        LoadGridTopUp()
        LoadGridTongHop()
        btnNew_Click(sender, e)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strSQL As String
        strSQL = "Update TopUp set SupplierID=@SupplierID, CustType=@CustType, Amount=@Amount, ValidDate=@ValidDate, Curr=@Curr where RecID=" & dtr("RecID")

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@SupplierID", cbxSupName.SelectedValue),
                New SqlParameter("@CustType", cbxType.Text),
                New SqlParameter("@Amount", CDbl(txtAmount.Text)),
                New SqlParameter("@ValidDate", dtpDate.Value),
                New SqlParameter("@Curr", cbxCurr.Text)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("TopUp", dtr("RecID"))
        LoadGridTopUp()
        LoadGridTongHop()
        btnNew_Click(sender, e)
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            txtAmount.Text = FormatDigit(dtr("Amount"))
            cbxSupName.SelectedValue = dtr("SupplierID")
            cbxType.Text = dtr("CustType")
            dtpDate.Value = dtr("ValidDate")
            btnUpdate.Enabled = True
            btnAdd.Enabled = False
        Else
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub Acc_TopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildControl("Select RecID, SupplierName from Supplier where status='OK' order by SupplierName", "RecID", "SupplierName", cbxSupName)
        BuildControl("Select Val from MISC where CAT='CURR' and status='OK' order by val", "Val", "val", cbxCurr)
        LoadGridTopUp()
        LoadGridTongHop()
        btnNew_Click(sender, e)

    End Sub

    Private Sub GridTopUp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTopUp.CellClick
        bdsView_CurrentChanged(sender, e)
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
            ExeNonequery("update TopUp set Status='XX' where recID=@RecID", Para)
            GhiLog("TopUp", dtr("RecID"))
        End If
        LoadGridTopUp()
        LoadGridTongHop()
        btnNew_Click(sender, e)
    End Sub
End Class