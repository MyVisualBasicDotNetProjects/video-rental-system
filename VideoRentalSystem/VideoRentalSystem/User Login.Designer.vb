<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLogin
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
        Me.components = New System.ComponentModel.Container
        Me.cboUserName = New System.Windows.Forms.ComboBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.trVisible = New System.Windows.Forms.Timer(Me.components)
        Me.lblType = New System.Windows.Forms.Label
        Me.tr2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cboUserName
        '
        Me.cboUserName.DisplayMember = "UserName"
        Me.cboUserName.FormattingEnabled = True
        Me.cboUserName.Location = New System.Drawing.Point(324, 114)
        Me.cboUserName.Name = "cboUserName"
        Me.cboUserName.Size = New System.Drawing.Size(170, 21)
        Me.cboUserName.TabIndex = 29
        Me.cboUserName.ValueMember = "UserName"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(324, 172)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(170, 20)
        Me.txtPassword.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnCancel.Location = New System.Drawing.Point(422, 218)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(330, 218)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(78, 23)
        Me.btnOk.TabIndex = 26
        Me.btnOk.Text = "&Ok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(321, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(321, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "User Account"
        '
        'trVisible
        '
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(192, 245)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(66, 13)
        Me.lblType.TabIndex = 30
        Me.lblType.Text = "Type of user"
        '
        'frmUserLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Welcome_with_Bere
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(544, 300)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.cboUserName)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "frmUserLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login - VIDEO RENTAL SYSTEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboUserName As System.Windows.Forms.ComboBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trVisible As System.Windows.Forms.Timer
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents tr2 As System.Windows.Forms.Timer
End Class
