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
            this.MousePosition = new System.Windows.Forms.Label();
            this.progressBarVehicleOne = new System.Windows.Forms.ProgressBar();
            this.progressBarVehicleTwo = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // MousePosition
            // 
            this.MousePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MousePosition.Location = new System.Drawing.Point(704, 9);
            this.MousePosition.Name = "MousePosition";
            this.MousePosition.Size = new System.Drawing.Size(292, 30);
            this.MousePosition.TabIndex = 24;
            // 
            // progressBarVehicleOne
            // 
            this.progressBarVehicleOne.Location = new System.Drawing.Point(313, 203);
            this.progressBarVehicleOne.Name = "progressBarVehicleOne";
            this.progressBarVehicleOne.Size = new System.Drawing.Size(100, 23);
            this.progressBarVehicleOne.TabIndex = 25;
            // 
            // progressBarVehicleTwo
            // 
            this.progressBarVehicleTwo.Location = new System.Drawing.Point(453, 202);
            this.progressBarVehicleTwo.Name = "progressBarVehicleTwo";
            this.progressBarVehicleTwo.Size = new System.Drawing.Size(100, 23);
            this.progressBarVehicleTwo.TabIndex = 26;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.progressBarVehicleTwo);
            this.Controls.Add(this.progressBarVehicleOne);
            this.Controls.Add(this.MousePosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MousePosition;
        private System.Windows.Forms.ProgressBar progressBarVehicleOne;
        private System.Windows.Forms.ProgressBar progressBarVehicleTwo;
    }
}