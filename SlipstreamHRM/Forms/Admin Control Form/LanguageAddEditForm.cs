using SlipstreamHRM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class LanguageAddEditForm : MaterialSkin.Controls.MaterialForm
    {
        private LanguageInformation languageInformation;
        private string LanguageID;

        public LanguageAddEditForm(string languageID, string language)
        {
            InitializeComponent();
            this.LanguageID = languageID;
            this.Text = "Add Language";
            if (!string.IsNullOrEmpty(LanguageID))
            {
                this.Text = "Edit Language";
                txtLanguage.Text = language;
            }
        }

        private void LanguageAddEditForm_Load(object sender, EventArgs e)
        {
            languageInformation = new LanguageInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _languageID = Convert.ToInt32(LanguageID);
            languageInformation.Language = txtLanguage.Text;

            if (string.IsNullOrEmpty(LanguageID))
            {
                if (!string.IsNullOrEmpty(languageInformation.Language))
                {
                    languageInformation.AddLanguage();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Language", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }

            else
            {
                if (!string.IsNullOrEmpty(languageInformation.Language))
                {
                    languageInformation.EditLanguage(_languageID);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Input Language", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
    }
}
