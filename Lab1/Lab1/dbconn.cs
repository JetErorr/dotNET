using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lab1
{
    class dbconn
    {
        SqlConnection con;
        SqlCommand cmd;
        public void insertdata()
        {
            try
            {
                con = new SqlConnection
(
@"
Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename='C:\Users\Jarde\documents\visual studio 2015\Projects\Lab1\Lab1\Database1.mdf';
Integrated Security=True
"
);
                cmd = new SqlCommand();
                Console.WriteLine("Enter the Sid: ");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter Div: ");
                string sdiv = Console.ReadLine();
                Console.WriteLine("Enter Branch: ");
                string sbranch = Console.ReadLine();

                cmd.CommandText = "insert into student(s_id, s_name, s_div, s_branch) values(" + sid + ", '" + sname + "', '" + sdiv + "', '" + sbranch + "')";
                //cmd.CommandText = "update student set s_div = '" + sdiv + "' where s_Id = '"+sid+"'";
                //cmd.CommandText = "delete from student where s_id = '"+sid+"'";
                cmd.Connection = con;

                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                {
                    Console.WriteLine("Inserted.!");
                }
                else
                {
                    Console.WriteLine("Not Inserted.!");
                }
            }
            catch(SqlException s)
            {
                Console.WriteLine(s);
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(String []args)
        {
            dbconn obj = new dbconn();
            obj.insertdata();
        }
    }
}
