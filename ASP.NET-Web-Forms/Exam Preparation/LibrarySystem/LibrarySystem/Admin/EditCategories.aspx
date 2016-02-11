<%@ Page Title="Edit Categories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCategories.aspx.cs" Inherits="LibrarySystem.Admin.EditCategories" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%#: Title %></h1>

    <asp:ListView runat="server" ID="ListViewCategories" ItemType="LibrarySystem.Models.Category" SelectMethod="ListViewCategories_GetData" DeleteMethod="ListViewCategories_DeleteItem" UpdateMethod="ListViewCategories_UpdateItem" DataKeyNames="ID" InsertMethod="ListViewCategories_InsertItem" InsertItemPosition="LastItem">
        <LayoutTemplate>
            <table class="gridView">
                <thead>
                </thead>
                <tbody>
                    <tr>
                        <th scope="col">
                            <asp:LinkButton Text="Category Name" runat="server" ID="LinkButtonSortByCategoriy" CommandName="Sort" CommandArgument="Name">
                            </asp:LinkButton>
                        </th>
                        <th scope="col">Action</th>
                    </tr>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    <tr>
                        <td colspan="2">
                            <asp:DataPager runat="server" ID="DataPagerCategories" PagedControlID="ListViewCategories" PageSize="5">
                                <Fields>
                                    <asp:NumericPagerField />
                                </Fields>
                            </asp:DataPager>
                            <asp:LinkButton CssClass="btn btn-primary pull-right" runat="server" ID="LinkButtonInsert" OnClick="LinkButtonInsert_Click" Text="Insert"></asp:LinkButton>
                        </td>
                    </tr>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#: Item.Name %></td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonEdit" Text="Edit" CommandName="Edit"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="LinkButtonDelete" Text="Delete" CommandName="Delete"></asp:LinkButton>
                </td>
            </tr>
        </ItemTemplate>
        <EditItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonSave" Text="Save" CommandName="Update"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="LinkButtonCancel" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                </td>
            </tr>
        </EditItemTemplate>
        <InsertItemTemplate>
            <tr>
                <td>
                    <asp:TextBox runat="server" ID="TextBoxName" Text="<%#: BindItem.Name %>" />
                </td>
                <td>
                    <asp:LinkButton runat="server" ID="LinkButtonInsert" Text="Insert" CommandName="Insert"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="LinkButtonCancel" Text="Cancel" CommandName="Cancel"></asp:LinkButton>
                </td>
            </tr>
        </InsertItemTemplate>
    </asp:ListView>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>

</asp:Content>
