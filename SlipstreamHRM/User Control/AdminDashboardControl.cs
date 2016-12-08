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
    public partial class AdminDashboardControl : UserControl
    {
        private static AdminDashboardControl _instance;

        public static AdminDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminDashboardControl();
                return _instance;
            }
        }

        public AdminDashboardControl()
        {
            InitializeComponent();
        }
    }
}
