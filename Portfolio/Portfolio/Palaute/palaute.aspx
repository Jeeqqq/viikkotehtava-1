<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="palaute.aspx.cs" Inherits="Portfolio.Palaute.palaute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <h2>Palaute Kursille IIO13200</h2>

         <table style="background-color:#eeeeee; padding:10px">
         <tr valign="top">
            <td colspan="3">
               <asp:Label ID="lblOutput" 
                    Text="Täytä palaute lomake"
                    runat="server"
                    AssociatedControlID="pvmTxt"/>
               <br />
            </td>
         </tr>


         <tr>
            <td align="right">
               Pvm:
            </td>
            <td>
               <asp:TextBox id="pvmTxt" TextMode="Date"
                    runat="server"/>
            </td>
            <td>
               <asp:RequiredFieldValidator id="RequiredFieldValidator2"
                    ControlToValidate="pvmTxt"
                    Display="Static"
                    ErrorMessage="*"
                    runat="server"/> 
            </td>
         </tr>
             <tr>
            <td align="right">
               Nimi:
            </td>
            <td>
               <asp:TextBox id="nimiTxt" 
                    runat="server"/>
            </td>
            <td>
               <asp:RequiredFieldValidator id="RequiredFieldValidator1"
                    ControlToValidate="nimiTxt"
                    Display="Static"
                    ErrorMessage="*"
                    runat="server"/> 
            </td>
         </tr>
             <tr>
            <td align="right">
               Olen oppinut:
            </td>
            <td>
               <asp:TextBox id="oppinutTxt" 
                    runat="server"/>
            </td>
            <td>
               <asp:RequiredFieldValidator id="RequiredFieldValidator3"
                    ControlToValidate="oppinutTxt"
                    Display="Static"
                    ErrorMessage="*"
                    runat="server"/> 
            </td>
         </tr>
             <tr>
            <td align="right">
               Haluan Oppia:
            </td>
            <td>
               <asp:TextBox id="halutaTxt" 
                    runat="server"/>
            </td>
            <td>
               <asp:RequiredFieldValidator id="RequiredFieldValidator4"
                    ControlToValidate="halutaTxt"
                    Display="Static"
                    ErrorMessage="*"
                    runat="server"/> 
            </td>
         </tr>
                     
             <tr>
            <td align="right">
              Hyvää:
            </td>
            <td>
               <asp:TextBox id="hyvaaTxt" 
                    runat="server"/>
            </td>
            <td>
               <asp:RequiredFieldValidator id="RequiredFieldValidator5"
                    ControlToValidate="hyvaaTxt"
                    Display="Static"
                    ErrorMessage="*"
                    runat="server"/> 
            </td>
         </tr>
                      
             <tr>
            <td align="right">
              Parannettavaa:
            </td>
            <td>
               <asp:TextBox id="parannettavaaTxt" 
                    runat="server"/>
            </td>
            <td>
               <asp:RequiredFieldValidator id="RequiredFieldValidator6"
                    ControlToValidate="parannettavaaTxt"
                    Display="Static"
                    ErrorMessage="*"
                    runat="server"/> 
            </td>
         </tr>
                      
             <tr>
            <td align="right">
               Muuta:
            </td>
            <td>
               <asp:TextBox id="muutaTxt" 
                    runat="server"/>
            </td>
            <td>
            </td>
         </tr>
         <tr>
            <td></td>
            <td>
               <asp:Button id="Button1" 
                    Text="Lähetä palaute" 
                    onClick="Button1_Click"
                    runat="server"/>
            </td>
            <td></td>
         </tr>
      </table>
<asp:ListView ID="ListView1" runat="server" >
        
        <LayoutTemplate>
          <table cellpadding="2" width="640px" border="1" runat="server" style="margin:10px 10px 10px 10px;" id="tblCars">
            <tr id="Tr1" runat="server">
              <th id="Th1" runat="server">Pvm</th>
              <th id="Th2" runat="server">Tekija</th>
              <th id="Th3" runat="server">Opittu</th>
              <th id="Th4" runat="server">Haluan Oppia</th>
              <th id="Th5" runat="server">Hyvää </th>
              <th id="Th6" runat="server">Parannettavaa</th>   
              <th id="Th7" runat="server">Muuta</th>
            </tr>
            <tr runat="server" id="itemPlaceholder" />
          </table>
        </LayoutTemplate>
         <ItemTemplate>
          <tr id="Tr2" runat="server">
            <td>
               <asp:Label ID="lblMerkki" runat="Server" Text='<%#Eval("Pvm") %>' />
            </td>
            <td>
              <asp:Label ID="lblMalli" runat="Server" Text='<%#Eval("Tekija") %>' />
            </td>
            <td >
              <asp:Label ID="lblRekkari" runat="Server" Text='<%#Eval("Opittu") %>' />
            </td>
              <td >
              <asp:Label ID="lblVm" runat="Server" Text='<%#Eval("HaluanOppia") %>' />
            </td>
              <td >
              <asp:Label ID="lblMyynti" runat="Server" Text='<%#Eval("Hyvaa") %>' />
            </td>
              <td >
              <asp:Label ID="lblSOstoHinta" runat="Server" Text='<%#Eval("Parannettavaa") %>' />
            </td>
              <td >
              <asp:Label ID="Label1" runat="Server" Text='<%#Eval("Muuta") %>' />
            </td>
          </tr>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
