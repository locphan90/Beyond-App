Imports System.Data.SqlClient

Public Class Ticketing_CustPayment
    Dim TableName As String
    Dim TableID As Integer
    'Dim PNRID As Integer
    Dim CustID As Integer
    Dim dtr As DataRowView
    Dim TongTien As Double = 0
    Dim Code As String 'Code ở đây là PNR hoặc code charter
    Sub New(pTableName As String, pTableID As Integer, Optional pCustID As Integer = 0, Optional pCode As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TableID = pTableID
        TableName = pTableName
        CustID = pCustID
        Code = pCode
    End Sub

    Private Sub Ticketing_CustPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CustName As String = ""
        If TableName = "PNR" Then
            If CustID <> 0 Then
                CustName = ExeScalar("Select CustName from Customer where RecID=" & CustID)
            Else
                CustName = ExeScalar("Select top 1 CustName from Ticketing where PNRID=" & TableID & " and Status='OK' order by RecID desc")
            End If
            'Dim dtl As DataTable = GetDataTable("Select * from PNR where RecID=" & TableID)
        ElseIf TableName = "CharterSell" Then
            CustName = ExeScalar("Select CustName from CharterSell where RecID=" & TableID)
            txtPayer.Text = CustName
        End If
        lblCustName.Text = CustName
        txtAmount.Text = FormatDigit(TinhTienConLai)
        LoadGridPayment()

        Dim ColName As String = ""
        If TableName = "CharterSell" Then
            ColName = "TotalAmt"
        Else
            ColName = "Amount"
        End If
        TongTien = ExeScalar("Select " & ColName & " from " & TableName & " where RecID=" & TableID)
    End Sub

    Private Function TinhTienConLai() As Decimal
        Dim ColName As String = ""
        If TableName = "CharterSell" Then
            ColName = "TotalAmt"
        Else
            ColName = "Amount"
        End If
        Dim Result As Decimal = 0
        Result = ExeScalar("Select " & ColName & " - (select isnull(sum(Amount),0) from CustPayment where Status<>'XX' and TableID=" & TableName & ".RecID) from " & TableName & " where RecID=" & TableID)
        Return Result
    End Function

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

    Private Sub LoadGridPayment()
        Dim dtl As DataTable = GetDataTable("Select p.RecID, Payer, Amount, p.Note, p.Status, (Select HoTen from tblUser where RecID=p.FstUser) FstUser, p.FstUpdate, isnull(f.FileName,'') FileAttach, isnull(f.FilePath, '') FilePath from CustPayment p left join ftpfile f on f.TableID=p.RecID and f.TableName='CustPayment' and f.status='OK' where p.Status<>'XX' and p.TableName='" & TableName & "' and p.TableID=" & TableID & " order by p.RecID")
        bdsView.DataSource = dtl
        GridPayment.DataSource = bdsView
        GridPayment.Columns("RecID").Visible = False
        GridPayment.Columns("FilePath").Visible = False
        GridPayment.Columns("Payer").Width = 150
        GridPayment.Columns("FileAttach").Width = 200
        GridPayment.Columns("Amount").Width = 70
        GridPayment.Columns("Status").Width = 40
        GridPayment.Columns("FstUser").Width = 150
        GridPayment.Columns("FstUpdate").Width = 110
        GridPayment.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridPayment.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("Amount").DefaultCellStyle.Format = "#,##"

    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAmount.Text = 0 Then
            MsgBox("Chưa nhập số tiền thanh toán!")
            Exit Sub
        End If
        Dim strSQL As String
        strSQL = "insert CustPayment (TableName, TableID, Payer, Amount, Note, FstUser) values (@TableName, @TableID, @Payer, @Amount, @Note, @FstUser);SELECT SCOPE_IDENTITY()"

        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@TableName", TableName),
                New SqlParameter("@TableID", TableID),
                New SqlParameter("@Payer", txtPayer.Text),
                New SqlParameter("@Amount", CDec(txtAmount.Text)),
                New SqlParameter("@Note", txtNote.Text),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        Dim RecID As Integer = ExeScalar(strSQL, Para)
        GhiLog("CustPayment", RecID)
        LoadGridPayment()
        txtNote.Text = ""
        txtAmount.Text = FormatDigit(TinhTienConLai)
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

        Dim result As DialogResult = MessageBox.Show("Bạn có muốn xóa thanh toán này không?", "Beyond Application", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            ExeNonequery("update CustPayment set Status='XX' where recID=@RecID", Para)
            GhiLog("CustPayment", dtr("RecID"))
        End If
        LoadGridPayment()
    End Sub

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        If bdsView.Count = 0 Then
            MsgBox("Chưa tạo thông tin thanh toán!")
            Exit Sub
        End If
        If (ofdFile.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Cursor.Current = Cursors.WaitCursor
            If dtr("FileAttach") <> "" Then
                FtpDeleteFile(dtr("RecID") & "_" & dtr("FileAttach"), "ftp://112.78.2.154/HinhAnh/", "dnfsoft", "&9U5x3cn")
                ExeNonequery("Update FtpFile set Status='XX' where TableName='CustPayment' and TableID=" & dtr("RecID"))
            End If
            FtpUploadFile(ofdFile.FileName, "ftp://112.78.2.154/HinhAnh/" & dtr("RecID") & "_" & ofdFile.SafeFileName, "dnfsoft", "&9U5x3cn")
            InsertFtpFile("CustPayment", dtr("RecID"), ofdFile.SafeFileName, "ftp://112.78.2.154/HinhAnh/" & dtr("RecID") & "_" & ofdFile.SafeFileName)
            LoadGridPayment()
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Private Sub GridThanhToan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridPayment.CellDoubleClick
        Cursor.Current = Cursors.WaitCursor
        ' Perform your time-consuming task here
        If GridPayment.CurrentRow.Cells("FilePath").Value <> "" Then
            FTPDownloadFile(Application.StartupPath & "\FilesBeyond\" & GridPayment.CurrentRow.Cells("FileAttach").Value, GridPayment.CurrentRow.Cells("FilePath").Value, "dnfsoft", "&9U5x3cn")
            Process.Start(Application.StartupPath & "\FilesBeyond\" & GridPayment.CurrentRow.Cells("FileAttach").Value)
        End If
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        Dim DaThanhToan As Double = ExeScalar("select isnull(sum(Amount),0) from CustPayment where Status='OK' and TableName='" & TableName & "' and TableID=" & TableID)
        CallXlsReport("Receipt.xlt", "V", ExcelConn, dtr("RecID"), dtr("Amount"), TinhTienConLai, lblCustName.Text, dtr("Payer"), dtr("Note"), TongTien, myStaff.UserName, Code, DaThanhToan)
    End Sub
End Class

