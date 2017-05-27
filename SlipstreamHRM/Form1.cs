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
using SlipstreamHRM.Forms;
using Tulpep.NotificationWindow;
using System.Threading;

namespace SlipstreamHRM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection Connection;

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlDataAdapter Adapter1 = new SqlDataAdapter(string.Format("Select Count(*) From LogInInfo Where Username COLLATE Latin1_General_CS_AS = '{0}' and Password COLLATE Latin1_General_CS_AS = '{1}'", UserNameTextBox.Text, PasswordTextBox.Text), Connection);
                DataTable LogInTable = new DataTable();
                Adapter1.Fill(LogInTable);
                if (LogInTable.Rows[0][0].ToString() == "1")
                {
                    Connection.Close();
                    try
                    {
                        Connection.Open();
                        string UserRole = "";
                        SqlDataAdapter Adapter2 = new SqlDataAdapter(string.Format("Select UserRole From UserInformation Where Username='{0}'", UserNameTextBox.Text), Connection);
                        DataTable UserInfomationTable = new DataTable();
                        Adapter2.Fill(UserInfomationTable);

                        
                        foreach (DataRow row in UserInfomationTable.Rows)
                        {
                            UserRole = row["UserRole"].ToString();
                        }

                        Connection.Close();

                        if (UserRole == "Global Admin")
                        {
                            this.Hide();
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.Successfull;
                            popup.TitleText = "Log In";
                            popup.ContentText = "Successfully Loged In";
                            popup.ShowCloseButton = false;
                            popup.Popup();
                            AdminControlManager adminControlManager = new AdminControlManager(UserNameTextBox.Text);
                            adminControlManager.Show();
                        }
                        else
                        {
                            this.Hide();
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.Successfull;
                            popup.TitleText = "Log In";
                            popup.ContentText = "Successfully Loged In";
                            popup.ShowCloseButton = false;
                            popup.Popup();
                            EmployeeControlManager employeeControlManager = new EmployeeControlManager(UserNameTextBox.Text);
                            employeeControlManager.Show();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Connection.Close();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Enter Your Username and Password Correctly", "Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
