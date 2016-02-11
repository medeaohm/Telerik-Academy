<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escape.aspx.cs" Inherits="EscapingHTML.Escape" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="InputText" runat="server" Width="440px">&lt;h1&gt;Hello&lt;/h1&gt;Text&lt;script&gt;alert(&quot;bug!&quot;)&lt;/script&gt;</asp:TextBox>
        <br/>
        <br/>
        <asp:Button ID="BtnShowText" runat="server" OnClick="BtnShowText_Click" Text="GO" />
        <br/>
        <br/>
        <asp:TextBox ID="OutputText" runat="server" Width="440px"></asp:TextBox>
        <br/>
        <asp:Label ID="LabelOutputText" runat="server" Width="440px" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
