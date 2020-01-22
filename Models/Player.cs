using System.Collections.Generic;

namespace Deck_Cards.Models
{
    public class Player
    {
        private string Name;

        private List<Card> Hand;

        public Player(string name){
            Name=name;
            Hand=new List<Card>();
        }

        public string name{
            get{return Name;}
        }

        public List<Card> hand{
            get{return Hand;}
        }

        public Card Draw(Deck deck){
            Card drawn_card = deck.Deal(deck);
            Hand.Add(drawn_card);
            System.Console.WriteLine($"{Name} draws a {drawn_card.stringValueProp} of {drawn_card.suitProp} from the deck.");
            return drawn_card;
        }

        public Card Discard(int index){
            if (Hand.Count-1<index){
                return null;
            }
            else {
                Card discarded_card = Hand[index];
                Hand.RemoveAt(index);
                return discarded_card;
            }
        }






    }
}