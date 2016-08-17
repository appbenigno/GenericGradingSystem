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
    public partial class Transmutation : Form
    {
        public Transmutation()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Letters")
            {
                lvGPA.Clear();

                lvGPA.View = View.Details;
                lvGPA.GridLines = true;
                lvGPA.FullRowSelect = true;

                lvGPA.Columns.Add("Grade", 100);
                lvGPA.Columns.Add("Range From", 100);
                lvGPA.Columns.Add("Range To", 100);
                

                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                //Add first item
                arr[0] = "A+";
                arr[1] = "97";
                arr[2] = "100";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "A";
                arr[1] = "93";
                arr[2] = "97";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "A-";
                arr[1] = "90";
                arr[2] = "92";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "B+";
                arr[1] = "87";
                arr[2] = "89";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "B";
                arr[1] = "83";
                arr[2] = "86";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "B-";
                arr[1] = "80";
                arr[2] = "82";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "C+";
                arr[1] = "77";
                arr[2] = "79";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "C";
                arr[1] = "73";
                arr[2] = "76";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "C-";
                arr[1] = "70";
                arr[2] = "72";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "D+";
                arr[1] = "67";
                arr[2] = "69";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "D";
                arr[1] = "63";
                arr[2] = "66";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "D-";
                arr[1] = "60";
                arr[2] = "62";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "F";
                arr[1] = "0";
                arr[2] = "59";                
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
            }


            if (comboBox1.Text == "4 is Gold")
            {
                lvGPA.Clear();
                lvGPA.LabelEdit = true;

                lvGPA.View = View.Details;
                lvGPA.GridLines = true;
                lvGPA.FullRowSelect = true;

                lvGPA.Columns.Add("Grade", 100);
                lvGPA.Columns.Add("Range From", 100);
                lvGPA.Columns.Add("Range To", 100);


                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                //Add first item
                arr[0] = "4.0";
                arr[1] = "97";
                arr[2] = "100";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "4.0";
                arr[1] = "93";
                arr[2] = "97";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "3.7";
                arr[1] = "90";
                arr[2] = "92";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "3.3";
                arr[1] = "87";
                arr[2] = "89";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "3.0";
                arr[1] = "83";
                arr[2] = "86";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "2.7";
                arr[1] = "80";
                arr[2] = "82";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "2.3";
                arr[1] = "77";
                arr[2] = "79";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "2.0";
                arr[1] = "73";
                arr[2] = "76";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "1.7";
                arr[1] = "70";
                arr[2] = "72";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "1.3";
                arr[1] = "67";
                arr[2] = "69";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "1.0";
                arr[1] = "63";
                arr[2] = "66";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "0.7";
                arr[1] = "60";
                arr[2] = "62";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "0";
                arr[1] = "0";
                arr[2] = "59";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
            }


            if (comboBox1.Text == "UNO is Gold")
            {
                lvGPA.Clear();
                lvGPA.LabelEdit = true;

                lvGPA.View = View.Details;
                lvGPA.GridLines = true;
                lvGPA.FullRowSelect = true;

                lvGPA.Columns.Add("Grade", 100);
                lvGPA.Columns.Add("Range From", 100);
                lvGPA.Columns.Add("Range To", 100);


                //Add items in the listview
                string[] arr = new string[4];
                ListViewItem itm;

                //Add first item
                arr[0] = "4.0";
                arr[1] = "97";
                arr[2] = "100";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "4.0";
                arr[1] = "93";
                arr[2] = "97";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "3.7";
                arr[1] = "90";
                arr[2] = "92";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "3.3";
                arr[1] = "87";
                arr[2] = "89";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "3.0";
                arr[1] = "83";
                arr[2] = "86";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "2.7";
                arr[1] = "80";
                arr[2] = "82";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "2.3";
                arr[1] = "77";
                arr[2] = "79";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "2.0";
                arr[1] = "73";
                arr[2] = "76";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "1.7";
                arr[1] = "70";
                arr[2] = "72";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "1.3";
                arr[1] = "67";
                arr[2] = "69";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "1.0";
                arr[1] = "63";
                arr[2] = "66";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
                arr[0] = "0.7";
                arr[1] = "60";
                arr[2] = "62";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);

                arr[0] = "0";
                arr[1] = "0";
                arr[2] = "59";
                itm = new ListViewItem(arr);
                lvGPA.Items.Add(itm);
            }
        }
    }
}
//gab was here