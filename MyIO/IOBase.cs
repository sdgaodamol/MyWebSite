using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyIO
{
    public class IOBase
    {
        StreamReader myStreamReader = null;
        StreamWriter myStreamWriter = null;
        Encoding myEncoding = Encoding.GetEncoding("UTF-8");
        String error;

        /// <summary>
        /// 读取和设置要处理的字符串
        /// </summary>
         public string MyStr
        {
            get { return MyStr; }
            private set {; }
        }
        /// <summary>
        ///  设置和读取文件编码格式
        /// </summary>
        public Encoding MyEnCoding
        {
            get
            {
                return myEncoding;
            }
            set
            {
                myEncoding = value;
            }
        }

        /// <summary>
        /// 按照文件地址和文件编码读取文件流
        /// </summary>
        /// <param name="filePath">文件地址</param>
        public bool ReadFile(string filePath)
        {
            try
            { 
                myStreamReader = new StreamReader(filePath, myEncoding);
                MyStr = myStreamReader.ReadToEnd();
            return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                myStreamReader.Close();
            }
        }
        /// <summary>
        /// 将字符串通过文件流按照编码和文件名，写入文件并保存
        /// </summary>
        /// <param name="filePath">保存的文件名</param>
        /// <param name="Str">写入的字符串</param>
        /// <returns></returns>
        public bool WriteFile(string filePath, string Str)
        {
            try
            {
                myStreamWriter = new StreamWriter(filePath, false, myEncoding);
                myStreamWriter.Write(Str);
                myStreamWriter.Flush();
                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                myStreamWriter.Close();
            }
        }
        /// <summary>
        /// 按照文件夹路径创建文件夹
        /// </summary>
        /// <param name="directoryPath">文件夹路径</param>
        /// <returns></returns>
        public bool CreateNewDirectory(string directoryPath)
        {
            if(Directory.Exists(directoryPath))
            {
                return false;
            }else
            {
                Directory.CreateDirectory(directoryPath);
                return true;
            }
        }
        /// <summary>
        /// 按照文件路径判断文件是否存在
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool IsExistFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }


    }
}
