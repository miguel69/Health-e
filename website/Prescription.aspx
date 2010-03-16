<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Prescription.aspx.cs" Inherits="prescription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
 <table border="1" width="50%" style="font-family: Calibri, Sans-Serif;">
 <tr>
 <td style="background-color: Blue; color: White; font-weight: bold;">Attributes</td><td style="background-color: Blue; color: White; font-weight: bold;">Values</td>
 </tr>
 <tr>
 <td> Name: </td> 
 <td><asp:Label ID="Username" runat="server"> </asp:Label> </td>
 </tr>
 <tr>
 <td>Height:</td> <td> <asp:Label ID="HeightBox" runat="server"> </asp:Label> </td>
 </tr>
 <tr>
 <td>Weight:</td> <td> <asp:Label ID="WeightBox" runat="server"> </asp:Label> </td>
 </tr>
 <tr>
 <td>Year:</td> <td> <asp:Label ID="Age" runat="server"> </asp:Label> </td>
 </tr>
 </table>
 <asp:Button ID="update" runat="server"  onclick="update_Click"  />
 
</asp:Content>
