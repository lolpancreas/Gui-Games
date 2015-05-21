using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Game_Class_Library;
using Gui_Games;
using Game_Class_Library;

namespace Gui_Games
{
    public partial class SolitaireForm : Form
    {
        public SolitaireForm()
        {
            InitializeComponent();
            pb_DrawPile.Image = Images.GetBackOfCardImage();
            Solitaire.SetUpGame();
        }

        private void SolitaireForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pb_DrawPile_Click(object sender, EventArgs e)
        {
            Solitaire.DealCard();
            Card card = Solitaire.GetTopCardOnDrawPile();
            pb_DiscardPile.Image = Images.GetCardImage(card);
            

            
        }
    }
}
