<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="Index.aspx.vb" Inherits="WebApplication1.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />

      <script type="text/javascript">

          $('#slider').cycle({

                fx: 'scrollHorz',
                next: '.cycle-next',
                prev: '.cycle-prev',
                pager: '#pager',
                timeout: 2000,
                speed: 1200,
                pause: 1

            });
    </script>

    <div id="mainpage" runat ="server"> </div>
    
    <br />
    <br />


</asp:Content>
