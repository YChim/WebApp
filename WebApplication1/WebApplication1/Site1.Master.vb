Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") Is Nothing Then
            User.InnerHtml = "<ul class=""myMenu""> <li><a href=""Login_Register.aspx""> Login/Register </a> </li>  </ul>"
        ElseIf Session.Contents("Level") = "3" Then
            User.InnerHtml = "<ul class=""myMenu""> <li><a href=""#""> " & Session("username") & " </a> <ul> <li><a href=""profile.aspx"">Profile</a></li> <li><a href=""ChangePassword.aspx"">Change password</a></li> <li><a href=""ProductManagement.aspx"">Manage Products</a></li> <li><a href=""AddAdmin.aspx"">Add Admin</a></li> <li><a href=""Reports.aspx"">Reports</a></li> <li><a href=""LogOut.aspx"">LogOut</a></li> </ul> </li>  </ul>"
        Else
            User.InnerHtml = "<ul class=""myMenu""> <li><a href=""#""> " & Session("username") & " </a> <ul> <li><a href=""profile.aspx"">Profile</a></li> <li><a href=""ChangePassword.aspx"">Change password</a></li> <li><a href=""LogOut.aspx"">LogOut</a></li> </ul> </li>  </ul>"
        End If

    End Sub

End Class