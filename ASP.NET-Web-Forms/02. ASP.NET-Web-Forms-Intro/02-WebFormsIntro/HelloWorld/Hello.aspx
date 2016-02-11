<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Hello.aspx.cs"
    Inherits="Hello.Hello" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>ASP.NET Web Forms</title>
</head>

<body>
    <form id="formHello" runat="server">
        <h1>Hello</h1>
        Please enter your name:
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonPrintName" runat="server"
            OnClick="ButtonPrintName_Click" Text="Go!" />
        <br />
        <br />
        <asp:Label ID="TextBoxHello" runat="server" Text=""></asp:Label>
    </form>
</body>

</html>
