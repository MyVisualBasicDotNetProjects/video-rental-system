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
        txtOldPassword.Focus()

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
            MessageBox.Show("የተሳሳተ የሚስጥር ኮድ", "ፊልም ማከራያ ሲስተም", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                MessageBox.Show("የሚስጥር ኮድዎ በሥነሥርዓት ተቀይሩዋል", "ፊልም ማከራያ ሲስተም", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmHome.Show()
                Me.Close()
            Else
                MessageBox.Show("የተሳሳተ ማረጋገጫ!", "ፊልም ማከራያ ሲስተም", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        frmHome.Show() 'frmHome.Hide()
        Me.Dispose()

    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click

        Dim deleteUser As String
        deleteUser = VideoRentalSystem.frmUserLogin.loginName.Trim

        Dim objDeleteCommand As New SqlCommand
        objDeleteCommand.Connection = objConnection

        Dim answer As DialogResult
        answer = MessageBox.Show(Me, "እርግጠኛ ነዎት ተጠቃሚ '" & deleteUser & "'ን ማጥፋት ይፈልጋሉ?", "ፊልም ማከራያ ሲስተም", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If answer.ToString.Equals("Yes") Then

            objDeleteCommand.CommandText = _
                    "DELETE " & _
                    "FROM Users " & _
                    "WHERE UserName = '" & deleteUser & "';"

            objConnection.Open()

            ' Execute the SqlCommand object to insert the new data...
            Try
                objDeleteCommand.ExecuteScalar()
                MessageBox.Show("ተጠቃሚው በሥነሥርዓት ጠፍተዋል" & vbCrLf & "እባክዎን እንደሌላ ተጠቃሚ እንደገና ይግቡ ፤ እናመሰግናለን", "ፊልም ማከራያ ሲስተም", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmUserLogin.Show()
                Call frmUserLogin.frmUserLogin_Load(Nothing, Nothing)
                Me.Close()
            Catch SqlExceptionErr As SqlException
                MessageBox.Show(SqlExceptionErr.Message)
                MessageBox.Show("ተጠቃሚው አልጠፉም", "ፊልም ማከራያ ሲስተም", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            objConnection.Close()

        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        frmHelp.Show()
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(100, 100)

    End Sub
End Class