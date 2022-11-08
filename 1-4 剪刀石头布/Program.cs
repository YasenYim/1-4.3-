using System;

namespace _1_4_剪刀石头布
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(0, 3);   // r的范围是0-2的闭区间

            Console.WriteLine("请输入0，1，2分别代表：剪刀、石头、布。");
            string s = Console.ReadLine();
            int a = int.Parse(s);

            if (a == 0)
            {
                if (r == 0)
                {
                    Console.WriteLine($"系统出的是{r},代表的是剪刀");
                    Console.WriteLine("平局"); 
                }
                else if (r == 1)
                {
                    Console.WriteLine($"系统出的是{r},代表的是石头");
                    Console.WriteLine("你输了");
                }
                else
                {
                    Console.WriteLine($"系统出的是{r},代表的是布");
                    Console.WriteLine("你赢了"); }
                }

            else if (a == 1)
            {
                if (r == 0)
                {
                    Console.WriteLine($"系统出的是{r},代表的是剪刀");
                    Console.WriteLine("你赢了"); 
                }
                else if (r == 1)
                {
                    Console.WriteLine($"系统出的是{r},代表的是石头");
                    Console.WriteLine("平局"); 
                }
                else
                {
                    Console.WriteLine($"系统出的是{r},代表的是布");
                    Console.WriteLine("你输了"); 
                }
            }

            else
            {
                if (r == 0)
                {
                    Console.WriteLine($"系统出的是{r},代表的是剪刀");
                    Console.WriteLine("你输了"); 
                }
                else if (r == 1)
                {
                    Console.WriteLine($"系统出的是{r},代表的是石头");
                    Console.WriteLine("你赢了"); 
                }
                else
                {
                    Console.WriteLine($"系统出的是{r},代表的是布");
                    Console.WriteLine("平局");
                }
            }
          

            Console.ReadKey();
        }
    }
}
