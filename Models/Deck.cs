using System;
using System.Collections.Generic;
using Deck_Cards.Models;

namespace Deck_Cards.Models
{
    public class Deck
    {
        private List<Card> Cards;
        public Deck(){
            Cards = new List<Card>();
            List<string> card_suits = new List<string>(){"Spades", "Hearts", "Clubs", "Diamonds"};
            for(var i=1;i<=13;i++){
                foreach(string item in card_suits){
                    Cards.Add(new Card(item,i));
                }
            }
            // Cards = Cards.Shuffle(Cards);
        }
        public Deck(string empty){
            Cards = new List<Card>();
        }
        public List<Card> cardsProp {
            get{
                return Cards;
            }
        }
        public Card Deal(Deck deck){
            Card current_card = deck.Cards[0];
            deck.Cards.RemoveAt(0);
            return current_card;
        }
        public void Reset(Deck deck){
            deck = new Deck();
        }
        public Deck Shuffle(Deck deck){
                        //make empty deck
            Deck empty_deck = new Deck("empty");
                        //iterate to move old deck to new
            while(deck.Cards.Count>0){
                        //get random index
                Random rand = new Random();
                int c = rand.Next(deck.Cards.Count);
                        //store card that is transferring
                Card current_card = deck.Cards[c];
                        //remove card from old deck
                deck.Cards.RemoveAt(c);
                        //add card to new deck
                empty_deck.Cards.Add(current_card);
            }
                        //all done, Change empty_deck to shuffled_deck
            Deck shuffled_deck = empty_deck;
            return shuffled_deck;
        }

















    }
}