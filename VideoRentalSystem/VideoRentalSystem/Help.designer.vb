<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.btnCap = New System.Windows.Forms.Button
        Me.btnHow = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnAbout = New System.Windows.Forms.Button
        Me.txtCapabilities = New System.Windows.Forms.RichTextBox
        Me.pbHelp = New System.Windows.Forms.PictureBox
        Me.btnHome = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        CType(Me.pbHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCap
        '
        Me.btnCap.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCap.Location = New System.Drawing.Point(23, 97)
        Me.btnCap.Name = "btnCap"
        Me.btnCap.Size = New System.Drawing.Size(105, 73)
        Me.btnCap.TabIndex = 1
        Me.btnCap.Text = "CAPABILITIES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VRS"
        Me.btnCap.UseVisualStyleBackColor = True
        '
        'btnHow
        '
        Me.btnHow.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHow.Location = New System.Drawing.Point(23, 182)
        Me.btnHow.Name = "btnHow"
        Me.btnHow.Size = New System.Drawing.Size(105, 73)
        Me.btnHow.TabIndex = 2
        Me.btnHow.Text = "HOW TO ..."
        Me.btnHow.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(23, 272)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(105, 73)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "SHOW FORM AND CODE"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(23, 362)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(105, 73)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "ABOUT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PROGRAMMER"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'txtCapabilities
        '
        Me.txtCapabilities.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapabilities.Location = New System.Drawing.Point(158, 93)
        Me.txtCapabilities.Name = "txtCapabilities"
        Me.txtCapabilities.ReadOnly = True
        Me.txtCapabilities.Size = New System.Drawing.Size(230, 359)
        Me.txtCapabilities.TabIndex = 6
        Me.txtCapabilities.Text = resources.GetString("txtCapabilities.Text")
        '
        'pbHelp
        '
        Me.pbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbHelp.Image = Global.VideoRentalSystem.My.Resources.Resources.HelpFrontPage2
        Me.pbHelp.Location = New System.Drawing.Point(158, 91)
        Me.pbHelp.Name = "pbHelp"
        Me.pbHelp.Size = New System.Drawing.Size(230, 359)
        Me.pbHelp.TabIndex = 7
        Me.pbHelp.TabStop = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Yellow
        Me.btnHome.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.btnHome
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(12, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(41, 39)
        Me.btnHome.TabIndex = 119
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Yellow
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Location = New System.Drawing.Point(338, 11)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(57, 33)
        Me.btnRefresh.TabIndex = 120
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VideoRentalSystem.My.Resources.Resources.Help3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(407, 493)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.pbHelp)
        Me.Controls.Add(Me.txtCapabilities)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnHow)
        Me.Controls.Add(Me.btnCap)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(850, 100)
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Help - VIDEO RENTAL SYSTEM"
        CType(Me.pbHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCap As System.Windows.Forms.Button
    Friend WithEvents btnHow As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents txtCapabilities As System.Windows.Forms.RichTextBox
    Friend WithEvents pbHelp As System.Windows.Forms.PictureBox
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button ~dulla^@204~ 