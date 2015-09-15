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

    <div id="hero">

        <div id="pager"></div>

        <span class="cycle-prev">&#9001</span>
        <span class="cycle-next">&#9002</span>

        <div id="slider">

            <div class="items">
                <img src="../images/1.png" />
                <div class="info">
                    <h2>Science</h2> 
                    <p>Click<a href="Science.aspx">Here</a></p>
                </div>
            </div>

            <div class="items">
                <img src="../images/2.jpg" />
                <div class="info">
                    <h2>Motoring</h2> 
                    <p>Click<a href="Motoring.aspx">Here</a></p>
                </div>
            </div>

            <div class="items">
                <img src="../images/3.jpg" />
                <div class="info">
                    <h2>Fashion</h2> 
                    <p>Click<a href="Fashion.aspx">Here</a></p>
                </div>
            </div>

            <div class="items">
                <img src="../images/4.png" />
                <div class="info">
                    <h2>Gossip</h2> 
                    <p>Click<a href="Gossip.aspx">Here</a></p>
                </div>
            </div>

            <div class="items">
                <img src="../images/5.jpg" />
                <div class="info">
                    <h2>Kids</h2> 
                    <p>Click<a href="Kids.aspx">Here</a></p>
                </div>
            </div>
        </div>
    </div>
    

</asp:Content>
