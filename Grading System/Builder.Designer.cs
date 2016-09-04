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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Perez, Angel",
            "Assignment",
            "Introduction to Science and Technology",
            "100",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Doe, John",
            "Assignment",
            "Introduction to Science",
            "90",
            "100"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Doe, John");
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
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvActivities = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
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
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstClass.Location = new System.Drawing.Point(16, 370);
            this.lstClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(972, 168);
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
            this.label1.Location = new System.Drawing.Point(17, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entries";
            // 
            // lvActivitiesList
            // 
            this.lvActivitiesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActivitiesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.lvActivitiesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvActivitiesList.FullRowSelect = true;
            this.lvActivitiesList.Location = new System.Drawing.Point(110, 58);
            this.lvActivitiesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvActivitiesList.MultiSelect = false;
            this.lvActivitiesList.Name = "lvActivitiesList";
            this.lvActivitiesList.Size = new System.Drawing.Size(206, 270);
            this.lvActivitiesList.TabIndex = 4;
            this.lvActivitiesList.UseCompatibleStateImageBehavior = false;
            this.lvActivitiesList.View = System.Windows.Forms.View.Details;
            this.lvActivitiesList.DoubleClick += new System.EventHandler(this.lvActivitiesList_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Activity Type";
            this.columnHeader6.Width = 139;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Weight";
            this.columnHeader7.Width = 58;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(324, 203);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 28);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lvActivities
            // 
            this.lvActivities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lvActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvActivities.FullRowSelect = true;
            this.lvActivities.HideSelection = false;
            this.lvActivities.Location = new System.Drawing.Point(432, 58);
            this.lvActivities.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvActivities.MultiSelect = false;
            this.lvActivities.Name = "lvActivities";
            this.lvActivities.Size = new System.Drawing.Size(206, 270);
            this.lvActivities.TabIndex = 7;
            this.lvActivities.UseCompatibleStateImageBehavior = false;
            this.lvActivities.View = System.Windows.Forms.View.Details;
            this.lvActivities.DoubleClick += new System.EventHandler(this.lvActivities_DoubleClick);
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
            this.columnHeader9.Width = 58;
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(646, 58);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 22);
            this.txtWeight.TabIndex = 8;
            this.txtWeight.Text = "0";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.Click += new System.EventHandler(this.txtWeight_Click);
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Overall Weight:";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(608, 332);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(16, 16);
            this.lblTotalWeight.TabIndex = 10;
            this.lblTotalWeight.Text = "0";
            // 
            // Builder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 590);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lvActivities);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvActivitiesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalWeight;
    }
}