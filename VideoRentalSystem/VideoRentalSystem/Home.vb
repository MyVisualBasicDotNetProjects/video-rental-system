'Import Data and SqlClient namespaces...
Imports System.Data
Imports System.Data.SqlClient
Public Class frmHome

    Dim objConnection As New SqlConnection("Server =(local);Database=Video_Store; Integrated Security= True;")

    Dim objCommand As New SqlCommand
    Dim objDataAdaptor As New SqlDataAdapter
    Dim objDataAdaptor2 As New SqlDataAdapter
    Dim objDataAdaptor3 As New SqlDataAdapter
    Dim objDataSet As DataSet

    Private Sub frmHome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Showing today's date in frmhome
        Dim DateTimePicker1 As New DateTimePicker
        DateTimePicker1.Value = Date.Today
        lblDate.Text = "Today:  " & DateTimePicker1.Value

        lst10Due.Items.Clear()

        ' Checking for Due date
        Dim DateTimePicker2 As New DateTimePicker
        DateTimePicker2.Value = Date.Now

        Dim today As New Date
        today = DateTimePicker2.Value.Date

        Dim NowMinus10Days As Date
        NowMinus10Days = DateAdd(DateInterval.Day, -10, today)

        Dim objSelectCommand7 As New SqlCommand
        objSelectCommand7.Connection = objConnection

        'SELECT command
        objSelectCommand7.CommandText = _
        "SELECT CustomerName " & _
        "FROM Rent " & _
        "WHERE DateRented > " & NowMinus10Days & ";"

        objConnection.Open()
        Dim obj10Due As Object = objSelectCommand7.ExecuteScalar
        objConnection.Close()

        Dim objSelectCommand8 As New SqlCommand
        objSelectCommand8.Connection = objConnection

        'SELECT command 2
        objSelectCommand8.CommandText = _
        "SELECT Title " & _
        "FROM Rent " & _
        "WHERE DateRented > " & NowMinus10Days & ";"

        objConnection.Open()
        Dim obj10DueTitle As Object = objSelectCommand7.ExecuteScalar
        objConnection.Close()

        lst10Due.Items.Add(obj10Due & "                         " & obj10DueTitle)

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

        grdSearchAvi.DataSource = objDataSet2

        grdSearchAvi.DataMember = "Avialable"

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

        ElseIf ID.Length > 6 Or title.Length > 30 Or type.Length > 10 Or dateReleased.Length > 15 _
            Or dateBought.Length > 8 Or actor.Length > 50 Or description.Length > 50 Then
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

            Dim objInsertCommand As New SqlCommand
            objInsertCommand.Connection = objConnection

            'INSERT statement
            objInsertCommand.CommandText = _
            "INSERT INTO Movie " & _
            "(ID, Title, Type, DateReleased, DateBought, Actor, Description)" & _
            "VALUES (@ID, @title, @type, @dateReleased, @dateBought,  ~dulla^@204~ ~dulla^@204~             objInsertCommand.Paramete~dulla^@204~ ue("@ID", ID)
            objInsertC~dulla^@204~ ters.AddWithValue("@title", title)
 ~dulla^@204~ jInsertCommand.Parameters.AddWithValu~dulla^@204~ pe)
            objInsertCommand.Par~dulla^@204~ thValue("@dateReleased", dateReleased~dulla^@204~   objInsertCommand.Parameters.AddWith~dulla^@204~ ought", dateBought)
            objI~dulla^@204~ Parameters.AddWithValue("@actor", act~dulla^@204~     objInsertCommand.Parameters.AddWi~dulla^@204~ cription", description)

          ~dulla^@204~ on.Open()

            ' Execute th~dulla^@204~ object to insert the new data...
   ~dulla^@204~ 
                objInsertCommand.Exe~dulla^@204~ )
                MessageBox.Show("M~dulla^@204~ ted Successfully!!!", "Video Rental S~dulla^@204~ geBoxButtons.OK, MessageBoxIcon.Infor~dulla^@204~             objConnection.Close()
  ~dulla^@204~  Call btnRefresh_Click(Nothing, Nothi~dulla^@204~     Catch SqlExceptionErr As SqlExcep~dulla^@204~          MessageBox.Show(SqlException~dulla^@204~ 
                MessageBox.Show("Mov~dulla^@204~ ed!", "Video Rental System - Exceptio~dulla^@204~ essageBoxButtons.OK, MessageBoxIcon.E~dulla^@204~       End Try

            objConne~dulla^@204~ 
        End If

    End Sub

  ~dulla^@204~  btnNew_Click(ByVal sender As System.~dulla^@204~  e As System.EventArgs) Handles btnNe~dulla^@204~       txtID.Text = ""
        txtTit~dulla^@204~ 
        cboType.Text = ""
        t~dulla^@204~ d.Text = ""
        dtpDateBought.Va~dulla^@204~ w
        txtActor.Text = ""
      ~dulla^@204~ ion.Text = ""

    End Sub

    P~dulla^@204~ nSearchGo_Click(ByVal sender As Syste~dulla^@204~ al e As System.EventArgs) Handles btn~dulla^@204~ k

        Dim searchContent As Str~dulla^@204~ chMovie.Text

        Dim selectDat~dulla^@204~ ew SqlDataAdapter
        selectData~dulla^@204~ tCommand = New SqlCommand

        ~dulla^@204~ ptor.SelectCommand.Connection = objCo~dulla^@204~        Dim searchBy As String
      ~dulla^@204~ cboSearchBy.Text

        If (searc~dulla^@204~ itle")) Then
            selectDataA~dulla^@204~ Command.CommandText = _
            ~dulla^@204~ Title, Type, DateReleased, Actor  FRO~dulla^@204~  Title like '" & searchContent & "%'"~dulla^@204~ seIf (searchBy.Equals("ID")) Then
  ~dulla^@204~ ectDataAdaptor.SelectCommand.CommandT~dulla^@204~         ("SELECT ID, Title, Type, Dat~dulla^@204~ tor FROM Movie WHERE ID like '" & sea~dulla^@204~ "%'")
        ElseIf (searchBy.Equal~dulla^@204~ en
            selectDataAdaptor.Sel~dulla^@204~ mmandText = _
            ("SELECT I~dulla^@204~ e, DateReleased, Actor FROM Movie WHE~dulla^@204~ '" & searchContent & "%'")
        E~dulla^@204~     MessageBox.Show("Please check the~dulla^@204~  "Video Rental System - Search Except~dulla^@204~ BoxButtons.OK, MessageBoxIcon.Error)~dulla^@204~ If

        selectDataAdaptor.Fill(~dulla^@204~ MoviesSearch")
        selectDataAda~dulla^@204~ angesDuringFill = True

        grd~dulla^@204~ urce = objDataSet
        grdMovies.~dulla^@204~ "MoviesSearch"

        If grdMovie~dulla^@204~ 0 Then
            MessageBox.Show("~dulla^@204~ d!", "Video Rental System - Search Ex~dulla^@204~ sageBoxButtons.OK, MessageBoxIcon.Err~dulla^@204~     Call btnRefresh_Click(Nothing, No~dulla^@204~    End If

    End Sub

    Priva~dulla^@204~ resh_Click(ByVal sender As System.Obj~dulla^@204~ As System.EventArgs) Handles btnRefre~dulla^@204~        txtSearchMovie.Text = ""
    ~dulla^@204~ oad(Nothing, Nothing)

    End Sub~dulla^@204~ e Sub btnDelete_Click(ByVal sender As~dulla^@204~ t, ByVal e As System.EventArgs) Handl~dulla^@204~ Click

        Call btnDeleteMovie_~dulla^@204~ , Nothing)

    End Sub

    Priv~dulla^@204~ nt_Click(ByVal sender As System.Objec~dulla^@204~  System.EventArgs) Handles btnRent.Cl~dulla^@204~   Dim rentID, title, customerName, da~dulla^@204~ tring
        Dim paid As Integer
~dulla^@204~ ID = txtRentID.Text
        title = ~dulla^@204~ Text
        customerName = txtCustN~dulla^@204~      dateRented = dtpDateRented.Value~dulla^@204~ g

        If rentID.Equals("") Or ~dulla^@204~ "") Or customerName.Equals("") Or dat~dulla^@204~ s("") Or rdbYes.Checked = False Or rd~dulla^@204~  False Then
            MessageBox.S~dulla^@204~ ill all the empty text box(s)!", "Vid~dulla^@204~ tem - Exception Message", MessageBoxB~dulla^@204~ ssageBoxIcon.Error)
        ElseIf r~dulla^@204~ > 6 Or title.Length > 30 Or customerN~dulla^@204~ 30 Or dateRented.Length > 8 Then
   ~dulla^@204~ ageBox.Show("Please check the number ~dulla^@204~  allowed" & vbCrLf & _
            "~dulla^@204~ tten in yellow background!", "Video R~dulla^@204~ - Exception Message", MessageBoxButto~dulla^@204~ eBoxIcon.Error)
            lblMsg2.~dulla^@204~ e check the number of characters allo~dulla^@204~ written in yellow background!"

   ~dulla^@204~ ID.Visible = True
            lblRTi~dulla^@204~  True
            lblRCN.Visible = T~dulla^@204~     lblRDR.Visible = True
        El~dulla^@204~    If rdbYes.Checked Then
          ~dulla^@204~ 1
            ElseIf rdbNo.Checked T~dulla^@204~         paid = 0
            End If~dulla^@204~   Dim objInsertCommand As New SqlComm~dulla^@204~     objInsertCommand.Connection = obj~dulla^@204~ 
            'INSERT starement
     ~dulla^@204~ ertCommand.CommandText = _
         ~dulla^@204~ TO Rent " & _
            "(ID, Titl~dulla^@204~ me, DateRented, Paid, Returned)" & _~dulla^@204~ "VALUES (@ID, @title, @customerName, ~dulla^@204~ @paid, @returned);"

            ob~dulla^@204~ d.Parameters.AddWithValue("@ID", rent~dulla^@204~     objInsertCommand.Parameters.AddWi~dulla^@204~ le", title)
            objInsertCom~dulla^@204~ rs.AddWithValue("@customerName", cust~dulla^@204~           objInsertCommand.Parameters~dulla^@204~ ("@dateRented", dateRented)
        ~dulla^@204~ Command.Parameters.AddWithValue("@pai~dulla^@204~           objInsertCommand.Parameters~dulla^@204~ ("@returned", 0)

            objCo~dulla^@204~ ()

            ' Execute the SqlCo~dulla^@204~ to insert the new data...
          ~dulla^@204~           objInsertCommand.ExecuteNon~dulla^@204~             MessageBox.Show("Movie Re~dulla^@204~ ully!!!", "Video Rental System", Mess~dulla^@204~ .OK, MessageBoxIcon.Information)
   ~dulla^@204~ h SqlExceptionErr As SqlException
  ~dulla^@204~  MessageBox.Show(SqlExceptionErr.Mess~dulla^@204~          MessageBox.Show("Movie NOT r~dulla^@204~ eo Rental System - Exception Message"~dulla^@204~ uttons.OK, MessageBoxIcon.Error)
   ~dulla^@204~ Try

            objConnection.Clos~dulla^@204~ End If

    End Sub

    Private ~dulla^@204~ _LostFocus(ByVal sender As System.Obj~dulla^@204~ As System.EventArgs) Handles txtRentI~dulla^@204~ 
        Dim rentID = txtRentID.Text~dulla^@204~  objSelectCommand0 As New SqlCommand~dulla^@204~ electCommand0.Connection = objConnect~dulla^@204~   'SELECT command
        objSelectC~dulla^@204~ ndText = _
        "SELECT Title " &~dulla^@204~ FROM Movie " & _
        "WHERE ID =~dulla^@204~ & "';"

        objConnection.Open(~dulla^@204~ m aviID As Object = objSelectCommand0~dulla^@204~ r
        objConnection.Close()

 ~dulla^@204~ ialableID As String
        avialabl~dulla^@204~ viID, String)

        If avialable~dulla^@204~ 
            MessageBox.Show("Invalid~dulla^@204~ "Video Rental System - Exception Mess~dulla^@204~ BoxButtons.OK, MessageBoxIcon.Error)~dulla^@204~ txtRentID.Text = ""
            'txt~dulla^@204~ )
        End If

        txtRentT~dulla^@204~ vialableID

    End Sub

    Priv~dulla^@204~ wRent_Click(ByVal sender As System.Ob~dulla^@204~  As System.EventArgs) Handles btnNewR~dulla^@204~         txtRentID.Text = ""
        ~dulla^@204~ Text = ""
        dtpDateRented.Valu~dulla^@204~ 
        txtCustName.Text = ""
     ~dulla^@204~ cked = False
        rdbNo.Checked =~dulla^@204~  End Sub


    Private Sub btnRese~dulla^@204~ al sender As System.Object, ByVal e A~dulla^@204~ tArgs) Handles btnReserve.Click

        Dim ReserveMovieID, title, customerN~dulla^@204~ 
        Dim customerTel As Integer~dulla^@204~ serveMovieID = txtReserveMovieID.Text~dulla^@204~ le = txtReserveTitle.Text
        cu~dulla^@204~ txtReserveCName.Text

        If Re~dulla^@204~ Equals("") Or title.Equals("") Or cus~dulla^@204~ als("") Or txtCustTel.Text.ToString.E~dulla^@204~ n
            MessageBox.Show("Pleas~dulla^@204~ e empty text box(s)!", "Video Rental ~dulla^@204~ ption Message", MessageBoxButtons.OK,~dulla^@204~ on.Error)
        ElseIf ReserveMovi~dulla^@204~ 6 Or title.Length > 30 Or customerNam~dulla^@204~  Or customerTel.ToString.Length > 15 ~dulla^@204~      MessageBox.Show("Please check th~dulla^@204~ haracters allowed" & vbCrLf & _
    ~dulla^@204~ ch is written in yellow background!",~dulla^@204~ l System - Exception Message", Messag~dulla^@204~ K, MessageBoxIcon.Error)
           ~dulla^@204~  = "Please check the number of charac~dulla^@204~ which is written in yellow background~dulla^@204~      lblResID.Visible = True
       ~dulla^@204~ tle.Visible = True
            lblRe~dulla^@204~  True
            lblResCT.Visible =~dulla^@204~   Else
            customerTel = txt~dulla^@204~ 
            ' Create a new SqlComman~dulla^@204~             Dim maxIdCommand As SqlCo~dulla^@204~ qlCommand _
            ("SELECT COU~dulla^@204~ nID) FROM Reservation", objConnection~dulla^@204~     ' Open the connection, execute th~dulla^@204~  close the connection
            ob~dulla^@204~ pen()
            Dim maxId As Objec~dulla^@204~ and.ExecuteScalar
            objCon~dulla^@204~ ()

            ' Declare and set t~dulla^@204~ able to the value in MaxID...
      ~dulla^@204~ ID As String
            strID = CTy~dulla^@204~ ing)
            strID += 1

     ~dulla^@204~ jSelectCommand As New SqlCommand
   ~dulla^@204~ electCommand.Connection = objConnecti~dulla^@204~      'SELECT command
            obj~dulla^@204~ .CommandText = _
            "SELECT~dulla^@204~           "FROM Rent " & _
         ~dulla^@204~ = '" & ReserveMovieID & "';"

     ~dulla^@204~ nection.Open()
            Dim aviID~dulla^@204~ objSelectCommand.ExecuteScalar
     ~dulla^@204~ nection.Close()

            If avi~dulla^@204~ 
                MessageBox.Show("The~dulla^@204~ her avialable or not in the store at ~dulla^@204~  Rental System - Exception Message", ~dulla^@204~ tons.OK, MessageBoxIcon.Error)
     ~dulla^@204~ 

            Dim objInsertCommand ~dulla^@204~ mand
            objInsertCommand.Co~dulla^@204~ jConnection

            'INSERT st~dulla^@204~         objInsertCommand.CommandText ~dulla^@204~     "INSERT INTO Reservation " & _
 ~dulla^@204~ ReservationID, ID, Title, CustomerNam~dulla^@204~ l, Done)" & _
            "VALUES (@~dulla^@204~ , @ReserveMovieID, @title, @customerN~dulla^@204~ rTel, @Done);"

            objInse~dulla^@204~ ameters.AddWithValue("@ReservationID"~dulla^@204~          objInsertCommand.Parameters.~dulla^@204~ "@ReserveMovieID", ReserveMovieID)
 ~dulla^@204~ jInsertCommand.Parameters.AddWithValu~dulla^@204~ itle)
            objInsertCommand.P~dulla^@204~ WithValue("@customerName", customerNa~dulla^@204~     objInsertCommand.Parameters.AddWi~dulla^@204~ tomerTel", customerTel)
            ~dulla^@204~ and.Parameters.AddWithValue("@Done", ~dulla^@204~      objConnection.Open()

        ~dulla^@204~  the SqlCommand object to insert the ~dulla^@204~             Try
                objI~dulla^@204~ ExecuteNonQuery()
                Me~dulla^@204~ ("Movie Reserved Successfully!!!", "V~dulla^@204~ ystem", MessageBoxButtons.OK, Message~dulla^@204~ mation)
            Catch SqlExcepti~dulla^@204~ xception
                MessageBox.~dulla^@204~ tionErr.Message)
                Mes~dulla^@204~ "Movie NOT reserved!", "Video Rental ~dulla^@204~ ption Message", MessageBoxButtons.OK,~dulla^@204~ on.Error)
            End Try

   ~dulla^@204~ onnection.Close()
        End If

~dulla^@204~ 
    Private Sub txtReserveMovieID_L~dulla^@204~ l sender As System.Object, ByVal e As~dulla^@204~ Args) Handles txtReserveMovieID.LostF~dulla^@204~    Dim reserveMovieID = txtReserveMov~dulla^@204~       Dim objSelectCommand9 As New Sq~dulla^@204~      objSelectCommand9.Connection = o~dulla^@204~ 

        'SELECT command
        o~dulla^@204~ nd9.CommandText = _
        "SELECT ~dulla^@204~         "FROM Movie " & _
        "W~dulla^@204~ & reserveMovieID & "';"

        ob~dulla^@204~ pen()
        Dim aviID2 As Object =~dulla^@204~ mand9.ExecuteScalar
        objConne~dulla^@204~ 

        Dim avialableID2 As Strin~dulla^@204~ ialableID2 = CType(aviID2, String)
~dulla^@204~ vialableID2 = "" Then
            Me~dulla^@204~ ("Invalid Movie ID!", "Video Rental S~dulla^@204~ tion Message", MessageBoxButtons.OK, ~dulla^@204~ n.Error)
            txtReserveMovie~dulla^@204~ 
            'txtReserveMovieID.Focus~dulla^@204~ nd If

        txtReserveTitle.Text~dulla^@204~ D2

    End Sub

    Private Sub ~dulla^@204~ tion_Click(ByVal sender As System.Obj~dulla^@204~ As System.EventArgs) Handles btnNewRe~dulla^@204~ ck

        txtReserveMovieID.Text ~dulla^@204~  txtReserveTitle.Text = ""
        t~dulla^@204~ e.Text = ""
        txtCustTel.Text ~dulla^@204~ nd Sub

    Private Sub btnReturn_C~dulla^@204~ nder As System.Object, ByVal e As Sys~dulla^@204~ ) Handles btnReturn.Click

        ~dulla^@204~ s String

        MovieID = txtMovi~dulla^@204~        If MovieID.Equals("") Then
  ~dulla^@204~ sageBox.Show("Please fill all the emp~dulla^@204~ )!", "Video Rental System - Exception~dulla^@204~ ssageBoxButtons.OK, MessageBoxIcon.Er~dulla^@204~  ElseIf MovieID.Length > 6 Then
    ~dulla^@204~ geBox.Show("Please check the number o~dulla^@204~ allowed" & vbCrLf & _
            " ~dulla^@204~ ten in yellow background!", "Video Re~dulla^@204~  Exception Message", MessageBoxButton~dulla^@204~ BoxIcon.Error)
            lblMsg5.T~dulla^@204~  check the number of characters allow~dulla^@204~ ritten in yellow background!"

    ~dulla^@204~ turnID.Visible = True
        Else
~dulla^@204~  Dim objSelectCommand As New SqlComma~dulla^@204~    objSelectCommand.Connection = objC~dulla^@204~             'SELECT command
        ~dulla^@204~ Command.CommandText = _
            ~dulla^@204~ & _
            "FROM Rent " & _
  ~dulla^@204~ ERE ID LIKE '" & MovieID & "';"

  ~dulla^@204~ Connection.Open()
            Dim Ob~dulla^@204~ bject = objSelectCommand.ExecuteScala~dulla^@204~     Dim avialableMovieID As String
 ~dulla^@204~ ialableMovieID = CType(ObjMovieID, St~dulla^@204~       objConnection.Close()

      ~dulla^@204~ alableMovieID.Equals("") Then

    ~dulla^@204~ bjSelectCommand2 As New SqlCommand
 ~dulla^@204~ jSelectCommand2.Connection = objConne~dulla^@204~         'SELECT command
            ~dulla^@204~ and2.CommandText = _
            "SE~dulla^@204~  " & _
            "FROM Rent " & _~dulla^@204~ "WHERE ID LIKE '" & MovieID & "';"
~dulla^@204~ objConnection.Open()
            Dim~dulla^@204~  As Object = objSelectCommand2.Execut~dulla^@204~         objConnection.Close()

    ~dulla^@204~ ceReturned = False Then
            ~dulla^@204~ dateCommand As New SqlCommand
      ~dulla^@204~ UpdateCommand.Connection = objConnect~dulla^@204~           'UPDATE statement 
       ~dulla^@204~ pdateCommand.CommandText = _
       ~dulla^@204~ ATE Rent " & _
                "SET ~dulla^@204~ " & _
                "WHERE ID LIKE~dulla^@204~ leMovieID & "';"

                o~dulla^@204~ Open()

                ' Execute t~dulla^@204~  object to insert the new data...
  ~dulla^@204~  Try
                    objUpdateCo~dulla^@204~ NonQuery()

                    '--~dulla^@204~ -------------------------------------~dulla^@204~ ----------------------------------
~dulla^@204~         ' Checking for Due date
    ~dulla^@204~    Dim DateTimePicker1 As New DateTim~dulla^@204~                 DateTimePicker1.Value~dulla^@204~ 
                    Dim today As Ne~dulla^@204~                today = DateTimePicker~dulla^@204~ 

                    Dim objSelectCommand3 As New SqlCommand
               ~dulla^@204~ tCommand3.Connection = objConnection~dulla^@204~           'SELECT command
          ~dulla^@204~ SelectCommand3.CommandText = _
     ~dulla^@204~   "SELECT DateRented " & _
         ~dulla^@204~ ROM Rent " & _
                    "~dulla^@204~  '" & MovieID & "';"

             ~dulla^@204~ jDateRented As Object = objSelectComm~dulla^@204~ calar

                    Dim strD~dulla^@204~ String
                    strDateRe~dulla^@204~ objDateRented, String)

           ~dulla^@204~ dateRented, properDate As Date
     ~dulla^@204~   dateRented = CType(strDateRented, D~dulla^@204~                properDate = DateAdd(D~dulla^@204~ ay, 1, dateRented)

               ~dulla^@204~ ate, cost As Integer

             ~dulla^@204~ eDiff(DateInterval.Day, properDate, t~dulla^@204~ n

                        dueDate ~dulla^@204~ teInterval.Day, properDate, today)
 ~dulla^@204~           cost = dueDate * 1  ' Actua~dulla^@204~ hing

                        Messa~dulla^@204~ ou owe me " & dueDate & " USD!", "Vid~dulla^@204~ tem", MessageBoxButtons.OK, MessageBo~dulla^@204~ tion)
                    Else
    ~dulla^@204~        MessageBox.Show("No due date!"~dulla^@204~ al System", MessageBoxButtons.OK, Mes~dulla^@204~ nformation)
                    End ~dulla^@204~              MessageBox.Show("Movie R~dulla^@204~ ssfully!!!", "Video Rental System", M~dulla^@204~ ons.OK, MessageBoxIcon.Information)
~dulla^@204~      Catch SqlExceptionErr As SqlExce~dulla^@204~               MessageBox.Show(SqlExce~dulla^@204~ age)
                    MessageBox.~dulla^@204~ OT returned!", "Video Rental System -~dulla^@204~ ssage", MessageBoxButtons.OK, Message~dulla^@204~ )
                End Try

       ~dulla^@204~ onnection.Close()
            Else
~dulla^@204~    MessageBox.Show("The Movie is neve~dulla^@204~ been returned!", "Video Rental System~dulla^@204~ Buttons.OK, MessageBoxIcon.Error)
  ~dulla^@204~  If


            '---------------~dulla^@204~ -------------------------------------~dulla^@204~ ---------------------

            ~dulla^@204~  the returned movie is reserved

  ~dulla^@204~  objSelectCommand4 As New SqlCommand~dulla^@204~ objSelectCommand4.Connection = objCon~dulla^@204~           'SELECT command
          ~dulla^@204~ mmand4.CommandText = _
            "~dulla^@204~  _
            "FROM Reservation " &~dulla^@204~    "WHERE ID LIKE '" & MovieID & "';"~dulla^@204~    objConnection.Open()
            ~dulla^@204~ ed As Object = objSelectCommand4.Exec~dulla^@204~           objConnection.Close()

  ~dulla^@204~  reservedMovie As String
           ~dulla^@204~ e = CType(ObjReserved, String)
     ~dulla^@204~ servedMovie.Equals("") Then

      ~dulla^@204~ SelectCommand5 As New SqlCommand
   ~dulla^@204~ electCommand5.Connection = objConnect~dulla^@204~       'SELECT command
            ob~dulla^@204~ d5.CommandText = _
            "SELE~dulla^@204~ 
            "FROM Reservation " & _~dulla^@204~  "WHERE ID LIKE '" & MovieID & "';"
~dulla^@204~  objConnection.Open()
            Di~dulla^@204~ ng As Object = objSelectCommand5.Exec~dulla^@204~           objConnection.Close()

  ~dulla^@204~ doneReserving = False Then   ' If Don~dulla^@204~ ion table is 0

                Dim~dulla^@204~ mand6 As New SqlCommand
            ~dulla^@204~ Command6.Connection = objConnection
~dulla^@204~      'SELECT command            ' sel~dulla^@204~  title,...
                objSelect~dulla^@204~ andText = _
                "SELECT ~dulla^@204~ " & _
                "FROM Reservat~dulla^@204~               "WHERE ID LIKE '" & Mov~dulla^@204~ 
                objConnection.Open(~dulla^@204~       Dim ObjCustomer As Object = obj~dulla^@204~ 6.ExecuteScalar
                objC~dulla^@204~ se()

                Dim customer ~dulla^@204~               customer = CType(ObjCus~dulla^@204~ )

                MsgBox("This mov~dulla^@204~ D to " & customer)

               ~dulla^@204~ eCommand2 As New SqlCommand
        ~dulla^@204~ dateCommand2.Connection = objConnecti~dulla^@204~          'UPDATE statement           ~dulla^@204~ e to 1 to show that it is not reserve~dulla^@204~               objUpdateCommand2.Comma~dulla^@204~                "UPDATE Reservation " ~dulla^@204~         "SET Done = 1 " & _
        ~dulla^@204~ E ID LIKE '" & reservedMovie & "';"
~dulla^@204~      objConnection.Open()

        ~dulla^@204~ cute the SqlCommand object to insert ~dulla^@204~ ..
                Try
            ~dulla^@204~ dateCommand2.ExecuteNonQuery()
     ~dulla^@204~ tch SqlExceptionErr As SqlException
~dulla^@204~        MessageBox.Show(SqlExceptionEr~dulla^@204~                    MessageBox.Show("M~dulla^@204~ TED FROM RESERVATION!!", "Video Renta~dulla^@204~ ception Message", MessageBoxButtons.O~dulla^@204~ Icon.Error)
                End Try~dulla^@204~       objConnection.Close()
        ~dulla^@204~        End If ' ends he if at the beg~dulla^@204~ Return_click

    End Sub

    Pr~dulla^@204~ NewReturn_Click(ByVal sender As Syste~dulla^@204~ al e As System.EventArgs) Handles btn~dulla^@204~ ck

        txtMovieID.Text = ""
~dulla^@204~ 

    Private Sub btnShowRevenue_Cli~dulla^@204~ er As System.Object, ByVal e As Syste~dulla^@204~ Handles btnShowRevenue.Click

     ~dulla^@204~ edDate As Date
        selectedDate ~dulla^@204~ ate.Value.Date

        Dim objSele~dulla^@204~ New SqlCommand
        objSelectComm~dulla^@204~ n = objConnection

        'SELECT ~dulla^@204~      
        objSelectCommand.Comma~dulla^@204~        "SELECT Count(DateRented) " & ~dulla^@204~ ROM Rent " & _
        "WHERE DateRe~dulla^@204~ electedDate & "';"

        objConn~dulla^@204~ 
        Dim ObjDate As Object = obj~dulla^@204~ .ExecuteScalar
        objConnection~dulla^@204~        Dim noOfDate As Integer
     ~dulla^@204~  CType(ObjDate, Integer)

        I~dulla^@204~  0 Then
            Dim rvn As Integ~dulla^@204~    rvn = noOfDate * 1      ' 1 is mon~dulla^@204~ 

            MessageBox.Show("In th~dulla^@204~ lectedDate & ", " & noOfDate & " movi~dulla^@204~ d." _
                            & ~dulla^@204~  " & rvn & " Birr is recieved. ", "Vi~dulla^@204~ stem" _
                            ~dulla^@204~ uttons.OK, MessageBoxIcon.Information~dulla^@204~     '''''''''''''''''''''''''''''''''~dulla^@204~ '''''''''''''''''''''''''''''''''''''~dulla^@204~ '
            ' Declare and Initiali~dulla^@204~ ance of the DataSet object...
      ~dulla^@204~ DataSet2 As New DataSet

          ~dulla^@204~ ataAdaptor2 As New SqlDataAdapter
  ~dulla^@204~ ectDataAdaptor2.SelectCommand = New S~dulla^@204~             selectDataAdaptor2.Select~dulla^@204~ ction = objConnection

            ~dulla^@204~ ptor2.SelectCommand.CommandText = _
~dulla^@204~ "SELECT * FROM Rent WHERE DateRented ~dulla^@204~ edDate & "';")
            'ID, Titl~dulla^@204~ me, Paid
            selectDataAdapt~dulla^@204~ ataSet2, "RevenueSearch")
          ~dulla^@204~ daptor2.AcceptChangesDuringFill = Tru~dulla^@204~     grdRevenue.DataSource = objDataSe~dulla^@204~    grdRevenue.DataMember = "RevenueSe~dulla^@204~         'If grdRevenue.RowCount = 0 T~dulla^@204~     '    MessageBox.Show("The custome~dulla^@204~ ented a movie!", "Video Rental System~dulla^@204~ eption", MessageBoxButtons.OK, Messag~dulla^@204~ r)
            'End If

        El~dulla^@204~    MessageBox.Show("No movie is rente~dulla^@204~ ctedDate, "Video Rental System" _
  ~dulla^@204~                          , MessageBox~dulla^@204~ essageBoxIcon.Information)
        E~dulla^@204~ End Sub

    Private Sub btnGo_Clic~dulla^@204~ r As System.Object, ByVal e As System~dulla^@204~ andles btnGo.Click

        Dim sea~dulla^@204~  String = txtSearchCustomer.Text

 ~dulla^@204~ ialize a new instance of the DataSet ~dulla^@204~       objDataSet = New DataSet()

 ~dulla^@204~ lectDataAdaptor As New SqlDataAdapter~dulla^@204~ ectDataAdaptor.SelectCommand = New Sq~dulla^@204~        selectDataAdaptor.SelectComman~dulla^@204~ = objConnection

        selectDataAdaptor.SelectCommand.CommandText = _
   ~dulla^@204~  Title, DateRented FROM Rent WHERE Cu~dulla^@204~ ke '" & searchContent & "'")

     ~dulla^@204~ Adaptor.Fill(objDataSet, "CustomerSea~dulla^@204~   selectDataAdaptor.AcceptChangesDuri~dulla^@204~ 

        'grdCust.c = 100

     ~dulla^@204~ taSource = objDataSet
        grdCus~dulla^@204~ = "CustomerSearch"

        If grdC~dulla^@204~ = 0 Then
            MessageBox.Show~dulla^@204~ r has never rented a movie!", "Video ~dulla^@204~  - Search Exception", MessageBoxButto~dulla^@204~ eBoxIcon.Error)
        End If

  ~dulla^@204~     Private Sub btnCustRefresh_Click(~dulla^@204~ As System.Object, ByVal e As System.E~dulla^@204~ dles btnCustRefresh.Click

        ~dulla^@204~ omer.Text = ""
        grdCust.DataS~dulla^@204~ ng
        grdCust.DataMember = Noth~dulla^@204~ d Sub

    Private Sub btnGoSearchA~dulla^@204~ l sender As System.Object, ByVal e As~dulla^@204~ Args) Handles btnGoSearchAvi.Click
~dulla^@204~ searchContent As String = txtSearchAv~dulla^@204~      Dim selectDataAdaptor As New Sql~dulla^@204~         selectDataAdaptor.SelectComma~dulla^@204~ ommand

        selectDataAdaptor.S~dulla^@204~ Connection = objConnection

       ~dulla^@204~  As String
        searchBy = cboSea~dulla^@204~ 
        If (searchBy.Equals("Title"~dulla^@204~         selectDataAdaptor.SelectComma~dulla^@204~ t = _
            ("SELECT ID, Title~dulla^@204~ e, DateRented FROM Rent WHERE Title l~dulla^@204~ chContent & "' AND Returned = 0")
  ~dulla^@204~ (searchBy.Equals("ID")) Then
       ~dulla^@204~ taAdaptor.SelectCommand.CommandText =~dulla^@204~    ("SELECT ID, Title, CustomerName, ~dulla^@204~ OM Rent WHERE ID like '" & searchCont~dulla^@204~  Returned = 0")
        Else
      ~dulla^@204~ Box.Show("Please check the Search By!~dulla^@204~ tal System - Search Exception", Messa~dulla^@204~ OK, MessageBoxIcon.Error)
        En~dulla^@204~    selectDataAdaptor.Fill(objDataSet,~dulla^@204~ hAvi")
        selectDataAdaptor.Acc~dulla^@204~ ingFill = True

        grdSearchAv~dulla^@204~ = objDataSet
        grdSearchAvi.Da~dulla^@204~ oviesSearchAvi"

        If grdSear~dulla^@204~ t = 0 Then
            MessageBox.Sh~dulla^@204~  is avialable or not in the store at ~dulla^@204~  Rental System - Search Exception", M~dulla^@204~ ons.OK, MessageBoxIcon.Error)
      ~dulla^@204~ nRefresh_Click(Nothing, Nothing)
   ~dulla^@204~           MessageBox.Show("The movie ~dulla^@204~ "Video Rental System", MessageBoxButt~dulla^@204~ geBoxIcon.Information)
        End I~dulla^@204~ Sub

    Private Sub btnRefreshAvi_~dulla^@204~ ender As System.Object, ByVal e As Sy~dulla^@204~ s) Handles btnRefreshAvi.Click

   ~dulla^@204~ hMovie.Text = ""
        frmHome_Loa~dulla^@204~ thing)

    End Sub

    Private ~dulla^@204~ Movie_Click(ByVal sender As System.Ob~dulla^@204~  As System.EventArgs) Handles btnDele~dulla^@204~ 

        Dim i As Integer
       ~dulla^@204~  As String

        i = grdMovies.C~dulla^@204~ ex
        deleteID = grdMovies.Item~dulla^@204~ 

        Dim objDeleteCommand As Ne~dulla^@204~ 
        objDeleteCommand.Connection ~dulla^@204~ on

        Dim answer As DialogRes~dulla^@204~ answer = MessageBox.Show(Me, "Are you~dulla^@204~ t to delete user '" & deleteID & "'?"~dulla^@204~ al System - CONFIRMATION MESSAGE", Me~dulla^@204~ ns.YesNo, MessageBoxIcon.Information)~dulla^@204~ f answer.ToString.Equals("Yes") Then~dulla^@204~   objDeleteCommand.CommandText = _
 ~dulla^@204~ ELETE " & _
            "FROM Movie ~dulla^@204~       "WHERE ID = '" & deleteID & "';~dulla^@204~     objConnection.Open()

         ~dulla^@204~ the SqlCommand object to insert the n~dulla^@204~            Try
                objDe~dulla^@204~ xecuteScalar()
                Messa~dulla^@204~ ovie information deleted Successfully~dulla^@204~ Rental System", MessageBoxButtons.OK,~dulla^@204~ on.Information)
                objC~dulla^@204~ se()
                Call btnRefresh~dulla^@204~ g, Nothing)
            Catch SqlExc~dulla^@204~ SqlException
                Message~dulla^@204~ xceptionErr.Message)
               ~dulla^@204~ how("Movie information NOT deleted!",~dulla^@204~ l System - Exception Message", Messag~dulla^@204~ K, MessageBoxIcon.Error)
           ~dulla^@204~            objConnection.Close()
   ~dulla^@204~ 
    End Sub

    Private Sub btnM~dulla^@204~ ick(ByVal sender As System.Object, By~dulla^@204~ em.EventArgs) Handles btnMovieRateGo.~dulla^@204~     Dim searchContent As String = txt~dulla^@204~ ch.Text

        ' Initialize a new~dulla^@204~ the DataSet object...
        objDat~dulla^@204~ taSet()

        Dim selectDataAdap~dulla^@204~ lDataAdapter
        selectDataAdapt~dulla^@204~ and = New SqlCommand

        selec~dulla^@204~ SelectCommand.Connection = objConnect~dulla^@204~   Dim searchBy As String
        sea~dulla^@204~ vieRateSearchBy.Text

        If (s~dulla^@204~ s("Title")) Then
            selectD~dulla^@204~ lectCommand.CommandText = _
        ~dulla^@204~ ID, Title, DateRented, CustomerName F~dulla^@204~ E Title like '" & searchContent & "'"~dulla^@204~ seIf (searchBy.Equals("ID")) Then
  ~dulla^@204~ ectDataAdaptor.SelectCommand.CommandT~dulla^@204~        ("SELECT ID, Title, DateRented~dulla^@204~ e FROM Rent WHERE ID like '" & search~dulla^@204~ )
        Else
            MessageB~dulla^@204~ se check the Search By!", "Video Rent~dulla^@204~ earch Exception", MessageBoxButtons.O~dulla^@204~ Icon.Error)
        End If

      ~dulla^@204~ daptor.Fill(objDataSet, "MovieRateSea~dulla^@204~   selectDataAdaptor.AcceptChangesDuri~dulla^@204~ 

        'grdCust.c = 100

     ~dulla^@204~ te.DataSource = objDataSet
        g~dulla^@204~ ataMember = "MovieRateSearch"

    ~dulla^@204~ Integer
        j += grdMovieRate.Ro~dulla^@204~      lblNoOfTimes.Text = "The movie i~dulla^@204~ j & " number of times."

        If~dulla^@204~ .RowCount = 0 Then
            Messa~dulla^@204~ he movie has never been rented!", "Vi~dulla^@204~ stem - Search Exception", MessageBoxB~dulla^@204~ ssageBoxIcon.Error)
        End If
~dulla^@204~ 

    Private Sub btnMovieRateRefre~dulla^@204~ l sender As System.Object, ByVal e As~dulla^@204~ Args) Handles btnMovieRateRefresh.Cli~dulla^@204~  txtMovieRateSearch.Text = ""
      ~dulla^@204~ e.DataSource = Nothing
        grdMo~dulla^@204~ ember = Nothing

    End Sub


 ~dulla^@204~ b btnTotalRevenue_Click(ByVal sender ~dulla^@204~ ect, ByVal e As System.EventArgs) Han~dulla^@204~ Revenue.Click

        Dim begDate,~dulla^@204~ ate
        begDate = dtpBegDate.Val~dulla^@204~     endDate = dtpEndDate.Value.Date
~dulla^@204~  objSelectCommand As New SqlCommand
~dulla^@204~ lectCommand.Connection = objConnectio~dulla^@204~ 'SELECT command           
        o~dulla^@204~ nd.CommandText = _
        "SELECT C~dulla^@204~ ed) " & _
        "FROM Rent " & _
~dulla^@204~ E DateRented > '" & begDate & "' AND ~dulla^@204~ '" & endDate & "';"

        objCon~dulla^@204~ )
        Dim ObjBEDate As Object = ~dulla^@204~ and.ExecuteScalar
        objConnect~dulla^@204~ 
        Dim noOfBEDate As Integer
~dulla^@204~ EDate = CType(ObjBEDate, Integer)

~dulla^@204~ OfBEDate <> 0 Then
            Dim r~dulla^@204~ 
            rvn = noOfBEDate * 1   ~dulla^@204~ ey per movie

            MessageBo~dulla^@204~ en the dates " & begDate & " and " & ~dulla^@204~  " & noOfBEDate & " movies were rente~dulla^@204~                       & vbCrLf & "And~dulla^@204~ Birr is recieved. ", "Video Rental Sy~dulla^@204~                         , MessageBoxB~dulla^@204~ ssageBoxIcon.Information)

        ~dulla^@204~ '''''''''''''''''''''''''''''''''''''~dulla^@204~ '''''''''''''''''''''''''''''''''''''~dulla^@204~   ' Declare and Initialize a new inst~dulla^@204~ ataSet object...
            Dim obj~dulla^@204~ ew DataSet

            Dim selectD~dulla^@204~ s New SqlDataAdapter
            sel~dulla^@204~ r6.SelectCommand = New SqlCommand

~dulla^@204~ electDataAdaptor6.SelectCommand.Conne~dulla^@204~ nnection

            selectDataAdaptor6.SelectCommand.CommandText = _
     ~dulla^@204~ CT * FROM Rent WHERE DateRented > '" ~dulla^@204~ ' AND DateRented < '" & endDate & "';~dulla^@204~      selectDataAdaptor6.Fill(objDataS~dulla^@204~ ueSearch")
            selectDataAda~dulla^@204~ hangesDuringFill = True

          ~dulla^@204~ DataSource = objDataSet6
           ~dulla^@204~ ataMember = "BERevenueSearch"

    ~dulla^@204~ rdRevenue.RowCount = 0 Then
        ~dulla^@204~ ageBox.Show("The customer has never r~dulla^@204~ !", "Video Rental System - Search Exc~dulla^@204~ ageBoxButtons.OK, MessageBoxIcon.Erro~dulla^@204~    'End If

        Else
         ~dulla^@204~ .Show("No movie is rented between " &~dulla^@204~ and " & endDate, "Video Rental System~dulla^@204~                                 , Mes~dulla^@204~ s.OK, MessageBoxIcon.Information)
  ~dulla^@204~ 

    End Sub

    Private Sub btn~dulla^@204~ ick(ByVal sender As System.Object, By~dulla^@204~ em.EventArgs) Handles btnCreateUser.C~dulla^@204~    frmCreateUserAccount.Show()
     ~dulla^@204~ 

    End Sub

    Private Sub bt~dulla^@204~ (ByVal sender As System.Object, ByVal~dulla^@204~ EventArgs) Handles btnChange.Click
~dulla^@204~ hangePassword.Show()
        Me.Clos~dulla^@204~ d Sub

    Private Sub btnHelp_Clic~dulla^@204~ r As System.Object, ByVal e As System~dulla^@204~ andles btnHelp.Click

        frmHe~dulla^@204~       'Me.StartPosition = FormStartPo~dulla^@204~ 
        'Dim i As Integer = Me.Loca~dulla^@204~ 01) '., +100) ' = 100,100
        'M~dulla^@204~ = i

    End Sub
    Private Sub b~dulla^@204~ k(ByVal sender As System.Object, ByVa~dulla^@204~ .EventArgs) Handles btnLogOff.Click
~dulla^@204~ eoRentalSystem.frmUserLogin.frmUserLo~dulla^@204~ ing, Nothing)
        VideoRentalSys~dulla^@204~ gin.Show()
        VideoRentalSystem~dulla^@204~ .txtPassword.Text = ""
        Me.Cl~dulla^@204~ End Sub

    'Private Sub help()
 ~dulla^@204~ elpprovider As Help
    '    helppro~dulla^@204~ p(Me, "C:\Users\Biniam\Documents\Visu~dulla^@204~ 5\Projects\VideoRentalSystem\Help\hel~dulla^@204~ '    ' Display the contents of the he~dulla^@204~  '    'helpprovider.ShowHelp(Me, "c:\myhelpfile.chm")

    'End Sub

End Class