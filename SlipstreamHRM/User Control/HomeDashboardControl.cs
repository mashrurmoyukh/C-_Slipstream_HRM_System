using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.User_Control
{
    public partial class HomeDashboardControl : UserControl
    {
        private static HomeDashboardControl _instance;

        public static HomeDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HomeDashboardControl();
                return _instance;
            }
        }

        public HomeDashboardControl()
        {
            InitializeComponent();
        }
    }
}
