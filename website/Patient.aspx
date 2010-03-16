<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Patient.aspx.cs" Inherits="_Default" %>

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
            <asp:Label ID="Picture_lbl" runat="server" Text="Profile Picture: "/>
            <asp:Image ID="Profile_img" runat="server" />
            <br />
            <asp:Label ID="FullName_lbl" runat="server" Text="Full name: " />
            <br />
            <asp:Label ID="BY_lbl" runat=server Text="Birth Year: " />
            
            <br />
            <asp:Label ID="Gender_lbl" runat="server" Text="Gender: " />
            
            <br />
            <asp:Label ID="Height_lbl" runat="server" Text="Height: "></asp:Label>
            <br />
            <asp:Label ID="Weight_lbl" runat="server" Text="Weight: "></asp:Label>
</asp:Content>