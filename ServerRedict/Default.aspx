<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ServerRedict.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnExcute" runat="server" Text="Excute方法" OnClick="btnExcute_Click" />
            <asp:Button ID="btnTransfer" runat="server" Text="Transfer方法" OnClick="btnTransfer_Click" />
        </div>
    </form>
</body>
</html>
