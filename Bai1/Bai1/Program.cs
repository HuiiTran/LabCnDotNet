using Bai1;

class Program
{
    static void Main(string[] args)
    {

        
            
            List<INhanVien> nhanViens = new List<INhanVien>();
            int i = -1;
        Console.WriteLine("Nhap thong tin nhan vien san xuat bam 1");
        Console.WriteLine("Nhap thong tin nhan vien van phong bam 2");
        while (i != 0)
            {
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        NhanVienSanXuat NhanVienTemp = new NhanVienSanXuat();
                        Console.WriteLine("Nhap thong tin nhan vien san xuat:");
                        Console.Write("Nhap Ho va Ten:");
                        NhanVienTemp.Name = Console.ReadLine();

                        Console.Write("Nhap ngay sinh:");
                        NhanVienTemp.DateOfBirth = Console.ReadLine();

                        Console.Write("Nhap luong co ban:");
                        NhanVienTemp.BasicSalary = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Nhap so luong san pham:");
                        NhanVienTemp.ProductQuantity = Convert.ToInt32(Console.ReadLine());

                        NhanVienTemp.Salary = NhanVienTemp.CalSalary();
                        Console.WriteLine("Hoan tat nhap thong tin nhan vien san xuat! Bam 0 de thoat chuong trinh");
                        nhanViens.Add(NhanVienTemp);
                        break;
                    case 2:
                        NhanVienVanPhong NhanVienTemp1 = new NhanVienVanPhong();
                        Console.WriteLine("Nhap thong tin nhan vien san xuat:");
                        Console.Write("Nhap Ho va Ten:");
                        NhanVienTemp1.Name = Console.ReadLine();

                        Console.Write("Nhap ngay sinh:");
                        NhanVienTemp1.DateOfBirth = Console.ReadLine();

                        Console.Write("Nhap so ngay lam viec:");
                        NhanVienTemp1.WorkDays = Convert.ToInt32(Console.ReadLine());

                        NhanVienTemp1.Salary = NhanVienTemp1.CalSalary();
                        Console.WriteLine("Hoan tat nhap thong tin nhan vien van phong! Bam 0 de thoat chuong trinh");
                        nhanViens.Add(NhanVienTemp1);
                        break;
                    default:
                        break;
                }
            }

            foreach(INhanVien nhanVien in nhanViens)
            {
                Console.WriteLine(nhanVien.Name + "," + nhanVien.DateOfBirth + "," + nhanVien.Salary );
            }
            
        
    }
}