Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Module SubAndFuntions
    Public myStaff As New objStaff
    Public Conn As New SqlClient.SqlConnection

    Public UserSQL As String
    Public GoogleDriveDisk As String
    Public CnStr As String = "Data Source=DESKTOP-AHU5FGU;Initial Catalog=BeyondApp; Integrated Security=SSPI; TimeOut=30"
    Public ExcelConn As String = "PROVIDER = SQLOLEDB;DATABASE=BeyondApp;server=DESKTOP-AHU5FGU;Integrated Security=SSPI;"
    'Public CnStr As String = "Data Source=112.78.2.154;Initial Catalog=dnf66954_Beyond;UID=dnf66954_Beyond;Pwd=9036S?cck;TimeOut=30"
    'Public ExcelConn As String = "PROVIDER=SQLOLEDB;DATA SOURCE=112.78.2.154;INITIAL CATALOG=dnf66954_Beyond;User ID=dnf66954_DNFview; password=Ee28s!7m9"

    Public Function GetDataTable(ByVal pStrCmd As String,
                             Optional pT As SqlClient.SqlTransaction = Nothing) As DataTable
        Dim tblResults As New DataTable
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
        Dim adapter As New SqlClient.SqlDataAdapter(pStrCmd, Conn)
        adapter.SelectCommand.Transaction = pT
        adapter.Fill(tblResults)
        Conn.Close()
        Return tblResults
    End Function

    Public Sub LoadGrid(cmd As String, GridName As DataGridView, bds As BindingSource)
        Dim dtl As New DataTable
        dtl = GetDataTable(cmd)
        bds.DataSource = dtl
        GridName.DataSource = bds
    End Sub

    Public Sub BuildControl(ByVal cmd As String, ByVal pValue As String, ByVal pDisplay As String, ByVal obj As Object)
        Dim dtl As DataTable = GetDataTable(cmd)
        obj.DataSource = dtl
        obj.DisplayMember = pDisplay
        obj.ValueMember = pValue
    End Sub

    Public Function encryptData(data As String) As Byte()
        Dim md5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim hashedBytes As Byte()
        Dim encoder As New System.Text.UTF8Encoding()
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data))
        Return hashedBytes
    End Function

    Public Function md5(data As String) As String
        Return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower()
    End Function

    Public Function ExeScalar(pQuery As String, ParamArray pPara() As SqlParameter) As Object
        Dim kq As Object = Nothing
        Using sqlcon As New SqlConnection(CnStr)
            Dim sqlcom As SqlCommand = sqlcon.CreateCommand()
            Try
                sqlcon.Open()
                sqlcom.CommandText = pQuery
                If Not IsNothing(pPara) Then
                    sqlcom.Parameters.AddRange(pPara)
                End If
                kq = sqlcom.ExecuteScalar
                sqlcom.Parameters.Clear()
            Catch ex As Exception
                sqlcom.Parameters.Clear()
                MsgBox(ex.Message)
            End Try
        End Using
        Return kq
    End Function

    Public Function ExeNonequery(pQuery As String, ParamArray pPara() As SqlParameter) As Boolean
        Using sqlcon As New SqlConnection(CnStr)
            Dim sqlcom As SqlCommand = sqlcon.CreateCommand()
            Try
                sqlcon.Open()
                sqlcom.CommandText = pQuery
                If Not IsNothing(pPara) Then
                    sqlcom.Parameters.AddRange(pPara)
                End If
                sqlcom.ExecuteNonQuery()
                sqlcom.Parameters.Clear()
                Return True
            Catch ex As Exception
                sqlcom.Parameters.Clear()
                MsgBox(ex.Message)
            End Try
        End Using
        Return False
    End Function

    Public Function FormatDigit(ByVal strValue) As String
        If (String.IsNullOrEmpty(strValue)) Then
            FormatDigit = "0"
        ElseIf InStr(strValue, ".") = 0 Then
            If (CStr(strValue) <> "0" And CStr(strValue) <> "-") Then
                FormatDigit = Convert.ToDecimal(strValue).ToString("#,##0")
            Else
                FormatDigit = strValue
            End If
        Else
            If InStr(strValue, ".00") > 0 Then
                FormatDigit = Convert.ToDecimal(strValue).ToString("#,##0")
            Else
                FormatDigit = Convert.ToDecimal(strValue).ToString("N")
            End If
        End If
    End Function

    Public Function CheckIsDigit(ByVal numChar As Integer) As Boolean
        CheckIsDigit = False
        If numChar <> 8 Then
            If numChar < 48 Or numChar > 57 Then
                CheckIsDigit = True
            End If
        End If
    End Function

    Public Function GenerateRandomString(ByRef len As Integer, ByRef upper As Boolean) As String
        Dim rand As New Random()
        Dim allowableChars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim final As String = String.Empty
        For i As Integer = 0 To len - 1
            final += allowableChars(rand.Next(allowableChars.Length - 1))
        Next

        Return IIf(upper, final.ToUpper(), final)
    End Function

    Public Sub FtpUploadFile(ByVal filetoupload As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        ' Create a web request that will be used to talk with the server and set the request method to upload a file by ftp.
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri), FtpWebRequest)

        Try
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile

            ' Confirm the Network credentials based on the user name and password passed in.
            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            ' Read into a Byte array the contents of the file to be uploaded 
            Dim bytes() As Byte = System.IO.File.ReadAllBytes(filetoupload)

            ' Transfer the byte array contents into the request stream, write and then close when done.
            ftpRequest.ContentLength = bytes.Length
            Using UploadStream As Stream = ftpRequest.GetRequestStream()
                UploadStream.Write(bytes, 0, bytes.Length)
                UploadStream.Close()
            End Using
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub FTPDownloadFile(ByVal downloadpath As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        'Create a WebClient.
        Dim request As New WebClient()

        ' Confirm the Network credentials based on the user name and password passed in.
        request.Credentials = New NetworkCredential(ftpusername, ftppassword)

        'Read the file data into a Byte array
        Dim bytes() As Byte = request.DownloadData(ftpuri)

        Try
            '  Create a FileStream to read the file into
            Dim DownloadStream As FileStream = IO.File.Create(downloadpath)
            '  Stream this data into the file
            DownloadStream.Write(bytes, 0, bytes.Length)
            '  Close the FileStream
            DownloadStream.Close()

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub FtpDeleteFile(ByVal filetodelete As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        ' Create a web request that will be used to talk with the server and set the request method to delete a file by ftp.
        Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(ftpuri & "/" & filetodelete), FtpWebRequest)

        Try
            ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile

            ' Confirm the Network credentials based on the user name and password passed in.
            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)

            ' Send the request and wait for a response.
            Using response As FtpWebResponse = CType(ftpRequest.GetResponse(), FtpWebResponse)
            End Using
        Catch ex As System.Exception
            'MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub GhiLog(TableName As String, RecID As Integer)
        ExeNonequery("Insert ActionLog (TableName, JsonLog) SELECT '" & TableName & "', CONCAT('',(select *,  getdate() LstUpdate, '" & myStaff.UserID & "' LstUser From " & TableName & " where RecID=" & RecID & " for json path), '') AS JsonOutput")
    End Sub

    Public Function LuuJSON(obj As String, value As String) As String
        Dim Result As String = ""
        If IsNumeric(value) = True Then
            Result = """" & obj & """:" & value
        Else
            Result = """" & obj & """:""" & value & """"
        End If
        Return Result
    End Function

    Public Sub InsertFtpFile(TableName As String, TableID As Integer, FileName As String, FilePath As String)
        Dim Para() As SqlParameter
        Para = New SqlParameter() _
            {
                New SqlParameter("@TableName", TableName),
                New SqlParameter("@TableID", TableID),
                New SqlParameter("@FileName", FileName),
                New SqlParameter("@FilePath", FilePath),
                New SqlParameter("@FstUser", myStaff.UserID)
            }
        ExeNonequery("Insert FtpFile (TableName, TableID, FileName, FilePath, FstUser) values (@TableName, @TableID, @FileName, @FilePath, @FstUser)", Para)
    End Sub

    Public Sub CallXlsReport(ByVal strFileName As String, ByVal parViewPrint As String, pConStr As String,
       ByVal str1 As String, Optional ByVal str2 As String = "", Optional ByVal str3 As String = "",
       Optional ByVal str4 As String = "", Optional ByVal str5 As String = "", Optional ByVal str6 As String = "",
       Optional ByVal str7 As String = "", Optional ByVal str8 As String = "", Optional ByVal str9 As String = "",
       Optional ByVal str10 As String = "", Optional ByVal str11 As String = "", Optional ByVal str12 As String = "",
       Optional pWkSheet As String = "RPT", Optional CallWkSheetToView As Boolean = True)

        If InStr("PEVO", parViewPrint) = 0 Or strFileName = "" Then Exit Sub

        Dim AppXls As Microsoft.Office.Interop.Excel.Application, WkBook As Microsoft.Office.Interop.Excel.Workbook, WkSheet As Microsoft.Office.Interop.Excel.Worksheet
        On Error Resume Next
        AppXls = CreateObject("Excel.Application")
        On Error GoTo 0
        WkBook = AppXls.Workbooks.Open(Application.StartupPath & "\" & strFileName, , , , "RPT1234", , , , , True)
        WkSheet = WkBook.Worksheets("Para")
        If str1 <> "" Then WkSheet.Cells(1, 2) = str1
        If str2 <> "" Then WkSheet.Cells(2, 2) = str2
        If str3 <> "" Then WkSheet.Cells(3, 2) = str3
        If str4 <> "" Then WkSheet.Cells(4, 2) = str4
        If str5 <> "" Then WkSheet.Cells(5, 2) = str5
        If str6 <> "" Then WkSheet.Cells(6, 2) = str6
        If str7 <> "" Then WkSheet.Cells(7, 2) = str7
        If str8 <> "" Then WkSheet.Cells(8, 2) = str8
        If str9 <> "" Then WkSheet.Cells(9, 2) = str9
        If str10 <> "" Then WkSheet.Cells(10, 2) = str10
        If str11 <> "" Then WkSheet.Cells(11, 2) = str11
        If str12 <> "" Then WkSheet.Cells(12, 2) = str12
        WkSheet.Cells(13, 2) = pConStr
        WkSheet.Cells(15, 2) = parViewPrint
        If CallWkSheetToView = True Then
            WkSheet = WkBook.Worksheets(pWkSheet)
            If parViewPrint = "V" Then
                AppXls.Visible = True
                WkSheet.PrintPreview(vbNo)
            ElseIf parViewPrint = "P" Then
                AppXls.Visible = True
                WkSheet.PrintPreview(vbNo)
            ElseIf parViewPrint = "O" Then
                AppXls.Visible = False
                WkSheet.PrintOut()
            End If
        Else
            'phần này để chạy report nhiều sheet ko bị lỗi
        End If
CloseXLS:
        WkBook.Close(SaveChanges:=False)
        AppXls.Quit()
        releaseObject(AppXls)
        releaseObject(WkBook)
        AppXls = Nothing
        On Error GoTo 0
    End Sub

    Public Sub CallExcelFile(FileName As String, PSW As String)
        Dim AppXls As Microsoft.Office.Interop.Excel.Application, WkBook As Microsoft.Office.Interop.Excel.Workbook, WkSheet As Microsoft.Office.Interop.Excel.Worksheet
        On Error Resume Next
        AppXls = CreateObject("Excel.Application")
        On Error GoTo 0
        WkBook = AppXls.Workbooks.Open(Application.StartupPath & "\" & FileName, Password:="RPT1234", Editable:=True)
        AppXls.Visible = True
    End Sub

    Public Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As System.Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module

