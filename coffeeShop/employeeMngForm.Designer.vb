<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeeMngForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
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
        Me.txtCall1 = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtFullAddress = New System.Windows.Forms.TextBox()
        Me.btnChk = New System.Windows.Forms.Button()
        Me.rdoSex1 = New System.Windows.Forms.RadioButton()
        Me.rdoSex2 = New System.Windows.Forms.RadioButton()
        Me.dateReg = New System.Windows.Forms.DateTimePicker()
        Me.txtAreaEtc = New System.Windows.Forms.RichTextBox()
        Me.txtCall2 = New System.Windows.Forms.TextBox()
        Me.txtCall3 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(398, 388)
        Me.DataGridView1.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(492, 377)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "追加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(598, 377)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "修正"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(704, 377)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "暗証番号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(426, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "名前"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "性別"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "電話番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "登録日"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 12)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ETC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "郵便住所"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(427, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "住所"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(492, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(148, 21)
        Me.txtId.TabIndex = 13
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(492, 46)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(148, 21)
        Me.txtPass.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(492, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(148, 21)
        Me.txtName.TabIndex = 15
        '
        'txtCall1
        '
        Me.txtCall1.Location = New System.Drawing.Point(492, 140)
        Me.txtCall1.Name = "txtCall1"
        Me.txtCall1.Size = New System.Drawing.Size(45, 21)
        Me.txtCall1.TabIndex = 16
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(492, 206)
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(45, 21)
        Me.txtAddress1.TabIndex = 17
        '
        'txtFullAddress
        '
        Me.txtFullAddress.Location = New System.Drawing.Point(492, 239)
        Me.txtFullAddress.Name = "txtFullAddress"
        Me.txtFullAddress.Size = New System.Drawing.Size(312, 21)
        Me.txtFullAddress.TabIndex = 18
        '
        'btnChk
        '
        Me.btnChk.Location = New System.Drawing.Point(646, 12)
        Me.btnChk.Name = "btnChk"
        Me.btnChk.Size = New System.Drawing.Size(52, 23)
        Me.btnChk.TabIndex = 20
        Me.btnChk.Text = "確認"
        Me.btnChk.UseVisualStyleBackColor = True
        '
        'rdoSex1
        '
        Me.rdoSex1.AutoSize = True
        Me.rdoSex1.Checked = True
        Me.rdoSex1.Location = New System.Drawing.Point(492, 112)
        Me.rdoSex1.Name = "rdoSex1"
        Me.rdoSex1.Size = New System.Drawing.Size(35, 16)
        Me.rdoSex1.TabIndex = 21
        Me.rdoSex1.TabStop = True
        Me.rdoSex1.Text = "男"
        Me.rdoSex1.UseVisualStyleBackColor = True
        '
        'rdoSex2
        '
        Me.rdoSex2.AutoSize = True
        Me.rdoSex2.Location = New System.Drawing.Point(533, 112)
        Me.rdoSex2.Name = "rdoSex2"
        Me.rdoSex2.Size = New System.Drawing.Size(35, 16)
        Me.rdoSex2.TabIndex = 22
        Me.rdoSex2.Text = "女"
        Me.rdoSex2.UseVisualStyleBackColor = True
        '
        'dateReg
        '
        Me.dateReg.Location = New System.Drawing.Point(492, 170)
        Me.dateReg.Name = "dateReg"
        Me.dateReg.Size = New System.Drawing.Size(173, 21)
        Me.dateReg.TabIndex = 23
        '
        'txtAreaEtc
        '
        Me.txtAreaEtc.Location = New System.Drawing.Point(492, 274)
        Me.txtAreaEtc.Name = "txtAreaEtc"
        Me.txtAreaEtc.Size = New System.Drawing.Size(312, 97)
        Me.txtAreaEtc.TabIndex = 24
        Me.txtAreaEtc.Text = ""
        '
        'txtCall2
        '
        Me.txtCall2.Location = New System.Drawing.Point(543, 140)
        Me.txtCall2.Name = "txtCall2"
        Me.txtCall2.Size = New System.Drawing.Size(45, 21)
        Me.txtCall2.TabIndex = 25
        '
        'txtCall3
        '
        Me.txtCall3.Location = New System.Drawing.Point(594, 140)
        Me.txtCall3.Name = "txtCall3"
        Me.txtCall3.Size = New System.Drawing.Size(45, 21)
        Me.txtCall3.TabIndex = 26
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(543, 206)
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(45, 21)
        Me.txtAddress2.TabIndex = 27
        '
        'employeeMngForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 412)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtCall3)
        Me.Controls.Add(Me.txtCall2)
        Me.Controls.Add(Me.txtAreaEtc)
        Me.Controls.Add(Me.dateReg)
        Me.Controls.Add(Me.rdoSex2)
        Me.Controls.Add(Me.rdoSex1)
        Me.Controls.Add(Me.btnChk)
        Me.Controls.Add(Me.txtFullAddress)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtCall1)
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
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "employeeMngForm"
        Me.Text = "employeeMngForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
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
    Friend WithEvents txtCall1 As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtFullAddress As TextBox
    Friend WithEvents btnChk As Button
    Friend WithEvents rdoSex1 As RadioButton
    Friend WithEvents rdoSex2 As RadioButton
    Friend WithEvents dateReg As DateTimePicker
    Friend WithEvents txtAreaEtc As RichTextBox
    Friend WithEvents txtCall2 As TextBox
    Friend WithEvents txtCall3 As TextBox
    Friend WithEvents txtAddress2 As TextBox
End Class
