using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopChomChon
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            label7.Text = label7.Text + Session.UserID;
        }


        private void onEnter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int total = 0;
        public void ChageMoney()
        {
            if (textBox2.Text == "" || Convert.ToInt32(textBox2.Text) < 1)
            {
                return;
            }
            string[] row = { Convert.ToInt32(textBox2.Text) + Environment.NewLine };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            listView1.View = View.List;
            textBox2.Clear();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                total += int.Parse(listView1.Items[i].SubItems[0].Text);
            }
            label3.Text = string.Format("{0:C0}", total);
            //total.ToString("#,###,###,###", CultureInfo.InvariantCulture);
        }

        public string idnew;
        public string getAutoid(string id)
        {
            DateTime date = DateTime.Now;
            string getday = date.Day.ToString();
            string getmonth = date.Month.ToString();
            string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
            SqlConnection con = new SqlConnection(myConection);
            SqlCommand cmd = new SqlCommand("SELECT COUNT (รหัสรายการยอดซื้อสมาชิก) FROM [ShopChomChon].[dbo].[ยอดซื้อ]", con);
            con.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string getc = dataReader.GetInt32(0).ToString();
                if (id.Length == 1)
                {
                    idnew = getmonth + getday + getc + "00" + id;
                }
                else if (id.Length == 2)
                {
                    idnew = getmonth + getday + getc + "0" + id;
                }
                else
                {
                    idnew = getmonth + getday + getc + id;
                }
            }
            con.Close();
            return idnew;
        }

        public void UserChange()
        {
            try
            {
                string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
                SqlConnection cnn = new SqlConnection(myConection);
                SqlCommand command = new SqlCommand("sp_ยอดซื้อ_insert", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@รหัสรายการยอดซื้อสมาชิก", getAutoid(textBox1.Text));
                if (textBox1.Text == "")
                {
                    command.Parameters.AddWithValue("@เลขสมาชิก", "999");
                }
                else
                {
                    command.Parameters.AddWithValue("@เลขสมาชิก", textBox1.Text);
                }
                command.Parameters.AddWithValue("@เป็นเงิน", total);
                command.Parameters.AddWithValue("@เงินที่รับ", Session.ReciveMoney);
                command.Parameters.AddWithValue("@เงินทอน", Session.ChangeMoney);
                command.Parameters.AddWithValue("@วันที่", DateTime.Now);
                command.Parameters.AddWithValue("@พนักงาน", Session.UserID);
                cnn.Open();
                int x = command.ExecuteNonQuery();
                if (x != 0)
                {
                    MessageBox.Show("คิดเงินเสร็จแล้ว");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    label3.Text = "";
                    label6.Text = "";
                    listView1.Clear();
                    total = 0;
                }
                else
                {
                    MessageBox.Show("ระบบทำงานไม่ถูกต้อง");
                }
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ระบบทำงานไม่ถูกต้อง");
                throw;
            }
        }

        private void Chaged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ChageMoney();
                e.Handled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ChkChange(object sender, KeyEventArgs e)
        {

        }

        private void ChkMoney(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listView1.Items.Count != 0 && textBox3.Text != "" && ChkChange(Convert.ToInt32(textBox3.Text)) != -1)
                {
                    UserChange();
                }
                else
                {
                    MessageBox.Show("ใส่ข้อมูลไม่ถูกต้อง");
                }
            }
        }

        private int ChkChange(int money)
        {
            int c1, c2, re;
            c1 = money;
            c2 = total;
            if (c1 >= c2)
            {
                re = c1 - c2;
                MessageBox.Show("เงินทอน     =>     " + re.ToString());
                Session.ReciveMoney = c1;
                Session.ChangeMoney = re;
                return re;
            }
            else
            {
                return -1;
            }
        }

        private void FindName(object sender, EventArgs e)
        {
            string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
            SqlConnection con = new SqlConnection(myConection);
            string query = String.Format("select ชื่อ,นามสกุล from [ShopChomChon].[dbo].[สมาชิก] where เลขสมาชิก like '{0}'", textBox1.Text.Trim());
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = dr.GetString(0) + "   " + dr.GetString(1);
            }
            con.Close();

            string queryn = String.Format("IF EXISTS(select ชื่อ from [ShopChomChon].[dbo].[สมาชิก] where เลขสมาชิก like '{0}') SELECT 'found' AS search_result ELSE SELECT 'not found' AS search_result;", textBox1.Text.Trim());
            SqlCommand cmdn = new SqlCommand(queryn, con);
            con.Open();
            SqlDataReader drn = cmdn.ExecuteReader();
            string chk;
            while (drn.Read())
            {
                chk = drn.GetString(0);
                if (chk == "not found")
                {
                    label6.Text = "ไม่พบหมายเลขสมาชิก";
                }
            }
            con.Close();
        }

        private void chkNum(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void resetMoney(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                switch (MessageBox.Show("ยืนยัน", "ต้องการล้างค่ารายการคิดเงิน", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        {
                            listView1.Items.Clear();
                            total = 0;
                            label3.Text = string.Format("{0:C0}", total);
                            MessageBox.Show("ล้างค่าเรียบร้อย");
                            break;
                        }
                    case DialogResult.No: MessageBox.Show("ยกเลิกการล่างค่า"); break;
                }
            }
        }

        private void ชวยเหลอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ต้องการล้างค่าการคิดเงิน : คลิกที่กล่องรายการรวมและกดปุ่ม DELETE");
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
