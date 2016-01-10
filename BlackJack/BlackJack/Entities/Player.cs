using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BlackJack.Entities
{
    public class Player : IUser
    {

        private int Money = 100;
        List<Card> cards = new List<Card>();
        private string playername = "Player";

        public List<Card> Cards
        {
            get { return this.cards; }
            set { this.cards = value; }
        }

        public string Name
        {
            get { return this.playername; }
            set { this.playername = value; }
        }

        public int PlayerMoney
        {
            get
            {
                return Money;
            }
            set
            {
                this.Money = value;
            }
        }

        public int CardsValue { get; set; }        
    }
    
}
