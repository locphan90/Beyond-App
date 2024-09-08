Imports System.Data.SqlClient

Public Class Acc_ConfirmSupPayment
    Dim dtr As DataRowView
    Dim RunPageLoad As Boolean = False
    Private Sub Acc_ConfirmSupPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RunPageLoad = True
        LoadGridPayment()
    End Sub

    Private Sub LoadGridPayment()
        Dim DK As String = ""
        If dtpValid.Checked Then
            DK = " and FstUpdate>='" & Format(dtpValid.Value, "dd-MMM-yy") & " 23:59'"
        End If
        If rdoConfirmed.Checked Then
            DK = DK & " and Status='OK'"
        Else
            DK = DK & " and Status='QQ'"
        End If

        Dim dtl As DataTable = GetDataTable("select (select SupplierName from Supplier where RecID=p.SupplierID) Supplier, FOP, Curr, ROE, Urgent, Amount, RMK, TRX, (Select HoTen from tblUser where p.FstUser=RecID) FstUser, FstUpdate, RecID from SupplierPayment p where RecID>0" & DK)
        bdsView.DataSource = dtl
        GridPayment.DataSource = bdsView
        GridPayment.Columns("RecID").Visible = False
        GridPayment.Columns("Supplier").Width = 150
        GridPayment.Columns("FOP").Width = 35
        GridPayment.Columns("Curr").Width = 40
        GridPayment.Columns("ROE").Width = 50
        GridPayment.Columns("Urgent").Width = 40
        GridPayment.Columns("Amount").Width = 70
        GridPayment.Columns("RMK").Width = 250
        GridPayment.Columns("TRX").Width = 200
        GridPayment.Columns("FstUser").Width = 150
        GridPayment.Columns("FstUpdate").Width = 90
        GridPayment.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridPayment.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("Amount").DefaultCellStyle.Format = "#,##"
        GridPayment.Columns("ROE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("ROE").DefaultCellStyle.Format = "#,##"
        GridPayment.Columns("Curr").Frozen = True
    End Sub

    Private Sub LoadGridFile()
        Dim dtl As DataTable = GetDataTable("select RecID, FileName, FilePath, (Select hoten from tbluser where recid=FtpFile.FstUser) FstUser, FstUpdate from FtpFile where TableName='SupplierPayment' and TableID=" & dtr("RecID") & " and Status='OK'")
        GridFile.DataSource = dtl
        GridFile.Columns("RecID").Visible = False
        GridFile.Columns("FilePath").Visible = False
        GridFile.Columns("FstUser").Width = 150
        GridFile.Columns("FileName").Width = 300
        GridFile.Columns("FstUpdate").Width = 90
        GridFile.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridFile.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
    End Sub

    Private Sub GridPayment_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles GridPayment.DataBindingComplete
        GridPayment.ClearSelection()
    End Sub

    Private Sub rdoPending_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPending.CheckedChanged, rdoConfirmed.CheckedChanged
        If RunPageLoad = True Then
            LoadGridPayment()
        End If
    End Sub

    Private Sub dtpValid_ValueChanged(sender As Object, e As EventArgs) Handles dtpValid.ValueChanged
        If RunPageLoad = True Then
            LoadGridPayment()
        End If
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            LoadGridFile()
        Else
            GridFile.DataSource = Nothing
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

    Private Sub btnRefuse_Click(sender As Object, e As EventArgs) Handles btnRefuse.Click
        ExeNonequery("Update SupplierPayment set Status='RF' where RecID=" & dtr("RecID"))
        ExeNonequery("Update SupplierPaymentDetail set Status='RF' where SupplierPaymentID=" & dtr("RecID"))
        GhiLog("SupplierPayment", dtr("RecID"))
        LoadGridPayment()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strSQL As String
        strSQL = "Update SupplierPayment set Status='OK', TRX=@TRX where RecID=" & dtr("RecID")
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@TRX", txtTransactionInfo.Text)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("SupplierPayment", dtr("RecID"))
        LoadGridPayment()
        txtTransactionInfo.Text = ""
    End Sub
End Class