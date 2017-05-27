using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.DAL.Admin_Control_Manager;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class NewsAddForm : MaterialSkin.Controls.MaterialForm
    {
        public NewsAddForm()
        {
            InitializeComponent();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtSubject.Text) && !string.IsNullOrEmpty(txtDescription.Text))
            {
                NewsInformation newsInformation = new NewsInformation();
                newsInformation.Subject = txtSubject.Text.ToString();
                newsInformation.Description = txtDescription.Text.ToString();
                newsInformation.PublishedDate = DateTime.Now.ToLongDateString();
                newsInformation.AddNews();

                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Give all input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
