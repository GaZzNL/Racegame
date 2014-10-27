namespace Racegame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.BorderUp = new System.Windows.Forms.Label();
            this.BorderDown = new System.Windows.Forms.Label();
            this.BorderLeft = new System.Windows.Forms.Label();
            this.BorderRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BorderUp
            // 
            this.BorderUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderUp.ForeColor = System.Drawing.Color.Black;
            this.BorderUp.Location = new System.Drawing.Point(0, 0);
            this.BorderUp.Name = "BorderUp";
            this.BorderUp.Size = new System.Drawing.Size(1003, 5);
            this.BorderUp.TabIndex = 20;
            this.BorderUp.Text = "label10";
            // 
            // BorderDown
            // 
            this.BorderDown.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderDown.Location = new System.Drawing.Point(0, 724);
            this.BorderDown.Name = "BorderDown";
            this.BorderDown.Size = new System.Drawing.Size(1008, 5);
            this.BorderDown.TabIndex = 21;
            this.BorderDown.Text = "label11";
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderLeft.Location = new System.Drawing.Point(0, 5);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(5, 724);
            this.BorderLeft.TabIndex = 22;
            this.BorderLeft.Text = "label12";
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderRight.Location = new System.Drawing.Point(1003, 5);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(5, 724);
            this.BorderRight.TabIndex = 23;
            this.BorderRight.Text = "label13";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderDown);
            this.Controls.Add(this.BorderUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BorderUp;
        private System.Windows.Forms.Label BorderDown;
        private System.Windows.Forms.Label BorderLeft;
        private System.Windows.Forms.Label BorderRight;
    }
}