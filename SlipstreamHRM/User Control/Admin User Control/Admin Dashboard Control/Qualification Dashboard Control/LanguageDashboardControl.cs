using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;
using SlipstreamHRM.BAL.Admin_Control_Manager;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    public partial class LanguageDashboardControl : UserControl
    {
        private LanguageDashboardControl _instance;

        public LanguageDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LanguageDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private LanguageInformation languageInformation;
        private LanguageDashboardHandler languageDashboardHandler;

        public LanguageDashboardControl()
        {
            InitializeComponent();
        }

        private void LanguageDashboardControl_Load(object sender, EventArgs e)
        {
            languageInformation = new LanguageInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            LanguageDataShow();
        }

        public void LanguageDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Language as 'Language' FROM LanguageInformation ORDER BY Language ASC", Connection);
                DataTable LanguageInfoTable = new DataTable();
                Adapter.Fill(LanguageInfoTable);
                languageDataGridView.DataSource = LanguageInfoTable;

                languageDataGridView.Columns[0].Width = 880;

                languageDataGridView.BackgroundColor = Color.White;
                languageDataGridView.BorderStyle = BorderStyle.Fixed3D;
                languageDataGridView.Cursor = Cursors.Hand;

                languageDataGridView.AllowUserToAddRows = false;
                languageDataGridView.AllowUserToDeleteRows = false;
                languageDataGridView.AllowUserToOrderColumns = true;
                languageDataGridView.ReadOnly = true;
                languageDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                languageDataGridView.MultiSelect = false;
                languageDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                languageDataGridView.AllowUserToResizeColumns = false;
                languageDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                languageDataGridView.AllowUserToResizeRows = false;
                languageDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                languageDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                languageDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                languageDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                languageDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                languageDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                languageDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                languageDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                languageDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Language Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            languageDashboardHandler = new LanguageDashboardHandler();
            languageDashboardHandler.AddLanguageForm();
            LanguageDataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (languageDataGridView.Rows.Count != 0 && languageDataGridView.Rows != null)
            {
                languageInformation.Language = languageDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(languageInformation.Language))
                {
                    languageDashboardHandler = new LanguageDashboardHandler();
                    languageDashboardHandler.EditLanguageForm(languageInformation.Language);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LanguageDataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (languageDataGridView.Rows.Count != 0 && languageDataGridView.Rows != null)
            {
                languageDashboardHandler = new LanguageDashboardHandler();
                string language = languageDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (language != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        languageDashboardHandler.DeleteLanguage(language);
                    }
                }
            }
            LanguageDataShow();
        }     
    }
}
