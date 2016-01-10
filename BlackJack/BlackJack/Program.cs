// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using BlackJack.BusinessLogic;
using BlackJack.Entities;

namespace BlackJack
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameService gameservice = new GameService();
            gameservice.StartPlay();
            gameservice.PlayRound();
            gameservice.NextRound();
            gameservice.EndRound();
            Console.ReadKey();
        }
    }

}



