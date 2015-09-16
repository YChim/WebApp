Imports System.Data
Imports System.Data.SqlClient
Imports WebApplication1.Secrecy

Public Class Profile
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader
    Private connectionString As String = ""
    Private sql As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connection = New SqlConnection(connectionString)

    End Sub

End Class