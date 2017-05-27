using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SlipstreamHRM.DAL;


namespace SlipstreamHRM.Forms.Admin_Control_Form
{
    public partial class WorkShiftAddEdit : MaterialSkin.Controls.MaterialForm
    {
        private SqlConnection Connection;
        private WorkShiftInformation workShiftInformation;
        private string WorkShiftID;

        public WorkShiftAddEdit(string workShiftID, string workShift, float hoursPerDay, float from, float to)
        {
            InitializeComponent();
            this.WorkShiftID = workShiftID;
            this.Text = "Add Work Shift";
            if (!string.IsNullOrEmpty(WorkShiftID))
            {
                this.Text = "Work Shift";
                txtWorkShift.Text = workShift;
                txtHoursPerDay.Text = hoursPerDay.ToString();
                comboBoxFrom.Text = Convert.ToString(from);
                comboBoxTo.Text = Convert.ToString(to);
            }
        }

        private void WorkShiftAddEdit_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            workShiftInformation = new WorkShiftInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _workShiftID = Convert.ToInt32(WorkShiftID);
            workShiftInformation.WorkShift = txtWorkShift.Text;
            workShiftInformation.From = float.Parse(comboBoxFrom.Text);
            workShiftInformation.To = float.Parse(comboBoxTo.Text);

            if (string.IsNullOrEmpty(WorkShiftID))
            {
                try
                {
                    if (!string.IsNullOrEmpty(workShiftInformation.WorkShift) && !string.IsNullOrEmpty(workShiftInformation.From.ToString()) && !string.IsNullOrEmpty(workShiftInformation.To.ToString()))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter("INSERT INTO WorkShiftInformation (WorkShift, HoursPerDay, StartHour, EndHour) VALUES ('" + workShiftInformation.WorkShift + "','" + (workShiftInformation.To-workShiftInformation.From) + "','" + workShiftInformation.From + "','" + workShiftInformation.To + "')", Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
                this.Close();
            }
            else
            {
                try
                {
                    if (!string.IsNullOrEmpty(workShiftInformation.WorkShift) && !string.IsNullOrEmpty(workShiftInformation.From.ToString()) && !string.IsNullOrEmpty(workShiftInformation.To.ToString()))
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE WorkShiftInformation SET WorkShift = '{0}', HoursPerDay = '{1}', StartHour = '{2}', EndHour = '{3}' WHERE WorkShiftID = '{4}'", workShiftInformation.WorkShift, workShiftInformation.To - workShiftInformation.From, workShiftInformation.From, workShiftInformation.To, _workShiftID), Connection);
                        Adapter.SelectCommand.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Data Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Input Incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
                finally
                {
                    Connection.Close();
                }
                this.Close();
            }
        }
    }
}
