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
    public partial class QuanLyDocGia : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-P3JTV9V;Initial Catalog=qltv;Integrated Security=True");
        public QuanLyDocGia()
        {
            InitializeComponent();
        }
        public void hienthidocgia()
        {
            strcon.Open();
            string sql = "Select_DocGia";
            SqlCommand com = new SqlCommand(sql, strcon);
            //com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            strcon.Close();  // đóng kết nối
            gridDocGia.DataSource = dt;
        }
        private void initDataGridView()
        {

            gridDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void setSelectdgvQLTV()
        {
            var row = gridDocGia.CurrentRow;
            if (row != null)
            {
                var cells = row.Cells;
                txtmadg.Text = cells[0].Value.ToString().Trim();
                txttendg.Text = cells[1].Value.ToString().Trim();
                txtngaysinh.Text = cells[2].Value.ToString().Trim();
                txtcmt.Text = cells[3].Value.ToString().Trim();
                txtsdt.Text = cells[4].Value.ToString().Trim();
                txtdiachi.Text = cells[5].Value.ToString().Trim();
                txtmathe.Text = cells[6].Value.ToString().Trim();
                btnSua.Enabled = btnXoa.Enabled = true;
                txtmadg.Enabled = btnThem.Enabled = false;
            }
        }

        private void QuanLyDocGia_Load(object sender, EventArgs e)
        {
            hienthidocgia();
            initDataGridView();
        }

        private void gridDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setSelectdgvQLTV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            strcon.Open();
            string sql = "Insert_DocGia";
            SqlCommand com = new SqlCommand(sql, strcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@madg", SqlDbType.NVarChar).Value = txtmadg.Text;
            com.Parameters.Add("@tendg", SqlDbType.NVarChar).Value = txttendg.Text;
            com.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = txtngaysinh.Text;
            com.Parameters.Add("@socmt", SqlDbType.NVarChar).Value = txtcmt.Text;
            com.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txtsdt.Text;
            com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtdiachi.Text;
            com.Parameters.Add("@mathe", SqlDbType.NVarChar).Value = txtmathe.Text;
            com.ExecuteNonQuery();
            strcon.Close();  // đóng kết nối
            hienthidocgia();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            strcon.Open();
            string sql = "Update_docgia";
            SqlCommand com = new SqlCommand(sql, strcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@madg", SqlDbType.NVarChar).Value = txtmadg.Text;
            com.Parameters.Add("@tendg", SqlDbType.NVarChar).Value = txttendg.Text;
            com.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = txtngaysinh.Text;
            com.Parameters.Add("@socmt", SqlDbType.NVarChar).Value = txtcmt.Text;
            com.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txtsdt.Text;
            com.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtdiachi.Text;
            com.Parameters.Add("@mathe", SqlDbType.NVarChar).Value = txtmathe.Text;
            com.ExecuteNonQuery();
            strcon.Close();  // đóng kết nối
            hienthidocgia();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            strcon.Open();
            string sql = "delete_docgia";
            SqlCommand com = new SqlCommand(sql, strcon);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@madg", txtmadg.Text);
            com.ExecuteNonQuery();
            strcon.Close();
            _clear();
            hienthidocgia();
        }

        private void btnXoatrang_Click(object sender, EventArgs e)
        {
            _clear();
        }
        private void _clear()
        {
            btnSua.Enabled = btnXoa.Enabled = false;
            btnThem.Enabled = txtmadg.Enabled = true;
            txtmadg.Focus();
            txtmadg.Clear();
            txttendg.Clear();
            txtngaysinh.Clear();
            txtcmt.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtmathe.Clear();
        }
    }
}
