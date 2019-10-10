using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new instance of Players object
            Players players = new Players();
            players.InitializeList();
            players.PrintList();
            players.findMaxWeight();
            players.findMinWeight();

        }
    }
}