<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txta" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtb" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="135px" />
    
    </div>
    </form>
</body>
</html>
