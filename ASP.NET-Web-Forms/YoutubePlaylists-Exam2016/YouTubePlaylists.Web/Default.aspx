<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YouTubePlaylists.Web._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Youtube Playlists</h1>
    <h2>Most Popular Playlists</h2>
    <asp:Repeater runat="server" ID="repeaterPlaylists"
        ItemType="YouTubePlaylists.Data.Models.Playlist"
        SelectMethod="repeaterPlaylists_GetData">
        <ItemTemplate>
            <h3>
                <a href="PlaylistDetails.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a>
                <small><a href="CategoryDetails.aspx?id=<%# Item.Category.Id %>"><%#: Item.Category.Name %></a></small>
            </h3>
            <p>
                Author: <%#: Item.Author.UserName %>
            </p>
            <p>
                Ratings: <%# Item.Ratings.Sum(r=>r.Value) %>
            </p>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
