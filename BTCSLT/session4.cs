using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class session4 //Function
    {
        static void Main()
        {
            //question01();
            //question01a();
            //question02();
            //question03();
            //question04();
            //question05();
            question06();
        }

        static void question01() //chọn số lớn nhất trong 3 số
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine());

            int max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }

            Console.WriteLine("So lon nhat trong ba so la: " + max);
        }
        static void question01a() //câu 1, yêu cầu có ít nhất 1 giá trị
        {
            Console.WriteLine("Nhap so thu nhat:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai (Enter to skip):");
            string input2 = Console.ReadLine();
            int? num2 = string.IsNullOrEmpty(input2) ? (int?)null : int.Parse(input2);

            Console.WriteLine("Nhap so thu ba (Enter to skip):");
            string input3 = Console.ReadLine();
            int? num3 = string.IsNullOrEmpty(input3) ? (int?)null : int.Parse(input3);

            // Xác định số lớn nhất
            int max = num1;

            if (num2.HasValue && num2 > max)
            {
                max = num2.Value;
            }

            if (num3.HasValue && num3 > max)
            {
                max = num3.Value;
            }

            Console.WriteLine("So lon nhat la: " + max);
        }
        static void question02() //tính giai thừa của 1 số nguyên không âm
        {
            Console.WriteLine("Nhap vao 1 so nguyen khong am:");
             int n = int.Parse(Console.ReadLine());

                if (n< 0)
                {
                    Console.WriteLine("So khong duoc la nguyen am. Vui long chon lai");
                    return;
                }

            int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }

                Console.WriteLine("Giai thua cua " + n + " la: " + result);
        }
        static void question03() //kiểm tra phải số nguyên tố hay không
        {
            Console.WriteLine("Nhap mot so:");
            int a = int.Parse(Console.ReadLine());

            // Kiểm tra số nguyên tố
            if (a < 2)
            {
                Console.WriteLine(a + " khong phai so nguyen to.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(a + " la so nguyen to.");
            }
            else
            {
                Console.WriteLine(a + " khong phai la so nguyen to.");
            }
        }
        static void question04() //In ra tất cả các số nguyên tố nhỏ hơn số đã nhập + In ra N số nguyên tố đầu tiên
        {
            // Kiểm tra số nguyên tố
            bool IsPrime(int number)
            {
                if (number < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            // In ra tất cả các số nguyên tố nhỏ hơn số đã nhập
            void PrintPrimesLessThan(int number)
            {
                Console.WriteLine($"Cac so nguyen to nho hon {number}:");
                for (int i = 2; i < number; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine(); // Xuống dòng sau khi in
            }

            // In ra N số nguyên tố đầu tiên
            void PrintFirstNPrimes(int n)
            {
                Console.WriteLine($"co {n} so nguyen to dau tien:");
                int count = 0;
                int num = 2;

                while (count < n)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                        count++;
                    }
                    num++;
                }
                Console.WriteLine(); // Xuống dòng sau khi in
            }

            // Nhập vào số và gọi hàm
            Console.WriteLine("nhap vao 1 so:");
            int number = int.Parse(Console.ReadLine());
            PrintPrimesLessThan(number);

            Console.WriteLine("nhap vao so luong so nguyen to ban muon in:");
            int n = int.Parse(Console.ReadLine());
            PrintFirstNPrimes(n);
        }
        static void question05()//kiểm tra và in ra tất cả các số hoàn hảo nhỏ hơn 1000
        {
            // Hàm kiểm tra số hoàn hảo
            bool IsPerfect(int number)
            {
                int sum = 0;
                // Tính tổng các ước số của số
                for (int i = 1; i <= number / 2; i++) // Kiểm tra từ 1 đến number/2
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                return sum == number;
            }

            // In ra tất cả các số hoàn hảo nhỏ hơn 1000
            Console.WriteLine("Cac so hoan hao nho hon 1000:");
            for (int i = 2; i < 1000; i++) // Bắt đầu từ 2 vì số 1 không phải là số hoàn hảo
            {
                if (IsPerfect(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); // Xuống dòng sau khi in
        }
        static void question06() //kiểm tra xem một chuỗi có phải là pangram hay không
        {
            bool IsPangram(string str)
            {
                // Chuyển chuỗi về chữ thường để không phân biệt chữ hoa và chữ thường
                str = str.ToLower();
                // Sử dụng một mảng bool để kiểm tra sự xuất hiện của từng chữ cái
                bool[] letterPresent = new bool[26]; // Mảng cho 26 chữ cái

                // Duyệt qua từng ký tự trong chuỗi
                foreach (char c in str)
                {
                    // Kiểm tra xem ký tự có phải là chữ cái không
                    if (c >= 'a' && c <= 'z')
                    {
                        // Đánh dấu rằng chữ cái đã xuất hiện
                        letterPresent[c - 'a'] = true;
                    }
                }

                // Kiểm tra xem tất cả các chữ cái đã xuất hiện chưa
                foreach (bool present in letterPresent)
                {
                    if (!present)
                    {
                        return false; // Nếu có chữ cái chưa xuất hiện, không phải là pangram
                    }
                }

                return true; // Nếu tất cả các chữ cái đều xuất hiện ít nhất một lần
            }

            // Nhập vào chuỗi và kiểm tra
            Console.WriteLine("Nhap vao mot chuoi:");
            string input = Console.ReadLine();

            if (IsPangram(input))
            {
                Console.WriteLine("Day la 1 pangram.");
            }
            else
            {
                Console.WriteLine("Day khong phai la 1 pangram.");
            }
        }
    }
   
}
