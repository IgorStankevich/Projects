using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Entities;

namespace BlackJack.BusinessLogic
{
    public static class ConsoleService
    {
        private static Player _Player { get; set; }
        private static Computer _Computer { get; set; }
        public static int moneyinput;

        public static void StartConsole()
        {
            Console.Title = "BlackJack Game";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Black Jack");
        }

        public static bool ShowConsoleCards()
        {
            while (true)
            {
                Console.WriteLine("Show all cards in deck? (y/n)");
                var input = Console.ReadLine();
                Console.Clear();
                if (input == "y" || input == "n")
                {
                    return input == "y" ? true : false;
                }
            }
        }

        public static void ShowAllCards(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.WriteLine("The Card Name: {0}, The Card Lear: {1}", card.CardName, card.CardLear);
            }
        }

        public static int InputMoney(int money, int countcard)
        {
            Console.WriteLine("The count of cards is {0}", countcard);
            Console.WriteLine("How much you want to bet 1-{0}", money);

            int.TryParse(Console.ReadLine(), out moneyinput);

            while (moneyinput > money)
            {
                Console.WriteLine("Incorrect sum, try again");
                moneyinput = Convert.ToInt32(Console.ReadLine());
            }
            return moneyinput;
        }

        public static bool GetNextCard()
        {
            while (true)
            {
                Console.WriteLine("Do you need another one card?(y/n)");
                var answer = Console.ReadLine();
                if (answer == "y" || answer == "n")
                {
                    return answer == "y" ? true : false;
                }
            }
        }


        public static void ShowUserCards(IUser user)
        {
            foreach (var card in user.Cards)
            {
                Console.WriteLine("[ {0} ] Card: {1} of: {2}  card value : {3}", user.Name, card.CardName, card.CardLear, card.Value);
            }
        }

        public static void ValueTotal(IUser user)
        {
            Console.WriteLine("[ {0} ] Total value: {1} ", user.Name, user.CardsValue);
        }

        public static void ShowRoundWinner(IUser user)
        {
            Console.WriteLine("[{0}] Win!", user.Name);
        }

        public static void ShowRoundLoser(IUser user)
        {
            Console.WriteLine("[{0}] Lose!", user.Name);
        }

        public static void EndGame()
        {
            Console.WriteLine("You Lost! Press to any button for Exit...");
            Console.ReadKey();
        }
    }
}
