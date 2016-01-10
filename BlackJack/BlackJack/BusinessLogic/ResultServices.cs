using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Entities;

namespace BlackJack
{
    public class ResultServices
    {
        private Player _player;
        private Computer _computer;

        public ResultServices()
        {
            _player = new Player();
            _computer = new Computer();
        }

        public Result ResultRound()
        {
            if (_player.CardsValue > _computer.CardsValue && _player.CardsValue <= 21 || _computer.CardsValue > 21)
            {
                return Result.PlayerWon;
            }
            else if (_computer.CardsValue > _player.CardsValue && _computer.CardsValue <= 21 || _player.CardsValue > 21)
            {
                return Result.ComputerWon;
            }
            if (_player.CardsValue == 21)
            {
                return Result.BlackJackPlayer;
            }
            else if (_computer.CardsValue == 21)
            {
                return Result.BlackJackComputer;
            }
        }
    }
}
