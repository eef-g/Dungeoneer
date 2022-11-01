﻿namespace DungeonDelver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fightButton = new System.Windows.Forms.Button();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.blockButton = new System.Windows.Forms.Button();
            this.healButton = new System.Windows.Forms.Button();
            this.tauntButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.RichTextBox();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // fightButton
            // 
            this.fightButton.Location = new System.Drawing.Point(8, 402);
            this.fightButton.Margin = new System.Windows.Forms.Padding(2);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(185, 81);
            this.fightButton.TabIndex = 0;
            this.fightButton.Text = "FIGHT";
            this.fightButton.UseVisualStyleBackColor = true;
            this.fightButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundImage
            // 
            this.backgroundImage.Image = global::DungeonDelver.Properties.Resources.Wall;
            this.backgroundImage.Location = new System.Drawing.Point(8, 12);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(382, 278);
            this.backgroundImage.TabIndex = 1;
            this.backgroundImage.TabStop = false;
            // 
            // blockButton
            // 
            this.blockButton.Location = new System.Drawing.Point(205, 402);
            this.blockButton.Margin = new System.Windows.Forms.Padding(2);
            this.blockButton.Name = "blockButton";
            this.blockButton.Size = new System.Drawing.Size(185, 81);
            this.blockButton.TabIndex = 2;
            this.blockButton.Text = "BLOCK";
            this.blockButton.UseVisualStyleBackColor = true;
            this.blockButton.Click += new System.EventHandler(this.blockButton_Click);
            // 
            // healButton
            // 
            this.healButton.Location = new System.Drawing.Point(8, 487);
            this.healButton.Margin = new System.Windows.Forms.Padding(2);
            this.healButton.Name = "healButton";
            this.healButton.Size = new System.Drawing.Size(185, 81);
            this.healButton.TabIndex = 3;
            this.healButton.Text = "HEAL";
            this.healButton.UseVisualStyleBackColor = true;
            this.healButton.Click += new System.EventHandler(this.healButton_Click);
            // 
            // tauntButton
            // 
            this.tauntButton.Location = new System.Drawing.Point(205, 487);
            this.tauntButton.Margin = new System.Windows.Forms.Padding(2);
            this.tauntButton.Name = "tauntButton";
            this.tauntButton.Size = new System.Drawing.Size(185, 81);
            this.tauntButton.TabIndex = 4;
            this.tauntButton.Text = "TAUNT";
            this.tauntButton.UseVisualStyleBackColor = true;
            this.tauntButton.Click += new System.EventHandler(this.tauntButton_Click);
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusText.ForeColor = System.Drawing.Color.Gold;
            this.statusText.Location = new System.Drawing.Point(8, 296);
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(382, 101);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "> This is a test to see how the status text will be\n> [ALERT] Low Health\n> [LOOT]" +
    " You got a sword\n> Action Text\n> [RESULTS] XP Gain";
            // 
            // imageDisplay
            // 
            this.imageDisplay.BackColor = System.Drawing.Color.Transparent;
            this.imageDisplay.BackgroundImage = global::DungeonDelver.Properties.Resources.CreatureBackground;
            this.imageDisplay.Location = new System.Drawing.Point(113, 94);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(184, 196);
            this.imageDisplay.TabIndex = 6;
            this.imageDisplay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 570);
            this.Controls.Add(this.imageDisplay);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.tauntButton);
            this.Controls.Add(this.healButton);
            this.Controls.Add(this.blockButton);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.fightButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dungen Delver";
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button fightButton;
        private PictureBox backgroundImage;
        private Button blockButton;
        private Button healButton;
        private Button tauntButton;
        private RichTextBox statusText;
        private PictureBox imageDisplay;
    }
}