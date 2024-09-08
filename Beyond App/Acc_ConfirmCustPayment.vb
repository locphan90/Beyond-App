Imports System.Data.SqlClient
Imports System.IO

Public Class Acc_ConfirmCustPayment
    Dim RunPageLoad As Boolean = False
    Dim dtr As DataRowView
    Dim FolderPath As String = Application.StartupPath & "\FilesBeyond"
    Private Sub LoadGridPayment()
        Dim DK As String = ""
        If dtpValid.Checked Then
            DK = DK & " and p.FstUpdate >= '" & Format(dtpValid.Value, "dd-MMM-yy") & " 00:00'"
        End If
        If rdoPending.Checked Then
            DK = DK & " and p.Status='QQ'"
        End If
        If rdoConfirmed.Checked Then
            DK = DK & " and p.Status='OK'"
        End If

        Dim dtl As DataTable = GetDataTable("Select p.RecID, case when p.TableName='PNR' then 'AIR' else 'CHARTER' end Type, Payer, Amount, Note, (Select HoTen from tblUser where RecID=p.FstUser) FstUser, p.FstUpdate, isnull(f.FileName,'') FileAttach, isnull(f.FilePath, '') FilePath from CustPayment p left join ftpfile f on f.TableID=p.RecID and f.TableName='CustPayment' and f.status='OK' where p.Status<>'XX' " & DK & "order by p.RecID")
        bdsView.DataSource = dtl
        GridPayment.DataSource = bdsView
        GridPayment.Columns("RecID").Visible = False
        GridPayment.Columns("FilePath").Visible = False
        GridPayment.Columns("FileAttach").Visible = False
        GridPayment.Columns("FstUser").Width = 150
        GridPayment.Columns("Payer").Width = 150
        GridPayment.Columns("Type").Width = 70
        GridPayment.Columns("Note").Width = 200
        GridPayment.Columns("FstUpdate").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("FstUpdate").DefaultCellStyle.Format = "dd-MMM-yy HH:mm"
        GridPayment.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        GridPayment.Columns("Amount").DefaultCellStyle.Format = "#,##"
    End Sub

    Private Sub Acc_ConfirmCustPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridPayment()
        RunPageLoad = True
    End Sub

    Private Sub dtpValid_ValueChanged(sender As Object, e As EventArgs) Handles dtpValid.ValueChanged
        If RunPageLoad = True Then
            LoadGridPayment()
        End If
    End Sub

    Private Sub bdsView_CurrentChanged(sender As Object, e As EventArgs) Handles bdsView.CurrentChanged
        If bdsView.Count > 0 Then
            dtr = bdsView.Current
            Dim dtl As DataTable = GetDataTable("Select RecID, FileName, FilePath from FtpFile where TableName='CustPayment' and TableID=" & dtr("RecID") & " and (charindex('.jpg', FileName)<>0 or charindex('.jpeg', FileName)<>0 or charindex('.png', FileName)<>0) and Status='OK'")
            For i As Int16 = 0 To dtl.Rows.Count - 1
                Dim SavePath As String = System.IO.Path.Combine(FolderPath, dtl.Rows(i)("FileName")) 'combines the saveDirectory and the filename to get a fully qualified path.
                If System.IO.File.Exists(SavePath) Then
                    'The file exists
                Else
                    FTPDownloadFile(Application.StartupPath & "\FilesBeyond\" & dtl.Rows(i)("FileName"), dtl.Rows(i)("FilePath"), "dnfsoft", "&9U5x3cn")
                End If
            Next
            flpHinhAnh.Controls.Clear()
            ' Check if the directory exists
            If Directory.Exists(FolderPath) Then
                For i As Integer = 0 To dtl.Rows.Count - 1
                    ' Create a PictureBox for each image
                    Dim pictureBox As New PictureBox()
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom ' Adjust image display mode if needed
                    pictureBox.ImageLocation = FolderPath & "\" & dtl.Rows(i)("FileName")
                    pictureBox.Image = Image.FromFile(FolderPath & "\" & dtl.Rows(i)("FileName"))
                    pictureBox.Width = 285 ' Set the width as needed
                    pictureBox.Height = 410 ' Set the height as needed 300
                    Dim imageSize As Size = pictureBox.Image.Size
                    Dim pictureBoxSize As Size = pictureBox.Size
                    Dim ratioX As Double = CType(pictureBoxSize.Width, Double) / imageSize.Width
                    Dim ratioY As Double = CType(pictureBoxSize.Height, Double) / imageSize.Height
                    Dim ratio As Double = Math.Min(ratioX, ratioY)
                    Dim newWidth As Integer = CInt(imageSize.Width * ratio)
                    Dim newHeight As Integer = CInt(imageSize.Height * ratio)
                    pictureBox.Size = New Size(newWidth, newHeight)
                    ' Assign a tag to identify each PictureBox
                    pictureBox.Tag = i ' You can use any unique identifier here

                    ' Attach DoubleClick event handler to each PictureBox
                    AddHandler pictureBox.DoubleClick, AddressOf PictureBox_DoubleClick

                    ' Add PictureBox to the FlowLayoutPanel
                    flpHinhAnh.Controls.Add(pictureBox)
                Next
            Else

            End If
        End If
    End Sub
    Private Sub PictureBox_DoubleClick(sender As Object, e As EventArgs)
        Dim clickedPictureBox As PictureBox = DirectCast(sender, PictureBox)
        Process.Start(clickedPictureBox.ImageLocation)
    End Sub

    Private Sub rdoPending_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPending.CheckedChanged, rdoConfirmed.CheckedChanged
        If RunPageLoad = True Then
            LoadGridPayment()
        End If
        If rdoPending.Checked Then
            btnConfirm.Enabled = True
            btnRefuse.Enabled = True
        Else
            btnConfirm.Enabled = False
            btnRefuse.Enabled = False
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        bdsView.Filter = "Payer like '%" & txtSearch.Text & "%'"
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim strSQL As String
        strSQL = "Update CustPayment set Status='OK', TransactionInfo=@TransactionInfo where RecID=" & dtr("RecID")
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@TransactionInfo", txtTransactionInfo.Text)
            }
        ExeNonequery(strSQL, Para)
        GhiLog("CustPayment", dtr("RecID"))
        LoadGridPayment()
        txtTransactionInfo.Text = ""
    End Sub

    Private Sub btnRefuse_Click(sender As Object, e As EventArgs) Handles btnRefuse.Click
        ExeNonequery("Update CustPayment set Status='RF' where RecID=" & dtr("RecID"))
        GhiLog("CustPayment", dtr("RecID"))
        LoadGridPayment()
    End Sub
End Class