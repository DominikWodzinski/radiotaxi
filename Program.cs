using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADIOTAXI
{
    class Program
    {
        static void Main(string[] args)
        {

            Klient Klient1 = new Klient();
            

            Console.WriteLine("-------------------RADIO TAXI-------------------");

            Dzielnica dzielnica1 = new Dzielnica();
            dzielnica1.Id = 1;
            dzielnica1.Nazwa = "Widzew Wschód";
            dzielnica1.Odleglosc = 5;

            Console.WriteLine($"{dzielnica1.Id}. {dzielnica1.Nazwa}");


            Dzielnica dzielnica2 = new Dzielnica();
            dzielnica2.Id = 2;
            dzielnica2.Nazwa = "Janów";
            dzielnica2.Odleglosc = 7;

            Console.WriteLine($"{dzielnica2.Id}. {dzielnica2.Nazwa}");


            Dzielnica dzielnica3 = new Dzielnica();
            dzielnica3.Id = 3;
            dzielnica3.Nazwa = "Olechów";
            dzielnica3.Odleglosc = 8;

            Console.WriteLine($"{dzielnica3.Id}. {dzielnica3.Nazwa}");

            Dzielnica dzielnica4 = new Dzielnica();
            dzielnica4.Id = 4;
            dzielnica4.Nazwa = "Radogoszcz";
            dzielnica4.Odleglosc = 4;

            Console.WriteLine($"{dzielnica4.Id}. {dzielnica4.Nazwa}");

            Dzielnica dzielnica5 = new Dzielnica();
            dzielnica5.Id = 5;
            dzielnica5.Nazwa = "Retkinia";
            dzielnica5.Odleglosc = 5;

            Console.WriteLine($"{dzielnica5.Id}. {dzielnica5.Nazwa}");

            Dzielnica dzielnica6 = new Dzielnica();
            dzielnica6.Id = 6;
            dzielnica6.Nazwa = "Karolew";
            dzielnica6.Odleglosc = 3;

            Console.WriteLine($"{dzielnica6.Id}. {dzielnica6.Nazwa}");

            Dzielnica dzielnica7 = new Dzielnica();
            dzielnica7.Id = 7;
            dzielnica7.Nazwa = "Julianów";
            dzielnica7.Odleglosc = 5;

            Console.WriteLine($"{dzielnica7.Id}. {dzielnica7.Nazwa}");

            Dzielnica dzielnica8 = new Dzielnica();
            dzielnica8.Id = 8;
            dzielnica8.Nazwa = "Teofilów";
            dzielnica8.Odleglosc = 5;

            Console.WriteLine($"{dzielnica8.Id}. {dzielnica8.Nazwa}");

            Dzielnica dzielnica9 = new Dzielnica();
            dzielnica9.Id = 9;
            dzielnica9.Nazwa = "Żabieniec";
            dzielnica9.Odleglosc = 3;

            Console.WriteLine($"{dzielnica9.Id}. {dzielnica9.Nazwa}");

            Dzielnica dzielnica10 = new Dzielnica();
            dzielnica10.Id = 10;
            dzielnica10.Nazwa = "Stare Polesie";
            dzielnica10.Odleglosc = 1;

            Console.WriteLine($"{dzielnica10.Id}. {dzielnica10.Nazwa}");


            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Wybierz dzielnice w której się znajdujesz.");
            int Adres = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Adres);


            Console.ReadKey();


            //W("-------------------RADIO TAXI-------------------");
            //W("");
            //W("1. Widzew Wschód");
            //W("2. Janów");
            //W("3. Olechów");
            //W("4. Radogoszcz");
            //W("5. Retkinia");
            //W("6. Karolew");
            //W("7. Julianów");
            //W("8. Teofilów");
            //W("9. Żabieniec");
            //W("10. Stare Polesie");
            //W("");
            //W("Podaj numer dzielnicy w której się znajdujesz:");

            //int Adres = int.Parse(Console.ReadLine());




        }
    }
}
