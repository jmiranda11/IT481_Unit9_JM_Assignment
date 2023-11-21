using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT481_Unit3_JoseMiranda_Assignment
{
    internal class Controller
    {
        string connectionString;
        SqlConnection cnn = null ;

        public Controller()
        {
            connectionString = "Server = localhost\\SQLEXPRESS; " +
                    "Trusted_Connection=true;" +
                    "Database=northwind;" +
                    "User Instance=True;" +
                    "trustServerCertificate=True;" +
                    "Connection timeout=30";
        }

        public Controller(string conn)
        {
            connectionString = conn;
        }

        // method to get customer record count
        public string getCustomerCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT count(*) FROM customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            cnn.Close();
            return count.ToString();
        }

        //method to get company names
        public string getCompanyNames()
        {
            string names = "None";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT companyname FROM customers order by companyname;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            names = "";
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();
            return names;
        }

        public string getEmployeeCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT count(*) FROM employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            cnn.Close();
            return count.ToString();
        }

        public string getEmployeeName()
        {
            string names = "None";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT FirstName + ' ' + LastName as nm FROM employees order by nm;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            names = "";
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();
            return names;
        }

        public string getOrderCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT count(*) FROM orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            cnn.Close();
            return count.ToString();
        }

        public string getShipName()
        {
            string names = "None";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "SELECT shipname FROM orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            names = "";
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            cnn.Close();
            return names;
        }

    }
}
