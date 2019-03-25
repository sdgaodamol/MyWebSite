using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyIO;

namespace MyWebSite
{
    public class WebSiteBackStage
    {
        static IOBase myIO_CLS = new IOBase();
        string ArticleDirectory = "~/Article/";
        string ArticleFilePath = "~/Article/" + GetDate() + "_Article/";

        /// <summary>
        /// 按照传入的字符串数组和设置的模板创建文章html
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns>success</returns>
        public bool CreateArticleHtml(string[] inputStr)
        {
            string tempStr = "";
            bool success = false;
            myIO_CLS.ReadFile("~/App_Data/ArticleModel.html");
            tempStr = myIO_CLS.MyStr;
            tempStr.Replace("mytitle",inputStr[0]);
            tempStr.Replace("mybadge", inputStr[1]);
            tempStr.Replace("mydate", inputStr[2]);
            tempStr.Replace("myid", inputStr[3]);
            tempStr.Replace("mydescription", inputStr[4]);
            tempStr.Replace("mycontent", inputStr[5]);
            if (CreateSaveDirectory())
            {
                success = WriteFileAndSave(ArticleFilePath + inputStr[3] + ".html", tempStr);
            }
            return success;
        }
        private bool WriteFileAndSave(string filePath, string writeStr)
        {
                if (myIO_CLS.IsExistFile(filePath))
                {
                    return false;
                }
                else
                {
                    myIO_CLS.WriteFile(filePath, writeStr);
                    return true;
                }
        }
        /// <summary>
        /// 创建保存文章的文件夹，不存在就新建，yyyymmdd_Article格式
        /// </summary>
        /// <returns></returns>
        private bool CreateSaveDirectory()
        {
            try
            {
                myIO_CLS.CreateNewDirectory(ArticleDirectory + GetDate() + "_Article");
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 获取当天日期的格式化字符串
        /// </summary>
        /// <returns></returns>
        private static string GetDate()
        {
            return DateTime.Now.ToString("yyyymmdd");
        }
        /// <summary>
        /// 按照消息字符串，网页弹出提示框
        /// </summary>
        /// <param name="page"></param>
        /// <param name="msg"></param>
        public  void Show(System.Web.UI.Page page, string msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "message", "<script>alert('" + msg.ToString() + "'');</script>");
        }
    }
}