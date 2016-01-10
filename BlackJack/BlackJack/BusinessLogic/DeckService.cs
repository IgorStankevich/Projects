using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using BlackJack.Entities;

namespace BlackJack.BusinessLogic
{
    public class DeckService
    {
        private Deck _deck;

        public DeckService()
        {
            _deck = new Deck();
            CreateDeck();
        }

        public void CreateDeck()
        {
            const int countLear = 4;
            const int countCard = 13;
            _deck.Cards = new List<Card>();
            for (int i = 0; i < countLear; i++)
            {
                for (int j = 0; j < countCard; j++)
                {
                    _deck.Cards.Add(new Card { CardLear = (CardLear)i, CardName = (CardName)j });
                    if (j <= 8)
                    {
                        _deck.Cards[_deck.Cards.Count - 1].Value = j + 1;
                    }
                    else
                    {
                        _deck.Cards[_deck.Cards.Count - 1].Value = 10;
                    }
                    if (j == 0)
                    {
                        _deck.Cards[_deck.Cards.Count - 1].Value += 10;
                    }
                }
            }
        }

        public List<Card> GetCards()
        {
            var cardstoremove = _deck.Cards.Last();
            _deck.Cards.Remove(cardstoremove);
            return _deck.Cards;//
        }
        //give the cards for the round
        public List<Card> GetCards(int count)
        {
            var cards = _deck.Cards.Take(count).ToList();
            foreach (Card card in cards)
            {
                _deck.Cards.Remove(card);
            }
            return cards;
        }

        public int CardCount()
        {
            return _deck.Cards.Count;
        }

        public void Shuffle()
        {
            Random rnd = new Random();

            int c = _deck.Cards.Count;
            while (c > 1)
            {
                c--;
                int n = rnd.Next(c + 1);
                Card card = _deck.Cards[n];
                _deck.Cards[n] = _deck.Cards[c];
                _deck.Cards[c] = card;
            }
        }

        public List<Card> ShowCardsonDeck()
        {
            var cardtodeck = _deck.Cards.ToList();
            return cardtodeck;
        }

        public int ValueСards(List<Card> _value)
        {
            int value = 0;
            foreach (Card cards in _value)
            {
                value += cards.Value;
            }
            return value;
        }

        public int Money()
        {
            int money = 0;
            return money;
        }
    }
}
