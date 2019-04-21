using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace elevatorProject
{
    public class Controllers:Form
    {
        public void open(Timer openTimer)
        {
            openTimer.Enabled = true;
        }
        public void close(Timer closeTimer)
        {
            closeTimer.Enabled = true;
        }
    }
        
}
