using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Shared_Game_Class_Library;

namespace Game_Class_Library {

    public static class Crazy_Eights_Game {

        public const int NUM_OF_PLAYERS = 2;
        public const int USER = 0;
        public const int COMPUTER = 1;

        private const string COMPUTERS_NAME = "Computer";

        private const int NUM_OF_STARTING_CARDS = 8;

        private const int MAX_CARDS = 13;
        private const int NO_ONE = 2;
        private const int NO_CARDS = 0;

        //Used in a switch statement to determine which strings to display in instruction label
        private static int determineText;
        private const int PLAYER_TURN_TEXT = 0;
        private const int CARD_UNPLAYABLE_TEXT = 1;
        private const int CANNOT_DRAW_TEXT = 2;
        private const int PLAYER_DRAW_TEXT = 3;
        private const int PLAYER_WIN_TEXT = 4;
        private const int COMPUTER_WIN_TEXT = 5;
        private const int TIE_TEXT = 6;

        private static bool canDraw = false; //Player is able to draw.
        private static bool firstCard = true; //First card dealt.
        private static bool computerCanPlay = true; //Computer is able to play a card.
        private static bool computerHasPlayed = false; //Computer has played a card.

        private static CardPile drawPile;     // The pile of cards that the players can draw from.
        private static CardPile discardPile;  // The pile of cards discarded by the players.

        private static Hand[] hands = new Hand[NUM_OF_PLAYERS];

        private static Suit currentSuit;

        /// <summary>
        /// Set up to play the game, 
        /// by shuffling the drawPile of cards 
        /// and then dealing the two hands.
        /// </summary>
        public static void SetUpGame()
        {
            drawPile = new CardPile(true);
            drawPile.Shuffle();
            hands[USER] = new Hand(drawPile.DealCards(NUM_OF_STARTING_CARDS));
            hands[COMPUTER] = new Hand(drawPile.DealCards(NUM_OF_STARTING_CARDS));
            SetUpTheDiscardPile();
            SortHand(USER);
            SortHand(COMPUTER); //optional
        } //end SetUpGame



        private static void SetUpTheDiscardPile()
        {
            discardPile = new CardPile();
            Card card = drawPile.DealOneCard();
            discardPile.AddCard(card);
            

        }


        /* The following methods are intended to be called by your GUI code.
         * 
         *  do not delete them. */

        /// <summary>
        /// Helps the GUI to display what is in a player's hand.
        /// </summary>
        /// <returns>the Hand of the specified player</returns>
        public static Hand GetHand(int player)
        {
            return hands[player];
        }

        /// <summary>
        /// Helps the GUI to sort a player's hand.
        /// </summary>
        /// <returns>the Hand of the specified player</returns>
        public static void SortHand(int player)
        {
            hands[player].SortHand();
        }

        /// <summary>
        /// Helps the GUI to display what is on the top of the discard pile.
        /// </summary>
        /// <returns>the card on the top of the discard pile.</returns>
        public static Card GetTopCardOnDiscardPile()
        {
            return discardPile.GetLastCardInPile();
        }

        /// <summary>
        /// Tells the GUI whether there are any cards left in the draw pile.
        /// </summary>
        /// <returns>True, if there is at least one card in the draw pile. False, otherwise.</returns>
        public static bool DrawPileHasCards()
        {
            return (drawPile.GetCount() > 0);
        }

        /// <summary>
        /// Lets the GUI set the current Suit.
        /// </summary>    
        public static void SetCurrentSuit(Suit chosenSuit)
        {
            currentSuit = chosenSuit;
        }

        /// <summary>
        /// Allows the player to play a card.
        /// </summary>
        /// <param name="cardFromHand">Card selected from GUI card click</param>
        public static void PlayCard(Card cardFromHand)
        {
            discardPile.DealOneCard();
            hands[USER].RemoveCard(cardFromHand);
        }//end PlayCard

