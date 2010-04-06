<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PatientMaster.master" CodeFile="WeightHistory.aspx.cs" Inherits="WeightHistory"%>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
            
            <table border="2px" width="100%">
                <tr>
                    <td align="center">
            <asp:Table ID="c_tableWeight" runat="server" BorderWidth="1px" CellPadding="2" CellSpacing="2" GridLines="Both"/>
                    </td>
                    <td align="center">
                        Weight Chart:
                        <br />
                        <asp:Image ID="weightChart_img" runat="server" ImageUrl="~/GenerateChart.aspx" /></td>
                </tr>
            </table>
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
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style1
        {
            width: 138px;
        }
    </style>

</asp:Content>
