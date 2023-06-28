using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class TruyenTranh : TaiLieu
    {
        public DateTime NgayPhatHanh { get; set; }

        public TruyenTranh()
        {
        }

        public TruyenTranh(DateTime ngayPhatHanh)
        {
            NgayPhatHanh = ngayPhatHanh;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Ngay phat hanh: ");
            NgayPhatHanh = DateTime.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ngay phat hanh: {NgayPhatHanh}");
        }
        public override void TimKiemTheoTen(List<TaiLieu> s)
        {
            base.TimKiemTheoTen(s);
        }
    }
}