        /// <summary>
        /// Allows player to draw a card from the draw pile.
        /// 
        /// Pre : Player has no playable cards and less than 13 cards in their hand.
        /// Post: Card is added to player's hand.
        /// </summary>
        public static void DrawCard()
        {
            Card card = drawPile.DealOneCard();

            if (!DrawPileHasCards())
            {
                TurnoverDrawpile();
            }//end if

            if (hands[USER].GetCount() < MAX_CARDS)
            {
                hands[USER].Add(card);
            }//end if
        }//end DrawCard

        /// <summary>
        /// Determines whether a card can be played;
        /// Ie. Card is has same suit or face value as top card on discard pile 
        /// or is an eight.
        /// </summary>
        /// <param name="chosenCard">Card clicked on GUI</param>
        /// <returns>True if card is playable, false if card is unplayable</returns>
        public static bool CanBePlayed(Card chosenCard)
        {
            if (chosenCard.GetSuit() == currentSuit)
            { //If same suit
                firstCard = false;
                return true;
            }
            else if (chosenCard.GetFaceValue() == GetTopCardOnDiscardPile().GetFaceValue() //If same face value
                  || chosenCard.GetFaceValue() == FaceValue.Eight)
            { //If card is an eight
                firstCard = false;
                return true;
            }
            else if (FirstCardIsEight() && firstCard)
            {
                //If the first card dealt is an eight, player can play any card
                firstCard = false;
                return true;
            }
            else
            {
                return false;
            }//end if        
        }//end CanBePlayed

        /// <summary>
        /// Determines if there is a winner.
        /// </summary>
        /// <returns>Winner is either player, computer or no one</returns>
        public static int DetermineWinner()
        {
            int winner = NO_ONE;

            if (hands[USER].GetCount() == NO_CARDS)
            {
                winner = USER;
                determineText = PLAYER_WIN_TEXT;
            }
            else if (hands[COMPUTER].GetCount() == NO_CARDS)
            {
                winner = COMPUTER;
                determineText = COMPUTER_WIN_TEXT;
            }//end if
            return winner;
        }//end DetermineWinner

        /// <summary>
        /// Determines whether the player uses an eight.
        /// Called from GUI.
        /// </summary>
        /// <param name="chosenCard">Card clicked from GUI</param>
        /// <returns>True if player has used an eight, otherwise false</returns>
        public static bool PlayerHasEight(Card chosenCard)
        {
            if (chosenCard.GetFaceValue() == FaceValue.Eight)
            {
                return true;
            }
            else
            {
                return false;
            }//end if
        }//end PlayerHasEight

        /// <summary>
        /// Determines which text the information label should display.
        /// Text unrelated to win conditions is now changed in GUI.
        /// </summary>
        /// <returns>Approppriate instruction label message as a string</returns>
        public static string WhichText()
        {
            string text = "";

            switch (determineText)
            {
                case PLAYER_TURN_TEXT:
                    text = "Your turn. Click on one of your cards to play";
                    break;
                case CARD_UNPLAYABLE_TEXT:
                    text = "Can't play that card now.";
                    break;
                case CANNOT_DRAW_TEXT:
                    text = "Cannot draw now. You have at least one card you can play.";
                    break;
                case PLAYER_DRAW_TEXT:
                    text = "You have no cards that you can play. You must draw a card.";
                    break;
                case PLAYER_WIN_TEXT:
                    text = "You win. Click Deal to start the game.";
                    break;
                case COMPUTER_WIN_TEXT:
                    text = "The computer wins. Click Deal to start the game.";
                    break;
                case TIE_TEXT:
                    text = "Neither can play. Game is a tie.";
                    break;
                default:
                    break;
            }//end switch
            return text;
        }//end WhichText

