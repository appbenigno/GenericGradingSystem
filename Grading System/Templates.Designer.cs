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
            this.label2 = new System.Windows.Forms.Label();
            this.imgContinue = new System.Windows.Forms.PictureBox();
            this.imgeTemplateTheme1 = new System.Windows.Forms.PictureBox();
            this.imgeTemplateSimple = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgeTemplateTheme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgeTemplateSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemplateSimple
            // 
            this.lblTemplateSimple.AutoSize = true;
            this.lblTemplateSimple.Location = new System.Drawing.Point(133, 281);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Theme 1";
            // 
            // imgContinue
            // 
            this.imgContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgContinue.Image = global::Grading_System.ProjResource.btn_continue;
            this.imgContinue.Location = new System.Drawing.Point(467, 449);
            this.imgContinue.Name = "imgContinue";
            this.imgContinue.Size = new System.Drawing.Size(162, 66);
            this.imgContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgContinue.TabIndex = 6;
            this.imgContinue.TabStop = false;
            this.imgContinue.Click += new System.EventHandler(this.imgContinue_Click);
            // 
            // imgeTemplateTheme1
            // 
            this.imgeTemplateTheme1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgeTemplateTheme1.Image = global::Grading_System.ProjResource.template_simple;
            this.imgeTemplateTheme1.Location = new System.Drawing.Point(326, 79);
            this.imgeTemplateTheme1.Name = "imgeTemplateTheme1";
            this.imgeTemplateTheme1.Size = new System.Drawing.Size(267, 199);
            this.imgeTemplateTheme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgeTemplateTheme1.TabIndex = 4;
            this.imgeTemplateTheme1.TabStop = false;
            // 
            // imgeTemplateSimple
            // 
            this.imgeTemplateSimple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgeTemplateSimple.Image = global::Grading_System.ProjResource.template_simple;
            this.imgeTemplateSimple.Location = new System.Drawing.Point(29, 79);
            this.imgeTemplateSimple.Name = "imgeTemplateSimple";
            this.imgeTemplateSimple.Size = new System.Drawing.Size(267, 199);
            this.imgeTemplateSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgeTemplateSimple.TabIndex = 0;
            this.imgeTemplateSimple.TabStop = false;
            this.imgeTemplateSimple.Click += new System.EventHandler(this.imgeTemplateSimple_Click);
            // 
            // Templates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 540);
            this.Controls.Add(this.imgContinue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgeTemplateTheme1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTemplateSimple);
            this.Controls.Add(this.imgeTemplateSimple);
            this.MaximizeBox = false;
            this.Name = "Templates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Templates";
            this.Activated += new System.EventHandler(this.Templates_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Templates_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgeTemplateTheme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgeTemplateSimple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgeTemplateSimple;
        private System.Windows.Forms.Label lblTemplateSimple;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgeTemplateTheme1;
        private System.Windows.Forms.PictureBox imgContinue;
    }
}