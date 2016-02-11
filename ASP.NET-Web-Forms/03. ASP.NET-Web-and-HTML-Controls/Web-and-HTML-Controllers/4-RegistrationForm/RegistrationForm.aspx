<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="RegistrationForm.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/jquery-1.12.0.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="formRegistration" runat="server">
        <fieldset>
            <legend>Registration form</legend>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="First Name" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:TextBox ID="TextBoxFirstName" runat="server" CssClass="form-control" Width="300px" placeholder="First name">
                    </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ErrorMessage="Please enter first name" 
                        ControlToValidate="TextBoxFirstName" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Last name" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:TextBox ID="TextBoxLastName" runat="server" CssClass="form-control" Width="300px" placeholder="Last name">
                    </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter last name" 
                        ControlToValidate="TextBoxLastName" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Faculty number" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:TextBox ID="TextBoxFacultyNumber" runat="server" CssClass="form-control" Width="300px" placeholder="88 888 888">
                    </asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter faculty number" 
                        ControlToValidate="TextBoxFacultyNumber" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="University" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList ID="DropDownListUniversities" runat="server" Width="300px" CssClass="form-control">
                        <asp:ListItem Text="Select University" Value="" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="University 1">University 1</asp:ListItem>
                        <asp:ListItem Value="University 2">University 2</asp:ListItem>
                        <asp:ListItem Value="University 3">University 3</asp:ListItem>
                        <asp:ListItem Value="University 4">University 4</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter university" 
                        ControlToValidate="DropDownListUniversities" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Specialty" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:DropDownList ID="DropDownListSpecialties" runat="server" CssClass="form-control" Width="300px">
                        <asp:ListItem Text="Select specialty" Value="" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="specialty 1">specialty 1</asp:ListItem>
                        <asp:ListItem Value="specialty 2">specialty 2</asp:ListItem>
                        <asp:ListItem Value="specialty 3">specialty 3</asp:ListItem>
                        <asp:ListItem Value="specialty 4">specialty 4</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please enter specialty" 
                        ControlToValidate="DropDownListSpecialties" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Courses" CssClass="col-md-2 control-label"></asp:Label>
                <div class="col-md-10">
                    <asp:ListBox ID="ListBoxCourses" runat="server" SelectionMode="Multiple" CssClass="form-control" Width="300px">
                        <asp:ListItem Value="course 1">course 1</asp:ListItem>
                        <asp:ListItem Value="course 2">course 2</asp:ListItem>
                        <asp:ListItem Value="course 3">course 3</asp:ListItem>
                        <asp:ListItem Value="course 4">course 4</asp:ListItem>
                    </asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please enter courses" 
                        ControlToValidate="ListBoxCourses" Font-Bold="True" ForeColor="#FF0066"></asp:RequiredFieldValidator>
                </div>
            </div>
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" CssClass="btn btn-primary"/>
            <br />
        </fieldset>
        <asp:PlaceHolder ID="PlaceHolderStudent" runat="server"></asp:PlaceHolder>
        <asp:Panel ID="PanelStudent" runat="server" BackColor="Gray"></asp:Panel>
    </form>
</body>
</html>