        /// <summary>
        /// Determines whether the player can draw a card.
        /// Called from GUI.
        /// Pre : Player does not have any playable cards in their hand.
        /// </summary>
        /// <returns>True if a player has no playable cards in their hand, 
        /// false if player has playable cards in their hand.</returns>
        public static bool PlayerCanDraw()
        {
            canDraw = true;

            foreach (Card card in hands[USER])
            {
                if (CanBePlayed(card))
                {
                    return false;
                }
                else
                {
                }//end if
            }//end foreach
            return canDraw;
        }//end PlayerCanDraw

        /// <summary>
        /// Returns true if the first card dealt is an eight.
        /// Called from GUI.
        /// </summary>
        /// <returns>True if first card dealt is eight, otherwise false.</returns>
        public static bool FirstCardIsEight()
        {
            if (GetTopCardOnDiscardPile().GetFaceValue() == FaceValue.Eight)
            {
                return true;
            }
            else
            {
                return false;
            }//end if
        }//end FirstCardIsEight

        /// <summary>
        /// Allows computer to draw a card.
        /// Called from GUI.
        /// 
        /// Pre : Computer has no playable cards and less than 13 cards in their hand.
        /// Post: Card is added to computer's hand.
        /// </summary>
        public static void ComputerDraw()
        {
            if (!DrawPileHasCards())
            {
                TurnoverDrawpile();
            }//end if            

            if (hands[COMPUTER].GetCount() < MAX_CARDS)
            {
                Card card = drawPile.DealOneCard();
                hands[COMPUTER].Add(card);
                SortHand(COMPUTER);
            }//end if
        }//end ComputerDraw

        /// <summary>
        /// Allows computer to play a card.
        /// Will return if one of the conditions is met; Ie. a card is playable.
        /// 
        /// Pre : Player has played a card.
        ///       Card has the same face value or suit as the top card on the discard pile or card is an eight.
        /// Post: Computer plays a card.
        /// </summary>
        public static void ComputerPlaysCard()
        {
            //Firstly, checks hand for any cards with same face value
            foreach (Card card in hands[COMPUTER])
            {
                if (card.GetFaceValue() == GetTopCardOnDiscardPile().GetFaceValue()
                    && card.GetFaceValue() != FaceValue.Eight){
                    discardPile.AddCard(card);
                    hands[COMPUTER].RemoveCard(card);
                    computerHasPlayed = true;
                    return;
                }//end if
            }//end foreach

            //Secondly, checks hand for any cards with same suit
            foreach (Card card in hands[COMPUTER])
            {
                if (card.GetSuit() == currentSuit && card.GetFaceValue() != FaceValue.Eight){
                    discardPile.AddCard(card);
                    hands[COMPUTER].RemoveCard(card);
                    computerHasPlayed = true;
                    return;
                }//end if
            }//end foreach

            //Lastly, checks if hand has an eight
            foreach (Card card in hands[COMPUTER])
            {
                if (card.GetFaceValue() == FaceValue.Eight)
                {
                    discardPile.AddCard(card);
                    hands[COMPUTER].RemoveCard(card);
                    computerHasPlayed = true;
                    return;
                }//end if
            }//end foreach
        }//end ComputerPlaysCard

        /// <summary>
        /// Returns true if computer has a playable card.
        /// Called from GUI.
        /// 
        /// Pre : The player (NOT computer) has played a card.
        /// Post: Returns true or false.
        /// </summary>
        /// <returns></returns>
        public static bool ComputerCanPlay()
        {
            foreach (Card card in hands[COMPUTER])
            {
                if (card.GetFaceValue() == GetTopCardOnDiscardPile().GetFaceValue() ||
                    card.GetSuit() == currentSuit ||
                    card.GetFaceValue() == FaceValue.Eight)
                {
                    return true;
                }//end if
            }//end foreach
            return false;
        }//end ComputerCanPlay

