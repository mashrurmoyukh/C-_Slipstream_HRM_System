using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.BAL.Admin_Control_Manager;
using SlipstreamHRM.DAL;
using System.Data.SqlClient;

namespace SlipstreamHRM.User_Control.Admin_Dashboard_Control.Qualification_Dashboard_Control
{
    public partial class SkillDashboardControl : UserControl
    {
        private SkillDashboardControl _instance;

        public SkillDashboardControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkillDashboardControl();
                return _instance;
            }
        }

        private SqlConnection Connection;
        private SkillInformation skillInformation;
        private SkillDashboardHandler skillDashboardHandler;

        public SkillDashboardControl()
        {
            InitializeComponent();
        }     

        private void SkillDashboardControl_Load_1(object sender, EventArgs e)
        {
            skillInformation = new SkillInformation();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            SkillDataShow();
        }

        private void AddTile_Click(object sender, EventArgs e)
        {
            skillDashboardHandler = new SkillDashboardHandler();
            skillDashboardHandler.AddSkillForm();
            SkillDataShow();
        }

        private void EditTile_Click(object sender, EventArgs e)
        {
            if (skillDataGridView.Rows.Count != 0 && skillDataGridView.Rows != null)
            {
                skillInformation.Skill = skillDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                skillInformation.SkillDescription = skillDataGridView.SelectedRows[0].Cells[1].Value.ToString();

                if (!string.IsNullOrEmpty(skillInformation.Skill))
                {
                    skillDashboardHandler = new SkillDashboardHandler();
                    skillDashboardHandler.EditSkillrForm(skillInformation.Skill, skillInformation.SkillDescription);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Data dosen't selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            SkillDataShow();
        }

        private void DeleteTile_Click(object sender, EventArgs e)
        {
            if (skillDataGridView.Rows.Count != 0 && skillDataGridView.Rows != null)
            {
                skillDashboardHandler = new SkillDashboardHandler();
                string skillName = skillDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (skillName != null)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        skillDashboardHandler.DeleteSkill(skillName);
                    }
                }
            }
            SkillDataShow();
        }

        public void SkillDataShow()
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT Skill as 'Skill', Description as 'Skill Description' FROM SkillInformation ORDER BY Skill ASC", Connection);
                DataTable SkillInfoTable = new DataTable();
                Adapter.Fill(SkillInfoTable);
                skillDataGridView.DataSource = SkillInfoTable;

                skillDataGridView.Columns[0].Width = 200;
                skillDataGridView.Columns[1].Width = 900;

                skillDataGridView.BackgroundColor = Color.White;
                skillDataGridView.BorderStyle = BorderStyle.Fixed3D;
                skillDataGridView.Cursor = Cursors.Hand;

                skillDataGridView.AllowUserToAddRows = false;
                skillDataGridView.AllowUserToDeleteRows = false;
                skillDataGridView.AllowUserToOrderColumns = true;
                skillDataGridView.ReadOnly = true;
                skillDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                skillDataGridView.MultiSelect = false;
                skillDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                skillDataGridView.AllowUserToResizeColumns = false;
                skillDataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                skillDataGridView.AllowUserToResizeRows = false;
                skillDataGridView.RowHeadersWidthSizeMode =
                    DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                skillDataGridView.DefaultCellStyle.SelectionBackColor = Color.White;
                skillDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;

                skillDataGridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

                skillDataGridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
                skillDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

                skillDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                skillDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                skillDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Skill Data Show", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
