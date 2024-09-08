Public Class Ticketing_CharterCode
    Dim dtr As DataRowView
    Dim RunPageLoad As Boolean = False
    Private Sub Ticketing_CharterCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTo.Value = DateAdd(DateInterval.Day, 30, dtpFrom.Value)
        LoadGridCharterCode()
        RunPageLoad = True
    End Sub
    Private Sub LoadGridCharterCode()
        Dim dtl As DataTable = GetDataTable("Select Code, DeptDate, EndDate, Descr, QtyC, (Select isnull(sum(QtyC),0) from CharterSell where CharterID=c.RecID and Status='OK') QtyC_DaBan, QtyY, (Select isnull(sum(QtyY),0) from CharterSell where CharterID=c.RecID and Status='OK') QtyY_DaBan, RecID from CharterCode c where Status='OK' and DeptDate between '" & Format(dtpFrom.Value, "ddMMMyy") & "' and '" & Format(dtpTo.Value, "ddMMMyy") & " 23:59' order by Code, RecID")
        bdsView.DataSource = dtl
        GridCharterCode.DataSource = bdsView
        GridCharterCode.Columns("RecID").Visible = False
        GridCharterCode.Columns("Code").Width = 110
        GridCharterCode.Columns("Descr").Width = 250
        GridCharterCode.Columns("DeptDate").Width = 60
        GridCharterCode.Columns("QtyC").Width = 60
        GridCharterCode.Columns("QtyC_DaBan").Width = 80
        GridCharterCode.Columns("QtyY").Width = 60
        GridCharterCode.Columns("QtyY_DaBan").Width = 80
        GridCharterCode.Columns("DeptDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridCharterCode.Columns("DeptDate").DefaultCellStyle.Format = "dd-MMM-yy"
        GridCharterCode.Columns("EndDate").Width = 60
        GridCharterCode.Columns("EndDate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridCharterCode.Columns("EndDate").DefaultCellStyle.Format = "dd-MMM-yy"
        GridCharterCode.Columns("QtyC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridCharterCode.Columns("QtyY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridCharterCode.Columns("QtyC_DaBan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridCharterCode.Columns("QtyY_DaBan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GridCharterCode.Columns("Code").Frozen = True
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
        End If
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        If RunPageLoad = True Then
            LoadGridCharterCode()
        End If
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        If RunPageLoad = True Then
            LoadGridCharterCode()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bdsView.Filter = "Code like '%" & txtSearch.Text & "%' or descr like '%" & txtSearch.Text & "%'"
    End Sub

    Private Sub GridCharterCode_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCharterCode.CellDoubleClick
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_ChaterSell") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_CharterSell(dtr("RecID"))
            f.MdiParent = FrmMain
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub
End Class