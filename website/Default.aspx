<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to Health-e</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="doctor_hp" NavigateUrl="~/Doctor.aspx" Text="I'm a Doctor" Target="_self" runat="server" />
        <asp:HyperLink ID="patient_hp" NavigateUrl="~/Patient.aspx" Text="I'm a Patient" Target="_self" runat="server" />
    </div>
    </form>
</body>
</html>
