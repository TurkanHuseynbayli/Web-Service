<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="MyServices.upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 35%;
            height: 182px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 25px;
            width: 235px;
        }
        .auto-style4 {
            width: 235px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Study"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Retrieve image from web service using"></asp:Label>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">enter you image filename<br />
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="235px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="49px" Text="Show Image" Width="148px" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Image ID="Image1" runat="server" Height="302px" Width="441px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnupload" runat="server" OnClick="btnupload_Click" Text="Upload" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
