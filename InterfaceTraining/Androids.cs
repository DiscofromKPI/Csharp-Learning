using System;
namespace ConsoleApp1
{
    class Androids : IBuilders
    {
        public int AmountOf{get; }
        public int Power{get; }

        public Androids()
        {
            AmountOf = 300;
            Power = 10000;

        }

        public void Start()
        {
            Console.WriteLine("ROBOTI SPASUT NAS, ONI NACHALI SOZDAVAT GOROD IZ KYSKOV SEBYA");
        }
        public void TooWeak()
        {
            Console.WriteLine("Андроиды рассыпались и не оправдали надежд человечества");
        }

        
        
    }
}