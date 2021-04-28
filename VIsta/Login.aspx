<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="VIsta.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="frmlogin" runat="server" style="margin:auto; text-align:center; width: 30%; max-width: 520px; padding: 30px;" >
        <table style="text-align:center">
           <tr><td class="auto-style1"><h2 style="text-align:center;">LOGIN</h2></td></tr>
            <tr>
                    <td>Usuario <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
                </tr>
            <tr>
                    <td>Clave <asp:TextBox ID="txtContraseña" TextMode="Password" runat="server"></asp:TextBox></td>
                </tr>             
            <tr>
                <td colspan="1"><asp:Button ID="btnLOGIN" runat="server" Text="LOGIN" OnClick="btnLOGIN_Click" /></td>
            </tr>
            <tr>
                <td colspan="1"><asp:Button ID="btncancelar" runat="server" Text="CANCELAR" OnClick="btncancelar_Click" /></td>
           </tr>
            <tr>
                <td>
                    <asp:Label ID="msjIniciar" runat="server" ForeColor="Red"></asp:Label></td>
                
                    <td><asp:Label ID="msjMensaje" runat="server"  ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
