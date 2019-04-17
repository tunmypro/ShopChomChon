namespace ShopChomChon
{
    partial class Form5
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
            this.ไอดDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.พาสเวรดDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ชอผใชงานDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ประเภทผใชงานDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ผใชงานBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopChomChonDataSet8 = new ShopChomChon.ShopChomChonDataSet8();
            this.button1 = new System.Windows.Forms.Button();
            this.ผู้ใช้งานTableAdapter = new ShopChomChon.ShopChomChonDataSet8TableAdapters.ผู้ใช้งานTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ผใชงานBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ไอดDataGridViewTextBoxColumn,
            this.พาสเวรดDataGridViewTextBoxColumn,
            this.ชอผใชงานDataGridViewTextBoxColumn,
            this.ประเภทผใชงานDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ผใชงานBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // ไอดDataGridViewTextBoxColumn
            // 
            this.ไอดDataGridViewTextBoxColumn.DataPropertyName = "ไอดี";
            this.ไอดDataGridViewTextBoxColumn.HeaderText = "ไอดี";
            this.ไอดDataGridViewTextBoxColumn.Name = "ไอดDataGridViewTextBoxColumn";
            // 
            // พาสเวรดDataGridViewTextBoxColumn
            // 
            this.พาสเวรดDataGridViewTextBoxColumn.DataPropertyName = "พาสเวิร์ด";
            this.พาสเวรดDataGridViewTextBoxColumn.HeaderText = "พาสเวิร์ด";
            this.พาสเวรดDataGridViewTextBoxColumn.Name = "พาสเวรดDataGridViewTextBoxColumn";
            // 
            // ชอผใชงานDataGridViewTextBoxColumn
            // 
            this.ชอผใชงานDataGridViewTextBoxColumn.DataPropertyName = "ชื่อผู้ใช้งาน";
            this.ชอผใชงานDataGridViewTextBoxColumn.HeaderText = "ชื่อผู้ใช้งาน";
            this.ชอผใชงานDataGridViewTextBoxColumn.Name = "ชอผใชงานDataGridViewTextBoxColumn";
            // 
            // ประเภทผใชงานDataGridViewTextBoxColumn
            // 
            this.ประเภทผใชงานDataGridViewTextBoxColumn.DataPropertyName = "ประเภทผู้ใช้งาน";
            this.ประเภทผใชงานDataGridViewTextBoxColumn.HeaderText = "ประเภทผู้ใช้งาน";
            this.ประเภทผใชงานDataGridViewTextBoxColumn.Name = "ประเภทผใชงานDataGridViewTextBoxColumn";
            // 
            // ผใชงานBindingSource
            // 
            this.ผใชงานBindingSource.DataMember = "ผู้ใช้งาน";
            this.ผใชงานBindingSource.DataSource = this.shopChomChonDataSet8;
            // 
            // shopChomChonDataSet8
            // 
            this.shopChomChonDataSet8.DataSetName = "ShopChomChonDataSet8";
            this.shopChomChonDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(309, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "เปลี่ยนแปลงข้อมูล";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ผู้ใช้งานTableAdapter
            // 
            this.ผู้ใช้งานTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการพนักงาน";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ผใชงานBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopChomChonDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private ShopChomChonDataSet8 shopChomChonDataSet8;
        private System.Windows.Forms.BindingSource ผใชงานBindingSource;
        private ShopChomChonDataSet8TableAdapters.ผู้ใช้งานTableAdapter ผู้ใช้งานTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ไอดDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn พาสเวรดDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ชอผใชงานDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ประเภทผใชงานDataGridViewTextBoxColumn;
    }
}