Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurações do Formulário
        Me.Text = "Mengo's Forms"
        Me.BackColor = Color.Black
        Me.Size = New Size(400, 300)

        ' Label para o título
        Dim lblTitle As New Label()
        lblTitle.Text = "Mengo's Forms"
        lblTitle.Font = New Font("Arial", 16, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(100, 20)
        Me.Controls.Add(lblTitle)

        ' Label para o nome
        Dim lblName As New Label()
        lblName.Text = "Warrior:"
        lblName.ForeColor = Color.White
        lblName.Location = New Point(50, 70)
        Me.Controls.Add(lblName)

        ' TextBox para o nome
        Dim txtName As New TextBox()
        txtName.Location = New Point(150, 70)
        txtName.Width = 200
        Me.Controls.Add(txtName)

        ' Label para o email
        Dim lblEmail As New Label()
        lblEmail.Text = "Email:"
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(50, 110)
        Me.Controls.Add(lblEmail)

        ' TextBox para o email
        Dim txtEmail As New TextBox()
        txtEmail.Location = New Point(150, 110)
        txtEmail.Width = 200
        Me.Controls.Add(txtEmail)

        ' Label para a mensagem
        Dim lblMessage As New Label()
        lblMessage.Text = "Say SRN:"
        lblMessage.ForeColor = Color.White
        lblMessage.Location = New Point(50, 150)
        Me.Controls.Add(lblMessage)

        ' TextBox para a mensagem
        Dim txtMessage As New TextBox()
        txtMessage.Location = New Point(150, 150)
        txtMessage.Width = 200
        txtMessage.Height = 60
        txtMessage.Multiline = True
        Me.Controls.Add(txtMessage)

        ' Botão de enviar
        Dim btnSubmit As New Button()
        btnSubmit.Text = "Send"
        btnSubmit.BackColor = Color.Red
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(150, 230)
        btnSubmit.Width = 100
        AddHandler btnSubmit.Click, AddressOf BtnSubmit_Click
        Me.Controls.Add(btnSubmit)
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        MessageBox.Show("SRN,the message was sent.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
