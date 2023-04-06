using System;

   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите секунды");
            int x = int.Parse(Console.ReadLine());
            Zeit zeit1 = new Zeit(x);
            Console.WriteLine(zeit1);
            Console.WriteLine("Введите секунды");
            int u = int.Parse(Console.ReadLine());
            Zeit zeit2 = new Zeit(u);
            Console.WriteLine(zeit2);
            bool y = true;
            while(y)
            {
                Console.WriteLine("Что вы хотите сделать ?\n1)Сложение \n2)Вычитание \n3)Умножение \n4)Деление \n5)Первая больше второй \n6)Первая меньше второй \n7)Равны ли дроби \n8)Не равны ли дроби");
                int z = int.Parse(Console.ReadLine());
                switch(z)
                {
                    case 1:
                        Zeit addition = zeit1 + zeit2;
                        Console.WriteLine($"Результат сложения: {addition}\n");
                        break;
                    case 2:
                        Zeit substraction = zeit1 - zeit2;
                        Console.WriteLine($"Результат вычитания: {substraction}\n");
                        break;
                    case 3:
                        Zeit multiplication = zeit1 * zeit2;
                        Console.WriteLine($"Результат умножения: {multiplication}\n");
                        break;
                    case 4:
                        Zeit division = zeit1 / zeit2;
                        Console.WriteLine($"Результат деления: {division}\n");
                        break;
                    case 5:
                        bool isGreater = zeit1 > zeit2;
                        Console.WriteLine($"Первая дробь больше второй? {isGreater}\n");
                        break;
                    case 6:
                        bool isLess = zeit1 < zeit2;
                        Console.WriteLine($"Первая дробь меньше второй? {isLess}\n");
                        break;
                    case 7:
                        bool isEquals = zeit1 == zeit2;
                        Console.WriteLine($"Обе дроби равны? {isEquals}\n");
                        break;
                    case 8:
                        bool isNotEquals = zeit1 != zeit2;
                        Console.WriteLine($"Обе дроби не равны? {isNotEquals}\n");
                        break;
                    default:
                        y = false;
                        break;
                }
            }
        }
    }
}
