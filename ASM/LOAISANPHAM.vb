Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class FRMLOAISANPHAM
    Dim ketnoi As New SqlConnection("Data Source=KY0SHIR0-PC\SQLEXPRESS;Initial Catalog=qlybanhang;Integrated Security=True")
    Public Property Value As String
    Private Sub FRMLOAISANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LAYTHONGTINLOAISANPHAM()
    End Sub
    Private Sub thucthi(str As String)
        ketnoi.Open()
        Dim com As New SqlCommand(str, ketnoi)
        com.ExecuteNonQuery()
        ketnoi.Close()
    End Sub
    Private Sub LAYTHONGTINLOAISANPHAM()
        ketnoi.Open()
        Dim truyvanlsp As New SqlCommand("select * from loaisanpham", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvanlsp)
        Dim dulieubanglsp As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubanglsp)
        ketnoi.Close()
        LSVLOAISANPHAM.Items.Clear()

        For Each cot As DataRow In dulieubanglsp.Rows
            LSVLOAISANPHAM.Items.Add(cot("MaLsp").ToString())
            LSVLOAISANPHAM.Items(i).SubItems.Add(cot("TenLsp").ToString())
            LSVLOAISANPHAM.Items(i).SubItems.Add(cot("MotaLsp").ToString())
            i += 1
        Next
    End Sub

    Private Sub BTNTHEM_Click(sender As Object, e As EventArgs) Handles BTNTHEM.Click
        Try


            Dim TENLOAISANPHAM As String = TXTTENLOAISANPHAM.Text
            Dim MOTA As String = TXTMOTALOAI.Text

            Dim truyvan1 As String = "insert into LOAISANPHAM (TenLsp,MotaLsp) Values(N'" + TENLOAISANPHAM + "',N'" + MOTA + "')"
            thucthi(truyvan1)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LAYTHONGTINLOAISANPHAM()


            TXTTENLOAISANPHAM.Text = ""
            TXTMOTALOAI.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BTNSUA_Click(sender As Object, e As EventArgs) Handles BTNSUA.Click
        Try
            Dim maloaisanpham As String = TXTMALOAISANPHAM.Text
            Dim tenloaisanpham As String = TXTTENLOAISANPHAM.Text
            Dim motaloaisanpham As String = TXTMOTALOAI.Text
            ketnoi.Open()
            Dim sualsp As New SqlCommand("update LoaiSanPham set TenLsp = N'" + tenloaisanpham + "', MotaLsp = '" + motaloaisanpham + "' where MaLsp = '" + maloaisanpham + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXTTENLOAISANPHAM.Text = ""
            TXTMOTALOAI.Text = ""
            TXTMALOAISANPHAM.Text = ""
            LAYTHONGTINLOAISANPHAM()
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BTNXOA_Click(sender As Object, e As EventArgs) Handles BTNXOA.Click

        Try

            Dim MALOAISANPHAM As String = TXTMALOAISANPHAM.Text

            ketnoi.Open()
            Dim xoalsp As New SqlCommand(" DELETE FROM LoaiSanPham WHERE MaLsp = '" + MALOAISANPHAM + "'", ketnoi)
            xoalsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXTTENLOAISANPHAM.Text = ""
            TXTMOTALOAI.Text = ""
            TXTMALOAISANPHAM.Text = ""
            LAYTHONGTINLOAISANPHAM()

        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub LSVLOAISANPHAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSVLOAISANPHAM.SelectedIndexChanged
        For Each dsachlsp As ListViewItem In LSVLOAISANPHAM.SelectedItems
            TXTMALOAISANPHAM.Text = dsachlsp.SubItems(0).Text
            TXTTENLOAISANPHAM.Text = dsachlsp.SubItems(1).Text
            TXTMOTALOAI.Text = dsachlsp.SubItems(2).Text
        Next
    End Sub
End Class