using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSThemes
{
    public class Template
    {
        public static void setTemplate(ListBox targetListBox, Lister.TableTemplates targetThemeVariable, PictureBox targetPictureBox, ToolStripStatusLabel targetStatusLabel)
        {
            if (targetListBox.SelectedItem.ToString().Equals("Simple"))
            {
                targetThemeVariable = Lister.TableTemplates.Simple;
                targetPictureBox.Image = TemplateResource.template_simple;
                targetStatusLabel.Text = targetListBox.SelectedItem.ToString();
            }
            else if (targetListBox.SelectedItem.ToString().Equals("Blue"))
            {
                targetThemeVariable = Lister.TableTemplates.Blue;
                targetPictureBox.Image = TemplateResource.template_blue;
                targetStatusLabel.Text = targetListBox.SelectedItem.ToString();
            }
        }
    }
}
