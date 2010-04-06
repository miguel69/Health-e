<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PatientMaster.master" CodeFile="Patient.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
            <asp:Label ID="Picture_lbl" runat="server" Text="Profile Picture: "/>
            <br />
            <asp:Image ID="Profile_img" runat="server" Width="100" ImageUrl="~/FetchProfilePicture.aspx" />
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