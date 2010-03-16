<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <div>
        <asp:HyperLink ID="doctor_hp" NavigateUrl="~/Doctor.aspx" Text="I'm a Doctor" Target="_self" runat="server" />
        <asp:HyperLink ID="patient_hp" NavigateUrl="~/Patient.aspx" Text="I'm a Patient" Target="_self" runat="server" />
    </div>
</asp:Content>
