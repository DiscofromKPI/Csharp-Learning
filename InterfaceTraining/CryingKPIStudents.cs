using System;
namespace ConsoleApp1
{
    public class CryingKpiStudents : IBuilders
    {
        public int AmountOf{ get; }
        public int Power{ get; }

        public CryingKpiStudents()
        {
            AmountOf = 15000;
            Power = 200;

        }

        public void Start()
        {
            Console.WriteLine("Работа строится на теории вероятности слез студентов, сдающих лабы");
        }
        public void TooWeak()
        {
            Console.WriteLine("ОТЧИСЛЕНЫ");
        }
        
    }
}