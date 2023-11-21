using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace IT481_Unit3_JoseMiranda_Assignment
{
    public partial class Form1 : Form
    { 

        private Controller controller;
        private string user;
        private string password;
        private string server;
        private string database;


        public Form1()
        {
            InitializeComponent();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            user = tbUser.Text;
            password = tbPassword.Text;
            server = tbServer.Text;
            database = tbDatabase.Text;

            if (user.Length==0 || password.Length==0 || server.Length==0 || database.Length==0)
            {
                isValid = false;
                MessageBox.Show("Your must enter username, password,server and database values!");
            }

            if (isValid)
            {
                controller = new Controller("Server = " + server + "\\SQLEXPRESS; " +
                    "Database= " + database + ";" +
                    "User Id = " + user + ";" +
                    "Password = " + password + ";" +
                    "trustServerCertificate=True;"
                    );
                MessageBox.Show("Connection information sent!");
            }
            
        }

        private void btnQuery1_Click(object sender, EventArgs e)
        {
            string count = controller.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        private void btnQuery2_Click(object sender, EventArgs e)
        {
            string names = controller.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }

        private void btnQuery3_Click(object sender, EventArgs e)
        {
            string count = controller.getOrderCount();
            MessageBox.Show(count, "Order count");
        }

        private void btnQuery4_Click(object sender, EventArgs e)
        {
            string names = controller.getShipName();
            MessageBox.Show(names, "Order Ship names");
        }

        private void btnQuery5_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeCount();
            MessageBox.Show(count, "Employee count");
        }

        private void btnQuery6_Click(object sender, EventArgs e)
        {
            string count = controller.getEmployeeName();
            MessageBox.Show(count, "Employee Names");
        }
    }
}
