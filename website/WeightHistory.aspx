<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="WeightHistory.aspx.cs" Inherits="WeightHistory"%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
            <b>Welcome, <asp:Label ID="PersonName_lbl" runat="server"/></b>  <br /><br />
            <br />
            <br />
            <asp:HyperLink ID="Profile_hp" runat="server" NavigateUrl="~/Patient.aspx">Profile</asp:HyperLink>
            &nbsp;|
            <asp:HyperLink ID="HeightHistory_hp" runat="server" NavigateUrl="~/HeightHistory.aspx">Height History</asp:HyperLink>
            &nbsp;|
            <asp:HyperLink ID="WeightHistory_hp" runat="server" NavigateUrl="~/WeightHistory.aspx">Weight History</asp:HyperLink>
            <br />
            <hr />
            <asp:Table ID="c_tableWeight" runat="server" BorderWidth="1px" CellPadding="2" CellSpacing="2" GridLines="Both"/>
            <br />
            <table border="0" cellpadding="4">
                <tr>    
                    <td><asp:Label ID="label1" runat="server" Text="Weight:"/></td>
                    <td><asp:TextBox ID="c_textboxWeight" runat="server"></asp:TextBox></td>
                </tr>    
                <tr>    
                    <td colspan="2" align="right"><asp:Button ID="c_buttonSave" runat="server" Text="Save" OnClick="c_buttonSave_Click" Height="24px" Width="81px" /></td>
                </tr>
            </table>
</asp:Content>