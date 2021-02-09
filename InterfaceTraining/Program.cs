using System;
using ConsoleApp1;

namespace InterfaceTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Working rabotnik = new Working();//Строится цивилизация 
            
            rabotnik.Builder = new Androids();
            if (WillBuild(rabotnik.Builder.AmountOf, rabotnik.Builder.Power))
            {
                Success();
                rabotnik.Builder.Start();
            }
            else rabotnik.Builder.TooWeak();
            
            Console.WriteLine();
            
            rabotnik.Builder = new UnilieKachki();
            if (WillBuild(rabotnik.Builder.AmountOf, rabotnik.Builder.Power))
            {
                Success();
                rabotnik.Builder.Start();
            }
            else rabotnik.Builder.TooWeak();
            
            Console.WriteLine();
            
            rabotnik.Builder = new Rabotyagi();
            if (WillBuild(rabotnik.Builder.AmountOf, rabotnik.Builder.Power))
            {
                Success();
                rabotnik.Builder.Start();
            }
            else rabotnik.Builder.TooWeak();
            
            Console.WriteLine();
           
            rabotnik.Builder = new CryingKpiStudents();
            if(WillBuild(rabotnik.Builder.AmountOf, rabotnik.Builder.Power)) rabotnik.Builder.Start();
            else rabotnik.Builder.TooWeak();
        }
        public static bool WillBuild(int amount, int power)
        {
            return power * amount / 10000 > 200;
        }

        public static void Success()
        {
            Console.WriteLine("Успешный старт...");
        }
    }
}