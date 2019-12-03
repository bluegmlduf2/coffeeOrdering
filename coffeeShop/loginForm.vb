Public Class loginForm
    Dim ds As DataSet
    Dim sql As String

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_Acces()
        txtID.Text = "1"
        txtPASS.Text = "1111"
    End Sub

    ''' <summary>
    ''' ID,PASSが空いていれば発生
    ''' </summary>
    ''' <returns></returns>
    Function IdPassCheck() As Boolean
        Dim sId As String = txtID.Text
        Dim sPs As String = txtPASS.Text

        If sId = "" Or sPs = "" Then
            MsgBox("IDとPASSWORDを入力してください", vbOKOnly, "確認")
            Return True
        End If
    End Function

    ''' <summary>
    ''' 顧客用のログインボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ds = New DataSet

        'ID,PASS텍스트 빈칸 체크 부분
        If IdPassCheck() Then
            Exit Sub
        End If

        Try
            sql = "Select mLoginId,mName from member "
            sql += "where mLoginId='" + txtID.Text + "' and mPass='" + txtPASS.Text + "'"
            DA = New OleDb.OleDbDataAdapter(sql, Con)
            DA.Fill(ds, "member")

            '찾는 멤버가 없을떄
            If ds.Tables("member").Rows.Count = 0 Then
                MsgBox("IDもしくはPASSWORDが間違いました", vbOKOnly, "確認")
                Return
            End If

            '전체변수에 박아둠
            vId = ds.Tables("member").Rows(0).Item(0).ToString '아이디
            vName = ds.Tables("member").Rows(0).Item(1) '이름

            txtID.Text = ""
            txtPASS.Text = ""

            MsgBox(vName + "様ようこそ")

            pointForm.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Error!!")
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' 職員専用のログインボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEmpLogin_Click(sender As Object, e As EventArgs) Handles btnEmpLogin.Click
        ds = New DataSet

        'ID,PASS텍스트 빈칸 체크 부분
        If IdPassCheck() Then
            Exit Sub
        End If

        Try
            sql = "Select eLoginId,eName,pId from employee "
            sql += "where eLoginId='" + txtID.Text + "' And ePass='" + txtPASS.Text + "'"
            DA = New OleDb.OleDbDataAdapter(sql, Con)
            DA.Fill(ds, "employee")

            '찾는 멤버가 없을떄
            If ds.Tables("employee").Rows.Count = 0 Then
                MsgBox("IDもしくはPASSWORDが間違いました", vbOKOnly, "確認")
                Return
            End If

            '전체변수에 박아둠
            vId = ds.Tables("employee").Rows(0).Item(0) '아이디
            vName = ds.Tables("employee").Rows(0).Item(1) '이름
            vRight = ds.Tables("employee").Rows(0).Item(2) '권한

            txtID.Text = ""
            txtPASS.Text = ""

            mainForm.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Error!!")
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private Sub loginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
