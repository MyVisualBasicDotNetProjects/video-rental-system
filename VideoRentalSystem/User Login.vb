Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmUserLogin

    Dim objConnection As New SqlConnection()

    Dim userDataSet As DataSet
    Dim objDV As DataView

    Dim objCommand As New SqlCommand

    ' Public Manager, SalesPerson As Boolean
    Public loginName As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objConnection.ConnectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

    End Sub

    Public Sub frmUserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim trial As Date
        trial = Date.Today
        'MsgBox(trial)

        'If trial > "12/31/2008" Then

        '    Dim objUpdateCommand0 As New SqlCommand
        '    objUpdateCommand0.Connection = objConnection

        '    'UPDATE statement               ' Set Done to 1 to show that it is not reserved anymore
        '    objUpdateCommand0.CommandText = _
        '    "UPDATE Users " & _
        '    "SET Password = 'bakjwks'"

        '    objConnection.Open()

        '    ' Execute the SqlCommand object to change password of all users
        '    Try
        '        objUpdateCommand0.ExecuteNonQuery()
        '    Catch SqlExceptionErr As SqlException
        '        MessageBox.Show(SqlExceptionErr.Message)
        '    End Try

        '    objConnection.Close()

        '    Dim answer As DialogResult
        '    answer = MessageBox.Show(Me, "This software is trial." & vbCrLf & "Please contact the Programmer @ 0911-110855", "Video Rental System - EXPIRATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    If answer.ToString.Equals("OK") Then
        '        End
        '        'Me.Dispose()
        '    End If

        'ElseIf trial < "12/16/2008" Then

        '    Dim objUpdateCommand1 As New SqlCommand
        '    objUpdateCommand1.Connection = objConnection

        '    'UPDATE statement               ' Set Done to 1 to show that it is not reserved anymore
        '    objUpdateCommand1.CommandText = _
        '    "UPDATE Users " & _
        '    "SET Password = 'bakjwks'"

        '    objConnection.Open()

        '    ' Execute the SqlCommand object to change password of all users
        '    Try
        '        objUpdateCommand1.ExecuteNonQuery()
        '    Catch SqlExceptionErr As SqlException
        '        MessageBox.Show(SqlExceptionErr.Message)
        '    End Try

        '    objConnection.Close()

        '    Dim answer2 As DialogResult
        '    answer2 = MessageBox.Show(Me, "Your system date on your computer is not correct!" & vbCrLf & _
        '    "This software is trial." & vbCrLf & "Please contact the Programmer @ 0911-110855", _
        '    "Video Rental System - EXPIRATION MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    If answer2.ToString.Equals("OK") Then
        '        'Me.Dispose()
        '        End
        '    End If
        'End If

        ' ''Me.Opacity = 0
        ' ''tr2.Start()

        Call cboUserName_SelectedValueChanged(Nothing, Nothing)

        lblType.Hide()
        txtPassword.Text = ""
        txtPassword.Focus()

        Dim objDataAdaptor As New SqlDataAdapter

        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT UserName FROM Users ORDER BY UserName;"

        userDataSet = New DataSet()
        objDataAdaptor.Fill(userDataSet, "Users")
        cboUserName.DataSource = userDataSet.Tables("Users")

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Dim type As String
        'Type = lblType.Text.Trim
        loginName = cboUserName.Text

        Dim rowCount As String

        Dim objDataAdaptor1 As New SqlDataAdapter

        objDataAdaptor1.SelectCommand = New SqlCommand()
        objDataAdaptor1.SelectCommand.Connection = objConnection
        objDataAdaptor1.SelectCommand.CommandText = _
            "SELECT * from Users where UserName='" + cboUserName.Text + _
            "'AND Password='" + txtPassword.Text + "'"

        userDataSet = New DataSet()
        objDataAdaptor1.Fill(userDataSet, "Users")

        'set the dataview object to the dataset object...
        objDV = New DataView(userDataSet.Tables("Users"))
        Dim objDataTable As DataTable

        objDataTable = userDataSet.Tables("Users")
        rowCount = (objDataTable.Rows.Count - 1)

        If rowCount = -1 Then
            MessageBox.Show("Access Denied!", "Video Rental System - Exception Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtPassword.Focus()
        Else
            ' MessageBox.Show("Access Granted!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'If Type.Equals("Manager") Then

            '    Manager = True

            'ElseIf Type.Equals("Sales Person") Then
            '    SalesPerson = True

            '    'ElseIf type.Equals("Purchaser") Then
            '    '    Purchaser = True
            'Else
            '    MessageBox.Show("Unknown user type!")
            'End If

            frmHome.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub cboUserName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUserName.SelectedValueChanged

        txtPassword.Text = ""
        txtPassword.Focus()

    End Sub

    ' ''Private Sub tr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tr2.Tick

    ' ''    If Me.Opacity > 1 Then
    ' ''        tr2.Stop()
    ' ''    Else
    ' ''        Me.Opacity = Me.Opacity + 0.01
    ' ''    End If

    ' ''End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class





