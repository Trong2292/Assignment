<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMLOAISANPHAM
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LSVLOAISANPHAM = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNXOA = New System.Windows.Forms.Button()
        Me.BTNSUA = New System.Windows.Forms.Button()
        Me.BTNTHEM = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTMOTALOAI = New System.Windows.Forms.TextBox()
        Me.TXTTENLOAISANPHAM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTMALOAISANPHAM = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LSVLOAISANPHAM)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 396)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOẠI SẢN PHẨM"
        '
        'LSVLOAISANPHAM
        '
        Me.LSVLOAISANPHAM.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LSVLOAISANPHAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.LSVLOAISANPHAM.FullRowSelect = True
        Me.LSVLOAISANPHAM.GridLines = True
        Me.LSVLOAISANPHAM.Location = New System.Drawing.Point(6, 21)
        Me.LSVLOAISANPHAM.Name = "LSVLOAISANPHAM"
        Me.LSVLOAISANPHAM.Size = New System.Drawing.Size(694, 369)
        Me.LSVLOAISANPHAM.TabIndex = 1
        Me.LSVLOAISANPHAM.UseCompatibleStateImageBehavior = False
        Me.LSVLOAISANPHAM.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "MÃ LOẠI"
        Me.ColumnHeader6.Width = 146
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TÊN LOẠI"
        Me.ColumnHeader7.Width = 274
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "MÔ TẢ"
        Me.ColumnHeader8.Width = 270
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNXOA)
        Me.GroupBox1.Controls.Add(Me.BTNSUA)
        Me.GroupBox1.Controls.Add(Me.BTNTHEM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXTMOTALOAI)
        Me.GroupBox1.Controls.Add(Me.TXTMALOAISANPHAM)
        Me.GroupBox1.Controls.Add(Me.TXTTENLOAISANPHAM)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(725, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 396)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'BTNXOA
        '
        Me.BTNXOA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTNXOA.ForeColor = System.Drawing.Color.Blue
        Me.BTNXOA.Location = New System.Drawing.Point(285, 292)
        Me.BTNXOA.Name = "BTNXOA"
        Me.BTNXOA.Size = New System.Drawing.Size(84, 34)
        Me.BTNXOA.TabIndex = 15
        Me.BTNXOA.Text = "XÓA"
        Me.BTNXOA.UseVisualStyleBackColor = True
        '
        'BTNSUA
        '
        Me.BTNSUA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTNSUA.ForeColor = System.Drawing.Color.Blue
        Me.BTNSUA.Location = New System.Drawing.Point(175, 292)
        Me.BTNSUA.Name = "BTNSUA"
        Me.BTNSUA.Size = New System.Drawing.Size(84, 34)
        Me.BTNSUA.TabIndex = 16
        Me.BTNSUA.Text = "SỬA"
        Me.BTNSUA.UseVisualStyleBackColor = True
        '
        'BTNTHEM
        '
        Me.BTNTHEM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTNTHEM.ForeColor = System.Drawing.Color.Blue
        Me.BTNTHEM.Location = New System.Drawing.Point(71, 292)
        Me.BTNTHEM.Name = "BTNTHEM"
        Me.BTNTHEM.Size = New System.Drawing.Size(84, 34)
        Me.BTNTHEM.TabIndex = 17
        Me.BTNTHEM.Text = "THÊM"
        Me.BTNTHEM.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(108, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "MÔ TẢ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "TÊN LOẠI SẢN PHẨM"
        '
        'TXTMOTALOAI
        '
        Me.TXTMOTALOAI.Location = New System.Drawing.Point(175, 109)
        Me.TXTMOTALOAI.Multiline = True
        Me.TXTMOTALOAI.Name = "TXTMOTALOAI"
        Me.TXTMOTALOAI.Size = New System.Drawing.Size(248, 148)
        Me.TXTMOTALOAI.TabIndex = 7
        '
        'TXTTENLOAISANPHAM
        '
        Me.TXTTENLOAISANPHAM.Location = New System.Drawing.Point(175, 71)
        Me.TXTTENLOAISANPHAM.Name = "TXTTENLOAISANPHAM"
        Me.TXTTENLOAISANPHAM.Size = New System.Drawing.Size(248, 25)
        Me.TXTTENLOAISANPHAM.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "MÃ LOẠI SẢN PHẨM"
        '
        'TXTMALOAISANPHAM
        '
        Me.TXTMALOAISANPHAM.Location = New System.Drawing.Point(175, 40)
        Me.TXTMALOAISANPHAM.Name = "TXTMALOAISANPHAM"
        Me.TXTMALOAISANPHAM.ReadOnly = True
        Me.TXTMALOAISANPHAM.Size = New System.Drawing.Size(248, 25)
        Me.TXTMALOAISANPHAM.TabIndex = 10
        '
        'FRMLOAISANPHAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1173, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FRMLOAISANPHAM"
        Me.Text = "LOẠI SẢN PHẨM"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LSVLOAISANPHAM As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNXOA As System.Windows.Forms.Button
    Friend WithEvents BTNSUA As System.Windows.Forms.Button
    Friend WithEvents BTNTHEM As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTMOTALOAI As System.Windows.Forms.TextBox
    Friend WithEvents TXTTENLOAISANPHAM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTMALOAISANPHAM As System.Windows.Forms.TextBox
End Class
