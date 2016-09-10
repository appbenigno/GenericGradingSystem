﻿using System;
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
        string gradeTypeChoice = Globals.GradeType.gradeTypeChoice;

        public void transmuteListViewFormat()
        {
            lvGrade.Clear();
            lvGrade.Columns.Add("From", 44);
            lvGrade.Columns.Add("-", 26);
            lvGrade.Columns.Add("To", 50);            
            lvGrade.Scrollable = true;            
            lvGrade.View = View.Details;
            lvGrade.GridLines = true;
            lvGrade.FullRowSelect = true;
            lvGrade.LabelEdit = true;

            lvEquivalent.View = View.Details;
            lvEquivalent.GridLines = true;
            lvEquivalent.FullRowSelect = true;
            lvEquivalent.LabelEdit = true;
            lvEquivalent.Scrollable = true;      
        }

        public void percentage()
        {

        }
        public void letterGrade()
        {
            transmuteListViewFormat();

            ListViewItem gradeRange0 = new ListViewItem("85");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("90");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("92");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("87");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("89");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("83");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("86");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("80");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("82");
            lvGrade.Items.Add(gradeRange4);

            ListViewItem gradeRange5 = new ListViewItem("77");
            gradeRange5.SubItems.Add("-");
            gradeRange5.SubItems.Add("79");
            lvGrade.Items.Add(gradeRange5);

            ListViewItem gradeRange6 = new ListViewItem("73");
            gradeRange6.SubItems.Add("-");
            gradeRange6.SubItems.Add("76");
            lvGrade.Items.Add(gradeRange6);

            ListViewItem gradeRange7 = new ListViewItem("70");
            gradeRange7.SubItems.Add("-");
            gradeRange7.SubItems.Add("72");
            lvGrade.Items.Add(gradeRange7);

            ListViewItem gradeRange8 = new ListViewItem("67");
            gradeRange8.SubItems.Add("-");
            gradeRange8.SubItems.Add("69");
            lvGrade.Items.Add(gradeRange8);

            ListViewItem gradeRange9 = new ListViewItem("63");
            gradeRange9.SubItems.Add("-");
            gradeRange9.SubItems.Add("66");
            lvGrade.Items.Add(gradeRange9);

            ListViewItem gradeRange10 = new ListViewItem("60");
            gradeRange10.SubItems.Add("-");
            gradeRange10.SubItems.Add("62");
            lvGrade.Items.Add(gradeRange10);

            ListViewItem gradeRange11 = new ListViewItem("59");
            gradeRange11.SubItems.Add("-");
            gradeRange11.SubItems.Add("57");
            lvGrade.Items.Add(gradeRange11);

            ListViewItem gradeRange12 = new ListViewItem("0");
            gradeRange12.SubItems.Add("-");
            gradeRange12.SubItems.Add("56");
            lvGrade.Items.Add(gradeRange12);


            // equivalent grades listview (A+...)
            string equivalent;
            ListViewItem gradeEquivalent;
            equivalent = "A+";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "A";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "A-";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "B+";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "B";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "B-";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "C+";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "C";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "C-";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "D+";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "D";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "D-";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);

            equivalent = "F";
            gradeEquivalent = new ListViewItem(equivalent);
            lvEquivalent.Items.Add(gradeEquivalent);
        }
        public void gradePoint1()
        {
            transmuteListViewFormat();

            ListViewItem gradeRange0 = new ListViewItem("96");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("94");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("95");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("92");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("93");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("89");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("91");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("87");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("88");
            lvGrade.Items.Add(gradeRange4);

            ListViewItem gradeRange5 = new ListViewItem("84");
            gradeRange5.SubItems.Add("-");
            gradeRange5.SubItems.Add("86");
            lvGrade.Items.Add(gradeRange5);

            ListViewItem gradeRange6 = new ListViewItem("82");
            gradeRange6.SubItems.Add("-");
            gradeRange6.SubItems.Add("83");
            lvGrade.Items.Add(gradeRange6);

            ListViewItem gradeRange7 = new ListViewItem("79");
            gradeRange7.SubItems.Add("-");
            gradeRange7.SubItems.Add("81");
            lvGrade.Items.Add(gradeRange7);

            ListViewItem gradeRange8 = new ListViewItem("75");
            gradeRange8.SubItems.Add("-");
            gradeRange8.SubItems.Add("78");
            lvGrade.Items.Add(gradeRange8);

            ListViewItem gradeRange9 = new ListViewItem("0");
            gradeRange9.SubItems.Add("-");
            gradeRange9.SubItems.Add("74");
            lvGrade.Items.Add(gradeRange9);

            ListViewItem gradeRange10 = new ListViewItem("1.00");
            lvEquivalent.Items.Add(gradeRange10);

            ListViewItem gradeRange11 = new ListViewItem("1.25");
            lvEquivalent.Items.Add(gradeRange11);

            ListViewItem gradeRange12 = new ListViewItem("1.50");
            lvEquivalent.Items.Add(gradeRange12);

            ListViewItem gradeRange13 = new ListViewItem("1.75");
            lvEquivalent.Items.Add(gradeRange13);

            ListViewItem gradeRange14 = new ListViewItem("2.00");
            lvEquivalent.Items.Add(gradeRange14);

            ListViewItem gradeRange15 = new ListViewItem("2.25");
            lvEquivalent.Items.Add(gradeRange15);

            ListViewItem gradeRange16 = new ListViewItem("2.50");
            lvEquivalent.Items.Add(gradeRange16);

            ListViewItem gradeRange17 = new ListViewItem("2.75");
            lvEquivalent.Items.Add(gradeRange17);

            ListViewItem gradeRange18 = new ListViewItem("3.00");
            lvEquivalent.Items.Add(gradeRange18);

            ListViewItem gradeRange19 = new ListViewItem("5.00");
            lvEquivalent.Items.Add(gradeRange19);
        }
        public void gradePoint5()
        {
            ListViewItem gradeRange0 = new ListViewItem("92");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("87");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("91");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("83");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("86");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("79");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("82");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("75");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("78");
            lvGrade.Items.Add(gradeRange4);

            ListViewItem gradeRange5 = new ListViewItem("70");
            gradeRange5.SubItems.Add("-");
            gradeRange5.SubItems.Add("74");
            lvGrade.Items.Add(gradeRange5);

            ListViewItem gradeRange6 = new ListViewItem("0");
            gradeRange6.SubItems.Add("-");
            gradeRange6.SubItems.Add("69");
            lvGrade.Items.Add(gradeRange6);
           

            ListViewItem gradeRange7 = new ListViewItem("4.0");
            lvEquivalent.Items.Add(gradeRange7);

            ListViewItem gradeRange8 = new ListViewItem("3.5");
            lvEquivalent.Items.Add(gradeRange8);

            ListViewItem gradeRange9 = new ListViewItem("3.0");
            lvEquivalent.Items.Add(gradeRange9);

            ListViewItem gradeRange10 = new ListViewItem("2.5");
            lvEquivalent.Items.Add(gradeRange10);

            ListViewItem gradeRange11 = new ListViewItem("2.0");
            lvEquivalent.Items.Add(gradeRange11);

            ListViewItem gradeRange12 = new ListViewItem("1.0");
            lvEquivalent.Items.Add(gradeRange12);

            ListViewItem gradeRange13 = new ListViewItem("0.0");
            lvEquivalent.Items.Add(gradeRange13);
            
        }
        public Transmutation()
        {
            InitializeComponent();

            if (gradeTypeChoice == "percentage")
            {
                transmuteListViewFormat();

            }
            else if (gradeTypeChoice == "letter")
            {
                transmuteListViewFormat();
                letterGrade();
            }
            else if (gradeTypeChoice == "gradePoint1")
            {
                transmuteListViewFormat();
                gradePoint1();
            }
            else if (gradeTypeChoice == "gradePoint4")
            {
                transmuteListViewFormat();
                gradePoint5();
            }            
        }

        public void codeNiGab()
        {
        //    if (gradeTypeChoice == "letter")
        //    {
        //        ListViewFormat();

        //        Add items in the listview

        //    string[] arr = new string[4];

        //        ListViewItem itm;

        //        Add first item

        //        arr[0] = "A+";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[2] = "A";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "A-";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "B+";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "B";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "B-";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "C+";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "C";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "C-";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "D+";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "D";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "D-";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //        arr[0] = "F";
        //        itm = new ListViewItem(arr);
        //        lvGrade.Items.Add(itm);
        //    }
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text == "Letters")
        //    {
        //        lvGPA.Clear();

        //        lvGPA.View = View.Details;
        //        lvGPA.GridLines = true;
        //        lvGPA.FullRowSelect = true;

        //        lvGPA.Columns.Add("Grade", 100);
        //        lvGPA.Columns.Add("Range From", 100);
        //        lvGPA.Columns.Add("Range To", 100);


        //        Add items in the listview
        //        string[] arr = new string[4];
        //        ListViewItem itm;

        //        Add first item
        //        arr[0] = "A+";
        //        arr[1] = "97";
        //        arr[2] = "100";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "A";
        //        arr[1] = "93";
        //        arr[2] = "97";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "A-";
        //        arr[1] = "90";
        //        arr[2] = "92";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "B+";
        //        arr[1] = "87";
        //        arr[2] = "89";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "B";
        //        arr[1] = "83";
        //        arr[2] = "86";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "B-";
        //        arr[1] = "80";
        //        arr[2] = "82";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "C+";
        //        arr[1] = "77";
        //        arr[2] = "79";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "C";
        //        arr[1] = "73";
        //        arr[2] = "76";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "C-";
        //        arr[1] = "70";
        //        arr[2] = "72";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "D+";
        //        arr[1] = "67";
        //        arr[2] = "69";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "D";
        //        arr[1] = "63";
        //        arr[2] = "66";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "D-";
        //        arr[1] = "60";
        //        arr[2] = "62";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "F";
        //        arr[1] = "0";
        //        arr[2] = "59";                
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //    }


        //    if (comboBox1.Text == "4 is Gold")
        //    {
        //        lvGPA.Clear();
        //        lvGPA.LabelEdit = true;

        //        lvGPA.View = View.Details;
        //        lvGPA.GridLines = true;
        //        lvGPA.FullRowSelect = true;

        //        lvGPA.Columns.Add("Grade", 100);
        //        lvGPA.Columns.Add("Range From", 100);
        //        lvGPA.Columns.Add("Range To", 100);


        //        Add items in the listview
        //        string[] arr = new string[4];
        //        ListViewItem itm;

        //        Add first item
        //        arr[0] = "4.0";
        //        arr[1] = "97";
        //        arr[2] = "100";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "4.0";
        //        arr[1] = "93";
        //        arr[2] = "97";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "3.7";
        //        arr[1] = "90";
        //        arr[2] = "92";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "3.3";
        //        arr[1] = "87";
        //        arr[2] = "89";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "3.0";
        //        arr[1] = "83";
        //        arr[2] = "86";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "2.7";
        //        arr[1] = "80";
        //        arr[2] = "82";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "2.3";
        //        arr[1] = "77";
        //        arr[2] = "79";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "2.0";
        //        arr[1] = "73";
        //        arr[2] = "76";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "1.7";
        //        arr[1] = "70";
        //        arr[2] = "72";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "1.3";
        //        arr[1] = "67";
        //        arr[2] = "69";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "1.0";
        //        arr[1] = "63";
        //        arr[2] = "66";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "0.7";
        //        arr[1] = "60";
        //        arr[2] = "62";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "0";
        //        arr[1] = "0";
        //        arr[2] = "59";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //    }


        //    if (comboBox1.Text == "UNO is Gold")
        //    {
        //        lvGPA.Clear();
        //        lvGPA.LabelEdit = true;

        //        lvGPA.View = View.Details;
        //        lvGPA.GridLines = true;
        //        lvGPA.FullRowSelect = true;

        //        lvGPA.Columns.Add("Grade", 100);
        //        lvGPA.Columns.Add("Range From", 100);
        //        lvGPA.Columns.Add("Range To", 100);


        //        Add items in the listview
        //        string[] arr = new string[4];
        //        ListViewItem itm;

        //        Add first item
        //        arr[0] = "4.0";
        //        arr[1] = "97";
        //        arr[2] = "100";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "4.0";
        //        arr[1] = "93";
        //        arr[2] = "97";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "3.7";
        //        arr[1] = "90";
        //        arr[2] = "92";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "3.3";
        //        arr[1] = "87";
        //        arr[2] = "89";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "3.0";
        //        arr[1] = "83";
        //        arr[2] = "86";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "2.7";
        //        arr[1] = "80";
        //        arr[2] = "82";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "2.3";
        //        arr[1] = "77";
        //        arr[2] = "79";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "2.0";
        //        arr[1] = "73";
        //        arr[2] = "76";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "1.7";
        //        arr[1] = "70";
        //        arr[2] = "72";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "1.3";
        //        arr[1] = "67";
        //        arr[2] = "69";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "1.0";
        //        arr[1] = "63";
        //        arr[2] = "66";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //        arr[0] = "0.7";
        //        arr[1] = "60";
        //        arr[2] = "62";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);

        //        arr[0] = "0";
        //        arr[1] = "0";
        //        arr[2] = "59";
        //        itm = new ListViewItem(arr);
        //        lvGPA.Items.Add(itm);
        //    }
        //}
        
    }

    private void lvGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
