<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PatientMaster.master" CodeFile="HeightHistory.aspx.cs" Inherits="HeightHistory"%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
            <asp:Table ID="c_tableHeight" runat="server" BorderWidth="1px" CellPadding="2" CellSpacing="2" GridLines="Both"/>
            <br />
            <table border="0" cellpadding="4">
                <tr>    
                    <td><asp:Label ID="label1" runat="server" Text="Height:"/></td>
                    <td><asp:TextBox ID="c_textboxHeight" runat="server"></asp:TextBox></td>
                </tr>    
                <tr>    
                    <td colspan="2" align="right"><asp:Button ID="c_buttonSave" runat="server" Text="Save" OnClick="c_buttonSave_Click" Height="24px" Width="81px" /></td>
                </tr>
            </table>
</asp:Content>