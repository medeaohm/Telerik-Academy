<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLifecycle.aspx.cs" Inherits="LivecycleEvents.PageLifecycle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LiveCycle</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="ButtonOK" runat="server" Text="Submit"
            OnInit="ButtonOK_Init" OnLoad="ButtonOK_Load" OnClick="ButtonOK_Click"
            OnPreRender="ButtonOK_PreRender" OnUnload="ButtonOK_Unload" />
    </div>
    </form>
</body>
</html>
