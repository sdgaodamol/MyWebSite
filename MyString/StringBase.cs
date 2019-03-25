using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    public class StringBase
    {
        public static string GetRepeatNumberStr(int num, int repeatNum,int len)
        {
            string tempStr = "";
            switch(num.ToString().Length){
                case 1:
                    len = len - 1;
                    break;
                case 2:
                    len = len - 2;
                    break;
                case 3:
                    len = len - 2;
                    break;
                case 4:
                    len = len - 2;
                    break;
                case 5:
                    len = len - 2;
                    break;
                case 6:
                    len = len - 2;
                    break;
                default:
                    break;
            }
            for (int i = 0; i <= len; i++)
            {
               tempStr  += repeatNum.ToString();
            }
            tempStr = tempStr + num.ToString();
            return tempStr;
        }
    }
}
