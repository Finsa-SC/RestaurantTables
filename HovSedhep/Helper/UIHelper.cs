using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HovSedhep.Helper
{
    internal class UIHelper
    {
        public static void ButtonHover(Control parent)
        {
            foreach(Control ctrl in parent.Controls)
            {
                if(ctrl is Button btn)
                {
                    if(btn.Tag != null)
                    {
                        btn.FlatAppearance.BorderColor = Color.DodgerBlue;
                    }
                    else
                    {
                        btn.FlatAppearance.BorderColor = Color.DarkGray;
                    }
                }
            }
        }
        public static bool Chek_Blok(Control parent)
        {
            foreach(Control ctrl in parent.Controls)
            {
                if(ctrl is TextBox txt)
                {
                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show("Please Fill All of Input!!", "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                else if(ctrl is NumericUpDown nmb)
                {
                    if(nmb.Value == 0)
                    {
                        MessageBox.Show("Please Fill All of Input!!", "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true; 
                    }
                }
                else if(ctrl is ComboBox cmb)
                {
                    if(cmb.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Please Select All of Decision!!", "Null Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                }
                if (ctrl.HasChildren)
                {
                    if(Chek_Blok(ctrl))
                        return true;
                }
            }
            return false;
        }
    }
}
