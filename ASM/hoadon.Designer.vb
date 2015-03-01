<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhoadon
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
        Me.txtxoa = New System.Windows.Forms.Button()
        Me.txtsua = New System.Windows.Forms.Button()
        Me.txtthem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmota = New System.Windows.Forms.TextBox()
        Me.txtngaylap = New System.Windows.Forms.TextBox()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvkhachhang = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvhoadon = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'txtxoa
        '
        Me.txtxoa.Location = New System.Drawing.Point(985, 160)
        Me.txtxoa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtxoa.Name = "txtxoa"
        Me.txtxoa.Size = New System.Drawing.Size(100, 43)
        Me.txtxoa.TabIndex = 19
        Me.txtxoa.Text = "Xóa"
        Me.txtxoa.UseVisualStyleBackColor = True
        '
        'txtsua
        '
        Me.txtsua.Location = New System.Drawing.Point(877, 160)
        Me.txtsua.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsua.Name = "txtsua"
        Me.txtsua.Size = New System.Drawing.Size(100, 43)
        Me.txtsua.TabIndex = 20
        Me.txtsua.Text = "Sửa"
        Me.txtsua.UseVisualStyleBackColor = True
        '
        'txtthem
        '
        Me.txtthem.Location = New System.Drawing.Point(768, 160)
        Me.txtthem.Margin = New System.Windows.Forms.Padding(4)
        Me.txtthem.Name = "txtthem"
        Me.txtthem.Size = New System.Drawing.Size(100, 43)
        Me.txtthem.TabIndex = 21
        Me.txtthem.Text = "Thêm"
        Me.txtthem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(819, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Mô Tả"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(799, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Ngày Lập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(751, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(779, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'txtmota
        '
        Me.txtmota.Location = New System.Drawing.Point(877, 107)
        Me.txtmota.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmota.Multiline = True
        Me.txtmota.Name = "txtmota"
        Me.txtmota.Size = New System.Drawing.Size(208, 50)
        Me.txtmota.TabIndex = 11
        '
        'txtngaylap
        '
        Me.txtngaylap.Location = New System.Drawing.Point(877, 77)
        Me.txtngaylap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtngaylap.Name = "txtngaylap"
        Me.txtngaylap.Size = New System.Drawing.Size(208, 22)
        Me.txtngaylap.TabIndex = 12
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(877, 45)
        Me.txttenkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(208, 22)
        Me.txttenkhachhang.TabIndex = 13
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(877, 13)
        Me.txtmahoadon.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.ReadOnly = True
        Me.txtmahoadon.Size = New System.Drawing.Size(208, 22)
        Me.txtmahoadon.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(712, 569)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Hóa Đơn"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tên Khách Hàng"
        Me.ColumnHeader6.Width = 127
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Mã Khách Hàng"
        Me.ColumnHeader5.Width = 95
        '
        'lsvkhachhang
        '
        Me.lsvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvkhachhang.FullRowSelect = True
        Me.lsvkhachhang.GridLines = True
        Me.lsvkhachhang.Location = New System.Drawing.Point(769, 241)
        Me.lsvkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvkhachhang.Name = "lsvkhachhang"
        Me.lsvkhachhang.Size = New System.Drawing.Size(300, 319)
        Me.lsvkhachhang.TabIndex = 8
        Me.lsvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lsvkhachhang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Mô Tả"
        Me.ColumnHeader4.Width = 168
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ngày Lập"
        Me.ColumnHeader3.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên Khách Hàng"
        Me.ColumnHeader2.Width = 149
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã Hóa Đơn"
        Me.ColumnHeader1.Width = 86
        '
        'lsvhoadon
        '
        Me.lsvhoadon.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvhoadon.FullRowSelect = True
        Me.lsvhoadon.GridLines = True
        Me.lsvhoadon.Location = New System.Drawing.Point(21, 37)
        Me.lsvhoadon.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvhoadon.Name = "lsvhoadon"
        Me.lsvhoadon.Size = New System.Drawing.Size(687, 521)
        Me.lsvhoadon.TabIndex = 7
        Me.lsvhoadon.UseCompatibleStateImageBehavior = False
        Me.lsvhoadon.View = System.Windows.Forms.View.Details
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(753, 217)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(335, 365)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông Tin Khách Hàng"
        '
        'frmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 582)
        Me.Controls.Add(Me.txtxoa)
        Me.Controls.Add(Me.txtsua)
        Me.Controls.Add(Me.txtthem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmota)
        Me.Controls.Add(Me.txtngaylap)
        Me.Controls.Add(Me.txttenkhachhang)
        Me.Controls.Add(Me.txtmahoadon)
        Me.Controls.Add(Me.lsvkhachhang)
        Me.Controls.Add(Me.lsvhoadon)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmhoadon"
        Me.Text = "Hóa Đơn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtxoa As System.Windows.Forms.Button
    Friend WithEvents txtsua As System.Windows.Forms.Button
    Friend WithEvents txtthem As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmota As System.Windows.Forms.TextBox
    Friend WithEvents txtngaylap As System.Windows.Forms.TextBox
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvhoadon As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
