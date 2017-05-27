using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Requirement_Dashboard_Control;
using SlipstreamHRM.User_Control.Admin_User_Control.Requirement_Dashboard_Control;

namespace SlipstreamHRM.User_Control
{
    public partial class RequirementDashboardControl : UserControl
    {
        private RequirementDashboardControl _instance;

        public RequirementDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RequirementDashboardControl();
                return _instance;
            }
        }

        public RequirementDashboardControl()
        {
            InitializeComponent();
        }

        private void CandidatesTile_Click(object sender, EventArgs e)
        {
            CandidatesDashboardControl candidatesDashboardControl = new CandidatesDashboardControl();

            if (!requirementPanel.Controls.Contains(candidatesDashboardControl.Instance))
            {
                requirementPanel.Controls.Add(candidatesDashboardControl.Instance);
                candidatesDashboardControl.Instance.Dock = DockStyle.Fill;
                candidatesDashboardControl.Instance.BringToFront();
            }
            else
                candidatesDashboardControl.Instance.BringToFront();
        }

        private void DisiplineCasesTile_Click(object sender, EventArgs e)
        {
            DisciplineCasesDashboardControl disciplineCasesDashboardControl = new DisciplineCasesDashboardControl();

            if (!requirementPanel.Controls.Contains(disciplineCasesDashboardControl.Instance))
            {
                requirementPanel.Controls.Add(disciplineCasesDashboardControl.Instance);
                disciplineCasesDashboardControl.Instance.Dock = DockStyle.Fill;
                disciplineCasesDashboardControl.Instance.BringToFront();
            }
            else
                disciplineCasesDashboardControl.Instance.BringToFront();
        }

        private void VacanciesTile_Click(object sender, EventArgs e)
        {
            VacancyDashboardControl vacancyDashboardControl = new VacancyDashboardControl();

            if (!requirementPanel.Controls.Contains(vacancyDashboardControl.Instance))
            {
                requirementPanel.Controls.Add(vacancyDashboardControl.Instance);
                vacancyDashboardControl.Instance.Dock = DockStyle.Fill;
                vacancyDashboardControl.Instance.BringToFront();
            }
            else
                vacancyDashboardControl.Instance.BringToFront();
        }
    }
}
