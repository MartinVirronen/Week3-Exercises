using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum boiloogias 95 punktiM 
            //programm küisib kasutajal sisestada tema
            //eksami punktid ja otsustab, kes kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta matemaatika eksami tulemus:");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta keemia eksami tulemus:");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta bioloogia eksami tulemus:");
            int biology = Convert.ToInt32(Console.ReadLine());

            if(math >=85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("Tubli! saad arstiks õppida.");
            }
            else
            {
                Console.WriteLine("Ei ole võimalik arstiks õppida");
            }


        }
    }
}
