'Import Data and SqlClient namespaces...
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCreateUserAccount

    Dim objConnection As New SqlConnection("Server =(local);Database=Video_Store; Integrated Security= True;")
    Dim objDataAdaptor As New SqlDataAdapter
    Dim objCommand As New SqlCommand
    Dim userDataSet As DataSet
    Dim objDV As DataView

    Private Sub Create_User_Account_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        txtUserName.Text = ""
        rdbManager.Checked = True

    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click

        Dim userName, Password, confirmPassword, type, rowCount As String
        userName = txtUserName.Text
        Password = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text

        If rdbManager.Checked Then
            type = rdbManager.Text
        Else
            type = rdbSalesPerson.Text
        End If

        If Password.Equals(confirmPassword) Then

            ' Check if the user name is used
            objDataAdaptor.SelectCommand = New SqlCommand()
            objDataAdaptor.SelectCommand.Connection = objConnection
            objDataAdaptor.SelectCommand.CommandText = _
            "SELECT * FROM Users WHERE UserName='" + userName + "';"

            userDataSet = New DataSet()
            objDataAdaptor.Fill(userDataSet, "AviUserName")

            'set the dataview object to the dataset object...
            objDV = New DataView(userDataSet.Tables("AviUserName"))

            Dim objDataTable As DataTable

            objDataTable = userDataSet.Tables("AviUserName")
            rowCount = objDataTable.Rows.Count

            ' If no match is found
            If rowCount <> 0 Then
                MessageBox.Show("The user name is avialable. Please use another user name!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserName.Text = ""
                txtUserName.Focus()
            Else
                Dim objInsertCommand As New SqlCommand
                objInsertCommand.Connection = objConnection

                'INSERT statement
                objInsertCommand.CommandText = _
                "INSERT INTO Users " & _
                "(UserName, Password,TypeOfUser)" & _
                "VALUES (@userName, @Password, @TypeOfUser);"

                objInsertCommand.Parameters.AddWithValue("@userName", userName)
                objInsertCommand.Parameters.AddWithValue("@Password", Password)
                objInsertCommand.Parameters.AddWithValue("@TypeOfUser", type)

                objConnection.Open()

                ' Execute the SqlCommand object to insert the new data...
                Try
                    objInsertCommand.ExecuteNonQuery()
                Catch SqlExceptionErr As SqlException
                    MessageBox.Show(SqlExceptionErr.Message)
                End Try

                objConnection.Close()

                MessageBox.Show("User Account Created Successfully!!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmHome.Show()
                Me.Close()
            End If

        Else
            MessageBox.Show("Invalid conformation!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        frmHome.Hide()
        Me.Hide()
        frmHome.Show()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        frmHelp.Show()
        Me.Close()

    End Sub
End Class