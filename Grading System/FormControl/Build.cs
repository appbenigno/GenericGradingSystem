using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grading_System.FormControl
{
    public class Build
    {
        public static void BuildMode(PictureBox buildPicture, GroupBox groupClassList, ListView classList)
        {
            for (int x = 0; x < classList.Items.Count; x++)
            {
                if (classList.Items[x].Selected)
                {
                    flags.destroy("noneselected");
                    if (flags.isRaised("building"))
                    {
                        flags.destroy("building");
                        groupClassList.Enabled = true;
                        buildPicture.Image = ProjResource.button_build;
                    }
                    else if (!flags.isRaised("building"))
                    {
                        flags.raise("building");
                        groupClassList.Enabled = false;
                        buildPicture.Image = ProjResource.button_build_hover;
                    }
                    break;
                }
                else
                {
                    flags.raise("noneselected");
                }
            }
            if (flags.isRaised("noneselected"))
            {
                flags.destroy("noneselected");
                MessageBox.Show("Select a name from the class list first.", "No name selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
