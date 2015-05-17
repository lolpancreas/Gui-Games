﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shared_Game_Class_Library;
using Game_Class_Library;

namespace Gui_Games {
    
    /// <summary>
    /// Provides easy access to the Card images via GetCardImage(Card) 
    /// 
    /// called from other classes  as    Images.GetCardImage(card)   
    /// 
    /// where card is a Card object initialised with a Suit and FaceValue
    /// 
    /// For your assignment, it is not important to understand all the finer details 
    /// of all the methods in this class.
    /// 
    /// Do not confuse this class with the Microsoft-supplied class, Image, which has a similar name.
    /// 
    /// Authors:  Jim Reye and Mike Roggenkamp     August 2011
    /// 
    /// 
    /// </summary>
    public static class Images {

        private static Bitmap backOfCardImage;
        private static Bitmap[,] cardImages;
        
       
        /// <summary>
        /// Constructor - Loads images from disk files.
        /// </summary>
        static Images() {
            
                        // Load card images.
                        backOfCardImage = Images.LoadImage("Cards", "CardBack_Red");
                        cardImages = new Bitmap[4, 13];
            
                        for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++) {
                            for (FaceValue faceValue = FaceValue.Two; faceValue <= FaceValue.Ace; faceValue++) {
                                Card card = new Card(suit, faceValue);
                                string cardImageName = GetCardImageName(card);
                                cardImages[(int) card.GetSuit(), (int) card.GetFaceValue()] = LoadImage("Cards", cardImageName); // 
                            }
                        } //end for(Suit suit ...      
            

        }//end Images



        /// <summary>
        /// Used by the constructor in this class only.  Do NOT use elsewhere.
        /// </summary>
        private static Bitmap LoadImage(string subfolderName, string imageName) {
            string fileSpec = string.Format(@".\Images\{0}\{1}.png", subfolderName, imageName);
            Bitmap bitmap = new Bitmap(fileSpec);
            return bitmap;
        }
    
      

        /// <summary>
        /// Returns the image for the back (i.e. reverse side) of each card.
        /// </summary>
        /// <param name="card"></param>
        /// <returns>the image for the back of each card.</returns>
        public static Bitmap GetBackOfCardImage() {
            return backOfCardImage;
        }



                private static string GetCardImageName(Card card) {
                    Suit suit = card.GetSuit();
                    FaceValue facevalue = card.GetFaceValue();
                    return string.Format("{0}{1}", suit.ToString().TrimEnd('s'), facevalue);
                }

                public static Bitmap GetCardImage(Card card) {
                    return cardImages[(int)card.GetSuit(), (int)card.GetFaceValue()];
                    
                }


    }//end class Images
}
