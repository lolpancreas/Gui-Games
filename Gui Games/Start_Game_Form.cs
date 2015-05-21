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

namespace Gui_Games {
    public partial class Start_Game_Form : Form {
        public Start_Game_Form() {
            InitializeComponent();
        }

        string chosenGame = "";

        private void Start_Game_Form_Load(object sender, EventArgs e)
        {
            cb_GameSelect.Items.Add("Crazy Eights");
            cb_GameSelect.Items.Add("Solitaire");

            

        }

        private void cb_GameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_GameSelect.Text == (string)cb_GameSelect.Text)
            {
                buttonStart.Enabled = true;
                chosenGame = cb_GameSelect.Text;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (chosenGame == "Crazy Eights")
            {
                
                
                  

            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
