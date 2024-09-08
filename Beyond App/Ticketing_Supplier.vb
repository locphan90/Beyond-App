Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class Ticketing_Supplier
    Dim dtr As DataRowView
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtSupCode.Text = ""
        txtSupName.Text = ""
        btnUpdate.Enabled = False
        btnAdd.Enabled = True
        cbxType.Text = ""
        txtAccountName.Text = ""
        txtAccountNo.Text = ""
        txtBankName.Text = ""
        txtSupCode.Select()
    End Sub

    Private Sub LoadGridSupplier()
        Dim dtl As DataTable = GetDataTable("Select RecID, SupplierCode, SupplierName, Type, BankName, AccountName, AccountNo from Supplier where Status='OK' order by Suppliercode")
        bdsView.DataSource = dtl
        GridSupplier.DataSource = bdsView
        GridSupplier.Columns("RecID").Visible = False
        GridSupplier.Columns("SupplierCode").Width = 110
        GridSupplier.Columns("SupplierName").Width = 180
        GridSupplier.Columns("BankName").Width = 150
        GridSupplier.Columns("AccountName").Width = 150
        GridSupplier.Columns("AccountNo").Width = 110
    End Sub

    Private Sub GridSupplier_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridSupplier.DataBindingComplete
        GridSupplier.ClearSelection()
    End Sub

    Private Sub Ticketing_Airline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridSupplier()
        btnNew_Click(sender, e)
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            txtSupCode.Text = dtr("SupplierCode")
            txtSupName.Text = dtr("SupplierName")
            cbxType.Text = dtr("Type")
            txtAccountName.Text = dtr("AccountName")
            txtAccountNo.Text = dtr("AccountNo")
            txtBankName.Text = dtr("BankName")
            btnUpdate.Enabled = True
            btnAdd.Enabled = False
        Else
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strSQL As String
        strSQL = "Update Supplier set SupplierCode=@SupplierCode, SupplierName=@SupplierName, Type=@Type, BankName=@BankName, AccountName=@AccountName, AccountNo=@AccountNo where RecID=" & dtr("RecID")

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@SupplierCode", txtSupCode.Text),
                New SqlParameter("@SupplierName", txtSupName.Text),
                New SqlParameter("@Type", cbxType.Text),
                New SqlParameter("@BankName", txtBankName.Text),
                New SqlParameter("@AccountName", txtAccountName.Text),
                New SqlParameter("@AccountNo", txtAccountNo.Text)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("Supplier", dtr("RecID"))
        LoadGridSupplier()
        btnNew_Click(sender, e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strSQL As String
        strSQL = "insert Supplier (SupplierCode, SupplierName, Type, FstUser, BankName, AccountName, AccountNo ) values (@SupplierCode, @SupplierName, @Type, @FstUser, @BankName, @AccountName, @AccountNo);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@SupplierCode", txtSupCode.Text),
                New SqlParameter("@SupplierName", txtSupName.Text),
                New SqlParameter("@Type", cbxType.Text),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@BankName", txtBankName.Text),
                New SqlParameter("@AccountName", txtAccountName.Text),
                New SqlParameter("@AccountNo", txtAccountNo.Text)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("Supplier", RecID)
        LoadGridSupplier()
        btnNew_Click(sender, e)
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

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa supplier này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update Supplier set Status='XX' where recID=@RecID", Para)
            GhiLog("Supplier", dtr("RecID"))
        End If
        LoadGridSupplier()
        btnNew_Click(sender, e)
    End Sub

    Private Sub GridSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridSupplier.CellClick
        bdsView_CurrentChanged(sender, e)
    End Sub
End Class