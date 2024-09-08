Imports System.Data.SqlClient

Public Class Ticketing_AirRail
    Dim RunPageLoad As Boolean = False
    Dim dtlService As DataTable
    Dim dtrPNR As DataRowView
    Dim dtrTicketing As DataRowView
    Private Sub Ticketing_AirRail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildControl("Select RecID, SupplierName from Supplier where Status='OK' and Type='Air' union Select 0, '' order by SupplierName", "RecID", "SupplierName", cbxSupplier)
        BuildControl("Select 0 RecID, '' Code union select RecID, Code from Customer where Status='OK' order by Code", "RecID", "Code", cbxCust)
        BuildControl("Select Val from MISC where CAT='CURR' and status='OK' order by val", "Val", "val", cbxCurr)
        BuildControl("Select Val from MISC where CAT='CURR' and status='OK' order by val", "Val", "val", cbxServiceCurr)
        RunPageLoad = True
        TaoGridService()
        cbxCurr.Text = "VND"
        cbxServiceCurr.Text = "VND"
        LoadGridPNR()
        cbxType.Text = "Service"
        btnNew_Click(sender, e)
    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSupplier.SelectedIndexChanged, cbxCustType.SelectedIndexChanged, cbxCurr.SelectedIndexChanged, txtROE.Leave
        If cbxCurr.Text = "VND" Then
            txtROE.ReadOnly = True
            txtROE.Text = 1
        Else
            txtROE.ReadOnly = False
        End If
        If RunPageLoad = True Then
            If cbxSupplier.Text <> "" Then
                lblBalanceNumber.Text = FormatDigit(ExeScalar("Select isnull(Sum(Amount),0) -(select isnull(Sum((BasefareNet+Tax+FuelSurcharge)*Qty),0) from Ticketing where SupplierID=t.SupplierID and CustType='" & cbxCustType.Text & "' and status='OK' and Curr='" & cbxCurr.Text & "') from TopUp t where Status='OK' and Custtype='" & cbxCustType.Text & "' and SupplierID=" & cbxSupplier.SelectedValue & " and Curr='" & cbxCurr.Text & "' group by SupplierID"))
                lblBalanceNumber.Text = FormatDigit(CDbl(lblBalanceNumber.Text) * CInt(txtROE.Text))
            Else
                lblBalanceNumber.Text = 0
            End If
        End If
    End Sub

    Private Sub cbxCust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCust.SelectedIndexChanged
        If RunPageLoad = True Then
            If cbxCust.SelectedValue <> 0 Then
                txtCustomerName.Text = ExeScalar("Select CustName from Customer where RecID=" & cbxCust.SelectedValue)
                txtCustomerName.ReadOnly = True
            Else
                txtCustomerName.ReadOnly = False
                txtCustomerName.Text = ""
            End If
        End If
    End Sub

    'FormatNum
    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress, txtAgentComm.KeyPress, txtBasefareNet.KeyPress, txtBasefareSell.KeyPress, txtFuelSurcharge.KeyPress, txtPersonComm.KeyPress, txtQuantity.KeyPress, txtROE.KeyPress, txtServiceQty.KeyPress, txtTax.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged, txtAgentComm.TextChanged, txtBasefareNet.TextChanged, txtBasefareSell.TextChanged, txtFuelSurcharge.TextChanged, txtPersonComm.TextChanged, txtQuantity.TextChanged, txtROE.TextChanged, txtServiceQty.TextChanged, txtTax.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtAmount.Leave, txtAgentComm.Leave, txtBasefareNet.Leave, txtBasefareSell.Leave, txtFuelSurcharge.Leave, txtPersonComm.Leave, txtQuantity.Leave, txtROE.Leave, txtServiceQty.Leave, txtTax.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtAmount.GotFocus, txtAgentComm.GotFocus, txtBasefareNet.GotFocus, txtBasefareSell.GotFocus, txtFuelSurcharge.GotFocus, txtPersonComm.GotFocus, txtQuantity.GotFocus, txtROE.GotFocus, txtServiceQty.GotFocus, txtTax.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub TaoGridService()
        dtlService = New DataTable
        dtlService.Columns.Add("Type", GetType(String))
        dtlService.Columns.Add("TypeName", GetType(String))
        dtlService.Columns.Add("Curr", GetType(String))
        dtlService.Columns.Add("Invoice", GetType(Boolean))
        dtlService.Columns.Add("Qty", GetType(Integer))
        dtlService.Columns.Add("Amount", GetType(Decimal))
        dtlService.Columns.Add("RMK", GetType(String))

    End Sub

    Private Sub LoadGridService(JSON_Service As String)
        If JSON_Service.Length > 0 Then
            dtlService = GetDataTable("SELECT * FROM OPENJSON(N'" & JSON_Service & "') with (Type VARCHAR(10) N'$.Type', TypeName NVARCHAR(100) N'$.TypeName', Invoice bit '$.Invoice', Curr varchar(3) '$.Curr', Qty int '$.Qty',  Amount decimal '$.Amount', RMK NVARCHAR(500) '$.RMK')")
            GridService.DataSource = dtlService
            GridService.Columns("Type").Width = 65
            GridService.Columns("TypeName").Width = 150
            GridService.Columns("Invoice").Width = 50
            GridService.Columns("Curr").Width = 35
            GridService.Columns("Qty").Width = 30
            GridService.Columns("Amount").Width = 60
            GridService.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            GridService.Columns("Amount").DefaultCellStyle.Format = "#,##"
            GridService.Columns("RMK").Width = 260
        End If
    End Sub

    Private Sub TinhTongService()
        Dim TotalServiceFee As Decimal = 0, TotalCharge As Decimal = 0
        For i As Int16 = 0 To GridService.Rows.Count - 1
            If GridService.Rows(i).Cells("Type").Value = "CHARGE" Then
                TotalCharge = TotalCharge + GridService.Rows(i).Cells("Qty").Value * GridService.Rows(i).Cells("Amount").Value
            Else
                TotalServiceFee = TotalServiceFee + GridService.Rows(i).Cells("Qty").Value * GridService.Rows(i).Cells("Amount").Value
            End If
        Next
        txtTotalServiceFee.Text = FormatDigit(TotalServiceFee)
        txtTotalServiceCharge.Text = FormatDigit(TotalCharge)
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        If txtAmount.Text = "0" Then
            MsgBox("Chưa nhập số tiền!")
            Exit Sub
        End If
        dtlService.Rows.Add(cbxServiceType.SelectedValue, cbxServiceType.Text, cbxServiceCurr.Text, Convert.ToBoolean(chkInvService.Checked), txtServiceQty.Text, txtAmount.Text, txtServiceRMK.Text)
        GridService.DataSource = dtlService
        GridService.Columns("Type").Width = 65
        GridService.Columns("TypeName").Width = 150
        GridService.Columns("Invoice").Width = 50
        GridService.Columns("Curr").Width = 35
        GridService.Columns("Qty").Width = 30
        GridService.Columns("Amount").Width = 60
        GridService.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("Amount").DefaultCellStyle.Format = "#,##"
        GridService.Columns("RMK").Width = 260

        TinhTongService()
        cbxServiceType.Text = ""
        txtAmount.Text = 0
        txtServiceQty.Text = 1
        chkInvService.Checked = False
    End Sub

    Private Function JSON_Service() As String
        Dim JSON_Result As String = ""
        For i As Int16 = 0 To GridService.Rows.Count - 1
            If JSON_Result <> "" Then
                JSON_Result = JSON_Result & ",{" & LuuJSON("Type", GridService.Rows(i).Cells("Type").Value) & "," & LuuJSON("TypeName", GridService.Rows(i).Cells("TypeName").Value) & "," & LuuJSON("Curr", GridService.Rows(i).Cells("Curr").Value) & "," & LuuJSON("Qty", GridService.Rows(i).Cells("Qty").Value) & "," & LuuJSON("Amount", GridService.Rows(i).Cells("Amount").Value) & "," & LuuJSON("RMK", GridService.Rows(i).Cells("RMK").Value) & "}"
            Else
                JSON_Result = "{" & LuuJSON("Type", GridService.Rows(i).Cells("Type").Value) & "," & LuuJSON("TypeName", GridService.Rows(i).Cells("TypeName").Value) & "," & LuuJSON("Curr", GridService.Rows(i).Cells("Curr").Value) & "," & LuuJSON("Qty", GridService.Rows(i).Cells("Qty").Value) & "," & LuuJSON("Amount", GridService.Rows(i).Cells("Amount").Value) & "," & LuuJSON("RMK", GridService.Rows(i).Cells("RMK").Value) & "}"
            End If
        Next
        JSON_Result = "[" & JSON_Result & "]"
        Return JSON_Result
    End Function

    Private Sub LoadGridTicketing(PNRID As Integer)
        Dim dtl As DataTable = GetDataTable("Select CustName, RoutingType, CustType, Itinerary, FlightDate, ReturnDate, TicketType, PaxType, Qty, Invoice, Curr, ROE, BasefareSell, BasefareNet, Tax, FuelSurcharge, TotalServiceFee, TotalServiceCharge, TotalAmount, TKNO, PaxName, AgentComm, PersonComm, Note, (Select HoTen from tbluser where RecID=Ticketing.FstUser) FstUser, RecID, SupplierID, CustomerID, PNR, OtherServices, FstUser PIC from ticketing where status='OK' and PNRID=" & PNRID)
        bdsTicketing.DataSource = dtl
        GridTicketking.DataSource = bdsTicketing
        GridTicketking.Columns("RecID").Visible = False
        GridTicketking.Columns("SupplierID").Visible = False
        GridTicketking.Columns("OtherServices").Visible = False
        GridTicketking.Columns("CustomerID").Visible = False
        GridTicketking.Columns("PNR").Visible = False
        GridTicketking.Columns("PIC").Visible = False
        GridTicketking.Columns("RoutingType").HeaderText = "RType"
        GridTicketking.Columns("RoutingType").Width = 40
        GridTicketking.Columns("CustType").Width = 50
        GridTicketking.Columns("Itinerary").Width = 150
        GridTicketking.Columns("TicketType").Width = 60
        GridTicketking.Columns("PaxType").Width = 60
        GridTicketking.Columns("Qty").Width = 30
        GridTicketking.Columns("Invoice").Width = 50
        GridTicketking.Columns("Curr").Width = 35
        GridTicketking.Columns("ROE").Width = 50
        GridTicketking.Columns("BasefareSell").Width = 80
        GridTicketking.Columns("BasefareNet").Width = 80
        GridTicketking.Columns("Tax").Width = 75
        GridTicketking.Columns("FuelSurcharge").Width = 80
        GridTicketking.Columns("TotalServiceFee").Width = 90
        GridTicketking.Columns("TotalServiceCharge").Width = 105
        GridTicketking.Columns("TotalAmount").Width = 90
        GridTicketking.Columns("TKNO").Width = 150
        GridTicketking.Columns("PaxName").Width = 150
        GridTicketking.Columns("AgentComm").Width = 70
        GridTicketking.Columns("PersonComm").Width = 70
        GridTicketking.Columns("Note").Width = 200
        GridTicketking.Columns("RoutingType").Frozen = True
        GridTicketking.Columns("FlightDate").Width = 70
        GridTicketking.Columns("ReturnDate").Width = 70

        GridTicketking.Columns("ROE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("ROE").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("BasefareSell").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("BasefareSell").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("BasefareNet").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("BasefareNet").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("Tax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("Tax").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("FuelSurcharge").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("FuelSurcharge").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("TotalServiceFee").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("TotalServiceFee").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("TotalServiceCharge").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("TotalServiceCharge").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("TotalAmount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("TotalAmount").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("AgentComm").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("AgentComm").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("PersonComm").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("PersonComm").DefaultCellStyle.Format = "#,##"
        GridTicketking.Columns("FlightDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("FlightDate").DefaultCellStyle.Format = "ddMMMyy"
        GridTicketking.Columns("ReturnDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridTicketking.Columns("ReturnDate").DefaultCellStyle.Format = "ddMMMyy"

    End Sub

    Private Sub LoadGridPNR()
        Dim DK As String = ""
        If dtpFrom.Checked = True Then
            DK = " and p.FstUpdate between '" & Format(dtpFrom.Value, "dd-MMM-yy") & "' and '" & Format(dtpTo.Value, "dd-MMM-yy") & " 23:59'"
        End If
        Dim dtl As DataTable = GetDataTable("select p.RecID, SupplierName, PNR, CustName, Curr, Amount, PmtStatus, (Select HoTen from tbluser where RecID=p.FstUser) FstUser, p.FstUser PIC, CustID from PNR p left join Customer c on c.RecID=p.CustID left join Supplier s on s.RecID=p.SupplierID where p.status='OK' " & DK)
        bdsPNR.DataSource = dtl
        GridPNR.DataSource = bdsPNR
        GridPNR.Columns("RecID").Visible = False
        GridPNR.Columns("CustID").Visible = False
        GridPNR.Columns("PIC").Visible = False
        GridPNR.Columns("PNR").Width = 55
        GridPNR.Columns("Curr").Width = 40
        GridPNR.Columns("CustName").Width = 170
        GridPNR.Columns("SupplierName").Width = 170
        GridPNR.Columns("PmtStatus").Width = 70
        GridPNR.Columns("Amount").Width = 70
        GridPNR.Columns("PmtStatus").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridPNR.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPNR.Columns("Amount").DefaultCellStyle.Format = "#,##"
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtAgentComm.Text = 0
        txtAmount.Text = 0
        txtBasefareNet.Text = 0
        txtBasefareSell.Text = 0
        txtCustomerName.Text = ""
        txtFuelSurcharge.Text = 0
        txtItinerary.Text = ""
        txtNote.Text = ""
        txtPaxName.Text = ""
        txtPersonComm.Text = 0
        txtQuantity.Text = 0
        txtROE.Text = 1
        txtServiceQty.Text = 1
        txtServiceRMK.Text = ""
        txtTax.Text = 0
        txtTKNO.Text = ""
        txtTotalServiceCharge.Text = 0
        txtTotalServiceFee.Text = 0
        cbxCurr.Text = "VND"
        cbxCust.Text = ""
        cbxCustType.Text = ""
        cbxPaxType.Text = ""
        cbxRoutingType.Text = ""
        cbxServiceType.Text = ""
        cbxSupplier.Text = ""
        cbxTicketType.Text = "S"
        dtpFlightDate.Value = Date.Now
        dtpReturnDate.Value = Date.Now
        If chkKeepPNRCode.Checked = False Then
            txtPNR.Text = ""
        End If
        btnUpdate.Enabled = False
        btnAdd.Enabled = True
        dtlService = Nothing
        TaoGridService()
        GridService.DataSource = Nothing
    End Sub

    Private Function InsertPNR(PNR As String, SupplierID As Integer, CustID As Integer, NetAmt As Decimal, Amount As Decimal, PmtStatus As String, CustType As String, Curr As String) As Integer
        Dim strSQL As String
        strSQL = "insert PNR (PNR, SupplierID, CustID, NetAmt, Amount, PmtStatus, FstUser, CustType, Curr) values (@PNR, @SupplierID, @CustID, @NetAmt, @Amount, @PmtStatus, @FstUser, @CustType, @Curr);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@PNR", PNR),
                New SqlParameter("@SupplierID", SupplierID),
                New SqlParameter("@CustID", CustID),
                New SqlParameter("@NetAmt", NetAmt),
                New SqlParameter("@Amount", Amount),
                New SqlParameter("@PmtStatus", PmtStatus),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@CustType", CustType),
                New SqlParameter("@Curr", Curr)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("PNR", RecID)
        Return RecID
    End Function

    Private Sub InsertTicketing(PNRID As Integer, SupplierID As Integer, CustomerID As Integer, CustName As String, PNR As String, RoutingType As String, CustType As String, Itinerary As String, TicketType As String, PaxType As String, Qty As Int16, Invoice As Boolean, Curr As String, ROE As Int16, BasefareSell As Decimal, BasefareNet As Decimal, Tax As Decimal, FuelSurcharge As Decimal, OtherServices As String, TotalServiceFee As Decimal, TotalServiceCharge As Decimal, TKNO As String, PaxName As String, AgentComm As Decimal, PersonComm As Decimal, Note As String, FlightDate As Date, ReturnDate As Date)
        Dim strSQL As String
        strSQL = "insert Ticketing (PNRID, SupplierID, CustomerID, CustName, PNR, RoutingType, CustType, Itinerary, TicketType, PaxType, Qty, Invoice, Curr, ROE, BasefareSell, BasefareNet, Tax, FuelSurcharge, OtherServices, TotalServiceFee, TotalServiceCharge, TKNO, PaxName, AgentComm, PersonComm, Note, FstUser, FlightDate, ReturnDate) values (@PNRID, @SupplierID, @CustomerID, @CustName, @PNR, @RoutingType, @CustType, @Itinerary, @TicketType, @PaxType, @Qty, @Invoice, @Curr, @ROE, @BasefareSell, @BasefareNet, @Tax, @FuelSurcharge, @OtherServices, @TotalServiceFee, @TotalServiceCharge, @TKNO, @PaxName, @AgentComm, @PersonComm, @Note, @FstUser, @FlightDate, @ReturnDate);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@PNRID", PNRID),
                New SqlParameter("@SupplierID", SupplierID),
                New SqlParameter("@CustomerID", CustomerID),
                New SqlParameter("@CustName", CustName),
                New SqlParameter("@PNR", PNR),
                New SqlParameter("@RoutingType", RoutingType),
                New SqlParameter("@CustType", CustType),
                New SqlParameter("@Itinerary", Itinerary),
                New SqlParameter("@TicketType", TicketType),
                New SqlParameter("@PaxType", PaxType),
                New SqlParameter("@Qty", Qty),
                New SqlParameter("@Invoice", Invoice),
                New SqlParameter("@Curr", Curr),
                New SqlParameter("@ROE", ROE),
                New SqlParameter("@BasefareSell", BasefareSell),
                New SqlParameter("@BasefareNet", BasefareNet),
                New SqlParameter("@Tax", Tax),
                New SqlParameter("@FuelSurcharge", FuelSurcharge),
                New SqlParameter("@OtherServices", OtherServices),
                New SqlParameter("@TotalServiceFee", TotalServiceFee),
                New SqlParameter("@TotalServiceCharge", TotalServiceCharge),
                New SqlParameter("@TKNO", TKNO),
                New SqlParameter("@PaxName", PaxName),
                New SqlParameter("@AgentComm", AgentComm),
                New SqlParameter("@PersonComm", PersonComm),
                New SqlParameter("@Note", Note),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@FlightDate", FlightDate),
                New SqlParameter("@ReturnDate", ReturnDate)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("Ticketing", RecID)
    End Sub

    Private Sub UpdateTicketing(SupplierID As Integer, CustomerID As Integer, CustName As String, PNR As String, RoutingType As String, CustType As String, Itinerary As String, TicketType As String, PaxType As String, Qty As Int16, Invoice As Boolean, Curr As String, ROE As Int16, BasefareSell As Decimal, BasefareNet As Decimal, Tax As Decimal, FuelSurcharge As Decimal, OtherServices As String, TotalServiceFee As Decimal, TotalServiceCharge As Decimal, TKNO As String, PaxName As String, AgentComm As Decimal, PersonComm As Decimal, Note As String, RecID As Integer, FlightDate As Date, ReturnDate As Date)
        Dim strSQL As String
        strSQL = "Update Ticketing set SupplierID=@SupplierID, CustomerID=@CustomerID, CustName=@CustName, PNR=@PNR, RoutingType=@RoutingType, CustType=@CustType, Itinerary=@Itinerary, TicketType=@TicketType, PaxType=@PaxType, Qty=@Qty, Invoice=@Invoice, Curr=@Curr, ROE=@ROE, BasefareSell=@BasefareSell, BasefareNet=@BasefareNet, Tax=@Tax, FuelSurcharge=@FuelSurcharge, OtherServices=@OtherServices, TotalServiceFee=@TotalServiceFee, TotalServiceCharge=@TotalServiceFee, TKNO=@TKNO, PaxName=@PaxName, AgentComm=@AgentComm, PersonComm=@PersonComm, Note=@Note, FlightDate=@FlightDate, ReturnDate=@ReturnDate where RecID=@RecID"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@SupplierID", SupplierID),
                New SqlParameter("@CustomerID", CustomerID),
                New SqlParameter("@CustName", CustName),
                New SqlParameter("@PNR", PNR),
                New SqlParameter("@RoutingType", RoutingType),
                New SqlParameter("@CustType", CustType),
                New SqlParameter("@Itinerary", Itinerary),
                New SqlParameter("@TicketType", TicketType),
                New SqlParameter("@PaxType", PaxType),
                New SqlParameter("@Qty", Qty),
                New SqlParameter("@Invoice", Invoice),
                New SqlParameter("@Curr", Curr),
                New SqlParameter("@ROE", ROE),
                New SqlParameter("@BasefareSell", BasefareSell),
                New SqlParameter("@BasefareNet", BasefareNet),
                New SqlParameter("@Tax", Tax),
                New SqlParameter("@FuelSurcharge", FuelSurcharge),
                New SqlParameter("@OtherServices", OtherServices),
                New SqlParameter("@TotalServiceFee", TotalServiceFee),
                New SqlParameter("@TotalServiceCharge", TotalServiceCharge),
                New SqlParameter("@TKNO", TKNO),
                New SqlParameter("@PaxName", PaxName),
                New SqlParameter("@AgentComm", AgentComm),
                New SqlParameter("@PersonComm", PersonComm),
                New SqlParameter("@Note", Note),
                New SqlParameter("@FstUser", myStaff.UserID),
                New SqlParameter("@RecID", RecID),
                New SqlParameter("@ReturnDate", ReturnDate),
                New SqlParameter("@FlightDate", FlightDate)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("Ticketing", RecID)
    End Sub

    Private Function TinhTongTienPNR(PNR As String, SupplierID As Integer) As Decimal
        Dim Result As Decimal = 0
        Result = ExeScalar("Select isnull(sum(Qty*(BasefareSell+Tax+FuelSurcharge)+TotalServiceFee+TotalServiceCharge),0) from Ticketing where Status='OK' and SupplierID=" & SupplierID & " and PNR='" & PNR & "'")
        Return Result
    End Function

    Private Function TinhNetPNR(PNR As String, SupplierID As Integer) As Decimal
        Dim Result As Decimal = 0
        Result = ExeScalar("Select isnull(sum(Qty*(BasefareNet+Tax+FuelSurcharge)),0)+isnull(sum(TotalServiceFee),0) from Ticketing where Status='OK' and SupplierID=" & SupplierID & " and PNR='" & PNR & "'")
        Return Result
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbxSupplier.SelectedValue = 0 Then
            MsgBox("Chưa chọn Supplier!")
            Exit Sub
        End If
        If txtQuantity.Text = 0 Then
            MsgBox("Chưa nhập số lượng!")
            Exit Sub
        End If
        If lblBalanceNumber.Text <> "-" And lblBalanceNumber.Text <> "0" Then
            If CDbl(lblBalanceNumber.Text) < (CDbl(txtBasefareNet.Text) + CDbl(txtTax.Text) + CDbl(txtFuelSurcharge.Text) + CDbl(txtTotalServiceFee.Text)) * CInt(txtQuantity.Text) Then
                MsgBox("Số dư tài khoản không đủ để xuất vé!")
                Exit Sub
            End If
        ElseIf lblBalanceNumber.Text = "-" Or lblBalanceNumber.Text = "0" Then
            MsgBox("Số dư tài khoản không đủ để xuất vé!")
            Exit Sub
        End If
        Dim PNRID As Integer
        If txtPNR.Text <> "" Then
            If ExeScalar("Select count(*) from PNR where PNR='" & txtPNR.Text & "' and SupplierID=" & cbxSupplier.SelectedValue & " and status='OK'") > 0 Then
                PNRID = dtrPNR("RecID")
            Else
                PNRID = InsertPNR(txtPNR.Text, cbxSupplier.SelectedValue, cbxCust.SelectedValue, 0, 0, "-", cbxCustType.Text, cbxCurr.Text)
            End If
        Else
            PNRID = InsertPNR(txtPNR.Text, cbxSupplier.SelectedValue, cbxCust.SelectedValue, 0, 0, "-", cbxCustType.Text, cbxCurr.Text)
        End If

        InsertTicketing(PNRID, cbxSupplier.SelectedValue, cbxCust.SelectedValue, txtCustomerName.Text, txtPNR.Text, cbxRoutingType.Text, cbxCustType.Text, txtItinerary.Text, cbxTicketType.Text, cbxPaxType.Text, txtQuantity.Text, chkInvoice.Checked, cbxCurr.Text, txtROE.Text, txtBasefareSell.Text, txtBasefareNet.Text, txtTax.Text, txtFuelSurcharge.Text, If(JSON_Service.Length > 2, JSON_Service(), ""), txtTotalServiceFee.Text, txtTotalServiceCharge.Text, txtTKNO.Text, txtPaxName.Text, txtAgentComm.Text, txtPersonComm.Text, txtNote.Text, dtpFlightDate.Value, dtpReturnDate.Value)
        ExeNonequery("Update PNR set Amount=" & TinhTongTienPNR(txtPNR.Text, cbxSupplier.SelectedValue) & ", NetAmt=" & TinhNetPNR(txtPNR.Text, cbxSupplier.SelectedValue) & " where RecID=" & PNRID)
        LoadGridPNR()
        btnNew_Click(sender, e)
    End Sub

    Private Sub cbxCurr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCurr.SelectedIndexChanged, cbxServiceCurr.SelectedIndexChanged
        If cbxCurr.Text = "VND" Then
            txtROE.Text = 1
        Else
            txtROE.Text = 0
        End If
    End Sub

    Private Sub bdsPNR_CurrentChanged(sender As Object, e As EventArgs) Handles bdsPNR.CurrentChanged
        If bdsPNR.Count > 0 Then
            dtrPNR = bdsPNR.Current
            LoadGridTicketing(dtrPNR("RecID"))
            btnNew_Click(sender, e)
            If dtrPNR("PIC") = myStaff.UserID Then
                btnDeletePNR.Enabled = True
            Else
                btnDeletePNR.Enabled = False
            End If
        Else
                GridService.DataSource = Nothing
            GridTicketking.DataSource = Nothing
        End If
    End Sub

    Private Sub bdsTicketing_CurrentChanged(sender As Object, e As EventArgs) Handles bdsTicketing.CurrentChanged
        If bdsTicketing.Count > 0 Then
            dtrTicketing = bdsTicketing.Current
            txtAgentComm.Text = FormatDigit(dtrTicketing("AgentComm"))
            txtBasefareNet.Text = FormatDigit(dtrTicketing("BasefareNet"))
            txtBasefareSell.Text = FormatDigit(dtrTicketing("BasefareSell"))
            txtCustomerName.Text = dtrTicketing("CustName")
            txtFuelSurcharge.Text = FormatDigit(dtrTicketing("FuelSurcharge"))
            txtItinerary.Text = dtrTicketing("Itinerary")
            txtNote.Text = dtrTicketing("Note")
            txtPaxName.Text = dtrTicketing("PaxName")
            txtPersonComm.Text = FormatDigit(dtrTicketing("PersonComm"))
            txtPNR.Text = dtrTicketing("PNR")
            txtQuantity.Text = FormatDigit(dtrTicketing("Qty"))
            txtROE.Text = FormatDigit(dtrTicketing("ROE"))
            txtTotalServiceCharge.Text = FormatDigit(dtrTicketing("TotalServiceCharge"))
            txtTotalServiceFee.Text = FormatDigit(dtrTicketing("TotalServiceFee"))
            cbxCurr.Text = dtrTicketing("Curr")
            cbxCust.SelectedValue = dtrTicketing("CustomerID")
            cbxCustType.Text = dtrTicketing("CustType")
            cbxPaxType.Text = dtrTicketing("PaxType")
            cbxRoutingType.Text = dtrTicketing("RoutingType")
            cbxSupplier.SelectedValue = dtrTicketing("SupplierID")
            cbxTicketType.SelectedValue = dtrTicketing("TicketType")
            LoadGridService(dtrTicketing("OtherServices"))
            txtTKNO.Text = dtrTicketing("TKNO")
            btnUpdate.Enabled = True
            btnAdd.Enabled = False
            If dtrTicketing("PIC") = myStaff.UserID Then
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If
        Else
            btnNew_Click(sender, e)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cbxSupplier.SelectedValue = 0 Then
            MsgBox("Chưa chọn Supplier!")
            Exit Sub
        End If
        If txtQuantity.Text = 0 Then
            MsgBox("Chưa nhập số lượng!")
            Exit Sub
        End If
        If lblBalanceNumber.Text <> "-" And lblBalanceNumber.Text <> "0" Then
            If CDbl(lblBalanceNumber.Text) < (CDbl(txtBasefareNet.Text) + CDbl(txtTax.Text) + CDbl(txtFuelSurcharge.Text) + CDbl(txtTotalServiceFee.Text)) * CInt(txtQuantity.Text) Then
                MsgBox("Số dư tài khoản không đủ để xuất vé!")
                Exit Sub
            End If
        ElseIf lblBalanceNumber.Text = "-" Or lblBalanceNumber.Text = "0" Then
            MsgBox("Số dư tài khoản không đủ để xuất vé!")
            Exit Sub
        End If
        UpdateTicketing(cbxSupplier.SelectedValue, cbxCust.SelectedValue, txtCustomerName.Text, txtPNR.Text, cbxRoutingType.Text, cbxCustType.Text, txtItinerary.Text, cbxTicketType.Text, cbxPaxType.Text, txtQuantity.Text, chkInvoice.Checked, cbxCurr.Text, txtROE.Text, txtBasefareSell.Text, txtBasefareNet.Text, txtTax.Text, txtFuelSurcharge.Text, If(JSON_Service.Length > 2, JSON_Service(), ""), txtTotalServiceFee.Text, txtTotalServiceCharge.Text, txtTKNO.Text, txtPaxName.Text, txtAgentComm.Text, txtPersonComm.Text, txtNote.Text, dtrTicketing("RecID"), dtpFlightDate.Value, dtpReturnDate.Value)
        ExeNonequery("Update PNR set Amount=" & TinhTongTienPNR(txtPNR.Text, cbxSupplier.SelectedValue) & ", SupplierID=" & cbxSupplier.SelectedValue & ", CustID=" & cbxCust.SelectedValue & ", Curr='" & cbxCurr.Text & "' where RecID=" & dtrPNR("RecID"))
        LoadGridPNR()
        btnNew_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If bdsTicketing.Count = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", dtrTicketing("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update Ticketing set Status='XX' where recID=@RecID", Para)
            ExeNonequery("Update PNR set Amount=" & TinhTongTienPNR(txtPNR.Text, cbxSupplier.SelectedValue) & ", NetAmt=" & TinhNetPNR(txtPNR.Text, cbxSupplier.SelectedValue) & " where RecID=" & dtrPNR("RecID"))
            GhiLog("Ticketing", dtrTicketing("RecID"))
        End If
        LoadGridPNR()
        btnNew_Click(sender, e)
    End Sub

    Private Sub GridTicketking_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridTicketking.DataBindingComplete
        GridTicketking.ClearSelection()
    End Sub
    Private Sub GridService_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridService.DataBindingComplete
        GridService.ClearSelection()
    End Sub

    Private Sub btnDeletePNR_Click(sender As Object, e As EventArgs) Handles btnDeletePNR.Click
        If bdsPNR.Count = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        If dtrPNR("PmtStatus") <> "-" Then
            MsgBox("PNR đã có thanh toán của khách hàng, không được xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", dtrPNR("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng PNR này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update PNR set Status='XX' where recID=@RecID", Para)
            ExeNonequery("update Ticketing set Status='XX' where PNRID=@RecID", Para)
            GhiLog("PNR", dtrPNR("RecID"))
        End If
        LoadGridPNR()
        btnNew_Click(sender, e)
    End Sub

    Private Sub GridTicketking_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTicketking.CellClick
        bdsTicketing_CurrentChanged(sender, e)
    End Sub

    Private Sub GridService_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridService.CellClick
        If GridService.CurrentCell.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng này?", "Beyond Application", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                For Each row As DataGridViewRow In GridService.SelectedRows
                    GridService.Rows.Remove(row)
                Next
                dtlService = TryCast(GridService.DataSource, DataTable)
                TinhTongService()
            End If
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        ofdFile.Filter = "Excel file (xls,xlsx)|*.xls;*.xlsx"
        If (ofdFile.ShowDialog = DialogResult.OK) Then
            Cursor.Current = Cursors.WaitCursor
            Dim AppXls As Microsoft.Office.Interop.Excel.Application, WkBook As Microsoft.Office.Interop.Excel.Workbook, WkSheet As Microsoft.Office.Interop.Excel.Worksheet
            On Error Resume Next
            AppXls = CreateObject("Excel.Application")
            On Error GoTo 0
            WkBook = AppXls.Workbooks.Open(ofdFile.FileName, Editable:=True)
            WkSheet = WkBook.Worksheets("Sheet1")
            Dim i As Int16 = 7
            'lấy supplier bằng 3 để tượng trưng cho hãng import
            Do While WkSheet.Range("A" & i).Text <> ""
                If ExeScalar("Select count(*) from Ticketing where status='OK' and TKNO like '%" & WkSheet.Range("C" & i).Text.ToString.Trim & "%'") = 0 Then
                    Dim PNRID As Integer
                    If ExeScalar("Select count(*) from PNR where status='OK' and supplierid=3 and PNR like '%" & WkSheet.Range("K" & i).Text.ToString.Trim & "%'") = 0 Then
                        PNRID = InsertPNR(WkSheet.Range("K" & i).Text.ToString.Trim, 3, 0, 0, 0, "-", cbxCustType.Text, cbxCurr.Text)
                    Else
                        PNRID = ExeScalar("Select RecID from PNR where PNR='" & WkSheet.Range("K" & i).Text.ToString.Trim & "' and supplierid=3 and status='OK'")
                    End If
                    InsertTicketing(PNRID, 3, 0, "", WkSheet.Range("K" & i).Text.ToString.Trim, "", "FIT", "", "S", "", 1, False, "VND", 1, 0, WkSheet.Range("D" & i).Text, WkSheet.Range("E" & i).Text, 0, "", 0, 0, WkSheet.Range("C" & i).Text, WkSheet.Range("L" & i).Text, 0, 0, "", Date.Now, Date.Now)
                    ExeNonequery("Update PNR set Amount=" & TinhTongTienPNR(txtPNR.Text, cbxSupplier.SelectedValue) & " where RecID=" & PNRID)
                End If
                i = i + 1
            Loop
CloseXLS:
            WkBook.Close(SaveChanges:=False)
            AppXls.Quit()
            releaseObject(AppXls)
            releaseObject(WkBook)
            AppXls = Nothing
            On Error GoTo 0
            Cursor.Current = Cursors.Default
            LoadGridPNR()
            btnNew_Click(sender, e)
        End If

    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged
        If RunPageLoad = True Then
            LoadGridPNR()
        End If
    End Sub

    Private Sub txtSearchPNR_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPNR.TextChanged
        bdsPNR.Filter = "PNR like '%" & txtSearchPNR.Text & "%'"
    End Sub

    Private Sub cbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        If RunPageLoad = True Then
            BuildControl("Select Val, Val2 from misc where cat='OTHERSERVICE' and Val='" & cbxType.Text & "' and Status='OK' order by val", "Val", "Val2", cbxServiceType)
        End If
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_CustPayment") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_CustPayment("PNR", dtrPNR("RecID"), dtrPNR("CustID"), dtrPNR("PNR"))
            f.MdiParent = FrmMain
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub dtpFlightDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpFlightDate.ValueChanged
        dtpReturnDate.Value = dtpFlightDate.Value
    End Sub

    Private Sub chkInvidual_CheckedChanged(sender As Object, e As EventArgs) Handles chkInvidual.CheckedChanged
        If chkInvidual.Checked = True Then
            bdsPNR.Filter = "PIC=" & myStaff.UserID
        End If
    End Sub
End Class