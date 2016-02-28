using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using BlackJack.Entities;

namespace BlackJack.BusinessLogic
{
    class RoundService
    {
        private DeckService _deckService;
        private Player _player;
        private Computer _computer;
        private Round _round;
        private ResultServices _resultServices;

        public RoundService(Player player, Computer computer)
        {
            _deckService = new DeckService();
            _computer = computer;
            _player = player;
            _resultServices = new ResultServices();
        }

        public int StartRound()
        {
            int money = ConsoleService.InputMoney(_player.PlayerMoney, _deckService.CardCount());
            _deckService.Shuffle();
            return money;
        }

        public void GetCardForUser(IUser user)
        {
            user.Cards = _deckService.GetCards(2);
            user.CardsValue += _deckService.ValueСards(user.Cards);
            ConsoleService.ShowUserCards(user);
        }

        public void GetNextCard(IUser user)
        {
            user.Cards = _deckService.GetCards(1);
            user.CardsValue += _deckService.ValueСards(user.Cards);
            ConsoleService.ShowUserCards(user);
        }

        public void RoundWinner()
        {
            var resultround = _resultServices.ResultRound();
            if (resultround == Result.PlayerWon)
            {
                _player.PlayerMoney += ConsoleService.moneyinput;
                ConsoleService.ShowRoundWinner(_player);
            }
            else if (resultround == Result.ComputerWon)
            {
                _player.PlayerMoney -= ConsoleService.moneyinput;
                ConsoleService.ShowRoundWinner(_computer);
            }

            if (resultround == Result.BlackJackPlayer)
            {
                _player.PlayerMoney += ConsoleService.moneyinput;
            }

            else if (resultround == Result.BlackJackComputer)
            {
                _player.PlayerMoney -= ConsoleService.moneyinput;
            }
        }
    }
}
