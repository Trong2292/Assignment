Public Class FRMMAIN

    Private Sub SẢNPHẨMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SẢNPHẨMToolStripMenuItem.Click
        Dim SANPHAM = New FRMSANPHAM()
        SANPHAM.MdiParent = Me
        SANPHAM.Show()


    End Sub

    Private Sub THOÁTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles THOÁTToolStripMenuItem.Click
        If MsgBox("Bạn Chắc Chắn Sẽ Thoát Chương Trình ?", MsgBoxStyle.OkCancel, "Thông Báo") = MsgBoxResult.Ok Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub LOẠISẢNPHẨMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOẠISẢNPHẨMToolStripMenuItem.Click
        Dim LOAISANPHAM = New FRMLOAISANPHAM()
        LOAISANPHAM.MdiParent = Me
        LOAISANPHAM.Show()
    End Sub

    Private Sub KHÁCHHÀNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KHÁCHHÀNGToolStripMenuItem.Click
        Dim KH = New frmkhachhang()
        KH.MdiParent = Me
        KH.Show()
    End Sub

    Private Sub HÓAĐƠNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HÓAĐƠNToolStripMenuItem.Click
        Dim hD = New frmhoadon()
        hD.MdiParent = Me
        hD.Show()
    End Sub

    Private Sub CHITIẾTHÓAĐƠNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CHITIẾTHÓAĐƠNToolStripMenuItem.Click
        Dim CTHD = New frmchitiethoadon()
        CTHD.MdiParent = Me
        CTHD.Show()
    End Sub

    Private Sub FRMMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class