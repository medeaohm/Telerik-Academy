<%@ Page Title="Playlist Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaylistDetails.aspx.cs" Inherits="YouTubePlaylists.Web.PlaylistDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <asp:FormView runat="server" ID="FormViewPlylistDetails" ItemType="YouTubePlaylists.Data.Models.Playlist" SelectMethod="FormViewPlylistDetails_GetItem">
        <ItemTemplate>
            <header>
                <h1><%: Title %></h1>
                <p>Title: <%#: Item.Title %></p>
                <p>Category: <%#: Item.Category.Name %></p>
                <p>Description: <%#: Item.Description %></p>
                <p><i>Author: <%#: Item.Author.FirstName + Item.Author.LastName %></i></p>
                <p><i>Created on: <%#: Item.DateCreated %></i></p>
                <p><i>Total Rating: <%#: Item.Ratings.Sum(r => r.Value) %></i></p>  
                <br />
                <p>Videos: </p>
                <asp:ListView runat="server" ID="test" ItemType="YouTubePlaylists.Data.Models.Video" DataKeyNames="Id" SelectMethod="test_GetData">
                    <ItemTemplate>
                        <p><a href="<%#: Item.Url %>"</a><%#: Item.Url %></p>  
                    </ItemTemplate>
                </asp:ListView>
               
            </header>
        </ItemTemplate>

    </asp:FormView>

    <div class="back-link">
        <a href="/">Back to Playlists</a>
    </div>
</asp:Content>