Public Class api
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles save.Click
        If APIKey = "" Then
            MessageBox.Show("API box is clear", "ChatGpt Widget")
        Else
            My.Settings.APIKey = myapi.Text
            My.Settings.IsApiKeySet = True
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim url As String = "https://linktr.ee/medramizairi"
        Dim psi As New ProcessStartInfo(url)
        psi.UseShellExecute = True
        Process.Start(psi)
    End Sub

    Private Sub txtAPIKey_TextChanged(sender As Object, e As EventArgs) Handles myapi.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url2 As String = "https://beta.openai.com/account/api-keys"
        Dim psi As New ProcessStartInfo(url2)
        psi.UseShellExecute = True
        Process.Start(psi)

    End Sub

    Public ReadOnly Property APIKey() As String
        Get
            Return myapi.Text
        End Get
    End Property

End Class