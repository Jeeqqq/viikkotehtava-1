<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="eläkeLaskuri.aspx.cs" Inherits="Eläke.eläkeLaskuri" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Eläke Laskuri</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Tänään on paras päivä aloittaa eläkesäästäminen</h2>
    <div class="round">
        <h3 class="underline">Tiedätkö kuinka paljon saat aikanaan eläkettä? laske tästä!</h3>
        <table>
            <tr>
                <td>Ikä</td>
                <td>Lakisääteinen eläke :</td>
                <td id="tulos" runat="server"></td>
            </tr>
            <tr>
                <td><asp:Button ID="miinusIka" runat="server" Text="-" onClick="miinusIka_Click" /><asp:TextBox ID="ika" runat="server" ViewStateMode="Enabled" ReadOnly="true" /><asp:Button ID="plusIka" runat="server" Text="+" OnClick="plusIka_Click" /> vuotta</td>
                <td>Elinaikakertoimen vaikutus :</td>
                <td id="ekVaikutus" runat="server"></td>
            </tr>
            <tr>
                <td>Palkka</td>
                <td>Arvio lakisääteisesta eläkkeestä :</td>
                <td></td>
            </tr>
            <tr>
                <td><asp:Button ID="miinusPalkka" runat="server" Text="-" OnClick="miinusPalkka_Click"/><asp:TextBox ID="palkka" ViewStateMode="Enabled" runat="server" ReadOnly="true" /><asp:Button ID="plusPalkka" runat="server" Text="+" OnClick="plusPalkka_Click"/> vuotta</td>
                <td colspan="2"> <asp:TextBox ID="eläke" runat="server" ReadOnly="true" /> €</td>

            </tr>
        </table>
    </div>
    </form>
</body>
</html>
