<%@ Page Language="C#" MasterPageFile="~/MyApp.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterPagesDemo.Login" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <%--<form id="form1" runat="server">--%>
        <div>

            Session ID:&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            IsNewSession:
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            IsCookieLess:
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            You are the
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
&nbsp;user of the application<br />
            <br />

            <asp:Label runat="server" Text="Label">Enter username</asp:Label>
            <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Label">Enter Password</asp:Label>
            <asp:TextBox ID="txtpwd" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            
        </div>
   <%-- </form>--%>
</asp:Content>


