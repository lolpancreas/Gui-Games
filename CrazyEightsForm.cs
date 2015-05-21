using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Gui_Games;
using Shared_Game_Class_Library;
using Game_Class_Library;


namespace Gui_Games {
    /// <summary>
    /// Provides a GUI for the Crazy Eights game in the SharedGamesClasses.
    /// </summary>
    public partial class CrazyEightsForm : Form {
                
        public CrazyEightsForm() {
            InitializeComponent();
            DrawPilePictureBox.Image = Images.GetBackOfCardImage();
           
        }


        private void pictureBox_Click(object sender, EventArgs e) {
            // Which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            Card clickedCard = (Card)clickedPictureBox.Tag;

            TryToPlayCard(clickedCard);

            //Change instruction label text
            if (!Game_Class_Library.Crazy_Eights_Game.CanBePlayed(clickedCard))
            {
                InstructionLabel.Text = "Can't play that card now.";
                
            }//end if
            
        }

       
       
    
        private void TryToPlayCard(Card clickedCard) {


            // This MessageBox is for debugging purposes only.  
            // Turn the following line into a comment (//), once sure you can click on cards.
            //MessageBox.Show(clickedCard.ToString(/*shortFormat*/ false, /*displaySuit*/ true), "Clicked");
            
            if (Game_Class_Library.Crazy_Eights_Game.CanBePlayed(clickedCard)) {
                
                InstructionLabel.Text = Game_Class_Library.Crazy_Eights_Game.WhichText();
                EightGui(clickedCard);
                Game_Class_Library.Crazy_Eights_Game.PlayCard(clickedCard);
                DisplayGuiHand(Game_Class_Library.Crazy_Eights_Game.GetHand(Game_Class_Library.Crazy_Eights_Game.USER), PlayerHandTableLayoutPanel, Game_Class_Library.Crazy_Eights_Game.USER);
                DiscardPilePictureBox.Image = Images.GetCardImage(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile());

                //If card is not eight, set the current suit to the suit of played card.
                //Otherwise if card is eight, allow player to choose suit.
                if (clickedCard.GetFaceValue() != FaceValue.Eight) {
                    Game_Class_Library.Crazy_Eights_Game.SetCurrentSuit(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile().GetSuit());
                }//end if

                ShowWinner();

                if(!ShowWinner()){
                    RefreshTheFormThenPause();

                    while (!Game_Class_Library.Crazy_Eights_Game.GetCardHasBeenPlayed())
                    { //While computer has not yet played card
                        if (Game_Class_Library.Crazy_Eights_Game.ComputerCanPlay())
                        { //If computer has playable card
                            Game_Class_Library.Crazy_Eights_Game.ComputerPlaysCard(); //Computer plays card
                        } else {
                            Game_Class_Library.Crazy_Eights_Game.ComputerDraw(); //Otherwise draw a card
                        }//end if 
                    }//end while

                    Game_Class_Library.Crazy_Eights_Game.SetCardHasBeenPlayed();
                    Game_Class_Library.Crazy_Eights_Game.SetCurrentSuit(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile().GetSuit());

                    //Update GUI
                    DiscardPilePictureBox.Image = Images.GetCardImage(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile());
                    DisplayGuiHand(Game_Class_Library.Crazy_Eights_Game.GetHand(Game_Class_Library.Crazy_Eights_Game.COMPUTER), ComputerHandTableLayoutPanel, Game_Class_Library.Crazy_Eights_Game.COMPUTER);
                    ShowWinner();

                    if (Game_Class_Library.Crazy_Eights_Game.PlayerCanDraw())
                        
                    {
                        InstructionLabel.Text = "You have no cards that you can play. You must draw a card.";
                    }//end if
                }//end if
            }//end if

            //Unless the player plays an eight, the suit is set to the suit of whatever card is played.
            if (Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile().GetFaceValue() != FaceValue.Eight)
            {
                Game_Class_Library.Crazy_Eights_Game.SetCurrentSuit(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile().GetSuit());
                
            }//end if

            DiscardPilePictureBox.Image = Images.GetCardImage(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile());
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Game_Class_Library.Crazy_Eights_Game.Reset();
            this.Close();
        }

