using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("====== Simple Calculator ======");
                Console.WriteLine("1. Cộng");
                Console.WriteLine("2. Trừ");
                Console.WriteLine("3. Nhân");
                Console.WriteLine("4. Chia");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                      
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine();
            } while (choice != 0);
        }

        static void Add()
        {
            Console.Write("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kết quả: {a} + {b} = {a + b}");
        }

        
    }
}