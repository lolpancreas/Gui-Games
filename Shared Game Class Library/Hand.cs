using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Game_Class_Library;

namespace Shared_Game_Class_Library
{


    public class Hand { 
    

        private List<Card> cards;
        

      
        private bool hasCard = false;

        public Hand(){     
            cards = new List<Card>();
        }

        public Hand(List<Card> card){
            this.cards = cards;
        }

        public int GetCount(){
             return cards.Count;
            
        }

        public Card GetCard(int index){
            return cards[index];
        }

        public void Add(Card card){
            cards.Add(card);
        }

        public bool ContainsCard(Card card){
            return cards.Contains(card); 
        }

        public bool RemoveCard(Card card){
            return cards.Remove(card);
        }


        public void SortHand(){
            cards.Sort();
        }

        public void RemoveCardAt(int index){
            cards.RemoveAt(index);
        }

        public IEnumerator<Card> GetEnumerator(){
            return cards.GetEnumerator();
        }      
    }
}
