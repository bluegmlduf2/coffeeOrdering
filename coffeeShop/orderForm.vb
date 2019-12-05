Public Class orderForm
    Dim ds As DataSet
    Dim c1 As DataTable '취소버튼 눌렀을떄 초기화를 위해 데이터셋의 테이블 복사
    Dim t1 As DataTable
    Dim b1 As DataTable

    ''' <summary>
    ''' 초기화
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub orderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet

        'Datasource->table->(datasource)
        'Datasource->binding->(datasource)

        sql = "SELECT item_name,item_price,item_amount FROM ITEM WHERE ITEM_TYPE='coffee'"
        DA = New OleDb.OleDbDataAdapter(Sql, Con)
        DA.Fill(ds, "d_item_c")
        c1 = ds.Tables("d_item_c").Copy()
        DataGridView1.DataSource = ds.Tables("d_item_c")
        DataGridView1.Columns("item_name").HeaderText = "商品名"
        DataGridView1.Columns("item_price").HeaderText = "価格"
        DataGridView1.Columns("item_amount").HeaderText = "数量"
        DataGridView1.RowTemplate.Height = 40
        DataGridView1.ColumnHeadersHeight = 40
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk

        sql = "SELECT item_name,item_price,item_amount FROM ITEM WHERE ITEM_TYPE='tea'"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item_t")
        t1 = ds.Tables("d_item_t").Copy()
        DataGridView2.DataSource = ds.Tables("d_item_t")
        DataGridView2.Columns("item_name").HeaderText = "商品名"
        DataGridView2.Columns("item_price").HeaderText = "価格"
        DataGridView2.Columns("item_amount").HeaderText = "数量"
        DataGridView2.RowTemplate.Height = 40
        DataGridView2.ColumnHeadersHeight = 40
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk

        sql = "SELECT item_name,item_price,item_amount FROM ITEM WHERE ITEM_TYPE='bread'"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item_b")
        b1 = ds.Tables("d_item_b").Copy()
        DataGridView3.DataSource = ds.Tables("d_item_b")
        DataGridView3.Columns("item_name").HeaderText = "商品名"
        DataGridView3.Columns("item_price").HeaderText = "価格"
        DataGridView3.Columns("item_amount").HeaderText = "数量"
        DataGridView3.RowTemplate.Height = 40
        DataGridView3.ColumnHeadersHeight = 40
        DataGridView3.EnableHeadersVisualStyles = False
        DataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk

        DataGridView4.RowTemplate.Height = 30
        DataGridView4.ColumnHeadersHeight = 40
        DataGridView4.EnableHeadersVisualStyles = False
        DataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk
    End Sub

    ''' <summary>
    ''' 세로탭 텍스트 설정
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String

        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF

        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        ' ctlTab.BackColor = Color.Cornsilk

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 10
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    ''' <summary>
    ''' 1번~3번그리드 더블클릭시
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick, DataGridView3.CellDoubleClick, DataGridView2.CellDoubleClick
        Dim pName As String = sender.rows(e.RowIndex).Cells(0).value
        Dim pPrice As Integer = sender.rows(e.RowIndex).Cells(1).value 'sender(0, 0).value
        Dim pCount As Integer = sender.rows(e.RowIndex).Cells(2).value
        txtUsedPoint.Text = 0

        If pCount = 0 Then
            MsgBox("在庫が足りないです")
            Return
        End If

        For i = 1 To DataGridView4.RowCount
            If DataGridView4("cItemName", i - 1).Value = pName Then

                Dim vCount As Integer = DataGridView4.Rows(i - 1).Cells("cCount").Value
                DataGridView4.Rows(i - 1).Cells("cCount").Value = vCount + 1

                Dim vPrice As Integer = DataGridView4.Rows(i - 1).Cells("cPrice").Value + pPrice
                DataGridView4.Rows(i - 1).Cells("cPrice").Value = vPrice

                sender.rows(e.RowIndex).Cells(2).value = pCount - 1

                returnAmount()
                Return
            End If
        Next

        Dim addRow As Integer = DataGridView4.Rows.Add()
        DataGridView4("cItemName", addRow).Value = pName
        DataGridView4("cPrice", addRow).Value = pPrice
        DataGridView4("cCount", addRow).Value = 1
        DataGridView4("cOriPrice", addRow).Value = pPrice '나중에 되돌려줄떄 차감을 위해서 넣음
        sender.rows(e.RowIndex).Cells(2).value = pCount - 1

        returnAmount()
    End Sub

    ''' <summary>
    ''' 4번그리드 클릭시
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView4_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView4.CellMouseDoubleClick
        Dim pName As String = sender.rows(e.RowIndex).Cells(0).value
        Dim pPrice As Integer = sender.rows(e.RowIndex).Cells(1).value 'sender(0, 0).value
        Dim pCount As Integer = sender.rows(e.RowIndex).Cells(2).value
        Dim pOriPrice As Integer = sender.rows(e.RowIndex).Cells(3).value

        If sender.rows(e.RowIndex).Cells(2).value = 1 Then
            DataGridView4.Rows.Remove(DataGridView4.Rows(e.RowIndex))
            chkVal(pName)
            returnAmount()
            Return
        End If

        '1번~3번 그리드에 추가 메서드 
        chkVal(pName)

        '4번그리드 제거 및 수량 변경
        sender.rows(e.RowIndex).Cells(2).value = pCount - 1
        sender.rows(e.RowIndex).Cells(1).value = sender.rows(e.RowIndex).Cells(1).value - pOriPrice
        returnAmount()
    End Sub

    ''' <summary>
    ''' 총금액 반환
    ''' </summary>
    Private Sub returnAmount()
        Dim vAmount As Integer
        Dim vUsedPoint As Integer = Int32.Parse(txtUsedPoint.Text)

        For r = 1 To DataGridView4.RowCount
            vAmount += DataGridView4.Rows(r - 1).Cells("cPrice").Value
        Next
        txtAmount.Text = vAmount
        txtTotal.Text = vAmount
        Dim vPoint As Integer = vAmount * 5 / 100
        txtSavePoint.Text = (vPoint - vUsedPoint)

    End Sub

    ''' <summary>
    ''' 1~3번그리드 조회
    ''' </summary>
    ''' <param name="pName"></param>
    Private Sub chkVal(ByVal pName As String)
        For i = 1 To DataGridView1.RowCount
            If DataGridView1(0, i - 1).Value = pName Then
                DataGridView1(2, i - 1).Value = DataGridView1(2, i - 1).Value + 1
            End If
        Next

        For i = 1 To DataGridView2.RowCount
            If DataGridView2(0, i - 1).Value = pName Then
                DataGridView2(2, i - 1).Value = DataGridView2(2, i - 1).Value + 1
            End If
        Next

        For i = 1 To DataGridView3.RowCount
            If DataGridView3(0, i - 1).Value = pName Then
                DataGridView3(2, i - 1).Value = DataGridView3(2, i - 1).Value + 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' 포인트조회
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearchPoint_Click(sender As Object, e As EventArgs) Handles btnSearchPoint.Click
        Dim form As New pointForm

        If DataGridView4.RowCount = 0 Then
            MsgBox("ポイント使用の前に商品を選んでください")
            Return
        End If

        Dim rId As String = InputBox("会員IDを入力してください", "会員確認", "m1")
        sql = "Select mLoginId,mName from member "
        sql += "where mLoginId='" & rId & "'"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "memberChk")

        If ds.Tables("memberChk").Rows.Count = 0 Then
            MsgBox("該当する会員がいません")
            Return
        End If

        txtUsedPoint.Text = 0
        vId = ds.Tables("memberChk").Rows(0).Item("mLoginId")

        form.Owner = Me
        form.Label5.Visible = True
        form.txtPoint.Visible = True
        form.btnUse.Visible = True
        'pointForm.pForm = Me
        form.ShowDialog()
    End Sub

    ''' <summary>
    ''' 취소버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        '  DataGridView1.Refresh()
        DataGridView4.Rows.Clear()

        DataGridView1.DataSource = c1
        DataGridView2.DataSource = t1
        DataGridView3.DataSource = b1

    End Sub
End Class