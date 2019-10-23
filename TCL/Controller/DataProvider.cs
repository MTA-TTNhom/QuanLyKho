using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKVCGT.Controler
{

    class DataProvider
    {

        private string connectString = @"Data Source=DESKTOP-S2JTV1H\SQLEXPRESS;Initial Catalog=QLK;Integrated Security=True";

        private static DataProvider instances;
        /*1*/
        public static DataProvider Instances

        {
            get

            {
                if (instances == null)

                {
                    instances = new DataProvider();

                }
                return instances;
            }


            private set
            {

                instances = value;

            }

        }

        private DataProvider()

        {


        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)

        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectString))

            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)


                {

                    string[] listQuery = query.Split(' ');
                    int i = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains("@"))

                        {
                            string newItem = item.Trim(',');

                            cmd.Parameters.AddWithValue(newItem, parameter[i]);

                            i++;
                        }
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();


            }

            return dt;

        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int rowNum = 0;

            using (SqlConnection con = new SqlConnection(connectString))
            {

                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {

                    string[] listParameter = query.Split(' ');
                    int i = 0;

                    foreach (string item in listParameter)
                    {
                        if (item.Contains('@'))
                        {

                            string nitem = item.Trim(',');
                            cmd.Parameters.AddWithValue(nitem, parameter[i]);

                            i++;

                        }
                    }

                    rowNum = cmd.ExecuteNonQuery();
                }

                con.Close();
            }

            return rowNum;
        }


        public object ExeuteScalar(string query, object[] parameter = null)
        {

            object tem = 0;
            using (SqlConnection con = new SqlConnection(connectString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                if (parameter != null)
                {


                    string[] listParameter = query.Split(' ');
                    int i = 0;

                    foreach (string item in listParameter)
                    {

                        if (item.Contains('@'))
                        {

                            string nitem = item.Trim(',');

                            cmd.Parameters.AddWithValue(nitem, parameter[i]);
                            i++;
                        }

                    }

                    tem = cmd.ExecuteScalar();

                }


                con.Close();
            }

            return tem;

        }

    }



}
