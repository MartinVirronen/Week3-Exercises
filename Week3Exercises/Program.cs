using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //Kui sisestatud PIN-Kood on 1234
            //programm kuvab konsoolis "Tere Tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis



            //"Vale PIN. Proovi uuesti".

            Console.WriteLine("Sisesta oma PIN-kood");
            int code = Convert.ToInt32(Console.ReadLine());
           
             /*if (code == 1234)
             {
                Console.WriteLine("Sisestatud PIN-Kood on õige");
                Console.WriteLine("Tere Tulemast!");

             }
             else
             {
                Console.WriteLine("Vale Pin. Proovi uuesti");

             }*/

            if(code != 1234)
            {
            Console.WriteLine("Vale pin");
            
            }


            else
            {
            Console.WriteLine("Õige pin");
            }

        }

    }   
}
