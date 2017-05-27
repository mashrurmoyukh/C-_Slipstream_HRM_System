using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlipstreamHRM.User_Control.Employee_User_Control;
using Tulpep.NotificationWindow;
using System.Data.SqlClient;

namespace SlipstreamHRM.Forms
{
    public partial class EmployeeControlManager : MetroFramework.Forms.MetroForm
    {
        private string UserName;
        private SqlConnection Connection;

        public EmployeeControlManager(string _userName)
        {
            InitializeComponent();
            this.UserName = _userName;
        }

        private void EmployeeControlManager_Load(object sender, EventArgs e)
        {
            HomeDashBoardShow();
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            employeeNameShow();
        }

        private void EmployeeControlManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomeDashBoardShow()
        {
            EmployeeHomeDashboardControl employeeHomeDashboardControl = new EmployeeHomeDashboardControl();

            if (!employeePanel.Controls.Contains(employeeHomeDashboardControl.Instance))
            {
                employeePanel.Controls.Add(employeeHomeDashboardControl.Instance);
                employeeHomeDashboardControl.Instance.Dock = DockStyle.Fill;
                employeeHomeDashboardControl.Instance.BringToFront();
            }
            else
                employeeHomeDashboardControl.Instance.BringToFront();
            this.HeaderLink.Text = "Home";
        }

        private void pimTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EmployeePIMDashboardControl employeePIMDashboardControl = new EmployeePIMDashboardControl(UserName);

            if (!employeePanel.Controls.Contains(employeePIMDashboardControl.Instance))
            {
                employeePanel.Controls.Add(employeePIMDashboardControl.Instance);
                employeePIMDashboardControl.Instance.Dock = DockStyle.Fill;
                employeePIMDashboardControl.Instance.BringToFront();
            }
            else
                employeePIMDashboardControl.Instance.BringToFront();
            this.HeaderLink.Text = "PIM";
        }

        private void leaveTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EmployeeLeaveDashboardControl employeeLeaveDashboardControl = new EmployeeLeaveDashboardControl(UserName);

            if (!employeePanel.Controls.Contains(employeeLeaveDashboardControl.Instance))
            {
                employeePanel.Controls.Add(employeeLeaveDashboardControl.Instance);
                employeeLeaveDashboardControl.Instance.Dock = DockStyle.Fill;
                employeeLeaveDashboardControl.Instance.BringToFront();             
            }
            else
                employeeLeaveDashboardControl.Instance.BringToFront();
            this.HeaderLink.Text = "Leave";
        }

        private void timeTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EmployeeTimeDashboardControl employeeTimeDashboardControl = new EmployeeTimeDashboardControl(UserName);

            if (!employeePanel.Controls.Contains(employeeTimeDashboardControl.Instance))
            {
                employeePanel.Controls.Add(employeeTimeDashboardControl.Instance);
                employeeTimeDashboardControl.Instance.Dock = DockStyle.Fill;
                employeeTimeDashboardControl.Instance.BringToFront();
            }
            else
                employeeTimeDashboardControl.Instance.BringToFront();
            this.HeaderLink.Text = "Time";
        }

        private void disciplineTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EmployeeDisciplineDashboardControl employeeDisciplineDashboardControl = new EmployeeDisciplineDashboardControl(UserName);

            if (!employeePanel.Controls.Contains(employeeDisciplineDashboardControl.Instance))
            {
                employeePanel.Controls.Add(employeeDisciplineDashboardControl.Instance);
                employeeDisciplineDashboardControl.Instance.Dock = DockStyle.Fill;
                employeeDisciplineDashboardControl.Instance.BringToFront();             
            }
            else
                employeeDisciplineDashboardControl.Instance.BringToFront();
            this.HeaderLink.Text = "Discipline";
        }

        private void myInfoTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EmployeePersonalInformationDashboardControl employeePersonalInformationDashboardControl = new EmployeePersonalInformationDashboardControl(UserName);

            if (!employeePanel.Controls.Contains(employeePersonalInformationDashboardControl.Instance))
            {
                employeePanel.Controls.Add(employeePersonalInformationDashboardControl.Instance);
                employeePersonalInformationDashboardControl.Instance.Dock = DockStyle.Fill;
                employeePersonalInformationDashboardControl.Instance.BringToFront();
            }
            else
                employeePersonalInformationDashboardControl.Instance.BringToFront();
            this.HeaderLink.Text = "User Information";
        }

        private void homeTile_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            HomeDashBoardShow();
        }

        public void employeeNameShow()
        {
            string EmpName = " ";
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EmployeeName FROM UserInformation WHERE Username = '" + UserName + "'", Connection);              
                Adapter.SelectCommand.ExecuteNonQuery();
                DataTable EmployeeTable = new DataTable();
                Adapter.Fill(EmployeeTable);

                foreach (DataRow row in EmployeeTable.Rows)
                {
                    EmpName = row["EmployeeName"].ToString();
                }              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            finally
            {
                Connection.Close();
            }

            myInfoTile.Text = EmpName;           
        }

        private void logOutItem_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Successfull;
            popup.TitleText = "Log Out";
            popup.ContentText = "Successfully Loged Out";
            popup.ShowCloseButton = false;
            popup.Popup();
        }
    }
}
