using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Mgr
{
    public static class CLog
    {
        public static string path = Application.StartupPath + @"\Log.txt";

        public static void Debug(object message)
        {
            string msg = System.DateTime.Now.ToString() + " Debug : " + message.ToString();

            FileStream aFile = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine(msg);
            sw.Close();
        }

        public static void Info(object message)
        {
            string msg = System.DateTime.Now.ToString() + " Info : " + message.ToString();

            FileStream aFile = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine(msg);
            sw.Close();
        }

        public static void Warn(object message)
        {
            string msg = System.DateTime.Now.ToString() + " Warn : " + message.ToString();

            FileStream aFile = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine(msg);
            sw.Close();
        }

        public static void Error(object message)
        {
            string msg = System.DateTime.Now.ToString() + " Error : " + message.ToString();

            FileStream aFile = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(aFile);
            sw.WriteLine(msg);
            sw.Close();
        }
    }
}
