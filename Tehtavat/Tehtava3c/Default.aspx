<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Jotain tyyppejä</h1>
        <p><asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></p>
        <asp:GridView ID="gvAttendees" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
