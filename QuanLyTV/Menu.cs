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
    public partial class Menu : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source=DESKTOP-P3JTV9V;Initial Catalog=qltv;Integrated Security=True");
        public Menu()
        {
            InitializeComponent();
        }


        private void btnQLS_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySach formQLS = new QuanLySach();
            formQLS.ShowDialog();
            this.Close();
        }

        private void btnQLDG_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDocGia formQLDG = new QuanLyDocGia();
            formQLDG.ShowDialog();
            this.Close();
        }

        private void btnQLMT_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyMuonTraSach formQLMT = new QuanLyMuonTraSach();
            formQLMT.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
