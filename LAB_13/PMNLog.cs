using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_13
{
    static class PMNLog
    {
        static private readonly string _path = @"..\..\PMNlogfile.txt";

        static PMNLog()
        {
            StreamWriter sw = new StreamWriter(_path, false);
            sw.WriteLine(DateTime.Now + " : " + " File created");
            sw.Close();
        }

        static public void WriteLog(string text, bool bl = true)
        {
            StreamWriter sw = new StreamWriter(_path, bl);
            sw.WriteLine(DateTime.Now + " : " + text);
            sw.Close();
        }

        static public void ReadLog()
        {
            StreamReader sr = new StreamReader(_path);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        static public string FindLogByDate(string date)
        {
            string str = " ";

            foreach (string s in File.ReadLines(_path))
            {
                if (s.Contains(date))
                {
                    str += s + "\n";
                }
            }

            return str;
        }

        static public void CountOfLog()
        {
            int i = 0;
            foreach (string s in File.ReadLines(_path))
            {
                i++;
            }
            Console.WriteLine("В файле записано " + i + " логов");
        }

        static public void LogForTheLastHours()
        {
            Console.WriteLine("lll");
            string date = DateTime.Now.ToString("dd.MM.yyy") + " " + DateTime.Now.Hour;
            Console.WriteLine("\n" + date);

            string LFTLH = FindLogByDate(date);

            StreamWriter sw = new StreamWriter(_path);
            sw.WriteLine(LFTLH);
            sw.Close();

        }
    }
}
