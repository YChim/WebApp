<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Login_Register.aspx.vb" Inherits="WebApplication1.Login_Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 182px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="body" style="width:50%; " >

        <table style ="margin:auto;">
            <tr>
                <td> <h3>LOGIN HERE --OR--</h3> </td>
                <td style ="background-color: lightblue; width: 120px; border-radius:50%; text-decoration: none; font-size:20px; cursor:pointer; text-align:center;"> <a style="text-decoration:none; text-decoration-color:black;  display:block; background-color:lightblue; text-align:center; margin:0; color:black; border-radius:50%; height:32px; " href="Register.aspx"> Register</a></td>
            </tr>
        </table>
        <br />

        <table style="font-size:26px; margin:auto;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUser" runat="server" Font-Size="20px" Height="26px" Width="282px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="label2" runat="server" Text="Password:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpass" Type="password" runat="server" Font-Size="20px" Height="26px" Width="282px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" Height="35px" Width="169px" BorderStyle="Groove" />
                </td>
            </tr>
        </table>

        <br />
        <br />

    </div>

</asp:Content>
