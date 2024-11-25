using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class session3 //Operators and Control Flow slides
    {
        static void Main()
        {
            //Operation_quest1();
            //Operation_quest2();
            //Operation_quest3();
            //Operation_quest4();
            //Operation_quest5();
            //CFS_quest1();
            //CFS_quest2();
            //CFS_quest3();
            //CFS_quest4();
            //CFS_quest5();
            //CFS_quest6();
            //CFS_quest7();
            //CFS_quest8();
            //CFS_quest9();
            CFS_quest10();
        }

        static void Operation_quest1() //công trừ nhân chia lấy dư
        {
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double cong = a + b;
            double tru = a - b;
            double nhan = a * b;
            double chia = a / b;
            double du = a % b;

            Console.WriteLine("Output");
            Console.WriteLine($"• {a} + {b} = {cong}");
            Console.WriteLine($"• {a} - {b} = {tru}");
            Console.WriteLine($"• {a} x {b} = {nhan}");
            Console.WriteLine($"• {a} / {b} = {chia}");
            Console.WriteLine($"• {a} mod {b} = {du}");
        }

        static void Operation_quest2() //hiển thị giá trị của hàm 
        {
            Console.WriteLine("gia tri cua ham x = y^2 + 2y + 1 voi y tu -5 den 5:");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }

        static void Operation_quest3() //tính tốc độ từ khoảng cách và thời gian
        {
            Console.Write("nhap khoang cach (km): ");
            double qd = Convert.ToDouble(Console.ReadLine());

            Console.Write("nhap thoi gian (h): ");
            int gio = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap thoi gian (ph): ");
            int phut = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap thoi gian (s): ");
            int giay = Convert.ToInt32(Console.ReadLine());

            double tonggio = gio + (phut / 60.0) + (giay / 3600.0);
            double vantoc1 = qd / tonggio;
            double vantoc2 = vantoc1 * 0.621371;

            Console.WriteLine($"Tốc độ: {vantoc1} km/h hoặc {vantoc2} miles/h");
        }

        static void Operation_quest4() //diện tích bề mặt và thể tích hình cầu
        {
            Console.Write("Nhap ban kinh cua hinh cau: ");
            double bk = Convert.ToDouble(Console.ReadLine());

            double dt = 4 * Math.PI * Math.Pow(bk, 2);
            double tt = (4.0 / 3) * Math.PI * Math.Pow(bk, 3);

            Console.WriteLine($"Dien tich hinh cau = {dt}");
            Console.WriteLine($"The tich hinh cau = {tt}");
        }

        static void Operation_quest5() //kiểm tra kí tự là nguyên âm, chữ số hay kí tự khác
        {
            Console.WriteLine("Nhap 1 ki tu: ");
            char inputChar = Convert.ToChar(Console.ReadLine().ToLower());

            if ("aeiou".Contains(inputChar))
            {
                Console.WriteLine("ki tu la nguyen am.");
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine("ki tu la chu so.");
            }
            else
            {
                Console.WriteLine("ki tu la ki tu khac.");
            }
        }

        static void CFS_quest1() //chương trình kiểm tra số chẵn hay lẻ
        {
            Console.WriteLine("Nhap mot so: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan.");
            }
            else
            {
                Console.WriteLine($"{a} la so le.");
            }
        }

        static void CFS_quest2() //tìm số lớn nhất trong ba số
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int so1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai: ");
            int so2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            int so3 = Convert.ToInt32(Console.ReadLine());

            int lonnhat;

            if (so1 >= so2 && so1 >= so3)
            {
                lonnhat = so1;
            }
            else if (so2 >= so1 && so2 >= so3)
            {
                lonnhat = so2;
            }
            else
            {
                lonnhat = so3;
            }
            Console.WriteLine($"So lon nhat la: {lonnhat}");
        }

        static void CFS_quest3() //xác định tọa độ điểm thuộc góc phần tư nào trên hệ trục tọa độ XY
        {
            Console.Write("Nhap toa do X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap toa do Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu nhat.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu hai.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu ba.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Diem nam o goc phan tu thu tu.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Diem nam tren truc Y.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Diem nam tren truc X.");
            }
            else
            {
                Console.WriteLine("Diem nam o goc toa do (0,0).");
            }
        }

        static void CFS_quest4() //kiểm tra loại tam giác
        {
            Console.WriteLine("Nhap do dai canh 1: ");
            int canh1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap do dai canh 2: ");
            int canh2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap do dai canh 3: ");
            int canh3 = Convert.ToInt32(Console.ReadLine());

            if (canh1 == canh2 && canh2 == canh3)
            {
                Console.WriteLine("tam giac deu.");
            }
            else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
            {
                Console.WriteLine("tam giac can.");
            }
            else
            {
                Console.WriteLine("tam giac thuong.");
            }
        }

        static void CFS_quest5() //tổng và trung bình của 10 số
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Nhap so thu {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            double tbinh = sum / 10.0;
            Console.WriteLine($"Tong = {sum}");
            Console.WriteLine($"Trung binh = {tbinh}");
        }

        static void CFS_quest6() //hiển thị bảng cửu chương của một số nguyên
        {
            Console.WriteLine("Nhap 1 so nguyen: ");
            int so = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{so} x {i} = {so * i}");
            }
        }

        static void CFS_quest7() //hình tam giác số
        {
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }

        static void CFS_quest8() //hiển thị n số hạng đầu tiên của dãy hài hòa và tính tổng của chúng
        {
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;

            Console.Write("Day so hai hoa: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0}", i);
                if (i < n)
                {
                    Console.Write(" + ");
                }

                sum += 1.0 / i; // Tính tổng
            }

            Console.WriteLine();
            Console.WriteLine("Tong cua day hai hoa = " + sum);
        }

        static void CFS_quest9() //tìm các số hoàn hảo trong một khoảng số cho trước
        {
            Console.Write("Nhap so bat dau: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhap so ket thuc: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int sum = 0;

                // Tính tổng các ước của `i` (ngoại trừ chính nó)
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                }

                // Kiểm tra nếu `i` là số hoàn hảo
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void CFS_quest10() //kiểm tra số nguyên tố
        {
            Console.Write("Nhap vao 1 so: ");
            int number = int.Parse(Console.ReadLine());

            bool snt = true;

            if (number <= 1)
            {
                snt = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        snt = false;
                        break;
                    }
                }
            }

            if (snt)
                Console.WriteLine("{0} la so nguyen to.", number);
            else
                Console.WriteLine("{0} khong la so nguyen to.", number);
        }


    } 
}
