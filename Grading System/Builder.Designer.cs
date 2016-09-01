namespace Grading_System
{
    partial class Builder
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Perez, Angel",
            "Assignment",
            "Introduction to Science and Technology",
            "100",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Doe, John",
            "Assignment",
            "Introduction to Science",
            "90",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Doe, John");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGradeType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransmutationTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClass = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTemplates,
            this.mnuGradeType,
            this.mnuTransmutationTable,
            this.mnuReports});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTemplates
            // 
            this.mnuTemplates.Name = "mnuTemplates";
            this.mnuTemplates.Size = new System.Drawing.Size(73, 20);
            this.mnuTemplates.Text = "Templates";
            this.mnuTemplates.Click += new System.EventHandler(this.mnuTemplates_Click);
            // 
            // mnuGradeType
            // 
            this.mnuGradeType.Name = "mnuGradeType";
            this.mnuGradeType.Size = new System.Drawing.Size(78, 20);
            this.mnuGradeType.Text = "Grade Type";
            this.mnuGradeType.Click += new System.EventHandler(this.mnuGradeType_Click);
            // 
            // mnuTransmutationTable
            // 
            this.mnuTransmutationTable.Name = "mnuTransmutationTable";
            this.mnuTransmutationTable.Size = new System.Drawing.Size(127, 20);
            this.mnuTransmutationTable.Text = "Transmutation Table";
            this.mnuTransmutationTable.Click += new System.EventHandler(this.mnuTransmutationTable_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(59, 20);
            this.mnuReports.Text = "Reports";
            this.mnuReports.Click += new System.EventHandler(this.mnuReports_Click);
            // 
            // lstClass
            // 
            this.lstClass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstClass.FullRowSelect = true;
            this.lstClass.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstClass.Location = new System.Drawing.Point(12, 61);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(730, 335);
            this.lstClass.TabIndex = 1;
            this.lstClass.UseCompatibleStateImageBehavior = false;
            this.lstClass.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class Record";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Activity Type";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 213;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Score";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Max Score";
            this.columnHeader5.Width = 63;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Builder";
            this.Text = "Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Builder_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTemplates;
        private System.Windows.Forms.ToolStripMenuItem mnuGradeType;
        private System.Windows.Forms.ToolStripMenuItem mnuTransmutationTable;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ListView lstClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}