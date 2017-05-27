using SlipstreamHRM.Forms.Admin_Control_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlipstreamHRM.BAL.Admin_Control_Manager
{
    class ProjectDashboadHandler
    {
        public void AddProjectForm()
        {
            using (ProjectAddForm projectAddForm = new ProjectAddForm())
            {
                projectAddForm.ShowDialog();
            }
        }
    }
}
