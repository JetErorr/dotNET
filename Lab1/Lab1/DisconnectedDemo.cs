using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Lab1
{
    class DisconnectedDemo
    {
        public static void insertdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jarde\documents\visual studio 2015\Projects\Lab1\Lab1\Database1.mdf';Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from student",con);
            DataSet ds = new DataSet();

            adp.Fill(ds, "student");

            DataRow dr = ds.Tables["student"].NewRow();
            //dr["S_id"] = 2;
            dr["S_name"] = "Raj";
            dr["S_div"] = "6D1";
            dr["S_branch"] = "IT";

            ds.Tables["student"].Rows.Add(dr);

            SqlCommandBuilder scmb = new SqlCommandBuilder(adp);

            adp = scmb.DataAdapter;
            adp.Update(ds, "student");
            Console.WriteLine("Success.!");
            }

            static void show()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\Jarde\documents\visual studio 2015\Projects\Lab1\Lab1\Database1.mdf'; Integrated Security = True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from student",con);
            DataSet ds = new DataSet();
            
            int count = 0;
            while (count <= (ds.Tables["student"].Rows.Count - 1))
            {
                Console.WriteLine(ds.Tables["stduent"].Rows[count]["S_id"]);
                Console.WriteLine(ds.Tables["stduent"].Rows[count]["S_name"]);
                Console.WriteLine(ds.Tables["stduent"].Rows[count]["S_div"]);
                Console.WriteLine(ds.Tables["stduent"].Rows[count]["S_brach"]);
                count++;
            }
        }
            static void Main(){
                insertdata();
                show();
            }
    }
}
