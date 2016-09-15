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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transmutation));
            this.lvGrade = new System.Windows.Forms.ListView();
            this.Range1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Separator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Range2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGrade2 = new System.Windows.Forms.Button();
            this.btnGradePt125 = new System.Windows.Forms.Button();
            this.btnGradePt420 = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnOKtrans = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMapua = new System.Windows.Forms.Button();
            this.btnk12 = new System.Windows.Forms.Button();
            this.btnLoadMatrix = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openMatrix = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvGrade
            // 
            this.lvGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvGrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Range1,
            this.Separator,
            this.Range2,
            this.equiv,
            this.descr});
            this.lvGrade.FullRowSelect = true;
            this.lvGrade.GridLines = true;
            this.lvGrade.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGrade.HoverSelection = true;
            this.lvGrade.LabelEdit = true;
            this.lvGrade.Location = new System.Drawing.Point(29, 68);
            this.lvGrade.Margin = new System.Windows.Forms.Padding(4);
            this.lvGrade.MultiSelect = false;
            this.lvGrade.Name = "lvGrade";
            this.lvGrade.Size = new System.Drawing.Size(388, 391);
            this.lvGrade.TabIndex = 3;
            this.toolTip1.SetToolTip(this.lvGrade, "Double click a cell to edit");
            this.lvGrade.UseCompatibleStateImageBehavior = false;
            this.lvGrade.View = System.Windows.Forms.View.Details;
            this.lvGrade.SelectedIndexChanged += new System.EventHandler(this.lvGrade_SelectedIndexChanged);
            this.lvGrade.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvGrade_MouseDoubleClick);
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
            this.equiv.Width = 96;
            // 
            // descr
            // 
            this.descr.Text = "Description";
            this.descr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descr.Width = 151;
            // 
            // btnGrade2
            // 
            this.btnGrade2.Location = new System.Drawing.Point(40, 30);
            this.btnGrade2.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrade2.Name = "btnGrade2";
            this.btnGrade2.Size = new System.Drawing.Size(145, 28);
            this.btnGrade2.TabIndex = 6;
            this.btnGrade2.Text = "Letter Grading";
            this.btnGrade2.UseVisualStyleBackColor = true;
            this.btnGrade2.Click += new System.EventHandler(this.btnGrade2_Click);
            // 
            // btnGradePt125
            // 
            this.btnGradePt125.Location = new System.Drawing.Point(40, 102);
            this.btnGradePt125.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradePt125.Name = "btnGradePt125";
            this.btnGradePt125.Size = new System.Drawing.Size(145, 28);
            this.btnGradePt125.TabIndex = 7;
            this.btnGradePt125.Text = "Grade Point(1 to 5)";
            this.btnGradePt125.UseVisualStyleBackColor = true;
            this.btnGradePt125.Click += new System.EventHandler(this.btnGradePt125_Click);
            // 
            // btnGradePt420
            // 
            this.btnGradePt420.Location = new System.Drawing.Point(40, 66);
            this.btnGradePt420.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradePt420.Name = "btnGradePt420";
            this.btnGradePt420.Size = new System.Drawing.Size(145, 28);
            this.btnGradePt420.TabIndex = 8;
            this.btnGradePt420.Text = "Grade Point(4 to 0)";
            this.btnGradePt420.UseVisualStyleBackColor = true;
            this.btnGradePt420.Click += new System.EventHandler(this.btnGradePt420_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(40, 138);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(145, 28);
            this.btnCustom.TabIndex = 9;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnOKtrans
            // 
            this.btnOKtrans.Location = new System.Drawing.Point(554, 431);
            this.btnOKtrans.Margin = new System.Windows.Forms.Padding(4);
            this.btnOKtrans.Name = "btnOKtrans";
            this.btnOKtrans.Size = new System.Drawing.Size(100, 28);
            this.btnOKtrans.TabIndex = 10;
            this.btnOKtrans.Text = "Use";
            this.toolTip1.SetToolTip(this.btnOKtrans, "Use Loaded Transmutation Matrix");
            this.btnOKtrans.UseVisualStyleBackColor = true;
            this.btnOKtrans.Click += new System.EventHandler(this.btnOKtrans_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrade2);
            this.groupBox1.Controls.Add(this.btnGradePt125);
            this.groupBox1.Controls.Add(this.btnCustom);
            this.groupBox1.Controls.Add(this.btnGradePt420);
            this.groupBox1.Location = new System.Drawing.Point(425, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(229, 188);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generic";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMapua);
            this.groupBox2.Controls.Add(this.btnk12);
            this.groupBox2.Location = new System.Drawing.Point(425, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 106);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "University / School Standards";
            // 
            // btnMapua
            // 
            this.btnMapua.Location = new System.Drawing.Point(6, 64);
            this.btnMapua.Name = "btnMapua";
            this.btnMapua.Size = new System.Drawing.Size(217, 28);
            this.btnMapua.TabIndex = 1;
            this.btnMapua.Text = "Mapua";
            this.btnMapua.UseVisualStyleBackColor = true;
            this.btnMapua.Click += new System.EventHandler(this.btnMapua_Click);
            // 
            // btnk12
            // 
            this.btnk12.Location = new System.Drawing.Point(6, 30);
            this.btnk12.Name = "btnk12";
            this.btnk12.Size = new System.Drawing.Size(217, 28);
            this.btnk12.TabIndex = 0;
            this.btnk12.Text = "K-12";
            this.btnk12.UseVisualStyleBackColor = true;
            this.btnk12.Click += new System.EventHandler(this.btnk12_Click);
            // 
            // btnLoadMatrix
            // 
            this.btnLoadMatrix.Location = new System.Drawing.Point(446, 431);
            this.btnLoadMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadMatrix.Name = "btnLoadMatrix";
            this.btnLoadMatrix.Size = new System.Drawing.Size(100, 28);
            this.btnLoadMatrix.TabIndex = 13;
            this.btnLoadMatrix.Text = "Load Matrix";
            this.toolTip1.SetToolTip(this.btnLoadMatrix, "Load a transmutation matrix");
            this.btnLoadMatrix.UseVisualStyleBackColor = true;
            this.btnLoadMatrix.Click += new System.EventHandler(this.btnLoadMatrix_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grading_System.ProjResource.lbl_transmutation;
            this.pictureBox1.Location = new System.Drawing.Point(29, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // openMatrix
            // 
            this.openMatrix.Filter = "XML Records|*.xml";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // Transmutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadMatrix);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOKtrans);
            this.Controls.Add(this.lvGrade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Transmutation";
            this.Text = "Transmutation Table";
            this.Activated += new System.EventHandler(this.Transmutation_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transmutation_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView lvGrade;
        private System.Windows.Forms.ColumnHeader Range1;
        private System.Windows.Forms.ColumnHeader Separator;
        private System.Windows.Forms.ColumnHeader Range2;
        private System.Windows.Forms.Button btnGrade2;
        private System.Windows.Forms.Button btnGradePt125;
        private System.Windows.Forms.Button btnGradePt420;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnOKtrans;
        private System.Windows.Forms.ColumnHeader equiv;
        private System.Windows.Forms.ColumnHeader descr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnk12;
        private System.Windows.Forms.Button btnMapua;
        private System.Windows.Forms.Button btnLoadMatrix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openMatrix;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

