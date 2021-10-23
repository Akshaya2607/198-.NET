<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAssignment.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 370px;
        }
        .auto-style3 {
            width: 370px;
            height: 182px;
        }
        .auto-style4 {
            height: 182px;
        }
        .auto-style5 {
            width: 370px;
            height: 77px;
        }
        .auto-style6 {
            height: 77px;
        }
        .auto-style7 {
            width: 370px;
            height: 55px;
        }
        .auto-style8 {
            height: 55px;
        }
        .auto-style9 {
            width: 370px;
            height: 66px;
        }
        .auto-style10 {
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Enter Item</td>
                <td>
                    <asp:TextBox ID="txtitem" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit to list" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Listed Items:</td>
                <td class="auto-style8">Ur chosen items:</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="159px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="200px"></asp:ListBox>
                </td>
                <td class="auto-style4">
                    <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="159px" Width="200px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="OK" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
