<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.btnChange = New System.Windows.Forms.Button
        Me.btnHome = New System.Windows.Forms.Button
        Me.btnDeleteUser = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(187, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 165)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Name Information"
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(139, 21)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(161, 23)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(22, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Old Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Location = New System.Drawing.Point(138, 55)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtOldPassword.TabIndex = 17
        '
        'UsernameLabel
        '
        Me.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UsernameLabel.Location = New System.Drawing.Point(22, 23)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(116, 23)
        Me.UsernameLabel.TabIndex = 16
        Me.UsernameLabel.Text = "User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(138, 89)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtNewPassword.TabIndex = 2
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(138, 122)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(162, 23)
        Me.txtConfirmPassword.TabIndex = 1
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(294, 332)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(111, 33)
        Me.btnChange.TabIndex = 18
        Me.btnChange.Text = "&Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.btnHome
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(647, 326)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 39)
        Me.btnHome.TabIndex = 114
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.Red
        Me.btnDeleteUser.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.Location = New System.Drawing.Point(558, 156)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(111, 33)
        Me.btnDeleteUser.TabIndex = 115
        Me.btnDeleteUser.Text = "&Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.HelpIcon
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHelp.Location = New System.Drawing.Point(12, 12)
 ~dulla^@204~ ~dulla^@204~ btnHelp"
        Me.btnHelp.Size = N~dulla^@204~ wing.Size(41, 39)
        Me.btnHelp~dulla^@204~ 23
        Me.btnHelp.UseVisualStyle~dulla^@204~ rue
        '
        'frmChangePas~dulla^@204~   '
        Me.AutoScaleDimensions =~dulla^@204~ rawing.SizeF(6.0!, 13.0!)
        Me~dulla^@204~ e = System.Windows.Forms.AutoScaleMod~dulla^@204~    Me.BackgroundImage = Global.VideoR~dulla^@204~ y.Resources.Resources.Change_Password~dulla^@204~ ClientSize = New System.Drawing.Size(~dulla^@204~       Me.Controls.Add(Me.btnHelp)
  ~dulla^@204~ rols.Add(Me.btnDeleteUser)
        M~dulla^@204~ d(Me.btnHome)
        Me.Controls.Ad~dulla^@204~ 1)
        Me.Controls.Add(Me.btnCha~dulla^@204~  Me.Name = "frmChangePassword"
     ~dulla^@204~ sition = System.Windows.Forms.FormSta~dulla^@204~ nterScreen
        Me.Text = "Change~dulla^@204~ VIDEO RENTAL SYSTEM"
        Me.Grou~dulla^@204~ ayout(False)
        Me.GroupBox1.Pe~dulla^@204~ 
        Me.ResumeLayout(False)

 ~dulla^@204~    Friend WithEvents GroupBox1 As Sys~dulla^@204~ orms.GroupBox
    Friend WithEvents ~dulla^@204~ s System.Windows.Forms.Label
    Fri~dulla^@204~ s Label4 As System.Windows.Forms.Labe~dulla^@204~  WithEvents txtOldPassword As System.~dulla^@204~ .TextBox
    Friend WithEvents Usern~dulla^@204~ ystem.Windows.Forms.Label
    Friend~dulla^@204~ abel3 As System.Windows.Forms.Label
~dulla^@204~ thEvents Label2 As System.Windows.For~dulla^@204~  Friend WithEvents txtNewPassword As ~dulla^@204~ s.Forms.TextBox
    Friend WithEvent~dulla^@204~ assword As System.Windows.Forms.TextB~dulla^@204~ d WithEvents btnChange As System.Wind~dulla^@204~ ton
    Friend WithEvents btnHome As~dulla^@204~ ws.Forms.Button
    Friend WithEvent~dulla^@204~ er As System.Windows.Forms.Button
  ~dulla^@204~ Events btnHelp As System.Windows.Forms.Button
End Class