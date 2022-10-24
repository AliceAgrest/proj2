using System;

namespace proj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bol pgia
            int num, rnd1 , a ,b ,c ,d ,a2 ,b2 , c2 ,d2 , bul = 0 ,pgia = 0;
            Random rnd = new Random();
            rnd1 = rnd.Next(1000, 10000);
            a2 = rnd1 / 1000;
            b2 = (rnd1 / 100) % 10;
            c2 = (rnd1 / 10) % 10;
            d2 = rnd1 % 10;
            //Console.WriteLine("Enter  a four digit number ");
            //num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter  a four digit number ");
                num = int.Parse(Console.ReadLine());
                a = num / 1000;
                b = (num / 100) % 10;
                c = (num / 10) % 10;
                d = num % 10;

                if (a == a2 || a == b2 || a == c2 || a == d2)
                    bul += 1;
                else
                    pgia += 1;

                if (b == b2 || b == a2 || b == c2 || b == d2)
                    bul += 1;
                else
                    pgia += 1;

                if (c == c2 || c == a2 || c == b2 || c == d2)
                    bul += 1;
                else
                    pgia += 1;

                if (d == d2 || d == a2 || d == b2 || d == c2)
                    bul += 1;
                else
                    pgia += 1;

                Console.WriteLine($"You have {bul} buls and {pgia} pgia ");
            }
            //Console.WriteLine($"You have {bul} buls and {pgia} pgia ");

            Console.ReadLine();
        }
    }
}
