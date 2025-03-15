Imports MySql.Data.MySqlClient

Public Class frmDemo
    Private _CurrentContactPanelName As String = Nothing
    Private _ContactPanelsAddedCount As Integer = 0

    ' Load the user's expenses when the form loads
    Private Sub frmDemo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExpensePanels()
    End Sub

    Public Sub createCard()
        Dim contactPanel As New Panel With {
            .BackColor = Color.White,
            .Size = New Size(420, 50),
            .Name = "pnlContact" & (_ContactPanelsAddedCount + 1).ToString
        }

        flpMain.Controls.Add(contactPanel)
        _CurrentContactPanelName = contactPanel.Name
        _ContactPanelsAddedCount += 1
    End Sub

    Private Sub createCardDelete(panelName As String)
        Dim contactDeleteButton As New Button With {
            .AutoSize = False,
            .Size = New Size(90, 30),
            .BackColor = Color.Silver,
            .ForeColor = Color.Black,
            .Location = New Point(300, 10),
            .Name = "btnContactDelete" & _ContactPanelsAddedCount.ToString,
            .Text = "Delete"
        }

        Dim targetPanel As Panel = TryCast(flpMain.Controls(panelName), Panel)
        If targetPanel IsNot Nothing Then
            targetPanel.Controls.Add(contactDeleteButton)
            AddHandler contactDeleteButton.Click, AddressOf DynamicButton_Click
        End If
    End Sub

    Public Sub DynamicButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim deleteButton = TryCast(sender, Button)
        If deleteButton Is Nothing Then Return

        RemoveHandler deleteButton.Click, AddressOf DynamicButton_Click
        Dim parentPanel = TryCast(deleteButton.Parent, Panel)
        If parentPanel IsNot Nothing Then
            flpMain.Controls.Remove(parentPanel)
            parentPanel.Dispose()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Existing contact code
        createCard()
        createCardDelete(_CurrentContactPanelName)

        ' Load all user expenses in the panel
        LoadExpensePanels()
    End Sub

    Private Sub LoadExpensePanels()
        ' Clear any existing controls
        flpMain.Controls.Clear()

        ' Query the database for expenses
        Using connection As MySqlConnection = Common.createDBConnection()
            connection.Open()

            Dim query As String = "SELECT expense_id, Item, Cost, Category, Description, date " &
                                  "FROM user_expenses WHERE UserID = @UserID ORDER BY date DESC"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserID", AccountData.UserID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim expenseID As Integer = CInt(reader("expense_id"))
                        Dim item As String = reader("Item").ToString()
                        Dim cost As Decimal = CDec(reader("Cost"))
                        Dim category As String = reader("Category").ToString()
                        Dim description As String = reader("Description").ToString()
                        Dim expenseDate As DateTime = CDate(reader("date"))

                        ' Create a panel for each expense record
                        CreateExpensePanel(expenseID, item, cost, category, description, expenseDate)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub CreateExpensePanel(expenseID As Integer, item As String, cost As Decimal,
                               category As String, description As String, expenseDate As DateTime)

        Dim expensePanel As New Panel With {
        .BackColor = Color.White,
        .Size = New Size(420, 60),
        .Name = "pnlExpense" & expenseID.ToString()
    }

        ' Example labels for displaying expense data
        Dim lblItem As New Label With {
        .Text = "Item: " & item,
        .Location = New Point(10, 10),
        .AutoSize = True
    }
        expensePanel.Controls.Add(lblItem)

        Dim lblCost As New Label With {
        .Text = "Cost: $" & cost.ToString("F2"),
        .Location = New Point(10, 30),
        .AutoSize = True
    }
        expensePanel.Controls.Add(lblCost)

        Dim lblCategory As New Label With {
        .Text = "Category: " & category,
        .Location = New Point(130, 10),
        .AutoSize = True
    }
        expensePanel.Controls.Add(lblCategory)

        Dim lblDate As New Label With {
        .Text = "Date: " & expenseDate.ToShortDateString(),
        .Location = New Point(130, 30),
        .AutoSize = True
    }
        expensePanel.Controls.Add(lblDate)

        ' Optional: display description (could be in a separate label or tooltip)
        Dim lblDescription As New Label With {
        .Text = "Desc: " & description,
        .Location = New Point(260, 10),
        .AutoSize = True
    }
        expensePanel.Controls.Add(lblDescription)

        ' Create a delete button
        Dim deleteButton As New Button With {
        .Text = "Remove",
        .Size = New Size(80, 25),
        .Location = New Point(320, 25),
        .Name = "btnDeleteExpense" & expenseID.ToString()
    }
        AddHandler deleteButton.Click, Sub(sender, e) DeleteExpense(expenseID, expensePanel)
        expensePanel.Controls.Add(deleteButton)

        ' Add this panel to the FlowLayoutPanel
        flpMain.Controls.Add(expensePanel)
    End Sub

    Private Sub DeleteExpense(expenseID As Integer, panelToRemove As Panel)
        ' First remove from DB
        Dim confirm = MessageBox.Show("Remove expense?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Using connection As MySqlConnection = Common.createDBConnection()
                connection.Open()
                Dim query As String = "DELETE FROM user_expenses WHERE expense_id = @ID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", expenseID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Remove the panel from the flow layout
            flpMain.Controls.Remove(panelToRemove)
            panelToRemove.Dispose()
        End If
    End Sub

End Class
