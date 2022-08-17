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
    public partial class QuanLySach : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-P3JTV9V;Initial Catalog=qltv;Integrated Security=True");
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienthiTTTV();
            initDataGridView();
        }
        public void hienthiTTTV()
        {
            strcon.Open();// Mở kết nối
            string sql = "Select_Sach";// lưu đường dẫn
            SqlCommand com = new SqlCommand(sql, strcon);// tạo đối tượng thực thi sql
            com.CommandType = CommandType.StoredProcedure;// store procedure
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve da 
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            strcon.Close();  // đóng kết nối
            dgvQLS.DataSource = dt;
        }
        private void initDataGridView()
        {
            dgvQLS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // hiển thị auto size column
            dgvQLS.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // chọn full row
        }
        private void dgvQLS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setSelectdgvQLTV();
        }
        private void setSelectdgvQLTV()
        {
            var row = dgvQLS.CurrentRow;
            if (row != null)
            {
                var cells = row.Cells;
                txtMaSach.Text = cells[0].Value.ToString().Trim();
                txtTenSach.Text = cells[1].Value.ToString().Trim();
                txtLoaiSach.Text = cells[2].Value.ToString().Trim();
                txtTenTG.Text = cells[3].Value.ToString().Trim();
                txtNhaXB.Text = cells[4].Value.ToString().Trim();
                txtNamXB.Text = cells[5].Value.ToString().Trim();
                btnSua.Enabled = btnXoa.Enabled = true;
                txtMaSach.Enabled = btnThem.Enabled = false;
            }
        }
       
        private void btnXoaTrang_Click_1(object sender, EventArgs e)
        {
            _clear();
        }
        private void _clear()
        {
            btnSua.Enabled = btnXoa.Enabled = false;
            btnThem.Enabled = txtMaSach.Enabled = true;
            txtMaSach.Focus();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtLoaiSach.Clear();
            txtTenTG.Clear();
            txtNhaXB.Clear();
            txtNamXB.Clear();
        }
        // Thêm thông tin sách
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                strcon.Open();
                string sql = "Insert_sach";
                SqlCommand com = new SqlCommand(sql, strcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = txtMaSach.Text;
                com.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = txtTenSach.Text;
                com.Parameters.Add("@loaisach", SqlDbType.NVarChar).Value = txtLoaiSach.Text;
                com.Parameters.Add("@tenTG", SqlDbType.NVarChar).Value = txtTenTG.Text;
                com.Parameters.Add("@nhaXB", SqlDbType.NVarChar).Value = txtNhaXB.Text;
                com.Parameters.Add("@namXB", SqlDbType.DateTime).Value = txtNamXB.Text;
                com.ExecuteNonQuery();
                strcon.Close();  // đóng kết nối
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                hienthiTTTV();
            }
              
            catch (Exception)
            {
                MessageBox.Show("Không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        //Xóa sách
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                strcon.Open();
                string sql = "delete_sach";
                SqlCommand com = new SqlCommand(sql, strcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@masach", txtMaSach.Text);
                com.ExecuteNonQuery();
                strcon.Close();
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                hienthiTTTV();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
           
        }
        // sửa thông tin sách
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                strcon.Open();
                string sql = "Update_sach";
                SqlCommand com = new SqlCommand(sql, strcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = txtMaSach.Text;
                com.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = txtTenSach.Text;
                com.Parameters.Add("@loaisach", SqlDbType.NVarChar).Value = txtLoaiSach.Text;
                com.Parameters.Add("@tenTG", SqlDbType.NVarChar).Value = txtTenTG.Text;
                com.Parameters.Add("@nhaXB", SqlDbType.NVarChar).Value = txtNhaXB.Text;
                com.Parameters.Add("@namXB", SqlDbType.DateTime).Value = txtNamXB.Text;
                com.ExecuteNonQuery();
                strcon.Close();  // đóng kết nối
                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                hienthiTTTV();
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }
        // tìm kiếm sách
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
                strcon.Open();
                string sql = "search_sach";
                SqlCommand com = new SqlCommand(sql, strcon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                com.Parameters.Add("@tensach", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                com.Parameters.Add("@loaisach", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                com.Parameters.Add("@tenTG", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                com.Parameters.Add("@nhaXB", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                com.Parameters.Add("@namXB", SqlDbType.NVarChar).Value = txtTimKiem.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                strcon.Close();  // đóng kết nối
                dgvQLS.DataSource = dt;
                txtTimKiem.Clear();
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
