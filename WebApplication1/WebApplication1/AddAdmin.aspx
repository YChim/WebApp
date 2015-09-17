<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="AddAdmin.aspx.vb" Inherits="WebApplication1.AddAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="body" style="width:50%; " >

        <h1><u><b>Add new Administrator</b></u></h1>


        <br />
        <br />

        <table style="font-size:26px; margin:auto; ">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtfirst" runat="server" Height="25px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="Surname: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtlast" runat="server" Height="25px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="Email address: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Height="25px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Username: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server" Height="25px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtpassword" runat="server" Type="password"  Height="25px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="Confirm password: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtcon" runat="server" Type="password"  Height="25px" Width="197px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" Height="37px" Width="219px" BorderStyle="Groove"/>
                </td>
            </tr>
        </table>

        <br />
        <br />

    </div>

</asp:Content>
