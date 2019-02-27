//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab1
//{
//    class ConnectedDemo
//    {
        
//        static SqlCommand cmmd;
//        static SqlConnection conn;
//        public ConnectedDemo()
//        {   
//            conn.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Code\dotNET\Lab1\Lab1\Database3.mdf;Integrated Security=True");
//            cmmd.Connection = conn;
//        }
//        public void display()
//        {
//            cmmd.CommandText = ("select * from tabl");
//            execute(1);
//        }
//        public void insert()
//        {

//        }
//        public void update()
//        {

//        }
//        public void delete()
//        {

//        }
//        public void execute(int a = 1)
//        {
//            conn.Open();
//            if (a == 1)
//            {
//                SqlDataReader readr = cmmd.ExecuteReader();
//                while (readr.Read())
//                {
//                    Console.WriteLine(readr[0]+",\t");
//                    Console.WriteLine(readr[1]+",\t");
//                    Console.WriteLine(readr[2]+";\n");
//                }
//            }
//            else
//            {
//                int n = cmmd.ExecuteNonQuery();
//                if(n != 0)
//                {
//                    Console.WriteLine("Done.!");
//                }
//                else
//                {
//                    Console.WriteLine("Error: Return Code: " + n);
//                }
//            }
//            conn.Close();
//        }

//        static void Main()
//        {
//            ConnectedDemo test1 = new ConnectedDemo();
//            test1.display();
//        }
//    }
//}