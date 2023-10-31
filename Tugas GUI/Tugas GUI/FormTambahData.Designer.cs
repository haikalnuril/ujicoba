namespace Tugas_GUI
{
    partial class FormTambahData
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
            label1 = new Label();
            btnSimpan = new Button();
            btnBatal = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            dateTime = new DateTimePicker();
            cbProdi = new ComboBox();
            tbNo = new TextBox();
            tbTL = new TextBox();
            tbIPK = new TextBox();
            tbNIM = new TextBox();
            tbNama = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NP-B", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(261, 13);
            label1.Name = "label1";
            label1.Size = new Size(238, 26);
            label1.TabIndex = 1;
            label1.Text = "Tambah Data Baru";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(685, 434);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 2;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Tomato;
            btnBatal.Location = new Point(567, 434);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 3;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 4;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(54, 27);
            label3.TabIndex = 5;
            label3.Text = "NIM";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(43, 27);
            label4.TabIndex = 6;
            label4.Text = "IPK";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(140, 27);
            label5.TabIndex = 7;
            label5.Text = "Tanggal Lahir";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 227);
            label6.Name = "label6";
            label6.Size = new Size(136, 27);
            label6.TabIndex = 8;
            label6.Text = "Tempat Lahir";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 320);
            label7.Name = "label7";
            label7.Size = new Size(63, 27);
            label7.TabIndex = 9;
            label7.Text = "Prodi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 368);
            label8.Name = "label8";
            label8.Size = new Size(97, 27);
            label8.TabIndex = 10;
            label8.Text = "No. Telp.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(158, 81);
            label9.Name = "label9";
            label9.Size = new Size(12, 20);
            label9.TabIndex = 11;
            label9.Text = ":";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(158, 126);
            label10.Name = "label10";
            label10.Size = new Size(12, 20);
            label10.TabIndex = 12;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(158, 180);
            label11.Name = "label11";
            label11.Size = new Size(12, 20);
            label11.TabIndex = 13;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(158, 325);
            label12.Name = "label12";
            label12.Size = new Size(12, 20);
            label12.TabIndex = 14;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(158, 373);
            label13.Name = "label13";
            label13.Size = new Size(12, 20);
            label13.TabIndex = 15;
            label13.Text = ":";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(158, 232);
            label14.Name = "label14";
            label14.Size = new Size(12, 20);
            label14.TabIndex = 16;
            label14.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(158, 283);
            label15.Name = "label15";
            label15.Size = new Size(12, 20);
            label15.TabIndex = 17;
            label15.Text = ":";
            // 
            // dateTime
            // 
            dateTime.Location = new Point(176, 278);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(250, 27);
            dateTime.TabIndex = 18;
            // 
            // cbProdi
            // 
            cbProdi.FormattingEnabled = true;
            cbProdi.Items.AddRange(new object[] { "AGRIKULTUR", "KESEHATAN", "EKONOMI", "PARIWISATA" });
            cbProdi.Location = new Point(176, 322);
            cbProdi.Name = "cbProdi";
            cbProdi.Size = new Size(151, 28);
            cbProdi.TabIndex = 19;
            // 
            // tbNo
            // 
            tbNo.Location = new Point(176, 370);
            tbNo.Name = "tbNo";
            tbNo.Size = new Size(250, 27);
            tbNo.TabIndex = 20;
            // 
            // tbTL
            // 
            tbTL.Location = new Point(176, 229);
            tbTL.Name = "tbTL";
            tbTL.Size = new Size(151, 27);
            tbTL.TabIndex = 21;
            // 
            // tbIPK
            // 
            tbIPK.Location = new Point(176, 173);
            tbIPK.Name = "tbIPK";
            tbIPK.Size = new Size(65, 27);
            tbIPK.TabIndex = 22;
            // 
            // tbNIM
            // 
            tbNIM.Location = new Point(176, 119);
            tbNIM.Name = "tbNIM";
            tbNIM.Size = new Size(250, 27);
            tbNIM.TabIndex = 23;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(176, 76);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(387, 27);
            tbNama.TabIndex = 24;
            // 
            // FormTambahData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(tbNama);
            Controls.Add(tbNIM);
            Controls.Add(tbIPK);
            Controls.Add(tbTL);
            Controls.Add(tbNo);
            Controls.Add(cbProdi);
            Controls.Add(dateTime);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label1);
            Name = "FormTambahData";
            Text = "FormTambahData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private DateTimePicker dateTime;
        private ComboBox cbProdi;
        private TextBox tbNo;
        private TextBox tbTL;
        private TextBox tbIPK;
        private TextBox tbNIM;
        private TextBox tbNama;
    }
}