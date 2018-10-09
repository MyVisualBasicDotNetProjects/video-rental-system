'Import Data and SqlClient namespaces...
Imports System.Data
Imports System.Data.SqlClient

Public Class frmChangePassword

    Dim objConnection As New SqlConnection("Server =(local);Database=Video_Store; Integrated Security= True;")
    Dim objDataAdaptor As New SqlDataAdapter
    Dim objCommand As New SqlCommand
    Dim userDataSet As DataSet
    Dim objDV As DataView

    Private Sub frmChangePassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblUserName.Text = VideoRentalSystem.frmUserLogin.loginName.Trim

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        Dim oldPassword, newPassword, confirmPassword, userName, rowCount As String

        oldPassword = txtOldPassword.Text
        newPassword = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text
        userName = lblUserName.Text

        ' Check the old password for authentication
        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT * from Users where UserName='" + lblUserName.Text + "'AND Password='" + oldPassword + "'"

        userDataSet = New DataSet()
        objDataAdaptor.Fill(userDataSet, "Users")

        'set the dataview object to the dataset object...
        objDV = New DataView(userDataSet.Tables("Users"))

        Dim objDataTable As DataTable

        objDataTable = userDataSet.Tables("Users")
        rowCount = (objDataTable.Rows.Count - 1)

        ' If no match is found
        If rowCount = -1 Then
            MessageBox.Show("Incorrect old password!")
            txtOldPassword.Text = ""
            txtOldPassword.Focus()
        Else

            If newPassword.Equals(confirmPassword) Then 'new passwords are same

                Dim objUpdateCommand As New SqlCommand
                objUpdateCommand.Connection = objConnection

                'UPDATE statement
                objUpdateCommand.CommandText = _
                "UPDATE Users " & _
                "SET password = '" & newPassword & "'" & _
                "WHERE username ='" & userName & "';"

                objConnection.Open()
                objUpdateCommand.ExecuteNonQuery()
                objConnection.Close()

                MessageBox.Show("Passwords successfully changed !!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Invalid Conformation!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        frmHome.Hide()
        Me.Hide()
        frmHome.Show()

    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click

        Dim deleteUser As String
        deleteUser = VideoRentalSystem.frmUserLogin.loginName.Trim

        Dim objDeleteCommand As New SqlCommand
        objDeleteCommand.Connection = objConnection

        Dim answer As DialogResult
        answer = MessageBox.Show(Me, "Are you sure you want to delete user '" & deleteUser & "'?", "Video Rental System - CONFIRMATION MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If answer.ToString.Equals("Yes") Then

            objDeleteCommand.CommandText = _
                    "DELETE " & _
                    "FROM Users " & _
                    "WHERE UserName = '" & deleteUser & "';"

            objConnection.Open()

            ' Execute the SqlCommand object to insert the new data...
            Try
                objDeleteCommand.ExecuteScalar()
                MessageBox.Show("User is deleted Successfully!!!" & vbCrLf & "Please Log in again a different user.", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmUserLogin.Show()
                Call frmUserLogin.frmUserLogin_Load(Nothing, Nothing)
                Me.Close()
            Catch SqlExceptionErr As SqlException
                MessageBox.Show(SqlExceptionErr.Message)
                MessageBox.Show("User is NOT deleted!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            objConnection.Close()

        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        frmHelp.Show()
        Me.Close()

    End Sub
End Class