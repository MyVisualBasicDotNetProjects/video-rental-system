Public Class frmHelp

    Private Sub btnCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap.Click

        pbHelp.Hide()
        pbProgrammer.Hide()
        txtCapabilities.Show()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        pbHelp.Image = VideoRentalSystem.My.Resources.Resources.HelpFrontPage21
        pbHelp.Show()
        txtCapabilities.Hide()

    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click

        pbProgrammer.Show()
        txtCapabilities.Hide()
        pbHelp.Hide()

    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        frmHome.Show()
        frmHome.StartPosition = FormStartPosition.CenterScreen
        frmHome.Location = New System.Drawing.Point(238, 117)
        Me.Close()

    End Sub

    Private Sub frmHelp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtCapabilities.Hide()

    End Sub
End Class
