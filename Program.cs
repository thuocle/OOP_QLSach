using System;
using System.Collections.Generic;
using System.Linq;
namespace QuanLySach
{
    class Program:TaiLieu
    {
        static void Main(string[] args)
        {
            List<TaiLieu> listTL = new List<TaiLieu>();
            do
            {
                Console.WriteLine("-------MENU------\n" +
                    "1. Nhap thong tin\n" +
                    "2. Hien thi thong tin danh sach tai lieu\n" +
                    "3. Tim kiem tai lieu\n" +
                    "0. Thoat\n" +
                    "Moi ban nhap lua chon:");
                int lc = int.Parse(Console.ReadLine());
                switch (lc)
                {
                    case 1:
                        TaiLieu tailieu;
                        Console.WriteLine("=========NHAP==========");
                        Console.WriteLine("Chon loai tai lieu: ");
                        Console.WriteLine("-------MENU------\n" +
                   "a. Sach\n" +
                   "b. Tap chi\n" +
                   "c. Truyen tranh\n" +
                   "Moi ban nhap lua chon:");
                        char op = char.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 'a':
                                {
                                    tailieu = new Sach();
                                    tailieu.NhapThongTin();
                                    listTL.Add(tailieu);
                                }
                                break;
                            case 'b':
                                {
                                    tailieu = new TapChi();
                                    tailieu.NhapThongTin();
                                    listTL.Add(tailieu);
                                }
                                break;
                            case 'c':
                                {
                                    tailieu = new TruyenTranh();
                                    tailieu.NhapThongTin();
                                    listTL.Add(tailieu);
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("-------HIEN THI------");
                        Console.WriteLine("Danh sach tai lieu: ");
                        foreach (TaiLieu taiLieu in listTL)
                        {
                            taiLieu.HienThiThongTin();
                            Console.WriteLine("==============");
                        }
                        break;
                    case 3:

                        Console.WriteLine("-------TIM KIEM------");
                        Console.WriteLine("Moi ban nhap ten tai lieu can tim:");
                        string str = Console.ReadLine();
                        Console.WriteLine("Danh sach tai lieu can tim:");
                        foreach (var item in listTL)
                        {
                            if (item.TenTaiLieu.ToLower().Contains(str.ToLower()))
                            {
                                item.HienThiThongTin();
                            }
                        }
                        Console.WriteLine("============");
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}
