using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class exercise2
    {
        static void Main()
        {
            question01();
            //question02();
            //question03();
        }

        static void question01() //độ c sang k sang f
        {
            Console.Write("nhap nhiet do Celsius: ");
            double c = double.Parse(Console.ReadLine());
            double k = c + 273;
            double f = c * 18 / 10 + 32;

            Console.WriteLine($"Kelvin = {k}");
            Console.WriteLine($"Fahrenheit = {f}");
        }

        static void question02() //diện tích bề mặt và thể tích của hình cầu
        {
                Console.Write("nhap ban kinh cua hinh cau: ");
                double bk = Convert.ToDouble(Console.ReadLine());

                double dt = 4 * Math.PI * Math.Pow(bk, 2);
                double tt = (4.0 / 3) * Math.PI * Math.Pow(bk, 3);

                Console.WriteLine($"Dien tich hinh cau = {dt}");
                Console.WriteLine($"The tich hinh cau = {tt}");
        }

        static void question03() //công trừ nhân chia lấy dư
        { 
                // Nhập số thứ nhất từ người dùng
                Console.Write("Nhap so thu nhat: ");
                double a = Convert.ToDouble(Console.ReadLine());

                // Nhập số thứ hai từ người dùng
                Console.Write("Nhap so thu hai: ");
                double b = Convert.ToDouble(Console.ReadLine());

                // Tính toán các phép toán
                double cong = a + b;
                double tru = a - b;
                double nhan = a * b;
                double chia = a / b;
                double du = a % b;

                // Hiển thị kết quả theo định dạng yêu cầu
                Console.WriteLine("Output");
                Console.WriteLine($"• {a} + {b} = {cong}");
                Console.WriteLine($"• {a} - {b} = {tru}");
                Console.WriteLine($"• {a} x {b} = {nhan}");
                Console.WriteLine($"• {a} / {b} = {chia}");
                Console.WriteLine($"• {a} mod {b} = {du}");
        }

    }
}
