using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    public class ManagerHouse 
    {
       public ManagerHouse() { }

        public List<HaNoiHouse> listHouses = new List<HaNoiHouse>();

        public void nhapThongTinNha()
        {
            HaNoiHouse newHN = new HaNoiHouse();
            newHN.input();
            listHouses.Add(newHN);
        }

        public void hienThiThongTinNha(List<HaNoiHouse> listHouses)
        {
            listHouses.ForEach(house => house.display());
        }
        public void sapXep()
        {
            listHouses.Sort((s1,s2) => s1.DiaChi.CompareTo(s2.DiaChi));
            hienThiThongTinNha(listHouses);
        }
        public void timKiem()
        {
            List<HaNoiHouse> results = new List<HaNoiHouse>();

            Console.Write("Nhap dia chi can tim kiem: ");
            string seach = Console.ReadLine();
            listHouses.ForEach((house) => {
                if(house.DiaChi.ToLower().Contains(seach.ToLower()))
                {
                    results.Add(house);
                }
            });
            hienThiThongTinNha(results);
        }
     
    }
}
