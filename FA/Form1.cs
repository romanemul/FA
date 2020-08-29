using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;

namespace FA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connector();
        }


        public void Connector() 
        {
            //MySqlConnection conn = new MySqlConnection();
            //MySqlDataAdapter da = new MySqlDataAdapter();
            //MySqlCommand comm = new MySqlCommand();
            //MySqlCommand mscmd = new MySqlCommand();
            //comm.CommandText = "SELECT * FROM orders";
            //mscmd.CommandText = "INSERT INTO orders (name,company) VALUES (@name,@company)";
            //da.InsertCommand = mscmd;
            //comm.Connection = conn;
            //da.SelectCommand = comm;
            //conn.ConnectionString = "Server = localhost;Port=3306; Database = myschema; Uid = root; Connection Timeout = 5";
            //conn.Open();
            //comm.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //da.Fill(ds);
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            dateTimePicker1.Value = DateTime.Now;
            DateTime timeNow = dateTimePicker1.Value;
            
            MessageBox.Show(timeNow.ToString());
        }
    }
}
