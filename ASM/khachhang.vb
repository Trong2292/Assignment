Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class frmkhachhang
    Dim ketnoi As New SqlConnection("workstation id=trongvdpk00309.mssql.somee.com;packet size=4096;user id=trongvd;pwd=abcd1234;data source=trongvdpk00309.mssql.somee.com;persist security info=False;initial catalog=trongvdpk00309")
    Public Property Value As String
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub frmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddulieukhachhang()
    End Sub
    Private Sub loaddulieukhachhang()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from KhachHang", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangkhachhang As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangkhachhang)
        ketnoi.Close()
        lsvkhachhang.Items.Clear()

        For Each cot As DataRow In dulieubangkhachhang.Rows
            lsvkhachhang.Items.Add(cot("MaKH").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("TenKH").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("SDT").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("DiachiKH").ToString())
            lsvkhachhang.Items(i).SubItems.Add(cot("Email").ToString())
            i += 1
        Next
    End Sub
    Private Sub btnthemkhachhang_Click(sender As Object, e As EventArgs) Handles btnthemkhachhang.Click
        Try


            Dim tenkh As String = txttenkhachhang.Text
            Dim sdt As String = txtsodienthoai.Text
            Dim diachi As String = txtdiachi.Text
            Dim mail As String = txtemail.Text

            Dim truyvan1 As String = "insert into KhachHang (TenKH,SDT,DiachiKH,Email) Values(N'" + tenkh + "',N'" + sdt + "',N'" + diachi + "',N'" + mail + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaddulieukhachhang()

            txttenkhachhang.Text = ""
            txtsodienthoai.Text = ""
            txtdiachi.Text = ""
            txtemail.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub lsvkhachhang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvkhachhang.SelectedIndexChanged
        For Each dsachsp As ListViewItem In lsvkhachhang.SelectedItems
            txtmakhachhang.Text = dsachsp.SubItems(0).Text
            txttenkhachhang.Text = dsachsp.SubItems(1).Text
            txtsodienthoai.Text = dsachsp.SubItems(2).Text
            txtdiachi.Text = dsachsp.SubItems(3).Text
            txtemail.Text = dsachsp.SubItems(4).Text
        Next
    End Sub

    Private Sub btnxoakhachhang_Click(sender As Object, e As EventArgs) Handles btnxoakhachhang.Click
        Try

            Dim makh As String = txtmakhachhang.Text

            ketnoi.Open()
            Dim xoakh As New SqlCommand(" DELETE FROM KhachHang WHERE MaKH = '" + makh + "'", ketnoi)
            xoakh.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieukhachhang()

        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnsuakhachhang_Click(sender As Object, e As EventArgs) Handles btnsuakhachhang.Click
        Try
            Dim makh As String = txtmakhachhang.Text
            Dim tenkh As String = txttenkhachhang.Text
            Dim sdt As String = txtsodienthoai.Text
            Dim diachi As String = txtdiachi.Text
            Dim mail As String = txtemail.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update KhachHang set TenKH = N'" + tenkh + "', SDT = '" + sdt + "', DiachiKH = '" + diachi + "', Email = '" + mail + "' where MaKH = '" + makh + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            loaddulieukhachhang()
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class