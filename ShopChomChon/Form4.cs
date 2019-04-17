using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ShopChomChon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "ชื่อ";
            label2.Text = label2.Text + Session.UserID;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopChomChonDataSet7.สรุปยอดปันผล' table. You can move, or remove it, as needed.
            this.สรุปยอดปันผลTableAdapter5.Fill(this.shopChomChonDataSet7.สรุปยอดปันผล);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void searchindatagrid(object sender, EventArgs e)
        {
            DataView DV = new DataView(this.shopChomChonDataSet2.สรุปยอดปันผล);
            DV.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'",
                comboBox1.Text.Trim(), textBox2.Text.Trim());
            dataGridView1.DataSource = DV;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string chkid;
            chkid = Interaction.InputBox("กรอกหมายเลขสมาชิกที่รับเงิน", "กรอกเลขสมาชิก", "", -1, -1);
            if (chkid == "")
            {
                MessageBox.Show("ยกเลิกการรับเงินแล้ว");
            }
            else recivemoney(Convert.ToInt32(chkid));
        }

        public void recivemoney(int id)
        {
            string chkmh;
            chkmh = Interaction.InputBox("กรอกหมายเหตุการรับเงิน", "กรอกหมายเหตุ(ห้ามใส่ช่องว่าง)", "ใส่หมายเหตุ(ไม่ต้องใส่ก็ได้)", -1, -1);
            if (chkmh == "ใส่หมายเหตุ(ไม่ต้องใส่ก็ได้)" && id > 0 && id < 608)
            {
                chkmh = "ว่าง";
                sendsp(id, chkmh);
                MessageBox.Show("การรับเงินเสร็จสิ้น");
            }
            else if (chkmh == "")
            {
                MessageBox.Show("ยกเลิกการรับเงินแล้ว");
            }
            else if (chkmh.Length != 0 && id > 0 && id < 608)
            {
                sendsp(id, chkmh);
                MessageBox.Show("การรับเงินเสร็จสิ้น");
            }
            else
            {
                MessageBox.Show("หมายเลขสมาชิกไม่ถูกต้อง");
            }

            //switch (MessageBox.Show("ยืนยัน", "ยืนยันการรับเงินของหมายเลขสมาชิก => "+id.ToString(), MessageBoxButtons.YesNo))
            //{
            //    case DialogResult.Yes:
            //        {
            //            sendsp(id);
            //            MessageBox.Show(id.ToString());
            //            break;
            //        }
            //    case DialogResult.No: MessageBox.Show("ยกเลิกการรับเงินแล้ว"); break;
            //}
        }

        public void sendsp(int id, string comment)
        {
            try
            {
                string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
                SqlConnection cnn = new SqlConnection(myConection);
                SqlCommand command = new SqlCommand("sp_การรับเงิน", cnn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@เลขสมาชิก", id);
                command.Parameters.AddWithValue("@หมายเหตุ", comment);
                cnn.Open();
                int x = command.ExecuteNonQuery();
                if (x == 0)
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
    }
}
