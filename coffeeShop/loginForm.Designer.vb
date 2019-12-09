<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPASS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnEmpLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtID.Location = New System.Drawing.Point(91, 258)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(182, 21)
        Me.txtID.TabIndex = 0
        '
        'txtPASS
        '
        Me.txtPASS.Location = New System.Drawing.Point(91, 290)
        Me.txtPASS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPASS.Name = "txtPASS"
        Me.txtPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPASS.Size = New System.Drawing.Size(182, 21)
        Me.txtPASS.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PASSWORD"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(277, 258)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(67, 52)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnEmpLogin
        '
        Me.btnEmpLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEmpLogin.Location = New System.Drawing.Point(350, 258)
        Me.btnEmpLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmpLogin.Name = "btnEmpLogin"
        Me.btnEmpLogin.Size = New System.Drawing.Size(69, 52)
        Me.btnEmpLogin.TabIndex = 6
        Me.btnEmpLogin.Text = "職員" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ログイン"
        Me.btnEmpLogin.UseVisualStyleBackColor = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(424, 314)
        Me.Controls.Add(Me.btnEmpLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPASS)
        Me.Controls.Add(Me.txtID)
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boston Coffee Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPASS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnEmpLogin As Button
End Class
