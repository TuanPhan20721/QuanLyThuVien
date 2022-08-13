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
    public partial class Login : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-P3JTV9V;Initial Catalog=qltv;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            strcon.Open();
            string sql = "select * from nguoidung where tenDangNhap ='" + txtTK.Text +"' and matKhau = '"+txtPass.Text+"'";
            SqlCommand com = new SqlCommand(sql, strcon);
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            strcon.Close();
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                Menu formMenu = new Menu();
                formMenu.ShowDialog();
                this.Close();
            }else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
