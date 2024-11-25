using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class session5 //Arrays
    {
        static void Main()
        {
            //exercise1();
            //exercise2();
            //exercise3();
            //exercise4();
            exercise5();

        }

        static void exercise1() //Single Dimension Array
        {
            // tạo mảng ngẫu nhiên
            int[] array = new int[10]; // Tạo mảng 10 phần tử
            Random random = new Random(); // Khởi tạo đối tượng Random

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20); // Gán số ngẫu nhiên vào từng phần tử
            }
            Console.WriteLine("Mang random: " + string.Join(", ", array));

            // Tính giá trị trung bình
            double average = array.Average();
            Console.WriteLine("Gia tri trung binh: " + average);

            // Kiểm tra giá trị có trong mảng
            Console.WriteLine("Nhap gia tri can kiem tra: ");
            int check = int.Parse(Console.ReadLine()); // Nhập giá trị cần kiểm tra

            bool tonTai = array.Contains(check);
            Console.WriteLine($"gia tri {check} {(tonTai ? "co" : "khong")} ton tai trong mang.");

            // Tìm chỉ số của một giá trị
            Console.WriteLine("Nhap gia tri can tim chi so: ");
            int check2 = int.Parse(Console.ReadLine());
            int index = Array.IndexOf(array, check2);

            if (index != -1)
            {
                Console.WriteLine($"gia tri {check2} nam o chi so {index}.");
            }
            else
            {
                Console.WriteLine($"gia tri {check2} khong ton tai.");
            }

            // Xóa một giá trị khỏi mảng
            Console.WriteLine("Nhap gia tri can xoa: ");
            int delete = int.Parse(Console.ReadLine());
            int[] array1 = array.Where(x => x != delete).ToArray();

            Console.WriteLine($"Mang sau khi xoa gia tri {delete}: " + string.Join(", ", array1));

            // Tìm giá trị lớn nhất và nhỏ nhất
            int max = array.Max();
            int min = array.Min();
            Console.WriteLine($"Gia tri lon nhat: {max} \nGia tri nho nhat: {min}");

            // Đảo ngược mảng
            var array2 = array.Reverse().ToArray();
            Console.WriteLine("Mang sau khi dao nguoc: " + string.Join(", ", array2));

            // Tìm các giá trị trùng lặp
            var trung = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
            Console.WriteLine("cac gia tri trung lap: " + string.Join(", ", trung));

            // 8. Loại bỏ các giá trị trùng lặp
            array = array.Distinct().ToArray();
            Console.WriteLine("Mang sau khi bo cac gia tri trung lap: " + string.Join(", ", array));

        }
        static void exercise2() //Algorithms on Single Dimension Arrays
        {
            // Nhap 10 số nguyên và dùng bubbele sort
            int[] mang = new int[10];
            Console.WriteLine("Nhap 10 so nguyen:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"So thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mang.Length - 1; i++)
                for (int j = 0; j < mang.Length - 1 - i; j++)
                {
                    if (mang[j] > mang[j + 1])
                    {
                        // Hoan doi gia tri
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                    }
                }
            Console.WriteLine("Mang sau khi sap xep: " + string.Join(", ", mang));

            //nhập 1 câu rồi tìm 1 từ có trong đó không
            Console.WriteLine("Nhap mot cau: ");
            string cau = Console.ReadLine();
            Console.Write("Nhap mot tu can tim: ");
            string word = Console.ReadLine();

            // Tach cau thanh cac tu
            string[] tach = cau.Split(' ');
            // Thuc hien tim kiem tuyen tinh
            bool tontai = false;
            foreach (string tu in tach)
            {
                if (tu.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    tontai = true;
                    break;
                }
            }
            if (tontai)
            {
                Console.WriteLine($"Tu \"{word}\" co trong cau.");
            }
            else
            {
                Console.WriteLine($"Tu \"{word}\" khong co trong cau.");
            }

        }
        static void exercise3() //Two-Dimensional Arrays
        {
            // Nhap kich thuoc ma tran
            Console.Write("Nhap so hang N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot M: ");
            int m = int.Parse(Console.ReadLine());

            // Tao ma tran ngau nhien
            int[,] maTran = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    maTran[i, j] = rand.Next(0, 100); // Gia tri ngau nhien tu 0 den 99

            // In ma tran
            Console.WriteLine("Ma tran:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(maTran[i, j] + " ");
                Console.WriteLine();
            }

            // Nhap chi so i
            Console.Write("Nhap chi so i (bat dau tu 0): ");
            int iHangCot = int.Parse(Console.ReadLine());

            // In hang i
            Console.WriteLine($"Hang {iHangCot}:");
            for (int j = 0; j < m; j++)
                Console.Write(maTran[iHangCot, j] + " ");
            Console.WriteLine();

            // In cot i
            Console.WriteLine($"Cot {iHangCot}:");
            for (int i = 0; i < n; i++)
                Console.Write(maTran[i, iHangCot] + " ");
            Console.WriteLine();

            // Tim gia tri lon nhat trong ma tran
            int maxValue = int.MinValue;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (maTran[i, j] > maxValue)
                        maxValue = maTran[i, j];
            Console.WriteLine("Gia tri lon nhat trong ma tran: " + maxValue);

            // Tim gia tri nho nhat trong hang/cot i
            int minHang = int.MaxValue, minCot = int.MaxValue;
            for (int j = 0; j < m; j++)
                if (maTran[iHangCot, j] < minHang)
                    minHang = maTran[iHangCot, j];
            for (int i = 0; i < n; i++)
                if (maTran[i, iHangCot] < minCot)
                    minCot = maTran[i, iHangCot];
            Console.WriteLine($"Gia tri nho nhat trong hang {iHangCot}: " + minHang);
            Console.WriteLine($"Gia tri nho nhat trong cot {iHangCot}: " + minCot);

            // Chuyen vi ma tran
            Console.WriteLine("Ma tran sau khi chuyen vi:");
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(maTran[i, j] + " ");
                Console.WriteLine();
            }

            // In duong cheo chinh
            Console.WriteLine("Duong cheo chinh:");
            for (int i = 0; i < Math.Min(n, m); i++)
                Console.Write(maTran[i, i] + " ");
            Console.WriteLine();

            // In duong cheo phu
            Console.WriteLine("Duong cheo phu:");
            for (int i = 0; i < Math.Min(n, m); i++)
                Console.Write(maTran[i, m - 1 - i] + " ");
            Console.WriteLine();
        }
        static void exercise4() //Jagged Array – exercises 1
        {
            //Tạo mảng jagged cố định
            int[][] jaggedArray1 = new int[][]
            {
            new int[] { 1, 1, 1, 1, 1 },
            new int[] { 2, 2 },
            new int[] { 3, 3, 3, 3 },
            new int[] { 4, 4 }
            };
            Console.WriteLine("Mang jagged khoi tao co dinh:");
            foreach (var row in jaggedArray1)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // Phần 2: Tạo mảng jagged ngẫu nhiên theo đầu vào người dùng
            Console.Write("Nhap so hang cua mang: ");
            int numRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray2 = new int[numRows][];

            Random rand = new Random();
            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Nhap so cot cho hang {i}: ");
                int numCols = int.Parse(Console.ReadLine());
                jaggedArray2[i] = new int[numCols];
                for (int j = 0; j < numCols; j++)
                {
                    jaggedArray2[i][j] = rand.Next(1, 20); // Gia tri ngau nhien tu 1 den 99
                }
            }

            Console.WriteLine("Mang jagged ngau nhien:");
            foreach (var row in jaggedArray2)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            // 1. Tim so lon nhat trong tung hang va trong ca mang
            Console.WriteLine("\nSo lon nhat trong tung hang:");
            int maxOverall = int.MinValue;
            foreach (var row in jaggedArray2)
            {
                int maxInRow = row.Max();
                Console.WriteLine($"Hang: {string.Join(" ", row)} -> Max: {maxInRow}");
                if (maxInRow > maxOverall)
                    maxOverall = maxInRow;
            }
            Console.WriteLine($"So lon nhat trong mang: {maxOverall}");

            // 2. Sap xep tang dan trong tung hang
            Console.WriteLine("\nMang sau khi sap xep tung hang:");
            foreach (var row in jaggedArray2)
            {
                Array.Sort(row);
                Console.WriteLine(string.Join(" ", row));
            }

            // 3. In cac so nguyen to trong mang
            Console.WriteLine("\nCac so nguyen to trong mang:");
            foreach (var row in jaggedArray2)
            {
                foreach (var num in row)
                {
                    if (IsPrime(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            Console.WriteLine();

            // 4. Tim va in tat ca vi tri cua mot so nhap tu nguoi dung
            Console.Write("\nNhap mot so de tim kiem: ");
            int searchValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac vi tri cua so {searchValue}:");
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    if (jaggedArray2[i][j] == searchValue)
                    {
                        Console.WriteLine($"Hang {i}, Cot {j}");
                    }
                }
            }

            // Hàm kiểm tra số nguyên tố
            static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
        }
        static void exercise5() //The X company
        {
            // Khởi tạo mảng jagged với các nhóm và thành viên
            string[][][] nhom = new string[3][][]; 

            // Giá trị khởi tạo trước
            nhom[0] = new string[][]
            {
            new string[] { "101", "An", "15" },
            new string[] { "102", "Bao", "10" },
            new string[] { "103", "Chau", "20" },
            new string[] { "104", "Dai", "8" },
            new string[] { "105", "Binh", "12" }
            };
            nhom[1] = new string[][]
            {
            new string[] { "201", "Nhan", "5" },
            new string[] { "202", "Giang", "7" },
            new string[] { "203", "Han", "9" }
            };
            nhom[2] = new string[][]
            {
            new string[] { "301", "Yen", "13" },
            new string[] { "302", "Nhi", "22" },
            new string[] { "303", "Minh", "11" },
            new string[] { "304", "Loi", "18" },
            new string[] { "305", "Phuc", "6" },
            new string[] { "306", "Xuan", "17" }
            };

            // Menu trong hàm Main
            while (true)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. In danh sach tat ca thanh vien");
                Console.WriteLine("2. Tim thong tin thanh vien bang ID");
                Console.WriteLine("3. Tim thanh vien co so nhiem vu hoan thanh cao nhat");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon mot lua chon: ");
                int luaChon = int.Parse(Console.ReadLine());

                if (luaChon == 1)
                {
                    Console.WriteLine("\nDanh sach thanh vien:");
                    for (int i = 0; i < nhom.Length; i++)
                    {
                        Console.WriteLine($"Nhom {i + 1}:");
                        foreach (var thanhVien in nhom[i])
                        {
                            Console.WriteLine($"ID: {thanhVien[0]}, Ho ten: {thanhVien[1]}, Nhiem vu hoan thanh: {thanhVien[2]}");
                        }
                    }
                }
                else if (luaChon == 2)
                {
                    Console.Write("Nhap ID thanh vien: ");
                    string id = Console.ReadLine();
                    bool timThay = false;

                    foreach (var nhomCon in nhom)
                    {
                        foreach (var thanhVien in nhomCon)
                        {
                            if (thanhVien[0] == id)
                            {
                                Console.WriteLine($"\nThong tin thanh vien:");
                                Console.WriteLine($"ID: {thanhVien[0]}, Ho ten: {thanhVien[1]}, Nhiem vu hoan thanh: {thanhVien[2]}");
                                timThay = true;
                                break;
                            }
                        }
                        if (timThay) break;
                    }

                    if (!timThay) Console.WriteLine("Khong tim thay thanh vien.");
                }
                else if (luaChon == 3)
                {
                    string[] thanhVienMax = null; // [ID, Ho ten, Nhiem vu]
                    foreach (var nhomCon in nhom)
                    {
                        foreach (var thanhVien in nhomCon)
                        {
                            if (thanhVienMax == null || int.Parse(thanhVien[2]) > int.Parse(thanhVienMax[2]))
                            {
                                thanhVienMax = thanhVien;
                            }
                        }
                    }

                    if (thanhVienMax != null)
                    {
                        Console.WriteLine($"\nThanh vien co so nhiem vu hoan thanh cao nhat:");
                        Console.WriteLine($"ID: {thanhVienMax[0]}, Ho ten: {thanhVienMax[1]}, Nhiem vu hoan thanh: {thanhVienMax[2]}");
                    }
                }
                else if (luaChon == 4)
                {
                    Console.WriteLine("End.");
                    break;
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le, vui long thu lai.");
                }
            }
        }
    }
}
    



