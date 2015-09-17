Imports System.Data
Imports System.Data.SqlClient
Imports WebApplication1.Secrecy

Public Class Register
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private reader As SqlDataReader
    Private command As SqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Script.mdf;Integrated Security=True")
    End Sub

    Protected Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim level As String = ""

        If txtfirst.Text = "" Then
            txtcon.Text = ""
            txtEmail.Text = ""
            txtfirst.Text = ""
            txtlast.Text = ""
            txtpassword.Text = ""
            txtuser.Text = ""
            Exit Sub
        ElseIf txtlast.Text = "" Then
            txtcon.Text = ""
            txtEmail.Text = ""
            txtfirst.Text = ""
            txtlast.Text = ""
            txtpassword.Text = ""
            txtuser.Text = ""
            Exit Sub
        ElseIf txtEmail.Text = "" Then
            txtcon.Text = ""
            txtEmail.Text = ""
            txtfirst.Text = ""
            txtlast.Text = ""
            txtpassword.Text = ""
            txtuser.Text = ""
            Exit Sub
        ElseIf txtuser.Text = "" Then
            txtcon.Text = ""
            txtEmail.Text = ""
            txtfirst.Text = ""
            txtlast.Text = ""
            txtpassword.Text = ""
            txtuser.Text = ""
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            txtcon.Text = ""
            txtEmail.Text = ""
            txtfirst.Text = ""
            txtlast.Text = ""
            txtpassword.Text = ""
            txtuser.Text = ""
            Exit Sub
        ElseIf txtcon.Text = "" Then
            txtcon.Text = ""
            txtEmail.Text = ""
            txtfirst.Text = ""
            txtlast.Text = ""
            txtpassword.Text = ""
            txtuser.Text = ""
            Exit Sub
        End If

        If DropBox.Text = "Premium" Then
            level = "2"
        Else
            level = "1"
        End If

        If txtpassword.Text <> txtcon.Text Then
            Exit Sub
        Else
            command = New SqlCommand("INSERT INTO [User] VALUES(@user, @password, @first, @surname, @level, @email)", connection)
            command.CommandType = CommandType.Text
            command.Parameters.AddWithValue("@user", txtuser.Text)
            command.Parameters.AddWithValue("@password", HashPassword(txtpassword.Text))
            command.Parameters.AddWithValue("@first", txtfirst.Text)
            command.Parameters.AddWithValue("@surname", txtlast.Text)
            command.Parameters.AddWithValue("@level", level)
            command.Parameters.AddWithValue("@email", txtEmail.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            Response.Redirect("Login_Register.aspx")
        End If

        connection.Close()
        txtcon.Text = ""
        txtEmail.Text = ""
        txtfirst.Text = ""
        txtlast.Text = ""
        txtpassword.Text = ""
        txtuser.Text = ""

    End Sub
End Class