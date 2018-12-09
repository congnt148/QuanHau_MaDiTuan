namespace DA_KTLT
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
            System.Windows.Forms.ColumnHeader lvwSTT;
            this.pnlChessBoart = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxGiaTri = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbxKT2 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKT1 = new System.Windows.Forms.TextBox();
            this.tbxToaDoY = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxToaDoX = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtMaDiTuan = new System.Windows.Forms.RadioButton();
            this.rbtDatQuanHau = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lwvData = new System.Windows.Forms.ListView();
            this.lvwValues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            lvwSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.gbxGiaTri.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwSTT
            // 
            lvwSTT.Text = "STT";
            // 
            // pnlChessBoart
            // 
            this.pnlChessBoart.BackColor = System.Drawing.Color.White;
            this.pnlChessBoart.Location = new System.Drawing.Point(23, 128);
            this.pnlChessBoart.Name = "pnlChessBoart";
            this.pnlChessBoart.Size = new System.Drawing.Size(747, 690);
            this.pnlChessBoart.TabIndex = 0;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEnd.ForeColor = System.Drawing.Color.Black;
            this.btnEnd.Location = new System.Drawing.Point(511, 170);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(108, 50);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "END";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnInfo);
            this.groupBox1.Controls.Add(this.gbxGiaTri);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(793, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khởi tạo";
            // 
            // gbxGiaTri
            // 
            this.gbxGiaTri.Controls.Add(this.btnCreate);
            this.gbxGiaTri.Controls.Add(this.tbxKT2);
            this.gbxGiaTri.Controls.Add(this.label36);
            this.gbxGiaTri.Controls.Add(this.label1);
            this.gbxGiaTri.Controls.Add(this.tbxKT1);
            this.gbxGiaTri.Controls.Add(this.tbxToaDoY);
            this.gbxGiaTri.Controls.Add(this.label18);
            this.gbxGiaTri.Controls.Add(this.label19);
            this.gbxGiaTri.Controls.Add(this.tbxToaDoX);
            this.gbxGiaTri.Location = new System.Drawing.Point(24, 89);
            this.gbxGiaTri.Name = "gbxGiaTri";
            this.gbxGiaTri.Size = new System.Drawing.Size(474, 147);
            this.gbxGiaTri.TabIndex = 1;
            this.gbxGiaTri.TabStop = false;
            this.gbxGiaTri.Text = "Gía trị";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(347, 26);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(114, 95);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbxKT2
            // 
            this.tbxKT2.Enabled = false;
            this.tbxKT2.Location = new System.Drawing.Point(268, 28);
            this.tbxKT2.Name = "tbxKT2";
            this.tbxKT2.Size = new System.Drawing.Size(28, 27);
            this.tbxKT2.TabIndex = 7;
            this.tbxKT2.Text = "8";
            this.tbxKT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label36.Location = new System.Drawing.Point(239, 28);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 27);
            this.label36.TabIndex = 6;
            this.label36.Text = "x";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kích thước bàn cờ:";
            // 
            // tbxKT1
            // 
            this.tbxKT1.Location = new System.Drawing.Point(205, 28);
            this.tbxKT1.Name = "tbxKT1";
            this.tbxKT1.Size = new System.Drawing.Size(28, 27);
            this.tbxKT1.TabIndex = 1;
            this.tbxKT1.Text = "8";
            this.tbxKT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxKT1.TextChanged += new System.EventHandler(this.tbxKT1_TextChanged);
            this.tbxKT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxKT1_KeyPress);
            // 
            // tbxToaDoY
            // 
            this.tbxToaDoY.Location = new System.Drawing.Point(185, 94);
            this.tbxToaDoY.Name = "tbxToaDoY";
            this.tbxToaDoY.Size = new System.Drawing.Size(147, 27);
            this.tbxToaDoY.TabIndex = 5;
            this.tbxToaDoY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxToaDoY.TextChanged += new System.EventHandler(this.tbxToaDoY_TextChanged);
            this.tbxToaDoY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxToaDoY_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 19);
            this.label18.TabIndex = 2;
            this.label18.Text = "Toạ độ X xuất phát:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(13, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "Toạ độ Y xuất phát:";
            // 
            // tbxToaDoX
            // 
            this.tbxToaDoX.Location = new System.Drawing.Point(185, 61);
            this.tbxToaDoX.Name = "tbxToaDoX";
            this.tbxToaDoX.Size = new System.Drawing.Size(147, 27);
            this.tbxToaDoX.TabIndex = 3;
            this.tbxToaDoX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxToaDoX.TextChanged += new System.EventHandler(this.tbxToaDoX_TextChanged);
            this.tbxToaDoX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxToaDoX_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtMaDiTuan);
            this.groupBox3.Controls.Add(this.rbtDatQuanHau);
            this.groupBox3.Location = new System.Drawing.Point(24, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chương trình";
            // 
            // rbtMaDiTuan
            // 
            this.rbtMaDiTuan.AutoSize = true;
            this.rbtMaDiTuan.Location = new System.Drawing.Point(312, 20);
            this.rbtMaDiTuan.Name = "rbtMaDiTuan";
            this.rbtMaDiTuan.Size = new System.Drawing.Size(107, 23);
            this.rbtMaDiTuan.TabIndex = 8;
            this.rbtMaDiTuan.TabStop = true;
            this.rbtMaDiTuan.Text = "Mã đi tuần";
            this.rbtMaDiTuan.UseVisualStyleBackColor = true;
            this.rbtMaDiTuan.CheckedChanged += new System.EventHandler(this.rbtMaDiTuan_CheckedChanged);
            // 
            // rbtDatQuanHau
            // 
            this.rbtDatQuanHau.AutoSize = true;
            this.rbtDatQuanHau.Location = new System.Drawing.Point(134, 20);
            this.rbtDatQuanHau.Name = "rbtDatQuanHau";
            this.rbtDatQuanHau.Size = new System.Drawing.Size(128, 23);
            this.rbtDatQuanHau.TabIndex = 7;
            this.rbtDatQuanHau.TabStop = true;
            this.rbtDatQuanHau.Text = "Đặt quân hậu";
            this.rbtDatQuanHau.UseVisualStyleBackColor = true;
            this.rbtDatQuanHau.CheckedChanged += new System.EventHandler(this.rbtDatQuanHau_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(511, 107);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 50);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lwvData);
            this.groupBox2.Location = new System.Drawing.Point(793, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 427);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cách đi";
            // 
            // lwvData
            // 
            this.lwvData.AutoArrange = false;
            this.lwvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            lvwSTT,
            this.lvwValues});
            this.lwvData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lwvData.FullRowSelect = true;
            this.lwvData.Location = new System.Drawing.Point(6, 21);
            this.lwvData.Name = "lwvData";
            this.lwvData.Size = new System.Drawing.Size(624, 388);
            this.lwvData.TabIndex = 0;
            this.lwvData.UseCompatibleStateImageBehavior = false;
            this.lwvData.View = System.Windows.Forms.View.Details;
            this.lwvData.SelectedIndexChanged += new System.EventHandler(this.lwvData_SelectedIndexChanged);
            // 
            // lvwValues
            // 
            this.lvwValues.Text = "Cách đi";
            this.lvwValues.Width = 550;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1452, 84);
            this.label2.TabIndex = 19;
            this.label2.Text = "ĐẶT QUÂN HẬU VÀ MÃ ĐI TUẦN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.Location = new System.Drawing.Point(511, 46);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(108, 50);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "INFO";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 850);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlChessBoart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ Án Kỹ Thuật Lập Trình";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.gbxGiaTri.ResumeLayout(false);
            this.gbxGiaTri.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKT1;
        private System.Windows.Forms.TextBox tbxToaDoY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxToaDoX;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxGiaTri;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtMaDiTuan;
        private System.Windows.Forms.RadioButton rbtDatQuanHau;
        private System.Windows.Forms.ColumnHeader lvwValues;
        private System.Windows.Forms.TextBox tbxKT2;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnCreate;
        public System.Windows.Forms.ListView lwvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInfo;
    }
}

