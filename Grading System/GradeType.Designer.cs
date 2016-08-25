namespace Grading_System
{
    partial class GradeType
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
            this.lvGradePreview = new System.Windows.Forms.ListView();
            this.chGradePreview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnLetter = new System.Windows.Forms.Button();
            this.btnGradePoint1 = new System.Windows.Forms.Button();
            this.btnGradePoint4 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGradePreview
            // 
            this.lvGradePreview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGradePreview});
            this.lvGradePreview.Location = new System.Drawing.Point(50, 31);
            this.lvGradePreview.Name = "lvGradePreview";
            this.lvGradePreview.Size = new System.Drawing.Size(108, 251);
            this.lvGradePreview.TabIndex = 0;
            this.lvGradePreview.UseCompatibleStateImageBehavior = false;
            this.lvGradePreview.View = System.Windows.Forms.View.Details;
            // 
            // chGradePreview
            // 
            this.chGradePreview.Text = "Grade Peview";
            this.chGradePreview.Width = 102;
            // 
            // btnPercentage
            // 
            this.btnPercentage.Location = new System.Drawing.Point(199, 31);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(117, 35);
            this.btnPercentage.TabIndex = 1;
            this.btnPercentage.Text = "Percentage Grading";
            this.btnPercentage.UseVisualStyleBackColor = true;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnLetter
            // 
            this.btnLetter.Location = new System.Drawing.Point(199, 72);
            this.btnLetter.Name = "btnLetter";
            this.btnLetter.Size = new System.Drawing.Size(117, 35);
            this.btnLetter.TabIndex = 2;
            this.btnLetter.Text = "Letter Grading";
            this.btnLetter.UseVisualStyleBackColor = true;
            this.btnLetter.Click += new System.EventHandler(this.btnLetter_Click);
            // 
            // btnGradePoint1
            // 
            this.btnGradePoint1.Location = new System.Drawing.Point(199, 113);
            this.btnGradePoint1.Name = "btnGradePoint1";
            this.btnGradePoint1.Size = new System.Drawing.Size(117, 35);
            this.btnGradePoint1.TabIndex = 3;
            this.btnGradePoint1.Text = "Grade Point (1 to 5)";
            this.btnGradePoint1.UseVisualStyleBackColor = true;
            this.btnGradePoint1.Click += new System.EventHandler(this.btnGradePoint1_Click);
            // 
            // btnGradePoint4
            // 
            this.btnGradePoint4.Location = new System.Drawing.Point(199, 154);
            this.btnGradePoint4.Name = "btnGradePoint4";
            this.btnGradePoint4.Size = new System.Drawing.Size(117, 32);
            this.btnGradePoint4.TabIndex = 4;
            this.btnGradePoint4.Text = "Grade Point (4 to 0)";
            this.btnGradePoint4.UseVisualStyleBackColor = true;
            this.btnGradePoint4.Click += new System.EventHandler(this.btnGradePoint4_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(219, 259);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GradeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 310);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGradePoint4);
            this.Controls.Add(this.btnGradePoint1);
            this.Controls.Add(this.btnLetter);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.lvGradePreview);
            this.Name = "GradeType";
            this.Text = "GradeType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGradePreview;
        private System.Windows.Forms.ColumnHeader chGradePreview;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnLetter;
        private System.Windows.Forms.Button btnGradePoint1;
        private System.Windows.Forms.Button btnGradePoint4;
        private System.Windows.Forms.Button btnOK;
    }
}