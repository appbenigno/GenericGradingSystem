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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Perez, Angel",
            "Assignment",
            "Introduction to Science and Technology",
            "100",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Doe, John",
            "Assignment",
            "Introduction to Science",
            "90",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Doe, John");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTemplates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGradeType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransmutationTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClass = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lvActivitiesList = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvActivities = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.mnuTemplates.Size = new System.Drawing.Size(74, 20);
            this.mnuTemplates.Text = "Templates";
            this.mnuTemplates.Click += new System.EventHandler(this.mnuTemplates_Click);
            // 
            // mnuGradeType
            // 
            this.mnuGradeType.Name = "mnuGradeType";
            this.mnuGradeType.Size = new System.Drawing.Size(79, 20);
            this.mnuGradeType.Text = "Grade Type";
            this.mnuGradeType.Click += new System.EventHandler(this.mnuGradeType_Click);
            // 
            // mnuTransmutationTable
            // 
            this.mnuTransmutationTable.Name = "mnuTransmutationTable";
            this.mnuTransmutationTable.Size = new System.Drawing.Size(129, 20);
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
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lstClass.Location = new System.Drawing.Point(12, 301);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(730, 137);
            this.lstClass.TabIndex = 1;
            this.lstClass.UseCompatibleStateImageBehavior = false;
            this.lstClass.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entries";
            // 
            // lvActivitiesList
            // 
            this.lvActivitiesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActivitiesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvActivitiesList.FullRowSelect = true;
            this.lvActivitiesList.Location = new System.Drawing.Point(16, 47);
            this.lvActivitiesList.MultiSelect = false;
            this.lvActivitiesList.Name = "lvActivitiesList";
            this.lvActivitiesList.Size = new System.Drawing.Size(221, 220);
            this.lvActivitiesList.TabIndex = 4;
            this.lvActivitiesList.UseCompatibleStateImageBehavior = false;
            this.lvActivitiesList.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(243, 165);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Activity Type";
            this.columnHeader6.Width = 139;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Weight";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 49;
            // 
            // lvActivities
            // 
            this.lvActivities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lvActivities.FullRowSelect = true;
            this.lvActivities.Location = new System.Drawing.Point(324, 47);
            this.lvActivities.MultiSelect = false;
            this.lvActivities.Name = "lvActivities";
            this.lvActivities.Size = new System.Drawing.Size(221, 220);
            this.lvActivities.TabIndex = 7;
            this.lvActivities.UseCompatibleStateImageBehavior = false;
            this.lvActivities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Activity Type";
            this.columnHeader8.Width = 139;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Weight";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 49;
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.lvActivities);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvActivitiesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Builder";
            this.Text = "Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Builder_FormClosing);
            this.Load += new System.EventHandler(this.Builder_Load);
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
        private System.Windows.Forms.ListView lvActivitiesList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lvActivities;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}