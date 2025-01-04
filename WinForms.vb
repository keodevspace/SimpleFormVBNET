Imports System.Net.Mail
Imports System.Net

Public Class EmailForm
    Inherits Form

    Private labelSender As Label
    Private textBoxSender As TextBox
    Private labelRecipient As Label
    Private textBoxRecipient As TextBox
    Private labelSubject As Label
    Private textBoxSubject As TextBox
    Private labelBody As Label
    Private textBoxBody As TextBox
    Private buttonSend As Button

    Public Sub New()
        ' Configurações do Form
        Me.Text = "Enviar E-mail"
        Me.Size = New Drawing.Size(400, 400)
        Me.StartPosition = FormStartPosition.CenterScreen

        ' Label para o remetente
        labelSender = New Label()
        labelSender.Text = "Remetente (E-mail):"
        labelSender.Location = New Drawing.Point(20, 20)
        labelSender.AutoSize = True

        ' TextBox para o remetente
        textBoxSender = New TextBox()
        textBoxSender.Location = New Drawing.Point(20, 40)
        textBoxSender.Size = New Drawing.Size(350, 20)

        ' Label para o destinatário
        labelRecipient = New Label()
        labelRecipient.Text = "Destinatário (E-mail):"
        labelRecipient.Location = New Drawing.Point(20, 70)
        labelRecipient.AutoSize = True

        ' TextBox para o destinatário
        textBoxRecipient = New TextBox()
        textBoxRecipient.Location = New Drawing.Point(20, 90)
        textBoxRecipient.Size = New Drawing.Size(350, 20)

        ' Label para o assunto
        labelSubject = New Label()
        labelSubject.Text = "Assunto:"
        labelSubject.Location = New Drawing.Point(20, 120)
        labelSubject.AutoSize = True

        ' TextBox para o assunto
        textBoxSubject = New TextBox()
        textBoxSubject.Location = New Drawing.Point(20, 140)
        textBoxSubject.Size = New Drawing.Size(350, 20)

        ' Label para o corpo do e-mail
        labelBody = New Label()
        labelBody.Text = "Corpo do E-mail:"
        labelBody.Location = New Drawing.Point(20, 170)
        labelBody.AutoSize = True

        ' TextBox para o corpo do e-mail
        textBoxBody = New TextBox()
        textBoxBody.Location = New Drawing.Point(20, 190)
        textBoxBody.Size = New Drawing.Size(350, 100)
        textBoxBody.Multiline = True

        ' Botão para enviar o e-mail
        buttonSend = New Button()
        buttonSend.Text = "Enviar E-mail"
        buttonSend.Location = New Drawing.Point(150, 310)
        buttonSend.Size = New Drawing.Size(100, 30)
        AddHandler buttonSend.Click, AddressOf ButtonSend_Click

        ' Adicionar os componentes ao formulário
        Me.Controls.Add(labelSender)
        Me.Controls.Add(textBoxSender)
        Me.Controls.Add(labelRecipient)
        Me.Controls.Add(textBoxRecipient)
        Me.Controls.Add(labelSubject)
        Me.Controls.Add(textBoxSubject)
        Me.Controls.Add(labelBody)
        Me.Controls.Add(textBoxBody)
        Me.Controls.Add(buttonSend)
    End Sub

    ' Evento para enviar o e-mail
    Private Sub ButtonSend_Click(sender As Object, e As EventArgs)
        Try
            ' Configurações do SMTP
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New NetworkCredential("seu_email@gmail.com", "sua_senha")
            smtpClient.EnableSsl = True

            ' Configuração do e-mail
            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress(textBoxSender.Text)
            mailMessage.To.Add(textBoxRecipient.Text)
            mailMessage.Subject = textBoxSubject.Text
            mailMessage.Body = textBoxBody.Text

            ' Enviar o e-mail
            smtpClient.Send(mailMessage)

            MessageBox.Show("E-mail enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Erro ao enviar e-mail: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Método principal para inicializar a aplicação
    <STAThread>
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New EmailForm())
    End Sub
End Class
