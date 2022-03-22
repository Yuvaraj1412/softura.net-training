using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp3
{
    [Serializable]

    class Employee
    {
        public string Name = "YUVARAJ";
        public string ID = "EM4654";
        public string Gender = "Male";
        public string Age = "21";
    }
    class day12task2
    {
        public void Empdata()
        {
            Employee emobj = new Employee();
            FileStream fs = new FileStream("Employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, emobj);
            fs.Close();
        }
        public void DeserialData()
        {
            FileStream fs = new FileStream("Employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            Employee emobj = (Employee)f.Deserialize(fs);
            Console.WriteLine(emobj.Name);
            Console.WriteLine(emobj.ID);
            Console.WriteLine(emobj.Gender);
            Console.WriteLine(emobj.Age);
        }

        public static void Main()
        {
            day12task2 obj = new day12task2();
            obj.Empdata();
            obj.DeserialData();
            Console.Read();
        }
    }
}
