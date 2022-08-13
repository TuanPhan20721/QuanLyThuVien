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
    public partial class TimKiem : Form
    {
        SqlConnection strcon = new SqlConnection(@"Data Source="+ ConstantHelper.ServerName +";Initial Catalog=qltv;Integrated Security=True");
        //Bảng
        const string ttv = "theTV";
        //Thủ Thư
        const string matt = "Mã thủ thư";
        const string hoten = "Họ tên";
        const string ngaysinh = "Ngày sinh";
        const string sdt = "Số điện thoại";
        //Thẻ thư viên
        const string mathe = "Mã thẻ";
        const string ngaybd = "Ngày bắt đầu";
        const string ngayhh = "Ngày hết hạn";
        //Sách
        const string masach = "Mã sách";
        const string tensach = "Tên sách";
        const string loaisach = "Loại sách";
        const string tenTG = "Tên tác giả";
        const string nhaXB = "Nhà xuất bản";
        const string namXB = "Năm xuất bản";
        //Đọc giả
        const string madg = "Mã độc giả";
        const string tendg = "Tên độc giả";
        const string soCMT = "Số chứng minh thư";
        const string soDT = "số điện thoại";
        const string diachi = "Địa chỉ";
        public TimKiem()
        {
            InitializeComponent();
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            loadCboBang();
        }
        public void loadCboBang()
        {
            List<string> Bang = new List<string>();
            Bang.Add("Thủ Thư");
            Bang.Add("Sách");
            Bang.Add("Thẻ thư viện");
            Bang.Add("Độc giả");
            cboBang.DataSource = Bang;
        }

        public void loadCboThongTin()
        {
            String Bang = cboBang.SelectedItem.ToString();
            Bang = Bang.Replace(" ", "");
            Bang = NonUnicode(Bang);
            if (Bang == "Thethuvien")
            {
                Bang = ttv;
            }
            string StrSQL = "select * from LAY_TEN_COT(@tenBang)";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            cm.Parameters.Add("@tenBang", Bang);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            cboThongTin.ValueMember = "COLUMN_NAME";
            table = loadCboThongTin_SuaText(table, Bang);
            cboThongTin.DataSource = table;
            cboThongTin.DisplayMember = "COLUMN_NAME";

        }


        public DataTable loadCboThongTin_SuaText(DataTable table, string bang)
        {
            foreach (DataRow row in table.Rows)
            {
                row.BeginEdit();
                row["COLUMN_NAME"] = fillter(row["COLUMN_NAME"].ToString());
                row.EndEdit();
            }
            return table;
        }

        public string fillter(string fillter)
        {
            switch (fillter)
            {
                case "matt":
                    {
                        return matt;
                    }
                case "hoten":
                    {
                        return hoten;
                    }
                case "ngaysinh":
                    {
                        return ngaysinh;
                    }
                case "sdt":
                    {
                        return sdt;
                    }
                case "mathe":
                    {
                        return mathe;
                    }
                case "ngaybd":
                    {
                        return ngaybd;
                    }
                case "ngayhh":
                    {
                        return ngayhh;
                    }
                case "masach":
                    {
                        return masach;
                    }
                case "tensach":
                    {
                        return tensach;
                    }
                case "loaisach":
                    {
                        return loaisach;
                    }
                case "tenTG":
                    {
                        return tenTG;
                    }
                case "nhaXB":
                    {
                        return nhaXB;
                    }
                case "namXB":
                    {
                        return namXB;
                    }
                case "madg":
                    {
                        return madg;
                    }
                case "tendg":
                    {
                        return tendg;
                    }
                case "soCMT":
                    {
                        return soCMT;
                    }
                case "soDT":
                    {
                        return soDT;
                    }
                case "diachi":
                    {
                        return diachi;
                    }
                default:
                    break;
            }
            return fillter;
        }

        public string revertFillter(string fillter)
        {
            switch (fillter)
            {
                case matt:
                    {
                        return "matt";
                    }
                case hoten:
                    {
                        return "hoten";
                    }
                case ngaysinh:
                    {
                        return "ngaysinh";
                    }
                case sdt:
                    {
                        return "sdt";
                    }
                case mathe:
                    {
                        return "mathe";
                    }
                case ngaybd:
                    {
                        return "ngaybd";
                    }
                case ngayhh:
                    {
                        return "ngayhh";
                    }
                case masach:
                    {
                        return "masach";
                    }
                case tensach:
                    {
                        return "tensach";
                    }
                case loaisach:
                    {
                        return "loaisach";
                    }
                case tenTG:
                    {
                        return "tenTG";
                    }
                case nhaXB:
                    {
                        return "nhaXB";
                    }
                case namXB:
                    {
                        return "namXB";
                    }
                case madg:
                    {
                        return "madg";
                    }
                case tendg:
                    {
                        return "tendg";
                    }
                case soCMT:
                    {
                        return "soCMT";
                    }
                case soDT:
                    {
                        return "soDT";
                    }
                case diachi:
                    {
                        return "diachi";
                    }
                default:
                    break;
            }
            return fillter;
        }
        private void cboBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCboThongTin();
            loadGrv();
        }
        public void loadGrv()
        {
            String Bang = cboBang.SelectedItem.ToString();
            Bang = Bang.Replace(" ", "");
            Bang = NonUnicode(Bang);
            DataTable table = new DataTable();
            if (Bang == "ThuThu")
            {
                table = timThuThu(" ", "matt");
                grvKetQua.DataSource = table;
                styleGridViewThuThu();
            }
            if (Bang == "Thethuvien")
            {
                table = timTheThuVien(" ", "mathe");
                grvKetQua.DataSource = table;
                styleGridViewTheThuVien();
            }
            if (Bang == "Sach")
            {
                table = timSach(" ", "masach");
                grvKetQua.DataSource = table;
                styleGridViewSach();
            }
            if (Bang == "Docgia")
            {
                table = timDocGia(" ", "madg");
                grvKetQua.DataSource = table;
                styleGridViewDocGia();
            }
        }
        public string NonUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                "đ",
                "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                "í","ì","ỉ","ĩ","ị",
                "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                "d",
                "e","e","e","e","e","e","e","e","e","e","e",
                "i","i","i","i","i",
                "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                "u","u","u","u","u","u","u","u","u","u","u",
                "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String Bang = cboBang.SelectedItem.ToString();
            Bang = Bang.Replace(" ", "");
            Bang = NonUnicode(Bang);

            string tuKhoa = txtTuKhoa.Text;
            if (tuKhoa == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập " + lblTuKhoa.Text);
                txtTuKhoa.Focus();
                return;
            }

            string thongTin = cboThongTin.SelectedValue.ToString();
            thongTin = revertFillter(thongTin);
            DataTable table = new DataTable();
            if (Bang == "ThuThu")
            {
                table = timThuThu(tuKhoa, thongTin);
                grvKetQua.DataSource = table;
                styleGridViewThuThu();
            }
            if (Bang == "Thethuvien")
            {
                table = timTheThuVien(tuKhoa, thongTin);
                grvKetQua.DataSource = table;
                styleGridViewTheThuVien();
            }
            if (Bang == "Sach")
            {
                table = timSach(tuKhoa, thongTin);
                grvKetQua.DataSource = table;
                styleGridViewSach();
            }
            if (Bang == "Docgia")
            {
                table = timDocGia(tuKhoa, thongTin);
                grvKetQua.DataSource = table;
                styleGridViewDocGia();
            }

        }
        public DataTable timThuThu(string tuKhoa, string thongTin)
        {
            string StrSQL = "select * from TIM_KIEM_THU_THU() where " + thongTin + " like '%" + tuKhoa + "%'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable timSach(string tuKhoa, string thongTin)
        {
            string StrSQL = "select * from TIM_KIEM_SACH() where " + thongTin + " like '%" + tuKhoa + "%'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable timDocGia(string tuKhoa, string thongTin)
        {
            string StrSQL = "select * from TIM_KIEM_DOC_GIA() where " + thongTin + " like '%" + tuKhoa + "%'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable timTheThuVien(string tuKhoa, string thongTin)
        {
            string StrSQL = "select * from TIM_KIEM_THE_THU_VIEN() where " + thongTin + " like '%" + tuKhoa + "%'";
            SqlCommand cm = new SqlCommand(StrSQL, strcon);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public void styleGridViewThuThu()
        {
            grvKetQua.Columns["matt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["hoten"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["ngaysinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["sdt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grvKetQua.Columns["matt"].HeaderText = "Mã thủ thư";
            grvKetQua.Columns["hoten"].HeaderText = "Họ tên";
            grvKetQua.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            grvKetQua.Columns["sdt"].HeaderText = "Số điện thoại";

            grvKetQua.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            grvKetQua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            grvKetQua.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        public void styleGridViewSach()
        {
            grvKetQua.Columns["masach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["tensach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["loaisach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["tenTG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["nhaXB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["namXB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grvKetQua.Columns["masach"].HeaderText = "Mã sách";
            grvKetQua.Columns["tensach"].HeaderText = "Tên sách";
            grvKetQua.Columns["loaisach"].HeaderText = "Loại sách";
            grvKetQua.Columns["tenTG"].HeaderText = "Tên tác giả";
            grvKetQua.Columns["nhaXB"].HeaderText = "Nhà xuất bản";
            grvKetQua.Columns["namXB"].HeaderText = "Năm xuất bản";

            grvKetQua.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            grvKetQua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            grvKetQua.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        public void styleGridViewDocGia()
        {
            grvKetQua.Columns["madg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["tendg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["ngaysinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["soCMT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["soDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["diachi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["mathe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            grvKetQua.Columns["madg"].HeaderText = "Mã độc giả";
            grvKetQua.Columns["tendg"].HeaderText = "Tên độc giả";
            grvKetQua.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            grvKetQua.Columns["soCMT"].HeaderText = "Số chứng minh thư";
            grvKetQua.Columns["soDT"].HeaderText = "Số điện thoại";
            grvKetQua.Columns["diachi"].HeaderText = "Địa chỉ";
            grvKetQua.Columns["mathe"].HeaderText = "Mã thẻ";

            grvKetQua.EnableHeadersVisualStyles = false; //Bắt buộc phải có dòng này!
            grvKetQua.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.ColumnHeadersDefaultCellStyle.ForeColor = Color.Green;
            grvKetQua.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        public void styleGridViewTheThuVien()
        {
            grvKetQua.Columns["mathe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["ngaybd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvKetQua.Columns["ngayhh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grvKetQua.Columns["mathe"].HeaderText = "Mã thẻ";
            grvKetQua.Columns["ngaybd"].HeaderText = "Ngày bắt đầu";
            grvKetQua.Columns["ngayhh"].HeaderText = "Ngày kết thúc";

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
