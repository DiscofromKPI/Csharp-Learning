using System;
namespace ConsoleApp1
{
    class UnilieKachki : IBuilders
    {
        public int AmountOf{get; }
        public int Power{get; }

        public UnilieKachki()
        {
            AmountOf = 100;
            Power = 500;

        }

        public void Start()
        {
            Console.WriteLine("Я бы на твоем месте не мешал бы им строить");
        }

        public void TooWeak()
        {
            Console.WriteLine("Количество вколотых стероидов превысило адекватную норму");
        }
        
    }
}