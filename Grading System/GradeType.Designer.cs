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
            this.lvGPA = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvGPA
            // 
            this.lvGPA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvGPA.Location = new System.Drawing.Point(58, 51);
            this.lvGPA.Name = "lvGPA";
            this.lvGPA.Size = new System.Drawing.Size(435, 176);
            this.lvGPA.TabIndex = 0;
            this.lvGPA.UseCompatibleStateImageBehavior = false;
            this.lvGPA.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 90;
            // 
            // GradeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 504);
            this.Controls.Add(this.lvGPA);
            this.Name = "GradeType";
            this.Text = "GradeType";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGPA;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}