Imports System.IO
Imports System.Data.SqlClient
Public Class FrmReport
    Dim PhongBan As String = ""
    Dim dtrReport As DataRowView
    Sub New(pPhongBan As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PhongBan = pPhongBan
    End Sub

    Private Sub BaoCao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid("Select Val2 as TenBaoCao, Val, Num from MISC where cat like '%TEMPLATE_RPT%' and cat like '%" & PhongBan & "%' and status='OK' order by val2", GridReport, bdsReport)
        GridReport.Columns("TenBaoCao").Width = 234
        GridReport.Columns("Val").Visible = False
    End Sub

    Private Sub btnChayBaoCao_Click(sender As Object, e As EventArgs) Handles btnChayBaoCao.Click
        Dim FolderPath = Application.StartupPath & "\FilesBeyond"
        If Not System.IO.Directory.Exists(FolderPath) Then
            System.IO.Directory.CreateDirectory(FolderPath)
        End If
        Dim directoryName As String = FolderPath
        Try
            For Each deleteFile In Directory.GetFiles(directoryName, "*.*", SearchOption.TopDirectoryOnly)
                File.Delete(deleteFile)
            Next
        Catch ex As Exception

        End Try
        CallXlsReport(dtrReport("Val"), "O", ExcelConn, str1:=dtpTuNgay.Value, dtpDenNgay.Value, str3:=FolderPath & "\" & Format(dtpTuNgay.Value, "ddMMMyyyy") & "_" & dtrReport("Val").ToString.Replace(".xlt", "") & ".xlsx")
        Process.Start(FolderPath & "\" & Format(dtpTuNgay.Value, "ddMMMyyyy") & "_" & dtrReport("Val").ToString.Replace(".xlt", "") & ".xlsx")

    End Sub

    Public Sub CallExcelFile(FileName As String, PSW As String)
        Dim AppXls As Microsoft.Office.Interop.Excel.Application, WkBook As Microsoft.Office.Interop.Excel.Workbook, WkSheet As Microsoft.Office.Interop.Excel.Worksheet
        On Error Resume Next
        AppXls = CreateObject("Excel.Application")
        On Error GoTo 0
        WkBook = AppXls.Workbooks.Open(Application.StartupPath & "\" & FileName, Password:="RPT1234", Editable:=True)
        AppXls.Visible = True
    End Sub

    Private Sub bdsReport_CurrentChanged(sender As Object, e As EventArgs) Handles bdsReport.CurrentChanged
        If bdsReport.Count > 0 Then
            dtrReport = bdsReport.Current
        End If
    End Sub
End Class