Imports System.Data.SqlClient

Public Class Ticketing_CharterBuy
    Dim dtrCode As DataRowView
    Dim dtrLand As DataRowView
    Dim RunPageLoad As Boolean = False
    Private Function CreateCode(Code As String) As String
        Dim Result As String = ""
        Dim i As Int16 = ExeScalar("Select count(*) from CharterCode where Status='OK' and Code like '%" & Code & "%' and Status='OK'")
        If i = 0 Then
            Result = Code
        Else
            Result = Code & "_" & i + 1
        End If
        Return Result
    End Function

    Private Sub LoadGridCode()
        Dim dtl As DataTable = GetDataTable("Select Code, DeptDate, EndDate, Descr, AirSupplierID, QtyC, QtyY, TotalAmount, ContractorFee, RefPriceC, RefPriceY, Curr, RecID from CharterCode where Status='OK' order by Code, RecID")
        bdsCode.DataSource = dtl
        GridCode.DataSource = bdsCode
        GridCode.Columns("RecID").Visible = False
        GridCode.Columns("AirSupplierID").Visible = False
        GridCode.Columns("QtyC").Visible = False
        GridCode.Columns("QtyY").Visible = False
        GridCode.Columns("TotalAmount").Visible = False
        GridCode.Columns("ContractorFee").Visible = False
        GridCode.Columns("RefPriceY").Visible = False
        GridCode.Columns("RefPriceC").Visible = False
        GridCode.Columns("Curr").Visible = False
        GridCode.Columns("Code").Width = 110
        GridCode.Columns("Descr").Width = 180
        GridCode.Columns("DeptDate").Width = 60
        GridCode.Columns("DeptDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCode.Columns("DeptDate").DefaultCellStyle.Format = "dd-MMM-yy"
        GridCode.Columns("EndDate").Width = 60
        GridCode.Columns("EndDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCode.Columns("EndDate").DefaultCellStyle.Format = "dd-MMM-yy"
        GridCode.Columns("Code").Frozen = True
    End Sub

    Private Sub LoadGridLand()
        Dim dtl As DataTable = GetDataTable("Select SupplierName, l.Type, Bus, l.Qty, l.Curr, Price, RefPrice, (Select HoTen from tbluser where RecID=l.FstUser)FstUser, l.FstUpdate, l.RecID, LandSupplierID from CharterLand l left join CharterCode c on c.RecID=l.CharterID left join Supplier s on s.RecID=l.LandSupplierID where l.Status='OK' and CharterID=" & dtrCode("RecID") & " order by l.RecID")
        bdsLand.DataSource = dtl
        GridLand.DataSource = bdsLand
        GridLand.Columns("RecID").Visible = False
        GridLand.Columns("LandSupplierID").Visible = False
        GridLand.Columns("SupplierName").Width = 150
        GridLand.Columns("Type").Width = 50
        GridLand.Columns("Curr").Width = 35
        GridLand.Columns("RefPrice").Width = 70
        GridLand.Columns("Bus").Width = 80
        GridLand.Columns("Price").Width = 80
        GridLand.Columns("Qty").Width = 30
        GridLand.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridLand.Columns("Price").DefaultCellStyle.Format = "#,##"
        GridLand.Columns("RefPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridLand.Columns("RefPrice").DefaultCellStyle.Format = "#,##"
        GridLand.Columns("FstUser").Width = 150
        GridLand.Columns("FstUpdate").Width = 90
        GridLand.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridLand.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridLand.Columns("Type").Frozen = True
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim strSQL As String
        strSQL = "insert CharterCode (Code, DeptDate, EndDate, Descr, FstUser) values (@Code, @DeptDate, @EndDate, @Descr, @FstUser);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@Code", CreateCode(txtCode.Text & Format(dtpDeptDate.Value, "ddMMyy"))),
                New SqlParameter("@DeptDate", CDate(dtpDeptDate.Value)),
                New SqlParameter("@EndDate", CDate(dtpEndDate.Value)),
                New SqlParameter("@Descr", txtDescr.Text),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("CharterCode", RecID)
        LoadGridCode()
        txtCode.Text = ""
        dtpDeptDate.Value = Date.Now
        txtDescr.Text = ""
    End Sub

    Private Sub GridLand_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridLand.DataBindingComplete
        GridLand.ClearSelection()
    End Sub

    Private Sub GridCode_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridCode.DataBindingComplete
        GridCode.ClearSelection()
    End Sub

    Private Sub bdsCode_CurrentChanged(sender As Object, e As EventArgs) Handles bdsCode.CurrentChanged
        If bdsCode.Count > 0 Then
            dtrCode = bdsCode.Current
            txtQtyC.Text = FormatDigit(dtrCode("QtyC"))
            txtQtyY.Text = FormatDigit(dtrCode("QtyY"))
            txtTotalAirAmount.Text = FormatDigit(dtrCode("TotalAmount"))
            cbxAirSupplier.SelectedValue = dtrCode("AirSupplierID")
            txtContractorFee.Text = FormatDigit(dtrCode("ContractorFee"))
            txtRefPriceC.Text = FormatDigit(dtrCode("RefPriceC"))
            txtRefPriceY.Text = FormatDigit(dtrCode("RefPriceY"))
            cbxCurrAir.Text = dtrCode("Curr")
            LoadGridLand()
        Else
            txtQtyC.Text = 0
            txtQtyY.Text = 0
            txtRefPriceC.Text = 0
            txtRefPriceY.Text = 0
            cbxCurrAir.Text = ""
            cbxAirSupplier.Text = ""
            txtTotalAirAmount.Text = 0
            txtContractorFee.Text = 0
            GridLand.DataSource = Nothing
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bdsCode.Filter = "Code like '%" & txtSearch.Text & "%'"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If bdsCode.Count = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", dtrCode("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa code này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update CharterCode set Status='XX' where recID=@RecID", Para)
            GhiLog("CharterCode", dtrCode("RecID"))
        End If
        LoadGridCode()
        bdsCode_CurrentChanged(sender, e)
    End Sub

    Private Sub Ticketing_CharterBuy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridCode()
        BuildControl("Select RecID, SupplierName from Supplier where Status='OK' and Type='Land' union select 0, '' order by SupplierName", "RecID", "SupplierName", cbxSupplier)
        BuildControl("Select RecID, SupplierName from Supplier where Status='OK' and Type='Air' union select 0, '' order by SupplierName", "RecID", "SupplierName", cbxAirSupplier)
        BuildControl("Select Val, Val2 from MISC where CAT='BUS' and Status='OK' order by convert(int,Val)", "VAL", "VAL2", clbBus)
        BuildControl("Select Val from MISC where CAT='CURR' and status='OK' order by val", "Val", "val", cbxCurrAir)
        BuildControl("Select Val from MISC where CAT='CURR' and status='OK' order by val", "Val", "val", cbxCurrLand)
        bdsCode_CurrentChanged(sender, e)
        RunPageLoad = True
        txtQtyC.Text = 0
        txtQtyY.Text = 0
        txtRefPriceC.Text = 0
        txtRefPriceY.Text = 0
        cbxCurrAir.Text = ""
        cbxAirSupplier.Text = ""
        txtTotalAirAmount.Text = 0
        txtContractorFee.Text = 0
        GridLand.DataSource = Nothing
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim BusList As String = ""
        For Each item As Object In clbBus.CheckedItems
            Dim row As DataRowView = TryCast(item, DataRowView)
            BusList = BusList & "_" & row("Val")
        Next
        Dim strSQL As String
        strSQL = "insert CharterLand (CharterID, LandSupplierID, Type, Bus, Qty, Price, FstUser, RefPrice, Curr) values (@CharterID, @LandSupplierID, @Type, @Bus, @Qty, @Price, @FstUser, @RefPrice, @Curr);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@CharterID", dtrCode("RecID")),
                New SqlParameter("@LandSupplierID", cbxSupplier.SelectedValue),
                New SqlParameter("@Type", cbxType.Text),
                New SqlParameter("@Bus", BusList),
                New SqlParameter("@Qty", txtQty.Text),
                New SqlParameter("@Price", CDec(txtPrice.Text)),
                New SqlParameter("@RefPrice", CDec(txtRefPrice.Text)),
                New SqlParameter("@Curr", cbxCurrLand.Text),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("CharterLand", RecID)
        LoadGridLand()
        cbxSupplier.Text = ""
        txtQty.Text = 0
        cbxType.Text = ""
        txtPrice.Text = 0
        txtRefPrice.Text = 0
        For i = 0 To clbBus.Items.Count - 1
            clbBus.SetItemChecked(i, False)
        Next
    End Sub


    Private Sub LoadBusList(BusList As String)
        For i = 0 To clbBus.Items.Count - 1
            clbBus.SetItemChecked(i, False)
        Next
        For i As Integer = 0 To clbBus.Items.Count - 1
            If InStr(BusList, clbBus.GetItemText(clbBus.Items(i)).ToString) <> 0 Then
                clbBus.SetItemChecked(i, True)
            End If
        Next
    End Sub

    Private Sub bdsLand_CurrentChanged(sender As Object, e As EventArgs) Handles bdsLand.CurrentChanged
        If bdsLand.Count > 0 Then
            dtrLand = bdsLand.Current
            'cbxSupplier.SelectedValue = dtrLand("LandSupplierID")
            'txtQty.Text = dtrLand("Qty")
            'cbxType.Text = dtrLand("Type")
            'txtPrice.Text = FormatDigit(dtrLand("Price"))
            'LoadBusList(dtrLand("Bus"))
        End If
    End Sub

    Private Sub btnDeleteInfo_Click(sender As Object, e As EventArgs) Handles btnDeleteInfo.Click
        If bdsCode.Count = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", dtrLand("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa land này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update CharterLand set Status='XX' where recID=@RecID", Para)
            GhiLog("CharterLand", dtrLand("RecID"))
        End If
        LoadGridLand()
    End Sub

    Private Sub btnUpdateAir_Click(sender As Object, e As EventArgs) Handles btnUpdateAir.Click
        Dim strSQL As String
        strSQL = "Update CharterCode set AirSupplierID=@AirSupplierID, QtyC=@QtyC, QtyY=@QtyY, TotalAmount=@TotalAmount, ContractorFee=@ContractorFee, Curr=@Curr, RefPriceC=@RefPriceC, RefPriceY=@RefPriceY where RecID=" & dtrCode("RecID")

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@AirSupplierID", cbxAirSupplier.SelectedValue),
                New SqlParameter("@QtyC", CInt(txtQtyC.Text)),
                New SqlParameter("@QtyY", CInt(txtQtyY.Text)),
                New SqlParameter("@TotalAmount", CDec(txtTotalAirAmount.Text)),
                New SqlParameter("@ContractorFee", CDec(txtContractorFee.Text)),
                New SqlParameter("@Curr", cbxCurrAir.Text),
                New SqlParameter("@RefPriceC", CDec(txtRefPriceC.Text)),
                New SqlParameter("@RefPriceY", CDec(txtRefPriceY.Text))
            }
        ExeNonequery(strSQL, Para)
        GhiLog("CharterCode", dtrCode("RecID"))
        LoadGridCode()
    End Sub

    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress, txtQty.KeyPress, txtQtyC.KeyPress, txtQtyY.KeyPress, txtTotalAirAmount.KeyPress, txtContractorFee.KeyPress, txtRefPriceY.KeyPress, txtRefPriceC.KeyPress, txtRefPrice.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged, txtQty.TextChanged, txtQtyC.TextChanged, txtQtyY.TextChanged, txtTotalAirAmount.TextChanged, txtContractorFee.TextChanged, txtRefPriceY.TextChanged, txtRefPriceC.TextChanged, txtRefPrice.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave, txtQty.Leave, txtQtyC.Leave, txtQtyY.Leave, txtTotalAirAmount.Leave, txtContractorFee.Leave, txtRefPriceY.Leave, txtRefPriceC.Leave, txtRefPrice.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtPrice.GotFocus, txtQty.GotFocus, txtQtyC.GotFocus, txtQtyY.GotFocus, txtTotalAirAmount.GotFocus, txtContractorFee.GotFocus, txtRefPriceY.GotFocus, txtRefPriceC.GotFocus, txtRefPrice.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub GridCode_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCode.CellClick
        bdsCode_CurrentChanged(sender, e)
    End Sub

    Private Sub btnSell_Click(sender As Object, e As EventArgs) Handles btnSell.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_ChaterSell") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_CharterSell(dtrCode("RecID"))
            f.MdiParent = FrmMain
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub cbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged, cbxSupplier.SelectedIndexChanged
        If RunPageLoad = True Then
            Dim Result As Decimal = 0
            Result = ExeScalar("select isnull(Price,0) from LandSetting where Status='OK' and Type='" & cbxType.Text & "' and SupplierID=" & cbxSupplier.SelectedValue)
            txtPrice.Text = FormatDigit(Result)
        End If
    End Sub
End Class