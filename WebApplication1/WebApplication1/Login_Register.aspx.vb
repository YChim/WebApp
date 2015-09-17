Imports System.Data
Imports System.Data.SqlClient
Imports WebApplication1.Secrecy

Public Class Login_Register
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private reader As SqlDataReader
    Private command As SqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Script.mdf;Integrated Security=True")
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Then
            txtpass.Text = ""
            txtUser.Text = ""
            Exit Sub
        ElseIf txtpass.Text = "" Then
            txtpass.Text = ""
            txtUser.Text = ""
            Exit Sub
        End If

        Dim user As String = txtUser.Text
        Dim password As String = HashPassword(txtpass.Text)

        command = New SqlCommand("SELECT * FROM [User] WHERE UserName = @user AND PassWord = @pass", connection)
        command.CommandType = CommandType.Text
        command.Parameters.AddWithValue("@user", user)
        command.Parameters.AddWithValue("@pass", password)

        connection.Open()

        reader = command.ExecuteReader

        If reader.HasRows Then
            Do While reader.Read
                Session("username") = reader("UserName")
                Session("Level") = reader("AccessLevel")
            Loop
            Response.Redirect("Index.aspx")
        Else
            command.Dispose()
        End If
        command.Dispose()
        connection.Close()

        txtpass.Text = ""
        txtUser.Text = ""
    End Sub
End Class