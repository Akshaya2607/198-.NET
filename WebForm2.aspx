<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAssignment.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 254px;
        }
        .auto-style3 {
            width: 254px;
            height: 211px;
        }
        .auto-style4 {
            height: 211px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Click here to show your cart:</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="My Cart" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:ListBox ID="ListBox2" runat="server" Height="143px" Width="203px"></asp:ListBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
