using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class session6 //strings
    {
        static void Main()
        {
            Console.WriteLine("Nhap vao mot chuoi:");
            string input = Console.ReadLine();

            // 1. In chuỗi
            Console.WriteLine("Chuoi: " + input);

            // 2. Tính độ dài chuỗi mà không dùng thư viện
            int length = 0;
            foreach (char c in input) length++;
            Console.WriteLine("Do dai cua chuoi: " + length);

            // 3. Tách các ký tự trong chuỗi
            Console.WriteLine("Cac ki tu trong chuoi:");
            foreach (char c in input) 
            Console.WriteLine(c);

            // 4. In ký tự theo thứ tự ngược
            Console.WriteLine("Cac ki tu theo thu tu nguoc:");
            for (int i = length - 1; i >= 0; i--) 
            Console.Write(input[i]);
            Console.WriteLine();

            // 5. Đếm số lượng từ trong chuỗi
            string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("So luong tu trong chuoi: " + words.Length);

            // 6. So sánh hai chuỗi mà không dùng thư viện
            Console.WriteLine("Nhap chuoi thu 2:");
            string input2 = Console.ReadLine();
            bool areEqual = input.Length == input2.Length;
            if (areEqual)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != input2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Hai chuoi " + (areEqual ? "bang nhau" : "khong bang nhau"));

            // 7. Đếm số chữ cái, chữ số và ký tự đặc biệt
            int chucai = 0, so = 0, dacbiet = 0;
            foreach (char c in input)
            {
                if (char.IsLetter(c)) chucai++;
                else if (char.IsDigit(c)) so++;
                else dacbiet++;
            }
            Console.WriteLine($"Chu cai: {chucai}, Chu so: {so}, Ki tu dac biet: {dacbiet}");

            // 8. Đếm số nguyên âm và phụ âm
            int vowels = 0, consonants = 0;
            foreach (char c in input.ToLower())
            {
                if 
                    ("aeiou".Contains(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
            }
            Console.WriteLine($"Nguyen am: {vowels}, Phu am: {consonants}");

            // 9. Kiểm tra sự tồn tại của chuỗi con
            Console.WriteLine("Nhap chuoi con:");
            string substring = Console.ReadLine();
            bool isSubstringPresent = input.Contains(substring);
            Console.WriteLine("Chuoi con " + (isSubstringPresent ? "co ton tai" : "khong ton tai"));

            // 10. Tìm vị trí chuỗi con
            int position = input.IndexOf(substring);
            Console.WriteLine(position >= 0 ? $"Vi tri chuoi con: {position}" : "khong tim thay chuoi con.");

            // 11. Kiểm tra ký tự có phải là chữ cái và phân loại
            Console.WriteLine("Nhap 1 ki tu de kiem tra:");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (char.IsLetter(ch))
            {
                Console.WriteLine($"Ki tu '{ch}' la chu cai " + (char.IsUpper(ch) ? "hoa" : "thuong"));
            }
            else
            {
                Console.WriteLine($"Ki tu '{ch}' khong phai la chu cai");
            }

            // 12. Đếm số lần xuất hiện của chuỗi con
            int count = 0;
            int index = input.IndexOf(substring);
            while (index != -1)
            {
                count++;
                index = input.IndexOf(substring, index + substring.Length);
            }
            Console.WriteLine($"So lan xuat hien cua chuoi con: {count}");

            // 13. Thêm chuỗi con trước lần xuất hiện đầu tiên
            Console.WriteLine("Nhap chuoi con de chen:");
            string insertString = Console.ReadLine();
            position = input.IndexOf(substring);
            if (position >= 0)
            {
                string newString = input.Substring(0, position) + insertString + input.Substring(position);
                Console.WriteLine("Chuoi moi: " + newString);
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi con de chen.");
            }
        }
    }
}
