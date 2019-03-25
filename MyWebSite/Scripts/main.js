window.onload = function () {
    LinkToCommonSite(); //#1
    LinkToBaiduQuery(); //#2
};

//#1兴趣标签：根据标签字符跳转常用网站
function LinkToCommonSite() {
    labels = document.getElementsByClassName("label-info");
    var detailURL;
    try {
        for (var i = 0; i < labels.length; i++) {
            (function () {
                var clickLabel = labels[i];
                clickLabel.onclick = function (e) {
                    switch (clickLabel.innerText.trim()) {
                        case "游戏":
                            detailURL = "https://store.steampowered.com";
                            break;
                        case "漫画":
                            detailURL = "https://manhua.dmzj.com/tags/category_search/0-0-0-all-0-0-0-1.shtml";
                            break;
                        case "小说":
                            detailURL = "https://www.biquge5.com";
                            break;
                        case "电影":
                            detailURL = "https://www.xunleigang.net";
                            break;
                        case "韩娱":
                            detailURL = "https://www.hanfan.cc";
                            break;
                        default:
                            break;
                    }
                    window.open(detailURL);
                }
            })();
        }
    } catch (error) {
        alert("兴趣标签跳转无效");
    }
}
//#2喜欢的明星标签：根据标签字符跳转对应百度百科
function LinkToBaiduQuery() {
    labels = document.getElementsByClassName("label-default");
    try {
        for (var i = 0; i < labels.length; i++) {
            (function () {
                var clickLabel = labels[i];
                clickLabel.onclick = function (e) {
                    detailURL = "https://baike.baidu.com/item/" + clickLabel.innerText;
                    window.open(detailURL);
                }
            })();
        }
    } catch (error) {
        alert("喜欢的明星标签跳转无效");
    }
}

