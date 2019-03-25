<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createArticle.aspx.cs" Inherits="MyWebSite.article" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新建文章</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/createArticle.css" rel="stylesheet" />
</head>
<body class="container">
    <form id="form1" runat="server">
    <div class="head"></div>
    <label for="A_ID" class="col-md-3 col-xs-12">文章ID:</label><input class="col-md-3 col-xs-12" id="A_ID" runat ="server" readonly="true" />
    <label for="A_DATE" class="col-md-3 col-xs-12">生成日期:</label><input class="col-md-3 col-xs-12"  id="A_DATE" runat ="server" readonly="true" />
    <label for="A_NAME" class="col-md-3 col-xs-12">文章名:</label><input class="col-md-3 col-xs-12"  id="A_NAME" runat ="server" />
    <label for="A_DESCRIPTION" class="col-md-12 col-xs-12">描述:</label><textarea class="col-md-12 col-xs-12" id="A_DESCRIPTION" runat="server" rows="3"></textarea>
    <label for="A_CONTENT" class="col-md-12 col-xs-12">内容:</label><textarea class="col-md-12 col-xs-12" id="A_CONTENT" runat ="server" rows="30"></textarea>
    <asp:Button class="col-md-12 col-xs-12" ID="A_Submit" runat="server" Text="提交" OnClick="A_Submit_Click" />
    </form>
</body>
</html>
