using System;
using System.Collections.Generic;
using Deck_Cards.Models;

namespace Deck_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$");
            Console.WriteLine("Deck of Cards");
            Console.WriteLine("$$$$$$$$$$$$$");

            Player adam = new Player("Adam");
            Deck new_deck = new Deck();
            new_deck = new_deck.Shuffle(new_deck);

            // new_deck.Deal(new_deck);
            // new_deck.Deal(new_deck);
            // new_deck.Deal(new_deck);

            adam.Draw(new_deck);
            adam.Draw(new_deck);
            adam.Draw(new_deck);
            adam.Draw(new_deck);
            adam.Draw(new_deck);

            Console.WriteLine("##################");
            
            int count = 0;
            foreach(Card card in new_deck.cardsProp){
                count++;
                // Console.WriteLine($"Suit: {card.suitProp}, Value: {card.valueProp}");
            }
            Console.WriteLine($"Amount of Cards: {count.ToString()}");

            adam.Discard(3);
            adam.Discard(4);

            count = 0;
            foreach(Card card in adam.hand){
                count++;
                // Console.WriteLine($"Suit: {card.suitProp}, Value: {card.valueProp}");
            }
            Console.WriteLine($"Amount of {adam.name}'s Cards: {count.ToString()}");

        }
    }
}
