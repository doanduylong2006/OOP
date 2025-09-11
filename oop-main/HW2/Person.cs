using System;
using System.Text;

class Person
{
    // Thuộc tính
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public double Luong { get; set; }

    // Constructor
    public Person(string hoTen, string diaChi, double luong)
    {
        HoTen = hoTen;
        DiaChi = diaChi;
        Luong = luong;
    }

    // Hàm nhập thông tin (có kiểm tra hợp lệ)
    public static Person NhapThongTin()
    {
        Console.WriteLine("Nhập thông tin của một người:");
        Console.Write("Họ và tên: ");
        string hoTen = Console.ReadLine();

        Console.Write("Địa chỉ: ");
        string diaChi = Console.ReadLine();

        double luong = 0;
        while (true)
        {
            try
            {
                Console.Write("Lương: ");
                string sLuong = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(sLuong))
                {
                    throw new Exception(" Bạn phải nhập lương.");
                }

                if (!double.TryParse(sLuong, out luong))
                {
                    throw new Exception(" Lương phải là một số.");
                }

                if (luong <= 0)
                {
                    throw new Exception(" Lương phải lớn hơn 0.");
                }

                break; // nhập hợp lệ thì thoát vòng lặp
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        return new Person(hoTen, diaChi, luong);
    }

    // Hàm hiển thị thông tin
    public void HienThiThongTin()
    {
        Console.WriteLine("Thông tin người:");
        Console.WriteLine($"Họ và tên: {HoTen}");
        Console.WriteLine($"Địa chỉ: {DiaChi}");
        Console.WriteLine($"Lương: {Luong}");
    }

    // Hàm sắp xếp theo lương (Bubble Sort)
    public static void SapXepTheoLuong(Person[] ds)
    {
        if (ds == null || ds.Length == 0)
        {
            Console.WriteLine(" Không có dữ liệu để sắp xếp.");
            return;
        }

        for (int i = 0; i < ds.Length - 1; i++)
        {
            for (int j = 0; j < ds.Length - i - 1; j++)
            {
                if (ds[j].Luong > ds[j + 1].Luong)
                {
                    Person temp = ds[j];
                    ds[j] = ds[j + 1];
                    ds[j + 1] = temp;
                }
            }
        }
    }
}

class QuanLyNguoi
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;


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

        // Sắp xếp
        Person.SapXepTheoLuong(danhSach);

        Console.WriteLine("\n--- Thông tin sau khi sắp xếp (theo lương tăng dần) ---");
        foreach (Person p in danhSach)
        {
            p.HienThiThongTin();
        }

        Console.ReadKey();
    }
}
