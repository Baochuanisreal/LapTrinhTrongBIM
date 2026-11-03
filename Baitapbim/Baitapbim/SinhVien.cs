using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbim
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public double DTB { get; set; }
        public SinhVien()
        {
            Console.Write("Nhap Ho Ten : ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Que Quan:");
            QueQuan = Console.ReadLine();
            Console.Write("Nhap Diem Toan:");
            Toan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Ly:");
            Ly = double.Parse(Console.ReadLine());
            Console.Write("Nhap Diem Hoa:");
            Hoa = double.Parse(Console.ReadLine());
        }
        public SinhVien(string hoTen, string queQuan, double toan, double ly, double hoa)
        {
            this.HoTen = hoTen;
            this.QueQuan = queQuan;
            this.Toan = toan;
            this.Ly = ly;
            this.Hoa = hoa;
        }
        public void TinhDTB(SinhVien sv1)
        {
            sv1.DTB = (sv1.Toan + sv1.Hoa + sv1.Ly) / 3;
        }
        public void InDanhSach()
        {
            Console.WriteLine("Ho Ten :{HoTen},Que Quan :{QueQuan},Toan:{Toan},Ly :{Ly},Hoa:{Hoa},DTB:{DTB}");
        }




    }
}
