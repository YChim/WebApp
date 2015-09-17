Imports System.Data.SqlClient
Imports System.Data

Public Class index
    Inherits System.Web.UI.Page

    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim output As String = "<div id=""hero""> <div id=""pager""></div> <span class=""cycle-prev"">&#9001</span> <span class=""cycle-next"">&#9002</span> <div id=""slider"">"
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Script.mdf;Integrated Security=True")
        command = New SqlCommand("SELECT * FROM [Catagory]", connection)
        command.CommandType = CommandType.Text

        connection.Open()

        reader = command.ExecuteReader

        Do While reader.Read
            output &= "<div class=""items"" > <img src=""../images/" & reader("Image") & """ />"
            output &= "<div class=""info""> <h2>" & reader("Name") & "</h2>  <p>"
            output &= reader("Description") & "<a href=""Science.aspx""> Click Here</a></p> </div> </div>"
        Loop

        output &= "</div> </div>"
        mainpage.InnerHtml = output

    End Sub

End Class