Imports System.Net.Mail
Imports System.Net.Mime

Public Class Email

    Private Sub envia_btn_Click(sender As System.Object, e As System.EventArgs) Handles envia_btn.Click
        Dim servidor As String = "smtp.live.com"
        Dim utilizador_mail As String = user.Text
        Dim utilizador_pass As String = pass.Text
        Dim mail_para As String = destin.Text
        Dim mail_assunto As String = "Subject"
        Dim mail_conteudo As String = "Content"
        Dim mail_anexo As String = Cart.OpenFileDialog1.FileName


        CreateMessageWithAttachment(servidor, utilizador_mail, utilizador_pass, mail_para, mail_assunto, mail_conteudo, mail_anexo)
    End Sub

    Public Shared Sub CreateMessageWithAttachment(ByVal server As String, ByVal u As String, ByVal p As String, ByVal mp As String, ByVal ma As String, ByVal mc As String, ByVal mx As String)
        ' Specify the file to be attached and sent.
        ' This example assumes that a file named Data.xls exists in the
        ' current working directory.
        Try
            Dim file As String = mx

            ' Create a message and set up the recipients.

            Dim message As New MailMessage(u, mp, ma, mc)

            ' Create  the file attachment for this e-mail message.
            Dim data As New Attachment(file, MediaTypeNames.Application.Octet)

            ' Add time stamp information for the file.
            Dim disposition As ContentDisposition = data.ContentDisposition
            disposition.CreationDate = IO.File.GetCreationTime(file)
            disposition.ModificationDate = IO.File.GetLastWriteTime(file)
            disposition.ReadDate = IO.File.GetLastAccessTime(file)

            ' Add the file attachment to this e-mail message.
            message.Attachments.Add(data)

            'Send the message.
            Dim client As New SmtpClient(server)

            ' Add credentials if the SMTP server requires them.
            client.EnableSsl = True
            client.Credentials = New System.Net.NetworkCredential(u, p)

            '   client.Credentials = CredentialCache.DefaultNetworkCredentials

            Try
                client.Send(message)
                MsgBox("Enviado com sucesso!")
            Catch ex As Exception
                MsgBox("Exception caught in CreateMessageWithAttachment(): {0}", MsgBoxStyle.Critical, ex.ToString())
            End Try
            ' Display the values in the ContentDisposition for the attachment.
            Dim cd As ContentDisposition = data.ContentDisposition
            Console.WriteLine("Content disposition")
            Console.WriteLine(cd.ToString())
            Console.WriteLine("File {0}", cd.FileName)
            Console.WriteLine("Size {0}", cd.Size)
            Console.WriteLine("Creation {0}", cd.CreationDate)
            Console.WriteLine("Modification {0}", cd.ModificationDate)
            Console.WriteLine("Read {0}", cd.ReadDate)
            Console.WriteLine("Inline {0}", cd.Inline)
            Console.WriteLine("Parameters: {0}", cd.Parameters.Count)
            For Each d In cd.Parameters
                Console.WriteLine("{0} = {1}", d.Key, d.Value)
            Next d
            data.Dispose()
        Catch ex As Exception
            MsgBox("ERROR on sending", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
End Class