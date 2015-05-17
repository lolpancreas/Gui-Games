using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Class_Library;

namespace Shared_Game_Class_Library
{


    public class Hand 
    {
        Card card = new Card();

        List<Card> hand;
        
        
       
        private List<Card> cards;
        private bool hasCard = false;

        public Hand()
        {
        }

        public Hand(List<Card> card){
        }

        public int GetCount(){
            return 1;
        }

        public Card GetCard(int position){

            return cards[position];

        }

        public void AddCard(Card card){
            
          hand.Add(card);
           


        }

        public bool ContainsCard(Card card){

            if (cards.Contains(card))
            {
                hasCard = true;
                return true;

            }
            else
            {
                return false;
            }

            
        }

        public bool RemoveCard(Card card){
            if (hasCard == true)
            {
                cards.Remove(card);
            }
            return false;
        }


 

        public void SortHand(){
        }

        public void RemoveCardAt(int cardPosition){
           
            cards.RemoveAt(cardPosition);

        }

        

        public IEnumerator<Card> GetEnumerator()
        {
            return cards.GetEnumerator();
        }



        

    }
}
