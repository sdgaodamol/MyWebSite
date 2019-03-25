using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace DBManager_MSSQL
{
    public class MSSQLDB
    {
        OleDbConnection myconn;
        OleDbCommand mycmd;
        OleDbDataAdapter mydataAdapter;
        DataSet mydataset;
        DataTable mydataTable;
        string connStr; //数据连接字段
        string mysqlStr; //查询字符串
        bool myStatus;

        public bool Status //数据链接状态只读属性
        {
            get {
                return myStatus;
            }
        }
        public string SqlStr
        {
            set
            {
                mysqlStr = value;
            }
            get
            {
                return mysqlStr;
            }
        } //查询字符串属性
        public DataTable DTTable
        {
            get
            {
                return mydataTable;
            }
        }


        /// <summary>
        /// SQLServer7.0-2016实例 oledb标准链接
        /// </summary>
        /// <param name="serverstr">服务器+实例名</param>
        /// <param name="databasestr">数据库名</param>
        /// <param name="userid">数据库用户名，可选</param>
        /// <param name="password">数据库密码，可选</param>
        public MSSQLDB(string server_instance_str, string iniCatalog="", string userid = "", string password = "")
        {
            connStr = "Provider=sqloledb; Data Source = " + server_instance_str + "; Initial Catalog = " + iniCatalog + "; User Id = " + userid + "; Password = " + password + ";";
            myconn = new OleDbConnection(connStr);
            this.ConnOpen();
        }
        /// <summary>
        /// 按照sql语句，获得DataReader只读数据数组列表
        /// </summary>
        /// <param name="sqlStr"></param>
        /// <returns></returns>
        public void ReadData(string sqlStr) {
            mydataset = new DataSet();
            if (myStatus == true)
            {
                mycmd = new OleDbCommand();
                mycmd.Connection = myconn;
                mycmd.CommandText = sqlStr;
                mydataAdapter = new OleDbDataAdapter(mycmd);
                mydataAdapter.Fill(mydataset);
                mydataTable = mydataset.Tables[0];
            }else
            {
                this.ConnOpen();
                ReadData(sqlStr);
            }
            this.ConnClose();
        }
        private void ConnOpen()
        {
            myconn.Open();
            myStatus = true;
        }
        private void ConnClose()
        {
            myconn.Close();
            myStatus = false;
        }
    }
}

