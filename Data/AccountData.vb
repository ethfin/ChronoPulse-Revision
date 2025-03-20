Imports MySql.Data.MySqlClient

Public Class AccountData
    Public Shared Property UserID As Integer
    Public Shared Property Username As String
    Public Shared Property HideNameInLeaderboard As Boolean
    Public Property AccountId As Integer
    Public Property DeletionRequestDate As DateTime?

    Public Shared Sub Clear()
        UserID = 0
        Username = String.Empty
        HideNameInLeaderboard = False
    End Sub

    Public Shared Sub MarkForDeletion(accountId As Integer, deletionRequestDate As DateTime)
        ' Update the account data in the database to mark it for deletion
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "UPDATE dbaccounts SET DeletionRequestDate = @DeletionRequestDate WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@DeletionRequestDate", deletionRequestDate)
                cmd.Parameters.AddWithValue("@UserID", accountId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub RemoveDeletionMark(accountId As Integer)
        ' Update the account data in the database to remove the deletion mark
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "UPDATE dbaccounts SET DeletionRequestDate = NULL WHERE UserID = @UserID"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", accountId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Sub DeleteExpiredAccounts()
        ' Get all accounts marked for deletion
        Dim accounts As List(Of AccountData) = GetAllAccountsMarkedForDeletion()
        For Each account In accounts
            If account.DeletionRequestDate.HasValue AndAlso (DateTime.Now - account.DeletionRequestDate.Value).Days >= 30 Then
                ' Delete the account
                DeleteAccount(account.AccountId)
            End If
        Next
    End Sub

    Private Shared Function GetAllAccountsMarkedForDeletion() As List(Of AccountData)
        Dim accounts As New List(Of AccountData)
        ' This is a placeholder for the actual database retrieval logic
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Dim query As String = "SELECT UserID, DeletionRequestDate FROM dbaccounts WHERE DeletionRequestDate IS NOT NULL"
            Using cmd As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim account As New AccountData()
                        account.AccountId = reader.GetInt32("UserID")
                        account.DeletionRequestDate = If(reader.IsDBNull(reader.GetOrdinal("DeletionRequestDate")), CType(Nothing, DateTime?), reader.GetDateTime("DeletionRequestDate"))
                        accounts.Add(account)
                    End While
                End Using
            End Using
        End Using
        Return accounts
    End Function

    Public Shared Sub DeleteAccount(accountId As Integer)
        ' Delete the user's data from related tables
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()
            Using transaction As MySqlTransaction = connection.BeginTransaction()
                Try
                    ' Delete from user_expenses
                    Dim queryExpenses As String = "DELETE FROM user_expenses WHERE UserID = @UserID"
                    Using cmdExpenses As New MySqlCommand(queryExpenses, connection, transaction)
                        cmdExpenses.Parameters.AddWithValue("@UserID", accountId)
                        cmdExpenses.ExecuteNonQuery()
                    End Using

                    ' Delete from user_income
                    Dim queryIncome As String = "DELETE FROM user_income WHERE UserID = @UserID"
                    Using cmdIncome As New MySqlCommand(queryIncome, connection, transaction)
                        cmdIncome.Parameters.AddWithValue("@UserID", accountId)
                        cmdIncome.ExecuteNonQuery()
                    End Using

                    ' Delete from user_experience
                    Dim queryExperience As String = "DELETE FROM user_experience WHERE UserID = @UserID"
                    Using cmdExperience As New MySqlCommand(queryExperience, connection, transaction)
                        cmdExperience.Parameters.AddWithValue("@UserID", accountId)
                        cmdExperience.ExecuteNonQuery()
                    End Using

                    ' Delete from dbaccounts
                    Dim queryAccount As String = "DELETE FROM dbaccounts WHERE UserID = @UserID"
                    Using cmdAccount As New MySqlCommand(queryAccount, connection, transaction)
                        cmdAccount.Parameters.AddWithValue("@UserID", accountId)
                        cmdAccount.ExecuteNonQuery()
                    End Using

                    ' Commit the transaction
                    transaction.Commit()
                Catch ex As Exception
                    ' Rollback the transaction in case of an error
                    transaction.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub
End Class
