using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBManager_MSSQL;
using static MyString.StringBase;


namespace MyWebSite
{
    public partial class article : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            A_DATE.Value = DateTime.Now.ToString();
            MSSQLDB mydb = new MSSQLDB(@"DESKTOP-UQ6D8UK\SQLEXPRESS", "PW", "admintest", "adminTest");
            if (mydb.Status)
            {
                mydb.ReadData("SELECT TOP 1 A_ID FROM PW_ARTICLE_TBL ORDER BY A_ID DESC;");
                string tempStr = GetRepeatNumberStr((Convert.ToInt32(mydb.DTTable.Rows[0]["A_ID"])+1),0,8);
                A_ID.Value = tempStr;
            }
            else
            {

            }
        }
        protected void A_Submit_Click(object sender, EventArgs e)
        {
            string[] articleStr = new string[5] { A_NAME.Value.ToString(), A_DATE.Value.ToString(), A_ID.Value.ToString(), A_DESCRIPTION.Value.ToString(), A_CONTENT.Value.ToString() };
            WebSiteBackStage thisPageBackStage = new WebSiteBackStage();
            if(thisPageBackStage.CreateArticleHtml(articleStr))
            {
                thisPageBackStage.Show(this, "文章页面创建成功");
            }
            else
            {
                thisPageBackStage.Show(this, "文章页面创建失败");
            }
        }
    }
}