Imports System.Data.SqlClient
Imports Microsoft

Public Class Ticketing_SupplierPayment
    Dim dtrSupplier As DataRowView
    Dim dtrView As DataRowView
    Dim RunPageLoad As Boolean = False
    Private Sub LoadGridSupplier()
        Dim dtl As DataTable = GetDataTable("Select RecID, SupplierName, Type from Supplier where Status='OK' order by Type, SupplierName")
        bdsSupplier.DataSource = dtl
        GridSupplier.DataSource = bdsSupplier
        GridSupplier.Columns("RecID").Visible = False
        GridSupplier.Columns("SupplierName").Width = 150
        GridSupplier.Columns("Type").Width = 50
    End Sub

    Private Sub txtSupplier_TextChanged(sender As Object, e As EventArgs)
        bdsSupplier.Filter = " Fullname like '%" & txtSupplier.Text & "%'"
    End Sub

    Private Sub LoadGridService()
        Dim DK As String = ""
        If chkPaid.Checked Then
            DK = "NetAmt-Paid=0"
        Else
            DK = "NetAmt-Paid>0"
        End If

        If dtpFrom.Checked Then
            DK = DK & " and FstUpdate between '" & Format(dtpFrom.Value, "dd-MMM-yy") & "' and '" & Format(dtpTo.Value, "dd-MMM-yy") & " 23:59'"
        End If

        Dim dtl As DataTable = GetDataTable("Select * from (select PNR [Code/PNR], Curr, NetAmt, isnull((Select Sum(Amount) from SupplierPaymentDetail where Status='OK' and TableID=PNR.RecID and TableName='PNR'),0) Paid, 0 Payment, 'PNR' TableName, (Select HoTen from tbluser where RecID=pnr.FstUser) FstUser, FstUpdate, RecID from pnr where custtype='GIT' and SupplierID=" & dtrSupplier("RecID") & " and Status='OK'
union all
select Code, Curr, TotalAmount,  isnull((Select Sum(Amount) from SupplierPaymentDetail where Status='OK' and TableID=CharterCode.RecID and TableName='CharterCode'),0) Paid, 0, 'CharterCode', (Select HoTen from tbluser where RecID=CharterCode.FstUser) FstUser, FstUpdate, RecID  from CharterCode where AirSupplierID=" & dtrSupplier("RecID") & " and status='OK'
union all
select (select code from CharterCode where CharterID=RecID), Curr, Qty*Price, isnull((Select Sum(Amount) from SupplierPaymentDetail where Status='OK' and TableID=CharterLand.RecID and TableName='CharterLand'),0) Paid, 0, 'CharterLand', (Select HoTen from tbluser where RecID=CharterLand.FstUser) FstUser, FstUpdate,RecID  from CharterLand where LandSupplierID=" & dtrSupplier("RecID") & " and Status='OK') T where " & DK)
        GridService.DataSource = dtl
        GridService.Columns("RecID").Visible = False
        GridService.Columns("TableName").Visible = False
        GridService.Columns("Code/PNR").Width = 110
        GridService.Columns("Curr").Width = 40
        GridService.Columns("NetAmt").Width = 70
        GridService.Columns("NetAmt").HeaderText = "Amount"
        GridService.Columns("NetAmt").Width = 70
        GridService.Columns("Paid").Width = 70
        GridService.Columns("Payment").Width = 70
        GridService.Columns("FstUser").Width = 150
        GridService.Columns("FstUpdate").Width = 90
        GridService.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridService.Columns("NetAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("NetAmt").DefaultCellStyle.Format = "#,##"
        GridService.Columns("Paid").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("Paid").DefaultCellStyle.Format = "#,##"
        GridService.Columns("Payment").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridService.Columns("Payment").DefaultCellStyle.Format = "#,##"
    End Sub

    Private Sub LoadGridView()
        Dim dtl As DataTable = GetDataTable("select Fop, Curr, ROE, Urgent, Amount, RMK, (Select HoTen from tbluser where RecID=s.FstUser) FstUser, FstUpdate, (select STRING_AGG([code/pnr] + ': ' + convert(varchar, amount), '_') from (
select  (select PNR from PNR where RecID=sd.TableID) [Code/PNR], amount from SupplierPaymentDetail sd where TableName='PNR' and SupplierPaymentID=s.RecID and Status='OK'
union all
select  (select code from CharterCode where RecID=sd.TableID), amount from SupplierPaymentDetail sd where TableName='CharterCode' and SupplierPaymentID=s.RecID and Status='OK'
union all
select  (select (select code from CharterCode where CharterID=RecID) from CharterLand where RecID=sd.TableID), amount from SupplierPaymentDetail sd where TableName='CharterLand' and SupplierPaymentID=s.RecID and Status='OK') T) Info, TRX ,Status, s.recid from SupplierPayment s where supplierid=" & dtrSupplier("RecID") & " and status not in ('XX','RF') and FstUpdate between '" & Format(dtpViewFrom.Value, "dd-MMM-yy") & "' and '" & Format(dtpViewTo.Value, "dd-MMM-yy") & " 23:59'")
        bdsView.DataSource = dtl
        GridView.DataSource = bdsView
        GridView.Columns("RecID").Visible = False
        GridView.Columns("Status").Visible = False
        GridView.Columns("FOP").Width = 30
        GridView.Columns("Curr").Width = 35
        GridView.Columns("ROE").Width = 50
        GridView.Columns("Urgent").Width = 35
        GridView.Columns("Amount").Width = 70
        GridView.Columns("RMK").Width = 250
        GridView.Columns("Info").Width = 200
        GridView.Columns("TRX").Width = 150
        GridView.Columns("FstUser").Width = 150
        GridView.Columns("FstUpdate").Width = 90
        GridView.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridView.Columns("Amount").DefaultCellStyle.Format = "#,##"
        GridView.Columns("ROE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridView.Columns("ROE").DefaultCellStyle.Format = "#,##"
        GridView.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridView.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
    End Sub

    Private Sub frmPaymentRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunPageLoad = True
        LoadGridSupplier()
        If bdsSupplier.Count > 0 Then
            LoadGridService()
        End If
        BuildControl("Select Val from MISC where CAT='FOP' order by Val", "Val", "Val", cbxFOP)
    End Sub

    Private Sub bdsSupplier_CurrentChanged(sender As Object, e As EventArgs) Handles bdsSupplier.CurrentChanged
        If bdsSupplier.Count > 0 Then
            dtrSupplier = bdsSupplier.Current
            LoadGridService()
            If TabSummary.SelectedTab.Name = "TabReview" Then
                LoadGridView()
            End If
        End If
    End Sub



    Private Sub GridService_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles GridService.CurrentCellDirtyStateChanged
        If TypeOf GridService.CurrentCell Is DataGridViewCheckBoxCell Then
            GridService.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub GridService_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles GridService.CellValueChanged
        Dim Curr As String = ""
        For i As Int16 = 0 To GridService.RowCount - 1
            If GridService.Rows(i).Cells("chk").Value = True Then
                Curr = GridService.Rows(i).Cells("Curr").Value
                Exit For
            End If
        Next
        If GridService.Columns(e.ColumnIndex).Name = "chk" Then
            If GridService.Rows(e.RowIndex).Cells("chk").Value Then
                If Curr <> "" And Curr = GridService.Rows(e.RowIndex).Cells("Curr").Value Then
                    GridService.Item("Payment", e.RowIndex).ReadOnly = False
                    GridService.Item("Payment", e.RowIndex).Value = GridService.Item("NetAmt", e.RowIndex).Value - GridService.Item("Paid", e.RowIndex).Value
                    txtCurr.Text = Curr
                Else
                    MsgBox("Không được chọn 2 tỷ giá khác nhau!")
                    GridService.Rows(e.RowIndex).Cells("chk").Value = False
                    GridService.RefreshEdit()
                    Exit Sub
                End If
            Else
                GridService.Item("Payment", e.RowIndex).ReadOnly = True
                GridService.Item("Payment", e.RowIndex).Value = "0"
            End If
        End If
        If GridService.Columns(e.ColumnIndex).Name = "Payment" Then
            CalculateTotalAmount()
        End If
    End Sub

    Private Sub CalculateTotalAmount()
        Dim Amount As Double = 0
        For i As Integer = 0 To GridService.RowCount - 1
            If GridService.Rows(i).Cells("chk").Value = True Then
                Amount = Amount + GridService.Rows(i).Cells("Payment").Value
            End If
        Next
        lblTotalAmount.Text = Format(Amount, "#,##")
    End Sub

    Private Sub TextBox_keyPressNumber(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = ",") Then e.Handled = True
    End Sub

    Private Sub txtPayment_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 46 Then
            If (CheckIsDigit(Asc(e.KeyChar))) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub GridService_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridService.EditingControlShowing
        If e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPressNumber
            'AddHandler e.Control.KeyPress, AddressOf txtPayment_KeyPress
        Else
            RemoveHandler e.Control.KeyPress, AddressOf TextBox_keyPressNumber
        End If
    End Sub

    Private Sub Rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtROE.KeyPress
        ' Khai bao pham vi duoc nhap
        Dim ValidChar As String = "-0123456789." + Convert.ToChar(8).ToString()
        If ValidChar.Contains(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtROE.TextChanged
        If InStr(CType(sender, TextBox).Text, ".") = 0 Then
            If CType(sender, TextBox).Text <> "" Then
                CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
            End If
        End If
        sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_Leave(sender As Object, e As EventArgs) Handles txtROE.Leave
        CType(sender, TextBox).Text = FormatDigit(CType(sender, TextBox).Text.Replace(",", ""))
        'sender.SelectionStart = Len(sender.Text)
    End Sub

    Private Sub txtNumber_GotFocus(sender As Object, e As EventArgs) Handles txtROE.GotFocus
        If CType(sender, TextBox).Text = "0" Then
            CType(sender, TextBox).Text = ""
        End If
    End Sub

    Private Sub InsertPayment()

    End Sub

    Private Sub btnRequestPayment_Click(sender As Object, e As EventArgs) Handles btnRequestPayment.Click
        If txtCurr.Text <> "VND" Then
            If txtROE.Text = 0 And txtROE.Text = 1 Then
                MsgBox("Chưa nhập ROE!")
                Exit Sub
            End If
        End If
        Dim strSQL As String
        strSQL = "insert SupplierPayment (SupplierID, FOP, Curr, ROE, Urgent, Amount, RMK, FstUser) values (@SupplierID, @FOP, @Curr, @ROE, @Urgent, @Amount, @RMK, @FstUser);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@SupplierID", dtrSupplier("RecID")),
                New SqlParameter("@FOP", cbxFOP.Text),
                New SqlParameter("@Curr", txtCurr.Text),
                New SqlParameter("@ROE", CInt(txtROE.Text)),
                New SqlParameter("@Urgent", chkUrgent.Checked),
                New SqlParameter("@Amount", CDbl(lblTotalAmount.Text)),
                New SqlParameter("@RMK", txtRMK.Text),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        For i As Integer = 0 To GridService.RowCount - 1
            strSQL = "Insert SupplierPaymentDetail (SupplierPaymentID, Amount, TableName, TableID, FstUser) values (@SupplierPaymentID, @Amount, @TableName, @TableID, @FstUser);SELECT SCOPE_IDENTITY()"
            Dim IDDetail As Integer
            If GridService.Rows(i).Cells("chk").Value = True Then
                Para = New SqlParameter() _
                    {
                        New SqlParameter("@SupplierPaymentID", RecID),
                        New SqlParameter("@Amount", GridService.Rows(i).Cells("Payment").Value),
                        New SqlParameter("@TableName", GridService.Rows(i).Cells("TableName").Value),
                        New SqlParameter("@TableID", GridService.Rows(i).Cells("RecID").Value),
                        New SqlParameter("@FstUser", myStaff.UserID)
                    }
                IDDetail = ExeScalar(strSQL, Para)
                GhiLog("SupplierPaymentDetail", IDDetail)
            End If
        Next
        GhiLog("SupplierPayment", RecID)
        LoadGridService()
        txtCurr.Text = ""
        lblTotalAmount.Text = 0
        txtRMK.Text = ""
        chkUrgent.Checked = False
        txtROE.Text = 1
    End Sub

    Private Sub chkPaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaid.CheckedChanged
        If RunPageLoad = True Then
            LoadGridService()
        End If

        If chkPaid.Checked = True Then
            btnRequestPayment.Enabled = False
        Else
            btnRequestPayment.Enabled = True
        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged
        If RunPageLoad = True Then
            LoadGridService()
        End If
    End Sub

    Private Sub txtSupplier_TextChanged_1(sender As Object, e As EventArgs) Handles txtSupplier.TextChanged
        bdsSupplier.Filter = "FullName like '%" & txtSupplier.Text & "%'"
    End Sub

    Private Sub TabSummary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabSummary.SelectedIndexChanged
        If TabSummary.SelectedTab.Name = "TabReview" Then
            LoadGridView()
        Else
            LoadGridService()
        End If
    End Sub

    Private Sub dtpViewFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpViewFrom.ValueChanged, dtpViewTo.ValueChanged
        If RunPageLoad = True Then
            LoadGridView()
        End If
    End Sub

    Private Sub GridSupplier_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridSupplier.DataBindingComplete
        GridSupplier.ClearSelection()
    End Sub

    Private Sub GridService_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridService.DataBindingComplete
        GridService.ClearSelection()
    End Sub

    Private Sub GridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridView.DataBindingComplete
        GridView.ClearSelection()
    End Sub

    Private Sub GridView_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles GridView.RowPrePaint
        If GridView.Rows(e.RowIndex).Cells("Status").Value = "OK" Then
            GridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If bdsView.Count = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        If dtrView("Status") = "OK" Then
            MsgBox("Đã được kế toán xác nhận, không có quyền xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", dtrView("RecID"))
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa dòng này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update SupplierPayment set Status='XX' where recID=@RecID", Para)
            ExeNonequery("update SupplierPaymentDetail set Status='XX' where SupplierPaymentID=@RecID", Para)
            GhiLog("SupplierPayment", dtrView("RecID"))
        End If
        LoadGridView()
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtrView = bdsView.Current
            LoadGridFileAttach()
        Else
            GridFile.DataSource = Nothing
        End If
    End Sub

    Private Sub LoadGridFileAttach()
        Dim dtl As DataTable = GetDataTable("select RecID, FileName, FilePath, (Select hoten from tbluser where recid=FtpFile.FstUser) FstUser, FstUpdate from FtpFile where TableName='SupplierPayment' and TableID=" & dtrView("RecID") & " and Status='OK'")
        GridFile.DataSource = dtl
        GridFile.Columns("RecID").Visible = False
        GridFile.Columns("FilePath").Visible = False
        GridFile.Columns("FstUser").Width = 150
        GridFile.Columns("FileName").Width = 300
        GridFile.Columns("FstUpdate").Width = 90
        GridFile.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridFile.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
    End Sub

    Private Sub GridFile_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridFile.DataBindingComplete
        GridFile.ClearSelection()
    End Sub

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        If bdsView.Count = 0 Then
            MsgBox("Không có thanh toán tương ứng để đính kèm file!")
            Exit Sub
        End If

        If (ofdMulti.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Cursor.Current = Cursors.WaitCursor
            For Each mfile As String In ofdMulti.FileNames
                'check File exist
                Dim Filename As String = System.IO.Path.GetFileName(mfile) 'get the filename of the original file without the directory on it
                Dim SavePath As String = System.IO.Path.Combine(Application.StartupPath & "\FilesBeyond", Filename) 'combines the saveDirectory and the filename to get a fully qualified path.
                InsertFtpFile("SupplierPayment", dtrView("RecID"), System.IO.Path.GetFileName(mfile), "ftp://112.78.2.154/HinhAnh/" & System.IO.Path.GetFileName(mfile))
                If System.IO.File.Exists(SavePath) Then
                    'The file exists
                Else
                    'My.Computer.FileSystem.CopyFile(mfile, Application.StartupPath & "\FilesBeyond\" & System.IO.Path.GetFileName(mfile), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                End If
                FtpUploadFile(mfile, "ftp://112.78.2.154/HinhAnh/" & System.IO.Path.GetFileName(mfile), "dnfsoft", "&9U5x3cn")
            Next
            LoadGridFileAttach()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub GridFile_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridFile.CellDoubleClick
        Cursor.Current = Cursors.WaitCursor
        ' Perform your time-consuming task here
        If GridFile.CurrentRow.Cells("FilePath").Value <> "" Then
            FTPDownloadFile(Application.StartupPath & "\FilesBeyond\" & GridFile.CurrentRow.Cells("FileName").Value, GridFile.CurrentRow.Cells("FilePath").Value, "dnfsoft", "&9U5x3cn")
            Process.Start(Application.StartupPath & "\FilesBeyond\" & GridFile.CurrentRow.Cells("FileName").Value)
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnDeleteFile_Click(sender As Object, e As EventArgs) Handles btnDeleteFile.Click
        If GridFile.RowCount = 0 Then
            MsgBox("Không có dữ liệu để xóa!")
            Exit Sub
        End If
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
        {
            New SqlParameter("@RecID", GridFile.CurrentRow.Cells("RecID").Value)
        }

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa file này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("Update FtpFile set Status='XX' where RecID=@RecID", Para)
            GhiLog("FtpFile", GridFile.CurrentRow.Cells("RecID").Value)
        End If
        LoadGridView()
    End Sub
End Class