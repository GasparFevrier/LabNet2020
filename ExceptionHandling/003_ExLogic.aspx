<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="003_ExLogic.aspx.cs" Inherits="ExceptionHandling._003_ExLogic" %>

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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generar Exepcion" Width="243px" />
            <br />
            <br />
            Exepcion:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="105px" TextMode="MultiLine" Width="606px"></asp:TextBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
