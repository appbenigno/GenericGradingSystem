using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        public void gradeTypeListViewFormat()
        {
            lvGradePreview.Clear();
            lvGradePreview.Columns.Add("Grade", 100);
            lvGradePreview.View = View.Details;
            lvGradePreview.GridLines = true;
            lvGradePreview.FullRowSelect = true;            
        }

        public void btnPercentage_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "percentage";
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "100";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "95";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "90";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "85";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "80";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "75";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "70";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "65";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "60";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "55";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "50";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "0";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
        }

        public void btnLetter_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "letter";
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            //Add first item
            arr[0] = "A+";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "A";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "A-";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "B+";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "B";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "B-";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "C+";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "C";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "C-";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "D+";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "D";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "D-";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "F";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
        }

        public void btnGradePoint1_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "gradePoint1";
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            //Add first item
            arr[0] = "1.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "1.25";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "1.50";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "1.75";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "2.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "2.25";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "2.50";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "2.75";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "3.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "5.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
        }

        public void btnGradePoint4_Click(object sender, EventArgs e)
        {

            Globals.GradeType.gradeTypeChoice = "gradePoint4";
            gradeTypeListViewFormat();

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;
            //Add first item
            arr[0] = "4.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "3.50";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "3.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "2.50";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "2.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "1.50";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "1.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);
            arr[0] = "0.00";
            itm = new ListViewItem(arr);
            lvGradePreview.Items.Add(itm);

        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            Transmutation f3 = new Transmutation(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
            this.Close(); // closes the GradeType instance.
        }


    }
}

