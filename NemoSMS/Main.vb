Imports System.Net
Imports System.Drawing
Imports System.Web
Imports System.Text
Public Class MainForm
    'You will need to sign up for an account with 
    Private Sub txtboxMessage_TextChanged(sender As Object, e As EventArgs) Handles txtboxMessage.TextChanged
        'Message box max length set to 160 charcters
        lblCharctersLeftNum.Text = txtboxMessage.MaxLength - txtboxMessage.TextLength
    End Sub

    Private Sub btnClearMessage_Click(sender As Object, e As EventArgs) Handles btnClearMessage.Click
        'Clears All Text Boxes
        txtboxSender.Text = ""
        txtboxMessage.Text = ""
        txtboxRecipients.Text = ""
    End Sub
    Private Sub btnSendSMS_Click(sender As Object, e As EventArgs) Handles btnSendSMS.Click
        'Varibles required to send SMS via SMS API Gateway
        Dim request As HttpWebRequest
        Dim version As String = "HTTPV3"
        Dim un As String = "YOUR USERNAME"
        Dim pwd As String = "YOUR PASSWORD"
        Dim route As String = "2"
        Dim url As String
        Dim host As String = "http://api.gateway360.com/api/sms/submit_sms"
        Dim sourceAddress As String = txtboxSender.Text
        Dim recipients As String = txtboxRecipients.Text
        Dim msg As String = txtboxMessage.Text


        'SMS Publi API Documentation Can be Found here http://panel.smspubli.com/app/sms/settings/docs/api_sms.pdf
        'Version 
        Try
            url = host + "/?V=" & HttpUtility.UrlEncode(version) _
                    & "&UN=" + HttpUtility.UrlEncode(un) _
                    & "&PWD=" + HttpUtility.UrlEncode(pwd) _
                    & "&R=" + HttpUtility.UrlEncode(route) _
                    & "&SA=" + HttpUtility.UrlEncode(sourceAddress) _
                    & "&DA=" + HttpUtility.UrlEncode(recipients) _
                    & "&M=" + HttpUtility.UrlPathEncode(msg)

            request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            Dim postdata As String = url
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postdata)
            Dim response As WebResponse = request.GetResponse()
            MessageBox.Show((CType(response, HttpWebResponse).StatusDescription))
            response.Close()


        Catch ex As Exception
            MessageBox.Show("Messege Failed to Send")
            Me.Close()
        End Try



    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
