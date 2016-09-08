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
            this.Range1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEquivalent = new System.Windows.Forms.ListView();
            this.equivalent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Separator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Range2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvGrade
            // 
            this.lvGrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Range1,
            this.Separator,
            this.Range2});
            this.lvGrade.GridLines = true;
            this.lvGrade.Location = new System.Drawing.Point(39, 25);
            this.lvGrade.Name = "lvGrade";
            this.lvGrade.Scrollable = false;
            this.lvGrade.Size = new System.Drawing.Size(117, 308);
            this.lvGrade.TabIndex = 3;
            this.lvGrade.UseCompatibleStateImageBehavior = false;
            this.lvGrade.View = System.Windows.Forms.View.Details;
            // 
            // Range1
            // 
            this.Range1.Text = "From";
            this.Range1.Width = 50;
            // 
            // lvEquivalent
            // 
            this.lvEquivalent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.equivalent});
            this.lvEquivalent.GridLines = true;
            this.lvEquivalent.Location = new System.Drawing.Point(162, 25);
            this.lvEquivalent.Name = "lvEquivalent";
            this.lvEquivalent.Size = new System.Drawing.Size(87, 308);
            this.lvEquivalent.TabIndex = 4;
            this.lvEquivalent.UseCompatibleStateImageBehavior = false;
            this.lvEquivalent.View = System.Windows.Forms.View.Details;
            // 
            // equivalent
            // 
            this.equivalent.Text = "Equivalent";
            this.equivalent.Width = 85;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Separator
            // 
            this.Separator.Text = "-";
            this.Separator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Separator.Width = 26;
            // 
            // Range2
            // 
            this.Range2.Text = "To";
            this.Range2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Range2.Width = 50;
            // 
            // Transmutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 379);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvEquivalent);
            this.Controls.Add(this.lvGrade);
            this.MaximizeBox = false;
            this.Name = "Transmutation";
            this.Text = "Transmutation Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lvGrade;
        private System.Windows.Forms.ColumnHeader Range1;
        private System.Windows.Forms.ListView lvEquivalent;
        private System.Windows.Forms.ColumnHeader equivalent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Separator;
        private System.Windows.Forms.ColumnHeader Range2;
    }
}

