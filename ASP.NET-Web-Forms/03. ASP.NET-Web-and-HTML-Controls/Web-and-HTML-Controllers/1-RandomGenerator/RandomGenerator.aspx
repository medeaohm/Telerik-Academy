<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomGenerator.aspx.cs" Inherits="RandomGenerator.RandomGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Genertor</title>
</head>
<body>
    <form id="random_generator" runat="server">
    <div>
        Min:
        <asp:TextBox ID="min" runat="server"></asp:TextBox>
        <br />
        Max:
        <asp:TextBox ID="max" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Btn_Gen_Random" runat="server" onClick="Btn_Gen_Random_Click" Text="Generate Random Number" />
        <asp:Label ID="random" runat="server" Text="Random Number: "></asp:Label>
    </div>
    </form>
</body>
</html>
