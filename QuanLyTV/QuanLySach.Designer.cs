
namespace QuanLyTV
{
    partial class QuanLySach
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQLS = new System.Windows.Forms.DataGridView();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtLoaiSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(244, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Quản lý sách";
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(83, 209);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrang.TabIndex = 43;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(378, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(511, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 41;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(42, 248);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 40;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(226, 209);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQLS
            // 
            this.dgvQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masach,
            this.tensach,
            this.loaisach,
            this.tenTG,
            this.nhaXB,
            this.namXB});
            this.dgvQLS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQLS.Location = new System.Drawing.Point(0, 277);
            this.dgvQLS.Name = "dgvQLS";
            this.dgvQLS.ReadOnly = true;
            this.dgvQLS.RowHeadersWidth = 45;
            this.dgvQLS.Size = new System.Drawing.Size(647, 150);
            this.dgvQLS.TabIndex = 38;
            this.dgvQLS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLS_CellClick);
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "masach";
            this.Masach.HeaderText = "Mã sách";
            this.Masach.Name = "Masach";
            this.Masach.ReadOnly = true;
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            this.tensach.ReadOnly = true;
            // 
            // loaisach
            // 
            this.loaisach.DataPropertyName = "loaisach";
            this.loaisach.HeaderText = "Loại Sách";
            this.loaisach.Name = "loaisach";
            this.loaisach.ReadOnly = true;
            // 
            // tenTG
            // 
            this.tenTG.DataPropertyName = "tenTG";
            this.tenTG.HeaderText = "Tên Tác Giả";
            this.tenTG.Name = "tenTG";
            this.tenTG.ReadOnly = true;
            // 
            // nhaXB
            // 
            this.nhaXB.DataPropertyName = "nhaXB";
            this.nhaXB.HeaderText = "Nhà XB";
            this.nhaXB.Name = "nhaXB";
            this.nhaXB.ReadOnly = true;
            // 
            // namXB
            // 
            this.namXB.DataPropertyName = "namXB";
            this.namXB.HeaderText = "Năm XB";
            this.namXB.Name = "namXB";
            this.namXB.ReadOnly = true;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(397, 134);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(118, 20);
            this.txtNamXB.TabIndex = 37;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(397, 86);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(118, 20);
            this.txtNhaXB.TabIndex = 36;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(397, 30);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(118, 20);
            this.txtTenTG.TabIndex = 35;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(82, 134);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(126, 20);
            this.txtTenSach.TabIndex = 34;
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.Location = new System.Drawing.Point(82, 86);
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.Size = new System.Drawing.Size(126, 20);
            this.txtLoaiSach.TabIndex = 33;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(82, 30);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(126, 20);
            this.txtMaSach.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tên tác giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nhà XB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Năm XB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Loại sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã sách";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(138, 250);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(175, 20);
            this.txtTimKiem.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNamXB);
            this.groupBox1.Controls.Add(this.txtNhaXB);
            this.groupBox1.Controls.Add(this.txtTenTG);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.txtLoaiSach);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 166);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(530, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(87, 29);
            this.btnHome.TabIndex = 48;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 427);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvQLS);
            this.Name = "QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQLS;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtLoaiSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXB;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHome;
    }
}

