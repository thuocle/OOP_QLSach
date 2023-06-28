using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach
{
    public abstract class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }

      public virtual void NhapThongTin()
        {
            Console.Write("Ma Tai Lieu: ");
            MaTaiLieu = Console.ReadLine(); 
            Console.Write("Ten Tai Lieu: ");
            TenTaiLieu = Console.ReadLine(); 
            Console.Write("Ten Nha Xuat Ban: ");
            TenNhaXuatBan = Console.ReadLine(); 
            Console.Write("So Ban Phat Hanh: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Ma tai lieu: {MaTaiLieu}\n" +
                $"Ten tai lieu: {TenTaiLieu}\n" +
                $"Ten NXB: {TenNhaXuatBan}\n" +
                $"So ban phat hanh: {SoBanPhatHanh}");
        }
        public virtual void TimKiemTheoTen(List<TaiLieu> s)
        {
            string str = Console.ReadLine();
            Console.WriteLine("Danh sach tai lieu can tim:");
            foreach (var item in s)
            {
                if (item.TenTaiLieu.ToLower().Contains(str))
                {
                    item.HienThiThongTin();
                }
            }
        }
    }
}
