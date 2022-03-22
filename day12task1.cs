using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ConsoleApp3 
{
    class day12task1 
    {
        public static void Main()
        {
            FileStream fs = new FileStream("D:\\softura training\\Task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            Queue q = new Queue();
            q.Enqueue("Laddu");
            q.Enqueue("Almond and date cake");
            q.Enqueue("Brownies");
            q.Enqueue("Chocolate chip cookies");
            foreach (string cal in q)
            {
                sw.Write("\n" + cal);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            FileStream fs1 = new FileStream("D:\\softura training\\Task1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            string str = sr.ReadToEnd();
            sr.Close();
            fs1.Close();
            Console.WriteLine(str);
            FileInfo fi = new FileInfo(@"D:\softura training\Task1.txt");
            Console.WriteLine(fi.Length);
            Console.WriteLine(fi.CreationTime);
            Console.ReadLine();
        }
    }
}
