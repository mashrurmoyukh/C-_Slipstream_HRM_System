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
namespace SlipstreamHRM
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shafayet\Documents\DBSlipstreamHRM.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter Adapter = new SqlDataAdapter(string.Format("Select Count(*) From LogInInfo Where Username='{0}' and Password='{1}'", UserNameTextBox.Text, PasswordTextBox.Text), Connection);
            DataTable LogInTable = new DataTable();
            Adapter.Fill(LogInTable);
            if (LogInTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                AdminControlManager adminControlManager = new AdminControlManager("Admin");
                adminControlManager.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Your Username and Password Correctly", "Invalid Username/Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
