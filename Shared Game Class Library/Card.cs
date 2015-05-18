using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Class_Library;


namespace Shared_Game_Class_Library
{

    public enum Suit { Clubs, Diamonds, Hearts, Spades }

    public enum FaceValue {
        Two, Three, Four, Five, Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King, Ace
    }

     
    public class Card : IEquatable<Card>, IComparable<Card> 
    {
       

        private FaceValue faceValue;
        public Suit suit;
        public Card card;

       
         
        

        public Card()
        {
            
            
        }
        
        public Card(Suit inputSuit, FaceValue inputfaceValue){


            suit = inputSuit;
            faceValue = inputfaceValue;
                 
            
        }

        public FaceValue GetFaceValue()
        {
            
            return faceValue;

        }

        public Suit GetSuit()
        {
            
            return suit;
        }

        

        public int CompareTo(Card cardCompare)
        {
            if (card== cardCompare)
            {
                return -1;
            }           

            if (card == cardCompare)
            {
                return 0;
            }
            


            if (card == cardCompare)
            {
                return 1;
            }

            return 3;

        }


        public bool Equals(Card card){
            return true;
            
        }


        

    }
}
