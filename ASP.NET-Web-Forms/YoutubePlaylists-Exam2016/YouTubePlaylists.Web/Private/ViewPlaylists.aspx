<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPlaylists.aspx.cs" Inherits="YouTubePlaylists.Web.Private.ViewPlaylists" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%--    <asp:ListView runat="server" ID="lvPlaylists"
        ItemType="YouTubePlaylists.Data.Models.Playlist"
        DataKeyNames="Id"
        SelectMethod="lvPlaylists_GetData"
        InsertItemPosition="None">
        <LayoutTemplate>
            <asp:HyperLink NavigateUrl="?orderBy=Title" Text="Sort by Title" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=DateCreated" Text="Sort by Date" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Category.Name" Text="Sort by Category" runat="server" CssClass="btn btn-md-2 btn-default" />
            <asp:HyperLink NavigateUrl="?orderBy=Ratings.Sum(r => r.Value)" Text="Sort by Ratings" runat="server" CssClass="btn btn-md-2 btn-default" />
            <div runat="server" id="itemPlaceholder"></div>
            <asp:DataPager runat="server" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
            <h2>
                <%#: Item.Title %>
            </h2>
            <p>Category: <%#: Item.Category.Name %></p>
            <p><%# Item.Ratings.Sum(r=>r.Value) %></p>
            <i>by <%#: Item.Author.UserName %> on: <%# Item.DateCreated %></i>
        </ItemTemplate>
    </asp:ListView>--%>
    <asp:GridView runat="server" ID="gvPlaylist"
        ItemType="YouTubePlaylists.Data.Models.Playlist"
        DataKeyNames="Id"
        SelectMethod="gvPlaylist_GetData"
        AutoGenerateColumns="false"
        AllowPaging="true"
        PageSize="10"
        AllowSorting="true">
        <Columns>
            <asp:BoundField SortExpression="Title" DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Category.Name" HeaderText="Category"/>
            <asp:BoundField SortExpression="Author.UserName" DataField="Author.UserName" HeaderText="Author" />
            <asp:BoundField SortExpression="DateCreated" DataField="DateCreated" HeaderText="Date" />
           <%-- <asp:BoundField SortExpression="Ratings.Sum(r=>r.Value)" DataField="Ratings.Sum(r=>r.Value)" HeaderText="Rating" />--%>

        </Columns>
    </asp:GridView>
</asp:Content>
