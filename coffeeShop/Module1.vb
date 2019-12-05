Module Module1
    Public vId As String
    Public vName As String
    Public vRight As String
    Public vPoint As Integer
    Public vPosition As String

    Public sql As String

    Public Con As New OleDb.OleDbConnection
    Public DCom As New OleDb.OleDbCommand
    Public DA As New OleDb.OleDbDataAdapter

    Public Sub DB_Acces()
        Dim My_con As String
        My_con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\YOON\Documents\coffeeShop.accdb"
        Con.ConnectionString = My_con
        DCom.Connection = Con
        Con.Open()
    End Sub
End Module
