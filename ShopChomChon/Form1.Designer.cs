namespace ShopChomChon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopChomChonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopChomChonDataSet = new ShopChomChon.ShopChomChonDataSet();
            this.financeDataSet = new ShopChomChon.FinanceDataSet();
            this.financeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.สมาชกBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopChomChonDataSet1 = new ShopChomChon.ShopChomChonDataSet1();
            this.สมาชิกTableAdapter = new ShopChomChon.ShopChomChonDataSet1TableAdapters.สมาชิกTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.นำทางToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ไปหนาคดเงนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.หนาจดการพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.สมาชกBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 511);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // shopChomChonDataSetBindingSource
            // 
            this.shopChomChonDataSetBindingSource.DataSource = this.shopChomChonDataSet;
            this.shopChomChonDataSetBindingSource.Position = 0;
            // 
            // shopChomChonDataSet
            // 
            this.shopChomChonDataSet.DataSetName = "ShopChomChonDataSet";
            this.shopChomChonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeDataSet
            // 
            this.financeDataSet.DataSetName = "FinanceDataSet";
            this.financeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // financeDataSetBindingSource
            // 
            this.financeDataSetBindingSource.DataSource = this.financeDataSet;
            this.financeDataSetBindingSource.Position = 0;
            // 
            // สมาชกBindingSource
            // 
            this.สมาชกBindingSource.DataMember = "สมาชิก";
            this.สมาชกBindingSource.DataSource = this.shopChomChonDataSet1;
            // 
            // shopChomChonDataSet1
            // 
            this.shopChomChonDataSet1.DataSetName = "ShopChomChonDataSet1";
            this.shopChomChonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // สมาชิกTableAdapter
            // 
            this.สมาชิกTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(896, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "เซพค่าที่ทำการแก้ไข";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(745, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.searchindatagrid);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(758, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ใส่รหัสผ่านเพื่อบันทึกค่า";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ชื่อ",
            "เลขสมาชิก"});
            this.comboBox1.Location = new System.Drawing.Point(61, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ค้นหา";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.นำทางToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // นำทางToolStripMenuItem
            // 
            this.นำทางToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ไปหนาคดเงนToolStripMenuItem,
            this.ดToolStripMenuItem,
            this.หนาจดการพนกงานToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            this.นำทางToolStripMenuItem.Name = "นำทางToolStripMenuItem";
            this.นำทางToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.นำทางToolStripMenuItem.Text = "ดูหน้าอื่น";
            // 
            // ไปหนาคดเงนToolStripMenuItem
            // 
            this.ไปหนาคดเงนToolStripMenuItem.Name = "ไปหนาคดเงนToolStripMenuItem";
            this.ไปหนาคดเงนToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ไปหนาคดเงนToolStripMenuItem.Text = "หน้าคิดเงิน";
            this.ไปหนาคดเงนToolStripMenuItem.Click += new System.EventHandler(this.ไปหนาคดเงนToolStripMenuItem_Click);
            // 
            // ดToolStripMenuItem
            // 
            this.ดToolStripMenuItem.Name = "ดToolStripMenuItem";
            this.ดToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ดToolStripMenuItem.Text = "หน้าสรุปปันผล";
            this.ดToolStripMenuItem.Click += new System.EventHandler(this.ดToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(398, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "สวัสดี คุณ ";
            // 
            // หนาจดการพนกงานToolStripMenuItem
            // 
            this.หนาจดการพนกงานToolStripMenuItem.Name = "หนาจดการพนกงานToolStripMenuItem";
            this.หนาจดการพนกงานToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.หนาจดการพนกงานToolStripMenuItem.Text = "หน้าจัดการพนักงาน";
            this.หนาจดการพนกงานToolStripMenuItem.Click += new System.EventHandler(this.หนาจดการพนกงานToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1028, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายการสมาชิก";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.สมาชกBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource financeDataSetBindingSource;
        private FinanceDataSet financeDataSet;
        private System.Windows.Forms.BindingSource shopChomChonDataSetBindingSource;
        private ShopChomChonDataSet shopChomChonDataSet;
        private ShopChomChonDataSet1 shopChomChonDataSet1;
        private System.Windows.Forms.BindingSource สมาชกBindingSource;
        private ShopChomChonDataSet1TableAdapters.สมาชิกTableAdapter สมาชิกTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem นำทางToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ไปหนาคดเงนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ดToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem หนาจดการพนกงานToolStripMenuItem;
    }
}

