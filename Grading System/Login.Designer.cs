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
            this.imgEnter = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgEnter
            // 
            this.imgEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEnter.Image = global::Grading_System.ProjResource.btn_enter;
            this.imgEnter.Location = new System.Drawing.Point(207, 388);
            this.imgEnter.Name = "imgEnter";
            this.imgEnter.Size = new System.Drawing.Size(166, 137);
            this.imgEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEnter.TabIndex = 2;
            this.imgEnter.TabStop = false;
            this.imgEnter.Click += new System.EventHandler(this.imgEnter_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::Grading_System.ProjResource.logo;
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(545, 365);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 537);
            this.ControlBox = false;
            this.Controls.Add(this.imgEnter);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox imgEnter;

    }
}