using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Class_Library;

namespace Shared_Game_Class_Library
{
    

    public class CardPile
    {
        public List<Card> pile;
               
        public int NUM_SUITS = 4;
        public int NUM_CARDS_PER_SUIT = 13;
        Card card = new Card();
        Hand hand = new Hand();
        Card testCard = new Card();
        public List<Card> testPile = new List<Card>();
        
      //  for (int i = 1; i <= 52; i++)
        //    {
        //        pile.Add(card);
         //      
        //    }
        
        

        public CardPile()
        {
           // List<Card> pile = new List<Card>();
        }

        public void CardPileBool(bool newPile)
        {
            
            
            if (newPile == true)
            {
                for (int i = 1; i <= 52; i++ )
                {
                    testPile.Add(testCard);
                    
                    


                    
                }
                

             //   for (int i = 1; i < 52; i++)
             //   {                                                  
             //  }

            }
            else
            {
                List<Card> pile;
            }
        }

        
        public int GetCount()
        {
            return 1;
        }

        public Card GetLastCardInPile()
        {

            Card lastCard;
            return lastCard = pile[pile.Count - 1];
        }

        public void ShufflePile(){

            var rnd = new Random();
            var result = pile.OrderBy(card => rnd.Next());

        }

        public Card DealOneCard(){

           // pile.Remove(card);
           // hand.AddCard(card);  

            int index = 0;
           
            return testPile[index++];
            
         }

        public List<Card> DealCards(int cards)
        {
            testPile.RemoveRange(0, cards);
            hand.AddCard(card);

            
            return testPile;
        }


       
        

    }
}
