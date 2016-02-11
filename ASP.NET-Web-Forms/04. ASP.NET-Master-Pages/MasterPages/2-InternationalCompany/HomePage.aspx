<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" 
    Inherits="InternationalCompany.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <h2>Welcome to our company</h2>
    <p>Please choose your language</p>
    <asp:HyperLink runat="server" NavigateUrl="~/UK/UKHome.aspx"
         Text="" CssClass="uk-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Bulgaria/BGHome.aspx"
         Text="" CssClass="bg-icon"/>
</asp:Content>
