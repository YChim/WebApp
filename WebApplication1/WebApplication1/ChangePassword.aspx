<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="ChangePassword.aspx.vb" Inherits="WebApplication1.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="body" style="width:50%; " >

       <h1><u><b>Change Password</b></u></h1>

        <table style="margin:auto; font-size:25px; text-align:left;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Old password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtOld" Type="password" runat="server" Font-Size="17px" Height="27px" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="New password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtnew" Type="password" runat="server" Font-Size="17px" Height="27px" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Confirm password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCon" Type="password" runat="server" Font-Size="17px" Height="27px" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Change" Width="177px" Height="32px" />
                </td>
            </tr>
        </table>

   </div>

</asp:Content>
