Public NotInheritable Class frmSplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Me.Opacity = 0
        trVisible.Start()
        frmUserLogin.txtPassword.Focus()
        Button1.Visible = False
        Call Button1_Click(Nothing, Nothing)

    End Sub

    Private Sub trVisible_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trVisible.Tick

        If Me.Opacity > 1 Then
            trVisible.Stop()
            ' ''frmUserLogin.Opacity = 0
            ' ''frmUserLogin.tr2.Start()
        Else
            Me.Opacity = Me.Opacity + 0.1
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmUserLogin.cboUserName_SelectedValueChanged(Nothing, Nothing)
    End Sub
End Class
