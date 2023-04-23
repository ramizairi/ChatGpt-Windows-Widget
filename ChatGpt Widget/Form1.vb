Imports System.Drawing.Drawing2D
Imports System.Security.Policy
Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Newtonsoft.Json.Linq
Imports My.Settings



Public Class Form1


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        NotifyIcon1.Visible = True
        Me.ShowInTaskbar = False
    End Sub
    Private _apiForm As api
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 528, Screen.PrimaryScreen.WorkingArea.Height - 280)
        NotifyIcon1.Icon = Me.Icon
        NotifyIcon1.Text = "ChatGpt Widget"
        Dim OBJ As New api
        Dim apiForm As New api()
        apiForm.myapi.Text = apiForm.APIKey
        _apiForm = New api()
        _apiForm.Show()
        If My.Settings.IsApiKeySet Then
            _apiForm.Hide()
        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Left Then
            If Me.WindowState = FormWindowState.Minimized AndAlso NotifyIcon1.Visible = True Then
                Me.WindowState = FormWindowState.Normal
                Me.ShowInTaskbar = True
                NotifyIcon1.Visible = False
                Me.Activate()
            End If
        End If
    End Sub


    Private Sub GunaPanel1_MouseDown(sender As Object, e As MouseEventArgs) Handles GunaPanel1.MouseDown

    End Sub

    Private Sub GunaPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles GunaPanel1.MouseMove

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btnAPI.Click
        api.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim url3 As String = "https://linktr.ee/medramizairi"
        Dim psi3 As New ProcessStartInfo(url3)
        psi3.UseShellExecute = True
        Process.Start(psi3)

    End Sub
    Private apiKey As String = My.Settings.APIKey
    Private endpoint As String = "https://api.openai.com/v1/engines/text-davinci-003/completions"
    Private rateLimitInterval As Integer = 300
    Private isProcessingRequest As Boolean = False
    Private Sub input_KeyDown(sender As Object, e As KeyEventArgs) Handles input.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btn_Click(sender, e)
        End If
    End Sub
    Private Async Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        If input.Text = "" Then
            output.Text = "Please enter some text to prompt the AI."
            Return
        End If

        If isProcessingRequest Then
            output.Text = "Please wait for the previous request to finish."
            Return
        End If

        isProcessingRequest = True

        Try
            Using httpClient As New HttpClient()
                httpClient.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", My.Settings.APIKey)
                Dim requestData As String = "{""prompt"":""" & input.Text & """, ""max_tokens"":100, ""temperature"":0.1}"
                Dim content As New StringContent(requestData, Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = Await httpClient.PostAsync(endpoint, content)
                response.EnsureSuccessStatusCode()
                Dim responseString As String = Await response.Content.ReadAsStringAsync()
                Dim outputJson As JObject = JObject.Parse(responseString)
                Dim outputText As String = outputJson("choices")(0)("text").ToString()
                output.Text = outputText
                input.Text = ""
            End Using
        Catch ex As Exception
            output.Text = "An error occurred while communicating with the API: " & ex.Message
        End Try

        isProcessingRequest = False
    End Sub


    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If input.Text = "" Then
            MessageBox.Show("Please type something in the input box", "X Ai Error")
            Return
        End If
        Clipboard.SetText(output.Text)
        input.Text = ""
        output.Text = ""
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub


End Class
