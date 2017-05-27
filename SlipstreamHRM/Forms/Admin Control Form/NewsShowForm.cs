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
using System.Data.SqlClient;

namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class NewsShowForm : MaterialSkin.Controls.MaterialForm
    {
        private string _subject;
        private SqlConnection Connection;
        private NewsInformation newsInformation;

        public NewsShowForm(string Subject)
        {
            InitializeComponent();
            this._subject = Subject;
        }    

        private void NewsShowForm_Load(object sender, EventArgs e)
        {
            newsInformation = new NewsInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            newsShowForm();
        }

        public void newsShowForm()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select * FROM NewsInformation Where Subject = '{0}'", _subject), Connection);
                DataTable NewsInfomationTable = new DataTable();
                Adapter.Fill(NewsInfomationTable);

                foreach (DataRow row in NewsInfomationTable.Rows)
                {
                    newsInformation.Subject = row["Subject"].ToString();
                    newsInformation.Description = row["Description"].ToString();
                    newsInformation.PublishedDate = row["PublishedDate"].ToString();
                }

                txtSubject.Text = newsInformation.Subject;
                txtDescription.Text = newsInformation.Description;
                publishedLabel.Text = "Publlished on" + newsInformation.PublishedDate;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Show News", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
