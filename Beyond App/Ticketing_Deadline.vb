Public Class Ticketing_Deadline
    Dim dtr As DataRowView
    Dim RunPageLoad As Boolean = False
    Private Sub LoadGridDeadline()
        Dim DK As String = ""
        If rdoInvidual.Checked Then
            DK = " and d.FstUser=" & myStaff.UserID
        End If
        Dim dtl As DataTable = GetDataTable("Select d.Type, PNR, d.Deadline, CustName, ContractNo, (Select HoTen from tbluser where RecID=g.FstUser) FstUser, d.RecID, d.Fstuser NguoiTao from Deadline d left join GroupTicketing g on g.RecID=d.GroupTicketingID left join Customer c on c.recid=g.CustID where d.status='QQ' and Deadline between '" & Format(dtpFrom.Value, "dd-MMM-yy") & "' and '" & Format(dtpTo.Value, "dd-MMM-yy") & " 23:59' " & DK & " order by Deadline")
        bdsView.DataSource = dtl
        GridDeadline.DataSource = bdsView
        GridDeadline.Columns("RecID").Visible = False
        GridDeadline.Columns("NguoiTao").Visible = False
        GridDeadline.Columns("Type").Width = 100
        GridDeadline.Columns("PNR").Width = 50
        GridDeadline.Columns("Deadline").Width = 60
        GridDeadline.Columns("CustName").Width = 150
        GridDeadline.Columns("ContractNo").Width = 150
        GridDeadline.Columns("Deadline").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridDeadline.Columns("Deadline").DefaultCellStyle.Format = "dd-MMM-yy"
    End Sub

    Private Sub Ticketing_Deadline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridDeadline()
        RunPageLoad = True
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged, dtpTo.ValueChanged, rdoDepartment.CheckedChanged, rdoInvidual.CheckedChanged
        If RunPageLoad = True Then
            LoadGridDeadline()
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If bdsView.Count > 0 Then
            If dtr("NguoiTao") <> myStaff.UserID Then
                MsgBox("Deadline của user khác tạo, bạn không có quyền thao tác!")
                Exit Sub
            End If
            ExeNonequery("Update Deadline set Status='OK' where RecID=" & dtr("RecID"))
            GhiLog("Deadline", dtr("RecID"))
            LoadGridDeadline()
        End If
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
        End If
    End Sub
End Class