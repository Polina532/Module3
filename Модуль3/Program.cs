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
        

        Console.WriteLine("Когда ваш день рождения?");
        var dr = Console.ReadLine();
                
        Console.Write("Какой ваш любимый день недели (в ответе должна быть цифра 1-7)?  ");
       
        int d = int.Parse(Console.ReadLine());
        DaysOfWeek day = (DaysOfWeek)d;
        int numday = (int)day;

        Console.WriteLine(" ");
        Console.WriteLine("Вас зовут {0} и вам {1} лет. ", name, age);
        Console.WriteLine("Ваш день рождения {0}. ", dr);
        Console.WriteLine("Ваш любимый день недели {0} ({1}).", day, numday);
        Console.WriteLine("Анкета была заполнена сегодня: {0}.", dat1);
        Console.ReadLine();
                       

    }
}