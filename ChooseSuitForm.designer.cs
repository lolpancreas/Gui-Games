namespace Gui_Games
{
    partial class ChooseSuitForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ChooseSuitGroupBox = new System.Windows.Forms.GroupBox();
            this.SpadesRadioButton = new System.Windows.Forms.RadioButton();
            this.HeartsRadioButton = new System.Windows.Forms.RadioButton();
            this.DiamondsRadioButton = new System.Windows.Forms.RadioButton();
            this.ClubsRadioButton = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.ChooseSuitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseSuitGroupBox
            // 
            this.ChooseSuitGroupBox.Controls.Add(this.SpadesRadioButton);
            this.ChooseSuitGroupBox.Controls.Add(this.HeartsRadioButton);
            this.ChooseSuitGroupBox.Controls.Add(this.DiamondsRadioButton);
            this.ChooseSuitGroupBox.Controls.Add(this.ClubsRadioButton);
            this.ChooseSuitGroupBox.Location = new System.Drawing.Point(29, 22);
            this.ChooseSuitGroupBox.Name = "ChooseSuitGroupBox";
            this.ChooseSuitGroupBox.Size = new System.Drawing.Size(121, 167);
            this.ChooseSuitGroupBox.TabIndex = 0;
            this.ChooseSuitGroupBox.TabStop = false;
            this.ChooseSuitGroupBox.Text = "Choose a Suit";
            // 
            // SpadesRadioButton
            // 
            this.SpadesRadioButton.AutoSize = true;
            this.SpadesRadioButton.Location = new System.Drawing.Point(19, 135);
            this.SpadesRadioButton.Name = "SpadesRadioButton";
            this.SpadesRadioButton.Size = new System.Drawing.Size(61, 17);
            this.SpadesRadioButton.TabIndex = 3;
            this.SpadesRadioButton.TabStop = true;
            this.SpadesRadioButton.Text = "Spades";
            this.SpadesRadioButton.UseVisualStyleBackColor = true;
            this.SpadesRadioButton.CheckedChanged += new System.EventHandler(this.SpadesRadioButton_CheckedChanged);
            // 
            // HeartsRadioButton
            // 
            this.HeartsRadioButton.AutoSize = true;
            this.HeartsRadioButton.Location = new System.Drawing.Point(19, 99);
            this.HeartsRadioButton.Name = "HeartsRadioButton";
            this.HeartsRadioButton.Size = new System.Drawing.Size(56, 17);
            this.HeartsRadioButton.TabIndex = 2;
            this.HeartsRadioButton.TabStop = true;
            this.HeartsRadioButton.Text = "Hearts";
            this.HeartsRadioButton.UseVisualStyleBackColor = true;
            this.HeartsRadioButton.CheckedChanged += new System.EventHandler(this.HeartsRadioButton_CheckedChanged);
            // 
            // DiamondsRadioButton
            // 
            this.DiamondsRadioButton.AutoSize = true;
            this.DiamondsRadioButton.Location = new System.Drawing.Point(19, 62);
            this.DiamondsRadioButton.Name = "DiamondsRadioButton";
            this.DiamondsRadioButton.Size = new System.Drawing.Size(72, 17);
            this.DiamondsRadioButton.TabIndex = 1;
            this.DiamondsRadioButton.TabStop = true;
            this.DiamondsRadioButton.Text = "Diamonds";
            this.DiamondsRadioButton.UseVisualStyleBackColor = true;
            this.DiamondsRadioButton.CheckedChanged += new System.EventHandler(this.DiamondsRadioButton_CheckedChanged);
            // 
            // ClubsRadioButton
            // 
            this.ClubsRadioButton.AutoSize = true;
            this.ClubsRadioButton.Location = new System.Drawing.Point(19, 28);
            this.ClubsRadioButton.Name = "ClubsRadioButton";
            this.ClubsRadioButton.Size = new System.Drawing.Size(51, 17);
            this.ClubsRadioButton.TabIndex = 0;
            this.ClubsRadioButton.TabStop = true;
            this.ClubsRadioButton.Text = "Clubs";
            this.ClubsRadioButton.UseVisualStyleBackColor = true;
            this.ClubsRadioButton.CheckedChanged += new System.EventHandler(this.ClubsRadioButton_CheckedChanged);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(39, 209);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(93, 34);
            this.OkButton.TabIndex = 19;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ChooseSuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(176, 255);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ChooseSuitGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseSuitForm";
            this.Text = "ChooseSuitForm";
            this.Load += new System.EventHandler(this.ChooseSuitForm_Load);
            this.ChooseSuitGroupBox.ResumeLayout(false);
            this.ChooseSuitGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChooseSuitGroupBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton ClubsRadioButton;
        private System.Windows.Forms.RadioButton DiamondsRadioButton;
        private System.Windows.Forms.RadioButton HeartsRadioButton;
        private System.Windows.Forms.RadioButton SpadesRadioButton;
    }
}