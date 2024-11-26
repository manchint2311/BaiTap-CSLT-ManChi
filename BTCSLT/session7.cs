using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class session7 //files
    {
        static void Main()
        {
            //1. Tao file rong va dong lai
            string filePath = "fileRong.txt";
            File.Create(filePath).Close(); 
            Console.WriteLine("Da tao file rong: " + filePath);

            //2. xóa 1 file khỏi ổ đĩa
            string filedelete = "filecanxoa.txt";
                File.Delete(filedelete);
                Console.WriteLine("Da xoa file: " + filedelete);

            //3. tạo file và thêm text
            string fileadd = "fileThemNoiDung.txt";
            Console.WriteLine("Nhap text muon them: ");
            string fileupdate = Console.ReadLine();
            File.WriteAllText(fileupdate, "Day la noi dung cua file."); // Ghi chuoi vao file
            Console.WriteLine("Da tao va ghi noi dung vao file: " + fileadd);

            //4. tạo 1 file văn bản và đọc nội dung
            Console.Write("Nhap ten file can doc: ");
            string fileToRead = Console.ReadLine();
            if (File.Exists(fileToRead))
            {
                string content = File.ReadAllText(fileToRead);
                Console.WriteLine("Noi dung file: \n" + content);
            }
            else
            {
                Console.WriteLine("File khong ton tai.");
            }

            //5.tạo file và add chuỗi
            string filestring = "fileMangChuoi.txt";
            string[] lines = { "Dong 1", "Dong 2", "Dong 3" };

            File.WriteAllLines(filestring, lines); // Ghi tung dong cua mang vao file
            Console.WriteLine("Da ghi mang chuoi vao file.");

            //6.add nội dung vào file có sẵn
            string filethem = "fileThemNoiDung.txt";
            Console.Write("Nhap noi dung de them vao file: ");
            string noidung = Console.ReadLine();
            File.AppendAllText("fileThemNoiDung.txt", "\n" + noidung);
            Console.WriteLine("Da them noi dung vao file.");

            //7.Tao file, sao chep sang file moi va hien thi noi dung
            string file7 = "fileGoc.txt";
            string copiedFile = "fileSaoChep.txt";

            File.WriteAllText(file7, "Noi dung cua file goc."); // Tao file goc
            File.Copy(file7, copiedFile, true); // Sao chep file

            string copiedContent = File.ReadAllText(copiedFile);
            Console.WriteLine("Noi dung file sao chep: " + copiedContent);

            //8. Tao va di chuyen file trong cung thu muc voi ten khac
            string file8 = "fileGocDiChuyen.txt";
            string movedFile = "fileDiChuyen.txt";

            File.WriteAllText(file8, "Noi dung cua file goc."); // Tao file goc
            File.Move(file8, movedFile); // Di chuyen file
            Console.WriteLine("Da di chuyen file thanh: " + movedFile);

            //9. Doc dong dau tien cua file
            File.WriteAllLines("fileMangChuoi.txt", new[] { "Dong 1", "Dong 2", "Dong 3" });
            using (StreamReader reader = new StreamReader("fileMangChuoi.txt"))
            {
                Console.WriteLine("Dong dau tien: " + reader.ReadLine());
            }

            //10. Tao va doc dong cuoi cua file
            File.WriteAllLines("fileDongCuoi.txt", new[] { "Dong 1", "Dong 2", "Dong 3" });
            string[] finallines = File.ReadAllLines("fileDongCuoi.txt");
            Console.WriteLine("Dong cuoi cung: " + finallines[^1]);

            //11. Doc n dong cuoi cua file
            File.WriteAllLines("fileNDongCuoi.txt", new[] { "Dong 1", "Dong 2", "Dong 3", "Dong 4", "Dong 5" });
            Console.Write("Nhap so dong cuoi can doc: ");
            int n = int.Parse(Console.ReadLine());
            string[] linesToRead = File.ReadAllLines("fileNDongCuoi.txt");
            Console.WriteLine($"{n} dong cuoi:");
            for (int i = linesToRead.Length - n; i < linesToRead.Length; i++)
            {
                Console.WriteLine(linesToRead[i]);
            }

            //12.Doc mot dong cu the tu file
            File.WriteAllLines("fileDocDong.txt", new[] { "Dong 1", "Dong 2", "Dong 3" });
            Console.Write("Nhap so thu tu dong can doc: ");
            int lineNumber = int.Parse(Console.ReadLine());
            string[] specificLines = File.ReadAllLines("fileDocDong.txt");
            if (lineNumber > 0 && lineNumber <= specificLines.Length)
            {
                Console.WriteLine($"Dong {lineNumber}: " + specificLines[lineNumber - 1]);
            }
            else
            {
                Console.WriteLine("Dong khong hop le.");
            }

            //13.Dem so dong trong file
            File.WriteAllLines("fileDemDong.txt", new[] { "Dong 1", "Dong 2", "Dong 3" });
            int lineCount = File.ReadAllLines("fileDemDong.txt").Length;
            Console.WriteLine("So dong trong file: " + lineCount);

            //14. In cau truc thu muc
            Directory.CreateDirectory("ThuMucCuaToi");
            File.Create(Path.Combine("ThuMucCuaToi", "file1.txt")).Close();
            File.Create(Path.Combine("ThuMucCuaToi", "file2.txt")).Close();
            string[] files = Directory.GetFiles("ThuMucCuaToi");
            Console.WriteLine("Cau truc thu muc:");
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            //15.Thong ke ky tu va chu so trong file
            File.WriteAllText("fileThongKe.txt", "Hello123!!");
            string textContent = File.ReadAllText("fileThongKe.txt");
            int alphabets = 0, digits = 0, specials = 0;
            foreach (char c in textContent)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specials++;
            }
            Console.WriteLine("Ky tu chu: " + alphabets);
            Console.WriteLine("Chu so: " + digits);
            Console.WriteLine("Ky tu dac biet: " + specials);
        }


    }
}
