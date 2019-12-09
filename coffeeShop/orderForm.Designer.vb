<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.cItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cOriPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cItemCd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnSearchPoint = New System.Windows.Forms.Button()
        Me.rdoPayMoney = New System.Windows.Forms.RadioButton()
        Me.rdoPayCard = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSavePoint = New System.Windows.Forms.TextBox()
        Me.txtUsedPoint = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView4)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(426, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToResizeColumns = False
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItemName, Me.cPrice, Me.cCount, Me.cOriPrice, Me.cItemCd})
        Me.DataGridView4.Location = New System.Drawing.Point(5, 3)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowTemplate.Height = 27
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(416, 206)
        Me.DataGridView4.TabIndex = 4
        '
        'cItemName
        '
        Me.cItemName.FillWeight = 152.2843!
        Me.cItemName.HeaderText = "商品名"
        Me.cItemName.Name = "cItemName"
        Me.cItemName.ReadOnly = True
        '
        'cPrice
        '
        Me.cPrice.FillWeight = 94.81558!
        Me.cPrice.HeaderText = "価格"
        Me.cPrice.Name = "cPrice"
        Me.cPrice.ReadOnly = True
        '
        'cCount
        '
        Me.cCount.FillWeight = 52.90017!
        Me.cCount.HeaderText = "数量"
        Me.cCount.Name = "cCount"
        Me.cCount.ReadOnly = True
        Me.cCount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'cOriPrice
        '
        Me.cOriPrice.HeaderText = "原価"
        Me.cOriPrice.Name = "cOriPrice"
        Me.cOriPrice.ReadOnly = True
        Me.cOriPrice.Visible = False
        '
        'cItemCd
        '
        Me.cItemCd.HeaderText = "item_cd"
        Me.cItemCd.Name = "cItemCd"
        Me.cItemCd.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.btnSearchPoint)
        Me.GroupBox2.Controls.Add(Me.rdoPayMoney)
        Me.GroupBox2.Controls.Add(Me.rdoPayCard)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSavePoint)
        Me.GroupBox2.Controls.Add(Me.txtUsedPoint)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(425, 229)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(296, 174)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "決済金額"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(75, 145)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(211, 21)
        Me.txtTotal.TabIndex = 10
        '
        'btnSearchPoint
        '
        Me.btnSearchPoint.Location = New System.Drawing.Point(232, 51)
        Me.btnSearchPoint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearchPoint.Name = "btnSearchPoint"
        Me.btnSearchPoint.Size = New System.Drawing.Size(54, 20)
        Me.btnSearchPoint.TabIndex = 4
        Me.btnSearchPoint.Text = "照会"
        Me.btnSearchPoint.UseVisualStyleBackColor = True
        '
        'rdoPayMoney
        '
        Me.rdoPayMoney.AutoSize = True
        Me.rdoPayMoney.Location = New System.Drawing.Point(178, 85)
        Me.rdoPayMoney.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoPayMoney.Name = "rdoPayMoney"
        Me.rdoPayMoney.Size = New System.Drawing.Size(47, 16)
        Me.rdoPayMoney.TabIndex = 9
        Me.rdoPayMoney.Text = "現金"
        Me.rdoPayMoney.UseVisualStyleBackColor = True
        '
        'rdoPayCard
        '
        Me.rdoPayCard.AutoSize = True
        Me.rdoPayCard.Checked = True
        Me.rdoPayCard.Location = New System.Drawing.Point(108, 85)
        Me.rdoPayCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdoPayCard.Name = "rdoPayCard"
        Me.rdoPayCard.Size = New System.Drawing.Size(57, 16)
        Me.rdoPayCard.TabIndex = 8
        Me.rdoPayCard.TabStop = True
        Me.rdoPayCard.Text = "カード"
        Me.rdoPayCard.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "積み立てられるポイント"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "決済方法"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "使われるポイント"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "金額"
        '
        'txtSavePoint
        '
        Me.txtSavePoint.Location = New System.Drawing.Point(161, 114)
        Me.txtSavePoint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSavePoint.Name = "txtSavePoint"
        Me.txtSavePoint.Size = New System.Drawing.Size(126, 21)
        Me.txtSavePoint.TabIndex = 3
        '
        'txtUsedPoint
        '
        Me.txtUsedPoint.Enabled = False
        Me.txtUsedPoint.Location = New System.Drawing.Point(122, 51)
        Me.txtUsedPoint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsedPoint.Name = "txtUsedPoint"
        Me.txtUsedPoint.Size = New System.Drawing.Size(106, 21)
        Me.txtUsedPoint.TabIndex = 1
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(75, 20)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(211, 21)
        Me.txtAmount.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(50, 100)
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(410, 393)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(302, 385)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "コーヒー"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeight = 8
        Me.DataGridView1.Location = New System.Drawing.Point(5, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(304, 377)
        Me.DataGridView1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(104, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage2.Size = New System.Drawing.Size(302, 385)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "お茶"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(5, 5)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 27
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(307, 377)
        Me.DataGridView2.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(104, 4)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage3.Size = New System.Drawing.Size(302, 385)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "軽食"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(5, 5)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowTemplate.Height = 27
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(307, 377)
        Me.DataGridView3.TabIndex = 3
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPay.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnPay.Location = New System.Drawing.Point(726, 237)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(125, 101)
        Me.btnPay.TabIndex = 5
        Me.btnPay.Text = "決済"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(726, 342)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 60)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "取り消し"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'orderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 412)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "orderForm"
        Me.Text = "orderForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents txtSavePoint As TextBox
    Friend WithEvents txtUsedPoint As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoPayMoney As RadioButton
    Friend WithEvents rdoPayCard As RadioButton
    Friend WithEvents btnSearchPoint As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents cItemName As DataGridViewTextBoxColumn
    Friend WithEvents cPrice As DataGridViewTextBoxColumn
    Friend WithEvents cCount As DataGridViewTextBoxColumn
    Friend WithEvents cOriPrice As DataGridViewTextBoxColumn
    Friend WithEvents cItemCd As DataGridViewTextBoxColumn
End Class
