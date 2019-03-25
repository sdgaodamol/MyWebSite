using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBManager_MSSQL;

namespace MyWebSite
{
    public partial class main : System.Web.UI.Page
    {      
        protected void Page_Load(object sender, EventArgs e)
        {
            
            MSSQLDB mydb = new MSSQLDB(@"DESKTOP-UQ6D8UK\SQLEXPRESS", "PW", "admintest", "adminTest");
            if (mydb.Status)
            {
                mydb.ReadData("SELECT TOP 2 A_ID, A_DATE, A_NAME, A_DESCRIPTION, A_ANCHORLINK FROM PW_ARTICLE_TBL ORDER BY A_ID DESC");
                switch(mydb.DTTable.Rows.Count)
                {
                    case 2:
                        des1.InnerHtml = mydb.DTTable.Rows[0]["A_DESCRIPTION"].ToString() + "<span class =\"desID\">文章ID: " + mydb.DTTable.Rows[0]["A_ID"].ToString() + "</span>";
                        des2.InnerHtml = mydb.DTTable.Rows[1]["A_DESCRIPTION"].ToString() + "<span  class =\"desID\">文章ID: " + mydb.DTTable.Rows[1]["A_ID"].ToString() + "</span>";
                        des1AnchorLink.HRef = mydb.DTTable.Rows[0]["A_ANCHORLINK"].ToString();
                        des2AnchorLink.HRef = mydb.DTTable.Rows[1]["A_ANCHORLINK"].ToString();
                        break;
                    case 1:
                        des1.InnerHtml = mydb.DTTable.Rows[0]["A_DESCRIPTION"].ToString() + "<span  class =\"desID\">文章ID: " + mydb.DTTable.Rows[0]["A_ID"].ToString() + "</span>";
                        des1AnchorLink.HRef = mydb.DTTable.Rows[0]["A_ANCHORLINK"].ToString();
                        des2.InnerHtml = "暂时只有一篇文章";
                        break;
                    default:
                        des1.InnerHtml = "暂时没有文章";
                        des2.InnerHtml = "暂时没有文章";
                        break;
                }
                mydb.ReadData("SELECT A_ABOUT FROM PW_ABOUT_TBL ORDER BY Count DESC");
                if(mydb.DTTable.Rows.Count>0)
                {
                    for(int i = 0; i < mydb.DTTable.Rows.Count;i++)
                    {
                        if (i == 0)
                        {
                            about.InnerHtml += "<span class=\"badge\">" + mydb.DTTable.Rows[i]["A_ABOUT"].ToString() + "</span>\r\n";
                        }
                        else
                        {
                            about.InnerHtml += "        " + "<span class=\"badge\">" + mydb.DTTable.Rows[i]["A_ABOUT"].ToString() + "</span>\r\n";
                        }
                    }
                }
                else
                {
                    about.InnerText = "暂时没有相关标签";
                }
            }
            else
            {
                des1.InnerHtml = "数据库连接失败，无法读取";
                des2.InnerHtml = "数据库连接失败，无法读取";
            }
            
        }
    }
}