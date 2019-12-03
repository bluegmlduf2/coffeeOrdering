Public Class orderForm
    Dim ds As DataSet


    Private Sub orderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 'CoffeeShopDataSet.position' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        ds = New DataSet

        'Datasource->table->(datasource)
        'Datasource->binding->(datasource)
        sql = "SELECT item_name,item_price,item_amount FROM ITEM WHERE ITEM_TYPE='coffee'"
        DA = New OleDb.OleDbDataAdapter(Sql, Con)
        DA.Fill(ds, "d_item_c")
        DataGridView1.DataSource = ds.Tables("d_item_c")

        DataGridView1.Columns("item_name").HeaderText = "商品名"
        DataGridView1.Columns("item_price").HeaderText = "価格"
        DataGridView1.Columns("item_amount").HeaderText = "数量"

        sql = "SELECT item_name,item_price,item_amount FROM ITEM WHERE ITEM_TYPE='tea'"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item_t")
        DataGridView2.DataSource = ds.Tables("d_item_t")

        DataGridView2.Columns("item_name").HeaderText = "商品名"
        DataGridView2.Columns("item_price").HeaderText = "価格"
        DataGridView2.Columns("item_amount").HeaderText = "数量"

        sql = "SELECT item_name,item_price,item_amount FROM ITEM WHERE ITEM_TYPE='bread'"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_item_b")
        DataGridView3.DataSource = ds.Tables("d_item_b")

        DataGridView3.Columns("item_name").HeaderText = "商品名"
        DataGridView3.Columns("item_price").HeaderText = "価格"
        DataGridView3.Columns("item_amount").HeaderText = "数量"

    End Sub


    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics
        Dim sText As String

        Dim iX As Integer
        Dim iY As Integer
        Dim sizeText As SizeF

        Dim ctlTab As TabControl

        ctlTab = CType(sender, TabControl)

        g = e.Graphics

        sText = ctlTab.TabPages(e.Index).Text
        sizeText = g.MeasureString(sText, ctlTab.Font)

        iX = e.Bounds.Left + 6
        iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2

        g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick, DataGridView3.CellDoubleClick, DataGridView2.CellDoubleClick
        Dim pName As String = sender.rows(e.RowIndex).Cells(0).value
        Dim pPrice As String = sender.rows(e.RowIndex).Cells(1).value 'sender(0, 0).value

        Dim addRow As Integer = DataGridView4.Rows.Add()
        DataGridView4("cItemName", addRow).Value = pName
        DataGridView4("cPrice", addRow).Value = pPrice

    End Sub
End Class