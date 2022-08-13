using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTV
{
    class ctQuyenHan
    {
        string manq, quyenhan;
        int nhomQuyen;

        public ctQuyenHan(string manq, string quyenhan, int nhomQuyen)
        {
            this.manq = manq;
            this.quyenhan = quyenhan;
            this.nhomQuyen = nhomQuyen;
        }

        public string Manq { get => manq; set => manq = value; }
        public string Quyenhan { get => quyenhan; set => quyenhan = value; }
        public int NhomQuyen { get => nhomQuyen; set => nhomQuyen = value; }
    }
}
