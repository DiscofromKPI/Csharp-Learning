using System;
namespace ConsoleApp1
{
    class Rabotyagi : IBuilders
    {
        public int AmountOf{get; }
        public int Power{get; }

        public Rabotyagi()
        {
            AmountOf = 5000;
            Power = 10;

        }

        public void Start()
        {
            Console.WriteLine("ТРУШНЫЕ ПАЦЫКИ С ИПОТЕКОЙ НА 30 лет построят цивилизацию твой мечты!");
        }
        public void TooWeak()
        {
            Console.WriteLine("Работягам не хватило силы построить цивилизацию и они ушли на покой");
        }
        
    }
}