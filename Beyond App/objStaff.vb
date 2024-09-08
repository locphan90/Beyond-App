Public Class objStaff
    Dim _UserID As Integer
    Private _UserName As String
    Private _ChucVu As String
    Private _PhongBan As String
    Private _PSW As String
    Private _Phone As String


    Property UserID() As String
        Get
            Return _UserID
        End Get
        Set(ByVal UserID As String)
            _UserID = UserID
            Dim dTable As DataTable
            dTable = GetDataTable("select * from tblUser where RecID=" & _UserID & " and status='OK'")
            If dTable.Rows.Count = 0 Then
                Exit Property
            End If
            _ChucVu = dTable.Rows(0)("ChucVu")
            _UserName = dTable.Rows(0)("HoTen")
            _PSW = dTable.Rows(0)("PSW")
            _Phone = dTable.Rows(0)("Phone")
            _PhongBan = dTable.Rows(0)("PhongBan")
        End Set
    End Property

    ReadOnly Property UserName() As String
        Get
            Return _UserName
        End Get
    End Property

    ReadOnly Property ChucVu() As String
        Get
            Return _ChucVu
        End Get
    End Property

    ReadOnly Property PhongBan() As String
        Get
            Return _PhongBan
        End Get
    End Property

    ReadOnly Property PSW() As String
        Get
            Return _PSW
        End Get
    End Property

    ReadOnly Property Phone() As String
        Get
            Return _Phone
        End Get
    End Property


End Class
