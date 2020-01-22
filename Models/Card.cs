namespace Deck_Cards.Models
{
    public class Card
    {
        private string Suit;
        private int Value;

        public Card(string suit, int value){
            Suit = suit;
            Value = value;
        }

        public string suitProp{
            get{return Suit;}
        }

        public int valueProp{
            get{return Value;}
        }

        public string stringValueProp{
            get{
                if(Value==1){
                    return "Ace";
                }
                if(Value==11){
                    return "Jack";
                }
                if(Value==12){
                    return "Queen";
                }
                if(Value==13){
                    return "King";
                }
                else{
                    return Value.ToString();
                }
            }
        }
    }
}