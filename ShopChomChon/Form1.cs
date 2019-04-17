using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopChomChon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Fill_Data();
            comboBox1.SelectedItem = "ชื่อ";
            label3.Text = label3.Text + Session.UserID;
        }

        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader dataReader;
        string sql;
        private SqlDataAdapter mydtadp = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        SqlCommandBuilder cmbl;

        public void serverConection()
        {
            string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
            cnn = new SqlConnection(myConection);
            cnn.Open();
        }

        public void Fill_Data()
        {
            serverConection();

            sql = "Select * from [ShopChomChon].[dbo].[สมาชิก]";
            command = new SqlCommand(sql, cnn);
            SqlDataReader dr;
            DataTable dtDataTable = new DataTable();
            dtDataTable.Columns.AddRange(new DataColumn[12]
            {
                new DataColumn("รหัส"), new DataColumn("ประเภท"), new DataColumn("ชื่อ"), new DataColumn("นามสกุล"),
                new DataColumn("ชื่อหมู่"), new DataColumn("หมู่"), new DataColumn("อบต."),new DataColumn("บ้านเลขที่"),
                new DataColumn("ตำบล"), new DataColumn("อำเภอ"), new DataColumn("จังหวัด"), new DataColumn("จำนวนหุ้น")
            });
            dtDataTable.PrimaryKey = new DataColumn[] { dtDataTable.Columns["รหัส"] };

            try
            {
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string no = dr.GetInt32(0).ToString();
                    string type = dr.GetInt32(1).ToString();
                    string fname = dr.GetString(2);
                    string sname = dr.GetString(3);
                    string namemoo = dr.GetString(4);
                    string moo = dr.GetString(5);
                    string abt = dr.GetInt32(6).ToString();
                    string home = dr.GetString(7);
                    string tambon = dr.GetString(8);
                    string aumphur = dr.GetString(9);
                    string jugvud = dr.GetString(10);
                    string stock = dr.GetInt32(11).ToString();
                    dtDataTable.Rows.Add(no, type, fname, sname, namemoo, moo, abt, home, tambon, aumphur, jugvud,
                        stock);
                    if (fname == "รวมหุ้น อบต. หมู่ 7")
                    {
                        Session.totalm7 = stock;
                    }
                    if (fname == "รวมหุ้น อบต. หมู่ 8")
                    {
                        Session.totalm8 = stock;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Fail!");
                throw;
            }

            dataGridView1.DataSource = dtDataTable;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopChomChonDataSet1.สมาชิก' table. You can move, or remove it, as needed.
            this.สมาชิกTableAdapter.Fill(this.shopChomChonDataSet1.สมาชิก);

            serverConection();

            mydtadp.SelectCommand = new SqlCommand("select * from สมาชิก", cnn);
            cmbl = new SqlCommandBuilder(mydtadp);

            DataTable table = new DataTable();
            mydtadp.Fill(table);

            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serverConection();
            int i = 0;
            var username = Session.UserID;
            var password = textBox1.Text;
            sql = "Select ไอดี,พาสเวิร์ด from [ShopChomChon].[dbo].[ผู้ใช้งาน]";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                if (dataReader["ไอดี"].ToString().Equals(username, StringComparison.InvariantCulture) &&
                    dataReader["พาสเวิร์ด"].ToString().Equals(password, StringComparison.InvariantCulture))
                {
                    DialogResult dialogResult = MessageBox.Show("ยืนยัน", "ต้องการเปลี่ยนแปลงข้อมูลใช่หรือไม่",
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        mydtadp.Update((DataTable)bindingSource1.DataSource);
                        dataGridView1.Update();
                        MessageBox.Show("บันทึกค่าสำเร็จ");
                        i = 1;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        i = 0;
                    }
                }
            }
            if (i == 0)
            {
                MessageBox.Show("บันทึกค่าไม่สำเร็จ");
            }
            textBox1.Clear();
            cnn.Close();
        }

        private void searchindatagrid(object sender, EventArgs e)
        {
            DataView DV = new DataView(this.shopChomChonDataSet1.สมาชิก);
            DV.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                comboBox1.Text.Trim(), textBox2.Text.Trim());
            dataGridView1.DataSource = DV;
        }

        private void ไปหนาคดเงนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void ดToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void หนาจดการพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}