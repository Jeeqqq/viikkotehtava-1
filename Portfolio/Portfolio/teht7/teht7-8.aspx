<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="teht7-8.aspx.cs" Inherits="Portfolio.teht7.teht7_8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="autoNakyma" runat="server" 
        AllowSorting="True" 
        AllowPaging="True" 

        OnSorting="autoNakyma_Sorting" 
        OnPageIndexChanging="autoNakyma_PageIndexChanging" 
        OnRowCancelingEdit="autoNakyma_RowCancelingEdit" 
        OnRowDeleting="autoNakyma_RowDeleting" 
        OnRowEditing="autoNakyma_RowEditing" 
        OnRowUpdating="autoNakyma_RowUpdating" >
    </asp:GridView>

    <asp:Button ID="addNew" runat="server" OnClick="addNew_Click" Text="Lisää uusi" />
    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Tallenna" />

    <asp:Login ID="LoginWindow" runat="server" 
        OnAuthenticate="LoginWindow_Authenticate" 
        OnLoginError="LoginWindow_LoginError" 
        OnLoggedIn="LoginWindow_LoggedIn"
        RememberMeText="Remember me.">
    </asp:Login>
    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    <asp:Label ID="lblInfo" runat="server"></asp:Label>
</asp:Content>