        private void DealButton_Click(object sender, EventArgs e) {
            Game_Class_Library.Crazy_Eights_Game.SetUpGame();
            PlayerHandTableLayoutPanel.Enabled = true;

            if (Game_Class_Library.Crazy_Eights_Game.FirstCardIsEight())
            {
                //Allow player to play any card.
            } else {
                Game_Class_Library.Crazy_Eights_Game.SetCurrentSuit(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile().GetSuit());
                
            }//end if

            //Disable/Enable controls
            DealButton.Enabled = false;
            SortButton.Enabled = true;
            DrawPilePictureBox.Enabled = true;

            //Change instruction label text
            InstructionLabel.Text = "Your turn. Click on one of your cards to play";

            //Display cards
            DisplayGuiHand(Game_Class_Library.Crazy_Eights_Game.GetHand(Game_Class_Library.Crazy_Eights_Game.USER), PlayerHandTableLayoutPanel, Game_Class_Library.Crazy_Eights_Game.USER);
            DisplayGuiHand(Game_Class_Library.Crazy_Eights_Game.GetHand(Game_Class_Library.Crazy_Eights_Game.COMPUTER), ComputerHandTableLayoutPanel, Game_Class_Library.Crazy_Eights_Game.COMPUTER);
            DiscardPilePictureBox.Image = Images.GetCardImage(Game_Class_Library.Crazy_Eights_Game.GetTopCardOnDiscardPile());
        }

        private void SortButton_Click(object sender, EventArgs e) {
            Game_Class_Library.Crazy_Eights_Game.SortHand(Game_Class_Library.Crazy_Eights_Game.USER);
            DisplayGuiHand(Game_Class_Library.Crazy_Eights_Game.GetHand(Game_Class_Library.Crazy_Eights_Game.USER), PlayerHandTableLayoutPanel, Game_Class_Library.Crazy_Eights_Game.USER);
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int person) {
            tableLayoutPanel.Controls.Clear();  // Remove any cards already being shown.

            foreach (Card card in hand) {

                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Tell the PictureBox to use all the space inside its square.
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);

                pictureBox.Image = Images.GetCardImage(card);

                // Allow the user to click on a card in their hand.
                if (person == Game_Class_Library.Crazy_Eights_Game.USER) {
                    // Set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    // Tell the PictureBox which Card object it is a picture of.
                    pictureBox.Tag = card;
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }//end DisplayGuiHand
        }

        private void DrawPilePictureBox_Click(object sender, EventArgs e) {
            //testDrawPileLabel.Text = Game_Class_Library.Crazy_Eights_Game.CountDrawpile().ToString(); //Used to test TurnoverDrawpile()
            if (Game_Class_Library.Crazy_Eights_Game.PlayerCanDraw()) {
                Game_Class_Library.Crazy_Eights_Game.DrawCard();
            } else {
                InstructionLabel.Text = "Cannot draw now. You have at least one card you can play.";
            }//end if
            DisplayGuiHand(Game_Class_Library.Crazy_Eights_Game.GetHand(Game_Class_Library.Crazy_Eights_Game.USER), PlayerHandTableLayoutPanel, Game_Class_Library.Crazy_Eights_Game.USER);
            ShowWinner();
        }

        /// <summary>
        /// Ends game if winner has been determined.
        /// </summary>
        /// <returns>True if there is a winner or if a player has passed</returns>
        private bool ShowWinner() {
            if (Game_Class_Library.Crazy_Eights_Game.DetermineWinner() == Game_Class_Library.Crazy_Eights_Game.USER ||
                Game_Class_Library.Crazy_Eights_Game.DetermineWinner() == Game_Class_Library.Crazy_Eights_Game.COMPUTER ||
                Game_Class_Library.Crazy_Eights_Game.DetermineTie()) {
                
                //Disable/enable controls
                DealButton.Enabled = true;
                SortButton.Enabled = false;
                DrawPilePictureBox.Enabled = false;
                PlayerHandTableLayoutPanel.Enabled = false;

                InstructionLabel.Text = Game_Class_Library.Crazy_Eights_Game.WhichText();
                Game_Class_Library.Crazy_Eights_Game.Reset();
                return true;

            } else if (Game_Class_Library.Crazy_Eights_Game.PlayerPass()){ //If player has 13 unplayable cards in hand
                return true;
            } else if (Game_Class_Library.Crazy_Eights_Game.ComputerPass()) { //If computer has 13 unplayable cards in hand
                return true;
            }else {
                return false;
            }//end if
        }//end ShowWinner

        /// <summary>
        /// Shows ChooseSuitForm if player has used an eight.
        /// </summary>
        /// <param name="chosenCard">Card clicked in player hand.</param>
        private void EightGui(Card chosenCard)
        {
            ChooseSuitForm chooseSuit = new ChooseSuitForm();
            if (Game_Class_Library.Crazy_Eights_Game.PlayerHasEight(chosenCard))
            {
                //chooseSuit.Show();
                if (chooseSuit.ShowDialog() == DialogResult.OK)
                {
                    Game_Class_Library.Crazy_Eights_Game.SetCurrentSuit(chooseSuit.GetSuit());
                }//end if
            }//end if
        }//end EightGui

        private static void RefreshTheFormThenPause() {
            // Let the form display any recent changes to Controls, such as PictureBoxes.
            Application.DoEvents();

            // Wait, then continue.
            const int HALF_SECOND = 500; // milliseconds.
            Thread.Sleep(HALF_SECOND);
        }






    } //end class Crazy_Eights_GameForm
} //end namespace
