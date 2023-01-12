using house.hanoi;
class Program
{
    static int Main(string[] args)
    {
        ManagerHouse Mhouse = new ManagerHouse();
        int option = 0;
        while(option != 5)
        {
            Console.WriteLine("1. Nhập thông tin n ngôi nhà ở Hà Nội.");
            Console.WriteLine("2. Hiển thị thông tin của n ngôi nhà đó.");
            Console.WriteLine("3. Sắp xếp theo trường địa chỉ và hiển thị thông tin sau khi sắp xếp.");
            Console.WriteLine("4. Tìm kiếm nhà theo địa chỉ nhập vào.");
            Console.WriteLine("5. Thoát.");
            Console.WriteLine("Xin moi lua chon: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Mhouse.nhapThongTinNha();
                    break;
                case 2:
                    Mhouse.hienThiThongTinNha(Mhouse.listHouses);
                    break;
                case 3:
                    Mhouse.sapXep();
                    break;
                case 4:
                    Mhouse.timKiem();
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
        
        return 0;
    }
}
