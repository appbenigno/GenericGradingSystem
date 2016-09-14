using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            lvGrade.Columns.Add("Equivalent", 70);
            lvGrade.Columns.Add("Description", 100);
            lvGrade.View = View.Details;
        }
        public void letterGrade()
        {
            transmuteListViewFormat();

            ListViewItem gradeRange0 = new ListViewItem("93");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            gradeRange0.SubItems.Add("A+");
            gradeRange0.SubItems.Add("Outstanding");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("90");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("92.99");
            gradeRange1.SubItems.Add("A");
            gradeRange1.SubItems.Add("Excellent");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("87");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("89.99");
            gradeRange2.SubItems.Add("A-");
            gradeRange2.SubItems.Add("Near-Excellent");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("83");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("86.99");
            gradeRange3.SubItems.Add("B+");
            gradeRange3.SubItems.Add("Very Good");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("80");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("82.99");
            gradeRange4.SubItems.Add("B");
            gradeRange4.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange4);

            ListViewItem gradeRange5 = new ListViewItem("77");
            gradeRange5.SubItems.Add("-");
            gradeRange5.SubItems.Add("79.99");
            gradeRange5.SubItems.Add("B-");
            gradeRange5.SubItems.Add("Above Average");
            lvGrade.Items.Add(gradeRange5);

            ListViewItem gradeRange6 = new ListViewItem("73");
            gradeRange6.SubItems.Add("-");
            gradeRange6.SubItems.Add("76.99");
            gradeRange6.SubItems.Add("C+");
            gradeRange6.SubItems.Add("Average");
            lvGrade.Items.Add(gradeRange6);

            ListViewItem gradeRange7 = new ListViewItem("70");
            gradeRange7.SubItems.Add("-");
            gradeRange7.SubItems.Add("72.99");
            gradeRange7.SubItems.Add("C");
            gradeRange7.SubItems.Add("Satisfactory");
            lvGrade.Items.Add(gradeRange7);

            ListViewItem gradeRange8 = new ListViewItem("67");
            gradeRange8.SubItems.Add("-");
            gradeRange8.SubItems.Add("69.99");
            gradeRange8.SubItems.Add("C-");
            gradeRange8.SubItems.Add("Below Satisfactory");
            lvGrade.Items.Add(gradeRange8);

            ListViewItem gradeRange9 = new ListViewItem("63");
            gradeRange9.SubItems.Add("-");
            gradeRange9.SubItems.Add("66.99");
            gradeRange9.SubItems.Add("D+");
            gradeRange9.SubItems.Add("Acceptable");
            lvGrade.Items.Add(gradeRange9);

            ListViewItem gradeRange10 = new ListViewItem("60");
            gradeRange10.SubItems.Add("-");
            gradeRange10.SubItems.Add("62.99");
            gradeRange10.SubItems.Add("D");
            gradeRange10.SubItems.Add("Insufficient");
            lvGrade.Items.Add(gradeRange10);

            ListViewItem gradeRange11 = new ListViewItem("57");
            gradeRange11.SubItems.Add("-");
            gradeRange11.SubItems.Add("59.99");
            gradeRange11.SubItems.Add("D-");
            gradeRange11.SubItems.Add("Insufficient");
            lvGrade.Items.Add(gradeRange11);

            ListViewItem gradeRange12 = new ListViewItem("0");
            gradeRange12.SubItems.Add("-");
            gradeRange12.SubItems.Add("56.99");
            gradeRange12.SubItems.Add("F");
            gradeRange12.SubItems.Add("Insufficient");
            lvGrade.Items.Add(gradeRange12);
        }
        public void gradePoint125()
        {
            transmuteListViewFormat();

            ListViewItem gradeRange0 = new ListViewItem("96");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            gradeRange0.SubItems.Add("1.00");
            gradeRange0.SubItems.Add("Excellent");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("94");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("95.99");
            gradeRange1.SubItems.Add("1.25");
            gradeRange1.SubItems.Add("Very Good");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("92");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("93.99");
            gradeRange2.SubItems.Add("1.50");
            gradeRange2.SubItems.Add("Very Good");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("89");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("91.99");
            gradeRange3.SubItems.Add("1.75");
            gradeRange3.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("87");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("88.99");
            gradeRange4.SubItems.Add("2.00");
            gradeRange4.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange4);

            ListViewItem gradeRange5 = new ListViewItem("84");
            gradeRange5.SubItems.Add("-");
            gradeRange5.SubItems.Add("86.99");
            gradeRange5.SubItems.Add("2.25");
            gradeRange5.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange5);

            ListViewItem gradeRange6 = new ListViewItem("82");
            gradeRange6.SubItems.Add("-");
            gradeRange6.SubItems.Add("83.99");
            gradeRange6.SubItems.Add("2.50");
            gradeRange6.SubItems.Add("Fair");
            lvGrade.Items.Add(gradeRange6);

            ListViewItem gradeRange7 = new ListViewItem("79");
            gradeRange7.SubItems.Add("-");
            gradeRange7.SubItems.Add("81.99");
            gradeRange7.SubItems.Add("2.75");
            gradeRange7.SubItems.Add("Fair");
            lvGrade.Items.Add(gradeRange7);

            ListViewItem gradeRange8 = new ListViewItem("75");
            gradeRange8.SubItems.Add("-");
            gradeRange8.SubItems.Add("78.99");
            gradeRange8.SubItems.Add("3.00");
            gradeRange8.SubItems.Add("Pass");
            lvGrade.Items.Add(gradeRange8);

            ListViewItem gradeRange9 = new ListViewItem("0");
            gradeRange9.SubItems.Add("-");
            gradeRange9.SubItems.Add("74.99");
            gradeRange9.SubItems.Add("5.00");
            gradeRange9.SubItems.Add("Failure");
            lvGrade.Items.Add(gradeRange9);
        }
        public void gradePoint420()
        {
            ListViewItem gradeRange0 = new ListViewItem("92");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            gradeRange0.SubItems.Add("4.0");
            gradeRange0.SubItems.Add("Excellent");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("87");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("91.99");
            gradeRange1.SubItems.Add("3.5");
            gradeRange1.SubItems.Add("Very Good");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("83");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("86.99");
            gradeRange2.SubItems.Add("3.0");
            gradeRange2.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("79");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("82.99");
            gradeRange3.SubItems.Add("2.5");
            gradeRange3.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("75");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("78.99");
            gradeRange4.SubItems.Add("2.0");
            gradeRange4.SubItems.Add("Fair");
            lvGrade.Items.Add(gradeRange4);

            ListViewItem gradeRange5 = new ListViewItem("70");
            gradeRange5.SubItems.Add("-");
            gradeRange5.SubItems.Add("74.99");
            gradeRange5.SubItems.Add("1.0");
            gradeRange5.SubItems.Add("Pass");
            lvGrade.Items.Add(gradeRange5);

            ListViewItem gradeRange6 = new ListViewItem("0");
            gradeRange6.SubItems.Add("-");
            gradeRange6.SubItems.Add("69.99");
            gradeRange6.SubItems.Add("0.0");
            gradeRange6.SubItems.Add("Fail");
            lvGrade.Items.Add(gradeRange6);
        }
        public void customGrade()
        {
            ListViewItem gradeRange0 = new ListViewItem("91");
            gradeRange0.SubItems.Add("-");
            gradeRange0.SubItems.Add("100");
            gradeRange0.SubItems.Add("100");
            gradeRange0.SubItems.Add("Excellent");
            lvGrade.Items.Add(gradeRange0);

            ListViewItem gradeRange1 = new ListViewItem("81");
            gradeRange1.SubItems.Add("-");
            gradeRange1.SubItems.Add("90");
            gradeRange1.SubItems.Add("90");
            gradeRange1.SubItems.Add("Very Good");
            lvGrade.Items.Add(gradeRange1);

            ListViewItem gradeRange2 = new ListViewItem("76");
            gradeRange2.SubItems.Add("-");
            gradeRange2.SubItems.Add("80");
            gradeRange2.SubItems.Add("80");
            gradeRange2.SubItems.Add("Good");
            lvGrade.Items.Add(gradeRange2);

            ListViewItem gradeRange3 = new ListViewItem("70");
            gradeRange3.SubItems.Add("-");
            gradeRange3.SubItems.Add("70");
            gradeRange3.SubItems.Add("75");
            gradeRange3.SubItems.Add("Fair");
            lvGrade.Items.Add(gradeRange3);

            ListViewItem gradeRange4 = new ListViewItem("0");
            gradeRange4.SubItems.Add("-");
            gradeRange4.SubItems.Add("69");
            gradeRange4.SubItems.Add("0");
            gradeRange4.SubItems.Add("Fail");
            lvGrade.Items.Add(gradeRange4);
        }
        public Transmutation()
        {
            InitializeComponent();

            if (gradeTypeChoice == "custom")
            {
                transmuteListViewFormat();
                customGrade();
            }
            else if (gradeTypeChoice == "letter")
            {
                transmuteListViewFormat();
                letterGrade();
            }
            else if (gradeTypeChoice == "gradePoint1")
            {
                transmuteListViewFormat();
                gradePoint125();
            }
            else if (gradeTypeChoice == "gradePoint4")
            {
                transmuteListViewFormat();
                gradePoint420();
            }
            else
            {
                transmuteListViewFormat();
                gradePoint125(); // default value
            }
        }

        private void lvGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.Transmutation.transferTransmutation(lvGrade, Globals.Transmutation.TransmuteTable);
        }

        private void lvGrade_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point mousePos = lvGrade.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hitTest = lvGrade.HitTest(mousePos);
            int columnIndex = hitTest.Item.SubItems.IndexOf(hitTest.SubItem);
            int rowIndex = hitTest.Item.Index;
            MessageBox.Show(columnIndex.ToString(), "columnIndex"); // to test x y coordinates
            MessageBox.Show(rowIndex.ToString(), "RowIndex");

            if (columnIndex != -1 && rowIndex != -1 && columnIndex < 3 && columnIndex != 1) // for columns 0 and 1 grade range 1 and 2
            {
                try
                {
                    var userInput = Convert.ToDouble(Interaction.InputBox("Score", "Enter Score"));

                    if (userInput.GetType() == typeof(double))
                    {
                        lvGrade.Items[rowIndex].SubItems[columnIndex].Text = userInput.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Numbers Only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Numbers Only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (columnIndex != -1 && rowIndex != -1 && columnIndex > 2 && columnIndex < 4) // for column 3 equivalent
            {
                try
                {
                    var userInput = Interaction.InputBox("Score", "Enter Grade");

                    int parsedInput;
                    bool isNumeric;
                    isNumeric = int.TryParse(userInput, out parsedInput);

                    if (isNumeric)
                    {
                        var equivalent = Convert.ToDouble(parsedInput);

                        lvGrade.Items[rowIndex].SubItems[columnIndex].Text = Math.Round(equivalent, 1).ToString("#.00");
                    }
                    else if (isNumeric == false)
                    {
                        lvGrade.Items[rowIndex].SubItems[columnIndex].Text = userInput.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Numbers or Letters Only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Numbers or Letters Only", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (lvGrade.LabelEdit == true && columnIndex != -1 && rowIndex != -1 && columnIndex != 1) //for column 4 description
            {
                try
                {
                    var userInput = Interaction.InputBox("Desciption", "Enter Description");

                    int n;
                    bool isNumeric;
                    isNumeric = int.TryParse(userInput, out n); //to test if input is numeric

                    if (userInput.GetType() == typeof(string) && isNumeric == false)
                    {
                        lvGrade.Items[rowIndex].SubItems[columnIndex].Text = userInput;
                    }
                    else
                    {
                        MessageBox.Show("Must be in words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Must be in words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (columnIndex == 1) // for column 1
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Out of Bounds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrade2_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "letter";
            transmuteListViewFormat();
            letterGrade();
        }

        private void btnGradePt420_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "gradePoint4";
            transmuteListViewFormat();
            gradePoint420();
        }

        private void btnGradePt125_Click(object sender, EventArgs e)
        {
            Globals.GradeType.gradeTypeChoice = "gradePoint1";
            transmuteListViewFormat();
            gradePoint125();
        }

        private void Transmutation_Activated(object sender, EventArgs e)
        {
            Globals.Transmutation.transferTransmutation(lvGrade, Globals.Transmutation.TransmuteTable);
        }

        private void Transmutation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Winforms.TransmutationTable.Hide();
            }
            Globals.Transmutation.transferTransmutation(lvGrade, Globals.Transmutation.TransmuteTable);
        }

        private void btnOKtrans_Click(object sender, EventArgs e)
        {
            Globals.Transmutation.transferTransmutation(lvGrade, Globals.Transmutation.TransmuteTable);
        }
    }
}
