Public Class empMngForm
    Dim ds As DataSet
    Dim chkVal As Integer = 0

    Private Sub costomerMngForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ds = New DataSet
        '1번그리드 초기화'
        sql = "SELECT eLoginId,eName,iif(eSex=1,'男','女')as eSex1,ePhone,eWorkDate,eStatus,e.pId,"
        sql += "iif(ISNULL(eEtc),'',eEtc)as sEtc ,eId,ePass,t.pName FROM EMPLOYEE e inner join positionT t on e.pid=t.pid order by e.pId"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_employee")

        With DataGridView1
            .DataSource = ds.Tables("d_employee")
            .Columns("eLoginId").HeaderText = "ID"
            .Columns("eName").HeaderText = "名前"
            .Columns("eSex1").HeaderText = "性別"
            .Columns("ePhone").HeaderText = "電話番号"
            .Columns("eWorkDate").HeaderText = "登録日"
            .Columns("pName").HeaderText = "職位"
            .Columns("sEtc").HeaderText = "ETC"
            .Columns("eStatus").HeaderText = "勤務日程"
            .Columns("eLoginId").Width = 60
            .Columns("pName").Width = 40
            .Columns("eName").Width = 60
            .Columns("eSex1").Width = 40
            .Columns("sEtc").Width = 200
            .Columns("eStatus").Width = 150
            .Columns("pId").Visible = False
            .Columns("ePass").Visible = False
            .Columns("eId").Visible = False
            .Columns("pName").DisplayIndex = 2

            .RowTemplate.Height = 40
            .ColumnHeadersHeight = 40
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Cornsilk
        End With

        '콤보박스 직위 초기화'
        sql = "SELECT pId,pName FROM positionT"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_position")

        Dim dictionary As New Dictionary(Of String, Integer)
        '넥사크로와 다르게 key가 표시되는값 value가 코드값
        For i = 0 To ds.Tables("d_position").Rows.Count - 1
            Dim valus As String = ds.Tables("d_position").Rows(i).Item(1).ToString() '밸류
            Dim key As Integer = ds.Tables("d_position").Rows(i).Item(0) '키
            dictionary.Add(valus, key)
        Next

        cmbPid.DataSource = New BindingSource(dictionary, Nothing)
        cmbPid.DisplayMember = "Key"
        cmbPid.ValueMember = "Value"

        '첫행 선택'
        selectFirstRow()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '문제점 헤더클릭 하면 에러.. 못 막겠음
        If DataGridView1(2, e.RowIndex).Value = "男" Then
            rdoSex1.Checked = True
        Else
            rdoSex2.Checked = True
        End If

        '출근요일'
        For i = 0 To 6
            chkBoxListStatus.SetItemChecked(i, False)
        Next
        selectDays()

        txtId.Text = DataGridView1(0, e.RowIndex).Value
        txtName.Text = DataGridView1(1, e.RowIndex).Value
        txtCall1.Text = DataGridView1(3, e.RowIndex).Value
        dateReg.Value = DataGridView1(4, e.RowIndex).Value
        cmbPid.Text = DataGridView1(10, e.RowIndex).Value
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
        cmbPid.Enabled = True
        chkBoxListStatus.Enabled = True
        txtAreaEtc.Enabled = True

        txtId.Text = ""
        txtName.Text = ""
        txtPass.Text = ""
        rdoSex1.Checked = True
        rdoSex2.Checked = False
        txtCall1.Text = ""
        dateReg.Value = Today
        cmbPid.SelectedIndex = 1
        txtAreaEtc.Text = ""
        For i = 0 To 6
            chkBoxListStatus.SetItemChecked(i, False)
        Next

        txtId.Focus()

        '행추가
        '동적으로 데이터셋을 박아준 경우에는 datagridview에 추가할수없고 table에 직접 박아 줘야함
        Dim newRow As DataRow = ds.Tables("d_employee").NewRow()
        ds.Tables("d_employee").Rows.Add(newRow)
        DataGridView1.CurrentCell = DataGridView1.Rows(ds.Tables("d_employee").Rows.Count - 1).Cells(0) '현재 선택된 행 변경..억지로 끼워맞춤
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
        cmbPid.Text = ""
        chkBoxListStatus.Text = ""
        txtAreaEtc.Text = ""

        DataGridView1.Enabled = True
        txtId.Enabled = False
        txtPass.Enabled = False
        txtName.Enabled = False
        rdoSex1.Enabled = False
        rdoSex2.Enabled = False
        txtCall1.Enabled = False
        dateReg.Enabled = False
        cmbPid.Enabled = False
        chkBoxListStatus.Enabled = False
        txtAreaEtc.Enabled = False

        ds.Clear()
        ds = New DataSet

        sql = "SELECT eLoginId,eName,iif(eSex=1,'男','女')as eSex1,ePhone,eWorkDate,eStatus,e.pId,"
        sql += "iif(ISNULL(eEtc),'',eEtc)as sEtc ,eId,ePass,t.pName FROM EMPLOYEE e inner join positionT t on e.pid=t.pid order by e.pId"
        DA = New OleDb.OleDbDataAdapter(sql, Con)
        DA.Fill(ds, "d_employee")
        DataGridView1.DataSource = ds.Tables("d_employee")

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

        '성별
        If rdoSex1.Checked Then
            vSex = 1 '남자
        End If

        '요일
        Dim chkedBoxVal As String = dayReturn()

        If txtId.Text = "" Or txtPass.Text = "" Or txtName.Text = "" Or repStr.Length <> 13 Or chkedBoxVal = "" Then
            MsgBox("全部入力してください")
            Return
        End If

        If chkVal = 1 Then
            sql = "insert into employee(eLoginId,ePass,eName,eSex,ePhone,eWorkDate,eEtc,eStatus,pId) values ("
            sql += "'" & txtId.Text & "',"
            sql += "'" & txtPass.Text & "',"
            sql += "'" & txtName.Text & "',"
            sql += vSex & ","
            sql += "'" & txtCall1.Text & "',"
            sql += "'" & dateReg.Value & "',"
            sql += "'" & txtAreaEtc.Text & "',"
            sql += "'" & chkedBoxVal & "',"
            sql += cmbPid.SelectedValue & ")"

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
            sql += "mAddress='" & cmbPid.Text & "',"
            ' sql += "mAddress1='" & txtFullAddress.Text & "' "
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
            Dim vId = DataGridView1("eLoginId", i - 1).Value
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
        cmbPid.Enabled = True
        chkBoxListStatus.Enabled = True
        txtAreaEtc.Enabled = True
    End Sub

    Private Sub selectFirstRow()
        '성별'
        If DataGridView1(2, 0).Value = "男" Then
            rdoSex1.Checked = True
        Else
            rdoSex2.Checked = True
        End If

        '요일'
        selectDays()

        txtId.Text = DataGridView1(0, 0).Value
        txtName.Text = DataGridView1(1, 0).Value
        txtCall1.Text = DataGridView1(3, 0).Value
        dateReg.Value = DataGridView1(4, 0).Value
        cmbPid.Text = DataGridView1(10, 0).Value
        txtAreaEtc.Text = DataGridView1(7, 0).Value
        txtPass.Text = DataGridView1(9, 0).Value
    End Sub

    Private Sub selectDays()
        '출근요일'
        Dim arr() As String = DataGridView1(5, 0).Value.ToString.Split(",")
        For i = 0 To arr.Length - 1
            Select Case arr(i)
                Case "月"
                    chkBoxListStatus.SetItemChecked(i, True)
                Case "火"
                    chkBoxListStatus.SetItemChecked(i, True)
                Case "水"
                    chkBoxListStatus.SetItemChecked(i, True)
                Case "木"
                    chkBoxListStatus.SetItemChecked(i, True)
                Case "金"
                    chkBoxListStatus.SetItemChecked(i, True)
                Case "土"
                    chkBoxListStatus.SetItemChecked(i, True)
                Case "日"
                    chkBoxListStatus.SetItemChecked(i, True)
            End Select
        Next
    End Sub

    Private Function dayReturn() As String
        '속성과 반환의 차이.. 속성은 그냥 걔가 원래 가진 값..반환은 메서드에 매개변수를 넣고 실행해서 반환받는 값 ex)toString()
        'Dim boxChecked As Integer = 1
        Dim chkedBoxVal = chkBoxListStatus.CheckedItems.Count 'selectedItems 하다가 개고생..
        Dim checkIndex() As Integer = chkBoxListStatus.CheckedIndices.Cast(Of Integer).ToArray '선택된값의 index

        Dim dayStr As String = ""

        If chkedBoxVal <> 0 Then
            For i = 0 To checkIndex.Count - 1
                Select Case checkIndex(i)
                    Case 0
                        dayStr += "月,"
                    Case 1
                        dayStr += "火,"
                    Case 2
                        dayStr += "水,"
                    Case 3
                        dayStr += "木,"
                    Case 4
                        dayStr += "金,"
                    Case 5
                        dayStr += "土,"
                    Case 6
                        dayStr += "日,"
                End Select
            Next
            dayStr = dayStr.Substring(0, dayStr.LastIndexOf(","))
        End If

        Return dayStr
    End Function
End Class