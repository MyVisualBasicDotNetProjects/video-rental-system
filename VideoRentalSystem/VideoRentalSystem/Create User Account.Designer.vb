<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateUserAccount
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbSalesPerson = New System.Windows.Forms.RadioButton
        Me.rdbManager = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.btnCreateUser = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdbSalesPerson)
        Me.GroupBox2.Controls.Add(Me.rdbManager)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(615, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 79)
        Me.GroupBox2.TabIndex = 117
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type of Access"
        '
        'rdbSalesPerson
        '
        Me.rdbSalesPerson.AutoSize = True
        Me.rdbSalesPerson.ForeColor = System.Drawing.Color.Blue
        Me.rdbSalesPerson.Location = New System.Drawing.Point(23, 46)
        Me.rdbSalesPerson.Name = "rdbSalesPerson"
        Me.rdbSalesPerson.Size = New System.Drawing.Size(113, 22)
        Me.rdbSalesPerson.TabIndex = 1
        Me.rdbSalesPerson.TabStop = True
        Me.rdbSalesPerson.Text = "Sales person"
        Me.rdbSalesPerson.UseVisualStyleBackColor = True
        '
        'rdbManager
        '
        Me.rdbManager.AutoSize = True
        Me.rdbManager.ForeColor = System.Drawing.Color.Blue
        Me.rdbManager.Location = New System.Drawing.Point(23, 23)
        Me.rdbManager.Name = "rdbManager"
        Me.rdbManager.Size = New System.Drawing.Size(84, 22)
        Me.rdbManager.TabIndex = 0
        Me.rdbManager.TabStop = True
        Me.rdbManager.Text = "Manager"
        Me.rdbManager.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(177, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 172)
        Me.GroupBox1.TabIndex = 116
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Name Information"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(167, 35)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(162, 27)
        Me.txtUserName.TabIndex = 0
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Blue
        Me.UsernameLabel.Location = New System.Drawing.Point(22, 35)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(116, 23)
        Me.UsernameLabel.TabIndex = 16
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(22, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(22, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(167, 75)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(162, 27)
        Me.txtNewPassword.TabIndex = 1
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(167, 111)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(162, 27)
        Me.txtConfirmPassword.TabIndex = 2
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateUser.Location = New System.Drawing.Point(399, 377)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(90, 30)
        Me.btnCreateUser.TabIndex = 115
        Me.btnCreateUser.Text = "&Create"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.btnHome
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(725, 375)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 39)
        Me.btnHome.TabIndex = 118
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.HelpIcon
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Location = New System.Drawing.Point(12, 12)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(41, 39)
        Me.btnHelp.TabIndex = 122
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmCreateUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 1 ~dulla^@204~ ~dulla^@204~ Mode = System.Windows.Forms.AutoScale~dulla^@204~       Me.BackgroundImage = Global.Vid~dulla^@204~ m.My.Resources.Resources.Create_User_~dulla^@204~     Me.ClientSize = New System.Drawin~dulla^@204~ 81)
        Me.Controls.Add(Me.btnHe~dulla^@204~ Me.Controls.Add(Me.btnHome)
        ~dulla^@204~ dd(Me.GroupBox2)
        Me.Controls~dulla^@204~ Box1)
        Me.Controls.Add(Me.btn~dulla^@204~         Me.Name = "frmCreateUserAccou~dulla^@204~ Me.StartPosition = System.Windows.For~dulla^@204~ osition.CenterScreen
        Me.Text~dulla^@204~ er Account  - VIDEO RENTAL SYSTEM"
 ~dulla^@204~ upBox2.ResumeLayout(False)
        M~dulla^@204~ erformLayout()
        Me.GroupBox1.~dulla^@204~ False)
        Me.GroupBox1.PerformL~dulla^@204~     Me.ResumeLayout(False)

    End~dulla^@204~ end WithEvents GroupBox2 As System.Wi~dulla^@204~ roupBox
    Friend WithEvents rdbSal~dulla^@204~ ystem.Windows.Forms.RadioButton
    ~dulla^@204~ ents rdbManager As System.Windows.For~dulla^@204~ n
    Friend WithEvents GroupBox1 As~dulla^@204~ ws.Forms.GroupBox
    Friend WithEve~dulla^@204~ me As System.Windows.Forms.TextBox
 ~dulla^@204~ hEvents UsernameLabel As System.Windo~dulla^@204~ l
    Friend WithEvents Label3 As Sy~dulla^@204~ Forms.Label
    Friend WithEvents La~dulla^@204~ m.Windows.Forms.Label
    Friend Wit~dulla^@204~ wPassword As System.Windows.Forms.Tex~dulla^@204~ end WithEvents txtConfirmPassword As ~dulla^@204~ s.Forms.TextBox
    Friend WithEvent~dulla^@204~ er As System.Windows.Forms.Button
  ~dulla^@204~ Events btnHome As System.Windows.Form~dulla^@204~  Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
