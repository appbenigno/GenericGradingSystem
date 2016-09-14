namespace Grading_System
{
    partial class Templates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Templates));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.imgOK = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgTemplatePreview = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemplatePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(107, 17);
            this.toolStripStatusLabel1.Text = "Selected Template:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(12, 17);
            this.statusLabel.Text = "-";
            // 
            // lstTemplates
            // 
            this.lstTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.ItemHeight = 24;
            this.lstTemplates.Location = new System.Drawing.Point(36, 70);
            this.lstTemplates.Name = "lstTemplates";
            this.lstTemplates.Size = new System.Drawing.Size(250, 364);
            this.lstTemplates.TabIndex = 7;
            this.lstTemplates.SelectedIndexChanged += new System.EventHandler(this.lstTemplates_SelectedIndexChanged);
            // 
            // imgOK
            // 
            this.imgOK.BackColor = System.Drawing.Color.Transparent;
            this.imgOK.Image = global::Grading_System.ProjResource.button_ok;
            this.imgOK.Location = new System.Drawing.Point(635, 417);
            this.imgOK.Name = "imgOK";
            this.imgOK.Size = new System.Drawing.Size(142, 35);
            this.imgOK.TabIndex = 10;
            this.imgOK.TabStop = false;
            this.imgOK.Click += new System.EventHandler(this.imgOK_Click);
            this.imgOK.MouseLeave += new System.EventHandler(this.imgOK_MouseLeave);
            this.imgOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgOK_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Grading_System.ProjResource.lbl_preview;
            this.pictureBox2.Location = new System.Drawing.Point(376, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 28);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grading_System.ProjResource.lbl_selecttemplate;
            this.pictureBox1.Location = new System.Drawing.Point(36, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 28);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // imgTemplatePreview
            // 
            this.imgTemplatePreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgTemplatePreview.Location = new System.Drawing.Point(376, 70);
            this.imgTemplatePreview.Name = "imgTemplatePreview";
            this.imgTemplatePreview.Size = new System.Drawing.Size(401, 279);
            this.imgTemplatePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTemplatePreview.TabIndex = 0;
            this.imgTemplatePreview.TabStop = false;
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 493);
            this.Controls.Add(this.imgOK);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstTemplates);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.imgTemplatePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Templates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Templates";
            this.Activated += new System.EventHandler(this.Templates_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Templates_FormClosing);
            this.Load += new System.EventHandler(this.Templates_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemplatePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTemplatePreview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ListBox lstTemplates;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgOK;
    }
}