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
    public partial class QuanLyMuonTraSach : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-P3JTV9V;Initial Catalog=qltv;Integrated Security=True");

        public QuanLyMuonTraSach()
        {
            InitializeComponent();
        }

        //private void QuanLyMuonTraSach_Load(object sender, EventArgs e)
        //{
        //    hienthiTTTV();
        //    initDataGridView();
        //}
        
        

        
        public void hienthiTTTV()
        {
            strcon.Open();
            string sql = "Select_muonTraSach";
            SqlCommand com = new SqlCommand(sql, strcon);
            //com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            strcon.Close();  // đóng kết nối
            luoi1.DataSource = dt;
        }
        private void initDataGridView()
        {

            luoi1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            luoi1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void setSelectdgvQLTV()
        {
            var row = luoi1.CurrentRow;
            if (row != null)
            {
                var cells = row.Cells;
                txtMaMT.Text = cells[0].Value.ToString().Trim();
                txtMaThe.Text = cells[1].Value.ToString().Trim();
                txtMaTT.Text = cells[2].Value.ToString().Trim();
                txtNgayMuon.Text = cells[3].Value.ToString().Trim();
                txtMaSach.Text = cells[4].Value.ToString().Trim();
                txtTinhTrang.Text = cells[5].Value.ToString().Trim();
                txtNgayTra.Text = cells[6].Value.ToString().Trim();
                
                sua1.Enabled = xoa1.Enabled = true;
                txtMaSach.Enabled = them1.Enabled = false;
            }
        }
        private void _clear()
        {
            sua1.Enabled = xoa1.Enabled = false;
            them1.Enabled = txtMaSach.Enabled = true;
            //txtMaMT.Focus();
            txtMaMT.Clear();
            txtMaThe.Clear();
            txtMaTT.Clear();
            txtNgayMuon.Clear();
            txtMaSach.Focus();
            txtMaSach.Clear();
            txtTinhTrang.Clear();
            txtNgayTra.Clear();
            
        }

       

        private void btnXoaTrang_Click_1(object sender, EventArgs e)
        {
            _clear();
        }

       

       

        

        

        private void luoi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setSelectdgvQLTV();
        }

        private void them1_Click(object sender, EventArgs e)
        {
            strcon.Open();
            string sqlInsert = "Insert INTO muonTraSach VALUES(@maMT,@mathe,@matt,@NgayMuon,@masach,@daTra,@ngayTra)";
            //string sqlInsert = "Insert_muonTraSach";
            SqlCommand com = new SqlCommand(sqlInsert, strcon);
            //com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@maMT", SqlDbType.NVarChar).Value = txtMaMT.Text;
            com.Parameters.Add("@mathe", SqlDbType.NVarChar).Value = txtMaThe.Text;
            com.Parameters.Add("@matt", SqlDbType.NVarChar).Value = txtMaTT.Text;
            com.Parameters.Add("@ngayMuon", SqlDbType.NVarChar).Value = txtNgayMuon.Text;
            com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = txtMaSach.Text;
            com.Parameters.Add("@daTra", SqlDbType.NVarChar).Value = txtTinhTrang.Text;
            com.Parameters.Add("@ngayTra", SqlDbType.NVarChar).Value = txtNgayTra.Text;

            com.ExecuteNonQuery();
             strcon.Close();
            // đóng kết nối
            hienthiTTTV();

        }

        private void sua1_Click(object sender, EventArgs e)
        {
            strcon.Open();
            string sqlEdit = "update  muonTraSach SET maMT = @maMT,mathe = @mathe,@matt,ngayMuon = @NgayMuon,daTra = @daTra, ngayTra = @ngayTra where masach = @masach";
            //string sqlEdit = "Update_muonTraSach";
            SqlCommand com = new SqlCommand(sqlEdit, strcon);
            //com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@maMT", SqlDbType.NVarChar).Value = txtMaMT.Text;
            com.Parameters.Add("@mathe", SqlDbType.NVarChar).Value = txtMaThe.Text;
            com.Parameters.Add("@matt", SqlDbType.NVarChar).Value = txtMaTT.Text;
            com.Parameters.Add("@ngayMuon", SqlDbType.NVarChar).Value = txtNgayMuon.Text;
            com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = txtMaSach.Text;
            com.Parameters.Add("@daTra", SqlDbType.NVarChar).Value = txtTinhTrang.Text;
            com.Parameters.Add("@ngayTra", SqlDbType.NVarChar).Value = txtNgayTra.Text;
            com.ExecuteNonQuery();
            strcon.Close();  // đóng kết nối
            hienthiTTTV();
        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            strcon.Open();
            string sqlDELETE = "delete FROM muonTraSach where masach = @masach";
            //string sqlDELETE = "delete_muonTraSach";
            SqlCommand com = new SqlCommand(sqlDELETE, strcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@maMT", SqlDbType.NVarChar).Value = txtMaMT.Text;
            com.Parameters.Add("@mathe", SqlDbType.NVarChar).Value = txtMaThe.Text;
            com.Parameters.Add("@matt", SqlDbType.NVarChar).Value = txtMaTT.Text;
            com.Parameters.Add("@ngayMuon", SqlDbType.NVarChar).Value = txtNgayMuon.Text;
            com.Parameters.Add("@masach", SqlDbType.NVarChar).Value = txtMaSach.Text;
            com.Parameters.Add("@daTra", SqlDbType.NVarChar).Value = txtTinhTrang.Text;
            com.Parameters.Add("@ngayTra", SqlDbType.NVarChar).Value = txtNgayTra.Text;
            com.ExecuteNonQuery();
            strcon.Close();
            hienthiTTTV();
        }
        private void QuanLyMuonTraSach_Load(object sender, EventArgs e)
        {
            hienthiTTTV();
            initDataGridView();
        }

        private void xoatrang_Click(object sender, EventArgs e)
        {
            _clear();
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
