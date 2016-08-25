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
            this.lblTemplateSimple = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.imgContinue = new System.Windows.Forms.PictureBox();
            this.imgTemplatePreview = new System.Windows.Forms.PictureBox();
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemplatePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemplateSimple
            // 
            this.lblTemplateSimple.AutoSize = true;
            this.lblTemplateSimple.Location = new System.Drawing.Point(540, 352);
            this.lblTemplateSimple.Name = "lblTemplateSimple";
            this.lblTemplateSimple.Size = new System.Drawing.Size(68, 13);
            this.lblTemplateSimple.TabIndex = 1;
            this.lblTemplateSimple.Text = "Simple Table";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Selected Template:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(12, 17);
            this.statusLabel.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preview";
            // 
            // imgContinue
            // 
            this.imgContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgContinue.Image = global::Grading_System.ProjResource.btn_continue;
            this.imgContinue.Location = new System.Drawing.Point(615, 385);
            this.imgContinue.Name = "imgContinue";
            this.imgContinue.Size = new System.Drawing.Size(162, 66);
            this.imgContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContinue.TabIndex = 6;
            this.imgContinue.TabStop = false;
            this.imgContinue.Click += new System.EventHandler(this.imgContinue_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Template";
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstTemplates);
            this.Controls.Add(this.imgContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTemplateSimple);
            this.Controls.Add(this.imgTemplatePreview);
            this.MaximizeBox = false;
            this.Name = "Templates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Templates";
            this.Activated += new System.EventHandler(this.Templates_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Templates_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemplatePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTemplatePreview;
        private System.Windows.Forms.Label lblTemplateSimple;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgContinue;
        private System.Windows.Forms.ListBox lstTemplates;
        private System.Windows.Forms.Label label2;
    }
}