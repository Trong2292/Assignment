Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class FRMSANPHAM
    Dim ketnoi As New SqlConnection("workstation id=trongvdpk00309.mssql.somee.com;packet size=4096;user id=trongvd;pwd=abcd1234;data source=trongvdpk00309.mssql.somee.com;persist security info=False;initial catalog=trongvdpk00309")
    Public Property Value As String
    Private Sub FRMSANPHAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LAYTHONGTINLOAISANPHAM()
        LAYTHONGTINSANPHAM()
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
    Private Sub LAYTHONGTINSANPHAM()
        ketnoi.Open()
        Dim truyvansp As New SqlCommand("select * from SanPham left join LoaiSanPham on SanPham.MaLsp = LoaiSanPham.MaLsp", ketnoi)
        Dim sqladaptor As New SqlDataAdapter(truyvansp)
        Dim dulieubangsanpham As New DataTable
        Dim i As Integer
        sqladaptor.Fill(dulieubangsanpham)
        ketnoi.Close()
        LSVSANPHAM.Items.Clear()

        For Each cot As DataRow In dulieubangsanpham.Rows
            LSVSANPHAM.Items.Add(cot("MaSp").ToString())
            LSVSANPHAM.Items(i).SubItems.Add(cot("TenSp").ToString())
            LSVSANPHAM.Items(i).SubItems.Add(cot("TenLsp").ToString())
            LSVSANPHAM.Items(i).SubItems.Add(cot("DongiaSP").ToString())
            LSVSANPHAM.Items(i).SubItems.Add(cot("MotaSP").ToString())
            i += 1
        Next
    End Sub

    Private Sub BTNTHEM_Click(sender As Object, e As EventArgs) Handles BTNTHEM.Click
        Try
            Dim TENSANPHAM As String = TXTTENSANPHAM.Text
            Dim motasp As String = TXTMOTA.Text
            Dim dongia As String = TXTDONGIA.Text
            Dim maloaisp As String = TXTLOAISANPHAM.Text

            Dim truyvan2 As String = "insert into SANPHAM (TenSp,MaLsp,DongiaSP,MotaSP) Values(N'" + TENSANPHAM + "','" + maloaisp + "','" + dongia + "',N'" + motasp + "')"
            thucthi(truyvan2)

            MessageBox.Show("Nhập Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LAYTHONGTINSANPHAM()
            TXTTENSANPHAM.Text = ""
            TXTMOTA.Text = ""
            TXTLOAISANPHAM.Text = ""
            TXTDONGIA.Text = ""

        Catch ex As Exception
            MessageBox.Show("Nhập Dữ Liệu Không Thành Công, Vui Lòng Kiểm Tra Lại Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub LSVSANPHAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSVSANPHAM.SelectedIndexChanged
        For Each dsachsp As ListViewItem In LSVSANPHAM.SelectedItems
            txtmasanpham.Text = dsachsp.SubItems(0).Text
            TXTTENSANPHAM.Text = dsachsp.SubItems(1).Text
            TXTLOAISANPHAM.Text = dsachsp.SubItems(2).Text
            TXTDONGIA.Text = dsachsp.SubItems(3).Text
            TXTMOTA.Text = dsachsp.SubItems(4).Text
        Next
    End Sub

    Private Sub BTNSUA_Click(sender As Object, e As EventArgs) Handles BTNSUA.Click
        Try
            Dim masp As String = TXTMASANPHAM.Text
            Dim TENSANPHAM As String = TXTTENSANPHAM.Text
            Dim loaisp As String = TXTLOAISANPHAM.Text
            Dim dongia As String = TXTDONGIA.Text
            Dim motasp As String = TXTMOTA.Text

            ketnoi.Open()
            Dim sualsp As New SqlCommand("update SanPham set TenSP = N'" + TENSANPHAM + "', MaLsp = '" + loaisp + "', DongiaSP = '" + dongia + "', MotaSP = '" + motasp + "' where MaSp = '" + masp + "'", ketnoi)
            sualsp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LAYTHONGTINSANPHAM()
            TXTMASANPHAM.Text = ""
            TXTTENSANPHAM.Text = ""
            TXTMOTA.Text = ""
            TXTLOAISANPHAM.Text = ""
            TXTDONGIA.Text = ""
        Catch ex As Exception
            MessageBox.Show("Sửa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BTNXOA_Click(sender As Object, e As EventArgs) Handles BTNXOA.Click
        Try

            Dim MASANPHAM As String = TXTMASANPHAM.Text

            ketnoi.Open()
            Dim xoasp As New SqlCommand(" DELETE FROM SanPham WHERE Masp = '" + MASANPHAM + "'", ketnoi)
            xoasp.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LAYTHONGTINSANPHAM()

            TXTMASANPHAM.Text = ""
            TXTTENSANPHAM.Text = ""
            TXTMOTA.Text = ""
            TXTLOAISANPHAM.Text = ""
            TXTDONGIA.Text = ""
        Catch ex As Exception
            MessageBox.Show("Xóa Dữ Liệu Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
