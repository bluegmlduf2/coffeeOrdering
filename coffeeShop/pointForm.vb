Public Class pointForm
    Dim ds As DataSet
    Dim sql As String

    Private Sub pointForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet

        sql = "SELECT 
        (SELECT COUNT(*) FROM 
           ( SELECT 
           P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
           ON M.MID=P.MID WHERE P.MID=" + vId + ") AS R2  
           WHERE R1.MID>=R2.MID) AS ROWNUM ,
        R1.* 
        FROM
         ( SELECT 
        P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
        ON M.MID=P.MID WHERE P.MID=" + vId + ") AS R1 
        ORDER BY R1.MID ASC"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_point")

        Label1.Text = ds.Tables("d_point").Rows(0).Item("mName").ToString
        Label4.Text = ds.Tables("d_point").Rows(0).Item("payPointAmount").ToString

        DataGridView1.DataSource = ds.Tables("d_point")

        DataGridView1.Columns("rownum").HeaderText = "NO"
        DataGridView1.Columns("payId").HeaderText = "会計コード"
        DataGridView1.Columns("payDate").HeaderText = "決済日"
        DataGridView1.Columns("payAmount").HeaderText = "決済金額"
        DataGridView1.Columns("payPointUse").HeaderText = "使用したポイント"
        DataGridView1.Columns("payPoint").HeaderText = "積立金"
        DataGridView1.Columns("payPointAmount").HeaderText = "ポイント残高"
        DataGridView1.Columns("mName").HeaderText = "メンバー名"

        DataGridView1.Columns("mId").Visible = False

        DataGridView1.Columns("mName").DisplayIndex = 2

        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill



    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        loginForm.Show()
    End Sub
End Class