<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HÓAĐƠNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SẢNPHẨMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOẠISẢNPHẨMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KHÁCHHÀNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.THOÁTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CHITIẾTHÓAĐƠNToolStripMenuItem, Me.HÓAĐƠNToolStripMenuItem, Me.SẢNPHẨMToolStripMenuItem, Me.LOẠISẢNPHẨMToolStripMenuItem, Me.KHÁCHHÀNGToolStripMenuItem, Me.THOÁTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(895, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HÓAĐƠNToolStripMenuItem
        '
        Me.HÓAĐƠNToolStripMenuItem.Name = "HÓAĐƠNToolStripMenuItem"
        Me.HÓAĐƠNToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.HÓAĐƠNToolStripMenuItem.Text = "HÓA ĐƠN"
        '
        'SẢNPHẨMToolStripMenuItem
        '
        Me.SẢNPHẨMToolStripMenuItem.Name = "SẢNPHẨMToolStripMenuItem"
        Me.SẢNPHẨMToolStripMenuItem.Size = New System.Drawing.Size(96, 24)
        Me.SẢNPHẨMToolStripMenuItem.Text = "SẢN PHẨM"
        '
        'LOẠISẢNPHẨMToolStripMenuItem
        '
        Me.LOẠISẢNPHẨMToolStripMenuItem.Name = "LOẠISẢNPHẨMToolStripMenuItem"
        Me.LOẠISẢNPHẨMToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.LOẠISẢNPHẨMToolStripMenuItem.Text = "LOẠI SẢN PHẨM"
        '
        'KHÁCHHÀNGToolStripMenuItem
        '
        Me.KHÁCHHÀNGToolStripMenuItem.Name = "KHÁCHHÀNGToolStripMenuItem"
        Me.KHÁCHHÀNGToolStripMenuItem.Size = New System.Drawing.Size(117, 24)
        Me.KHÁCHHÀNGToolStripMenuItem.Text = "KHÁCH HÀNG"
        '
        'THOÁTToolStripMenuItem
        '
        Me.THOÁTToolStripMenuItem.Name = "THOÁTToolStripMenuItem"
        Me.THOÁTToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.THOÁTToolStripMenuItem.Text = "THOÁT"
        '
        'CHITIẾTHÓAĐƠNToolStripMenuItem
        '
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem.Name = "CHITIẾTHÓAĐƠNToolStripMenuItem"
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.CHITIẾTHÓAĐƠNToolStripMenuItem.Text = "CHI TIẾT HÓA ĐƠN"
        '
        'FRMMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 484)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRMMAIN"
        Me.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SẢNPHẨMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOẠISẢNPHẨMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents THOÁTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HÓAĐƠNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KHÁCHHÀNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CHITIẾTHÓAĐƠNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
