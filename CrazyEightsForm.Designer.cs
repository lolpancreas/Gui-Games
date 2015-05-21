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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.DrawPilePictureBox = new System.Windows.Forms.PictureBox();
            this.DiscardPilePictureBox = new System.Windows.Forms.PictureBox();
            this.ComputerHandTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHandTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DealButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.testDrawPileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardPilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.Location = new System.Drawing.Point(410, 184);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(163, 46);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Click Deal to start the game";
            this.InstructionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DrawPilePictureBox
            // 
            this.DrawPilePictureBox.Enabled = false;
            this.DrawPilePictureBox.Location = new System.Drawing.Point(181, 160);
            this.DrawPilePictureBox.Name = "DrawPilePictureBox";
            this.DrawPilePictureBox.Size = new System.Drawing.Size(72, 95);
            this.DrawPilePictureBox.TabIndex = 1;
            this.DrawPilePictureBox.TabStop = false;
            this.DrawPilePictureBox.Click += new System.EventHandler(this.DrawPilePictureBox_Click);
            // 
            // DiscardPilePictureBox
            // 
            this.DiscardPilePictureBox.Location = new System.Drawing.Point(296, 160);
            this.DiscardPilePictureBox.Name = "DiscardPilePictureBox";
            this.DiscardPilePictureBox.Size = new System.Drawing.Size(72, 95);
            this.DiscardPilePictureBox.TabIndex = 2;
            this.DiscardPilePictureBox.TabStop = false;
            // 
            // ComputerHandTableLayoutPanel
            // 
            this.ComputerHandTableLayoutPanel.AutoSize = true;
            this.ComputerHandTableLayoutPanel.ColumnCount = 13;
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.ComputerHandTableLayoutPanel.Location = new System.Drawing.Point(16, 44);
            this.ComputerHandTableLayoutPanel.Name = "ComputerHandTableLayoutPanel";
            this.ComputerHandTableLayoutPanel.RowCount = 1;
            this.ComputerHandTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComputerHandTableLayoutPanel.Size = new System.Drawing.Size(572, 95);
            this.ComputerHandTableLayoutPanel.TabIndex = 3;
            // 
            // PlayerHandTableLayoutPanel
            // 
            this.PlayerHandTableLayoutPanel.AutoSize = true;
            this.PlayerHandTableLayoutPanel.ColumnCount = 13;
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.PlayerHandTableLayoutPanel.Location = new System.Drawing.Point(16, 280);
            this.PlayerHandTableLayoutPanel.Name = "PlayerHandTableLayoutPanel";
            this.PlayerHandTableLayoutPanel.RowCount = 1;
            this.PlayerHandTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerHandTableLayoutPanel.Size = new System.Drawing.Size(572, 95);
            this.PlayerHandTableLayoutPanel.TabIndex = 4;
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.Location = new System.Drawing.Point(232, 378);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(81, 29);
            this.PlayerLabel.TabIndex = 6;
            this.PlayerLabel.Text = "Player";
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.AutoSize = true;
            this.ComputerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerLabel.Location = new System.Drawing.Point(228, 8);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.Size = new System.Drawing.Size(119, 29);
            this.ComputerLabel.TabIndex = 5;
            this.ComputerLabel.Text = "Computer";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(495, 413);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(93, 34);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel Game";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(16, 413);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(93, 34);
            this.DealButton.TabIndex = 18;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Enabled = false;
            this.SortButton.Location = new System.Drawing.Point(220, 413);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(93, 34);
            this.SortButton.TabIndex = 19;
            this.SortButton.Text = "Sort Cards";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // testDrawPileLabel
            // 
            this.testDrawPileLabel.AutoSize = true;
            this.testDrawPileLabel.Location = new System.Drawing.Point(38, 216);
            this.testDrawPileLabel.Name = "testDrawPileLabel";
            this.testDrawPileLabel.Size = new System.Drawing.Size(35, 13);
            this.testDrawPileLabel.TabIndex = 20;
            this.testDrawPileLabel.Text = "label1";
            this.testDrawPileLabel.Visible = false;
            // 
            // CrazyEightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(845, 459);
            this.Controls.Add(this.testDrawPileLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.ComputerLabel);
            this.Controls.Add(this.PlayerHandTableLayoutPanel);
            this.Controls.Add(this.ComputerHandTableLayoutPanel);
            this.Controls.Add(this.DiscardPilePictureBox);
            this.Controls.Add(this.DrawPilePictureBox);
            this.Controls.Add(this.InstructionLabel);
            this.Name = "CrazyEightsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crazy Eights";
            ((System.ComponentModel.ISupportInitialize)(this.DrawPilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscardPilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.PictureBox DiscardPilePictureBox;
        private System.Windows.Forms.TableLayoutPanel ComputerHandTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel PlayerHandTableLayoutPanel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.PictureBox DrawPilePictureBox;
        private System.Windows.Forms.Label testDrawPileLabel;

    }
}