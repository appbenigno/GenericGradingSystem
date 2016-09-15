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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeType));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvGrade = new System.Windows.Forms.ListView();
            this.Range1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Separator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Range2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equiv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.openMatrix = new System.Windows.Forms.OpenFileDialog();
            this.saveMatrix = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grading_System.ProjResource.lbl_transmutation;
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
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
            this.lvGrade.Location = new System.Drawing.Point(17, 66);
            this.lvGrade.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lvGrade.MultiSelect = false;
            this.lvGrade.Name = "lvGrade";
            this.lvGrade.Size = new System.Drawing.Size(383, 481);
            this.lvGrade.TabIndex = 15;
            this.toolTip1.SetToolTip(this.lvGrade, "Double click a row to edit data");
            this.lvGrade.UseCompatibleStateImageBehavior = false;
            this.lvGrade.View = System.Windows.Forms.View.Details;
            this.lvGrade.DoubleClick += new System.EventHandler(this.lvGrade_DoubleClick);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(418, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Values";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openMatrix
            // 
            this.openMatrix.Filter = "XML Records|*.xml";
            // 
            // saveMatrix
            // 
            this.saveMatrix.Filter = "XML Records|*.xml";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(418, 126);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(418, 191);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(418, 227);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // GradeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 597);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvGrade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "GradeType";
            this.Text = "GradeType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GradeType_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvGrade;
        private System.Windows.Forms.ColumnHeader Range1;
        private System.Windows.Forms.ColumnHeader Separator;
        private System.Windows.Forms.ColumnHeader Range2;
        private System.Windows.Forms.ColumnHeader equiv;
        private System.Windows.Forms.ColumnHeader descr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog openMatrix;
        private System.Windows.Forms.SaveFileDialog saveMatrix;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}