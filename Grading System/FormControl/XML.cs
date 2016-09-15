using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class XML
    {
        public static class FileStructure
        {
            public static string recordsPath = "records";
            public static string matrixPath = "matrix";
        }

        public static void SaveMatrix(ListView matrixList, SaveFileDialog saveDialog, NotifyIcon notifyIcon)
        {
            XmlWriterSettings mysettings = new XmlWriterSettings();
            mysettings.Indent = true;
            XmlWriter xWrite = XmlWriter.Create(saveDialog.FileName, mysettings);

            xWrite.WriteStartDocument();
            xWrite.WriteStartElement("GradingSystem");

            xWrite.WriteStartElement("TransmutationTable");
            for (int x1 = 0; x1 < matrixList.Items.Count; x1++)
            {
                xWrite.WriteStartElement("Record");
                xWrite.WriteAttributeString("From", matrixList.Items[x1].SubItems[0].Text);
                xWrite.WriteAttributeString("Separator", matrixList.Items[x1].SubItems[1].Text);
                xWrite.WriteAttributeString("To", matrixList.Items[x1].SubItems[2].Text);
                xWrite.WriteAttributeString("Equivalent", matrixList.Items[x1].SubItems[3].Text);
                xWrite.WriteAttributeString("Description", matrixList.Items[x1].SubItems[4].Text);
                xWrite.WriteEndElement();
            }
            xWrite.WriteEndElement();

            xWrite.WriteEndElement();
            xWrite.WriteEndDocument();
            xWrite.Close();

            FormControl.Notify.ShowBalloon(notifyIcon, "Transmutation Table Saved", "Matrix list saved successfully at " + saveDialog.FileName);
        }

        public static void LoadMatrix(ListView matrixList, OpenFileDialog openDialog, NotifyIcon notifyIcon)
        {
            try
            {
                readMatrixList(matrixList, "TransmutationTable", "Record", openDialog);
                FormControl.Notify.ShowBalloon(notifyIcon, "Transmutation Table Loaded", "Matrix list loaded successfully");
            }
            catch { }
        }
        public static void SaveClassList(ListView classList, ListView activitiesList, ListView entriesList, SaveFileDialog saveDialog, NotifyIcon notifyIcon)
        {
            XmlWriterSettings mysettings = new XmlWriterSettings();
            mysettings.Indent = true;
            XmlWriter xWrite = XmlWriter.Create(saveDialog.FileName, mysettings);

            xWrite.WriteStartDocument();
            xWrite.WriteStartElement("GradingSystem");

            xWrite.WriteStartElement("ClassList");
            for (int x1 = 0; x1 < classList.Items.Count; x1++)
            {
                xWrite.WriteStartElement("Student");
                xWrite.WriteAttributeString("Section", classList.Items[x1].SubItems[0].Text);
                xWrite.WriteAttributeString("FamilyName", classList.Items[x1].SubItems[1].Text);
                xWrite.WriteAttributeString("GivenName", classList.Items[x1].SubItems[2].Text);
                xWrite.WriteAttributeString("MiddleInitial", classList.Items[x1].SubItems[3].Text);
                xWrite.WriteEndElement();
            }
            xWrite.WriteEndElement();

            xWrite.WriteStartElement("ActivityList");
            for (int x2 = 0; x2 < activitiesList.Items.Count; x2++)
            {
                xWrite.WriteStartElement("Activities");
                xWrite.WriteAttributeString("ActivityType", activitiesList.Items[x2].SubItems[0].Text);
                xWrite.WriteAttributeString("Weight", activitiesList.Items[x2].SubItems[1].Text);
                xWrite.WriteEndElement();
            }
            xWrite.WriteEndElement();

            xWrite.WriteStartElement("EntryList");
            for (int x3 = 0; x3 < entriesList.Items.Count; x3++)
            {
                xWrite.WriteStartElement("Entries");
                xWrite.WriteAttributeString("Name", entriesList.Items[x3].SubItems[0].Text);
                xWrite.WriteAttributeString("Section", entriesList.Items[x3].SubItems[1].Text);
                xWrite.WriteAttributeString("ActivityType", entriesList.Items[x3].SubItems[2].Text);
                xWrite.WriteAttributeString("Description", entriesList.Items[x3].SubItems[3].Text);
                xWrite.WriteAttributeString("Score", entriesList.Items[x3].SubItems[4].Text);
                xWrite.WriteAttributeString("MaxScore", entriesList.Items[x3].SubItems[5].Text);
                xWrite.WriteEndElement();
            }
            xWrite.WriteEndElement();

            xWrite.WriteEndElement();
            xWrite.WriteEndDocument();
            xWrite.Close();

            FormControl.Notify.ShowBalloon(notifyIcon, "Settings Saved", "Class list saved successfully at " + saveDialog.FileName);
        }

        public static void LoadClassList(ListView classList, ListView activityList, ListView entriesList, OpenFileDialog openDialog, NotifyIcon notifyIcon)
        {
            try
            {
                readClassList(classList, "ClassList", "Student", openDialog);
                readActivityList(activityList, "ActivityList", "Activities", openDialog);
                readEntriesList(entriesList, "EntryList", "Entries", openDialog);
                FormControl.Notify.ShowBalloon(notifyIcon, "Settings Loaded", "Class list loaded successfully");
            }
            catch { }
        }
        protected static void readClassList(ListView targetList, string elementParent, string elementChild, OpenFileDialog openDialog)
        {
            XmlReader xRead = XmlReader.Create(openDialog.FileName);
            xRead.ReadStartElement("GradingSystem");
            targetList.Items.Clear();
            while (xRead.Read())
            {
                if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementParent)
                {
                    while (xRead.Read())
                    {
                        if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementChild)
                        {
                            if (xRead.HasAttributes)
                            {
                                ListViewItem lviItems = new ListViewItem(xRead.GetAttribute("Section").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("FamilyName").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("GivenName").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("MiddleInitial").ToString());
                                targetList.Items.Add(lviItems);
                            }
                        }
                    }
                }
            }
            xRead.Close();
        }

        protected static void readActivityList(ListView targetList, string elementParent, string elementChild, OpenFileDialog openDialog)
        {
            XmlReader xRead = XmlReader.Create(openDialog.FileName);
            xRead.ReadStartElement("GradingSystem");
            targetList.Items.Clear();
            while (xRead.Read())
            {
                if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementParent)
                {
                    while (xRead.Read())
                    {
                        if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementChild)
                        {
                            if (xRead.HasAttributes)
                            {
                                ListViewItem lviItems = new ListViewItem(xRead.GetAttribute("ActivityType").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Weight").ToString());
                                targetList.Items.Add(lviItems);
                            }
                        }
                    }
                }
            }
            xRead.Close();
        }
        protected static void readEntriesList(ListView targetList, string elementParent, string elementChild, OpenFileDialog openDialog)
        {
            XmlReader xRead = XmlReader.Create(openDialog.FileName);
            xRead.ReadStartElement("GradingSystem");
            targetList.Items.Clear();
            while (xRead.Read())
            {
                if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementParent)
                {
                    while (xRead.Read())
                    {
                        if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementChild)
                        {
                            if (xRead.HasAttributes)
                            {
                                ListViewItem lviItems = new ListViewItem(xRead.GetAttribute("Name").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Section").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("ActivityType").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Description").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Score").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("MaxScore").ToString());
                                targetList.Items.Add(lviItems);
                            }
                        }
                    }
                }
            }
            xRead.Close();
        }

        protected static void readMatrixList(ListView targetList, string elementParent, string elementChild, OpenFileDialog openDialog)
        {
            XmlReader xRead = XmlReader.Create(openDialog.FileName);
            xRead.ReadStartElement("GradingSystem");
            targetList.Items.Clear();
            while (xRead.Read())
            {
                if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementParent)
                {
                    while (xRead.Read())
                    {
                        if (xRead.NodeType == XmlNodeType.Element && xRead.Name == elementChild)
                        {
                            if (xRead.HasAttributes)
                            {
                                ListViewItem lviItems = new ListViewItem(xRead.GetAttribute("From").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Separator").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("To").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Equivalent").ToString());
                                lviItems.SubItems.Add(xRead.GetAttribute("Description").ToString());
                                targetList.Items.Add(lviItems);
                            }
                        }
                    }
                }
            }
            xRead.Close();
        }
    }
}
