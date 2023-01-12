using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    public class HaNoiHouse : House
    {
        private String tenQuan;
        public string TenQuan
        {
            get { return tenQuan; }
            set { tenQuan = value; }
        }
        public HaNoiHouse() { }
        public HaNoiHouse(string soNha, string diaChi, string loaiNha,string tenQuan) : base(soNha, diaChi, loaiNha)
        {
            TenQuan = tenQuan;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Ten Quan: " + TenQuan);
            Console.WriteLine("\n");
        }

        public override void input()
        { 
            base.input();
            Console.Write("nhap Ten Quan: ");
            TenQuan = Console.ReadLine();
        }
    }
}
