using System;

class Program
{
    static void Main(string[] args)
    {
        Person[] danhSach = new Person[3];

        // Nhập thông tin 3 người
        for (int i = 0; i < 3; i++)
        {
            danhSach[i] = Person.NhapThongTin();
        }

        Console.WriteLine("\n--- Thông tin trước khi sắp xếp ---");
        foreach (Person p in danhSach)
        {
            p.HienThiThongTin();
        }

        // Sắp xếp theo lương tăng dần
        Person.SapXepTheoLuong(danhSach);

        Console.WriteLine("\n--- Thông tin sau khi sắp xếp (theo lương tăng dần) ---");
        foreach (Person p in danhSach)
        {
            p.HienThiThongTin();
        }

        Console.ReadKey();
    }
}
