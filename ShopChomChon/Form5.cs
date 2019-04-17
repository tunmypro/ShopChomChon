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

namespace ShopChomChon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlCommandBuilder cmbl;
        private SqlDataAdapter mydtadp = new SqlDataAdapter();

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopChomChonDataSet8.ผู้ใช้งาน' table. You can move, or remove it, as needed.
            this.ผู้ใช้งานTableAdapter.Fill(this.shopChomChonDataSet8.ผู้ใช้งาน);
            string myConection = Properties.Settings.Default.ShopChomChonConnectionString;
            SqlConnection cnn = new SqlConnection(myConection);
            cnn.Open();
            mydtadp = new SqlDataAdapter("select * from [ShopChomChon].[dbo].[ผู้ใช้งาน]",cnn);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (MessageBox.Show("ยืนยัน", "ยืนยันการเปลี่ยนแปลงข้อมูล", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        {
                            cmbl = new SqlCommandBuilder(mydtadp);
                            mydtadp.Update(this.shopChomChonDataSet8.ผู้ใช้งาน);
                            MessageBox.Show("เปลี่ยนแปลงสำเร็จ");
                            break;
                        }
                    case DialogResult.No: MessageBox.Show("ยกเลิกแล้ว"); break;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            this.Close();
        }
    }
}
