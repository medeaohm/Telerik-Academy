<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_02.Web_Forms_App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Web Forms App </h2>
        <asp:Label ID="HelloFromCSharp" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="HelloFromAspx" runat="server" Text="Hello, ASP.NET (from the aspx code)"></asp:Label>
    </div>

    <div class="row">
        <p>
            <strong>"Code behind" </strong>stands for the server-side C# code behind pages
        </p>
    </div>

    <div class="row">
        <strong>Current assembly location:</strong>
        <br />
        <asp:Label ID="LabelAssembly" runat="server" Text=""></asp:Label>
        <br />
    </div>
    <br />
    <div class="row">
        <p>
            <strong>App_Data </strong>directory holds the local data files of the Web application
        </p>
        <p>
            <strong>BundleConfig.cs </strong>Combines and optimizes CSS and JS files
        </p>
        <p>
            <strong>FilterConfig.cs </strong>Configures filters in MVC / Web API apps. 
            Configures pre-action and post-action behavior to the controller's action methods
        </p>
        <p>
            <strong>RouteConfig.cs </strong>Configures URL patterns and their handlers. 
            Maps user-friendly URLs to certain page / controller
        </p>
        <p>
            <strong>IdentityConfig.cs / Startup.Auth.cs </strong>Configures the membership authentication. 
             Users, roles, login, logout, user management OAuth login (cross-sites login, read more) Facebook / Twitter / Microsoft / Google login
        </p>

        <p>
            <strong>Web.config </strong>is web app's configuration file. Holds settings like DB connection strings, HTTP handlers, modules, assembly bindings.
            Can hold custom application settings, e.g. credentials for external services. Changes in Web.config do not require rebuild.
        </p>
        <p>
            <strong>Web.Debug.config </strong>Local settings for debugging. E.g. local database instance for testing
        </p>
        <p>
            <strong>Web.Release.config </strong>Production settings for real world deployment
        </p>
        <p>
            <strong>Global.asax </strong>defines the HTTP application.Defines global application events like: 
            <br />
            <ul>
                <li>Application_Start</li>
                <li>Application_BeginRequest</li>
                <li>Application_EndRequest</li>
                <li>Application_Error</li>
            </ul>
        </p>
    </div>


</asp:Content>
