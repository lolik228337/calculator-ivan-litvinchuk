using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Util
    {
        string num = "";//number in lower display
        public string Num
        {
            get 
            {
                return num; 
            }
            set
            {
                if (num.Length < 9)
                {
                    num = value;
                }
                else if (num.Length == 9 && num.IndexOf('-') == -1)//9 numbers w/out minus
                {
                    if (value == "-" + num)
                    {
                        num = value;
                    }
                    else if(value == null || value == "")
                    {
                        num = "";
                    }
                }
                else if(num.Length == 9 && num.IndexOf('-') != -1)
                {
                    num = value;
                }
                else if(num.Length == 10)
                {
                    if (value == num.Substring(1, num.Length - 1))//change to plus
                    {
                        num = value;
                    }
                    else
                    {
                        if (value == null || value == "")//able to delete (clear)
                        {
                            num = "";
                        }
                    }
                }
            }
        }
        string num1 = "";//number in upper display
        public string Num1 
        {
            get
            {
                return num1;
            }
            set 
            {
                num1 = value;
            }
        }
        string action = "";
        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        string exception = "";
        public string Exception
        {
            get { return exception; }
            set { exception = value; }
        }
        public void Result() 
        {
            switch (action)
            {
                case "+":
                    num1 = Convert.ToString(Convert.ToInt32(num1) + Convert.ToInt32(num));
                    action = "+";
                    break;
                case "-":
                    num1 = Convert.ToString(Convert.ToInt32(num1) - Convert.ToInt32(num));
                    action = "-";
                    break;
                case "*":
                    num1 = Convert.ToString(Convert.ToInt32(num1) * Convert.ToInt32(num));
                    action = "*";
                    break;
                case "/":
                    try
                    {
                        num1 = Convert.ToString(Convert.ToInt32(num1) / Convert.ToInt32(num));
                        action = "/";
                    }
                    catch (DivideByZeroException ex)
                    {
                        num1 = "";
                        action = "";
                        exception = "NOT/0";
                    }
                    break;
                default:
                    break;
            }
            num = "";
        }
    }
}
