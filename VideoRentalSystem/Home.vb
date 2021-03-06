'Import Data and SqlClient namespaces...
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmHome

    Dim objConnection As New SqlConnection()

    Dim objCommand As New SqlCommand
    Dim objDataAdaptor As New SqlDataAdapter
    Dim objDataAdaptor2 As New SqlDataAdapter
    Dim objDataAdaptor3 As New SqlDataAdapter
    Dim objDataSet As DataSet

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        objConnection.ConnectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString

    End Sub


    Private Sub frmHome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Showing today's date in frmhome
        Dim DateTimePicker1 As New DateTimePicker
        DateTimePicker1.Value = Date.Today
        lblDate.Text = "Today:  " & DateTimePicker1.Value

        lst10Due.Items.Clear()

        ' Checking for Due date
        Dim DateTimePicker2 As New DateTimePicker
        DateTimePicker2.Value = Date.Today

        Dim today0 As New Date
        today0 = DateTimePicker2.Value.Date

        Dim NowMinus5Days As Date
        NowMinus5Days = DateAdd(DateInterval.Day, -5, today0)
        ' MsgBox(NowMinus10Days)

        'Dim objSelectCommand7 As New SqlCommand
        'objSelectCommand7.Connection = objConnection

        ''SELECT command
        'objSelectCommand7.CommandText = _
        '"SELECT CustomerName " & _
        '"FROM Rent " & _
        '"WHERE (DateRented > " & NowMinus10Days & ") AND (Returned = 0)"

        'objConnection.Open()
        'Dim obj10Due As Object = objSelectCommand7.ExecuteScalar
        'objConnection.Close()
        ''MsgBox(obj10Due)

        'Dim objSelectCommand8 As New SqlCommand
        'objSelectCommand8.Connection = objConnection

        ''SELECT command 2
        'objSelectCommand8.CommandText = _
        '"SELECT Title " & _
        '"FROM Rent " & _
        '"WHERE (DateRented > " & NowMinus10Days & ") AND (Returned = 0)"

        'objConnection.Open()
        'Dim obj10DueTitle As Object = objSelectCommand8.ExecuteScalar
        'objConnection.Close()

        'lst10Due.Items.Add(obj10Due & "                         " & obj10DueTitle)

        Dim objDataSet5 As New DataSet
        Dim selectDataAdaptor10 As New SqlDataAdapter
        selectDataAdaptor10.SelectCommand = New SqlCommand

        selectDataAdaptor10.SelectCommand.Connection = objConnection

        selectDataAdaptor10.SelectCommand.CommandText = _
        "SELECT ID, Title, CustomerName, DateRented, Paid " & _
        "FROM Rent " & _
        "WHERE (DateRented > " & NowMinus5Days & ") AND (Returned = 0)"

        selectDataAdaptor10.Fill(objDataSet5, "MoreThan")
        selectDataAdaptor10.AcceptChangesDuringFill = True

        grdMoreThan10Days.DataSource = objDataSet5
        grdMoreThan10Days.DataMember = "MoreThan"

        'If grdMoreThan10Days.RowCount = 0 Then
        '    MessageBox.Show("No match found!", "SCIS - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Call btnRefresh_Click(Nothing, Nothing)
        'End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        txtSearchMovie.Text = ""
        txtSearchMovie.Focus()

        objDataAdaptor.SelectCommand = New SqlCommand()
        objDataAdaptor.SelectCommand.Connection = objConnection

        ' SELECT statement
        objDataAdaptor.SelectCommand.CommandText = _
        "SELECT ID, Title, Type, DateReleased, Actor, Description FROM Movie"

        objDataAdaptor.SelectCommand.CommandType = CommandType.Text

        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()

        ' Fill the DataSet object with data...
        objDataAdaptor.Fill(objDataSet, "Movies")

        ' My work

        grdMovies.DataSource = objDataSet

        grdMovies.DataMember = "Movies"

        'Shows the number of movies in the database
        Dim NoR As Integer
        NoR = grdMovies.RowCount

        lblMsg0.Text = "There are " & NoR & " movies in the database."

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        txtSearchAvi.Text = ""
        txtSearchAvi.Focus()

        objDataAdaptor2.SelectCommand = New SqlCommand()
        objDataAdaptor2.SelectCommand.Connection = objConnection

        ' SELECT statement
        objDataAdaptor2.SelectCommand.CommandText = _
        "SELECT ID, Title, CustomerName, DateRented FROM Rent WHERE Returned = 0"

        objDataAdaptor2.SelectCommand.CommandType = CommandType.Text

        ' Declare and Initialize a new instance of the DataSet object...
        Dim objDataSet2 As New DataSet

        ' Fill the DataSet object with data...
        objDataAdaptor2.Fill(objDataSet2, "Avialable")

        ' My work

        grdSearchAviMovies.DataSource = objDataSet2

        grdSearchAviMovies.DataMember = "Avialable"

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        txtReserveMovieID.Text = ""
        txtReserveMovieID.Focus()

        objDataAdaptor3.SelectCommand = New SqlCommand()
        objDataAdaptor3.SelectCommand.Connection = objConnection

        ' SELECT statement
        objDataAdaptor3.SelectCommand.CommandText = _
        "SELECT ReservationID AS RID, ID, Title, CustomerName AS [Cust Name], " & _
        "CustomerTel AS [Cust Tel] FROM Reservation WHERE Done = 0"

        objDataAdaptor3.SelectCommand.CommandType = CommandType.Text

        ' Declare and Initialize a new instance of the DataSet object...
        Dim objDataSet00 As New DataSet

        ' Fill the DataSet object with data...
        objDataAdaptor3.Fill(objDataSet00, "Reserved")

        ' My work

        grdReservation.DataSource = objDataSet00

        grdReservation.DataMember = "Reserved"

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Hide all the labels of # of characters allowed in ADD MOVIE
        lblID.Visible = False
        lblTitle.Visible = False
        lblType.Visible = False
        lblActor.Visible = False
        lblDesc.Visible = False
        lblDReleased.Visible = False
        lblDBought.Visible = False

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Hide all the labels of # of characters allowed in RENT MOVIE
        lblRID.Visible = False
        lblRTitle.Visible = False
        lblRCN.Visible = False
        lblRDR.Visible = False

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Hide all the labels of # of characters allowed in RESERVE MOVIE
        lblResID.Visible = False
        lblResTitle.Visible = False
        lblResCN.Visible = False
        lblResCT.Visible = False

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Hide all the labels of # of characters allowed in RETURN MOVIE
        lblReturnID.Visible = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim ID, title, type, dateReleased, dateBought, actor, description As String

        ID = txtID.Text
        title = txtTitle.Text
        type = cboType.Text
        'dateReleased = dtpDateReleased.Value.Date.ToString
        dateReleased = txtDateReleased.Text
        dateBought = dtpDateBought.Value.Date.ToString
        actor = txtActor.Text
        description = txtDescription.Text

        If ID.Equals("") Or title.Equals("") Or type.Equals("") Or dateReleased.Equals("") _
            Or dateBought.Equals("") Or actor.Equals("") Or description.Equals("") Then
            MessageBox.Show("Please fill all the empty text box(s)!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf ID.Length > 6 Or title.Length > 30 Or type.Length > 19 Or dateReleased.Length > 15 _
            Or actor.Length > 50 Or description.Length > 50 Then
            MessageBox.Show("Please check the number of characters allowed" & vbCrLf & _
            " which is written in yellow background!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMsg1.Text = "Please check the number of characters allowed which is written in yellow background!"

            lblID.Visible = True
            lblTitle.Visible = True
            lblType.Visible = True
            lblActor.Visible = True
            lblDesc.Visible = True
            lblDReleased.Visible = True
            lblDBought.Visible = True
        Else

            Dim objSelectCommand9 As New SqlCommand
            objSelectCommand9.Connection = objConnection

            'SELECT command to check for used ID
            objSelectCommand9.CommandText = _
            "SELECT ID " & _
            "FROM Movie " & _
            "WHERE ID = " & ID & ";"

            objConnection.Open()
            Dim objUsedID As Object = objSelectCommand9.ExecuteScalar
            objConnection.Close()

            If objUsedID <> "" Then
                MessageBox.Show("The ID you inserted is used. Please use another ID.", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtID.Text = ""
                txtID.Focus()
            Else
                Dim objInsertCommand As New SqlCommand
                objInsertCommand.Connection = objConnection

                'INSERT statement
                objInsertCommand.CommandText = _
                "INSERT INTO Movie " & _
                "(ID, Title, Type, DateReleased, DateBought, Actor, Description)" & _
                "VALUES (@ID, @title, @type, @dateReleased, @dateBought, @actor, @description);"

                objInsertCommand.Parameters.AddWithValue("@ID", ID)
                objInsertCommand.Parameters.AddWithValue("@title", title)
                objInsertCommand.Parameters.AddWithValue("@type", type)
                objInsertCommand.Parameters.AddWithValue("@dateReleased", dateReleased)
                objInsertCommand.Parameters.AddWithValue("@dateBought", dateBought)
                objInsertCommand.Parameters.AddWithValue("@actor", actor)
                objInsertCommand.Parameters.AddWithValue("@description", description)

                objConnection.Open()

                ' Execute the SqlCommand object to insert the new data...
                Try
                    objInsertCommand.ExecuteNonQuery()
                    MessageBox.Show("Movie is inserted Successfully!!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    objConnection.Close()
                    Call btnNew_Click(Nothing, Nothing)
                    Call btnRefresh_Click(Nothing, Nothing)

                Catch SqlExceptionErr As SqlException
                    MessageBox.Show(SqlExceptionErr.Message)
                    MessageBox.Show("Movie is NOT added!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                objConnection.Close()
            End If
        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        txtID.Text = ""
        txtTitle.Text = ""
        cboType.Text = ""
        txtDateReleased.Text = ""
        dtpDateBought.Value = Date.Now
        txtActor.Text = ""
        txtDescription.Text = ""

    End Sub

    Private Sub btnSearchGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchGo.Click

        Dim searchContent As String = txtSearchMovie.Text

        Dim selectDataAdaptor As New SqlDataAdapter
        selectDataAdaptor.SelectCommand = New SqlCommand

        selectDataAdaptor.SelectCommand.Connection = objConnection

        Dim searchBy As String
        searchBy = cboSearchBy.Text

        If (searchBy.Equals("Title")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT ID, Title, Type, DateReleased, Actor, Description  FROM Movie WHERE Title like '" & searchContent & "%'")
        ElseIf (searchBy.Equals("ID")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT ID, Title, Type, DateReleased, Actor, Description FROM Movie WHERE ID like '" & searchContent & "%'")
        ElseIf (searchBy.Equals("Type")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT ID, Title, Type, DateReleased, Actor, Description FROM Movie WHERE Type like '" & searchContent & "%'")
        ElseIf (searchBy.Equals("Actor")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT ID, Title, Type, DateReleased, Actor, Description FROM Movie WHERE Actor like '%" & searchContent & "%'")
        Else
            MessageBox.Show("Please check the Search By!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        selectDataAdaptor.Fill(objDataSet, "MoviesSearch")
        selectDataAdaptor.AcceptChangesDuringFill = True

        grdMovies.DataSource = objDataSet
        grdMovies.DataMember = "MoviesSearch"

        If grdMovies.RowCount = 0 Then
            MessageBox.Show("No match found!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call btnRefresh_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        txtSearchMovie.Text = ""
        frmHome_Load(Nothing, Nothing)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Call btnDeleteMovie_Click(Nothing, Nothing)

    End Sub

    Private Sub btnRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRent.Click

        Dim rentID, title, customerName, dateRented As String
        Dim paid As Integer

        rentID = txtRentID.Text
        title = txtRentTitle.Text
        customerName = txtCustName.Text
        dateRented = dtpDateRented.Value.Date.ToString

        If rentID.Equals("") Or title.Equals("") Or customerName.Equals("") Or dateRented.Equals("") Or rdbYes.Checked = False And rdbNo.Checked = False Then
            MessageBox.Show("Please fill all the empty text box(s)!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf rentID.Length > 6 Or title.Length > 30 Or customerName.Length > 30 Then
            MessageBox.Show("Please check the number of characters allowed" & vbCrLf & _
            " which is written in yellow background!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMsg2.Text = "Please check the number of characters allowed which is written in yellow background!"

            lblRID.Visible = True
            lblRTitle.Visible = True
            lblRCN.Visible = True
            lblRDR.Visible = True
        Else

            ' Create a new SqlCommand object...
            Dim maxRentIdCommand As SqlCommand = New SqlCommand _
            ("SELECT MAX(RentID) FROM Rent", objConnection)

            ' Open the connection, execute the command and close the connection
            objConnection.Open()
            Dim maxRentId As Object = maxRentIdCommand.ExecuteScalar
            objConnection.Close()

            ' Declare and set the strID variable to the value in MaxID...
            Dim strRentID As String
            strRentID = CType(maxRentId, String)
            strRentID += 1

            If rdbYes.Checked Then
                paid = 1
            ElseIf rdbNo.Checked Then
                paid = 0
            End If

            Dim objSelectCommand34 As New SqlCommand
            objSelectCommand34.Connection = objConnection

            'SELECT command to check for used ID
            objSelectCommand34.CommandText = _
            "SELECT ID " & _
            "FROM Rent " & _
            "WHERE ID = " & rentID & " AND Returned = 0;"

            objConnection.Open()
            Dim objUsedRentID As Object = objSelectCommand34.ExecuteScalar
            objConnection.Close()

            If objUsedRentID <> "" Then
                MessageBox.Show("The movie is NOT Returned.", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRentID.Text = ""
                txtRentID.Focus()
            Else
                Dim objInsertCommand As New SqlCommand
                objInsertCommand.Connection = objConnection

                'INSERT statement
                objInsertCommand.CommandText = _
                "INSERT INTO Rent " & _
                "(RentID, ID, Title, CustomerName, DateRented, Paid, Returned)" & _
                "VALUES (@RentID, @ID, @title, @customerName, @dateRented, @paid, @returned);"

                objInsertCommand.Parameters.AddWithValue("@RentID", strRentID)
                objInsertCommand.Parameters.AddWithValue("@ID", rentID)
                objInsertCommand.Parameters.AddWithValue("@title", title)
                objInsertCommand.Parameters.AddWithValue("@customerName", customerName)
                objInsertCommand.Parameters.AddWithValue("@dateRented", dateRented)
                objInsertCommand.Parameters.AddWithValue("@paid", paid)
                objInsertCommand.Parameters.AddWithValue("@returned", 0)

                objConnection.Open()

                ' Execute the SqlCommand object to insert the new data...
                Try
                    objInsertCommand.ExecuteNonQuery()
                    MessageBox.Show("Movie Rented Successfully!!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call btnNewRent_Click(Nothing, Nothing)

                Catch SqlExceptionErr As SqlException
                    MessageBox.Show(SqlExceptionErr.Message)
                    MessageBox.Show("Movie NOT rented!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                objConnection.Close()
            End If
        End If

    End Sub

    Private Sub txtRentID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRentID.LostFocus

        Dim rentID = txtRentID.Text
        Dim objSelectCommand0 As New SqlCommand
        objSelectCommand0.Connection = objConnection

        'SELECT command
        objSelectCommand0.CommandText = _
        "SELECT Title " & _
        "FROM Movie " & _
        "WHERE ID = '" & rentID & "';"

        objConnection.Open()
        Dim aviID As Object = objSelectCommand0.ExecuteScalar
        objConnection.Close()

        Dim avialableID As String
        avialableID = CType(aviID, String)

        If avialableID = "" Then
            MessageBox.Show("Invalid Movie ID!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRentID.Text = ""
            'txtRentID.Focus()
        End If

        txtRentTitle.Text = avialableID

    End Sub

    Private Sub btnNewRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRent.Click

        txtRentID.Text = ""
        txtRentTitle.Text = ""
        dtpDateRented.Value = Date.Now
        txtCustName.Text = ""
        rdbYes.Checked = False
        rdbNo.Checked = False

    End Sub


    Private Sub btnReserve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReserve.Click

        Dim ReserveMovieID, title, customerName As String
        Dim customerTel As Integer

        ReserveMovieID = txtReserveMovieID.Text
        title = txtReserveTitle.Text
        customerName = txtReserveCName.Text

        If ReserveMovieID.Equals("") Or title.Equals("") Or customerName.Equals("") Or txtCustTel.Text.ToString.Equals("") Then
            MessageBox.Show("Please fill all the empty text box(s)!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ReserveMovieID.Length > 6 Or title.Length > 30 Or customerName.Length > 30 Or customerTel.ToString.Length > 15 Then
            MessageBox.Show("Please check the number of characters allowed" & vbCrLf & _
            " which is written in yellow background!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMsg3.Text = "Please check the number of characters allowed which is written in yellow background!"

            lblResID.Visible = True
            lblResTitle.Visible = True
            lblResCN.Visible = True
            lblResCT.Visible = True
        Else
            customerTel = txtCustTel.Text

            ' Create a new SqlCommand object...
            Dim maxIdCommand As SqlCommand = New SqlCommand _
            ("SELECT MAX(ReservationID) FROM Reservation", objConnection)

            ' Open the connection, execute the command and close the connection
            objConnection.Open()
            Dim maxId As Object = maxIdCommand.ExecuteScalar
            objConnection.Close()

            ' Declare and set the strID variable to the value in MaxID...
            Dim strID As String
            strID = CType(maxId, String)
            strID += 1

            'SELECT command to check for used ID
            Dim objSelectCommand35 As New SqlCommand
            objSelectCommand35.Connection = objConnection
            objSelectCommand35.CommandText = _
            "SELECT ReservationID " & _
            "FROM Reservation " & _
            "WHERE ReservationID = " & strID & " AND customerName = '" & customerName & " AND Done = 0';"

            objConnection.Open()
            Dim objUsedReservedID As Object = objSelectCommand35.ExecuteScalar
            objConnection.Close()

            If objUsedReservedID <> "" Then
                MessageBox.Show("The movie is already Reserved.", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtReserveMovieID.Text = ""
                txtReserveMovieID.Focus()
            Else

                Dim objSelectCommand As New SqlCommand
                objSelectCommand.Connection = objConnection

                'SELECT command
                objSelectCommand.CommandText = _
                "SELECT ID " & _
                "FROM Rent " & _
                "WHERE ID = '" & ReserveMovieID & "';"

                objConnection.Open()
                Dim aviRentID As Object = objSelectCommand.ExecuteScalar
                objConnection.Close()

                Dim objSelectCommand2 As New SqlCommand
                objSelectCommand2.Connection = objConnection

                'SELECT command
                objSelectCommand2.CommandText = _
                "SELECT ID " & _
                "FROM Movie " & _
                "WHERE ID = '" & ReserveMovieID & "';"

                objConnection.Open()
                Dim aviMovieID As Object = objSelectCommand2.ExecuteScalar
                objConnection.Close()

                If aviRentID = "" And aviMovieID <> "" Then
                    MessageBox.Show("The movie is avialable!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf aviMovieID = "" Then
                    MessageBox.Show("The movie is not in the store at all!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim objInsertCommand As New SqlCommand
                    objInsertCommand.Connection = objConnection

                    'INSERT starement
                    objInsertCommand.CommandText = _
                    "INSERT INTO Reservation " & _
                    "(ReservationID, ID, Title, CustomerName, CustomerTel, Done)" & _
                    "VALUES (@ReservationID, @ReserveMovieID, @title, @customerName, @customerTel, @Done);"

                    objInsertCommand.Parameters.AddWithValue("@ReservationID", strID)
                    objInsertCommand.Parameters.AddWithValue("@ReserveMovieID", ReserveMovieID)
                    objInsertCommand.Parameters.AddWithValue("@title", title)
                    objInsertCommand.Parameters.AddWithValue("@customerName", customerName)
                    objInsertCommand.Parameters.AddWithValue("@customerTel", customerTel)
                    objInsertCommand.Parameters.AddWithValue("@Done", 0)

                    objConnection.Open()

                    ' Execute the SqlCommand object to insert the new data...
                    Try
                        objInsertCommand.ExecuteNonQuery()
                        MessageBox.Show("Movie Reserved Successfully!!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Dim objDataAdaptor13 As New SqlDataAdapter
                        objDataAdaptor13.SelectCommand = New SqlCommand()
                        objDataAdaptor13.SelectCommand.Connection = objConnection

                        ' SELECT statement
                        objDataAdaptor13.SelectCommand.CommandText = _
                        "SELECT ReservationID AS RID, ID, Title, CustomerName AS [Cust Name], " & _
                        "CustomerTel AS [Cust Tel] FROM Reservation WHERE Done = 0"

                        objDataAdaptor3.SelectCommand.CommandType = CommandType.Text

                        ' Declare and Initialize a new instance of the DataSet object...
                        Dim objDataSet13 As New DataSet

                        ' Fill the DataSet object with data...
                        objDataAdaptor13.Fill(objDataSet13, "Reserved")

                        ' My work

                        grdReservation.DataSource = objDataSet13

                        grdReservation.DataMember = "Reserved"

                        Call btnNewReservation_Click(Nothing, Nothing)

                    Catch SqlExceptionErr As SqlException
                        MessageBox.Show(SqlExceptionErr.Message)
                        MessageBox.Show("Movie NOT reserved!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    objConnection.Close()
                End If
            End If
        End If

    End Sub

    Private Sub txtReserveMovieID_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReserveMovieID.LostFocus

        Dim reserveMovieID = txtReserveMovieID.Text
        Dim objSelectCommand9 As New SqlCommand
        objSelectCommand9.Connection = objConnection

        'SELECT command
        objSelectCommand9.CommandText = _
        "SELECT Title " & _
        "FROM Movie " & _
        "WHERE ID = '" & reserveMovieID & "';"

        objConnection.Open()
        Dim aviID2 As Object = objSelectCommand9.ExecuteScalar
        objConnection.Close()

        Dim avialableID2 As String
        avialableID2 = CType(aviID2, String)

        If avialableID2 = "" Then
            MessageBox.Show("Invalid Movie ID!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtReserveMovieID.Text = ""
            'txtReserveMovieID.Focus()
        End If

        txtReserveTitle.Text = avialableID2

    End Sub

    Private Sub btnNewReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewReservation.Click

        txtReserveMovieID.Text = ""
        txtReserveTitle.Text = ""
        txtReserveCName.Text = ""
        txtCustTel.Text = ""

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click

        Dim MovieID As String

        MovieID = txtMovieID.Text

        If MovieID.Equals("") Then
            MessageBox.Show("Please fill all the empty text box(s)!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MovieID.Length > 6 Then
            MessageBox.Show("Please check the number of characters allowed" & vbCrLf & _
            " which is written in yellow background!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblMsg5.Text = "Please check the number of characters allowed which is written in yellow background!"

            lblReturnID.Visible = True
        Else
            Dim objSelectCommand As New SqlCommand
            objSelectCommand.Connection = objConnection

            'SELECT command
            objSelectCommand.CommandText = _
            "SELECT ID " & _
            "FROM Rent " & _
            "WHERE ID ='" & MovieID & "' AND Returned = 0;"

            objConnection.Open()
            Dim ObjMovieID As Object = objSelectCommand.ExecuteScalar
            objConnection.Close()

            Dim avialableMovieID As String
            avialableMovieID = CType(ObjMovieID, String)
            'MsgBox(avialableMovieID)

            If avialableMovieID = "" Then
                MessageBox.Show("The movie is NOT Rented!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMovieID.Text = ""
            Else

                Dim objSelectCommand2 As New SqlCommand
                objSelectCommand2.Connection = objConnection

                'SELECT command
                objSelectCommand2.CommandText = _
                "SELECT Returned " & _
                "FROM Rent " & _
                "WHERE ID LIKE '" & MovieID & "';"

                objConnection.Open()
                Dim onceReturned As Object = objSelectCommand2.ExecuteScalar
                objConnection.Close()

                If onceReturned = False Then

                    Dim objUpdateCommand As New SqlCommand
                    objUpdateCommand.Connection = objConnection

                    'UPDATE statement 
                    objUpdateCommand.CommandText = _
                    "UPDATE Rent " & _
                    "SET Returned = 1 " & _
                    "WHERE ID LIKE '" & avialableMovieID & "';"

                    objConnection.Open()

                    ' Execute the SqlCommand object to insert the new data...
                    Try
                        objUpdateCommand.ExecuteNonQuery()

                        '---------------------------------------------------------------------------------------------------

                        ' Checking for Due date
                        Dim DateTimePicker1 As New DateTimePicker
                        DateTimePicker1.Value = Date.Now

                        Dim today As New Date
                        today = DateTimePicker1.Value.Date

                        Dim objSelectCommand3 As New SqlCommand
                        objSelectCommand3.Connection = objConnection

                        'SELECT command
                        objSelectCommand3.CommandText = _
                        "SELECT DateRented " & _
                        "FROM Rent " & _
                        "WHERE ID = '" & MovieID & "';"

                        Dim objDateRented As Object = objSelectCommand3.ExecuteScalar

                        Dim strDateRented As String
                        strDateRented = CType(objDateRented, String)

                        Dim dateRented, properDate As Date
                        dateRented = CType(strDateRented, Date)

                        properDate = DateAdd(DateInterval.Day, 1, dateRented)

                        Dim dueDate, cost As Integer

                        If DateDiff(DateInterval.Day, properDate, today) > 0 Then

                            dueDate = DateDiff(DateInterval.Day, properDate, today)
                            cost = dueDate * 1  ' Actually means nothing

                            MessageBox.Show("You owe me " & dueDate & " Birr!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No due date!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        MessageBox.Show("Movie Returned Successfully!!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch SqlExceptionErr As SqlException
                        MessageBox.Show(SqlExceptionErr.Message)
                        MessageBox.Show("Movie NOT returned!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    objConnection.Close()

                ElseIf onceReturned = True Then
                    MessageBox.Show("The Movie is avialable!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                '---------------------------------------------------------------------------------------------------

                ' Checking if the returned movie is reserved
                'MsgBox("Reservation")
                Dim objSelectCommand4 As New SqlCommand
                objSelectCommand4.Connection = objConnection

                'SELECT command
                objSelectCommand4.CommandText = _
                "SELECT ID " & _
                "FROM Reservation " & _
                "WHERE ID ='" & MovieID & "';"

                objConnection.Open()
                Dim ObjReserved As Object = objSelectCommand4.ExecuteScalar
                objConnection.Close()

                'Dim reservedMovie As String
                'reservedMovie = CType(ObjReserved, String)

                If ObjReserved = "" Then
                    'MessageBox.Show("The movie is NOT Reserved!", "Video Rental System - Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim objSelectCommand5 As New SqlCommand
                    objSelectCommand5.Connection = objConnection

                    'SELECT command
                    objSelectCommand5.CommandText = _
                    "SELECT Done " & _
                    "FROM Reservation " & _
                    "WHERE ID = '" & MovieID & "';"

                    objConnection.Open()
                    Dim doneReserving As Object = objSelectCommand5.ExecuteScalar
                    objConnection.Close()

                    If doneReserving = False Then   ' If Done in Reservation table is 0
                        'MsgBox("Done")
                        Dim objSelectCommand6 As New SqlCommand
                        objSelectCommand6.Connection = objConnection

                        'SELECT command            ' select all - id, title,...
                        objSelectCommand6.CommandText = _
                        "SELECT CustomerName " & _
                        "FROM Reservation " & _
                        "WHERE ID ='" & MovieID & "';"

                        objConnection.Open()
                        Dim ObjCustomer As Object = objSelectCommand6.ExecuteScalar
                        objConnection.Close()
                        'MsgBox(ObjCustomer)

                        If ObjCustomer <> "" Then

                            MsgBox("This movie is RESERVED to " & ObjCustomer)

                            Dim objUpdateCommand2 As New SqlCommand
                            objUpdateCommand2.Connection = objConnection

                            'UPDATE statement               ' Set Done to 1 to show that it is not reserved anymore
                            objUpdateCommand2.CommandText = _
                            "UPDATE Reservation " & _
                            "SET Done = 1 " & _
                            "WHERE ID = '" & MovieID & "';"     ' *** reservedMovie

                            objConnection.Open()

                            ' Execute the SqlCommand object to insert the new data...
                            Try
                                objUpdateCommand2.ExecuteNonQuery()
                            Catch SqlExceptionErr As SqlException
                                MessageBox.Show(SqlExceptionErr.Message)
                                MessageBox.Show("Movie NOT DELETED FROM RESERVATION!!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try

                            objConnection.Close()
                            Call btnNewReturn_Click(Nothing, Nothing)
                        End If
                    End If
                End If
            End If
        End If ' ends he if at the beginning of frmReturn_click
    End Sub

    Private Sub btnNewReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewReturn.Click

        txtMovieID.Text = ""

    End Sub

    Private Sub btnShowRevenue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRevenue.Click

        Dim selectedDate As Date
        selectedDate = dtpRevenueDate.Value.Date

        Dim objSelectCommand As New SqlCommand
        objSelectCommand.Connection = objConnection

        'SELECT command           
        objSelectCommand.CommandText = _
        "SELECT Count(DateRented) " & _
        "FROM Rent " & _
        "WHERE DateRented = '" & selectedDate & "';"

        objConnection.Open()
        Dim ObjDate As Object = objSelectCommand.ExecuteScalar
        objConnection.Close()

        Dim noOfDate As Integer
        noOfDate = CType(ObjDate, Integer)

        If noOfDate <> 0 Then
            Dim rvn As Integer
            rvn = noOfDate * 1      ' 1 is money per movie

            MessageBox.Show("In the date " & selectedDate & ", " & noOfDate & " movies were rented." _
                            & vbCrLf & "And " & rvn & " Birr is recieved. ", "Video Rental System" _
                            , MessageBoxButtons.OK, MessageBoxIcon.Information)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Declare and Initialize a new instance of the DataSet object...
            Dim objDataSet2 As New DataSet

            Dim selectDataAdaptor2 As New SqlDataAdapter
            selectDataAdaptor2.SelectCommand = New SqlCommand

            selectDataAdaptor2.SelectCommand.Connection = objConnection

            selectDataAdaptor2.SelectCommand.CommandText = _
            ("SELECT * FROM Rent WHERE DateRented = '" & selectedDate & "';")

            selectDataAdaptor2.Fill(objDataSet2, "RevenueSearch")
            selectDataAdaptor2.AcceptChangesDuringFill = True

            grdRevenue.DataSource = objDataSet2
            grdRevenue.DataMember = "RevenueSearch"

            'If grdRevenue.RowCount = 0 Then
            '    MessageBox.Show("The customer has never rented a movie!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

        Else
            MessageBox.Show("No movie is rented in " & selectedDate, "Video Rental System" _
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim searchContent As String = txtSearchCustomer.Text

        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()

        Dim selectDataAdaptor As New SqlDataAdapter
        selectDataAdaptor.SelectCommand = New SqlCommand

        selectDataAdaptor.SelectCommand.Connection = objConnection

        selectDataAdaptor.SelectCommand.CommandText = _
        ("SELECT Title, DateRented, Returned FROM Rent WHERE CustomerName like '" & searchContent & "'")

        selectDataAdaptor.Fill(objDataSet, "CustomerSearch")
        selectDataAdaptor.AcceptChangesDuringFill = True

        grdCust.DataSource = objDataSet
        grdCust.DataMember = "CustomerSearch"

        If grdCust.RowCount = 0 Then
            MessageBox.Show("The customer has never rented a movie!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSearchCustomer.Text = ""
            txtSearchCustomer.Focus()
        End If

    End Sub

    Private Sub btnCustRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustRefresh.Click

        txtSearchCustomer.Text = ""
        grdCust.DataSource = Nothing
        grdCust.DataMember = Nothing

    End Sub

    Private Sub btnGoSearchAvi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoSearchAvi.Click

        Dim searchContent As String = txtSearchAvi.Text

        Dim selectDataAdaptor As New SqlDataAdapter
        selectDataAdaptor.SelectCommand = New SqlCommand

        selectDataAdaptor.SelectCommand.Connection = objConnection

        Dim selectDataAdaptor2 As New SqlDataAdapter
        selectDataAdaptor2.SelectCommand = New SqlCommand

        selectDataAdaptor2.SelectCommand.Connection = objConnection

        Dim searchBy As String
        searchBy = cboSearchAvi.Text

        If (searchBy.Equals("Title")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT RentID, ID, Title, CustomerName, DateRented FROM Rent WHERE Title = '" & searchContent & "%' AND Returned = 0")

            selectDataAdaptor2.SelectCommand.CommandText = _
            ("SELECT Title FROM Movie WHERE Title = '" & searchContent & "';")
        ElseIf (searchBy.Equals("ID")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT RentID, ID, Title, CustomerName, DateRented FROM Rent WHERE ID = '" & searchContent & "' AND Returned = 0")

            selectDataAdaptor2.SelectCommand.CommandText = _
            ("SELECT ID FROM Movie WHERE ID = '" & searchContent & "'")
        Else
            MessageBox.Show("Please check the Search By!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        selectDataAdaptor.Fill(objDataSet, "RentSearchAvi")
        selectDataAdaptor.AcceptChangesDuringFill = True

        selectDataAdaptor2.Fill(objDataSet, "MoviesSearchAvi")
        selectDataAdaptor2.AcceptChangesDuringFill = True

        grdSearchAviMovies.DataSource = objDataSet
        grdSearchAviMovies.DataMember = "MoviesSearchAvi"

        grdSearchAvi.DataSource = objDataSet
        grdSearchAvi.DataMember = "RentSearchAvi"

        If grdSearchAviMovies.RowCount <> 0 And grdSearchAvi.RowCount = 0 Then
            MessageBox.Show("The movie is avialable!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call btnRefreshAvi_Click(Nothing, Nothing)
        ElseIf grdSearchAviMovies.RowCount = 0 Then
            MessageBox.Show("The movie is NOT avialable in the Store!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call btnRefreshAvi_Click(Nothing, Nothing)
        Else
            MessageBox.Show("The movie is RENTED!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnRefreshAvi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshAvi.Click

        txtSearchAvi.Text = ""
        frmHome_Load(Nothing, Nothing)

        grdSearchAviMovies.DataSource = Nothing
        grdSearchAviMovies.DataMember = Nothing

        grdSearchAvi.DataSource = Nothing
        grdSearchAvi.DataMember = Nothing

    End Sub

    Private Sub btnDeleteMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteMovie.Click

        Dim i As Integer
        Dim deleteID As String

        i = grdMovies.CurrentRow.Index
        deleteID = grdMovies.Item(0, i).Value

        Dim objDeleteCommand As New SqlCommand
        objDeleteCommand.Connection = objConnection

        Dim answer As DialogResult
        answer = MessageBox.Show(Me, "Are you sure you want to delete user '" & deleteID & "'?", "Video Rental System - CONFIRMATION MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If answer.ToString.Equals("Yes") Then

            objDeleteCommand.CommandText = _
            "DELETE " & _
            "FROM Movie " & _
            "WHERE ID = '" & deleteID & "';"

            objConnection.Open()

            ' Execute the SqlCommand object to insert the new data...
            Try
                objDeleteCommand.ExecuteScalar()
                MessageBox.Show("Movie information deleted Successfully!!!", "Video Rental System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                objConnection.Close()
                Call btnRefresh_Click(Nothing, Nothing)
            Catch SqlExceptionErr As SqlException
                MessageBox.Show(SqlExceptionErr.Message)
                MessageBox.Show("Movie information NOT deleted!", "Video Rental System - Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            objConnection.Close()
        End If

    End Sub

    Private Sub btnMovieRateGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovieRateGo.Click

        Dim searchContent As String = txtMovieRateSearch.Text

        ' Initialize a new instance of the DataSet object...
        objDataSet = New DataSet()

        Dim selectDataAdaptor As New SqlDataAdapter
        selectDataAdaptor.SelectCommand = New SqlCommand

        selectDataAdaptor.SelectCommand.Connection = objConnection

        Dim searchBy As String
        searchBy = cboMovieRateSearchBy.Text

        If (searchBy.Equals("Title")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
            ("SELECT ID, Title, DateRented, CustomerName FROM Rent WHERE Title = '" & searchContent & "'")
        ElseIf (searchBy.Equals("ID")) Then
            selectDataAdaptor.SelectCommand.CommandText = _
           ("SELECT ID, Title, DateRented, CustomerName FROM Rent WHERE ID = '" & searchContent & "'")
        Else
            MessageBox.Show("Please check the Search By!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        selectDataAdaptor.Fill(objDataSet, "MovieRateSearch")
        selectDataAdaptor.AcceptChangesDuringFill = True

        'grdCust.c = 100

        grdMovieRate.DataSource = objDataSet
        grdMovieRate.DataMember = "MovieRateSearch"

        Dim j As Integer
        j += grdMovieRate.RowCount

        lblNoOfTimes.Text = "The movie is rented " & j & " times."
        lblNoOfTimes.Visible = True

        If grdMovieRate.RowCount = 0 Then
            MessageBox.Show("The movie has never been rented!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnMovieRateRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovieRateRefresh.Click

        txtMovieRateSearch.Text = ""
        grdMovieRate.DataSource = Nothing
        grdMovieRate.DataMember = Nothing
        lblNoOfTimes.Text = ""
        lblNoOfTimes.Visible = False

    End Sub

    Private Sub btnTotalRevenue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalRevenue.Click

        Dim begDate, endDate As Date
        begDate = dtpBegDate.Value.Date
        endDate = dtpEndDate.Value.Date

        Dim objSelectCommand As New SqlCommand
        objSelectCommand.Connection = objConnection

        'SELECT command           
        objSelectCommand.CommandText = _
        "SELECT Count(DateRented) " & _
        "FROM Rent " & _
        "WHERE DateRented >= '" & begDate & "' AND DateRented <= '" & endDate & "';"

        objConnection.Open()
        Dim ObjBEDate As Object = objSelectCommand.ExecuteScalar
        objConnection.Close()

        Dim noOfBEDate As Integer
        noOfBEDate = CType(ObjBEDate, Integer)

        If noOfBEDate <> 0 Then
            Dim rvn As Integer
            rvn = noOfBEDate * 1      ' 1 is money per movie

            MessageBox.Show("Between the dates " & begDate & " and " & endDate & " , " & noOfBEDate & " movies were rented." _
                            & vbCrLf & "And " & rvn & " Birr is recieved. ", "Video Rental System" _
                            , MessageBoxButtons.OK, MessageBoxIcon.Information)

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Declare and Initialize a new instance of the DataSet object...
            Dim objDataSet6 As New DataSet

            Dim selectDataAdaptor6 As New SqlDataAdapter
            selectDataAdaptor6.SelectCommand = New SqlCommand

            selectDataAdaptor6.SelectCommand.Connection = objConnection

            selectDataAdaptor6.SelectCommand.CommandText = _
            ("SELECT * FROM Rent WHERE DateRented >= '" & begDate & "' AND DateRented <= '" & endDate & "';")

            selectDataAdaptor6.Fill(objDataSet6, "BERevenueSearch")
            selectDataAdaptor6.AcceptChangesDuringFill = True

            grdRevenue.DataSource = objDataSet6
            grdRevenue.DataMember = "BERevenueSearch"

            'If grdRevenue.RowCount = 0 Then
            '    MessageBox.Show("The customer has never rented a movie!", "Video Rental System - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If

        Else
            MessageBox.Show("No movie is rented between " & begDate & " and " & endDate, "Video Rental System" _
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUser.Click

        frmCreateUserAccount.Show()
        Me.Close()

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        frmChangePassword.Show()
        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click

        frmHelp.Show()

        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(30, 100)

    End Sub
    Private Sub btnLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOff.Click

        VideoRentalSystem.frmUserLogin.frmUserLogin_Load(Nothing, Nothing)
        VideoRentalSystem.frmUserLogin.Show()
        VideoRentalSystem.frmUserLogin.txtPassword.Text = ""
        Me.Close()

    End Sub

    'Private Sub help()
    '    Dim helpprovider As Help
    '    helpprovider.ShowHelp(Me, "C:\Users\Biniam\Documents\Visual Studio 2005\Projects\VideoRentalSystem\Help\help.htm")
    '    ' Display the contents of the help file.
    '    'helpprovider.ShowHelp(Me, "c:\myhelpfile.chm")

    'End Sub

End Class