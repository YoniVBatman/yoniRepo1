using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter an id:");
            string id = Console.ReadLine();
            Console.WriteLine("Plese enter the gender F/M:");
            char gen = char.Parse(Console.ReadLine());
            Console.WriteLine("Plese enter the amount of films of actor:");
            int AnumFilms = int.Parse(Console.ReadLine());

            Actor a = new Actor(id, gen, AnumFilms);
            Console.WriteLine("--------------");

            Console.WriteLine("Plese enter the amount of films for other:");
            int OnumFilms = int.Parse(Console.ReadLine());
            Other b = new Other(OnumFilms);

            switch (a.Compare(other))
            {
                case 1:
                    Console.WriteLine("Actor is more Famous");
                break;
                case 2:
                    Console.WriteLine("Other is more Famous");
                break;
                default:
                    Console.WriteLine("Actor and Other are Famous");
                break;
            }
            Console.WriteLine("--------------");

            Actor[] actArr = new Actor[37];
            for (int i = 0; i < actArr.Length; i++)
                actArr[i] = new Actor("1",'F',0);

            Random rnd = new Random();
            int count = 0;
            Console.Write("Enter the amount of movies to surpass: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < actArr.Length; i++)
            {
                int ran = rnd.Next(100) + 1;
                actArr[i].setNumFilms(ran);
                if (actArr[i].getNumFilms() > num)
                    count++;
            }
            Console.WriteLine("the amount actors with more movies than " + num + " is: " + count);







        }
    }
}
