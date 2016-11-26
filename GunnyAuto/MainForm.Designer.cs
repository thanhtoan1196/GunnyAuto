namespace GunnyAuto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDame = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.gridBuffDau = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridBuffBuff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBuffDame1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBuffDame2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBuffDame3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBuffDame4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBuffDame5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gridDau = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridBossDame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBossDame1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBossDame2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBossDame3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBossDame4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridBossDame5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageBoss = new System.Windows.Forms.TabPage();
            this.tabPageDangNhap = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbMayChu = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVat = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridAcc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gridNhanVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridAn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageDame.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageDangNhap.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDame);
            this.tabControl1.Controls.Add(this.tabPageBoss);
            this.tabControl1.Controls.Add(this.tabPageDangNhap);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Location = new System.Drawing.Point(3, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDame
            // 
            this.tabPageDame.Controls.Add(this.label1);
            this.tabPageDame.Controls.Add(this.groupBox3);
            this.tabPageDame.Controls.Add(this.groupBox2);
            this.tabPageDame.Location = new System.Drawing.Point(4, 22);
            this.tabPageDame.Name = "tabPageDame";
            this.tabPageDame.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDame.Size = new System.Drawing.Size(290, 298);
            this.tabPageDame.TabIndex = 1;
            this.tabPageDame.Text = "Buff Dame";
            this.tabPageDame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "♥♥Chức năng tự động Buff Dame♥♥";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(6, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 137);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "--> Buff Dame Nhanh";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridBuffDau,
            this.gridBuffBuff,
            this.gridBuffDame1,
            this.gridBuffDame2,
            this.gridBuffDame3,
            this.gridBuffDame4,
            this.gridBuffDame5});
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(272, 112);
            this.dataGridView3.TabIndex = 5;
            // 
            // gridBuffDau
            // 
            this.gridBuffDau.HeaderText = "";
            this.gridBuffDau.Name = "gridBuffDau";
            this.gridBuffDau.ReadOnly = true;
            this.gridBuffDau.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBuffDau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gridBuffDau.Width = 30;
            // 
            // gridBuffBuff
            // 
            this.gridBuffBuff.HeaderText = "Buff";
            this.gridBuffBuff.Name = "gridBuffBuff";
            this.gridBuffBuff.ReadOnly = true;
            this.gridBuffBuff.Width = 50;
            // 
            // gridBuffDame1
            // 
            this.gridBuffDame1.HeaderText = "Dame1";
            this.gridBuffDame1.Name = "gridBuffDame1";
            this.gridBuffDame1.ReadOnly = true;
            this.gridBuffDame1.Width = 50;
            // 
            // gridBuffDame2
            // 
            this.gridBuffDame2.HeaderText = "Dame2";
            this.gridBuffDame2.Name = "gridBuffDame2";
            this.gridBuffDame2.ReadOnly = true;
            this.gridBuffDame2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBuffDame2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridBuffDame2.Width = 50;
            // 
            // gridBuffDame3
            // 
            this.gridBuffDame3.HeaderText = "Dame3";
            this.gridBuffDame3.Name = "gridBuffDame3";
            this.gridBuffDame3.ReadOnly = true;
            this.gridBuffDame3.Width = 50;
            // 
            // gridBuffDame4
            // 
            this.gridBuffDame4.HeaderText = "Dame4";
            this.gridBuffDame4.Name = "gridBuffDame4";
            this.gridBuffDame4.ReadOnly = true;
            this.gridBuffDame4.Width = 50;
            // 
            // gridBuffDame5
            // 
            this.gridBuffDame5.HeaderText = "Dame5";
            this.gridBuffDame5.Name = "gridBuffDame5";
            this.gridBuffDame5.ReadOnly = true;
            this.gridBuffDame5.Width = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(6, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "--> Buff Dame đánh Boss";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridDau,
            this.gridBossDame,
            this.gridBossDame1,
            this.gridBossDame2,
            this.gridBossDame3,
            this.gridBossDame4,
            this.gridBossDame5});
            this.dataGridView2.Location = new System.Drawing.Point(6, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView2.Size = new System.Drawing.Size(272, 110);
            this.dataGridView2.TabIndex = 4;
            // 
            // gridDau
            // 
            this.gridDau.HeaderText = "";
            this.gridDau.Name = "gridDau";
            this.gridDau.ReadOnly = true;
            this.gridDau.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDau.Width = 30;
            // 
            // gridBossDame
            // 
            this.gridBossDame.HeaderText = "Buff";
            this.gridBossDame.Name = "gridBossDame";
            this.gridBossDame.ReadOnly = true;
            this.gridBossDame.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBossDame.Width = 50;
            // 
            // gridBossDame1
            // 
            this.gridBossDame1.HeaderText = "Dame1";
            this.gridBossDame1.Name = "gridBossDame1";
            this.gridBossDame1.ReadOnly = true;
            this.gridBossDame1.Width = 50;
            // 
            // gridBossDame2
            // 
            this.gridBossDame2.HeaderText = "Dame2";
            this.gridBossDame2.Name = "gridBossDame2";
            this.gridBossDame2.ReadOnly = true;
            this.gridBossDame2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBossDame2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gridBossDame2.Width = 50;
            // 
            // gridBossDame3
            // 
            this.gridBossDame3.HeaderText = "Dame3";
            this.gridBossDame3.Name = "gridBossDame3";
            this.gridBossDame3.ReadOnly = true;
            this.gridBossDame3.Width = 50;
            // 
            // gridBossDame4
            // 
            this.gridBossDame4.HeaderText = "Dame4";
            this.gridBossDame4.Name = "gridBossDame4";
            this.gridBossDame4.ReadOnly = true;
            this.gridBossDame4.Width = 50;
            // 
            // gridBossDame5
            // 
            this.gridBossDame5.HeaderText = "Dame5";
            this.gridBossDame5.Name = "gridBossDame5";
            this.gridBossDame5.ReadOnly = true;
            this.gridBossDame5.Width = 50;
            // 
            // tabPageBoss
            // 
            this.tabPageBoss.Location = new System.Drawing.Point(4, 22);
            this.tabPageBoss.Name = "tabPageBoss";
            this.tabPageBoss.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBoss.Size = new System.Drawing.Size(290, 298);
            this.tabPageBoss.TabIndex = 0;
            this.tabPageBoss.Text = "Boss Thế Giới";
            this.tabPageBoss.UseVisualStyleBackColor = true;
            // 
            // tabPageDangNhap
            // 
            this.tabPageDangNhap.Controls.Add(this.groupBox1);
            this.tabPageDangNhap.Location = new System.Drawing.Point(4, 22);
            this.tabPageDangNhap.Name = "tabPageDangNhap";
            this.tabPageDangNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDangNhap.Size = new System.Drawing.Size(290, 298);
            this.tabPageDangNhap.TabIndex = 3;
            this.tabPageDangNhap.Text = "Đăng nhập";
            this.tabPageDangNhap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbMayChu);
            this.groupBox1.Controls.Add(this.txtTenNhanVat);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtTaikhoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý tài khoản";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Lưu tài khoản và mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbMayChu
            // 
            this.cbMayChu.FormattingEnabled = true;
            this.cbMayChu.Items.AddRange(new object[] {
            "Gà Hỏa Long",
            "Gà Hỏa Phụng",
            "Gà Đại Ca",
            "Gà Chịu Chơi",
            "Gà Thả Ga"});
            this.cbMayChu.Location = new System.Drawing.Point(90, 73);
            this.cbMayChu.Name = "cbMayChu";
            this.cbMayChu.Size = new System.Drawing.Size(116, 21);
            this.cbMayChu.TabIndex = 8;
            // 
            // txtTenNhanVat
            // 
            this.txtTenNhanVat.Location = new System.Drawing.Point(90, 99);
            this.txtTenNhanVat.Name = "txtTenNhanVat";
            this.txtTenNhanVat.Size = new System.Drawing.Size(116, 20);
            this.txtTenNhanVat.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(90, 47);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(116, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(90, 24);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(116, 20);
            this.txtTaikhoan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhân vật:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Máy chủ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài khoản:";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(290, 298);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "Giới Thiệu";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ẩn tất cả các game",
            "Thoát tất cả các game",
            "Ẩn xuống khay hệ thống"});
            this.comboBox1.Location = new System.Drawing.Point(63, 469);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Ẩn tất cả các game";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridAcc,
            this.gridNhanVat,
            this.gridTrangThai,
            this.gridAn});
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(298, 134);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gridAcc
            // 
            this.gridAcc.HeaderText = "#";
            this.gridAcc.Name = "gridAcc";
            this.gridAcc.ReadOnly = true;
            this.gridAcc.Width = 30;
            // 
            // gridNhanVat
            // 
            this.gridNhanVat.HeaderText = "Tên Nhân Vật";
            this.gridNhanVat.Name = "gridNhanVat";
            this.gridNhanVat.ReadOnly = true;
            this.gridNhanVat.Width = 120;
            // 
            // gridTrangThai
            // 
            this.gridTrangThai.HeaderText = "Trạng thái";
            this.gridTrangThai.Name = "gridTrangThai";
            this.gridTrangThai.ReadOnly = true;
            // 
            // gridAn
            // 
            this.gridAn.HeaderText = "Ẩn";
            this.gridAn.Name = "gridAn";
            this.gridAn.ReadOnly = true;
            this.gridAn.Width = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gunny-TonyHoang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDame.ResumeLayout(false);
            this.tabPageDame.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageDangNhap.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBoss;
        private System.Windows.Forms.TabPage tabPageDame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridBuffDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBuffBuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBuffDame1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBuffDame2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBuffDame3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBuffDame4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBuffDame5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBossDame;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBossDame1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBossDame2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBossDame3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBossDame4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridBossDame5;
        private System.Windows.Forms.TabPage tabPageDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMayChu;
        private System.Windows.Forms.TextBox txtTenNhanVat;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn gridAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridNhanVat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gridAcc;
    }
}