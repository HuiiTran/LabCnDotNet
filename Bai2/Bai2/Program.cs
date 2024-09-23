using Bai2;

class Program
{
    static void Main(string[] args)
    {



        List<IObject> Object_S = new List<IObject>();
        int i = -1;
        Console.WriteLine("Nhap thong tin sinh vien bam 1");
        Console.WriteLine("Nhap thong tin hoc sinh bam 2");
        Console.WriteLine("Nhap thong tin cong nha bam 3");
        Console.WriteLine("Nhap thong tin nghe si bam 4");
        Console.WriteLine("Nhap thong tin ca si bam 5");
        while (i != 0)
        {
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    SinhVien objectTemp = new SinhVien();
                    Console.WriteLine("Nhap thong tin sinh vien:");
                    Console.Write("Nhap Ho va Ten:");
                    objectTemp.Name = Console.ReadLine();

                    Console.Write("Nhap ngay sinh:");
                    objectTemp.DateOfBirth = Console.ReadLine();

                    Console.Write("Nhap dia chi:");
                    objectTemp.Address = Console.ReadLine();

                    Console.Write("Nhap gioi tinh:");
                    objectTemp.Gender = Console.ReadLine();

                    Console.Write("Nhap nam thu:");
                    objectTemp.Years = Console.ReadLine();

                    Console.Write("Nhap nien khoa:");
                    objectTemp.Academic_Year = Console.ReadLine();

                    Console.Write("Nhap truong:");
                    objectTemp.School = Console.ReadLine();

                    Console.Write("Nhap nganh hoc:");
                    objectTemp.Field_of_Study = Console.ReadLine();

                    Console.WriteLine("Hoan tat nhap thong tin ! Bam 0 de thoat chuong trinh");
                    Console.WriteLine(objectTemp.Name + "," + objectTemp.DateOfBirth + "," + objectTemp.Address + "," + objectTemp.Gender + "," + objectTemp.Years + "," + objectTemp.Academic_Year + "," + objectTemp.School + "," + objectTemp.Field_of_Study);
                    Object_S.Add(objectTemp);
                    break;
                case 2:
                    HocSinh objectTemp1 = new HocSinh();
                    Console.WriteLine("Nhap thong tin hoc sinh:");
                    Console.Write("Nhap Ho va Ten:");
                    objectTemp1.Name = Console.ReadLine();

                    Console.Write("Nhap ngay sinh:");
                    objectTemp1.DateOfBirth = Console.ReadLine();

                    Console.Write("Nhap dia chi:");
                    objectTemp1.Address = Console.ReadLine();

                    Console.Write("Nhap gioi tinh:");
                    objectTemp1.Gender = Console.ReadLine();

                    Console.Write("Nhap truong:");
                    objectTemp1.School = Console.ReadLine();

                    Console.Write("Nhap lop hoc:");
                    objectTemp1.Class = Console.ReadLine();

                    Console.WriteLine("Hoan tat nhap thong tin ! Bam 0 de thoat chuong trinh");
                    Console.WriteLine(objectTemp1.Name + "," + objectTemp1.DateOfBirth + "," + objectTemp1.Address + "," + objectTemp1.Gender + ","+ objectTemp1.School + "," + objectTemp1.Class);

                    Object_S.Add(objectTemp1);
                    break;
                case 3:
                    {
                        CongNhan objectTemp2 = new CongNhan();
                        Console.WriteLine("Nhap thong tin cong nhan:");
                        Console.Write("Nhap Ho va Ten:");
                        objectTemp2.Name = Console.ReadLine();

                        Console.Write("Nhap ngay sinh:");
                        objectTemp2.DateOfBirth = Console.ReadLine();

                        Console.Write("Nhap dia chi:");
                        objectTemp2.Address = Console.ReadLine();

                        Console.Write("Nhap gioi tinh:");
                        objectTemp2.Gender = Console.ReadLine();

                        Console.Write("Nhap dia chi lam viec:");
                        objectTemp2.WorkAddress = Console.ReadLine();

                        Console.Write("Nhap luong:");
                        objectTemp2.Salary = Console.ReadLine();

                        Console.WriteLine("Hoan tat nhap thong tin ! Bam 0 de thoat chuong trinh");
                        Console.WriteLine(objectTemp2.Name + "," + objectTemp2.DateOfBirth + "," + objectTemp2.Address + "," + objectTemp2.Gender + "," + objectTemp2.WorkAddress + "," + objectTemp2.Salary);
                        Object_S.Add(objectTemp2);
                        break;
                    }
                case 4:
                    {
                        NgheSi objectTemp2 = new NgheSi();
                        Console.WriteLine("Nhap thong tin nghe si:");
                        Console.Write("Nhap Ho va Ten:");
                        objectTemp2.Name = Console.ReadLine();

                        Console.Write("Nhap ngay sinh:");
                        objectTemp2.DateOfBirth = Console.ReadLine();

                        Console.Write("Nhap dia chi:");
                        objectTemp2.Address = Console.ReadLine();

                        Console.Write("Nhap gioi tinh:");
                        objectTemp2.Gender = Console.ReadLine();

                        Console.Write("Nhap nghe danh:");
                        objectTemp2.Pseudonym = Console.ReadLine();

                        Console.Write("Nhap linh vuc chuyen mon:");
                        objectTemp2.Field = Console.ReadLine();

                        Console.WriteLine("Hoan tat nhap thong tin ! Bam 0 de thoat chuong trinh");
                        Console.WriteLine(objectTemp2.Name + "," + objectTemp2.DateOfBirth + "," + objectTemp2.Address + "," + objectTemp2.Gender + "," + objectTemp2.Pseudonym + "," + objectTemp2.Field);

                        Object_S.Add(objectTemp2);
                        break;
                    }
                case 5:
                    {
                        CaSi objectTemp2 = new CaSi();
                        Console.WriteLine("Nhap thong tin ca si:");
                        Console.Write("Nhap Ho va Ten:");
                        objectTemp2.Name = Console.ReadLine();

                        Console.Write("Nhap ngay sinh:");
                        objectTemp2.DateOfBirth = Console.ReadLine();

                        Console.Write("Nhap dia chi:");
                        objectTemp2.Address = Console.ReadLine();

                        Console.Write("Nhap gioi tinh:");
                        objectTemp2.Gender = Console.ReadLine();

                        Console.Write("Nhap nghe danh:");
                        objectTemp2.Pseudonym = Console.ReadLine();

                        Console.Write("Nhap linh vuc chuyen mon:");
                        objectTemp2.Field = Console.ReadLine();

                        Console.WriteLine("Hoan tat nhap thong tin ! Bam 0 de thoat chuong trinh");
                        Console.WriteLine(objectTemp2.Name + "," + objectTemp2.DateOfBirth + "," + objectTemp2.Address + "," + objectTemp2.Gender + "," + objectTemp2.Pseudonym + "," + objectTemp2.Field);

                        Object_S.Add(objectTemp2);
                        break;
                    }
                default:
                    break;
            }
        }

        


    }
}