<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tokasivu.aspx.cs" Inherits="teht1.tokasivu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Valuutta Muunnin</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Tervetuloa</h1>
    <asp:TextBox ID="parametri" runat="server"  Enabled="false"/></br>
    <asp:TextBox ID="laskuri" runat="server" /><p id="tulos" runat="server"> tähän tulostetaan tulos muunnoksesta</p></br>
    <asp:Button ID="muutaEuroiksi" runat="server" onClick="muutaEuroiksi_Click" Text="markat euroiksi"/></br>
    <div>Laskutoimituksia : </div><p id="tulokset" runat="server"></p>
    </div>
    </form>
</body>
</html>
