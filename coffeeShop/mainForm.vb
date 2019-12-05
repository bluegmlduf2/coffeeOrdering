Public Class mainForm

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        orderForm.MdiParent = Me
        costomerMngForm.MdiParent = Me
        orderForm.Show()
        Me.Text = "ようこそ　BostonCoffee[" + vPosition + "][" + vName + "]様"
    End Sub

    ''' <summary>
    　 ''' 顧客管理ボータン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub 顧客管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 顧客管理ToolStripMenuItem.Click
        orderForm.Close()
        costomerMngForm.Show()
    End Sub

    Private Sub mainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub
End Class