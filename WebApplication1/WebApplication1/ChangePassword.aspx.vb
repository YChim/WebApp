Imports System.Data
Imports System.Data.SqlClient
Imports WebApplication1.Secrecy

Public Class ChangePassword
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader
    Private connectionString As String = ""
    Private sql As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection = New SqlConnection(connectionString)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtOld.Text = "" Then
            Exit Sub
        ElseIf txtnew.Text = "" Then
            Exit Sub
        ElseIf txtCon.Text = "" Then
            Exit Sub
        End If

        Dim password As String = HashPassword(txtOld.Text)
        command = New SqlCommand("SELECT * FROM [Users] WHERE Username = @pass", connection)
        command.CommandType = CommandType.Text
        command.Parameters.AddWithValue("@pass", password)
        Dim ID As Integer
        connection.Open()

        reader = command.ExecuteReader
        If reader.HasRows Then
            Do While reader.Read
                ID = reader("ID")
            Loop
            command.Dispose()
            command = New SqlCommand("UPDATE [Users] set Password = @pass WHERE ID=@id", connection)
            command.CommandType = CommandType.Text
            command.Parameters.AddWithValue("@pass", password)
            command.Parameters.AddWithValue("@id", ID)
            command.ExecuteNonQuery()
        End If

        connection.Close()

    End Sub
End Class