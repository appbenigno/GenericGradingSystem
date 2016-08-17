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
            this.lvGPA = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvGPA
            // 
            this.lvGPA.Location = new System.Drawing.Point(0, -1);
            this.lvGPA.Name = "lvGPA";
            this.lvGPA.Size = new System.Drawing.Size(508, 260);
            this.lvGPA.TabIndex = 1;
            this.lvGPA.UseCompatibleStateImageBehavior = false;
            this.lvGPA.View = System.Windows.Forms.View.Details;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Letters",
            "Uno is Gold",
            "4 is Gold"});
            this.comboBox1.Location = new System.Drawing.Point(194, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Transmutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 379);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lvGPA);
            this.MaximizeBox = false;
            this.Name = "Transmutation";
            this.Text = "Transmutation Table";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGPA;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

