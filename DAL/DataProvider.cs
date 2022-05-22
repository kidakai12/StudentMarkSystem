using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataProvider
    {
        public DataProvider() { }

        //Học
        public string connectionString = @"Data Source=DESKTOP-P8VHEBN\HOCDB1;Initial Catalog=QUANLYTOURDULICH;USER ID=kidakai12; PASSWORD=songkhoe123";
        //Hùng
        //public string connectionString = @"Data Source=DESKTOP-48AE0SM\SQLEXPRESS;Initial Catalog=QUANLYTOURDULICH;Integrated Security=True";
        //Doanh
        //public string connectionString = @"Data Source=DESKTOP-TB623K0\DOANHTT;Initial Catalog=QUANLYTOURDULICH;Integrated Security=True";
        //Nguyen
        //public string connectionString = @"Data Source=LAPTOP-CEDHB3NK\NGUYEN;Initial Catalog=QUANLYTOURDULICH; USER ID=SA; PASSWORD=nguyen";

        public DataTable ExecuteQuery(string query,object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;

                    foreach(string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
