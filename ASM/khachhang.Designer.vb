<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkhachhang
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
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnsuakhachhang = New System.Windows.Forms.Button()
        Me.btnxoakhachhang = New System.Windows.Forms.Button()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsodienthoai = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lsvkhachhang = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.btnthemkhachhang = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Email"
        Me.ColumnHeader6.Width = 184
        '
        'btnsuakhachhang
        '
        Me.btnsuakhachhang.Location = New System.Drawing.Point(814, 154)
        Me.btnsuakhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsuakhachhang.Name = "btnsuakhachhang"
        Me.btnsuakhachhang.Size = New System.Drawing.Size(123, 48)
        Me.btnsuakhachhang.TabIndex = 14
        Me.btnsuakhachhang.Text = "Sửa"
        Me.btnsuakhachhang.UseVisualStyleBackColor = True
        '
        'btnxoakhachhang
        '
        Me.btnxoakhachhang.Location = New System.Drawing.Point(814, 79)
        Me.btnxoakhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnxoakhachhang.Name = "btnxoakhachhang"
        Me.btnxoakhachhang.Size = New System.Drawing.Size(123, 44)
        Me.btnxoakhachhang.TabIndex = 13
        Me.btnxoakhachhang.Text = "Xóa"
        Me.btnxoakhachhang.UseVisualStyleBackColor = True
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(128, 150)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(567, 22)
        Me.txtemail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(128, 118)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(567, 22)
        Me.txtdiachi.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Địa chỉ"
        '
        'txtsodienthoai
        '
        Me.txtsodienthoai.Location = New System.Drawing.Point(128, 86)
        Me.txtsodienthoai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsodienthoai.Name = "txtsodienthoai"
        Me.txtsodienthoai.Size = New System.Drawing.Size(567, 22)
        Me.txtsodienthoai.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Số điện thoại"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SĐT"
        Me.ColumnHeader4.Width = 156
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên khách hàng"
        Me.ColumnHeader2.Width = 126
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã khách hàng"
        Me.ColumnHeader1.Width = 87
        '
        'lsvkhachhang
        '
        Me.lsvkhachhang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvkhachhang.FullRowSelect = True
        Me.lsvkhachhang.GridLines = True
        Me.lsvkhachhang.Location = New System.Drawing.Point(13, 235)
        Me.lsvkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvkhachhang.MultiSelect = False
        Me.lsvkhachhang.Name = "lsvkhachhang"
        Me.lsvkhachhang.Size = New System.Drawing.Size(1005, 370)
        Me.lsvkhachhang.TabIndex = 5
        Me.lsvkhachhang.UseCompatibleStateImageBehavior = False
        Me.lsvkhachhang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Địa chỉ"
        Me.ColumnHeader5.Width = 196
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(128, 55)
        Me.txttenkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(567, 22)
        Me.txttenkhachhang.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tên khách hàng"
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(128, 23)
        Me.txtmakhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.ReadOnly = True
        Me.txtmakhachhang.Size = New System.Drawing.Size(567, 22)
        Me.txtmakhachhang.TabIndex = 2
        '
        'btnthemkhachhang
        '
        Me.btnthemkhachhang.Location = New System.Drawing.Point(814, 16)
        Me.btnthemkhachhang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnthemkhachhang.Name = "btnthemkhachhang"
        Me.btnthemkhachhang.Size = New System.Drawing.Size(123, 43)
        Me.btnthemkhachhang.TabIndex = 1
        Me.btnthemkhachhang.Text = "Thêm"
        Me.btnthemkhachhang.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã khách hàng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnsuakhachhang)
        Me.GroupBox1.Controls.Add(Me.btnxoakhachhang)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtsodienthoai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txttenkhachhang)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtmakhachhang)
        Me.GroupBox1.Controls.Add(Me.btnthemkhachhang)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 214)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin khách hàng"
        '
        'frmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 614)
        Me.Controls.Add(Me.lsvkhachhang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmkhachhang"
        Me.Text = "khachhang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnsuakhachhang As System.Windows.Forms.Button
    Friend WithEvents btnxoakhachhang As System.Windows.Forms.Button
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvkhachhang As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents btnthemkhachhang As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
