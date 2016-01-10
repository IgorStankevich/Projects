using System.Collections.Generic;

namespace BlackJack.Entities
{
  public  class Computer:IUser
    {        
        List<Card> cards = new List<Card>();
        private string computername = "Computer";
        public List<Card> Cards
        {
            get { return this.cards; }
            set { this.cards = value; }
        }

        public string Name
        {
            get { return this.computername; }
            set { this.computername = value; }
        }


        public int CardsValue { get; set; }
        
    }
}