        /// <summary>
        /// Determines whether the game is tied.
        /// </summary>
        /// <returns>True or false</returns>
        public static bool DetermineTie()
        {
            if (hands[USER].GetCount() == MAX_CARDS && canDraw
                && hands[COMPUTER].GetCount() == MAX_CARDS && !computerCanPlay)
            {
                determineText = TIE_TEXT;
                return true;
            }
            else
            {
                return false;
            }//end if
        }//end DetermineTie

        /// <summary>
        /// Turns the drawpile over so that the game doesn't run out of cards.
        /// 
        /// Pre : Draw pile has no cards in it.
        /// Post: Draw pile is turned over.
        /// </summary>
        public static void TurnoverDrawpile()
        {
            drawPile = discardPile;
            drawPile.Shuffle();
            SetUpTheDiscardPile();
        }//end TurnoverDrawpile


        /// <summary>
        /// Allows computer to play an eight if no other playable cards are in hand.
        /// NOT USED - SEEMS TO STOP PROGRAM FROM FREEZING RANDOMLY.
        /// Pre : Computer has no other cards in hand that have same face value or suit as
        ///       card on the top of the discard pile.
        /// Post: Computer plays eight before resorting to drawing a card.
        /// </summary>
        public static bool ComputerPlaysEight()
        {
            bool playedEight = false;

            foreach (Card card in hands[COMPUTER])
            {
                if (!computerCanPlay && card.GetFaceValue() == FaceValue.Eight)
                {
                    computerCanPlay = true;
                    discardPile.AddCard(card);
                    hands[COMPUTER].RemoveCard(card);
                    SetCurrentSuit(GetTopCardOnDiscardPile().GetSuit());
                    playedEight = true;
                    break;
                }
                else
                {
                    computerCanPlay = false;
                    playedEight = false;
                }//end if
            }//end foreach
            return playedEight;
        }//end ComputerPlays Eight

        /// <summary>
        /// Called from GUI to reset variables for new game.
        /// 
        /// Pre : A game has been won or cancelled.
        /// Post: Bools are reset.
        /// </summary>
        public static void Reset()
        {
            canDraw = false;
            firstCard = true;
            computerCanPlay = true;
        }//end Reset

        /// <summary>
        /// Determines whether a player needs to pass or not.
        /// </summary>
        /// <returns>True if player has 13 unplayable cards in hand, otherwise false.</returns>
        public static bool PlayerPass()
        {
            if (PlayerCanDraw() && hands[USER].GetCount() == MAX_CARDS)
            {
                return true;
            }
            else
            {
                return false;
            }//end if
        }//end PlayerPass

        /// <summary>
        /// Determines whether a computer needs to pass or not.
        /// </summary>
        /// <returns>True if computer has 13 unplayable cards in hand, otherwise false.</returns>
        public static bool ComputerPass()
        {
            if (!computerCanPlay && hands[COMPUTER].GetCount() == MAX_CARDS)
            {
                return true;
            }
            else
            {
                return false;
            }//end if
        }//end ComputerPass

        /// <summary>
        /// Used to test the TurnoverDrawpile method.
        /// </summary>
        /// <returns>Number of cards in draw pile.</returns>
        public static int CountDrawpile()
        {
            return drawPile.GetCount();
        }//end CountDrawpile

        /// <summary>
        /// Returns whether the computer has played a card.
        /// Called from GUI.
        /// </summary>
        /// <returns>Bool computerHasPlayed</returns>
        public static bool GetCardHasBeenPlayed()
        {
            return computerHasPlayed;
        }//end GetCardHasBeenPlayed

        /// <summary>
        /// Sets computerHasPlayed to false.
        /// Called from GUI.
        /// 
        /// Pre : Computer has played a card.
        /// Post: computerHasPlayed is set to false.
        /// </summary>
        public static void SetCardHasBeenPlayed()
        {
            computerHasPlayed = false;
        }//end SetCardHasBeenPlayed

    } //end class Crazy_Eights_Game
} //end namespace
