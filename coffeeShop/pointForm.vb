Public Class pointForm
    Dim ds As DataSet
    Dim pNow As Integer

    Private Sub pointForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet

        sql = "SELECT 
        (SELECT COUNT(*) FROM 
           ( SELECT 
           P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
           ON M.MID=P.MID WHERE M.mLoginId='" + vId + "') AS R2  
           WHERE R1.MID>=R2.MID) AS ROWNUM ,
        R1.* 
        FROM
         ( SELECT 
        P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
        ON M.MID=P.MID WHERE M.mLoginId='" + vId + "') AS R1 
        ORDER BY R1.PAYDATE DESC"
        Console.WriteLine(sql)
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
        DataGridView1.Columns("payPointAmount").DisplayIndex = 3
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Columns("payPointAmount").HeaderCell.Style.BackColor = Color.Cornsilk
        DataGridView1.Columns("payPointAmount").DefaultCellStyle.BackColor = Color.Cornsilk

        pNow = DataGridView1("payPointAmount", 0).Value
        txtPoint.Text = pNow
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    ''' <summary>
    ''' 포인트창 닫기 이벤트
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pointForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Label5.Visible = False
        txtPoint.Visible = False
        btnUse.Visible = False
        vId = ""

        If loginForm.Equals(Owner) Then
            If MsgBox("終了しますか？", MessageBoxButtons.YesNo, "終了") = vbYes Then
                Owner.Show()
                Me.Dispose(True)
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUse_Click(sender As Object, e As EventArgs) Handles btnUse.Click
        If txtPoint.Text > pNow Then
            MsgBox("使えられるポイントは" & pNow & "です")
            txtPoint.Text = pNow
            Return
        End If

        orderForm.txtUsedPoint.Text = txtPoint.Text
        orderForm.txtTotal.Text = Integer.Parse(orderForm.txtAmount.Text) - Integer.Parse(txtPoint.Text)
        Label5.Visible = False
        txtPoint.Visible = False
        btnUse.Visible = False
        Me.Dispose(True)
    End Sub
End Class