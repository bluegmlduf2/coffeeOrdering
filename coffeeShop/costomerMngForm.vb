Public Class costomerMngForm
    Dim ds As DataSet
    Dim chkVal As Integer = 0

    Private Sub costomerMngForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        'Datasource->table->(datasource)
        'Datasource->binding->(datasource)
        sql = "SELECT mLoginId,mName,iif(mSex=1,'男','女')as mSex1,mPhone,mRegDate,"
        sql += "iif(ISNULL(mAddress),'',mAddress)as sAddress,"
        sql += "iif(ISNULL(mAddress1),'',mAddress1)as sAddress1,"
        sql += "iif(ISNULL(mEtc),'',mEtc)as sEtc ,mId,mPass FROM MEMBER order by mId"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_member")

        With DataGridView1
            .DataSource = ds.Tables("d_member")
            .Columns("mLoginId").HeaderText = "ID"
            .Columns("mName").HeaderText = "名前"
            .Columns("mSex1").HeaderText = "性別"
            .Columns("mPhone").HeaderText = "電話番号"
            .Columns("mRegDate").HeaderText = "登録日"
            .Columns("sAddress").HeaderText = "郵便住所"
            .Columns("sAddress1").HeaderText = "住所"
            .Columns("sEtc").HeaderText = "ETC"
            .Columns("mLoginId").Width = 60
            .Columns("mName").Width = 60
            .Columns("mSex1").Width = 40
            .Columns("sAddress").Width = 100
            .Columns("sAddress1").Width = 150
            .Columns("sEtc").Width = 200
            .Columns("mId").Visible = False
            .Columns("mPass").Visible = False

            .RowTemplate.Height = 40
            .ColumnHeadersHeight = 40
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk
        End With

        selectFirstRow()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '문제점 헤더클릭 하면 에러.. 못 막겠음
        txtId.Text = DataGridView1(0, e.RowIndex).Value
        txtName.Text = DataGridView1(1, e.RowIndex).Value
        If DataGridView1(2, e.RowIndex).Value = "男" Then
            rdoSex1.Checked = True
        Else
            rdoSex2.Checked = True
        End If
        txtCall1.Text = DataGridView1(3, e.RowIndex).Value
        dateReg.Value = DataGridView1(4, e.RowIndex).Value
        txtAddress1.Text = DataGridView1(5, e.RowIndex).Value
        txtFullAddress.Text = DataGridView1(6, e.RowIndex).Value
        txtAreaEtc.Text = DataGridView1(7, e.RowIndex).Value
        txtPass.Text = DataGridView1(9, e.RowIndex).Value
    End Sub

    ''' <summary>
    ''' 추가버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        chkVal = 5 '5는 아직 아이디 확인안함

        btnChk.Enabled = True
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        DataGridView1.Enabled = False
        txtId.Enabled = True
        txtPass.Enabled = True
        txtName.Enabled = True
        rdoSex1.Enabled = True
        rdoSex2.Enabled = True
        txtCall1.Enabled = True
        dateReg.Enabled = True
        txtAddress1.Enabled = True
        txtFullAddress.Enabled = True
        txtAreaEtc.Enabled = True

        txtId.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        rdoSex1.Checked = True
        rdoSex2.Checked = False
        txtCall1.Text = ""
        dateReg.Value = Today
        txtAddress1.Text = ""
        txtFullAddress.Text = ""
        txtAreaEtc.Text = ""

        txtId.Focus()

        '동적으로 데이터셋을 박아준 경우에는 datagridview에 추가할수없고 table에 직접 박아 줘야함
        Dim newRow As DataRow = ds.Tables("d_member").NewRow()
        ds.Tables("d_member").Rows.Add(newRow)
        DataGridView1.CurrentCell = DataGridView1.Rows(ds.Tables("d_member").Rows.Count - 1).Cells(0) '현재 선택된 행 변경..억지로 끼워맞춤
    End Sub

    ''' <summary>
    ''' 취소버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnChk.Enabled = False
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False

        txtId.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        rdoSex1.Checked = True
        rdoSex2.Checked = False
        txtCall1.Text = ""
        dateReg.Value = Today
        txtAddress1.Text = ""
        txtFullAddress.Text = ""
        txtAreaEtc.Text = ""

        DataGridView1.Enabled = True
        txtId.Enabled = False
        txtPass.Enabled = False
        txtName.Enabled = False
        rdoSex1.Enabled = False
        rdoSex2.Enabled = False
        txtCall1.Enabled = False
        dateReg.Enabled = False
        txtAddress1.Enabled = False
        txtFullAddress.Enabled = False
        txtAreaEtc.Enabled = False
        '행 추가 한 상태였다면 추가한 행을 삭제함
        'If chkVal = 1 Then
        '    ds.Tables("d_member").Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
        '    DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        'End If

        ds.Clear()
        ds = New DataSet

        sql = "SELECT mLoginId,mName,iif(mSex=1,'男','女')as mSex1,mPhone,mRegDate,"
        sql += "iif(ISNULL(mAddress),'',mAddress)as sAddress,"
        sql += "iif(ISNULL(mAddress1),'',mAddress1)as sAddress1,"
        sql += "iif(ISNULL(mEtc),'',mEtc)as sEtc ,mId,mPass FROM MEMBER order by mId"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_member")
        DataGridView1.DataSource = ds.Tables("d_member")

        txtId.Text = DataGridView1(0, 0).Value
        txtName.Text = DataGridView1(1, 0).Value
        If DataGridView1(2, 0).Value = "男" Then
            rdoSex1.Checked = True
        Else
            rdoSex2.Checked = True
        End If

        selectFirstRow()

        chkVal = 0 '0은 원래대로
    End Sub

    ''' <summary>
    ''' 저장버튼
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim vSex As Integer = 2
        Dim repStr As String = txtCall1.Text.Replace(" ", "")

        If rdoSex1.Checked Then
            vSex = 1 '남자
        End If

        If txtId.Text = "" Or txtPass.Text = "" Or txtName.Text = "" Or repStr.Length <> 13 Then
            MsgBox("全部入力してください")
            Return
        End If

        If chkVal = 1 Then
            sql = "insert into member(mLoginId,mPass,mName,mSex,mPhone,mRegDate,mEtc,mAddress,mAddress1) values ("
            sql += "'" & txtId.Text & "',"
            sql += "'" & txtPass.Text & "',"
            sql += "'" & txtName.Text & "',"
            sql += vSex & ","
            sql += "'" & txtCall1.Text & "',"
            sql += "'" & dateReg.Value & "',"
            sql += "'" & txtAreaEtc.Text & "',"
            sql += "'" & txtAddress1.Text & "',"
            sql += "'" + txtFullAddress.Text & "')"

            DCom.CommandText = sql
            DCom.ExecuteNonQuery()
            MsgBox("追加されました")
        ElseIf chkVal = 2 Then
            Dim rmId As Integer = DataGridView1("mId", DataGridView1.CurrentCell.RowIndex).Value

            sql = "UPDATE MEMBER SET "
            sql += "mPass='" & txtPass.Text & "',"
            sql += "mName='" & txtName.Text & "',"
            sql += "mSex=" & vSex & ","
            sql += "mPhone='" & txtCall1.Text & "',"
            sql += "mRegDate='" & dateReg.Value & "',"
            sql += "mEtc='" & txtAreaEtc.Text & "',"
            sql += "mAddress='" & txtAddress1.Text & "',"
            sql += "mAddress1='" & txtFullAddress.Text & "' "
            sql += "WHERE MID=" & rmId

            DCom.CommandText = sql
            DCom.ExecuteNonQuery()
            MsgBox("削除しました")
        ElseIf chkVal = 5 Then
            MsgBox("ID確認お願いします")
            txtId.Focus()
            Return
        End If

        btnCancel.PerformClick()
    End Sub

    ''' <summary>
    ''' 아이디체크
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnChk_Click(sender As Object, e As EventArgs) Handles btnChk.Click
        Dim rId = txtId.Text
        For i = 1 To DataGridView1.RowCount
            Dim vId = DataGridView1("mLoginId", i - 1).Value
            If rId.Equals(vId) Then
                MsgBox("重複されるIDがございます")
                Return
            End If
        Next
        txtId.Enabled = False
        btnChk.Enabled = False

        MsgBox("使用可能なIDです")
        chkVal = 1
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

        Dim rmId As Integer = DataGridView1("mId", DataGridView1.CurrentCell.RowIndex).Value
        sql = "DELETE FROM MEMBER WHERE MID=" & rmId
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

        DataGridView1.Enabled = False

        txtPass.Enabled = True
        txtName.Enabled = True
        rdoSex1.Enabled = True
        rdoSex2.Enabled = True
        txtCall1.Enabled = True
        dateReg.Enabled = True
        txtAddress1.Enabled = True
        txtFullAddress.Enabled = True
        txtAreaEtc.Enabled = True
    End Sub

    Private Sub selectFirstRow()
        If DataGridView1(2, 0).Value = "男" Then
            rdoSex1.Checked = True
        Else
            rdoSex2.Checked = True
        End If
        txtId.Text = DataGridView1(0, 0).Value
        txtName.Text = DataGridView1(1, 0).Value
        txtCall1.Text = DataGridView1(3, 0).Value
        dateReg.Value = DataGridView1(4, 0).Value
        txtAddress1.Text = DataGridView1(5, 0).Value
        txtFullAddress.Text = DataGridView1(6, 0).Value
        txtAreaEtc.Text = DataGridView1(7, 0).Value
        txtPass.Text = DataGridView1(9, 0).Value
    End Sub
End Class