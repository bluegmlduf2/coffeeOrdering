Public Class pointForm
    Dim ds As DataSet
    Dim pNow As Integer
    Public vChk As Boolean = True

    Private Sub pointForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If vChk Then
            selectOneMember() '기존 회원 선택해서 포인트조회
        Else
            selectAllMember() '관리자모드에서 포인트조회
        End If

        'ROWNUM추가
        Dim col As DataColumn = New DataColumn()
        col.DataType = System.Type.GetType("System.String")
        col.ColumnName = "rownum"
        col.DefaultValue = "0"
        ds.Tables("d_point").Columns.Add(col)
        For i = 1 To ds.Tables("d_point").Rows.Count
            ds.Tables("d_point").Rows(i - 1).Item("rownum") = i
        Next

        With DataGridView1
            .DataSource = ds.Tables("d_point")
            .Columns("rownum").HeaderText = "NO"
            .Columns("payId").HeaderText = "会計コード"
            .Columns("payDate").HeaderText = "決済日"
            .Columns("payAmount").HeaderText = "決済金額"
            .Columns("payPointUse").HeaderText = "使用したポイント"
            .Columns("payPoint").HeaderText = "積立金"
            .Columns("payPointAmount").HeaderText = "ポイント残高"
            .Columns("mName").HeaderText = "メンバー名"
            .Columns("payMethod").HeaderText = "決済方法"
            .Columns("mId").Visible = False
            .Columns("rownum").DisplayIndex = 0
            .Columns("mName").DisplayIndex = 2
            .Columns("payPointAmount").DisplayIndex = 3
            .EnableHeadersVisualStyles = False
            .Columns("payPointAmount").HeaderCell.Style.BackColor = Color.Cornsilk
            .Columns("payPointAmount").DefaultCellStyle.BackColor = Color.Cornsilk
        End With

        pNow = DataGridView1("payPointAmount", 0).Value
        txtPoint.Text = pNow
        vChk = True
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
        orderForm.vmId = ds.Tables("d_point").Rows(0).Item("mId").ToString
        orderForm.vPayPointAmount = DataGridView1("payPointAmount", 0).Value
        orderForm.txtTotal.Text = Integer.Parse(orderForm.txtAmount.Text) - Integer.Parse(txtPoint.Text)
        Label5.Visible = False
        txtPoint.Visible = False
        btnUse.Visible = False

        Me.Dispose(True)
    End Sub

    ''' <summary>
    ''' 1명의 멤버에 대한 포인트만 조회
    ''' </summary>
    Private Sub selectOneMember()
        ds = New DataSet
        'sql = "SELECT 
        '(SELECT COUNT(*) FROM 
        '   ( SELECT 
        '   P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
        '   ON M.MID=P.MID WHERE M.mLoginId='" + vId + "') AS R2  
        '   WHERE R1.MID>=R2.MID) AS ROWNUM ,
        'R1.* 
        'FROM
        ' ( SELECT 
        'P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
        'ON M.MID=P.MID WHERE M.mLoginId='" + vId + "') AS R1 
        'ORDER BY R1.PAYDATE DESC"

        sql = " SELECT 
        P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
        ON M.MID=P.MID WHERE M.mLoginId='" + vId + "' ORDER BY PAYDATE DESC"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_point")

        Label1.Text = ds.Tables("d_point").Rows(0).Item("mName").ToString
        Label4.Text = ds.Tables("d_point").Rows(0).Item("payPointAmount").ToString
    End Sub

    ''' <summary>
    ''' 관리자가 전체 멤버에 대한 포인트에 대한 조회시, 화면 크기 그리드 크기 변환
    ''' </summary>
    Private Sub selectAllMember()
        ds = New DataSet

        sql = " SELECT 
        P.* ,M.MNAME FROM MEMBER AS M INNER JOIN PAYMENT AS P 
        ON M.MID=P.MID ORDER BY PAYDATE DESC"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_point")

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        'Me.Size = New System.Drawing.Size(958, 515)
        DataGridView1.Location = New Point(10, 10)
        DataGridView1.Size = New System.Drawing.Size(833, 390)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
    End Sub
End Class