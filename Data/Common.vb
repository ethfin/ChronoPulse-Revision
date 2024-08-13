Imports MySql.Data.MySqlClient

Module Common
    Private ReadOnly connectionString As String = "Database=chronopulsedb;" &
                                                  "Data Source=localhost;" &
                                                  "User id=projectDBAdmin;" &
                                                  "Password=1322LDSP;" &
                                                  "Port=3306;Command Timeout=600;"
    Private myDBConnection As MySqlConnection

    ' This function is used to get the connection to the database
    Public Function getDBConnectionX() As MySqlConnection
        If myDBConnection Is Nothing Then
            myDBConnection = New MySqlConnection(connectionString)
        End If
        Return myDBConnection
    End Function

    ' This function is used to create a new instance of the database connection
    Public Function createDBConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function
End Module
