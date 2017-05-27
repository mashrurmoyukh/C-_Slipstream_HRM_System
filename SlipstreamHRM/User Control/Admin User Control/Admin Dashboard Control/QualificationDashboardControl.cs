using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control
{
    public partial class QualificationDashboardControl : UserControl
    {
        private QualificationDashboardControl _instance;

        public QualificationDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QualificationDashboardControl();
                return _instance;
            }
        }

        public QualificationDashboardControl()
        {
            InitializeComponent();
            skillInformationDashboardShow();
            languageInformationDashboardShow();
            educationInformationDashboardShow();
        }

        public void skillInformationDashboardShow()
        {
            SkillDashboardControl skillDashboardControl = new SkillDashboardControl();

            if (!QualificationTabPage1.Controls.Contains(skillDashboardControl.Instance))
            {
                QualificationTabPage1.Controls.Add(skillDashboardControl.Instance);
                skillDashboardControl.Instance.Dock = DockStyle.Fill;
                skillDashboardControl.Instance.BringToFront();
            }
            else
                skillDashboardControl.Instance.BringToFront();
        }

        public void languageInformationDashboardShow()
        {
            LanguageDashboardControl languageDashboardControl = new LanguageDashboardControl();

            if (!QualificationTabPage3.Controls.Contains(languageDashboardControl.Instance))
            {
                QualificationTabPage3.Controls.Add(languageDashboardControl.Instance);
                languageDashboardControl.Instance.Dock = DockStyle.Fill;
                languageDashboardControl.Instance.BringToFront();
            }
            else
                languageDashboardControl.Instance.BringToFront();
        }

        public void educationInformationDashboardShow()
        {
            EducationDashboardControl educationDashboardControl = new EducationDashboardControl();

            if (!QualificationTabPage2.Controls.Contains(educationDashboardControl.Instance))
            {
                QualificationTabPage2.Controls.Add(educationDashboardControl.Instance);
                educationDashboardControl.Instance.Dock = DockStyle.Fill;
                educationDashboardControl.Instance.BringToFront();
            }
            else
                educationDashboardControl.Instance.BringToFront();
        }
    }
}
