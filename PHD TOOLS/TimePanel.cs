using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHD_TOOLS
{
    public partial class TimePanel : UserControl
    {
        public TimePanel()
        {
            InitializeComponent();
        }

        private void StartDateChange(object sender, EventArgs e)
        {
            if (Global.bGlobalSync) Global.dtFrom = DateTime.Parse(StartDate.Text);
        }

        private void EndDateChange(object sender, EventArgs e)
        {
            if (Global.bGlobalSync) Global.dtTo = DateTime.Parse(EndDate.Text);
        }
    }
}
