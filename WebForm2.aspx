<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ControlsDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 49px;
        }
        .auto-style5 {
            height: 184px;
        }
        .auto-style6 {
            height: 49px;
            width: 160px;
        }
        .auto-style7 {
            height: 184px;
            width: 160px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1" >
        <tr>
            <td class="auto-style6" style="background-color: #00FF00">
                <asp:Label ID="Label2" runat="server" Text="Choose"></asp:Label>
            </td>
            <td class="auto-style4" style="background-color:aqua">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>--Select view--</asp:ListItem>
                    <asp:ListItem>Personal</asp:ListItem>
                    <asp:ListItem>Educational</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style7" style="background-color: #00FF00"></td>
            <td class="auto-style5" style="background-color:aqua">
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="PersonalView" runat="server">
                        &nbsp;Personal Details&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                        <br />
                    </asp:View>
                    <asp:View ID="Education" runat="server">&nbsp;Educational details<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/trees1.jpg" OnClick="ImageButton1_Click" Width="40px" />
                        <br />
                    </asp:View>
                    <asp:View ID="Other" runat="server">Other Details<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server" Height="96px" TextMode="MultiLine" Width="306px"></asp:TextBox>
                    </asp:View>
                </asp:MultiView>
            </td>
        </tr>
    </table>
        <div>
        </div>
    </form>
</body>
</html>
