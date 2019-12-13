Public Class itemMngForm
    Dim ds As DataSet
    Dim chkVal As Integer = 0

    Private Sub costomerMngForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        sql = "SELECT item_id,item_name,item_price,item_amount,item_type,iif(ISNULL(item_etc),'',item_etc)as item_etc1 from item order by item_id"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item")

        With DataGridView1
            .DataSource = ds.Tables("d_item")
            .Columns("item_name").HeaderText = "商品名"
            .Columns("item_price").HeaderText = "価格"
            .Columns("item_amount").HeaderText = "数量"
            .Columns("item_type").HeaderText = "種類"
            .Columns("item_etc1").HeaderText = "ETC"
            .Columns("item_name").Width = 100
            .Columns("item_price").Width = 60
            .Columns("item_amount").Width = 40
            .Columns("item_type").Width = 80
            .Columns("item_etc1").Width = 200
            .Columns("item_id").Visible = False
            .RowTemplate.Height = 40
            .ColumnHeadersHeight = 40
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk
        End With

        '콤보박스
        sql = "Select item_type,MIN(item_id) FROM ITEM GROUP BY item_type order by MIN(item_id)"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item_combo")
        For i = 0 To ds.Tables("d_item_combo").Rows.Count - 1
            cmbType.Items.Add(ds.Tables("d_item_combo").Rows(i).Item(0).ToString())
        Next

        selectFirstRow(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '문제점 헤더클릭 하면 에러.. 못 막겠음
        selectFirstRow(e.RowIndex)
    End Sub

    ''' <summary>
    ''' 추가버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        chkVal = 1

        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnPlus.Enabled = True
        btnMinus.Enabled = True

        DataGridView1.Enabled = False
        txtItemName.Enabled = True
        txtPrice.Enabled = True
        txtAmount.Enabled = True
        cmbType.Enabled = True
        txtAreaEtc.Enabled = True

        txtItemName.Text = ""
        txtPrice.Text = ""
        txtAmount.Text = 0
        txtAreaEtc.Text = ""
        cmbType.SelectedIndex = 0

        txtItemName.Focus()

        '동적으로 데이터셋을 박아준 경우에는 datagridview에 추가할수없고 table에 직접 박아 줘야함
        Dim newRow As DataRow = ds.Tables("d_item").NewRow()
        ds.Tables("d_item").Rows.Add(newRow)
        DataGridView1.CurrentCell = DataGridView1.Rows(ds.Tables("d_item").Rows.Count - 1).Cells(1) '현재 선택된 행 변경..억지로 끼워맞춤
    End Sub

    ''' <summary>
    ''' 취소버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False

        btnPlus.Enabled = False
        btnMinus.Enabled = False

        DataGridView1.Enabled = True
        txtItemName.Enabled = False
        txtPrice.Enabled = False
        txtAmount.Enabled = False
        cmbType.Enabled = False
        txtAreaEtc.Enabled = False

        txtItemName.Text = ""
        txtPrice.Text = ""
        txtAmount.Text = ""
        cmbType.Text = ""
        txtAreaEtc.Text = ""

        ds.Clear()
        ds = New DataSet
        sql = "SELECT item_id,item_name,item_price,item_amount,item_type,iif(ISNULL(item_etc),'',item_etc)as item_etc1 from item order by item_id"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item")
        DataGridView1.DataSource = ds.Tables("d_item")

        selectFirstRow(0)

        chkVal = 0 '0은 원래대로
    End Sub

    ''' <summary>
    ''' 저장버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtItemName.Text = "" Or txtPrice.Text = "" Or txtAmount.Text = "" Then
            MsgBox("全部入力してください")
            Return
        End If

        If chkVal = 1 Then
            sql = "insert into item(item_name,item_price,item_amount,item_type,item_etc) values ("
            sql += "'" & txtItemName.Text & "',"
            sql += txtPrice.Text & ","
            sql += txtAmount.Text & ","
            sql += "'" & cmbType.Text & "',"
            sql += "'" & txtAreaEtc.Text & "')"

            DCom.CommandText = sql
            DCom.ExecuteNonQuery()
            MsgBox("追加されました")
        ElseIf chkVal = 2 Then
            Dim rItemId As Integer = DataGridView1("item_id", DataGridView1.CurrentCell.RowIndex).Value

            sql = "UPDATE item SET "
            sql += "item_name='" & txtItemName.Text & "',"
            sql += "item_price=" & txtPrice.Text & ","
            sql += "item_amount=" & txtAmount.Text & ","
            sql += "item_type='" & cmbType.Text & "',"
            sql += "item_etc='" & txtAreaEtc.Text & "' "
            sql += "WHERE item_id=" & rItemId

            DCom.CommandText = sql
            DCom.ExecuteNonQuery()
            MsgBox("修正しました")
        End If

        btnCancel.PerformClick()
    End Sub

    ''' <summary>
    ''' 삭제버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rYN As DialogResult = MessageBox.Show("本当に削除しますか？", "確認", MessageBoxButtons.YesNo)
        If rYN = DialogResult.No Then
            Return
        End If

        Dim rItemId As Integer = DataGridView1("item_id", DataGridView1.CurrentCell.RowIndex).Value
        sql = "DELETE FROM ITEM WHERE item_id=" & rItemId
        DCom.CommandText = sql
        DCom.ExecuteNonQuery()
        MsgBox("削除しました")

        btnCancel.Enabled = True
        btnCancel.PerformClick()
    End Sub

    ''' <summary>
    ''' 수정버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        chkVal = 2 '수정시 저장을 위한 변수

        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        btnPlus.Enabled = True
        btnMinus.Enabled = True

        DataGridView1.Enabled = False
        txtItemName.Enabled = False
        txtPrice.Enabled = True
        txtAmount.Enabled = True
        cmbType.Enabled = True
        txtAreaEtc.Enabled = True
    End Sub

    Private Sub selectFirstRow(ByVal i As Integer)
        txtItemName.Text = DataGridView1(1, i).Value
        txtPrice.Text = DataGridView1(2, i).Value
        txtAmount.Text = DataGridView1(3, i).Value
        cmbType.Text = DataGridView1(4, i).Value
        txtAreaEtc.Text = DataGridView1(5, i).Value
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click
        Dim cName As String = sender.name
        Dim rAmount As Integer = Int(txtAmount.Text)
        If cName = "btnPlus" Then
            rAmount = rAmount + 1
        Else
            rAmount = rAmount - 1
        End If

        If rAmount = -1 Then
            txtAmount.Text = 0
            MsgBox("数量が0です")
            Return
        End If

        txtAmount.Text = rAmount
    End Sub
End Class