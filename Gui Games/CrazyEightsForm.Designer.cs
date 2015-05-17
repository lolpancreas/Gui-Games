namespace Gui_Games
{
    partial class CrazyEightsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Computer = new System.Windows.Forms.Label();
            this.label_Player = new System.Windows.Forms.Label();
            this.button_Deal = new System.Windows.Forms.Button();
            this.button_SortHand = new System.Windows.Forms.Button();
            this.button_CancelGame = new System.Windows.Forms.Button();
            this.label_Instructions = new System.Windows.Forms.Label();
            this.panel_Player = new System.Windows.Forms.TableLayoutPanel();
            this.panel_computer = new System.Windows.Forms.TableLayoutPanel();
            this.pb_DiscardPile = new System.Windows.Forms.PictureBox();
            this.pb_DrawPile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DiscardPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DrawPile)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Computer
            // 
            this.label_Computer.AutoSize = true;
            this.label_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Computer.Location = new System.Drawing.Point(253, 9);
            this.label_Computer.Name = "label_Computer";
            this.label_Computer.Size = new System.Drawing.Size(105, 25);
            this.label_Computer.TabIndex = 0;
            this.label_Computer.Text = "Computer";
            // 
            // label_Player
            // 
            this.label_Player.AutoSize = true;
            this.label_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Player.Location = new System.Drawing.Point(285, 396);
            this.label_Player.Name = "label_Player";
            this.label_Player.Size = new System.Drawing.Size(73, 25);
            this.label_Player.TabIndex = 1;
            this.label_Player.Text = "Player";
            // 
            // button_Deal
            // 
            this.button_Deal.Location = new System.Drawing.Point(60, 410);
            this.button_Deal.Name = "button_Deal";
            this.button_Deal.Size = new System.Drawing.Size(75, 23);
            this.button_Deal.TabIndex = 2;
            this.button_Deal.Text = "Deal";
            this.button_Deal.UseVisualStyleBackColor = true;
            this.button_Deal.Click += new System.EventHandler(this.button_Deal_Click);
            // 
            // button_SortHand
            // 
            this.button_SortHand.Enabled = false;
            this.button_SortHand.Location = new System.Drawing.Point(239, 445);
            this.button_SortHand.Name = "button_SortHand";
            this.button_SortHand.Size = new System.Drawing.Size(119, 23);
            this.button_SortHand.TabIndex = 3;
            this.button_SortHand.Text = "Sort Player\'s Hand";
            this.button_SortHand.UseVisualStyleBackColor = true;
            // 
            // button_CancelGame
            // 
            this.button_CancelGame.Location = new System.Drawing.Point(517, 410);
            this.button_CancelGame.Name = "button_CancelGame";
            this.button_CancelGame.Size = new System.Drawing.Size(75, 23);
            this.button_CancelGame.TabIndex = 4;
            this.button_CancelGame.Text = "Cancel Game";
            this.button_CancelGame.UseVisualStyleBackColor = true;
            this.button_CancelGame.Click += new System.EventHandler(this.button_CancelGame_Click);
            // 
            // label_Instructions
            // 
            this.label_Instructions.AutoSize = true;
            this.label_Instructions.BackColor = System.Drawing.Color.White;
            this.label_Instructions.Location = new System.Drawing.Point(411, 195);
            this.label_Instructions.Name = "label_Instructions";
            this.label_Instructions.Size = new System.Drawing.Size(181, 39);
            this.label_Instructions.TabIndex = 9;
            this.label_Instructions.Text = "\r\n                                                          \r\n\r\n";
            this.label_Instructions.Click += new System.EventHandler(this.label_Instructions_Click);
            // 
            // panel_Player
            // 
            this.panel_Player.AutoSize = true;
            this.panel_Player.ColumnCount = 13;
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_Player.Location = new System.Drawing.Point(22, 279);
            this.panel_Player.Name = "panel_Player";
            this.panel_Player.RowCount = 1;
            this.panel_Player.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_Player.Size = new System.Drawing.Size(570, 95);
            this.panel_Player.TabIndex = 8;
            this.panel_Player.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Player_Paint);
            this.panel_Player.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_Player_MouseClick);
            // 
            // panel_computer
            // 
            this.panel_computer.AutoSize = true;
            this.panel_computer.ColumnCount = 13;
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.panel_computer.Location = new System.Drawing.Point(17, 50);
            this.panel_computer.Name = "panel_computer";
            this.panel_computer.RowCount = 1;
            this.panel_computer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_computer.Size = new System.Drawing.Size(570, 95);
            this.panel_computer.TabIndex = 8;
            this.panel_computer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_computer_Paint);
            // 
            // pb_DiscardPile
            // 
            this.pb_DiscardPile.Location = new System.Drawing.Point(303, 163);
            this.pb_DiscardPile.Name = "pb_DiscardPile";
            this.pb_DiscardPile.Size = new System.Drawing.Size(70, 95);
            this.pb_DiscardPile.TabIndex = 6;
            this.pb_DiscardPile.TabStop = false;
            // 
            // pb_DrawPile
            // 
            this.pb_DrawPile.Location = new System.Drawing.Point(166, 163);
            this.pb_DrawPile.Name = "pb_DrawPile";
            this.pb_DrawPile.Size = new System.Drawing.Size(70, 95);
            this.pb_DrawPile.TabIndex = 5;
            this.pb_DrawPile.TabStop = false;
            // 
            // CrazyEightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(693, 505);
            this.Controls.Add(this.label_Instructions);
            this.Controls.Add(this.panel_Player);
            this.Controls.Add(this.panel_computer);
            this.Controls.Add(this.pb_DiscardPile);
            this.Controls.Add(this.pb_DrawPile);
            this.Controls.Add(this.button_CancelGame);
            this.Controls.Add(this.button_SortHand);
            this.Controls.Add(this.button_Deal);
            this.Controls.Add(this.label_Player);
            this.Controls.Add(this.label_Computer);
            this.Name = "CrazyEightsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CrazyEightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_DiscardPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_DrawPile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Computer;
        private System.Windows.Forms.Label label_Player;
        private System.Windows.Forms.Button button_Deal;
        private System.Windows.Forms.Button button_SortHand;
        private System.Windows.Forms.Button button_CancelGame;
        private System.Windows.Forms.PictureBox pb_DrawPile;
        private System.Windows.Forms.PictureBox pb_DiscardPile;
        private System.Windows.Forms.TableLayoutPanel panel_computer;
        private System.Windows.Forms.TableLayoutPanel panel_Player;
        private System.Windows.Forms.Label label_Instructions;

    }
}