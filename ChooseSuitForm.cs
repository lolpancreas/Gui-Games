using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shared_Game_Class_Library;
using Gui_Games;



namespace Gui_Games {
    public partial class ChooseSuitForm : Form {
        private const int NONE_CHECKED = 0;
        private const int CLUBS_CHECKED = 1;
        private const int DIAMONDS_CHECKED = 2;
        private const int HEARTS_CHECKED = 3;
        private const int SPADES_CHECKED = 4;

        private int whichRadioButton = NONE_CHECKED;
        private bool isChecked = false;

        public ChooseSuitForm() {
            InitializeComponent();
            
        }

        private void OkButton_Click(object sender, EventArgs e) {
            if (isChecked) {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            /*
            DialogResult dialogResult = DialogResult.OK;
            
            if(dialogResult == DialogResult.OK){
                CrazyEights.SetCurrentSuit(GetSuit());
                this.Close();
            }//end if
             */
        }

        private void ClubsRadioButton_CheckedChanged(object sender, EventArgs e) {
            whichRadioButton = CLUBS_CHECKED;
            isChecked = true;
        }

        private void DiamondsRadioButton_CheckedChanged(object sender, EventArgs e) {
            whichRadioButton = DIAMONDS_CHECKED;
            isChecked = true;
        }

        private void HeartsRadioButton_CheckedChanged(object sender, EventArgs e) {
            whichRadioButton = HEARTS_CHECKED;
            isChecked = true;
        }

        private void SpadesRadioButton_CheckedChanged(object sender, EventArgs e) {
            whichRadioButton = SPADES_CHECKED;
            isChecked = true;
        }

        //Returns suit based on which radio button is checked
        public Suit GetSuit() {
            Suit suit = new Suit();

            switch (whichRadioButton) {
                case CLUBS_CHECKED:
                    suit = Suit.Clubs;
                    break;
                case DIAMONDS_CHECKED:
                    suit = Suit.Diamonds;
                    break;
                case HEARTS_CHECKED:
                    suit = Suit.Hearts;
                    break;
                case SPADES_CHECKED:
                    suit = Suit.Spades;
                    break;
                default:
                    break;
            }
            //CrazyEights.SetCurrentSuit(suit);
            return suit;
        }

        private void ChooseSuitForm_Load(object sender, EventArgs e)
        {

        }//end GetSuit
    }
}

