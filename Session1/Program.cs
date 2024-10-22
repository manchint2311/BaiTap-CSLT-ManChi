using System;

class Session1
{
    static void Main()
    {
        //question1();
        //question2();
        //question3();
        //question4();
        //question5();
        //question6();
        //question7();
        //question8();
        //question9();
        question10();
    }
    static void question1() //cộng 2 số
    {
        Console.Write("nhap so a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("nhap so b: ");
        int b = int.Parse(Console.ReadLine());

        int tong = a + b;
        Console.WriteLine("a + b = " + tong);
    }

    static void question2() //hoán đổi 2 số
    {
        Console.Write("nhap so a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("nhap so b: ");
        int b = int.Parse(Console.ReadLine());
        int hoandoi = a;
        a = b;
        b = hoandoi;

        Console.WriteLine($"sau khi hoan doi: a = {a}, b = {b}");
    }

    static void question3() //nhân 2 số thực
    {
        Console.Write("nhap so a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("nhap so b: ");
        float b = float.Parse(Console.ReadLine());
        float tich = a * b;
        Console.WriteLine("a * b = " + tich);
    }
    static void question4() //ft -> meter
    {
        Console.Write("nhap do dai (ft): ");
        float a = float.Parse(Console.ReadLine());
        float b = a * 0.3048f;
        Console.WriteLine(a + "ft = " + b + "m");
    }

    static void question5() //độ F -> độ C
    {

        Console.Write("nhap nhiet do (F): ");
        float f = float.Parse(Console.ReadLine());

        float c = (f - 32) * 5 / 9;

        Console.WriteLine($"{f}°F = {c}°C");
    }
    static void question6() //kích thước của các kiểu dữ liệu
    {
        Console.WriteLine($"int: {sizeof(int)} bytes");
        Console.WriteLine($"float: {sizeof(float)} bytes");
        Console.WriteLine($"double: {sizeof(double)} bytes");
        Console.WriteLine($"char: {sizeof(char)} bytes");
        Console.WriteLine($"bool: {sizeof(bool)} byte");
    }
    static void question7() //in giá trị ASCII của kí tự

    {
        Console.Write("nhap 1 ki tu: ");
        char a = Console.ReadKey().KeyChar;
        Console.WriteLine($"gia tri ASCII cua '{a}' : {(int)a}");
    }

    static void question8() //diện tích hình tròn
    {
        Console.Write("nhap ban kinh: ");
        float r = float.Parse(Console.ReadLine());

        float s = (float)(Math.PI * r * r);

        Console.WriteLine($"dien tich hinh tron: {s:F2}");
    }

    static void question9() //diện tích hình vuông
    {
        Console.Write("nhap do dai canh: ");
        float a = float.Parse(Console.ReadLine());
        float s = a * a;
        Console.WriteLine($"dien tich hinh vuong: {s}");
    }
    static void question10() //tính số ngày tuần năm
    {
        Console.Write("nhap so ngay: ");
        int total = int.Parse(Console.ReadLine());

        int nam = total / 365;
        int ngayconlai = total % 365;
        int tuan = ngayconlai / 7;
        int ngay = ngayconlai % 7;

        Console.WriteLine($"{total} ngay = {nam} nam, {tuan} tuan va {ngay} ngay");
    }
}
