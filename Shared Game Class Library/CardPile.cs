using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Game_Class_Library;

namespace Shared_Game_Class_Library
{
    

    public class CardPile
    {
        public static int NUM_SUITS = 4;
        public static int NUM_CARDS_PER_SUIT = 13;
        private List<Card> pile = new List<Card>();

        private static Random random = new Random();
        

        public CardPile(){          
        }

        public CardPile(bool initialiseWith52Cards){
            if (initialiseWith52Cards){
                // Add 52 cards - One card of each Suit and FaceValue combination to the pile.
                for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++){
                    for (FaceValue faceValue = FaceValue.Two; faceValue <= FaceValue.Ace; faceValue++){
                        pile.Add(new Card(suit, faceValue));
                    }
                }
            }
            // else, there are no cards in the pile.
        }

        /// <summary>
        /// Adds a card to the pile.
        /// </summary>
        public void AddCard(Card card){
            pile.Add(card);
        }
        
        public int GetCount(){
            return 1;
        }

        public Card GetLastCardInPile(){
            return pile[pile.Count - 1];
        }

        public void Shuffle(){
            Random randomCard = new Random();
            int totalCards = pile.Count;

            for (int i = 0; i < totalCards; i++)
            {
                int replacementCardInt = randomCard.Next(0, totalCards);
                Card replacementCard = pile[replacementCardInt];
                pile[replacementCardInt] = pile[i];
                pile[i] = replacementCard;
            }//end for
        }

        public Card DealOneCard(){
            Card card = pile[0];
            pile.RemoveAt(0);
            return card;
        }//end DealOneCard

        public List<Card> DealCards(int numCardsToDeal){
            List<Card> cards = new List<Card>();

            for (int i = 0; i < numCardsToDeal; i++){
                cards.Add(pile[i]);
                pile.RemoveAt(i);
            }//end for
            return cards;
        } //end DealCards

    }
}
