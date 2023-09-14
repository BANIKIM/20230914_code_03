using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230914_code_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int com_number = 0;//컴퓨터의 랜덤값
            int my_number = 0;
            com_number = rand.Next(0, 1000);

            while(true)
            {
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{i + 1}번째 질문");
                    my_number = int.Parse(Console.ReadLine());
                    if (com_number == my_number)
                    {
                        Console.WriteLine("정답입니다.");
                        break;
                    }
                    else if (com_number > my_number)
                    {
                        Console.WriteLine("업!");
                    }
                    else
                    {
                        Console.WriteLine("다운!");
                    }
                    if(i==9)
                    {
                        Console.WriteLine("게임오버");
                    }

                }
                Console.WriteLine("게임을 재시작?");
                Console.WriteLine("1. 예    2.아니오");
                my_number = int.Parse(Console.ReadLine());
                if (2 == my_number)
                {
                    break;
                }
            }

           
            
        }
    }
}
