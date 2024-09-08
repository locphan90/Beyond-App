Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.ConnectionString = CnStr
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Office\11.0\Excel\Security\FileValidation", "EnableOnLoad", 0, Microsoft.Win32.RegistryValueKind.DWord)
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Office\12.0\Excel\Security\FileValidation", "EnableOnLoad", 0, Microsoft.Win32.RegistryValueKind.DWord)
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Office\13.0\Excel\Security\FileValidation", "EnableOnLoad", 0, Microsoft.Win32.RegistryValueKind.DWord)
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Office\14.0\Excel\Security\FileValidation", "EnableOnLoad", 0, Microsoft.Win32.RegistryValueKind.DWord)
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Office\15.0\Excel\Security\FileValidation", "EnableOnLoad", 0, Microsoft.Win32.RegistryValueKind.DWord)
        Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Office\16.0\Excel\Security\FileValidation", "EnableOnLoad", 0, Microsoft.Win32.RegistryValueKind.DWord)
        LogIn_Out()
        Dim FolderPath = Application.StartupPath & "\FilesBeyond"
        If Not System.IO.Directory.Exists(FolderPath) Then
            System.IO.Directory.CreateDirectory(FolderPath)
        End If
        Me.WindowState = FormWindowState.Maximized
        BarDangNhap_Click(sender, e)
        pnlDeadline.Top = 32
        pnlDeadline.Left = Screen.PrimaryScreen.WorkingArea.Width - 300
    End Sub

    Public Sub LogIn_Out()
        For Each MnuPad In Me.MenuControl.Items
            If MnuPad.ToString <> "User" Then
                MnuPad.Enabled = False
                For Each MnuBar In MnuPad.DropDownItems
                    MnuBar.enabled = False
                Next
            End If
        Next

        BarDangNhap.Text = "Log in"
        BarDoiMatKhau.Visible = False
        pnlDeadline.Visible = False
    End Sub

    Public Function GetMdiClientWindow() As MdiClient
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                Return CType(ctl, MdiClient)
            End If
        Next ctl
        Return Nothing
    End Function


    Private Sub BarDangNhap_Click(sender As Object, e As EventArgs) Handles BarDangNhap.Click
        If BarDangNhap.Text = "Log in" Then
            Dim isOpened As Boolean = False
            For Each frm As Form In Application.OpenForms
                If frm.Name.Equals("FrmLogIn") Then
                    isOpened = True
                    frm.Close()
                    Exit For
                End If
            Next
            If isOpened = False Then
                Dim f As New FrmLogIn
                f.MdiParent = Me
                f.StartPosition = FormStartPosition.CenterScreen
                f.Show()
            End If
        Else
            LogIn_Out()
        End If
    End Sub

    Private Sub PadQuanLyUser_Click(sender As Object, e As EventArgs) Handles PadUserManagement.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("FrmUserRight") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New FrmUserRight
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarDoiMatKhau_Click(sender As Object, e As EventArgs) Handles BarDoiMatKhau.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("FrmDoiMatKhau") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New FrmDoiMatKhau
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarAirRail_Click(sender As Object, e As EventArgs) Handles BarAirRail.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_AirRail") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_AirRail
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarCustomer_Click(sender As Object, e As EventArgs) Handles BarCustomer.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_Customer") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_Customer
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarSupplier_Click(sender As Object, e As EventArgs) Handles BarSupplier.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_Supplier") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_Supplier
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarAccTopUp_Click(sender As Object, e As EventArgs) Handles BarAccTopUp.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Acc_TopUp") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Acc_TopUp
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarCustomerPayment_Click(sender As Object, e As EventArgs) Handles BarCustomerPayment.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Acc_ConfirmCustPayment") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Acc_ConfirmCustPayment
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarLandSetting_Click(sender As Object, e As EventArgs) Handles BarLandSetting.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_LandSetting") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_LandSetting
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarCharterBuy_Click(sender As Object, e As EventArgs) Handles BarCharterBuy.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_CharterBuy") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_CharterBuy
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarSupplierPayment_Click(sender As Object, e As EventArgs) Handles BarSupplierPayment.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_SupplierPayment") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_SupplierPayment
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarAccSupplierPayment_Click(sender As Object, e As EventArgs) Handles BarAccSupplierPayment.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Acc_ConfirmSupPayment") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Acc_ConfirmSupPayment
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarGroup_Click(sender As Object, e As EventArgs) Handles BarGroup.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_Group") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_Group
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub BarDeadlineToFollow_Click(sender As Object, e As EventArgs) Handles BarDeadlineToFollow.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_Deadline") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_Deadline
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Public Sub LoadGridDeadline()
        Dim dtl As DataTable = GetDataTable("Select d.Type, PNR, d.Deadline, CustName, ContractNo, d.RecID from Deadline d left join GroupTicketing g on g.RecID=d.GroupTicketingID left join Customer c on c.recid=g.CustID where d.status='QQ' and Deadline='" & Format(Date.Now, "ddMMMyyyy") & "' and d.FstUser=" & myStaff.UserID)
        If dtl.Rows.Count > 0 Then
            pnlDeadline.Visible = True
            GridDeadline.DataSource = dtl
            GridDeadline.Columns("RecID").Visible = False
            GridDeadline.Columns("Type").Width = 100
            GridDeadline.Columns("PNR").Width = 50
            GridDeadline.Columns("Deadline").Width = 60
            GridDeadline.Columns("CustName").Width = 100
            GridDeadline.Columns("ContractNo").Width = 100
            GridDeadline.Columns("Deadline").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            GridDeadline.Columns("Deadline").DefaultCellStyle.Format = "dd-MMM-yy"
        Else
            pnlDeadline.Visible = False
        End If

    End Sub

    Private Sub tmrDeadline_Tick(sender As Object, e As EventArgs) Handles tmrDeadline.Tick
        tmrDeadline.Enabled = False
        LoadGridDeadline()
        tmrDeadline.Enabled = True
    End Sub

    Private Sub lklRefresh_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklRefresh.LinkClicked
        LoadGridDeadline()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If GridDeadline.RowCount > 0 Then
            ExeNonequery("Update Deadline set Status='OK' where RecID=" & GridDeadline.CurrentRow.Cells("RecID").Value)
            GhiLog("Deadline", GridDeadline.CurrentRow.Cells("RecID").Value)
            LoadGridDeadline()
        End If
    End Sub

    Private Sub BarCharterSell_Click(sender As Object, e As EventArgs) Handles BarCharterSell.Click
        Dim isOpened As Boolean = False
        For Each frm As Form In Application.OpenForms
            If frm.Name.Equals("Ticketing_CharterCode") Then
                isOpened = True
                frm.Close()
                Exit For
            End If
        Next
        If isOpened = False Then
            Dim f As New Ticketing_CharterCode
            f.MdiParent = Me
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub
End Class
