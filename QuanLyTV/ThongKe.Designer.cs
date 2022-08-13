
namespace QuanLyTV
{
    partial class ThongKe
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grvKetQua = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.chkTraSach = new System.Windows.Forms.CheckBox();
            this.chkSachChuaMuon = new System.Windows.Forms.CheckBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.chkSachChuaTra = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.chkThang = new System.Windows.Forms.CheckBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.chkNgay = new System.Windows.Forms.CheckBox();
            this.chkMuonSach = new System.Windows.Forms.CheckBox();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Vollkorn", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(487, -81);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 77);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Thống kê";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vollkorn", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 77);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thống kê";
            // 
            // grvKetQua
            // 
            this.grvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvKetQua.Location = new System.Drawing.Point(14, 262);
            this.grvKetQua.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grvKetQua.Name = "grvKetQua";
            this.grvKetQua.RowHeadersWidth = 51;
            this.grvKetQua.RowTemplate.Height = 24;
            this.grvKetQua.Size = new System.Drawing.Size(1324, 444);
            this.grvKetQua.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.chkTraSach);
            this.groupBox1.Controls.Add(this.chkSachChuaMuon);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.lblNam);
            this.groupBox1.Controls.Add(this.txtThang);
            this.groupBox1.Controls.Add(this.lblThang);
            this.groupBox1.Controls.Add(this.txtNgay);
            this.groupBox1.Controls.Add(this.lblNgay);
            this.groupBox1.Controls.Add(this.chkSachChuaTra);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.chkThang);
            this.groupBox1.Controls.Add(this.chkNam);
            this.groupBox1.Controls.Add(this.chkNgay);
            this.groupBox1.Controls.Add(this.chkMuonSach);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo";
            // 
            // dtpNgay
            // 
            this.dtpNgay.Checked = false;
            this.dtpNgay.Location = new System.Drawing.Point(813, 32);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.ShowCheckBox = true;
            this.dtpNgay.Size = new System.Drawing.Size(356, 35);
            this.dtpNgay.TabIndex = 25;
            this.dtpNgay.Visible = false;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // chkTraSach
            // 
            this.chkTraSach.AutoSize = true;
            this.chkTraSach.Location = new System.Drawing.Point(619, 34);
            this.chkTraSach.Name = "chkTraSach";
            this.chkTraSach.Size = new System.Drawing.Size(110, 36);
            this.chkTraSach.TabIndex = 24;
            this.chkTraSach.Text = "Trả sách";
            this.chkTraSach.UseVisualStyleBackColor = true;
            this.chkTraSach.CheckedChanged += new System.EventHandler(this.chkTraSach_CheckedChanged);
            // 
            // chkSachChuaMuon
            // 
            this.chkSachChuaMuon.AutoSize = true;
            this.chkSachChuaMuon.Location = new System.Drawing.Point(205, 34);
            this.chkSachChuaMuon.Name = "chkSachChuaMuon";
            this.chkSachChuaMuon.Size = new System.Drawing.Size(183, 36);
            this.chkSachChuaMuon.TabIndex = 23;
            this.chkSachChuaMuon.Text = "Sách chưa mượn";
            this.chkSachChuaMuon.UseVisualStyleBackColor = true;
            this.chkSachChuaMuon.CheckedChanged += new System.EventHandler(this.chkSachChuaMuon_CheckedChanged);
            // 
            // txtNam
            // 
            this.txtNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNam.Location = new System.Drawing.Point(867, 74);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(83, 35);
            this.txtNam.TabIndex = 22;
            this.txtNam.Visible = false;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(807, 77);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(58, 32);
            this.lblNam.TabIndex = 21;
            this.lblNam.Text = "Năm";
            this.lblNam.Visible = false;
            // 
            // txtThang
            // 
            this.txtThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThang.Location = new System.Drawing.Point(768, 74);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(31, 35);
            this.txtThang.TabIndex = 20;
            this.txtThang.Visible = false;
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(692, 77);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(71, 32);
            this.lblThang.TabIndex = 19;
            this.lblThang.Text = "Tháng";
            this.lblThang.Visible = false;
            // 
            // txtNgay
            // 
            this.txtNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgay.Location = new System.Drawing.Point(656, 74);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(31, 35);
            this.txtNgay.TabIndex = 18;
            this.txtNgay.Visible = false;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(592, 77);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(60, 32);
            this.lblNgay.TabIndex = 17;
            this.lblNgay.Text = "Ngày";
            this.lblNgay.Visible = false;
            // 
            // chkSachChuaTra
            // 
            this.chkSachChuaTra.AutoSize = true;
            this.chkSachChuaTra.Location = new System.Drawing.Point(6, 34);
            this.chkSachChuaTra.Name = "chkSachChuaTra";
            this.chkSachChuaTra.Size = new System.Drawing.Size(155, 36);
            this.chkSachChuaTra.TabIndex = 16;
            this.chkSachChuaTra.Text = "Sách chưa trả";
            this.chkSachChuaTra.UseVisualStyleBackColor = true;
            this.chkSachChuaTra.CheckedChanged += new System.EventHandler(this.chkSachChuaTra_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1039, 74);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(210, 39);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Thống kê";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // chkThang
            // 
            this.chkThang.AutoSize = true;
            this.chkThang.Location = new System.Drawing.Point(205, 76);
            this.chkThang.Name = "chkThang";
            this.chkThang.Size = new System.Drawing.Size(93, 36);
            this.chkThang.TabIndex = 5;
            this.chkThang.Text = "Tháng";
            this.chkThang.UseVisualStyleBackColor = true;
            this.chkThang.CheckedChanged += new System.EventHandler(this.chkThang_CheckedChanged);
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(422, 76);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(80, 36);
            this.chkNam.TabIndex = 3;
            this.chkNam.Text = "Năm";
            this.chkNam.UseVisualStyleBackColor = true;
            this.chkNam.CheckedChanged += new System.EventHandler(this.chkNam_CheckedChanged);
            // 
            // chkNgay
            // 
            this.chkNgay.AutoSize = true;
            this.chkNgay.Location = new System.Drawing.Point(6, 76);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Size = new System.Drawing.Size(82, 36);
            this.chkNgay.TabIndex = 2;
            this.chkNgay.Text = "Ngày";
            this.chkNgay.UseVisualStyleBackColor = true;
            this.chkNgay.CheckedChanged += new System.EventHandler(this.chkNgay_CheckedChanged);
            // 
            // chkMuonSach
            // 
            this.chkMuonSach.AutoSize = true;
            this.chkMuonSach.Location = new System.Drawing.Point(422, 34);
            this.chkMuonSach.Name = "chkMuonSach";
            this.chkMuonSach.Size = new System.Drawing.Size(135, 36);
            this.chkMuonSach.TabIndex = 1;
            this.chkMuonSach.Text = "Mượn sách";
            this.chkMuonSach.UseVisualStyleBackColor = true;
            this.chkMuonSach.CheckedChanged += new System.EventHandler(this.chkMuonSach_CheckedChanged);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1167, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(169, 55);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.grvKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Vollkorn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkThang;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.CheckBox chkNgay;
        private System.Windows.Forms.CheckBox chkMuonSach;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.CheckBox chkSachChuaTra;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.CheckBox chkTraSach;
        private System.Windows.Forms.CheckBox chkSachChuaMuon;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Button btnHome;
    }
}