using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Entities
{
    public interface IUser
    {
        List<Card> Cards { get; set; }
        int CardsValue { get; set; }
        string Name { get; set; }
    }
}
