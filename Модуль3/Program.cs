using System;

enum DaysOfWeek:byte 
    {
       Понедельник = 1,
       Вторник,
       Среда,
       Четверг,
       Пятница ,
       Суббота,
       Воскресение

    }



class MainClass
{
    public static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Red;
        var dat1 = DateTime.Now;
        Console.WriteLine("Как вас зовут?");
        var name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        var age = (byte)int.Parse(Console.ReadLine());
        Console.WriteLine("Вас зовут {0} и вам {1} лет. ", name, age);

        Console.WriteLine("Когда ваш день рождения? (формат 00.00.0000) ");
        var dr = Console.ReadLine();
        Console.WriteLine("Ваш день рождения {0}. ", dr);
        
        Console.Write("Какой ваш любимый день недели (цифра 1-7)?  ");
       
        int d = int.Parse(Console.ReadLine());
        DaysOfWeek day = (DaysOfWeek)d;
        int numday = (int)day;
        Console.WriteLine("Ваш любимый день недели {0} ({1}), Сегодня {2}.", day, numday, dat1);

        Console.ReadLine();
        //Console.Write("What is your favorite day of the week? ");

        // DaysOfWeek day =  (DaysOfWeek) int.Parse(Console.ReadLine());
        //int day2 = (int)day; 
        //Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        // Console.WriteLine("Your favotite week day is {0} ({1}).",day, day2);


    }
}