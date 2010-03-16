<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Patient.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <asp:MultiView ID="StartupData" runat="server">
        <asp:View ID="ApplicationData" runat="server">
            <b>Welcome, <asp:Label ID="PersonName_lbl" runat="server"/></b>  <br /><br />
            <b>Basic Application Data</b>  <br />
            <asp:Label ID="AppName" runat="server" Text="Application Name: " /><br />
            <asp:Label ID="AppId" runat="server" Text="Application Id: "/><br />
        </asp:View>
    </asp:MultiView>
</asp:Content>