<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSANPHAM
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
        Me.LSVSANPHAM = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LSVLOAISANPHAM = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTTENSANPHAM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTLOAISANPHAM = New System.Windows.Forms.TextBox()
        Me.TXTDONGIA = New System.Windows.Forms.TextBox()
        Me.TXTMOTA = New System.Windows.Forms.TextBox()
        Me.BTNTHEM = New System.Windows.Forms.Button()
        Me.BTNSUA = New System.Windows.Forms.Button()
        Me.BTNXOA = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTMASANPHAM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LSVSANPHAM
        '
        Me.LSVSANPHAM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LSVSANPHAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSVSANPHAM.FullRowSelect = True
        Me.LSVSANPHAM.GridLines = True
        Me.LSVSANPHAM.Location = New System.Drawing.Point(6, 21)
        Me.LSVSANPHAM.Name = "LSVSANPHAM"
        Me.LSVSANPHAM.Size = New System.Drawing.Size(597, 672)
        Me.LSVSANPHAM.TabIndex = 0
        Me.LSVSANPHAM.UseCompatibleStateImageBehavior = False
        Me.LSVSANPHAM.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "MÃ SẢN PHẨM"
        Me.ColumnHeader1.Width = 108
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TÊN SẢN PHẨM"
        Me.ColumnHeader2.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "LOẠI SẢN PHẨM"
        Me.ColumnHeader3.Width = 116
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ĐƠN GIÁ"
        Me.ColumnHeader4.Width = 105
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MÔ TẢ"
        Me.ColumnHeader5.Width = 151
        '
        'LSVLOAISANPHAM
        '
        Me.LSVLOAISANPHAM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LSVLOAISANPHAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.LSVLOAISANPHAM.FullRowSelect = True
        Me.LSVLOAISANPHAM.GridLines = True
        Me.LSVLOAISANPHAM.Location = New System.Drawing.Point(6, 21)
        Me.LSVLOAISANPHAM.Name = "LSVLOAISANPHAM"
        Me.LSVLOAISANPHAM.Size = New System.Drawing.Size(354, 351)
        Me.LSVLOAISANPHAM.TabIndex = 1
        Me.LSVLOAISANPHAM.UseCompatibleStateImageBehavior = False
        Me.LSVLOAISANPHAM.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MÃ LOẠI"
        Me.ColumnHeader6.Width = 92
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TÊN LOẠI"
        Me.ColumnHeader7.Width = 92
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "MÔ TẢ"
        Me.ColumnHeader8.Width = 165
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LSVSANPHAM)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(610, 699)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SẢN PHẨM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LSVLOAISANPHAM)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(628, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 381)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOẠI SẢN PHẨM"
        '
        'TXTTENSANPHAM
        '
        Me.TXTTENSANPHAM.Location = New System.Drawing.Point(761, 450)
        Me.TXTTENSANPHAM.Name = "TXTTENSANPHAM"
        Me.TXTTENSANPHAM.Size = New System.Drawing.Size(227, 22)
        Me.TXTTENSANPHAM.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(644, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LOẠI SẢN PHẨM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(644, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ĐƠN GIÁ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(644, 546)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MÔ TẢ"
        '
        'TXTLOAISANPHAM
        '
        Me.TXTLOAISANPHAM.Location = New System.Drawing.Point(761, 482)
        Me.TXTLOAISANPHAM.Name = "TXTLOAISANPHAM"
        Me.TXTLOAISANPHAM.Size = New System.Drawing.Size(227, 22)
        Me.TXTLOAISANPHAM.TabIndex = 4
        '
        'TXTDONGIA
        '
        Me.TXTDONGIA.Location = New System.Drawing.Point(761, 514)
        Me.TXTDONGIA.Name = "TXTDONGIA"
        Me.TXTDONGIA.Size = New System.Drawing.Size(227, 22)
        Me.TXTDONGIA.TabIndex = 4
        '
        'TXTMOTA
        '
        Me.TXTMOTA.Location = New System.Drawing.Point(761, 546)
        Me.TXTMOTA.Multiline = True
        Me.TXTMOTA.Name = "TXTMOTA"
        Me.TXTMOTA.Size = New System.Drawing.Size(227, 61)
        Me.TXTMOTA.TabIndex = 4
        '
        'BTNTHEM
        '
        Me.BTNTHEM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTNTHEM.ForeColor = System.Drawing.Color.Blue
        Me.BTNTHEM.Location = New System.Drawing.Point(666, 643)
        Me.BTNTHEM.Name = "BTNTHEM"
        Me.BTNTHEM.Size = New System.Drawing.Size(84, 34)
        Me.BTNTHEM.TabIndex = 6
        Me.BTNTHEM.Text = "THÊM"
        Me.BTNTHEM.UseVisualStyleBackColor = True
        '
        'BTNSUA
        '
        Me.BTNSUA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTNSUA.ForeColor = System.Drawing.Color.Blue
        Me.BTNSUA.Location = New System.Drawing.Point(770, 643)
        Me.BTNSUA.Name = "BTNSUA"
        Me.BTNSUA.Size = New System.Drawing.Size(84, 34)
        Me.BTNSUA.TabIndex = 6
        Me.BTNSUA.Text = "SỬA"
        Me.BTNSUA.UseVisualStyleBackColor = True
        '
        'BTNXOA
        '
        Me.BTNXOA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTNXOA.ForeColor = System.Drawing.Color.Blue
        Me.BTNXOA.Location = New System.Drawing.Point(880, 643)
        Me.BTNXOA.Name = "BTNXOA"
        Me.BTNXOA.Size = New System.Drawing.Size(84, 34)
        Me.BTNXOA.TabIndex = 6
        Me.BTNXOA.Text = "XÓA"
        Me.BTNXOA.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXTMASANPHAM)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(628, 390)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(366, 321)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'TXTMASANPHAM
        '
        Me.TXTMASANPHAM.Location = New System.Drawing.Point(133, 24)
        Me.TXTMASANPHAM.Name = "TXTMASANPHAM"
        Me.TXTMASANPHAM.ReadOnly = True
        Me.TXTMASANPHAM.Size = New System.Drawing.Size(227, 25)
        Me.TXTMASANPHAM.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "MÃ SẢN PHẨM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TÊN SẢN PHẨM"
        '
        'FRMSANPHAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1006, 723)
        Me.Controls.Add(Me.BTNXOA)
        Me.Controls.Add(Me.BTNSUA)
        Me.Controls.Add(Me.BTNTHEM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTMOTA)
        Me.Controls.Add(Me.TXTDONGIA)
        Me.Controls.Add(Me.TXTLOAISANPHAM)
        Me.Controls.Add(Me.TXTTENSANPHAM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "FRMSANPHAM"
        Me.Text = "SẢN PHẨM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LSVSANPHAM As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LSVLOAISANPHAM As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTTENSANPHAM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXTLOAISANPHAM As System.Windows.Forms.TextBox
    Friend WithEvents TXTDONGIA As System.Windows.Forms.TextBox
    Friend WithEvents TXTMOTA As System.Windows.Forms.TextBox
    Friend WithEvents BTNTHEM As System.Windows.Forms.Button
    Friend WithEvents BTNSUA As System.Windows.Forms.Button
    Friend WithEvents BTNXOA As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTMASANPHAM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
