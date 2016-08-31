namespace Grading_System
{
    partial class Login
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
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.imgContinue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinue)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::Grading_System.ProjResource.splashlogo1;
            this.imgLogo.Location = new System.Drawing.Point(115, 139);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(530, 136);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // imgContinue
            // 
            this.imgContinue.BackColor = System.Drawing.Color.Transparent;
            this.imgContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgContinue.Image = global::Grading_System.ProjResource.button_continue;
            this.imgContinue.Location = new System.Drawing.Point(513, 439);
            this.imgContinue.Name = "imgContinue";
            this.imgContinue.Size = new System.Drawing.Size(228, 45);
            this.imgContinue.TabIndex = 3;
            this.imgContinue.TabStop = false;
            this.imgContinue.Click += new System.EventHandler(this.imgContinue_Click);
            this.imgContinue.MouseLeave += new System.EventHandler(this.imgContinue_MouseLeave);
            this.imgContinue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgContinue_MouseMove);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Grading_System.ProjResource.book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(762, 496);
            this.ControlBox = false;
            this.Controls.Add(this.imgContinue);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgContinue;
    }
}