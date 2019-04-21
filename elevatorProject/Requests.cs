using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorProject
{
    public class Requests : Form
    {
        public void upToDownReq(Timer downTimer)
        {
            downTimer.Enabled = true;
        }
    }
}
