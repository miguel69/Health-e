<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageBody" runat="server">
    <h1>Welcome to Health-e</h1>
    <h2>Please tell us who you are:</h2>
    <div style="margin-top:100px;">
        <div style="width: 400 px; float: left; text-align:center;">
            <asp:HyperLink  Width="400px" ID="patientImage_hp" ImageUrl="~/images/patient.png" NavigateUrl="~/Patient.aspx" Target="_self" runat="server" />
            <br />
            <asp:HyperLink ID="patient_hp" NavigateUrl="~/Patient.aspx" Text="I'm a Patient" Target="_self" runat="server" />
        </div>
        <div style="width: 400 px; float:left; text-align:center;">
            <asp:HyperLink Width="400px" ID="doctorImage_hp" ImageUrl="~/images/doctor.png" NavigateUrl="~/Doctor.aspx" Target="_self" runat="server" />
            <br />
            <asp:HyperLink ID="doctor_hp" NavigateUrl="~/Doctor.aspx" Text="I'm a Doctor" Target="_self" runat="server" />
        </div>
    </div>
</asp:Content>
