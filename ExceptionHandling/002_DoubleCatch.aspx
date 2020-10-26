<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="002_DoubleCatch.aspx.cs" Inherits="ExceptionHandling._002_DoubleCatch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 290px;
        }
        .auto-style4 {
            width: 159px;
        }
        .auto-style5 {
            width: 426px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style5">
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <br />
                        Ingrese Dividendo<br />
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox_Dividendo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        Ingrese Divisor<br />
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox_Divisor" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        <asp:Button ID="Button_Dividir" runat="server" OnClick="Button_Dividir_Click" Text="Dividir" Width="135px" />
                        <br />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        Resultado<br />
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox_Resultado" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                        Exepcion<br />
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox_Exep" runat="server" OnTextChanged="TextBox_Exep_TextChanged"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
