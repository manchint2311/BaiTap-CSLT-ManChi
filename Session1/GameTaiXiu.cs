using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    using System;

    class Game_TaiXiu
    {
        static int rollDice() //updated
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1; 
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }

        static bool playOneRound(ref int balance)
        {
            int com_dice = rollDice();
            Console.WriteLine($"So tien hien co: {balance}");
            Console.Write("Nhap so tien muon cuoc: ");
            int bet;

            // Kiểm tra số tiền cược có hợp lệ không
            while (!int.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > balance)
            {
                Console.WriteLine("So tien cuoc khong hop le, vui long nhap lai.");
            }

            Console.Write("Ban doan Tai hay Xiu (T/X): ");
            string user_guessing = Console.ReadLine();

            bool win = false;
            if (user_guessing.ToUpper().Equals("T"))
            {
                if (com_dice >= 10) // Tài
                {
                    Console.WriteLine("Ban thang!");
                    balance += bet; // Thắng thì cộng tiền cược vào tài khoản
                    win = true;
                }
                else
                {
                    Console.WriteLine("Ban thua!");
                    balance -= bet; // Thua thì trừ tiền cược khỏi tài khoản
                }
            }
            else if (user_guessing.ToUpper().Equals("X"))
            {
                if (com_dice < 10) // Xỉu
                {
                    Console.WriteLine("Ban thang!");
                    balance += bet;
                    win = true;
                }
                else
                {
                    Console.WriteLine("Ban thua!");
                    balance -= bet;
                }
            }
            else
            {
                Console.WriteLine("Vi lòng chi nhap T hoac X!");
            }

            return win;
        }

        static void game_engine()
        {
            int balance = 1000; // Số tiền ban đầu
            int rounds = 0;
            int wins = 0;
            int losses = 0;

            Console.Write("Nhap so lan muon choi: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui long nhap so lan choi hop le.");
            }

            while (rounds < n && balance > 0)
            {
                bool win = playOneRound(ref balance);
                if (win) wins++;
                else losses++;
                rounds++;
            }

            // Thống kê sau khi chơi xong
            Console.WriteLine("\nKet qua sau khi choi:");
            Console.WriteLine($"So lan choi: {rounds}");
            Console.WriteLine($"So lan thang: {wins}");
            Console.WriteLine($"So lan thua: {losses}");
            Console.WriteLine($"So tien con lai: {balance}");

            if (balance <= 0)
            {
                Console.WriteLine("Ban da het tien!");
            }
            else
            {
                Console.WriteLine("Hen gap lai lan sau!");
            }
        }

        public static void Main()
        {
            game_engine();
        }
    }

}

