Imports System.Data
Imports System.Data.SqlClient
Imports WebApplication1.Secrecy

Public Class Profile
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Script.mdf;Integrated Security=True")


    End Sub

End Class