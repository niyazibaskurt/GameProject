﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GameSalesManager : IGameSalesService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu " + game.GameName + " isimli oyunu satın aldı. ");
        }
    }
}
