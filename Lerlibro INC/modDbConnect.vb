Imports MySql.Data.MySqlClient
Module modDBConnection
    Public connect As New MySqlConnection
    Public reader As MySqlDataReader
    Public command As New MySqlCommand
    Public Adapter As New MySqlDataAdapter

    Public Sub dbConnect()
        connect = New MySqlConnection("server=localhost;uid=root;pwd='';database=lerlibro;")
        connect.Open()
    End Sub

    Public Sub dbDisconnect()
        connect.Close()
    End Sub

    Public Sub ExecuteQuery(query As String)
        command = New MySqlCommand(query, connect)
        reader = command.ExecuteReader

    End Sub
    Public Sub ExecuteQueryParameter(query As String)
        command = New MySqlCommand(query, connect)
    End Sub


    Public Sub disposeConnection()
        connect.Dispose()
    End Sub

End Module
