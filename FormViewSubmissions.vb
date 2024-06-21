Imports System.Net.Http
Imports Newtonsoft.Json

Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private client As New HttpClient()

    Private Async Sub FetchSubmission(index As Integer)
        Dim url As String = $"http://localhost:3000/read?index={index}"
        Dim response As HttpResponseMessage = Await client.GetAsync(url)

        If response.IsSuccessStatusCode Then
            Dim responseData As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseData)

            txtName.Text = submission("name")
            txtEmail.Text = submission("email")
            txtPhone.Text = submission("phone")
            txtGithub.Text = submission("github_link")
            txtStopwatch.Text = submission("stopwatch_time")
        Else
            MessageBox.Show("Error fetching submission")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            FetchSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        FetchSubmission(currentIndex)
    End Sub

    Private Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchSubmission(currentIndex)
        Me.KeyPreview = True
    End Sub

    Private Sub FormViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
