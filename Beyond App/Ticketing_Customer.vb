Imports System.Data.SqlClient
Public Class Ticketing_Customer
    Dim dtr As DataRowView
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtCode.Text = ""
        txtCode.ReadOnly = False
        txtAddress.Text = ""
        txtCustName.Text = ""
        txtPhone.Text = ""
        cbxType.Text = ""
        txtBankAccount.Text = ""
        txtBankName.Text = ""
        txtEmail.Text = ""
        txtRepresentative.Text = ""
        txtTaxCode.Text = ""
        txtCode.Select()
        cbxRole.Text = ""
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub LoadGridCust()
        Dim dtl As DataTable = GetDataTable("Select Code, CustName, CustType, Phone, Address, TaxCode, Email, BankName, BankAccount, Representative, Role, RecID from Customer where Status='OK' order by Code, Custtype")
        bdsView.DataSource = dtl
        GridCustomer.DataSource = bdsView
        GridCustomer.Columns("RecID").Visible = False
        GridCustomer.Columns("Code").Width = 80
        GridCustomer.Columns("CustName").Width = 200
        GridCustomer.Columns("CustType").Width = 80
        GridCustomer.Columns("Address").Width = 350
        GridCustomer.Columns("Phone").Width = 80
        GridCustomer.Columns("TaxCode").Width = 80
        GridCustomer.Columns("Email").Width = 150
        GridCustomer.Columns("BankName").Width = 110
        GridCustomer.Columns("BankAccount").Width = 110
        GridCustomer.Columns("Representative").Width = 150
        GridCustomer.Columns("Role").Width = 80
        GridCustomer.Columns("CustType").Frozen = True
    End Sub

    Private Sub GridCustomer_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridCustomer.DataBindingComplete
        GridCustomer.ClearSelection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCode.Text = "" Then
            MsgBox("Chưa nhập code khách hàng!")
            Exit Sub
        End If
        If ExeScalar("select count(*) from customer where Status='OK' and Code='" & txtCode.Text.Replace("'", "") & "'") = 0 Then
        Else
            MsgBox("Code khách hàng này đã tồn tại!")
            Exit Sub
        End If
        Dim strSQL As String
        strSQL = "insert Customer (Code, CustName, CustType, Phone, Address, FstUser, TaxCode, Email, BankName, BankAccount, Representative, Role) values (@Code, @CustName, @CustType, @Phone, @Address, @FstUser, @TaxCode, @Email, @BankName, @BankAccount, @Representative, @Role);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@Code", txtCode.Text),
                New SqlParameter("@CustName", txtCustName.Text),
                New SqlParameter("@CustType", cbxType.Text),
                New SqlParameter("@Phone", txtPhone.Text),
                New SqlParameter("@Address", txtAddress.Text),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@TaxCode", txtTaxCode.Text),
                New SqlParameter("@Email", txtEmail.Text),
                New SqlParameter("@BankName", txtBankName.Text),
                New SqlParameter("@BankAccount", txtBankAccount.Text),
                New SqlParameter("@Representative", txtRepresentative.Text),
                New SqlParameter("@Role", cbxRole.Text)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("Customer", RecID)
        LoadGridCust()
        btnNew_Click(sender, e)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strSQL As String
        strSQL = "Update Customer set CustName=@CustName, CustType=@CustType, Phone=@Phone, Address=@Address, TaxCode=@TaxCode, Email=@Email, BankName=@BankName, BankAccount=@BankAccount, Representative=@Representative, Role=@Role where RecID=" & dtr("RecID")

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@Code", txtCode.Text),
                New SqlParameter("@CustName", txtCustName.Text),
                New SqlParameter("@CustType", cbxType.Text),
                New SqlParameter("@Phone", txtPhone.Text),
                New SqlParameter("@Address", txtAddress.Text),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@TaxCode", txtTaxCode.Text),
                New SqlParameter("@Email", txtEmail.Text),
                New SqlParameter("@BankName", txtBankName.Text),
                New SqlParameter("@BankAccount", txtBankAccount.Text),
                New SqlParameter("@Representative", txtRepresentative.Text),
                New SqlParameter("@Role", cbxRole.Text)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("Customer", dtr("RecID"))
        LoadGridCust()
        btnNew_Click(sender, e)
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            txtCode.ReadOnly = True
            txtAddress.Text = dtr("Address")
            txtCode.Text = dtr("Code")
            txtCustName.Text = dtr("CustName")
            txtPhone.Text = dtr("Phone")
            cbxType.SelectedText = dtr("CustType")
            txtRepresentative.Text = dtr("Representative")
            txtBankAccount.Text = dtr("BankAccount")
            txtBankName.Text = dtr("BankName")
            txtEmail.Text = dtr("Email")
            txtTaxCode.Text = dtr("TaxCode")
            cbxRole.Text = dtr("Role")
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        Else
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub Ticketing_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridCust()
        BuildControl("Select val2 from misc where CAT='ROLE' and status='OK' union select '' order by val2", "Val2", "Val2", cbxRole)

        btnNew_Click(sender, e)
    End Sub

    Private Sub GridCustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCustomer.CellClick
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

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update customer set Status='XX' where recID=@RecID", Para)
            GhiLog("Customer", dtr("RecID"))
        End If
        LoadGridCust()
        btnNew_Click(sender, e)
    End Sub
End Class