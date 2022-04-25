using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace task
{
        public class product
        {
            public void productdis()
            {
                SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
                SqlCommand cmd = new SqlCommand("select prodID,prodName,price,manufactdate,expdate from tbl_product", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("prodID: " + dr[0] + " " + "prodName:" + dr[1] + " " + "price:" + dr[2] + " " + "manufactdate:" + dr[3] + " " + "expdate:" + dr[4]);
                }
                con.Close();
            }
        public int bill(int prodID,int quantity)
        {
            SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
            int count = quantity;
            SqlCommand cmd = new SqlCommand("select price*" + count + "from tbl_product where prodID =" + prodID + "", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int total = Convert.ToInt32(dr[0]);
                return total;
            }
            con.Close();
            return 0;
        }
        public void inspur(int prodID, int quantity, int cusID, int amount)
        {
            SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("insert tbl_purchase values(" + prodID + "," + cusID + "," + quantity +",getdate()," + amount + ")",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("purchase table insert");
        }
        public void showbill()
        {
            SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select top 1 billno,cusID,prodID,quantity,amount from tbl_purchase order by billno desc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("billno:" + dr[0] + "customerID:" + dr[1] + "productID:" + dr[2] + "quantity:" + dr[3] + "total_amount:Rs:" + dr[4]);
            }
            con.Close();
        }
        public void cusdetailpur(int cusID)
        {
            SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select billno,cusID,prodID,quantity,amount from tbl_purchase where cusID = " + cusID + "", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine("billno:" + dr[0] + "customerID:" + dr[1] + "productID:" + dr[2] + "quantity:" + dr[3] + "total_amount:Rs:" + dr[4]);
            }
            con.Close();
        }
        public void cusdetailbydate(int cusID)
        {
            SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select * from tbl_purchase where cusID =" + cusID + "order by date_pur", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("billno:" + dr[0] + "customerID:" + dr[1] + "productID:" + dr[2] + "quantity:" + dr[3] + "total_amount:Rs:" + dr[5] + "purchasedate:" + dr[4]);
            }
            con.Close();
        }

        
        }
    
    public class customer : product
    {
        public string validateID(string cusname)
        {
            SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user ID = sa; password = P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select cusID,cusName,gender,dateofbirth,contactno,emailID,city from tbl_customer where cusName = '" + cusname + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("cusID:" + dr[0] + " " + "cusName:" + dr[1] + " " + "gender:" + dr[2] + " " + "dateofbirth" + dr[3] + " " + "emailID:" + dr[4] + " " + "contactno:" + dr[5] + " " + "city:" + dr[6] + " ");
            }
            con.Close();
            return cusname;

        }

            public void new_customer()
            {
                SqlConnection con = new SqlConnection("data source = SAMSUNG; database = Task; user id = sa; password = P@ssw0rd");
                Console.WriteLine("Enter your name:");
                string cusName = Console.ReadLine();
                Console.WriteLine("Gender :M or F");
                string gender = Console.ReadLine();
                Console.WriteLine("Date of birth");
                string dateofbirth = Console.ReadLine();
                Console.WriteLine("Please Enter your Contact.No:");
                string contactno = Console.ReadLine();
                Console.WriteLine("Enter your EmailID");
                string emailID = Console.ReadLine();
                Console.WriteLine("Choose from the cities Below:\n 1.Chennai.\n 2.Mumbai. \n 3.Delhi.\n 4.Kolkata .....");
                string city = Console.ReadLine();
                SqlCommand cmd = new SqlCommand("insert tbl_customer values ('" + cusName + "','" + gender + "','" + dateofbirth + "','" + contactno + "','" + emailID + "','" + city + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Row inserted:");
            }
    }

    class Class1
    {
        public static void Main()
        {
            customer pod = new customer();
            Console.WriteLine("choose 1 - existing customer or 2 - new customer");
            int P = Convert.ToInt32(Console.ReadLine());
            switch (P)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your name:");
                        string name = Console.ReadLine();
                        pod.validateID(name);
                        pod.productdis();
                        break;
                    }
                case 2:
                    {
                        pod.new_customer();
                        break;
                    }
            }
            Console.WriteLine("enter productID:");
            int prodID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customerID:");
            int cusID = Convert.ToInt32(Console.ReadLine());
            int total = pod.bill(prodID, quantity);
            pod.inspur(prodID, quantity, cusID,total);
            Console.WriteLine("**********CURRENT BILL**********");
            pod.showbill();
            Console.WriteLine("*************PURCHASE DETAILS BY CUSTID*********");
            pod.cusdetailpur(cusID);
            Console.WriteLine("***************PURCHASE DETAILS BY DATE**********");
            pod.cusdetailbydate(cusID);
        }
    }
}
