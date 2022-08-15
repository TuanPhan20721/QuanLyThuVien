
namespace QuanLyTV
{
    partial class QuanLyMuonTraSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.xoatrang = new System.Windows.Forms.Button();
            this.xoa1 = new System.Windows.Forms.Button();
            this.sua1 = new System.Windows.Forms.Button();
            this.them1 = new System.Windows.Forms.Button();
            this.luoi1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.luoi1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(277, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lí Mượn Trả Sách";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "Tổng số quyển sách độc giả đang mượn";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(366, 345);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(44, 13);
            this.l.TabIndex = 59;
            this.l.Text = "soluong";
            // 
            // xoatrang
            // 
            this.xoatrang.Location = new System.Drawing.Point(543, 282);
            this.xoatrang.Name = "xoatrang";
            this.xoatrang.Size = new System.Drawing.Size(75, 32);
            this.xoatrang.TabIndex = 58;
            this.xoatrang.Text = "Xóa Trắng";
            this.xoatrang.UseVisualStyleBackColor = true;
            this.xoatrang.Click += new System.EventHandler(this.xoatrang_Click);
            // 
            // xoa1
            // 
            this.xoa1.Location = new System.Drawing.Point(434, 282);
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(75, 32);
            this.xoa1.TabIndex = 57;
            this.xoa1.Text = "Xóa";
            this.xoa1.UseVisualStyleBackColor = true;
            this.xoa1.Click += new System.EventHandler(this.xoa1_Click);
            // 
            // sua1
            // 
            this.sua1.Location = new System.Drawing.Point(323, 282);
            this.sua1.Name = "sua1";
            this.sua1.Size = new System.Drawing.Size(75, 32);
            this.sua1.TabIndex = 56;
            this.sua1.Text = "Sửa";
            this.sua1.UseVisualStyleBackColor = true;
            this.sua1.Click += new System.EventHandler(this.sua1_Click);
            // 
            // them1
            // 
            this.them1.Location = new System.Drawing.Point(202, 282);
            this.them1.Name = "them1";
            this.them1.Size = new System.Drawing.Size(75, 32);
            this.them1.TabIndex = 55;
            this.them1.Text = "Thêm ";
            this.them1.UseVisualStyleBackColor = true;
            this.them1.Click += new System.EventHandler(this.them1_Click);
            // 
            // luoi1
            // 
            this.luoi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi1.Location = new System.Drawing.Point(12, 370);
            this.luoi1.Name = "luoi1";
            this.luoi1.ReadOnly = true;
            this.luoi1.Size = new System.Drawing.Size(776, 178);
            this.luoi1.TabIndex = 54;
            this.luoi1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi1_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(109, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 52;
            this.label11.Text = "Tình trạng sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(430, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ngày hẹn trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(430, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(442, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(24, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 44;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // txtMaMT
            // 
            this.txtMaMT.Location = new System.Drawing.Point(202, 100);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.Size = new System.Drawing.Size(139, 20);
            this.txtMaMT.TabIndex = 61;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(586, 95);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(139, 20);
            this.txtMaSach.TabIndex = 62;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Location = new System.Drawing.Point(586, 136);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(139, 20);
            this.txtNgayMuon.TabIndex = 63;
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Location = new System.Drawing.Point(586, 184);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(139, 20);
            this.txtNgayTra.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(42, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Mã Thủ Thư";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(202, 189);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(139, 20);
            this.txtMaTT.TabIndex = 67;
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(202, 141);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(139, 20);
            this.txtMaThe.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(42, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Mã Thẻ";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(323, 245);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(224, 20);
            this.txtTinhTrang.TabIndex = 70;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(662, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(126, 38);
            this.btnHome.TabIndex = 71;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // QuanLyMuonTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.txtNgayMuon);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtMaMT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.l);
            this.Controls.Add(this.xoatrang);
            this.Controls.Add(this.xoa1);
            this.Controls.Add(this.sua1);
            this.Controls.Add(this.them1);
            this.Controls.Add(this.luoi1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyMuonTraSach";
            this.Text = "QuanLyMuonTraSach";
            this.Load += new System.EventHandler(this.QuanLyMuonTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luoi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button xoatrang;
        private System.Windows.Forms.Button xoa1;
        private System.Windows.Forms.Button sua1;
        private System.Windows.Forms.Button them1;
        private System.Windows.Forms.DataGridView luoi1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaMT;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnHome;
    }
}