using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    /// <summary>
    /// Clear(Control parent) method acts like a "cleaning robot." It goes through the Form (the main room)
    /// and empties every TextBox it sees. If it finds a "Box inside the room" (like a Panel),
    /// it steps inside that box to clean those TextBoxes too.
    /// every component is a Control like panel, form, text box and others
    /// </summary>
    public static class ClearForm
    {
        public  static void Clear(Control parent)
        {
           foreach(Control c in parent.Controls)
            {
                if(c is TextBox tb)
                {
                    tb.Clear();
                }
                if (c.HasChildren)
                {
                    Clear(c);
                }
            }
        }
    }
}
