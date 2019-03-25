<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="MyWebSite.main" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>吴丹骏的主页</title>
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="/Content/main.css" rel="stylesheet" />
    <script src="/Scripts/main.js" charset="utf-8"></script>
    <script src="/Scripts/Reuse.js" charset="utf-8"></script>
</head>
<body class="container">
    <section class="col-md-12 col-xs-12 welcome">
        <h1>欢迎来到我的个人主页</h1>
    </section>
    <aside class="col-md-4 col-md-push-8 col-xs-12">    
        <div class="info container">
            <img class="col-md-5 col-xs-12"src="#" alt="个人头像" />
            <div class="col-md-7 col-xs-12">
            <p>姓名：吴丹骏</p>
            <p>年龄：25</p>
            <p>现居地：上海</p>
            <p>兴趣：
                <span class="label label-info">游戏</span>
                <span class="label label-info">漫画</span>
                <span class="label label-info">小说</span>
                <span class="label label-info">电影</span>
                <span class="label label-info">韩娱</span>
            </p>
            <p>喜欢的明星：
                <span class="label label-default">安宥真</span>
                <span class="label label-default">宫脇咲良</span>
                <span class="label label-default">崔艺娜</span>
                <span class="label label-default">姜惠元</span>
                <span class="label label-default">权恩妃</span>
                <span class="label label-default">矢吹奈子</span>
                <span class="label label-default">下尾美羽</span>
            </p>
            </div>
        </div>
        <div class="about" id="about" runat="server">           
        </div>
    </aside>
    <section class="col-md-8 col-md-pull-4 col-xs-12 article">
        <a id="des1AnchorLink" href="#" target="_blank" runat="server">
            <div>
                <img src="/Images/1.jpg" />
                <p id="des1" runat="server">这是描述1</p>
            </div>
        </a>
        <a id="des2AnchorLink" href="#" target="_blank" runat="server">
            <div>
                <img src="/Images/2.jpg" />
                <p id="des2" runat="server">这是描述2</p>
            </div>
         </a>
    </section>
    <div class="clearfix"></div>
    <footer class="col-md-6 col-md-push-6  col-xs-12">实现技术及支持：ASP.NET &amp BootStrap &amp IIS &amp MSSQL2008 &nbsp&nbsp 2019/3/16最后编辑</footer>
</body>
</html>
