using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTV
{
    public partial class ThongKe : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source="+ ConstantHelper.ServerName +";Initial Catalog=qltv;Integrated Security=True");
        public ThongKe()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            chkNgay.Enabled = false;
            chkThang.Enabled = false;
            chkNam.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable tableResult = new DataTable();
            if(chkSachChuaTra.Checked == true)
            {
                tableResult = layDanhSachMuonTraNullData("ngayTra");
            }    
            else if(chkSachChuaMuon.Checked == true)
            {
                tableResult = layDanhSachMuonTraNullData("ngayMuon");
            }    
            else if(chkMuonSach.Checked == true)
            {
                if (chkNgay.Checked == true)
                {
                    string ngay = txtNgay.Text;
                    if (ngay.Length == 0 || ngay.Length > 2)
                    {
                        MessageBox.Show("Ngày phải nhiều hơn 0 và ít hơn 3 kí tự");
                        txtNgay.Focus();
                        return;
                    }    
                    tableResult = layDanhSachMuonTraNgay("ngayMuon", ngay);
                }
                if (chkThang.Checked == true)
                {
                    string thang = txtThang.Text;
                    if (thang.Length == 0 || thang.Length > 2)
                    {
                        MessageBox.Show("Tháng phải nhiều hơn 0 và ít hơn 3 kí tự");
                        txtThang.Focus();
                        return;
                    }
                    tableResult = layDanhSachMuonTraThang("ngayMuon", thang);
                }
                if (chkNam.Checked == true)
                {
                    string nam = txtNam.Text;
                    if (nam.Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập năm");
                        txtNam.Focus();
                        return;
                    }
                    tableResult = layDanhSachMuonTraNam("ngayMuon", nam);
                }
                if(dtpNgay.Checked == true)
                {
                    string ngay = dtpNgay.Value.ToString("yyyy/MM/dd");
                    tableResult = layDanhSachMuonTra("ngayMuon", ngay);
                }    
            }    
            else if(chkTraSach.Checked == true)
            {
                if (chkNgay.Checked == true)
                {
                    string ngay = txtNgay.Text;
                    if (ngay.Length == 0 || ngay.Length > 2)
                    {
                        MessageBox.Show("Ngày phải nhiều hơn 0 và ít hơn 3 kí tự");
                        txtNgay.Focus();
                        return;
                    }
                    tableResult = layDanhSachMuonTraNgay("ngayTra", ngay);
                }
                if (chkThang.Checked == true)
                {
                    string thang = txtThang.Text;
                    if (thang.Length == 0 || thang.Length > 2)
                    {
                        MessageBox.Show("Tháng phải nhiều hơn 0 và ít hơn 3 kí tự");
                        txtThang.Focus();
                        return;
                    }
                    tableResult = layDanhSachMuonTraThang("ngayTra", thang);
                }
                if (chkNam.Checked == true)
                {
                    string nam = txtNam.Text;
                    if (nam.Length == 0)
                    {
                        MessageBox.Show("Bạn chưa nhập năm");
                        txtNam.Focus();
                        return;
                    }
                    tableResult = layDanhSachMuonTraNam("ngayTra", nam);
                }
                if (dtpNgay.Checked == true)
                {
                    string ngay = dtpNgay.Value.ToString("yyyy/MM/dd");
                    tableResult = layDanhSachMuonTra("ngayTra", ngay);
                }
            }    
            grvKetQua.DataSource = tableResult;
            styleGridViewSach();
        }
        public DataTable layDanhSachMuonTra(string thongTin, string tuKhoa)
        {
            string StrSQL = "select * from LAY_DANH_SACH_MUON_TRA() where " + thongTin + " = '" + tuKhoa + "'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public DataTable layDanhSachMuonTraNgay(string thongTin, string tuKhoa)
        {
            string StrSQL = "select * from LAY_DANH_SACH_MUON_TRA() where DAY(" + thongTin + ") = '" + tuKhoa + "'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public DataTable layDanhSachMuonTraThang(string thongTin, string tuKhoa)
        {
            string StrSQL = "select * from LAY_DANH_SACH_MUON_TRA() where MONTH(" + thongTin + ") = '" + tuKhoa + "'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public DataTable layDanhSachMuonTraNam(string thongTin, string tuKhoa)
        {
            string StrSQL = "select * from LAY_DANH_SACH_MUON_TRA() where YEAR(" + thongTin + ") = '" + tuKhoa + "'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public DataTable layDanhSachMuonTraNullData(string thongTin)
        {
            string StrSQL = "select * from LAY_DANH_SACH_MUON_TRA() where " + thongTin + " is NULL";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        private void chkNgay_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNgay.Checked == true)
            {
                chkThang.Checked = false;
                chkNam.Checked = false;
                lblNgay.Visible = true;
                txtNgay.Visible = true;
            }
            else
            {
                lblNgay.Visible = false;
                txtNgay.Visible = false;
            }    
            if(chkNgay.Checked == true || chkNam.Checked == true || chkThang.Checked == true)
            {
                dtpNgay.Checked = false;
            }    
            else
            {
                dtpNgay.Checked = true;
            }    
        }

        private void chkThang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThang.Checked == true)
            {
                chkNgay.Checked = false;
                chkNam.Checked = false;
                lblThang.Visible = true;
                txtThang.Visible = true;
            }
            else
            {
                lblThang.Visible = false;
                txtThang.Visible = false;
            }
            if (chkNgay.Checked == true || chkNam.Checked == true || chkThang.Checked == true)
            {
                dtpNgay.Checked = false;
            }
            else
            {
                dtpNgay.Checked = true;
            }
        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked == true)
            {
                chkNgay.Checked = false;
                chkThang.Checked = false;
                lblNam.Visible = true;
                txtNam.Visible = true;
            }
            else
            {
                lblNam.Visible = false;
                txtNam.Visible = false;
            }
            if (chkNgay.Checked == true || chkNam.Checked == true || chkThang.Checked == true)
            {
                dtpNgay.Checked = false;
            }
            else
            {
                dtpNgay.Checked = true;
            }
        }

        private void chkSach_CheckedChanged(object sender, EventArgs e)
        {
            chkSachChuaTra.Checked = false;
        }

        private void chkSachChuaTra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSachChuaTra.Checked == true)
            {
                chkMuonSach.Checked = false;
                chkSachChuaMuon.Checked = false;
                chkTraSach.Checked = false;
                chkNgay.Enabled = false;
                chkThang.Enabled = false;
                chkNam.Enabled = false;
                dtpNgay.Visible = false;
            }
            
        }

        private void chkSachChuaMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSachChuaMuon.Checked == true)
            {
                chkMuonSach.Checked = false;
                chkTraSach.Checked = false;
                chkSachChuaTra.Checked = false;
                chkNgay.Enabled = false;
                chkThang.Enabled = false;
                chkNam.Enabled = false;
                dtpNgay.Visible = false;
            }
        }

        private void chkMuonSach_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMuonSach.Checked == true)
            {
                chkTraSach.Checked = false;
                chkSachChuaMuon.Checked = false;
                chkSachChuaTra.Checked = false;
                chkNgay.Enabled = true;
                chkThang.Enabled = true;
                chkNam.Enabled = true;
                dtpNgay.Visible = true;
            }
            else
            {
                chkNgay.Enabled = false;
                chkThang.Enabled = false;
                chkNam.Enabled = false;
                dtpNgay.Visible = false;
                lblNam.Visible = false;
                txtNam.Visible = false;
                lblNgay.Visible = false;
                txtNgay.Visible = false;
                lblThang.Visible = false;
                txtThang.Visible = false;
            }    
            
        }

        private void chkTraSach_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTraSach.Checked == true)
            {
                chkMuonSach.Checked = false;
                chkSachChuaMuon.Checked = false;
                chkSachChuaTra.Checked = false;
                chkNgay.Enabled = true;
                chkThang.Enabled = true;
                chkNam.Enabled = true;
                dtpNgay.Visible = true;
            }
            else
            {
                chkNgay.Enabled = false;
                chkThang.Enabled = false;
                chkNam.Enabled = false;
                dtpNgay.Visible = false;
                lblNam.Visible = false;
                txtNam.Visible = false;
                lblNgay.Visible = false;
                txtNgay.Visible = false;
                lblThang.Visible = false;
                txtThang.Visible = false;
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        public void styleGridViewSach()
        {
            grvKetQua.Columns["masach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["tensach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["loaisach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["tenTG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["nhaXB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["namXB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["maMT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["mathe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["matt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["ngayMuon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["daTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["ngayTra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grvKetQua.Columns["masach"].HeaderText = "Mã sách";
            grvKetQua.Columns["tensach"].HeaderText = "Tên sách";
            grvKetQua.Columns["loaisach"].HeaderText = "Loại sách";
            grvKetQua.Columns["tenTG"].HeaderText = "Tên tác giả";
            grvKetQua.Columns["nhaXB"].HeaderText = "Nhà xuất bản";
            grvKetQua.Columns["namXB"].HeaderText = "Năm xuất bản";
            grvKetQua.Columns["maMT"].HeaderText = "Mã mượn trả";
            grvKetQua.Columns["mathe"].HeaderText = "Mã thẻ";
            grvKetQua.Columns["matt"].HeaderText = "Mã thủ thư";
            grvKetQua.Columns["ngayMuon"].HeaderText = "Ngày mượn";
            grvKetQua.Columns["daTra"].HeaderText = "Đã trả";
            grvKetQua.Columns["ngayTra"].HeaderText = "Ngày trả";

            grvKetQua.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            grvKetQua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            grvKetQua.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formMenu = new Menu();
            formMenu.ShowDialog();
            this.Close();
        }
    }
}
