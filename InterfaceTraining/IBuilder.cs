using System;

namespace ConsoleApp1
{
    public interface IBuilders
    {
        
        int AmountOf{get; }
        int Power{get; }
        void Start();

        void TooWeak();

        

    }
}