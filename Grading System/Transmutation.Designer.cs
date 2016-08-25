namespace Grading_System
{
    partial class Transmutation
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
            
            this.lvGrade = new System.Windows.Forms.ListView();
            this.lvPercentage = new System.Windows.Forms.ListView();
            this.chGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPercentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            
            // 
            // lvGrade
            // 
            this.lvGrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGrade});
            this.lvGrade.Location = new System.Drawing.Point(80, 25);
            this.lvGrade.Name = "lvGrade";
            this.lvGrade.Size = new System.Drawing.Size(152, 248);
            this.lvGrade.TabIndex = 3;
            this.lvGrade.UseCompatibleStateImageBehavior = false;
            // 
            // lvPercentage
            // 
            this.lvPercentage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPercentage});
            this.lvPercentage.Location = new System.Drawing.Point(258, 27);
            this.lvPercentage.Name = "lvPercentage";
            this.lvPercentage.Size = new System.Drawing.Size(148, 246);
            this.lvPercentage.TabIndex = 4;
            this.lvPercentage.UseCompatibleStateImageBehavior = false;
            // 
            // chGrade
            // 
            this.chGrade.Text = "Grade";
            // 
            // chPercentage
            // 
            this.chPercentage.Text = "Percentage";
            // 
            // Transmutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 379);
            this.Controls.Add(this.lvPercentage);
            this.Controls.Add(this.lvGrade);
            this.MaximizeBox = false;
            this.Name = "Transmutation";
            this.Text = "Transmutation Table";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lvGrade;
        private System.Windows.Forms.ColumnHeader chGrade;
        private System.Windows.Forms.ListView lvPercentage;
        private System.Windows.Forms.ColumnHeader chPercentage;
    }
}

