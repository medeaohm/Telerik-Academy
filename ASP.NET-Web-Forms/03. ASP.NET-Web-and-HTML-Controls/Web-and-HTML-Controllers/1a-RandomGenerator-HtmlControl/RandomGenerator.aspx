<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomGenerator.aspx.cs" Inherits="RandomGenerator.RandomGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Random Genertor</title>
</head>
<body>
    <form id="random_generator" runat="server">
        <div>
            <label for="min">Min</label>
            <input type="number" runat="server" id="min" />
            <br />

            <label for="min">Max</label>
            <input type="number" runat="server" id="max" />
            <br />

            <input type="button" id="Btn_Gen_Random" runat="server" onserverclick="Btn_Gen_Random_Click" value="Generate Random Number" />
            <div>
                <p id="random" runat="server"></p>
            </div>
        </div>
    </form>
</body>
</html>

      