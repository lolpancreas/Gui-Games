﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Game_Class_Library;
using Game_Class_Library;

namespace Gui_Games
{
    public partial class CrazyEightsForm : Form
    {
        Card card = new Card(Suit.Diamonds, FaceValue.King);
        Hand hand = new Hand();
        CardPile cardPile = new CardPile();
        //List<Card> pile = new List<Card>();
        
         
        
        
        
        public CrazyEightsForm()
        {
            InitializeComponent();
           //startGameForm.Close();
                       
        }

        private void CrazyEightsForm_Load(object sender, EventArgs e)
        {

            
            pb_DrawPile.BackgroundImage = Images.GetBackOfCardImage();
            
            cardPile.CardPileBool(true);
            label_Instructions.Text = "Click Deal to start the game.";
            
            
            
            
        }

        private void label_Instructions_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button_Deal_Click(object sender, EventArgs e)
        {
            
            pb_DrawPile.BackgroundImage = null;
          
            List<Card> pile = cardPile.DealCards(8);

            Card dealtCard = cardPile.DealOneCard();
            button_SortHand.Enabled = true;
            button_Deal.Enabled = false;
            label_Instructions.Text = "";
            
            
            
            
            
            
            
           

           // panel_computer.BackgroundImage = Images.GetCardImage(card);

           //foreach (Card card in pile)        
            for (int i = 1; i <= 8; i++)
            {
                Size pictureBoxSize = new Size(72, 95);
                PictureBox computerCard = new PictureBox();
                PictureBox playerCard = new PictureBox();
                playerCard.Size = pictureBoxSize;
                computerCard.Size = pictureBoxSize;

                
                panel_Player.Controls.Add(playerCard);
                playerCard.BackgroundImage = Images.GetCardImage(dealtCard);

                
                computerCard.BackgroundImage = Images.GetCardImage(dealtCard);
                panel_computer.Controls.Add(computerCard);
                
                
            }
            


            
             // card = cardPile.DealOneCard();
               
              // cardPile.DealOneCard();
              // hand.AddCard(card);
          //     panel_computer.BackgroundImage = Images.GetCardImage(card);
           //    
                
           
        }

        private void panel_computer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_CancelGame_Click(object sender, EventArgs e)
        {

            


        }

        private void panel_Player_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Player_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}