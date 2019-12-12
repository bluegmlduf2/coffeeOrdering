<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class empMngForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnChk = New System.Windows.Forms.Button()
        Me.rdoSex1 = New System.Windows.Forms.RadioButton()
        Me.rdoSex2 = New System.Windows.Forms.RadioButton()
        Me.dateReg = New System.Windows.Forms.DateTimePicker()
        Me.txtAreaEtc = New System.Windows.Forms.RichTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCall1 = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.chkBoxListStatus = New System.Windows.Forms.CheckedListBox()
        Me.cmbPid = New System.Windows.Forms.ComboBox()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(487, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(487, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "暗証番号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(487, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "名前"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(488, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "性別"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(487, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "電話番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(487, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "登録日"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(487, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ETC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(488, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "職位"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(488, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "勤務日程"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.Cornsilk
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(562, 16)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(169, 25)
        Me.txtId.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Cornsilk
        Me.txtPass.Enabled = False
        Me.txtPass.Location = New System.Drawing.Point(562, 58)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(169, 25)
        Me.txtPass.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Cornsilk
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(562, 99)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(169, 25)
        Me.txtName.TabIndex = 15
        '
        'btnChk
        '
        Me.btnChk.Enabled = False
        Me.btnChk.Location = New System.Drawing.Point(738, 15)
        Me.btnChk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(59, 29)
        Me.btnChk.TabIndex = 20
        Me.btnChk.Text = "確認"
        Me.btnChk.UseVisualStyleBackColor = True
        '
        'rdoSex1
        '
        Me.rdoSex1.AutoSize = True
        Me.rdoSex1.Checked = True
        Me.rdoSex1.Enabled = False
        Me.rdoSex1.Location = New System.Drawing.Point(562, 140)
        Me.rdoSex1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoSex1.Name = "rdoSex1"
        Me.rdoSex1.Size = New System.Drawing.Size(43, 19)
        Me.rdoSex1.TabIndex = 21
        Me.rdoSex1.TabStop = True
        Me.rdoSex1.Text = "男"
        Me.rdoSex1.UseVisualStyleBackColor = True
        '
        'rdoSex2
        '
        Me.rdoSex2.AutoSize = True
        Me.rdoSex2.Enabled = False
        Me.rdoSex2.Location = New System.Drawing.Point(609, 140)
        Me.rdoSex2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoSex2.Name = "rdoSex2"
        Me.rdoSex2.Size = New System.Drawing.Size(43, 19)
        Me.rdoSex2.TabIndex = 22
        Me.rdoSex2.Text = "女"
        Me.rdoSex2.UseVisualStyleBackColor = True
        '
        'dateReg
        '
        Me.dateReg.Enabled = False
        Me.dateReg.Location = New System.Drawing.Point(562, 212)
        Me.dateReg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dateReg.Name = "dateReg"
        Me.dateReg.Size = New System.Drawing.Size(197, 25)
        Me.dateReg.TabIndex = 23
        Me.dateReg.Value = New Date(2019, 12, 9, 16, 23, 31, 0)
        '
        'txtAreaEtc
        '
        Me.txtAreaEtc.Enabled = False
        Me.txtAreaEtc.Location = New System.Drawing.Point(561, 415)
        Me.txtAreaEtc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAreaEtc.Name = "txtAreaEtc"
        Me.txtAreaEtc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txtAreaEtc.Size = New System.Drawing.Size(356, 43)
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
        'txtCall1
        '
        Me.txtCall1.BackColor = System.Drawing.Color.Cornsilk
        Me.txtCall1.Enabled = False
        Me.txtCall1.Location = New System.Drawing.Point(562, 176)
        Me.txtCall1.Mask = "000-0000-0000"
        Me.txtCall1.Name = "txtCall1"
        Me.txtCall1.Size = New System.Drawing.Size(171, 25)
        Me.txtCall1.TabIndex = 29
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
        'chkBoxListStatus
        '
        Me.chkBoxListStatus.BackColor = System.Drawing.Color.Cornsilk
        Me.chkBoxListStatus.Enabled = False
        Me.chkBoxListStatus.HorizontalScrollbar = True
        Me.chkBoxListStatus.Items.AddRange(New Object() {"月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日", "日曜日"})
        Me.chkBoxListStatus.Location = New System.Drawing.Point(561, 304)
        Me.chkBoxListStatus.MultiColumn = True
        Me.chkBoxListStatus.Name = "chkBoxListStatus"
        Me.chkBoxListStatus.Size = New System.Drawing.Size(356, 104)
        Me.chkBoxListStatus.TabIndex = 33
        '
        'cmbPid
        '
        Me.cmbPid.Enabled = False
        Me.cmbPid.FormattingEnabled = True
        Me.cmbPid.Location = New System.Drawing.Point(561, 258)
        Me.cmbPid.Name = "cmbPid"
        Me.cmbPid.Size = New System.Drawing.Size(198, 23)
        Me.cmbPid.TabIndex = 35
        '
        'empMngForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 515)
        Me.Controls.Add(Me.cmbPid)
        Me.Controls.Add(Me.chkBoxListStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtCall1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtAreaEtc)
        Me.Controls.Add(Me.dateReg)
        Me.Controls.Add(Me.rdoSex2)
        Me.Controls.Add(Me.rdoSex1)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "empMngForm"
        Me.Text = "costomerMngForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnChk As Button
    Friend WithEvents rdoSex1 As RadioButton
    Friend WithEvents rdoSex2 As RadioButton
    Friend WithEvents dateReg As DateTimePicker
    Friend WithEvents txtAreaEtc As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtCall1 As MaskedTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents chkBoxListStatus As CheckedListBox
    Friend WithEvents cmbPid As ComboBox
End Class
