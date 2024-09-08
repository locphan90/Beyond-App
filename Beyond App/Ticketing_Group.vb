Imports System.Data.SqlClient

Public Class Ticketing_Group
    Dim RunPageLoad As Boolean = False
    Dim dtr As DataRowView
    Private Sub Ticketing_Group_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BuildControl("Select 0 RecID, '' Code union select RecID, Code from Customer where Status='OK' and CustType='Agent' order by Code", "RecID", "Code", cbxAgent)
        cbxAgent.SelectedValue = 0
        LoadGridGroup()
        btnNew_Click(sender, e)
        RunPageLoad = True
    End Sub

    Private Sub cbxAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAgent.SelectedIndexChanged
        If RunPageLoad = True Then
            If cbxAgent.SelectedValue > 0 Then
                lblAgent.Text = ExeScalar("Select CustName from Customer Where RecID=" & cbxAgent.SelectedValue)
            Else
                lblAgent.Text = "-"
            End If

        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtContractNo.Text = ""
        txtItinerary.Text = ""
        txtNetAmt.Text = 0
        txtPNR.Text = ""
        txtQuantity.Text = 0
        txtRMK.Text = ""
        txtRMK1.Text = ""
        txtRMK2.Text = ""
        txtRMK3.Text = ""
        txtRMK4.Text = ""
        txtRMK5.Text = ""
        txtSellAmt.Text = 0
        txtTKNO.Text = ""
        cbxAgent.SelectedValue = 0
        cbxRoutingType.Text = ""
        dtpDepo1.Checked = False
        dtpDepo2.Checked = False
        dtpDepo3.Checked = False
        dtpReduceSeat.Checked = False
        dtpName.Checked = False
        btnUpdate.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub InsertGroup(CustID As Integer, ContractNo As String, PNR As String, TKNO As String, Itinerary As String, DeptDate As Date, EndDate As Date, RoutingType As String, NetAmt As Decimal, SellAmt As Decimal, Qty As Integer, RMK As String)

        Dim strSQL As String
        strSQL = "Insert GroupTicketing (CustID, ContractNo, PNR, TKNO, Itinerary, DeptDate, EndDate, RoutingType, NetAmt, SellAmt, Qty, RMK, FstUser) values (@CustID, @ContractNo, @PNR, @TKNO, @Itinerary, @DeptDate, @EndDate, @RoutingType, @NetAmt, @SellAmt, @Qty, @RMK, @FstUser);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@CustID", CustID),
                New SqlParameter("@ContractNo", ContractNo),
                New SqlParameter("@PNR", PNR),
                New SqlParameter("@TKNO", TKNO),
                New SqlParameter("@Itinerary", Itinerary),
                New SqlParameter("@DeptDate", DeptDate),
                New SqlParameter("@EndDate", EndDate),
                New SqlParameter("@RoutingType", RoutingType),
                New SqlParameter("@NetAmt", NetAmt),
                New SqlParameter("@SellAmt", SellAmt),
                New SqlParameter("@Qty", Qty),
                New SqlParameter("@RMK", RMK),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        UpdateDeadline(RecID)
        GhiLog("GroupTicketing", RecID)
    End Sub

    Private Sub UpdateGroup(CustID As Integer, ContractNo As String, PNR As String, TKNO As String, Itinerary As String, DeptDate As Date, EndDate As Date, RoutingType As String, NetAmt As Decimal, SellAmt As Decimal, Qty As Integer, RMK As String, RecID As Integer)
        Dim strSQL As String
        strSQL = "Update GroupTicketing set CustID=@CustID, ContractNo=@ContractNo, PNR=@PNR, TKNO=@TKNO, Itinerary=@Itinerary, DeptDate=@DeptDate, EndDate=@EndDate, RoutingType=@RoutingType, NetAmt=@NetAmt, SellAmt=@SellAmt, Qty=@Qty, RMK=@RMK where RecID=@RecID"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@CustID", CustID),
                New SqlParameter("@ContractNo", ContractNo),
                New SqlParameter("@PNR", PNR),
                New SqlParameter("@TKNO", TKNO),
                New SqlParameter("@Itinerary", Itinerary),
                New SqlParameter("@DeptDate", DeptDate),
                New SqlParameter("@EndDate", EndDate),
                New SqlParameter("@RoutingType", RoutingType),
                New SqlParameter("@NetAmt", NetAmt),
                New SqlParameter("@SellAmt", SellAmt),
                New SqlParameter("@Qty", Qty),
                New SqlParameter("@RMK", RMK),
                New SqlParameter("@RecID", RecID)
            }
        ExeNonequery(strSQL, Para)
        UpdateDeadline(RecID)
        GhiLog("GroupTicketing", RecID)
    End Sub

    Private Sub LoadGridGroup()
        Dim DK As String = ""
        If dtpFrom.Checked = True Then
            DK = " and FstUpdate between '" & Format(dtpFrom.Value, "dd-MMM-yy") & "' and '" & Format(dtpTo.Value, "dd-MMM-yy") & " 23:59'"
        End If
        Dim dtl As DataTable = GetDataTable("Select (Select Code from Customer where RecID=GroupTicketing.CustID) as Agent, ContractNo, PNR, TKNO, Itinerary, DeptDate, EndDate, RoutingType, Qty, NetAmt, SellAmt, NetAmt*Qty TotalNet, SellAmt*Qty TotalSell, (SellAmt-NetAmt)*Qty Revenue, RMK, (Select HoTen from tblUser where RecID=GroupTicketing.RecID) FstUser, FstUpdate, RecID, CustID from GroupTicketing where Status='OK' " & DK & " order by RecID")
        bdsView.DataSource = dtl
        GridGroup.DataSource = bdsView
        GridGroup.Columns("RecID").Visible = False
        GridGroup.Columns("CustID").Visible = False
        GridGroup.Columns("Agent").Width = 150
        GridGroup.Columns("Agent").Width = 150
        GridGroup.Columns("PNR").Width = 50
        GridGroup.Columns("TKNO").Width = 200
        GridGroup.Columns("Itinerary").Width = 200
        GridGroup.Columns("DeptDate").Width = 65
        GridGroup.Columns("EndDate").Width = 65
        GridGroup.Columns("RoutingType").Width = 70
        GridGroup.Columns("NetAmt").Width = 75
        GridGroup.Columns("SellAmt").Width = 75
        GridGroup.Columns("Qty").Width = 30
        GridGroup.Columns("RMK").Width = 300
        GridGroup.Columns("FstUser").Width = 150
        GridGroup.Columns("FstUpdate").Width = 90
        GridGroup.Columns("TotalNet").Width = 75
        GridGroup.Columns("TotalSell").Width = 75
        GridGroup.Columns("Revenue").Width = 75
        GridGroup.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("DeptDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("EndDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("Qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("NetAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("SellAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("TotalNet").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("TotalSell").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("Revenue").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridGroup.Columns("EndDate").DefaultCellStyle.Format = "dd-MMM-yy"
        GridGroup.Columns("DeptDate").DefaultCellStyle.Format = "dd-MMM-yy"
        GridGroup.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridGroup.Columns("Qty").DefaultCellStyle.Format = "#,##"
        GridGroup.Columns("NetAmt").DefaultCellStyle.Format = "#,##"
        GridGroup.Columns("SellAmt").DefaultCellStyle.Format = "#,##"
        GridGroup.Columns("Revenue").DefaultCellStyle.Format = "#,##"
        GridGroup.Columns("TotalNet").DefaultCellStyle.Format = "#,##"
        GridGroup.Columns("TotalSell").DefaultCellStyle.Format = "#,##"
        GridGroup.Columns("PNR").Frozen = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbxAgent.SelectedValue = 0 Then
            MsgBox("Chưa chọn đại lý!")
            Exit Sub
        End If
        InsertGroup(cbxAgent.SelectedValue, txtContractNo.Text, txtPNR.Text, txtTKNO.Text, txtItinerary.Text, dtpDeptDate.Value, dtpEndDate.Value, cbxRoutingType.Text, txtNetAmt.Text, txtSellAmt.Text, txtQuantity.Text, txtRMK.Text)
        LoadGridGroup()
        btnNew_Click(sender, e)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cbxAgent.SelectedValue = 0 Then
            MsgBox("Chưa chọn đại lý!")
            Exit Sub
        End If
        UpdateGroup(cbxAgent.SelectedValue, txtContractNo.Text, txtPNR.Text, txtTKNO.Text, txtItinerary.Text, dtpDeptDate.Value, dtpEndDate.Value, cbxRoutingType.Text, txtNetAmt.Text, txtSellAmt.Text, txtQuantity.Text, txtRMK.Text, dtr("RecID"))
        LoadGridGroup()
        btnNew_Click(sender, e)
    End Sub

    Private Sub InsertDeadline(GroupTicketingID As Integer, Deadline As Date, RMK As String, Type As String)
        Dim strSQL As String
        strSQL = "Insert Deadline (GroupTicketingID, Deadline, RMK, Type, FstUser) values (@GroupTicketingID, @Deadline, @RMK, @Type, @FstUser)"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@GroupTicketingID", GroupTicketingID),
                New SqlParameter("@Deadline", Deadline),
                New SqlParameter("@RMK", RMK),
                New SqlParameter("@Type", Type),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        ExeNonequery(strSQL, Para)
    End Sub

    Private Sub UpdateDeadline(GroupTicketingID As Int64)
        ExeNonequery("Update Deadline set Status='XX' where Status='QQ' and GroupTicketingID=" & GroupTicketingID)
        If dtpDepo1.Checked And dtpDepo1.Enabled = True Then
            InsertDeadline(GroupTicketingID, dtpDepo1.Value, txtRMK1.Text, "DEPO1")
        End If
        If dtpDepo2.Checked And dtpDepo2.Enabled = True Then
            InsertDeadline(GroupTicketingID, dtpDepo2.Value, txtRMK2.Text, "DEPO2")
        End If
        If dtpDepo3.Checked And dtpDepo3.Enabled = True Then
            InsertDeadline(GroupTicketingID, dtpDepo3.Value, txtRMK3.Text, "DEPO3")
        End If
        If dtpReduceSeat.Checked And dtpReduceSeat.Enabled = True Then
            InsertDeadline(GroupTicketingID, dtpReduceSeat.Value, txtRMK4.Text, "REDUCESEAT")
        End If
        If dtpName.Checked And dtpName.Enabled = True Then
            InsertDeadline(GroupTicketingID, dtpName.Value, txtRMK5.Text, "NAME")
        End If
    End Sub

    Private Sub LoadGridDeadline()
        dtpDepo1.Checked = False
        dtpDepo2.Checked = False
        dtpDepo3.Checked = False
        dtpReduceSeat.Checked = False
        dtpName.Checked = False
        dtpDepo1.Enabled = True
        dtpDepo2.Enabled = True
        dtpDepo3.Enabled = True
        dtpReduceSeat.Enabled = True
        dtpName.Enabled = True
        Dim dtl As DataTable = GetDataTable("Select * from Deadline where GroupTicketingID=" & dtr("RecID") & " and Status<>'XX'")
        For i As Int16 = 0 To dtl.rows.count - 1
            If dtl.rows(i)("Type") = "DEPO1" Then
                If dtl.rows(i)("Status") = "QQ" Then
                    dtpDepo1.Enabled = True
                Else
                    dtpDepo1.Enabled = False
                End If
                dtpDepo1.Checked = True
                dtpDepo1.Value = dtl.Rows(i)("Deadline")
                txtRMK1.Text = dtl.Rows(i)("RMK")
            ElseIf dtl.rows(i)("Type") = "DEPO2" Then
                If dtl.rows(i)("Status") = "QQ" Then
                    dtpDepo2.Enabled = True
                Else
                    dtpDepo2.Enabled = False
                End If
                dtpDepo2.Checked = True
                dtpDepo2.Value = dtl.Rows(i)("Deadline")
                txtRMK2.Text = dtl.Rows(i)("RMK")
            ElseIf dtl.rows(i)("Type") = "DEPO3" Then
                If dtl.rows(i)("Status") = "QQ" Then
                    dtpDepo3.Enabled = True
                Else
                    dtpDepo3.Enabled = False
                End If
                dtpDepo3.Checked = True
                dtpDepo3.Value = dtl.Rows(i)("Deadline")
                txtRMK3.Text = dtl.Rows(i)("RMK")
            ElseIf dtl.rows(i)("Type") = "REDUCESEAT" Then
                If dtl.rows(i)("Status") = "QQ" Then
                    dtpReduceSeat.Enabled = True
                Else
                    dtpReduceSeat.Enabled = False
                End If
                dtpReduceSeat.Checked = True
                dtpReduceSeat.Value = dtl.Rows(i)("Deadline")
                txtRMK4.Text = dtl.Rows(i)("RMK")
            ElseIf dtl.rows(i)("Type") = "NAME" Then
                If dtl.rows(i)("Status") = "QQ" Then
                    dtpName.Enabled = True
                Else
                    dtpName.Enabled = False
                End If
                dtpName.Checked = True
                dtpName.Value = dtl.Rows(i)("Deadline")
                txtRMK5.Text = dtl.Rows(i)("RMK")
            End If
        Next
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            txtContractNo.Text = dtr("ContractNo")
            txtItinerary.Text = dtr("Itinerary")
            txtNetAmt.Text = FormatDigit(dtr("NetAmt"))
            txtPNR.Text = dtr("PNR")
            txtQuantity.Text = dtr("Qty")
            txtRMK.Text = dtr("RMK")
            txtTKNO.Text = dtr("TKNO")
            txtSellAmt.Text = FormatDigit(dtr("SellAmt"))
            cbxAgent.SelectedValue = dtr("CustID")
            LoadGridDeadline()
            dtpDeptDate.Value = dtr("DeptDate")
            dtpEndDate.Value = dtr("EndDate")
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        Else
            btnNew_Click(sender, e)
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

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa supplier này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update GroupTicketing set Status='XX' where recID=@RecID", Para)
            ExeNonequery("update Deadline set Status='XX' where GroupTicketingID=@RecID", Para)
            GhiLog("GroupTicketing", dtr("RecID"))
        End If
        LoadGridGroup()
        btnNew_Click(sender, e)
    End Sub

    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSellAmt.KeyPress, txtNetAmt.KeyPress, txtQuantity.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSellAmt.TextChanged, txtNetAmt.TextChanged, txtQuantity.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtSellAmt.Leave, txtNetAmt.Leave, txtQuantity.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtSellAmt.GotFocus, txtNetAmt.GotFocus, txtQuantity.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub GridGroup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridGroup.CellClick
        bdsView_CurrentChanged(sender, e)
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged
        If RunPageLoad = True Then
            LoadGridGroup()
        End If
    End Sub

End Class
