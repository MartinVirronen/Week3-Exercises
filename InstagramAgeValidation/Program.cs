using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem,
            //siis ta võib instagram'i kasutada
            //kui kasutaja on noorem, kui 13, siis ta on liiga noor.

            Console.WriteLine("Kui vana sa oled?");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if(Age > 13)
            {
                Console.WriteLine("Võid kasutada instagram'i.");

            }
            else if (Age < 13)
            {
                Console.WriteLine("Oled liiga noor, et kasutada Instagram'i.");

            }
            else
            {
                Console.WriteLine("Võid kasutada instagram'i.");
            }
                




        }
    }
}
