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


namespace BlackJack.Entities
{
   public class Game
   {
       public Player Player = new Player();
       public Computer Computer = new Computer();
       public List<Round> Rounds= new List<Round>();
   }
}
