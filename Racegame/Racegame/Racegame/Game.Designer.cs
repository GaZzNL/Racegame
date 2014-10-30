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
            this.progressBarVehicleOne = new System.Windows.Forms.ProgressBar();
            this.progressBarVehicleTwo = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lapsone = new System.Windows.Forms.Label();
            this.lapstwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarVehicleOne
            // 
            this.progressBarVehicleOne.Location = new System.Drawing.Point(188, 228);
            this.progressBarVehicleOne.Name = "progressBarVehicleOne";
            this.progressBarVehicleOne.Size = new System.Drawing.Size(100, 23);
            this.progressBarVehicleOne.TabIndex = 25;
            // 
            // progressBarVehicleTwo
            // 
            this.progressBarVehicleTwo.Location = new System.Drawing.Point(367, 228);
            this.progressBarVehicleTwo.Name = "progressBarVehicleTwo";
            this.progressBarVehicleTwo.Size = new System.Drawing.Size(100, 23);
            this.progressBarVehicleTwo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(185, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Player one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(364, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Player two";
            // 
            // lapsone
            // 
            this.lapsone.AutoSize = true;
            this.lapsone.BackColor = System.Drawing.Color.Green;
            this.lapsone.Location = new System.Drawing.Point(185, 202);
            this.lapsone.Name = "lapsone";
            this.lapsone.Size = new System.Drawing.Size(33, 13);
            this.lapsone.TabIndex = 32;
            this.lapsone.Text = "Laps:";
            // 
            // lapstwo
            // 
            this.lapstwo.AutoSize = true;
            this.lapstwo.BackColor = System.Drawing.Color.Green;
            this.lapstwo.Location = new System.Drawing.Point(364, 202);
            this.lapstwo.Name = "lapstwo";
            this.lapstwo.Size = new System.Drawing.Size(33, 13);
            this.lapstwo.TabIndex = 33;
            this.lapstwo.Text = "Laps:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lapstwo);
            this.Controls.Add(this.lapsone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarVehicleTwo);
            this.Controls.Add(this.progressBarVehicleOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarVehicleOne;
        private System.Windows.Forms.ProgressBar progressBarVehicleTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lapsone;
        private System.Windows.Forms.Label lapstwo;
    }
}