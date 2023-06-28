using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public class Sach : TaiLieu
    {
        public string TenTacGia { get; set; }
        public int SoTrang { get; set; }

        public Sach()
        {
        }

        public Sach(string tenTacGia, int soTrang)
        {
            TenTacGia = tenTacGia;
            SoTrang = soTrang;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Ten Tac Gia:");
            TenTacGia = Console.ReadLine();
            Console.Write("So Trang:");
            SoTrang= int.Parse(Console.ReadLine());
        }

        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ten tac gia: {TenTacGia}\n" +
                $"So trang: {SoTrang}");
        }

        public override void TimKiemTheoTen(List<TaiLieu> s)
        {
            base.TimKiemTheoTen(s);
        }
    }
}
