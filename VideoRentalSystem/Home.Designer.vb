<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbSearch = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grdMovies = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cboSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnSearchGo = New System.Windows.Forms.Button()
        Me.txtSearchMovie = New System.Windows.Forms.TextBox()
        Me.tbAddMovies = New System.Windows.Forms.TabPage()
        Me.lblMsg1 = New System.Windows.Forms.Label()
        Me.lblActor = New System.Windows.Forms.Label()
        Me.lblDBought = New System.Windows.Forms.Label()
        Me.lblDReleased = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtDateReleased = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dtpDateBought = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtActor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.tbRent = New System.Windows.Forms.TabPage()
        Me.lblMsg2 = New System.Windows.Forms.Label()
        Me.lblRDR = New System.Windows.Forms.Label()
        Me.lblRCN = New System.Windows.Forms.Label()
        Me.lblRTitle = New System.Windows.Forms.Label()
        Me.lblRID = New System.Windows.Forms.Label()
        Me.btnNewRent = New System.Windows.Forms.Button()
        Me.dtpDateRented = New System.Windows.Forms.DateTimePicker()
        Me.btnRent = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRentTitle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRentID = New System.Windows.Forms.TextBox()
        Me.tbReservation = New System.Windows.Forms.TabPage()
        Me.lblMsg3 = New System.Windows.Forms.Label()
        Me.lblResCT = New System.Windows.Forms.Label()
        Me.lblResCN = New System.Windows.Forms.Label()
        Me.lblResTitle = New System.Windows.Forms.Label()
        Me.lblResID = New System.Windows.Forms.Label()
        Me.btnNewReservation = New System.Windows.Forms.Button()
        Me.grdReservation = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCustTel = New System.Windows.Forms.TextBox()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtReserveCName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtReserveTitle = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtReserveMovieID = New System.Windows.Forms.TextBox()
        Me.tbReturnMovie = New System.Windows.Forms.TabPage()
        Me.grdMoreThan10Days = New System.Windows.Forms.DataGridView()
        Me.lblMsg5 = New System.Windows.Forms.Label()
        Me.lblReturnID = New System.Windows.Forms.Label()
        Me.btnNewReturn = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lst10Due = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtMovieID = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbRevenue = New System.Windows.Forms.TabPage()
        Me.btnTotalRevenue = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpBegDate = New System.Windows.Forms.DateTimePicker()
        Me.grdRevenue = New System.Windows.Forms.DataGridView()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpRevenueDate = New System.Windows.Forms.DateTimePicker()
        Me.btnShowRevenue = New System.Windows.Forms.Button()
        Me.tbCustomer = New System.Windows.Forms.TabPage()
        Me.btnCustRefresh = New System.Windows.Forms.Button()
        Me.grdCust = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.tbSearchIfAvi = New System.Windows.Forms.TabPage()
        Me.grdSearchAvi = New System.Windows.Forms.DataGridView()
        Me.btnDeleteMovie = New System.Windows.Forms.Button()
        Me.grdSearchAviMovies = New System.Windows.Forms.DataGridView()
        Me.btnRefreshAvi = New System.Windows.Forms.Button()
        Me.cboSearchAvi = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnGoSearchAvi = New System.Windows.Forms.Button()
        Me.txtSearchAvi = New System.Windows.Forms.TextBox()
        Me.tbMovieRate = New System.Windows.Forms.TabPage()
        Me.lblNoOfTimes = New System.Windows.Forms.Label()
        Me.btnMovieRateRefresh = New System.Windows.Forms.Button()
        Me.cboMovieRateSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grdMovieRate = New System.Windows.Forms.DataGridView()
        Me.btnMovieRateGo = New System.Windows.Forms.Button()
        Me.txtMovieRateSearch = New System.Windows.Forms.TextBox()
        Me.tbAbout = New System.Windows.Forms.TabPage()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblMsg0 = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbSearch.SuspendLayout()
        CType(Me.grdMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbAddMovies.SuspendLayout()
        Me.tbRent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tbReservation.SuspendLayout()
        CType(Me.grdReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbReturnMovie.SuspendLayout()
        CType(Me.grdMoreThan10Days, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRevenue.SuspendLayout()
        CType(Me.grdRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCustomer.SuspendLayout()
        CType(Me.grdCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSearchIfAvi.SuspendLayout()
        CType(Me.grdSearchAvi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSearchAviMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbMovieRate.SuspendLayout()
        CType(Me.grdMovieRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbSearch)
        Me.TabControl1.Controls.Add(Me.tbAddMovies)
        Me.TabControl1.Controls.Add(Me.tbRent)
        Me.TabControl1.Controls.Add(Me.tbReservation)
        Me.TabControl1.Controls.Add(Me.tbReturnMovie)
        Me.TabControl1.Controls.Add(Me.tbRevenue)
        Me.TabControl1.Controls.Add(Me.tbCustomer)
        Me.TabControl1.Controls.Add(Me.tbSearchIfAvi)
        Me.TabControl1.Controls.Add(Me.tbMovieRate)
        Me.TabControl1.Controls.Add(Me.tbAbout)
        Me.TabControl1.Location = New System.Drawing.Point(81, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 360)
        Me.TabControl1.TabIndex = 0
        '
        'tbSearch
        '
        Me.tbSearch.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Movie_Search1
        Me.tbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbSearch.Controls.Add(Me.btnDelete)
        Me.tbSearch.Controls.Add(Me.grdMovies)
        Me.tbSearch.Controls.Add(Me.btnRefresh)
        Me.tbSearch.Controls.Add(Me.cboSearchBy)
        Me.tbSearch.Controls.Add(Me.Label22)
        Me.tbSearch.Controls.Add(Me.Label23)
        Me.tbSearch.Controls.Add(Me.btnSearchGo)
        Me.tbSearch.Controls.Add(Me.txtSearchMovie)
        Me.tbSearch.Location = New System.Drawing.Point(4, 22)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(627, 334)
        Me.tbSearch.TabIndex = 6
        Me.tbSearch.Text = "Search"
        Me.tbSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(3, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(56, 23)
        Me.btnDelete.TabIndex = 112
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'grdMovies
        '
        Me.grdMovies.AllowUserToAddRows = False
        Me.grdMovies.AllowUserToDeleteRows = False
        Me.grdMovies.AllowUserToOrderColumns = True
        Me.grdMovies.AllowUserToResizeColumns = False
        Me.grdMovies.AllowUserToResizeRows = False
        Me.grdMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMovies.Location = New System.Drawing.Point(1, 83)
        Me.grdMovies.Name = "grdMovies"
        Me.grdMovies.ReadOnly = True
        Me.grdMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdMovies.Size = New System.Drawing.Size(623, 248)
        Me.grdMovies.TabIndex = 4
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(99, 48)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(70, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cboSearchBy
        '
        Me.cboSearchBy.FormattingEnabled = True
        Me.cboSearchBy.Items.AddRange(New Object() {"Actor", "ID", "Title", "Type"})
        Me.cboSearchBy.Location = New System.Drawing.Point(228, 50)
        Me.cboSearchBy.Name = "cboSearchBy"
        Me.cboSearchBy.Size = New System.Drawing.Size(121, 21)
        Me.cboSearchBy.Sorted = True
        Me.cboSearchBy.TabIndex = 1
        Me.cboSearchBy.Text = "ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(225, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Search by:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(382, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 110
        Me.Label23.Text = "Search"
        '
        'btnSearchGo
        '
        Me.btnSearchGo.Location = New System.Drawing.Point(565, 49)
        Me.btnSearchGo.Name = "btnSearchGo"
        Me.btnSearchGo.Size = New System.Drawing.Size(37, 23)
        Me.btnSearchGo.TabIndex = 2
        Me.btnSearchGo.Text = "Go"
        Me.btnSearchGo.UseVisualStyleBackColor = True
        '
        'txtSearchMovie
        '
        Me.txtSearchMovie.Location = New System.Drawing.Point(385, 51)
        Me.txtSearchMovie.Name = "txtSearchMovie"
        Me.txtSearchMovie.Size = New System.Drawing.Size(163, 20)
        Me.txtSearchMovie.TabIndex = 0
        '
        'tbAddMovies
        '
        Me.tbAddMovies.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Add_Movie2
        Me.tbAddMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbAddMovies.Controls.Add(Me.lblMsg1)
        Me.tbAddMovies.Controls.Add(Me.lblActor)
        Me.tbAddMovies.Controls.Add(Me.lblDBought)
        Me.tbAddMovies.Controls.Add(Me.lblDReleased)
        Me.tbAddMovies.Controls.Add(Me.lblDesc)
        Me.tbAddMovies.Controls.Add(Me.lblType)
        Me.tbAddMovies.Controls.Add(Me.lblTitle)
        Me.tbAddMovies.Controls.Add(Me.lblID)
        Me.tbAddMovies.Controls.Add(Me.txtDateReleased)
        Me.tbAddMovies.Controls.Add(Me.cboType)
        Me.tbAddMovies.Controls.Add(Me.btnNew)
        Me.tbAddMovies.Controls.Add(Me.dtpDateBought)
        Me.tbAddMovies.Controls.Add(Me.btnAdd)
        Me.tbAddMovies.Controls.Add(Me.Label7)
        Me.tbAddMovies.Controls.Add(Me.txtDescription)
        Me.tbAddMovies.Controls.Add(Me.Label6)
        Me.tbAddMovies.Controls.Add(Me.txtActor)
        Me.tbAddMovies.Controls.Add(Me.Label5)
        Me.tbAddMovies.Controls.Add(Me.Label4)
        Me.tbAddMovies.Controls.Add(Me.Label3)
        Me.tbAddMovies.Controls.Add(Me.Label2)
        Me.tbAddMovies.Controls.Add(Me.txtTitle)
        Me.tbAddMovies.Controls.Add(Me.Label1)
        Me.tbAddMovies.Controls.Add(Me.txtID)
        Me.tbAddMovies.Location = New System.Drawing.Point(4, 22)
        Me.tbAddMovies.Name = "tbAddMovies"
        Me.tbAddMovies.Padding = New System.Windows.Forms.Padding(3)
        Me.tbAddMovies.Size = New System.Drawing.Size(627, 334)
        Me.tbAddMovies.TabIndex = 0
        Me.tbAddMovies.Text = "Add Movies"
        Me.tbAddMovies.UseVisualStyleBackColor = True
        '
        'lblMsg1
        '
        Me.lblMsg1.AutoSize = True
        Me.lblMsg1.BackColor = System.Drawing.Color.White
        Me.lblMsg1.ForeColor = System.Drawing.Color.Red
        Me.lblMsg1.Location = New System.Drawing.Point(63, 313)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg1.TabIndex = 62
        '
        'lblActor
        '
        Me.lblActor.AutoSize = True
        Me.lblActor.BackColor = System.Drawing.Color.Yellow
        Me.lblActor.Location = New System.Drawing.Point(279, 123)
        Me.lblActor.Name = "lblActor"
        Me.lblActor.Size = New System.Drawing.Size(19, 13)
        Me.lblActor.TabIndex = 35
        Me.lblActor.Text = "50"
        '
        'lblDBought
        '
        Me.lblDBought.AutoSize = True
        Me.lblDBought.BackColor = System.Drawing.Color.Yellow
        Me.lblDBought.Location = New System.Drawing.Point(281, 86)
        Me.lblDBought.Name = "lblDBought"
        Me.lblDBought.Size = New System.Drawing.Size(19, 13)
        Me.lblDBought.TabIndex = 34
        Me.lblDBought.Text = "10"
        '
        'lblDReleased
        '
        Me.lblDReleased.AutoSize = True
        Me.lblDReleased.BackColor = System.Drawing.Color.Yellow
        Me.lblDReleased.Location = New System.Drawing.Point(281, 54)
        Me.lblDReleased.Name = "lblDReleased"
        Me.lblDReleased.Size = New System.Drawing.Size(19, 13)
        Me.lblDReleased.TabIndex = 33
        Me.lblDReleased.Text = "15"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Yellow
        Me.lblDesc.Location = New System.Drawing.Point(2, 160)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(19, 13)
        Me.lblDesc.TabIndex = 32
        Me.lblDesc.Text = "50"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Yellow
        Me.lblType.Location = New System.Drawing.Point(2, 118)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(19, 13)
        Me.lblType.TabIndex = 31
        Me.lblType.Text = "10"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblTitle.Location = New System.Drawing.Point(2, 83)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(19, 13)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "30"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Yellow
        Me.lblID.Location = New System.Drawing.Point(2, 48)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 29
        Me.lblID.Text = "6"
        '
        'txtDateReleased
        '
        Me.txtDateReleased.Location = New System.Drawing.Point(411, 51)
        Me.txtDateReleased.Name = "txtDateReleased"
        Me.txtDateReleased.Size = New System.Drawing.Size(180, 20)
        Me.txtDateReleased.TabIndex = 3
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Action", "Action / Comedy", "Adventure", "African", "Amharic", "Comedy", "Drama", "Erotic or PB", "Horor", "Indian", "Romance", "Rom/Com", "Suspense", "War"})
        Me.cboType.Location = New System.Drawing.Point(85, 121)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(180, 21)
        Me.cboType.TabIndex = 2
        Me.cboType.Text = "Action"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(377, 265)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(85, 37)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'dtpDateBought
        '
        Me.dtpDateBought.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateBought.Location = New System.Drawing.Point(410, 83)
        Me.dtpDateBought.Name = "dtpDateBought"
        Me.dtpDateBought.Size = New System.Drawing.Size(181, 20)
        Me.dtpDateBought.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(190, 265)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 37)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(102, 159)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.ShortcutsEnabled = False
        Me.txtDescription.Size = New System.Drawing.Size(420, 94)
        Me.txtDescription.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Actor(s)"
        '
        'txtActor
        '
        Me.txtActor.Location = New System.Drawing.Point(411, 118)
        Me.txtActor.Multiline = True
        Me.txtActor.Name = "txtActor"
        Me.txtActor.Size = New System.Drawing.Size(180, 32)
        Me.txtActor.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Date Bought"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(312, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Date Released"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(85, 83)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(180, 20)
        Me.txtTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(85, 48)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(180, 20)
        Me.txtID.TabIndex = 0
        '
        'tbRent
        '
        Me.tbRent.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Rent_Movie1
        Me.tbRent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbRent.Controls.Add(Me.lblMsg2)
        Me.tbRent.Controls.Add(Me.lblRDR)
        Me.tbRent.Controls.Add(Me.lblRCN)
        Me.tbRent.Controls.Add(Me.lblRTitle)
        Me.tbRent.Controls.Add(Me.lblRID)
        Me.tbRent.Controls.Add(Me.btnNewRent)
        Me.tbRent.Controls.Add(Me.dtpDateRented)
        Me.tbRent.Controls.Add(Me.btnRent)
        Me.tbRent.Controls.Add(Me.GroupBox1)
        Me.tbRent.Controls.Add(Me.Label9)
        Me.tbRent.Controls.Add(Me.Label10)
        Me.tbRent.Controls.Add(Me.Label11)
        Me.tbRent.Controls.Add(Me.txtCustName)
        Me.tbRent.Controls.Add(Me.Label12)
        Me.tbRent.Controls.Add(Me.txtRentTitle)
        Me.tbRent.Controls.Add(Me.Label13)
        Me.tbRent.Controls.Add(Me.txtRentID)
        Me.tbRent.Location = New System.Drawing.Point(4, 22)
        Me.tbRent.Name = "tbRent"
        Me.tbRent.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRent.Size = New System.Drawing.Size(627, 334)
        Me.tbRent.TabIndex = 1
        Me.tbRent.Text = "Rent"
        Me.tbRent.UseVisualStyleBackColor = True
        '
        'lblMsg2
        '
        Me.lblMsg2.AutoSize = True
        Me.lblMsg2.BackColor = System.Drawing.Color.Red
        Me.lblMsg2.ForeColor = System.Drawing.Color.White
        Me.lblMsg2.Location = New System.Drawing.Point(34, 288)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg2.TabIndex = 62
        '
        'lblRDR
        '
        Me.lblRDR.AutoSize = True
        Me.lblRDR.BackColor = System.Drawing.Color.Yellow
        Me.lblRDR.Location = New System.Drawing.Point(284, 99)
        Me.lblRDR.Name = "lblRDR"
        Me.lblRDR.Size = New System.Drawing.Size(19, 13)
        Me.lblRDR.TabIndex = 44
        Me.lblRDR.Text = "10"
        '
        'lblRCN
        '
        Me.lblRCN.AutoSize = True
        Me.lblRCN.BackColor = System.Drawing.Color.Yellow
        Me.lblRCN.Location = New System.Drawing.Point(5, 180)
        Me.lblRCN.Name = "lblRCN"
        Me.lblRCN.Size = New System.Drawing.Size(19, 13)
        Me.lblRCN.TabIndex = 43
        Me.lblRCN.Text = "30"
        '
        'lblRTitle
        '
        Me.lblRTitle.AutoSize = True
        Me.lblRTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblRTitle.Location = New System.Drawing.Point(5, 124)
        Me.lblRTitle.Name = "lblRTitle"
        Me.lblRTitle.Size = New System.Drawing.Size(19, 13)
        Me.lblRTitle.TabIndex = 42
        Me.lblRTitle.Text = "30"
        '
        'lblRID
        '
        Me.lblRID.AutoSize = True
        Me.lblRID.BackColor = System.Drawing.Color.Yellow
        Me.lblRID.Location = New System.Drawing.Point(5, 82)
        Me.lblRID.Name = "lblRID"
        Me.lblRID.Size = New System.Drawing.Size(13, 13)
        Me.lblRID.TabIndex = 41
        Me.lblRID.Text = "6"
        '
        'btnNewRent
        '
        Me.btnNewRent.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRent.Location = New System.Drawing.Point(384, 238)
        Me.btnNewRent.Name = "btnNewRent"
        Me.btnNewRent.Size = New System.Drawing.Size(85, 37)
        Me.btnNewRent.TabIndex = 40
        Me.btnNewRent.Text = "New"
        Me.btnNewRent.UseVisualStyleBackColor = True
        '
        'dtpDateRented
        '
        Me.dtpDateRented.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateRented.Location = New System.Drawing.Point(419, 99)
        Me.dtpDateRented.Name = "dtpDateRented"
        Me.dtpDateRented.Size = New System.Drawing.Size(181, 20)
        Me.dtpDateRented.TabIndex = 3
        '
        'btnRent
        '
        Me.btnRent.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRent.Location = New System.Drawing.Point(252, 238)
        Me.btnRent.Name = "btnRent"
        Me.btnRent.Size = New System.Drawing.Size(85, 37)
        Me.btnRent.TabIndex = 5
        Me.btnRent.Text = "Rent"
        Me.btnRent.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbNo)
        Me.GroupBox1.Controls.Add(Me.rdbYes)
        Me.GroupBox1.Location = New System.Drawing.Point(420, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 49)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(114, 15)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(39, 17)
        Me.rdbNo.TabIndex = 0
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "No"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Location = New System.Drawing.Point(6, 15)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(43, 17)
        Me.rdbYes.TabIndex = 1
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Yes"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(309, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Paid"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(309, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Date Rented"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 26)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Customer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(86, 175)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(180, 20)
        Me.txtCustName.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 124)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Title"
        '
        'txtRentTitle
        '
        Me.txtRentTitle.Location = New System.Drawing.Point(86, 126)
        Me.txtRentTitle.Name = "txtRentTitle"
        Me.txtRentTitle.ReadOnly = True
        Me.txtRentTitle.Size = New System.Drawing.Size(180, 20)
        Me.txtRentTitle.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "ID"
        '
        'txtRentID
        '
        Me.txtRentID.Location = New System.Drawing.Point(86, 82)
        Me.txtRentID.Name = "txtRentID"
        Me.txtRentID.Size = New System.Drawing.Size(180, 20)
        Me.txtRentID.TabIndex = 0
        '
        'tbReservation
        '
        Me.tbReservation.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Movie_Reservation1
        Me.tbReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbReservation.Controls.Add(Me.lblMsg3)
        Me.tbReservation.Controls.Add(Me.lblResCT)
        Me.tbReservation.Controls.Add(Me.lblResCN)
        Me.tbReservation.Controls.Add(Me.lblResTitle)
        Me.tbReservation.Controls.Add(Me.lblResID)
        Me.tbReservation.Controls.Add(Me.btnNewReservation)
        Me.tbReservation.Controls.Add(Me.grdReservation)
        Me.tbReservation.Controls.Add(Me.Label14)
        Me.tbReservation.Controls.Add(Me.txtCustTel)
        Me.tbReservation.Controls.Add(Me.btnReserve)
        Me.tbReservation.Controls.Add(Me.Label16)
        Me.tbReservation.Controls.Add(Me.txtReserveCName)
        Me.tbReservation.Controls.Add(Me.Label17)
        Me.tbReservation.Controls.Add(Me.txtReserveTitle)
        Me.tbReservation.Controls.Add(Me.Label18)
        Me.tbReservation.Controls.Add(Me.txtReserveMovieID)
        Me.tbReservation.Location = New System.Drawing.Point(4, 22)
        Me.tbReservation.Name = "tbReservation"
        Me.tbReservation.Size = New System.Drawing.Size(627, 334)
        Me.tbReservation.TabIndex = 2
        Me.tbReservation.Text = "Reservation"
        Me.tbReservation.UseVisualStyleBackColor = True
        '
        'lblMsg3
        '
        Me.lblMsg3.AutoSize = True
        Me.lblMsg3.BackColor = System.Drawing.Color.Red
        Me.lblMsg3.ForeColor = System.Drawing.Color.White
        Me.lblMsg3.Location = New System.Drawing.Point(11, 288)
        Me.lblMsg3.Name = "lblMsg3"
        Me.lblMsg3.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg3.TabIndex = 61
        '
        'lblResCT
        '
        Me.lblResCT.AutoSize = True
        Me.lblResCT.BackColor = System.Drawing.Color.Yellow
        Me.lblResCT.Location = New System.Drawing.Point(3, 172)
        Me.lblResCT.Name = "lblResCT"
        Me.lblResCT.Size = New System.Drawing.Size(19, 13)
        Me.lblResCT.TabIndex = 60
        Me.lblResCT.Text = "15"
        '
        'lblResCN
        '
        Me.lblResCN.AutoSize = True
        Me.lblResCN.BackColor = System.Drawing.Color.Yellow
        Me.lblResCN.Location = New System.Drawing.Point(3, 130)
        Me.lblResCN.Name = "lblResCN"
        Me.lblResCN.Size = New System.Drawing.Size(19, 13)
        Me.lblResCN.TabIndex = 59
        Me.lblResCN.Text = "30"
        '
        'lblResTitle
        '
        Me.lblResTitle.AutoSize = True
        Me.lblResTitle.BackColor = System.Drawing.Color.Yellow
        Me.lblResTitle.Location = New System.Drawing.Point(3, 95)
        Me.lblResTitle.Name = "lblResTitle"
        Me.lblResTitle.Size = New System.Drawing.Size(19, 13)
        Me.lblResTitle.TabIndex = 58
        Me.lblResTitle.Text = "30"
        '
        'lblResID
        '
        Me.lblResID.AutoSize = True
        Me.lblResID.BackColor = System.Drawing.Color.Yellow
        Me.lblResID.Location = New System.Drawing.Point(3, 60)
        Me.lblResID.Name = "lblResID"
        Me.lblResID.Size = New System.Drawing.Size(13, 13)
        Me.lblResID.TabIndex = 57
        Me.lblResID.Text = "6"
        '
        'btnNewReservation
        '
        Me.btnNewReservation.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewReservation.Location = New System.Drawing.Point(175, 213)
        Me.btnNewReservation.Name = "btnNewReservation"
        Me.btnNewReservation.Size = New System.Drawing.Size(85, 37)
        Me.btnNewReservation.TabIndex = 56
        Me.btnNewReservation.Text = "New"
        Me.btnNewReservation.UseVisualStyleBackColor = True
        '
        'grdReservation
        '
        Me.grdReservation.AllowUserToAddRows = False
        Me.grdReservation.AllowUserToDeleteRows = False
        Me.grdReservation.AllowUserToOrderColumns = True
        Me.grdReservation.AllowUserToResizeColumns = False
        Me.grdReservation.AllowUserToResizeRows = False
        Me.grdReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdReservation.Location = New System.Drawing.Point(280, 46)
        Me.grdReservation.Name = "grdReservation"
        Me.grdReservation.ReadOnly = True
        Me.grdReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdReservation.Size = New System.Drawing.Size(346, 227)
        Me.grdReservation.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(32, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 26)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Customer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telephone"
        '
        'txtCustTel
        '
        Me.txtCustTel.Location = New System.Drawing.Point(103, 169)
        Me.txtCustTel.Name = "txtCustTel"
        Me.txtCustTel.Size = New System.Drawing.Size(166, 20)
        Me.txtCustTel.TabIndex = 3
        '
        'btnReserve
        '
        Me.btnReserve.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.Location = New System.Drawing.Point(34, 213)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(105, 37)
        Me.btnReserve.TabIndex = 4
        Me.btnReserve.Text = "Reserve"
        Me.btnReserve.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(32, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 26)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Customer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Name"
        '
        'txtReserveCName
        '
        Me.txtReserveCName.Location = New System.Drawing.Point(101, 131)
        Me.txtReserveCName.Name = "txtReserveCName"
        Me.txtReserveCName.Size = New System.Drawing.Size(166, 20)
        Me.txtReserveCName.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(32, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Title"
        '
        'txtReserveTitle
        '
        Me.txtReserveTitle.Location = New System.Drawing.Point(101, 92)
        Me.txtReserveTitle.Name = "txtReserveTitle"
        Me.txtReserveTitle.Size = New System.Drawing.Size(166, 20)
        Me.txtReserveTitle.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(32, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 13)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "ID"
        '
        'txtReserveMovieID
        '
        Me.txtReserveMovieID.Location = New System.Drawing.Point(101, 57)
        Me.txtReserveMovieID.Name = "txtReserveMovieID"
        Me.txtReserveMovieID.Size = New System.Drawing.Size(166, 20)
        Me.txtReserveMovieID.TabIndex = 0
        '
        'tbReturnMovie
        '
        Me.tbReturnMovie.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Return_Movie
        Me.tbReturnMovie.Controls.Add(Me.grdMoreThan10Days)
        Me.tbReturnMovie.Controls.Add(Me.lblMsg5)
        Me.tbReturnMovie.Controls.Add(Me.lblReturnID)
        Me.tbReturnMovie.Controls.Add(Me.btnNewReturn)
        Me.tbReturnMovie.Controls.Add(Me.Label28)
        Me.tbReturnMovie.Controls.Add(Me.Label27)
        Me.tbReturnMovie.Controls.Add(Me.Label26)
        Me.tbReturnMovie.Controls.Add(Me.lst10Due)
        Me.tbReturnMovie.Controls.Add(Me.btnReturn)
        Me.tbReturnMovie.Controls.Add(Me.txtMovieID)
        Me.tbReturnMovie.Controls.Add(Me.Label19)
        Me.tbReturnMovie.Location = New System.Drawing.Point(4, 22)
        Me.tbReturnMovie.Name = "tbReturnMovie"
        Me.tbReturnMovie.Size = New System.Drawing.Size(627, 334)
        Me.tbReturnMovie.TabIndex = 3
        Me.tbReturnMovie.Text = "Return Movie"
        Me.tbReturnMovie.UseVisualStyleBackColor = True
        '
        'grdMoreThan10Days
        '
        Me.grdMoreThan10Days.AllowUserToAddRows = False
        Me.grdMoreThan10Days.AllowUserToDeleteRows = False
        Me.grdMoreThan10Days.AllowUserToOrderColumns = True
        Me.grdMoreThan10Days.AllowUserToResizeColumns = False
        Me.grdMoreThan10Days.AllowUserToResizeRows = False
        Me.grdMoreThan10Days.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdMoreThan10Days.BackgroundColor = System.Drawing.Color.Maroon
        Me.grdMoreThan10Days.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMoreThan10Days.GridColor = System.Drawing.Color.Red
        Me.grdMoreThan10Days.Location = New System.Drawing.Point(256, 84)
        Me.grdMoreThan10Days.Name = "grdMoreThan10Days"
        Me.grdMoreThan10Days.ReadOnly = True
        Me.grdMoreThan10Days.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdMoreThan10Days.Size = New System.Drawing.Size(370, 223)
        Me.grdMoreThan10Days.TabIndex = 63
        '
        'lblMsg5
        '
        Me.lblMsg5.AutoSize = True
        Me.lblMsg5.BackColor = System.Drawing.Color.Red
        Me.lblMsg5.ForeColor = System.Drawing.Color.White
        Me.lblMsg5.Location = New System.Drawing.Point(79, 286)
        Me.lblMsg5.Name = "lblMsg5"
        Me.lblMsg5.Size = New System.Drawing.Size(0, 13)
        Me.lblMsg5.TabIndex = 62
        '
        'lblReturnID
        '
        Me.lblReturnID.AutoSize = True
        Me.lblReturnID.BackColor = System.Drawing.Color.Yellow
        Me.lblReturnID.Location = New System.Drawing.Point(16, 84)
        Me.lblReturnID.Name = "lblReturnID"
        Me.lblReturnID.Size = New System.Drawing.Size(13, 13)
        Me.lblReturnID.TabIndex = 58
        Me.lblReturnID.Text = "6"
        '
        'btnNewReturn
        '
        Me.btnNewReturn.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewReturn.Location = New System.Drawing.Point(163, 131)
        Me.btnNewReturn.Name = "btnNewReturn"
        Me.btnNewReturn.Size = New System.Drawing.Size(85, 37)
        Me.btnNewReturn.TabIndex = 41
        Me.btnNewReturn.Text = "New"
        Me.btnNewReturn.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(474, 85)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Title of Movie"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(369, 95)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 13)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Customer Name"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Yellow
        Me.Label26.Location = New System.Drawing.Point(293, 62)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(306, 23)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Movies that are due morethan 5 days"
        '
        'lst10Due
        '
        Me.lst10Due.BackColor = System.Drawing.Color.Red
        Me.lst10Due.ForeColor = System.Drawing.Color.White
        Me.lst10Due.FormattingEnabled = True
        Me.lst10Due.Location = New System.Drawing.Point(372, 91)
        Me.lst10Due.Name = "lst10Due"
        Me.lst10Due.Size = New System.Drawing.Size(244, 173)
        Me.lst10Due.TabIndex = 2
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(38, 131)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(90, 37)
        Me.btnReturn.TabIndex = 1
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'txtMovieID
        '
        Me.txtMovieID.Location = New System.Drawing.Point(81, 81)
        Me.txtMovieID.Name = "txtMovieID"
        Me.txtMovieID.Size = New System.Drawing.Size(148, 20)
        Me.txtMovieID.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(35, 84)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "ID"
        '
        'tbRevenue
        '
        Me.tbRevenue.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Show_Revenue
        Me.tbRevenue.Controls.Add(Me.btnTotalRevenue)
        Me.tbRevenue.Controls.Add(Me.Label31)
        Me.tbRevenue.Controls.Add(Me.dtpEndDate)
        Me.tbRevenue.Controls.Add(Me.Label8)
        Me.tbRevenue.Controls.Add(Me.dtpBegDate)
        Me.tbRevenue.Controls.Add(Me.grdRevenue)
        Me.tbRevenue.Controls.Add(Me.Label20)
        Me.tbRevenue.Controls.Add(Me.dtpRevenueDate)
        Me.tbRevenue.Controls.Add(Me.btnShowRevenue)
        Me.tbRevenue.Location = New System.Drawing.Point(4, 22)
        Me.tbRevenue.Name = "tbRevenue"
        Me.tbRevenue.Size = New System.Drawing.Size(627, 334)
        Me.tbRevenue.TabIndex = 4
        Me.tbRevenue.Text = "Revenue"
        Me.tbRevenue.UseVisualStyleBackColor = True
        '
        'btnTotalRevenue
        '
        Me.btnTotalRevenue.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalRevenue.Location = New System.Drawing.Point(36, 268)
        Me.btnTotalRevenue.Name = "btnTotalRevenue"
        Me.btnTotalRevenue.Size = New System.Drawing.Size(160, 37)
        Me.btnTotalRevenue.TabIndex = 4
        Me.btnTotalRevenue.Text = "Total Revenue"
        Me.btnTotalRevenue.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(11, 234)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 13)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Ending date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(107, 230)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(106, 20)
        Me.dtpEndDate.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Beginning date"
        '
        'dtpBegDate
        '
        Me.dtpBegDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBegDate.Location = New System.Drawing.Point(107, 195)
        Me.dtpBegDate.Name = "dtpBegDate"
        Me.dtpBegDate.Size = New System.Drawing.Size(106, 20)
        Me.dtpBegDate.TabIndex = 2
        '
        'grdRevenue
        '
        Me.grdRevenue.AllowUserToAddRows = False
        Me.grdRevenue.AllowUserToDeleteRows = False
        Me.grdRevenue.AllowUserToOrderColumns = True
        Me.grdRevenue.AllowUserToResizeColumns = False
        Me.grdRevenue.AllowUserToResizeRows = False
        Me.grdRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRevenue.Location = New System.Drawing.Point(248, 50)
        Me.grdRevenue.Name = "grdRevenue"
        Me.grdRevenue.ReadOnly = True
        Me.grdRevenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRevenue.Size = New System.Drawing.Size(368, 246)
        Me.grdRevenue.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 82)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Select date"
        '
        'dtpRevenueDate
        '
        Me.dtpRevenueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRevenueDate.Location = New System.Drawing.Point(107, 78)
        Me.dtpRevenueDate.Name = "dtpRevenueDate"
        Me.dtpRevenueDate.Size = New System.Drawing.Size(106, 20)
        Me.dtpRevenueDate.TabIndex = 0
        '
        'btnShowRevenue
        '
        Me.btnShowRevenue.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowRevenue.Location = New System.Drawing.Point(36, 113)
        Me.btnShowRevenue.Name = "btnShowRevenue"
        Me.btnShowRevenue.Size = New System.Drawing.Size(160, 37)
        Me.btnShowRevenue.TabIndex = 1
        Me.btnShowRevenue.Text = "Show Revenue"
        Me.btnShowRevenue.UseVisualStyleBackColor = True
        '
        'tbCustomer
        '
        Me.tbCustomer.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Customer_Search
        Me.tbCustomer.Controls.Add(Me.btnCustRefresh)
        Me.tbCustomer.Controls.Add(Me.grdCust)
        Me.tbCustomer.Controls.Add(Me.Label21)
        Me.tbCustomer.Controls.Add(Me.btnGo)
        Me.tbCustomer.Controls.Add(Me.txtSearchCustomer)
        Me.tbCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(627, 334)
        Me.tbCustomer.TabIndex = 5
        Me.tbCustomer.Text = "Customer"
        Me.tbCustomer.UseVisualStyleBackColor = True
        '
        'btnCustRefresh
        '
        Me.btnCustRefresh.Location = New System.Drawing.Point(26, 57)
        Me.btnCustRefresh.Name = "btnCustRefresh"
        Me.btnCustRefresh.Size = New System.Drawing.Size(70, 23)
        Me.btnCustRefresh.TabIndex = 2
        Me.btnCustRefresh.Text = "Refresh"
        Me.btnCustRefresh.UseVisualStyleBackColor = True
        '
        'grdCust
        '
        Me.grdCust.AllowUserToAddRows = False
        Me.grdCust.AllowUserToDeleteRows = False
        Me.grdCust.AllowUserToOrderColumns = True
        Me.grdCust.AllowUserToResizeColumns = False
        Me.grdCust.AllowUserToResizeRows = False
        Me.grdCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCust.Location = New System.Drawing.Point(264, 57)
        Me.grdCust.Name = "grdCust"
        Me.grdCust.ReadOnly = True
        Me.grdCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCust.Size = New System.Drawing.Size(326, 246)
        Me.grdCust.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(23, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(110, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Enter customer name:"
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(96, 180)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(60, 34)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Location = New System.Drawing.Point(20, 141)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(210, 20)
        Me.txtSearchCustomer.TabIndex = 0
        '
        'tbSearchIfAvi
        '
        Me.tbSearchIfAvi.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Search_If_Avialable
        Me.tbSearchIfAvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbSearchIfAvi.Controls.Add(Me.grdSearchAvi)
        Me.tbSearchIfAvi.Controls.Add(Me.btnDeleteMovie)
        Me.tbSearchIfAvi.Controls.Add(Me.grdSearchAviMovies)
        Me.tbSearchIfAvi.Controls.Add(Me.btnRefreshAvi)
        Me.tbSearchIfAvi.Controls.Add(Me.cboSearchAvi)
        Me.tbSearchIfAvi.Controls.Add(Me.Label24)
        Me.tbSearchIfAvi.Controls.Add(Me.Label25)
        Me.tbSearchIfAvi.Controls.Add(Me.btnGoSearchAvi)
        Me.tbSearchIfAvi.Controls.Add(Me.txtSearchAvi)
        Me.tbSearchIfAvi.Location = New System.Drawing.Point(4, 22)
        Me.tbSearchIfAvi.Name = "tbSearchIfAvi"
        Me.tbSearchIfAvi.Size = New System.Drawing.Size(627, 334)
        Me.tbSearchIfAvi.TabIndex = 8
        Me.tbSearchIfAvi.Text = "Search if avialable"
        Me.tbSearchIfAvi.UseVisualStyleBackColor = True
        '
        'grdSearchAvi
        '
        Me.grdSearchAvi.AllowUserToAddRows = False
        Me.grdSearchAvi.AllowUserToDeleteRows = False
        Me.grdSearchAvi.AllowUserToOrderColumns = True
        Me.grdSearchAvi.AllowUserToResizeColumns = False
        Me.grdSearchAvi.AllowUserToResizeRows = False
        Me.grdSearchAvi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdSearchAvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSearchAvi.Location = New System.Drawing.Point(238, 51)
        Me.grdSearchAvi.Name = "grdSearchAvi"
        Me.grdSearchAvi.ReadOnly = True
        Me.grdSearchAvi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSearchAvi.Size = New System.Drawing.Size(386, 248)
        Me.grdSearchAvi.TabIndex = 119
        '
        'btnDeleteMovie
        '
        Me.btnDeleteMovie.BackColor = System.Drawing.Color.Red
        Me.btnDeleteMovie.Location = New System.Drawing.Point(9, 51)
        Me.btnDeleteMovie.Name = "btnDeleteMovie"
        Me.btnDeleteMovie.Size = New System.Drawing.Size(56, 23)
        Me.btnDeleteMovie.TabIndex = 4
        Me.btnDeleteMovie.Text = "Delete"
        Me.btnDeleteMovie.UseVisualStyleBackColor = False
        '
        'grdSearchAviMovies
        '
        Me.grdSearchAviMovies.AllowUserToAddRows = False
        Me.grdSearchAviMovies.AllowUserToDeleteRows = False
        Me.grdSearchAviMovies.AllowUserToOrderColumns = True
        Me.grdSearchAviMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdSearchAviMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSearchAviMovies.Location = New System.Drawing.Point(238, 51)
        Me.grdSearchAviMovies.Name = "grdSearchAviMovies"
        Me.grdSearchAviMovies.ReadOnly = True
        Me.grdSearchAviMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSearchAviMovies.Size = New System.Drawing.Size(386, 248)
        Me.grdSearchAviMovies.TabIndex = 5
        '
        'btnRefreshAvi
        '
        Me.btnRefreshAvi.Location = New System.Drawing.Point(94, 51)
        Me.btnRefreshAvi.Name = "btnRefreshAvi"
        Me.btnRefreshAvi.Size = New System.Drawing.Size(56, 23)
        Me.btnRefreshAvi.TabIndex = 3
        Me.btnRefreshAvi.Text = "Refresh"
        Me.btnRefreshAvi.UseVisualStyleBackColor = True
        '
        'cboSearchAvi
        '
        Me.cboSearchAvi.FormattingEnabled = True
        Me.cboSearchAvi.Items.AddRange(New Object() {"ID", "Title"})
        Me.cboSearchAvi.Location = New System.Drawing.Point(24, 120)
        Me.cboSearchAvi.Name = "cboSearchAvi"
        Me.cboSearchAvi.Size = New System.Drawing.Size(121, 21)
        Me.cboSearchAvi.Sorted = True
        Me.cboSearchAvi.TabIndex = 1
        Me.cboSearchAvi.Text = "Title"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(21, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = "Search by:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 167)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 117
        Me.Label25.Text = "Search"
        '
        'btnGoSearchAvi
        '
        Me.btnGoSearchAvi.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoSearchAvi.Location = New System.Drawing.Point(94, 225)
        Me.btnGoSearchAvi.Name = "btnGoSearchAvi"
        Me.btnGoSearchAvi.Size = New System.Drawing.Size(51, 28)
        Me.btnGoSearchAvi.TabIndex = 2
        Me.btnGoSearchAvi.Text = "Go"
        Me.btnGoSearchAvi.UseVisualStyleBackColor = True
        '
        'txtSearchAvi
        '
        Me.txtSearchAvi.Location = New System.Drawing.Point(27, 188)
        Me.txtSearchAvi.Name = "txtSearchAvi"
        Me.txtSearchAvi.Size = New System.Drawing.Size(175, 20)
        Me.txtSearchAvi.TabIndex = 0
        '
        'tbMovieRate
        '
        Me.tbMovieRate.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Movie_Rate
        Me.tbMovieRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbMovieRate.Controls.Add(Me.lblNoOfTimes)
        Me.tbMovieRate.Controls.Add(Me.btnMovieRateRefresh)
        Me.tbMovieRate.Controls.Add(Me.cboMovieRateSearchBy)
        Me.tbMovieRate.Controls.Add(Me.Label29)
        Me.tbMovieRate.Controls.Add(Me.Label30)
        Me.tbMovieRate.Controls.Add(Me.Label15)
        Me.tbMovieRate.Controls.Add(Me.grdMovieRate)
        Me.tbMovieRate.Controls.Add(Me.btnMovieRateGo)
        Me.tbMovieRate.Controls.Add(Me.txtMovieRateSearch)
        Me.tbMovieRate.Location = New System.Drawing.Point(4, 22)
        Me.tbMovieRate.Name = "tbMovieRate"
        Me.tbMovieRate.Size = New System.Drawing.Size(627, 334)
        Me.tbMovieRate.TabIndex = 9
        Me.tbMovieRate.Text = "Movie Rate"
        Me.tbMovieRate.UseVisualStyleBackColor = True
        '
        'lblNoOfTimes
        '
        Me.lblNoOfTimes.AutoSize = True
        Me.lblNoOfTimes.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfTimes.ForeColor = System.Drawing.Color.White
        Me.lblNoOfTimes.Location = New System.Drawing.Point(16, 267)
        Me.lblNoOfTimes.Name = "lblNoOfTimes"
        Me.lblNoOfTimes.Size = New System.Drawing.Size(0, 23)
        Me.lblNoOfTimes.TabIndex = 123
        '
        'btnMovieRateRefresh
        '
        Me.btnMovieRateRefresh.Location = New System.Drawing.Point(20, 44)
        Me.btnMovieRateRefresh.Name = "btnMovieRateRefresh"
        Me.btnMovieRateRefresh.Size = New System.Drawing.Size(70, 23)
        Me.btnMovieRateRefresh.TabIndex = 3
        Me.btnMovieRateRefresh.Text = "Refresh"
        Me.btnMovieRateRefresh.UseVisualStyleBackColor = True
        '
        'cboMovieRateSearchBy
        '
        Me.cboMovieRateSearchBy.FormattingEnabled = True
        Me.cboMovieRateSearchBy.Items.AddRange(New Object() {"ID", "Title"})
        Me.cboMovieRateSearchBy.Location = New System.Drawing.Point(35, 107)
        Me.cboMovieRateSearchBy.Name = "cboMovieRateSearchBy"
        Me.cboMovieRateSearchBy.Size = New System.Drawing.Size(121, 21)
        Me.cboMovieRateSearchBy.Sorted = True
        Me.cboMovieRateSearchBy.TabIndex = 1
        Me.cboMovieRateSearchBy.Text = "Title"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Yellow
        Me.Label29.Location = New System.Drawing.Point(32, 87)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 13)
        Me.Label29.TabIndex = 122
        Me.Label29.Text = "Search by:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.Yellow
        Me.Label30.Location = New System.Drawing.Point(34, 150)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(41, 13)
        Me.Label30.TabIndex = 121
        Me.Label30.Text = "Search"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(58, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(475, 23)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "This form shows how many times a movie has been rented."
        '
        'grdMovieRate
        '
        Me.grdMovieRate.AllowUserToAddRows = False
        Me.grdMovieRate.AllowUserToDeleteRows = False
        Me.grdMovieRate.AllowUserToOrderColumns = True
        Me.grdMovieRate.AllowUserToResizeColumns = False
        Me.grdMovieRate.AllowUserToResizeRows = False
        Me.grdMovieRate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdMovieRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMovieRate.Location = New System.Drawing.Point(271, 44)
        Me.grdMovieRate.Name = "grdMovieRate"
        Me.grdMovieRate.ReadOnly = True
        Me.grdMovieRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdMovieRate.Size = New System.Drawing.Size(326, 246)
        Me.grdMovieRate.TabIndex = 4
        '
        'btnMovieRateGo
        '
        Me.btnMovieRateGo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovieRateGo.Location = New System.Drawing.Point(96, 219)
        Me.btnMovieRateGo.Name = "btnMovieRateGo"
        Me.btnMovieRateGo.Size = New System.Drawing.Size(60, 34)
        Me.btnMovieRateGo.TabIndex = 2
        Me.btnMovieRateGo.Text = "Go"
        Me.btnMovieRateGo.UseVisualStyleBackColor = True
        '
        'txtMovieRateSearch
        '
        Me.txtMovieRateSearch.Location = New System.Drawing.Point(35, 172)
        Me.txtMovieRateSearch.Name = "txtMovieRateSearch"
        Me.txtMovieRateSearch.Size = New System.Drawing.Size(192, 20)
        Me.txtMovieRateSearch.TabIndex = 0
        '
        'tbAbout
        '
        Me.tbAbout.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.About2
        Me.tbAbout.Location = New System.Drawing.Point(4, 22)
        Me.tbAbout.Name = "tbAbout"
        Me.tbAbout.Size = New System.Drawing.Size(627, 334)
        Me.tbAbout.TabIndex = 7
        Me.tbAbout.Text = "About ..."
        Me.tbAbout.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCreateUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Location = New System.Drawing.Point(81, 440)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(83, 41)
        Me.btnCreateUser.TabIndex = 116
        Me.btnCreateUser.Text = "&Create User Account"
        Me.btnCreateUser.UseVisualStyleBackColor = False
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnChange.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(594, 442)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(122, 41)
        Me.btnChange.TabIndex = 117
        Me.btnChange.Text = "Change Password / Delete User"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'btnLogOff
        '
        Me.btnLogOff.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.login
        Me.btnLogOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogOff.Location = New System.Drawing.Point(750, 463)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(36, 34)
        Me.btnLogOff.TabIndex = 118
        Me.ToolTip1.SetToolTip(Me.btnLogOff, "Log Off")
        Me.btnLogOff.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(654, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 18)
        Me.lblDate.TabIndex = 119
        '
        'lblMsg0
        '
        Me.lblMsg0.AutoSize = True
        Me.lblMsg0.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg0.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg0.ForeColor = System.Drawing.Color.Blue
        Me.lblMsg0.Location = New System.Drawing.Point(228, 446)
        Me.lblMsg0.Name = "lblMsg0"
        Me.lblMsg0.Size = New System.Drawing.Size(0, 23)
        Me.lblMsg0.TabIndex = 120
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.HelpIcon
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Location = New System.Drawing.Point(12, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(41, 39)
        Me.btnHelp.TabIndex = 121
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Home1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(787, 499)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblMsg0)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnLogOff)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home - VIDEO RENTAL SYSTEM"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.tbSearch.ResumeLayout(False)
        Me.tbSearch.PerformLayout()
        CType(Me.grdMovies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbAddMovies.ResumeLayout(False)
        Me.tbAddMovies.PerformLayout()
        Me.tbRent.ResumeLayout(False)
        Me.tbRent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbReservation.ResumeLayout(False)
        Me.tbReservation.PerformLayout()
        CType(Me.grdReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbReturnMovie.ResumeLayout(False)
        Me.tbReturnMovie.PerformLayout()
        CType(Me.grdMoreThan10Days, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRevenue.ResumeLayout(False)
        Me.tbRevenue.PerformLayout()
        CType(Me.grdRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCustomer.ResumeLayout(False)
        Me.tbCustomer.PerformLayout()
        CType(Me.grdCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSearchIfAvi.ResumeLayout(False)
        Me.tbSearchIfAvi.PerformLayout()
        CType(Me.grdSearchAvi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSearchAviMovies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbMovieRate.ResumeLayout(False)
        Me.tbMovieRate.PerformLayout()
        CType(Me.grdMovieRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbAddMovies As System.Windows.Forms.TabPage
    Friend WithEvents tbRent As System.Windows.Forms.TabPage
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtActor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnRent As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRentTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRentID As System.Windows.Forms.TextBox
    Friend WithEvents tbReservation As System.Windows.Forms.TabPage
    Friend WithEvents tbReturnMovie As System.Windows.Forms.TabPage
    Friend WithEvents tbRevenue As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCustTel As System.Windows.Forms.TextBox
    Friend WithEvents btnReserve As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtReserveCName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtReserveTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtReserveMovieID As System.Windows.Forms.TextBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents txtMovieID As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpRevenueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShowRevenue As System.Windows.Forms.Button
    Friend WithEvents dtpDateBought As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateRented As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents tbCustomer As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtSearchCustomer As System.Windows.Forms.TextBox
    Friend WithEvents grdCust As System.Windows.Forms.DataGridView
    Friend WithEvents lst10Due As System.Windows.Forms.ListBox
    Friend WithEvents tbSearch As System.Windows.Forms.TabPage
    Friend WithEvents cboSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSearchGo As System.Windows.Forms.Button
    Friend WithEvents txtSearchMovie As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grdMovies As System.Windows.Forms.DataGridView
    Friend WithEvents grdRevenue As System.Windows.Forms.DataGridView
    Friend WithEvents tbAbout As System.Windows.Forms.TabPage
    Friend WithEvents tbSearchIfAvi As System.Windows.Forms.TabPage
    Friend WithEvents grdSearchAviMovies As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefreshAvi As System.Windows.Forms.Button
    Friend WithEvents cboSearchAvi As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnGoSearchAvi As System.Windows.Forms.Button
    Friend WithEvents txtSearchAvi As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDateReleased As System.Windows.Forms.TextBox
    Friend WithEvents tbMovieRate As System.Windows.Forms.TabPage
    Friend WithEvents grdMovieRate As System.Windows.Forms.DataGridView
    Friend WithEvents btnMovieRateGo As System.Windows.Forms.Button
    Friend WithEvents txtMovieRateSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnMovieRateRefresh As System.Windows.Forms.Button
    Friend WithEvents cboMovieRateSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnCustRefresh As System.Windows.Forms.Button
    Friend WithEvents btnTotalRevenue As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpBegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDeleteMovie As System.Windows.Forms.Button
    Friend WithEvents grdReservation As System.Windows.Forms.DataGridView
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnLogOff As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents lblNoOfTimes As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnNewRent As System.Windows.Forms.Button
    Friend WithEvents btnNewReservation As System.Windows.Forms.Button
    Friend WithEvents btnNewReturn As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblActor As System.Windows.Forms.Label
    Friend WithEvents lblDBought As System.Windows.Forms.Label
    Friend WithEvents lblDReleased As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblRDR As System.Windows.Forms.Label
    Friend WithEvents lblRCN As System.Windows.Forms.Label
    Friend WithEvents lblRTitle As System.Windows.Forms.Label
    Friend WithEvents lblRID As System.Windows.Forms.Label
    Friend WithEvents lblResCT As System.Windows.Forms.Label
    Friend WithEvents lblResCN As System.Windows.Forms.Label
    Friend WithEvents lblResTitle As System.Windows.Forms.Label
    Friend WithEvents lblResID As System.Windows.Forms.Label
    Friend WithEvents lblReturnID As System.Windows.Forms.Label
    Friend WithEvents lblMsg3 As System.Windows.Forms.Label
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents lblMsg2 As System.Windows.Forms.Label
    Friend WithEvents lblMsg5 As System.Windows.Forms.Label
    Friend WithEvents lblMsg0 As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents grdSearchAvi As System.Windows.Forms.DataGridView
    Friend WithEvents grdMoreThan10Days As System.Windows.Forms.DataGridView
End Class
