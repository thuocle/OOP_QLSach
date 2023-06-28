using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
     public class TapChi:TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }

        public TapChi()
        {
        }

        public TapChi(int soPhatHanh, int thangPhatHanh)
        {
            SoPhatHanh = soPhatHanh;
            ThangPhatHanh = thangPhatHanh;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("So phat hanh: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Thang phat hanh: ");
            ThangPhatHanh = int.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"So phat hanh: {SoPhatHanh}\n" +
                $"Thang phat hanh: {ThangPhatHanh}");
        }

        public override void TimKiemTheoTen(List<TaiLieu> s)
        {
            base.TimKiemTheoTen(s);
        }
    }
}
