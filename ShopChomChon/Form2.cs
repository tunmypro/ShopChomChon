using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopChomChon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartTimer();
        }

        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        string sql;

        public void serverConection()
        {
            string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
            cnn = new SqlConnection(myConection);
            cnn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serverConection();
            LoginCheck();
        }

        private void onEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serverConection();
                LoginCheck();
                e.Handled = true;
            }
        }

        public void LoginCheck()
        {
            var username = textBox1.Text;
            var password = textBox2.Text;
            sql = "Select ไอดี,พาสเวิร์ด,ประเภทผู้ใช้งาน from [ShopChomChon].[dbo].[ผู้ใช้งาน]";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (dataReader["ไอดี"].ToString().Equals(username, StringComparison.InvariantCulture) &&
                    dataReader["พาสเวิร์ด"].ToString().Equals(password, StringComparison.InvariantCulture))
                {
                    Session.UserID = textBox1.Text;
                    if (dataReader["ประเภทผู้ใช้งาน"].ToString().Equals("1", StringComparison.InvariantCulture))
                    {
                        Form1 f1 = new Form1();
                        f1.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form3 f3 = new Form3();
                        f3.Show();
                        this.Hide();
                    }
                }
            }
            label3.Text = "เข้าสู่ระบบไม่สำเร็จ";
            label3.ForeColor = Color.Red;
            cnn.Close();
        }

        Timer tmr = null;
        private void StartTimer()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(Timer1_Tick);
            tmr.Enabled = true;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }
    }
}
