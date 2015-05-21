using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Game_Class_Library;


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

        public Card(){    
        }

        public Card(Suit suit, FaceValue faceValue)
        {
            this.suit = suit;
            this.faceValue = faceValue;
        }

        public FaceValue GetFaceValue(){           
            return faceValue;
        }

        public Suit GetSuit(){      
            return suit;
        }

        

        public int CompareTo(Card anotherCard) {
            if (this.suit < anotherCard.suit) {
                return -1;
            } else if (this.suit > anotherCard.suit) {
                return 1;
            } else {
                if (this.faceValue < anotherCard.faceValue) {
                    return -1;
                } else if (this.faceValue > anotherCard.faceValue) {
                    return 1;
                } else {
                    return 0;
                }
            }
        }


        public bool Equals(Card anotherCard){
            return (this.suit == anotherCard.suit && this.faceValue == anotherCard.faceValue);
        }


        

    }
}
