namespace BaiLinQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            MaSp = new DataGridViewTextBoxColumn();
            TenSp = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            XuatXu = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 300);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(102, 196);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(102, 153);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 27);
            textBox6.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(434, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(831, 300);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSp, TenSp, SoLuong, DonGia, XuatXu, NgayHetHan });
            dataGridView1.Location = new Point(16, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 188);
            dataGridView1.TabIndex = 6;
            // 
            // MaSp
            // 
            MaSp.HeaderText = "Mã SP";
            MaSp.MinimumWidth = 6;
            MaSp.Name = "MaSp";
            MaSp.Width = 125;
            // 
            // TenSp
            // 
            TenSp.HeaderText = "Tên SP";
            TenSp.MinimumWidth = 6;
            TenSp.Name = "TenSp";
            TenSp.Width = 125;
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.Width = 125;
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            DonGia.Width = 125;
            // 
            // XuatXu
            // 
            XuatXu.HeaderText = "Xuất xứ";
            XuatXu.MinimumWidth = 6;
            XuatXu.Name = "XuatXu";
            XuatXu.Width = 125;
            // 
            // NgayHetHan
            // 
            NgayHetHan.HeaderText = "Ngày hết hạn";
            NgayHetHan.MinimumWidth = 6;
            NgayHetHan.Name = "NgayHetHan";
            NgayHetHan.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 483);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaSp;
        private DataGridViewTextBoxColumn TenSp;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn XuatXu;
        private DataGridViewTextBoxColumn NgayHetHan;
    }
}
