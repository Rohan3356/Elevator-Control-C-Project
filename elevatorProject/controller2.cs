using Microsoft.VisualBasic.PowerPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace elevatorProject
{
    public class controller2
    {
        public void down(RectangleShape lift)
        {
            lift.Top += 1;
        }
    }
}
