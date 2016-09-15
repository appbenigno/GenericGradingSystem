using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System
{
    public partial class GradeType : Form
    {
        string gradeTypeChoice = Globals.GradeType.gradeTypeChoice;
        public GradeType()
        {
            InitializeComponent();
            //btnOK.Enabled = false;    //OK button is disabled if the user did not pick any gradeType    
        }

        public void btnOKdisabled() //OK button is enabled if the user pick a gradeType
        {
            if (Globals.GradeType.gradeTypeChoice == "")
            {
                //btnOK.Enabled = false;
            }
            else
            {
                //btnOK.Enabled = true;
            }

        }

        public void gradeTypeListViewFormat()
        {
            lvGrade.Clear();            
            lvGrade.Columns.Add("Grade", 100);
            lvGrade.View = View.Details;
            lvGrade.GridLines = true;
            lvGrade.FullRowSelect = true;            
        }

        public void btnPercentage_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "custom";
            btnOKdisabled();
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "100";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
          
            arr[0] = "90";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
          
            arr[0] = "80";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
         
            arr[0] = "70";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
          
            arr[0] = "0";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
        }

        public void btnLetter_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "letter";
            btnOKdisabled();
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            //Add first item
            arr[0] = "A+";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "A";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "A-";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "B+";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "B";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "B-";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "C+";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "C";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "C-";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "D+";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "D";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "D-";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "F";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
        }

        public void btnGradePoint1_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "gradePoint1";
            btnOKdisabled();
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            //Add first item
            arr[0] = "1.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "1.25";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "1.50";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "1.75";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "2.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "2.25";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "2.50";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "2.75";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "3.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "5.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
        }

        public void btnGradePoint4_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "gradePoint4";
            btnOKdisabled();
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            //Add first item
            arr[0] = "4.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "3.50";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "3.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "2.50";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "2.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "1.50";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "1.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
            arr[0] = "0.00";
            itm = new ListViewItem(arr);
            lvGrade.Items.Add(itm);
        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            Transmutation f3 = new Transmutation(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
            this.Close(); // closes the GradeType instance.
        }

        private void GradeType_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Winforms.GradeType.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string from = Microsoft.VisualBasic.Interaction.InputBox("Enter value 'from'", "From", "1.00");
                string to = Microsoft.VisualBasic.Interaction.InputBox("Enter value 'to'", "To", "100.00");
                string equivalent = Microsoft.VisualBasic.Interaction.InputBox("Enter equivalent resulting value", "Equivalent", "1.0");
                string description = Microsoft.VisualBasic.Interaction.InputBox("Enter value remarks", "Remarks", "Excellent");
                ListViewItem lvi = new ListViewItem(from);
                lvi.SubItems.Add("-");
                lvi.SubItems.Add(to);
                lvi.SubItems.Add(equivalent);
                lvi.SubItems.Add(description);
                lvGrade.Items.Add(lvi);
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lvGrade.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("Select a row first", "Nothing selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvGrade_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                lvGrade.SelectedItems[0].SubItems[0].Text = Microsoft.VisualBasic.Interaction.InputBox("Enter value 'from'", "From");
                lvGrade.SelectedItems[0].SubItems[2].Text = Microsoft.VisualBasic.Interaction.InputBox("Enter value 'to'", "To");
                lvGrade.SelectedItems[0].SubItems[3].Text = Microsoft.VisualBasic.Interaction.InputBox("Enter equivalent resulting value", "Equivalent");
                lvGrade.SelectedItems[0].SubItems[4].Text = Microsoft.VisualBasic.Interaction.InputBox("Enter value remarks", "Remarks");
            }
            catch { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                openMatrix.InitialDirectory = Path.GetFullPath(".\\") + FormControl.XML.FileStructure.matrixPath;
                openMatrix.ShowDialog();
                FormControl.XML.LoadMatrix(lvGrade, openMatrix, notifyIcon);
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                saveMatrix.InitialDirectory = Path.GetFullPath(".\\") + FormControl.XML.FileStructure.matrixPath;
                saveMatrix.ShowDialog();
                FormControl.XML.SaveMatrix(lvGrade, saveMatrix, notifyIcon);
            }
            catch { }
        }
    }
}

