Public Class mainForm

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderForm.MdiParent = Me
        costomerMngForm.MdiParent = Me
        empMngForm.MdiParent = Me

        orderForm.Show()
        Me.Text = "ようこそ　BostonCoffee[" + vPosition + "][" + vName + "]様"
    End Sub

    ''' <summary>
    　 ''' 顧客管理ボータン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 顧客管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 顧客管理ToolStripMenuItem.Click
        allFormClose()
        costomerMngForm.MdiParent = Me
        costomerMngForm.Show()
    End Sub

    Private Sub 職員管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 職員管理ToolStripMenuItem.Click
        allFormClose()
        empMngForm.MdiParent = Me
        empMngForm.Show()
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        allFormClose()
        orderForm.MdiParent = Me
        orderForm.Show()
    End Sub

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub allFormClose()
        For Each item As Form In Me.MdiChildren
            item.Dispose()
        Next
    End Sub


End Class