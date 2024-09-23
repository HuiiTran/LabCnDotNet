using Bai4;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.Write("Nhập số lượng hình: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhập hình thứ " + (i + 1) + ":");
            Console.Write("1. Hình tròn\n2. Hình ellipse\nChọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập tọa độ tâm (x, y) và bán kính: ");
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(x, y, radius));
                    break;
                case 2:
                    Console.Write("Nhập tọa độ tâm (x, y) và bán kính lớn, bán kính nhỏ: ");
                    x = double.Parse(Console.ReadLine());
                    y = double.Parse(Console.ReadLine());
                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    shapes.Add(new Ellipse(x, y, a, b));
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Diện tích hình: {shape.Area()}");
        }
    }
}