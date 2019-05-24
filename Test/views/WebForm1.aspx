<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Test.views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
    <title></title>
    <script src="../static/bootstrap-3.3.7-dist/js/bootstrap.min.js"></script>
    <script src="../static/jquery/jquery-3.1.1.min.js"></script>
    <link href="../static/bootstrap-3.3.7-dist/css/bootstrap.css" rel="stylesheet" />
    <style>
        hr {
            border: 1px solid #666;
        }
        body {
            margin: 20px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col1 col-sm-1"><input class="form-control btn btn-danger" type="button" value="确定" /></div>
            <div class="col2 col-sm-2"><input class="form-control btn btn-danger" type="button" value="确定" runat="server" /></div>
            <div class="col3 col-sm-3"><asp:Button ID="Button" class="form-control btn btn-danger" runat="server" Text="确定"/></div>
        </div>    
        <%--<div>
            <input class="form-control btn btn-danger" type="button" value="确定" />
            <input class="form-control btn btn-danger" type="button" value="确定" runat="server" />
            <asp:Button ID="Button1" class="form-control btn btn-danger" runat="server" Text="确定"/>
        </div> --%>   
        <%
            for(int i = 0; i < 10; i++){%>
                <div><%=i %></div>

            <%} %>
        <asp:Login ID="Login1" runat="server" Height="147px" Width="254px">
        </asp:Login>
    </form>

</body>
</html>
