<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CategoryDetails.aspx.cs" Inherits="YouTubePlaylists.Web.CategoryDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewPlylistDetails" ItemType="YouTubePlaylists.Data.Models.Category" SelectMethod="FormViewPlylistDetails_GetItem">
        <ItemTemplate>
            <header>
                <h1><%#: Item.Name %></h1>
            </header>
             <p>Playlists: </p>
                <asp:ListView runat="server" ID="test" ItemType="YouTubePlaylists.Data.Models.Playlist" DataKeyNames="Id" SelectMethod="test_GetData">
                    <ItemTemplate>
                        <a href="PlaylistDetails.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a>
                    </ItemTemplate>
                </asp:ListView>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
