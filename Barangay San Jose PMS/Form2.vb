Imports System.Net.Http
Imports System.Text

Public Class Form2
    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Hide()
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using client As New HttpClient()
            ' Set the URL for the POST request
            Dim url As String = "http://127.0.0.1:8000/api/login/"
            Dim username = usernametxt.Text
            Dim password = PasswordText.Text

            ' Create the JSON payload
            Dim json As String = $"{{""username"":""{username}"",""password"":""{password}""}}"
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")


            Try
                ' Send the POST request
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

                ' Ensure the request was successful
                response.EnsureSuccessStatusCode()

                ' Read the response
                Dim responseString As String = Await response.Content.ReadAsStringAsync()

                ' Display the response in a message box
                MessageBox.Show(responseString, "Response", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Open Form5 after a successful response
                Dim form5 As New Form5()
                form5.Show()
                Me.Hide() ' Optional: Hide the current form if you want to close it

            Catch ex As HttpRequestException
                ' Handle any errors here
                MessageBox.Show($"Request error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub





    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordText.UseSystemPasswordChar = False
        Else
            PasswordText.UseSystemPasswordChar = True
        End If
    End Sub
End Class