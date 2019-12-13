<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class itemMngForm
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtAreaEtc = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(520, 466)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 38)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "追加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Location = New System.Drawing.Point(775, 466)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(79, 38)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(690, 466)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(79, 38)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(488, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "数量"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(488, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "種類"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(488, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ETC"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.Cornsilk
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(599, 116)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(94, 25)
        Me.txtAmount.TabIndex = 15
        '
        'txtAreaEtc
        '
        Me.txtAreaEtc.Enabled = False
        Me.txtAreaEtc.Location = New System.Drawing.Point(562, 218)
        Me.txtAreaEtc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAreaEtc.Name = "txtAreaEtc"
        Me.txtAreaEtc.Size = New System.Drawing.Size(356, 120)
        Me.txtAreaEtc.TabIndex = 24
        Me.txtAreaEtc.Text = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Location = New System.Drawing.Point(12, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(450, 493)
        Me.DataGridView1.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(860, 466)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 38)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "取り消し"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(605, 466)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(79, 38)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "修正"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(488, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "価格"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(488, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "商品名"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.Color.Cornsilk
        Me.txtItemName.Enabled = False
        Me.txtItemName.Location = New System.Drawing.Point(562, 16)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(169, 25)
        Me.txtItemName.TabIndex = 13
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Cornsilk
        Me.txtPrice.Enabled = False
        Me.txtPrice.Location = New System.Drawing.Point(562, 66)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(169, 25)
        Me.txtPrice.TabIndex = 14
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.Cornsilk
        Me.cmbType.Enabled = False
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(563, 166)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(168, 23)
        Me.cmbType.TabIndex = 33
        '
        'btnPlus
        '
        Me.btnPlus.Enabled = False
        Me.btnPlus.Location = New System.Drawing.Point(562, 115)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(34, 27)
        Me.btnPlus.TabIndex = 34
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Enabled = False
        Me.btnMinus.Location = New System.Drawing.Point(696, 115)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(34, 27)
        Me.btnMinus.TabIndex = 35
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'itemMngForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 515)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAreaEtc)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "itemMngForm"
        Me.Text = "costomerMngForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtAreaEtc As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
End Class
