Imports System.Data
Imports System.Data.SqlClient
Public Class frmUserLogin

    Dim objConnection As New SqlConnection("Server =(local); Database= Video_Store; Integrated Security= True;")

    Dim userDataSet As DataSet
    Dim objDV As DataView

    Dim objCommand As New SqlCommand

    ' Public Manager, SalesPerson As Boolean
    Public loginName As String

    Public Sub frmUserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        ' ''Me.Opacity = 0
        ' ''tr2.Start()

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

End Class





