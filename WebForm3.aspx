<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ControlsDemo.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 145%;
        }
        .auto-style2 {
            width: 226px;
        }
        .auto-style3 {
            width: 234px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Enter Name</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtname" runat="server" CssClass="auto-style4"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Name is a required field" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter Age</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtage" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" EnableTheming="True" ErrorMessage="Age must be greater than 18 and less than 60" ForeColor="Red" MaximumValue="60" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter Email</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtemail" ErrorMessage="Email address is required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter valid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter Website</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtwebsite" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtwebsite" ErrorMessage="Enter valid website" ForeColor="Red" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Enter Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpass" ControlToValidate="txtrepass" ErrorMessage="Password must match" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Re-enter Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtrepass" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
