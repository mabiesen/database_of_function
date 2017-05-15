Imports System.Data
Imports System.Data.SqlClient
Public Module InputToDB

    Public Sub addToDb(name, purpose, tags, myimports, inputs, outputs, wholefunction)
        Dim cmd As New SqlCommand()
        Dim conn As SqlConnection

        conn = New SqlConnection("Data Source=DESKTOP-8RM4FLT\SQLEXPRESS;Database=mytest;Integrated Security=True")
        conn.Open()
        cmd = New SqlCommand("insert into Functions_Table([name],[purpose],[tags],[requirements],[inputs],[outputs],[wholefunction]) values ('" & name & "','" & purpose & "','" & tags & "','" & myimports & "','" & inputs & "','" & outputs & "','" & wholefunction & "')", conn)

        cmd.ExecuteNonQuery()

        conn.Close()
    End Sub

End Module
