using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house
{
    public class House : IHOUSE
    {
        private String soNha;

        private String diaChi;

        private String loaiNha;
        public string SoNha{ get { return soNha;}   set { soNha = value; } }
        public string DiaChi { get { return diaChi;} set { diaChi = value; } }
        public string LoaiNha { get { return loaiNha;} set { loaiNha= value; } }

        public House(string soNha, string diaChi, string loaiNha)
        {
            SoNha = soNha;
            DiaChi = diaChi;
            LoaiNha = loaiNha;
        }
        public House() { }
        public virtual void display()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("So nha: " + SoNha);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Loai nha: " + LoaiNha);
        }

        public virtual void input()
        {
            Console.Write("nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.Write("nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("nhap loai nha: ");
            LoaiNha = Console.ReadLine();
        }
    }
}
