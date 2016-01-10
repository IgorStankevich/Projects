// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Entities;

namespace BlackJack.BusinessLogic
{
    public class GameService
    {
        private Game _game;
        private DeckService _deckService;
        private RoundService _roundService;
        private Player _player;
        private Computer _computer;


        public GameService()
        {
            _deckService = new DeckService();
            _game = new Game();
            _roundService = new RoundService(new Player(), new Computer());
            _player = new Player();
            _computer = new Computer();
        }

        public void StartPlay()
        {
            ConsoleService.StartConsole();
        }

        public void PlayRound()
        {
            var seeallcards = ConsoleService.ShowConsoleCards();
            if (seeallcards)
            {

                ConsoleService.ShowAllCards(_deckService.ShowCardsonDeck());
            }
            _roundService.StartRound();
            _roundService.GetCardForUser(_player);
            _roundService.GetCardForUser(_computer);

            var needanothercard = ConsoleService.GetNextCard();
            if (needanothercard)
            {
                _roundService.GetNextCard(_player);
                _roundService.GetNextCard(_computer);
            }
            else
            {
                _roundService.GetCardForUser(_computer);
            }
            ConsoleService.ValueTotal(_player);
            ConsoleService.ValueTotal(_computer);
            _roundService.RoundWinner();
        }

        public void NextRound()
        {
            while (_player.PlayerMoney > 0)
            {
                _player.CardsValue = 0;
                _computer.CardsValue = 0;
                PlayRound();
            }
            Console.Clear();
        }

        public void EndRound()
        {
            if (_deckService.CardCount() <= 0 || _player.PlayerMoney <= 0)
            {
                ConsoleService.EndGame();
            }
        }
    }
}






