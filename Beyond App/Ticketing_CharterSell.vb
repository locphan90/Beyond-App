
Imports System.Data.SqlClient

Public Class Ticketing_CharterSell
    Dim CharterID As Integer
    Dim dtlLand As DataTable
    Dim dtlService As DataTable
    Dim RunPageLoad As Boolean = False
    Dim dtr As DataRowView
    Sub New(pCharterID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        CharterID = pCharterID
    End Sub

    Private Sub LockControl()
        Dim dtl As DataTable = GetDataTable("Select * from CharterCode where RecID=" & CharterID)
        If CDate(dtl.Rows(0)("DeptDate")) < Date.Now Then
            btnAdd.Enabled = False
            btnNew.Enabled = False
            btnDelete.Enabled = False
            btnUpdate.Enabled = False
        End If
    End Sub

    Private Sub Ticketing_ChaterSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunPageLoad = True
        TaoGridLand()
        TaoGridService()
        LoadGridCharterSell()
        LoadRefInfo()
        btnNew_Click(sender, e)
        LockControl()

    End Sub

    Private Sub TinhAirAmt()
        If RunPageLoad = True Then
            txtTtlAmtAir.Text = FormatDigit(txtQtyC.Text * txtAmtC.Text + txtQtyY.Text * txtAmtY.Text)
        End If
    End Sub

    Private Sub LoadTotalAmt()
        TinhAirAmt()
        TinhLandAmt()
        TinhServiceAmt()
        txtTtlAmt.Text = FormatDigit(CDbl(txtTtlAmtAir.Text) + CDbl(txtTtlAmtLand.Text) + CDbl(txtTtlAmtService.Text))
    End Sub

    Private Sub LoadRefInfo()
        Dim dtl As DataTable = GetDataTable("select Qtyc-isnull((select sum(QtyC) from CharterSell where CharterID=c.RecID and Status='OK'),0) QtyC_ConLai, Qtyc-isnull((select sum(QtyC) from CharterSell where CharterID=c.RecID and Status='OK'),0) QtyY_ConLai, RefPriceC, RefPriceY from CharterCode c where RecID=" & CharterID)
        lblQtyC.Text = dtl.Rows(0)("QtyC_ConLai")
        lblQtyY.Text = dtl.Rows(0)("QtyC_ConLai")
        lblRefAmtC.Text = dtl.Rows(0)("RefPriceC")
        lblRefAmtY.Text = dtl.Rows(0)("RefPriceY")
        Dim dtlLand As DataTable = GetDataTable("Select LandDetail from CharterSell where Status='OK' and LandDetail<>'' and charterID=" & CharterID)
        Dim strSQL As String = ""
        If dtlLand.Rows.Count > 0 Then
            For i As Int16 = 0 To dtlLand.Rows.Count - 1
                If i = 0 Then
                    strSQL = "SELECT Qty, Type FROM OPENJSON(N'" & dtlLand.Rows(i)("LandDetail") & "') with (Type VARCHAR(10) N'$.Type', Qty int '$.Qty')"
                Else
                    strSQL = strSQL & "union all SELECT Qty, Type FROM OPENJSON(N'" & dtlLand.Rows(i)("LandDetail") & "') with (Type VARCHAR(10) N'$.Type', Qty int '$.Qty')"
                End If
            Next
            strSQL = "select T1.Type, SL Qty_Buy, Qty Qty_Sell, SL-Qty Qty_Remaining from (select type, sum(qty) SL from CharterLand where status='OK' and CharterID=" & CharterID & " group by Type) T1 left join  (select sum(qty) Qty, type from (" & strSQL & ") T group by Type) T2 on t1.Type=t2.type"
        Else
            strSQL = "Select Type, sum(Qty) Qty_Buy, 0 Qty_Sell, sum(Qty) Qty_Remaining from CharterLand where Status='OK' and charterID=" & CharterID & "  group by Type"
        End If

        Dim dtlRefLand As DataTable = GetDataTable(strSQL)
        GridRefLand.DataSource = dtlRefLand
        GridRefLand.Columns("Type").Width = 65
        GridRefLand.Columns("Qty_Buy").Width = 60
        GridRefLand.Columns("Qty_Sell").Width = 60
        GridRefLand.Columns("Qty_Remaining").Width = 80
        GridRefLand.Columns("Qty_Buy").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridRefLand.Columns("Qty_Sell").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridRefLand.Columns("Qty_Remaining").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridRefLand.Columns("Qty_Buy").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridRefLand.Columns("Qty_Sell").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridRefLand.Columns("Qty_Remaining").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub GridRefLand_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridRefLand.DataBindingComplete
        GridRefLand.ClearSelection()
    End Sub

    Private Sub cbxLandType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLandType.SelectedIndexChanged
        If RunPageLoad = True Then
            Dim BusList As String = ExeScalar("select isnull(STRING_AGG(bus,''),'') from CharterLand where Type='" & cbxLandType.Text & "' and CharterID=" & CharterID & " and status='OK'")
            BuildControl("SELECT distinct value FROM STRING_SPLIT('" & BusList & "', '_') order by value", "value", "value", cbxBus)
            Dim Result As Decimal = 0
            Result = ExeScalar("Select top 1 RefPrice from CharterLand where Status='OK' and CharterID=" & CharterID & " and Type='" & cbxLandType.Text & "'")
            txtLandAmt.Text = FormatDigit(Result)
        End If
    End Sub

    Private Sub cbxServiceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServiceType.SelectedIndexChanged
        If RunPageLoad = True Then
            BuildControl("Select Val2 from misc where cat='CHARTERSVC' and Val='" & cbxServiceType.Text & "' and status='OK' order by val, val2", "Val2", "Val2", cbxServiceName)
        End If
    End Sub

    Private Sub TaoGridLand()
        dtlLand = New DataTable
        dtlLand.Columns.Add("Type", GetType(String))
        dtlLand.Columns.Add("Qty", GetType(Integer))
        dtlLand.Columns.Add("LandAmt", GetType(Decimal))
        dtlLand.Columns.Add("Bus", GetType(String))
        dtlLand.Columns.Add("BusAmt", GetType(Decimal))
        dtlLand.Columns.Add("RMK", GetType(String))
    End Sub

    Private Sub TinhLandAmt()
        Dim TongAmt As Double = 0
        For i As Int16 = 0 To GridLand.RowCount - 1
            TongAmt = TongAmt + GridLand.Rows(i).Cells("Qty").Value * GridLand.Rows(i).Cells("LandAmt").Value + GridLand.Rows(i).Cells("BusAmt").Value
        Next
        txtTtlAmtLand.Text = FormatDigit(TongAmt)
    End Sub

    Private Sub btnLandAdd_Click(sender As Object, e As EventArgs) Handles btnLandAdd.Click
        'If txtLandAmt.Text = "0" Then
        '    MsgBox("Chưa nhập số tiền!")
        '    Exit Sub
        'End If
        If cbxLandType.Text = "" Then
            MsgBox("Chưa chọn land!")
            Exit Sub
        End If
        dtlLand.Rows.Add(cbxLandType.Text, txtLandQty.Text, txtLandAmt.Text, cbxBus.Text, txtBusAmt.Text, txtLandRMK.Text)
        GridLand.DataSource = dtlLand
        GridLand.Columns("Type").Width = 65
        GridLand.Columns("Qty").Width = 30
        GridLand.Columns("Bus").Width = 30
        GridLand.Columns("LandAmt").Width = 60
        GridLand.Columns("LandAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridLand.Columns("LandAmt").DefaultCellStyle.Format = "#,##"
        GridLand.Columns("BusAmt").Width = 60
        GridLand.Columns("BusAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridLand.Columns("BusAmt").DefaultCellStyle.Format = "#,##"
        GridLand.Columns("RMK").Width = 260
        LoadTotalAmt()
        txtLandQty.Text = 1
        txtLandAmt.Text = 0
        cbxBus.Text = ""
        txtBusAmt.Text = 0
        txtLandRMK.Text = ""
    End Sub

    Private Sub LoadGridLand(JSON As String)
        If JSON.Length > 0 Then
            dtlLand = GetDataTable("SELECT * FROM OPENJSON(N'" & JSON & "') with (Type VARCHAR(10) N'$.Type', Qty int '$.Qty',  LandAmt decimal '$.LandAmt', Bus varchar(2) '$.Bus', BusAmt decimal '$.BusAmt', RMK NVARCHAR(500) '$.RMK')")
            GridLand.DataSource = dtlLand
            GridLand.Columns("Type").Width = 65
            GridLand.Columns("Qty").Width = 30
            GridLand.Columns("Bus").Width = 30
            GridLand.Columns("LandAmt").Width = 60
            GridLand.Columns("LandAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            GridLand.Columns("LandAmt").DefaultCellStyle.Format = "#,##"
            GridLand.Columns("BusAmt").Width = 60
            GridLand.Columns("BusAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            GridLand.Columns("BusAmt").DefaultCellStyle.Format = "#,##"
            GridLand.Columns("RMK").Width = 260
        End If
    End Sub

    Private Sub GridLand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridLand.CellClick
        If GridLand.CurrentCell.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng này?", "Beyond Application", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                For Each row As DataGridViewRow In GridLand.SelectedRows
                    GridLand.Rows.Remove(row)
                Next
                dtlLand = TryCast(GridLand.DataSource, DataTable)
                LoadTotalAmt()
            End If
        End If
    End Sub

    Private Function JSON_Land() As String
        Dim JSON_Result As String = ""
        For i As Int16 = 0 To GridLand.Rows.Count - 1
            If JSON_Result <> "" Then
                JSON_Result = JSON_Result & ",{" & LuuJSON("Type", GridLand.Rows(i).Cells("Type").Value) & "," & LuuJSON("Qty", GridLand.Rows(i).Cells("Qty").Value) & "," & LuuJSON("LandAmt", GridLand.Rows(i).Cells("LandAmt").Value) & "," & LuuJSON("Bus", GridLand.Rows(i).Cells("Bus").Value) & "," & LuuJSON("BusAmt", GridLand.Rows(i).Cells("BusAmt").Value) & "," & LuuJSON("RMK", GridLand.Rows(i).Cells("RMK").Value) & "}"
            Else
                JSON_Result = "{" & LuuJSON("Type", GridLand.Rows(i).Cells("Type").Value) & "," & LuuJSON("Qty", GridLand.Rows(i).Cells("Qty").Value) & "," & LuuJSON("LandAmt", GridLand.Rows(i).Cells("LandAmt").Value) & "," & LuuJSON("Bus", GridLand.Rows(i).Cells("Bus").Value) & "," & LuuJSON("BusAmt", GridLand.Rows(i).Cells("BusAmt").Value) & "," & LuuJSON("RMK", GridLand.Rows(i).Cells("RMK").Value) & "}"
            End If
        Next
        JSON_Result = "[" & JSON_Result & "]"
        Return JSON_Result
    End Function

    Private Sub GridLand_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridLand.DataBindingComplete
        GridLand.ClearSelection()
    End Sub

    Private Sub TaoGridService()
        dtlService = New DataTable
        dtlService.Columns.Add("Type", GetType(String))
        dtlService.Columns.Add("Name", GetType(String))
        dtlService.Columns.Add("Qty", GetType(Integer))
        dtlService.Columns.Add("Amount", GetType(Decimal))
        dtlService.Columns.Add("RMK", GetType(String))
    End Sub

    Private Sub TinhServiceAmt()
        Dim TongAmt As Double = 0
        For i As Int16 = 0 To GridService.RowCount - 1
            TongAmt = TongAmt + GridService.Rows(i).Cells("Qty").Value * GridService.Rows(i).Cells("Amount").Value
        Next
        txtTtlAmtService.Text = FormatDigit(TongAmt)
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        If cbxServiceType.Text = "" Then
            MsgBox("Chưa chọn loại!")
            Exit Sub
        End If
        If cbxServiceName.Text = "" Then
            MsgBox("Chưa chọn tên dịch vụ, phụ phí!")
            Exit Sub
        End If
        If txtServiceQty.Text = 0 Then
            MsgBox("Chưa nhập số lượng!")
            Exit Sub
        End If
        If txtServiceAmount.Text = 0 Then
            MsgBox("Chưa nhập số tiền!")
            Exit Sub
        End If
        dtlService.Rows.Add(cbxServiceType.Text, cbxServiceName.Text, txtServiceQty.Text, txtServiceAmount.Text, txtServiceRMK.Text)
        GridService.DataSource = dtlService
        GridService.Columns("Type").Width = 65
        GridService.Columns("Name").Width = 150
        GridService.Columns("Qty").Width = 30
        GridService.Columns("Amount").Width = 60
        GridService.Columns("Qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("Qty").DefaultCellStyle.Format = "#,##"
        GridService.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("Amount").DefaultCellStyle.Format = "#,##"
        GridService.Columns("RMK").Width = 260
        LoadTotalAmt()
        cbxServiceName.Text = ""
        txtServiceQty.Text = 1
        txtServiceAmount.Text = 0
        txtServiceRMK.Text = ""
    End Sub

    Private Sub LoadGridService(JSON As String)
        If JSON.Length > 0 Then
            dtlService = GetDataTable("SELECT * FROM OPENJSON(N'" & JSON & "') with (Type VARCHAR(10) N'$.Type', Name NVARCHAR(100) N'$.Name', Qty int '$.Qty',  Amount decimal '$.Amount', RMK NVARCHAR(500) '$.RMK')")
            GridService.DataSource = dtlService
            GridService.Columns("Type").Width = 65
            GridService.Columns("Name").Width = 150
            GridService.Columns("Qty").Width = 30
            GridService.Columns("Amount").Width = 60
            GridService.Columns("Qty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            GridService.Columns("Qty").DefaultCellStyle.Format = "#,##"
            GridService.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            GridService.Columns("Amount").DefaultCellStyle.Format = "#,##"
            GridService.Columns("RMK").Width = 260
        End If
    End Sub

    Private Sub GridService_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridService.CellClick
        If GridService.CurrentCell.ColumnIndex = 0 Then
            Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng này?", "Beyond Application", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                For Each row As DataGridViewRow In GridService.SelectedRows
                    GridService.Rows.Remove(row)
                Next
                dtlLand = TryCast(GridService.DataSource, DataTable)

                LoadTotalAmt()
            End If
        End If
    End Sub

    Private Function JSON_Service() As String
        Dim JSON_Result As String = ""
        For i As Int16 = 0 To GridService.Rows.Count - 1
            If JSON_Result <> "" Then
                JSON_Result = JSON_Result & ",{" & LuuJSON("Type", GridService.Rows(i).Cells("Type").Value) & "," & LuuJSON("Name", GridService.Rows(i).Cells("Name").Value) & "," & LuuJSON("Qty", GridService.Rows(i).Cells("Qty").Value) & "," & LuuJSON("Amount", GridService.Rows(i).Cells("Amount").Value) & "," & LuuJSON("RMK", GridService.Rows(i).Cells("RMK").Value) & "}"
            Else
                JSON_Result = "{" & LuuJSON("Type", GridService.Rows(i).Cells("Type").Value) & "," & LuuJSON("Name", GridService.Rows(i).Cells("Name").Value) & "," & LuuJSON("Qty", GridService.Rows(i).Cells("Qty").Value) & "," & LuuJSON("Amount", GridService.Rows(i).Cells("Amount").Value) & "," & LuuJSON("RMK", GridService.Rows(i).Cells("RMK").Value) & "}"
            End If
        Next
        JSON_Result = "[" & JSON_Result & "]"
        Return JSON_Result
    End Function

    Private Sub GridService_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridService.DataBindingComplete
        GridService.ClearSelection()
    End Sub

    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLandQty.KeyPress, txtLandAmt.KeyPress, txtBusAmt.KeyPress, txtServiceQty.KeyPress, txtServiceAmount.KeyPress, txtAmtC.KeyPress, txtAmtY.KeyPress, txtQtyC.KeyPress, txtQtyY.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtLandQty.TextChanged, txtLandAmt.TextChanged, txtBusAmt.TextChanged, txtServiceQty.TextChanged, txtServiceAmount.TextChanged, txtAmtC.TextChanged, txtAmtY.TextChanged, txtQtyC.TextChanged, txtQtyY.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
                If RunPageLoad = True Then
                    LoadTotalAmt()
                End If
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtLandQty.Leave, txtLandAmt.Leave, txtBusAmt.Leave, txtServiceAmount.Leave, txtServiceQty.Leave, txtAmtC.Leave, txtAmtY.Leave, txtQtyC.Leave, txtQtyY.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtLandQty.GotFocus, txtLandAmt.GotFocus, txtBusAmt.GotFocus, txtServiceQty.GotFocus, txtServiceAmount.GotFocus, txtAmtC.GotFocus, txtAmtY.GotFocus, txtQtyC.GotFocus, txtQtyY.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub InsertCharterSell(CharterID As Integer, CustName As String, Phone As String, LandDetail As String, LandAmt As Double, QtyC As Int16, AmtC As Double, QtyY As Int16, AmtY As Double, OtherAmt As Double, OtherDetail As String, PaxInfo As String, FstUser As Integer, PNR As String)
        Dim strSQL As String
        strSQL = "Insert CharterSell (CharterID, CustName, Phone, LandDetail, LandAmt, QtyC, AmtC, QtyY, AmtY, OtherAmt, OtherDetail, PaxInfo, FstUser, PNR) values (@CharterID, @CustName, @Phone, @LandDetail, @LandAmt, @QtyC, @AmtC, @QtyY, @AmtY, @OtherAmt, @OtherDetail, @PaxInfo, @FstUser, @PNR);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@CharterID", CharterID),
                New SqlParameter("@CustName", CustName),
                New SqlParameter("@Phone", Phone),
                New SqlParameter("@LandDetail", LandDetail),
                New SqlParameter("@LandAmt", LandAmt),
                New SqlParameter("@QtyC", QtyC),
                New SqlParameter("@AmtC", AmtC),
                New SqlParameter("@QtyY", QtyY),
                New SqlParameter("@AmtY", AmtY),
                New SqlParameter("@OtherAmt", OtherAmt),
                New SqlParameter("@OtherDetail", OtherDetail),
                New SqlParameter("@PaxInfo", PaxInfo),
                New SqlParameter("@FstUser", FstUser),
                New SqlParameter("@PNR", PNR)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("CharterSell", RecID)
    End Sub

    Private Sub UpdateCharterSell(CustName As String, Phone As String, LandDetail As String, LandAmt As Double, QtyC As Int16, AmtC As Double, QtyY As Int16, AmtY As Double, OtherAmt As Double, OtherDetail As String, PaxInfo As String, RecID As Integer, PNR As String)
        Dim strSQL As String
        strSQL = "Update CharterSell set CustName=@CustName, Phone=@Phone, LandDetail=@LandDetail, LandAmt=@LandAmt, QtyC=@QtyC, AmtC=@AmtC, QtyY=@QtyY, AmtY=@AmtY, OtherAmt=@OtherAmt, OtherDetail=@OtherDetail, PaxInfo=@PaxInfo, PNR=@PNR where RecID=@RecID"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@CharterID", CharterID),
                New SqlParameter("@CustName", CustName),
                New SqlParameter("@Phone", Phone),
                New SqlParameter("@LandDetail", LandDetail),
                New SqlParameter("@LandAmt", LandAmt),
                New SqlParameter("@QtyC", QtyC),
                New SqlParameter("@AmtC", AmtC),
                New SqlParameter("@QtyY", QtyY),
                New SqlParameter("@AmtY", AmtY),
                New SqlParameter("@OtherAmt", OtherAmt),
                New SqlParameter("@OtherDetail", OtherDetail),
                New SqlParameter("@PaxInfo", PaxInfo),
                New SqlParameter("@RecID", RecID),
                New SqlParameter("@PNR", PNR)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("CharterSell", RecID)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txtCustName.Text = ""
        txtPhone.Text = ""
        txtQtyC.Text = 0
        txtQtyY.Text = 0
        txtAmtC.Text = lblRefAmtC.Text
        txtAmtY.Text = lblRefAmtY.Text
        txtLandQty.Text = 1
        txtLandAmt.Text = 0
        cbxBus.Text = ""
        txtBusAmt.Text = 0
        txtLandRMK.Text = ""
        cbxServiceName.Text = ""
        txtServiceQty.Text = 1
        txtServiceAmount.Text = 0
        txtServiceRMK.Text = ""
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
        GridService.DataSource = Nothing
        GridLand.DataSource = Nothing
        dtlLand = Nothing
        dtlService = Nothing
        TaoGridLand()
        TaoGridService()
        txtPaxName.Text = ""
        txtTKNO.Text = ""
        txtTtlAmt.Text = 0
        txtTtlAmtAir.Text = 0
        txtTtlAmtLand.Text = 0
        txtTtlAmtService.Text = 0
    End Sub

    Private Sub LoadGridCharterSell()
        Dim dtl As DataTable = GetDataTable("Select CustName, Phone, LandDetail, LandAmt, QtyC, AmtC, QtyY, AmtY, OtherAmt, OtherDetail, TotalAmt, PaxInfo, (Select HoTen from tbluser where RecID=CharterSell.FstUser) FstUser, FstUpdate, RecID, CharterID from CharterSell where CharterID=" & CharterID & " and Status='OK' order by RecID")
        bdsView.DataSource = dtl
        GridCharterSell.DataSource = bdsView
        GridCharterSell.Columns("RecID").Visible = False
        GridCharterSell.Columns("CharterID").Visible = False
        GridCharterSell.Columns("LandDetail").Visible = False
        GridCharterSell.Columns("OtherDetail").Visible = False
        GridCharterSell.Columns("PaxInfo").Visible = False
        GridCharterSell.Columns("CustName").Width = 150
        GridCharterSell.Columns("Phone").Width = 70
        GridCharterSell.Columns("LandAmt").Width = 60
        GridCharterSell.Columns("LandAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("LandAmt").DefaultCellStyle.Format = "#,##"
        GridCharterSell.Columns("OtherAmt").Width = 60
        GridCharterSell.Columns("OtherAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("OtherAmt").DefaultCellStyle.Format = "#,##"
        GridCharterSell.Columns("QtyC").Width = 30
        GridCharterSell.Columns("QtyC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("QtyC").DefaultCellStyle.Format = "#,##"
        GridCharterSell.Columns("QtyY").Width = 30
        GridCharterSell.Columns("QtyY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("QtyY").DefaultCellStyle.Format = "#,##"
        GridCharterSell.Columns("AmtY").Width = 60
        GridCharterSell.Columns("AmtY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("AmtY").DefaultCellStyle.Format = "#,##"
        GridCharterSell.Columns("AmtC").Width = 60
        GridCharterSell.Columns("AmtC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("AmtC").DefaultCellStyle.Format = "#,##"
        GridCharterSell.Columns("FstUser").Width = 150
        GridCharterSell.Columns("FstUpdate").Width = 90
        GridCharterSell.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridCharterSell.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridCharterSell.Columns("FstUpdate").Frozen = True
    End Sub

    Private Sub GridCharterSell_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridCharterSell.DataBindingComplete
        GridCharterSell.ClearSelection()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCustName.Text = "" Then
            MsgBox("Chưa nhập tên khách!")
            Exit Sub
        End If
        If txtPhone.Text = "" Then
            MsgBox("Chưa nhập số điện thoại!")
            Exit Sub
        End If
        InsertCharterSell(CharterID, txtCustName.Text, txtPhone.Text, IIf(JSON_Land.Length > 2, JSON_Land, ""), txtTtlAmtLand.Text, txtQtyC.Text, txtAmtC.Text, txtQtyY.Text, txtAmtY.Text, txtTtlAmtService.Text, IIf(JSON_Service.Length > 2, JSON_Service, ""), txtPaxName.Text & "|" & txtTKNO.Text, myStaff.UserID, txtPNR.Text)
        LoadGridCharterSell()
        btnNew_Click(sender, e)
        LoadRefInfo()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCustName.Text = "" Then
            MsgBox("Chưa nhập tên khách!")
            Exit Sub
        End If
        If txtPhone.Text = "" Then
            MsgBox("Chưa nhập số điện thoại!")
            Exit Sub
        End If
        UpdateCharterSell(txtCustName.Text, txtPhone.Text, IIf(JSON_Land.Length > 2, JSON_Land, ""), txtTtlAmtLand.Text, txtQtyC.Text, txtAmtC.Text, txtQtyY.Text, txtAmtY.Text, txtTtlAmtService.Text, IIf(JSON_Service.Length > 2, JSON_Service, ""), txtPaxName.Text & "|" & txtTKNO.Text, dtr("RecID"), txtPNR.Text)
        LoadGridCharterSell()
        btnNew_Click(sender, e)
        LoadRefInfo()
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            txtCustName.Text = dtr("CustName")
            txtPhone.Text = dtr("Phone")
            txtQtyC.Text = dtr("QtyC")
            txtQtyY.Text = dtr("QtyY")
            txtAmtC.Text = dtr("AmtC")
            txtAmtY.Text = dtr("AmtY")
            txtTKNO.Text = dtr("PaxInfo").ToString.Split("|")(1)
            txtPaxName.Text = dtr("PaxInfo").ToString.Split("|")(0)
            LoadGridLand(dtr("LandDetail"))
            LoadGridService(dtr("OtherDetail"))
            txtLandAmt.Text = FormatDigit(dtr("LandAmt"))
            txtTtlAmtService.Text = FormatDigit(dtr("OtherAmt"))
            txtTtlAmtAir.Text = FormatDigit(txtQtyC.Text * txtAmtC.Text + txtAmtY.Text * txtAmtY.Text)
            btnUpdate.Enabled = True
            btnAdd.Enabled = False
            LockControl()
            LoadTotalAmt()
            TinhServiceAmt()

        End If
    End Sub

    Private Sub GridCharterSell_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCharterSell.CellClick
        bdsView_CurrentChanged(sender, e)
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
            Dim f As New Ticketing_CustPayment("CharterSell", dtr("RecID"), 0, ExeScalar("Select Code from chartercode where RecID=" & CharterID))
            f.MdiParent = FrmMain
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
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
            ExeNonequery("update CharterSell set Status='XX' where recID=@RecID", Para)
            LoadTotalAmt()
            GhiLog("CharterSell", dtr("RecID"))
        End If
        LoadGridCharterSell()
        btnNew_Click(sender, e)
    End Sub
End Class