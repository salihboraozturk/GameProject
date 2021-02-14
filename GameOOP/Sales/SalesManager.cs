using System;
using System.Collections.Generic;
using System.Text;

namespace GameOOP
{
    class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campain campain)
        {
            Console.WriteLine("Sayın "+gamer.Name+", "+game.GameName+" oyunu"+campain.CampainName+"kampanyası ile satın alınmıştır.");
        }
    }
}
