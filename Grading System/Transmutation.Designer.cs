﻿namespace Grading_System
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
            this.Separator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Range2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGrade2 = new System.Windows.Forms.Button();
            this.btnGradePt2 = new System.Windows.Forms.Button();
            this.btnGradePt3 = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnOKtrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGrade
            // 
            this.lvGrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Range1,
            this.Separator,
            this.Range2,
            this.equiv,
            this.descr});
            this.lvGrade.GridLines = true;
            this.lvGrade.HoverSelection = true;
            this.lvGrade.LabelEdit = true;
            this.lvGrade.Location = new System.Drawing.Point(22, 25);
            this.lvGrade.MultiSelect = false;
            this.lvGrade.Name = "lvGrade";
            this.lvGrade.Size = new System.Drawing.Size(359, 308);
            this.lvGrade.TabIndex = 3;
            this.lvGrade.UseCompatibleStateImageBehavior = false;
            this.lvGrade.View = System.Windows.Forms.View.Details;
            this.lvGrade.SelectedIndexChanged += new System.EventHandler(this.lvGrade_SelectedIndexChanged);
            // 
            // Range1
            // 
            this.Range1.Text = "From";
            this.Range1.Width = 50;
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
            // equiv
            // 
            this.equiv.Text = "Equivalent";
            this.equiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.equiv.Width = 70;
            // 
            // descr
            // 
            this.descr.Text = "Description";
            this.descr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descr.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 404);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btnGrade2
            // 
            this.btnGrade2.Location = new System.Drawing.Point(387, 25);
            this.btnGrade2.Name = "btnGrade2";
            this.btnGrade2.Size = new System.Drawing.Size(109, 23);
            this.btnGrade2.TabIndex = 6;
            this.btnGrade2.Text = "Letter Grading";
            this.btnGrade2.UseVisualStyleBackColor = true;
            // 
            // btnGradePt2
            // 
            this.btnGradePt2.Location = new System.Drawing.Point(387, 117);
            this.btnGradePt2.Name = "btnGradePt2";
            this.btnGradePt2.Size = new System.Drawing.Size(109, 23);
            this.btnGradePt2.TabIndex = 7;
            this.btnGradePt2.Text = "Grade Point(1 to 5)";
            this.btnGradePt2.UseVisualStyleBackColor = true;
            // 
            // btnGradePt3
            // 
            this.btnGradePt3.Location = new System.Drawing.Point(387, 72);
            this.btnGradePt3.Name = "btnGradePt3";
            this.btnGradePt3.Size = new System.Drawing.Size(109, 23);
            this.btnGradePt3.TabIndex = 8;
            this.btnGradePt3.Text = "Grade Point(4 to 0)";
            this.btnGradePt3.UseVisualStyleBackColor = true;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(387, 164);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(109, 23);
            this.btnCustom.TabIndex = 9;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnOKtrans
            // 
            this.btnOKtrans.Location = new System.Drawing.Point(221, 416);
            this.btnOKtrans.Name = "btnOKtrans";
            this.btnOKtrans.Size = new System.Drawing.Size(75, 23);
            this.btnOKtrans.TabIndex = 10;
            this.btnOKtrans.Text = "OK";
            this.btnOKtrans.UseVisualStyleBackColor = true;
            // 
            // Transmutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 451);
            this.Controls.Add(this.btnOKtrans);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnGradePt3);
            this.Controls.Add(this.btnGradePt2);
            this.Controls.Add(this.btnGrade2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader Separator;
        private System.Windows.Forms.ColumnHeader Range2;
        private System.Windows.Forms.Button btnGrade2;
        private System.Windows.Forms.Button btnGradePt2;
        private System.Windows.Forms.Button btnGradePt3;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnOKtrans;
        private System.Windows.Forms.ColumnHeader equiv;
        private System.Windows.Forms.ColumnHeader descr;
    }
}

