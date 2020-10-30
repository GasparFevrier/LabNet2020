<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="001.aspx.cs" Inherits="ExceptionHandling._001_SimpleException" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SimpleExeption" Width="220px" />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="71px" Width="215px"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="214px"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
