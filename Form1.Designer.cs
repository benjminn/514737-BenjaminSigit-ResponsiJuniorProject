namespace Responsi2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtNamaDeveloper = new TextBox();
            cbProyek = new ComboBox();
            cbStatusKontrak = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label6 = new Label();
            txtJumlahBug = new TextBox();
            txtFiturSelesai = new TextBox();
            label7 = new Label();
            label8 = new Label();
            groupBox4 = new GroupBox();
            dgvDeveloper = new DataGridView();
            dgvProyek = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeveloper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 82);
            label2.Name = "label2";
            label2.Size = new Size(297, 23);
            label2.TabIndex = 1;
            label2.Text = "Developer Team Performance Tracker";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNamaDeveloper);
            groupBox1.Controls.Add(cbProyek);
            groupBox1.Controls.Add(cbStatusKontrak);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 124);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNamaDeveloper
            // 
            txtNamaDeveloper.Font = new Font("Calibri", 12F);
            txtNamaDeveloper.Location = new Point(160, 20);
            txtNamaDeveloper.Name = "txtNamaDeveloper";
            txtNamaDeveloper.Size = new Size(188, 27);
            txtNamaDeveloper.TabIndex = 9;
            // 
            // cbProyek
            // 
            cbProyek.Font = new Font("Calibri", 12F);
            cbProyek.FormattingEnabled = true;
            cbProyek.Location = new Point(160, 53);
            cbProyek.Name = "cbProyek";
            cbProyek.Size = new Size(188, 27);
            cbProyek.TabIndex = 8;
            // 
            // cbStatusKontrak
            // 
            cbStatusKontrak.Font = new Font("Calibri", 12F);
            cbStatusKontrak.FormattingEnabled = true;
            cbStatusKontrak.Items.AddRange(new object[] { "Freelance", "Fulltime" });
            cbStatusKontrak.Location = new Point(159, 86);
            cbStatusKontrak.Name = "cbStatusKontrak";
            cbStatusKontrak.Size = new Size(188, 27);
            cbStatusKontrak.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(5, 89);
            label5.Name = "label5";
            label5.Size = new Size(138, 19);
            label5.TabIndex = 6;
            label5.Text = "Status Kontrak        :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(7, 56);
            label4.Name = "label4";
            label4.Size = new Size(136, 19);
            label4.TabIndex = 5;
            label4.Text = "Pilih Proyek            :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(137, 19);
            label3.TabIndex = 4;
            label3.Text = "Nama Developer    :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtJumlahBug);
            groupBox2.Controls.Add(txtFiturSelesai);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(741, 92);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(358, 55);
            label9.Name = "label9";
            label9.Size = new Size(165, 19);
            label9.TabIndex = 13;
            label9.Text = "(Jumlah bug ditemukan)";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 23);
            label6.Name = "label6";
            label6.Size = new Size(164, 19);
            label6.TabIndex = 12;
            label6.Text = "(Jumlah fitur dikerjakan)";
            // 
            // txtJumlahBug
            // 
            txtJumlahBug.Font = new Font("Calibri", 12F);
            txtJumlahBug.Location = new Point(158, 52);
            txtJumlahBug.Name = "txtJumlahBug";
            txtJumlahBug.Size = new Size(188, 27);
            txtJumlahBug.TabIndex = 11;
            // 
            // txtFiturSelesai
            // 
            txtFiturSelesai.Font = new Font("Calibri", 12F);
            txtFiturSelesai.Location = new Point(160, 20);
            txtFiturSelesai.Name = "txtFiturSelesai";
            txtFiturSelesai.Size = new Size(188, 27);
            txtFiturSelesai.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(7, 55);
            label7.Name = "label7";
            label7.Size = new Size(135, 19);
            label7.TabIndex = 5;
            label7.Text = "Jumlah Bug            :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(6, 23);
            label8.Name = "label8";
            label8.Size = new Size(136, 19);
            label8.TabIndex = 4;
            label8.Text = "Fitur Selesai           :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvDeveloper);
            groupBox4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(28, 363);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(741, 194);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "DAFTAR PERFORMA TIM";
            // 
            // dgvDeveloper
            // 
            dgvDeveloper.BackgroundColor = SystemColors.Control;
            dgvDeveloper.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeveloper.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvDeveloper.GridColor = SystemColors.ScrollBar;
            dgvDeveloper.Location = new Point(7, 26);
            dgvDeveloper.Name = "dgvDeveloper";
            dgvDeveloper.Size = new Size(728, 162);
            dgvDeveloper.TabIndex = 0;
            dgvDeveloper.CellContentClick += dgvDeveloper_CellContentClick;
            // 
            // dgvProyek
            // 
            dgvProyek.BackgroundColor = SystemColors.Control;
            dgvProyek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProyek.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProyek.Location = new Point(6, 21);
            dgvProyek.Name = "dgvProyek";
            dgvProyek.Size = new Size(292, 195);
            dgvProyek.TabIndex = 1;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(785, 374);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(304, 45);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightBlue;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(785, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(304, 45);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(785, 476);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(304, 45);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(35, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(439, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvProyek);
            groupBox3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(785, 121);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 222);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "DAFTAR PERFORMA TIM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 574);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnDelete);
            Controls.Add(pictureBox3);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeveloper).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyek).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbStatusKontrak;
        private ComboBox cbProyek;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private TextBox txtNamaDeveloper;
        private TextBox txtJumlahBug;
        private TextBox txtFiturSelesai;
        private Label label6;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dgvDeveloper;
        private DataGridView dgvProyek;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private GroupBox groupBox3;
    }
}
