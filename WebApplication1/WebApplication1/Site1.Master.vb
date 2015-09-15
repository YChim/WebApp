Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("User") Is Nothing Then

        Else

        End If
        User.InnerHtml = "<ul class=""myMenu""> <li><a href=""#""> Admin </a> <ul> <li><a href=""profile.aspx"">Profile</a></li> <li><a href=""ChangePassword.aspx"">Change password</a></li> <li><a href=""LogOut.aspx"">LogOut</a></li> </ul> </li>  </ul>"
    End Sub

End Class