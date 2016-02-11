<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_2._1_SumNumbers_WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">This ASP.NET Web Forms application sums 2 numbers.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <label>First Number: </label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <label>Second Number: </label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="SumButton" runat="server" Text="Sum" OnClick="SumButton_Click" />
            <asp:TextBox ID="Result" runat="server"></asp:TextBox>
        </div>
    </div>

</asp:Content>
