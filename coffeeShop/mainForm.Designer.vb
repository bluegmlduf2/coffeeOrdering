<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.顧客管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.在庫管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.売上管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.積立金管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.メニュー管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.顧客管理ToolStripMenuItem, Me.在庫管理ToolStripMenuItem, Me.売上管理ToolStripMenuItem, Me.積立金管理ToolStripMenuItem, Me.メニュー管理ToolStripMenuItem, Me.HOMEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(859, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '顧客管理ToolStripMenuItem
        '
        Me.顧客管理ToolStripMenuItem.Name = "顧客管理ToolStripMenuItem"
        Me.顧客管理ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.顧客管理ToolStripMenuItem.Text = "顧客管理"
        '
        '在庫管理ToolStripMenuItem
        '
        Me.在庫管理ToolStripMenuItem.Name = "在庫管理ToolStripMenuItem"
        Me.在庫管理ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.在庫管理ToolStripMenuItem.Text = "職員管理"
        '
        '売上管理ToolStripMenuItem
        '
        Me.売上管理ToolStripMenuItem.Name = "売上管理ToolStripMenuItem"
        Me.売上管理ToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.売上管理ToolStripMenuItem.Text = "売上管理"
        '
        '積立金管理ToolStripMenuItem
        '
        Me.積立金管理ToolStripMenuItem.Name = "積立金管理ToolStripMenuItem"
        Me.積立金管理ToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.積立金管理ToolStripMenuItem.Text = "積立金管理"
        '
        'メニュー管理ToolStripMenuItem
        '
        Me.メニュー管理ToolStripMenuItem.Name = "メニュー管理ToolStripMenuItem"
        Me.メニュー管理ToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.メニュー管理ToolStripMenuItem.Text = "メニュー管理"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 442)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BostonCoffee"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 顧客管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 在庫管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 売上管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 積立金管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents メニュー管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
End Class
