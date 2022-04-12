using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Dataa
{
    class day27task
    {
        public void TaskData(int sno, string name)
        {
            SqlConnection con = new SqlConnection("Data source=SAMSUNG; database =Trial; user id = sa; password=P@ssw0rd");
            string sqlqry = "insert Enroll values(" + sno + ",'" + name + "')";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row inserted");
        }
        public void UpdateData()
        {
            SqlConnection con = new SqlConnection("Data source=SAMSUNG; database =Trial; user id = sa; password=P@ssw0rd");
            string sqlqry = "Update Enroll set name='yuvaraj' where sno=1";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row update");
        }
        public void DeleteData()
        {
            SqlConnection con = new SqlConnection("Data source=SAMSUNG; database =Trial; user id = sa; password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("delete Enroll where sno=1", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row deleted");
        }


        static void Main()
            {
            //SqlConnection con = new SqlConnection("data source = SAMSUNG; database=Trial; user id = sa; password = P@ssw0rd");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Create table Enroll(sno int, name varchar(20))", con);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Completed");
            //con.Close();
            day27task dt = new day27task();
            Console.WriteLine("Enter sno:");
            int sno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            dt.TaskData(sno, name);
            dt.UpdateData();
            dt.DeleteData();

            }
        
    }
}





