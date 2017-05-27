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
using Tulpep.NotificationWindow;
using System.Threading;

namespace SlipstreamHRM.Forms
{
    public partial class ChangePasswordForm : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection Connection;
        private string _userName;

        public ChangePasswordForm(string userName)
        {
            InitializeComponent();
            this._userName = userName;
            txtUserName.WaterMark = _userName;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOldPassword.Text) && !string.IsNullOrEmpty(txtNewPassword.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                try
                {
                    string _oldPassword = " ";
                    string OldPassword = " ";
                    string NewPassword = " ";
                    string ConfirmedPassword = " ";
                    
                    try
                    {
                        Connection.Open();
                        SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select Password From LogInInfo Where Username ='{0}'", _userName), Connection);
                        DataTable LogInInfomationTable = new DataTable();
                        Adapter.Fill(LogInInfomationTable);

                        foreach (DataRow row in LogInInfomationTable.Rows)
                        {
                            _oldPassword = row["Password"].ToString();
                        }
                    }

                    catch(Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message, "Old Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }

                    finally
                    {
                        Connection.Close();
                    }

                    OldPassword = Convert.ToString(txtOldPassword.Text);
                    NewPassword = Convert.ToString(txtNewPassword.Text);
                    ConfirmedPassword = Convert.ToString(txtConfirmPassword.Text);

                    if (OldPassword.Equals(_oldPassword))
                    {
                        if (NewPassword.Equals(ConfirmedPassword))
                        {
                            Connection.Open();
                            SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("UPDATE LogInInfo SET Password = '{0}' WHERE Username = '{1}'", NewPassword, _userName), Connection);
                            Adapter.SelectCommand.ExecuteNonQuery();
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.Successfull;
                            popup.TitleText = "Password Changed";
                            popup.ContentText = "Password Successfully Updated";
                            popup.ShowCloseButton = false;
                            popup.Popup();
                            this.Close();
                        }

                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "New Password and Confirmed Password Didn't Matched", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Connection.Close();
                        }
                    }

                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Old Password Didn't Matched", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }                  
                }

                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }

                finally
                {
                    Connection.Close();                   
                }
            }

            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Text Required Fill", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
