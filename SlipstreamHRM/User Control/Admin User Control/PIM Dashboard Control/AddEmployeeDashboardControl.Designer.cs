namespace SlipstreamHRM.User_Control.PIM_Dashboard_Control
{
    partial class AddEmployeeDashboardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEmployeePanel = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.logInPanel = new MetroFramework.Controls.MetroPanel();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.StatusLabel = new MetroFramework.Controls.MetroLabel();
            this.UsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.statusComboBox = new MetroFramework.Controls.MetroComboBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ConfirmPaswordLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CreateLogInDetailsLabel = new MetroFramework.Controls.MetroLabel();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.txtEmployeeID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MiddleNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtMiddleName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LastNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FirstNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AddEmployeeLink = new MetroFramework.Controls.MetroLink();
            this.AddEmployeePanel.SuspendLayout();
            this.logInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEmployeePanel
            // 
            this.AddEmployeePanel.Controls.Add(this.btnSave);
            this.AddEmployeePanel.Controls.Add(this.logInPanel);
            this.AddEmployeePanel.Controls.Add(this.CreateLogInDetailsLabel);
            this.AddEmployeePanel.Controls.Add(this.metroToggle1);
            this.AddEmployeePanel.Controls.Add(this.txtEmployeeID);
            this.AddEmployeePanel.Controls.Add(this.metroLabel1);
            this.AddEmployeePanel.Controls.Add(this.txtLastName);
            this.AddEmployeePanel.Controls.Add(this.MiddleNameLabel);
            this.AddEmployeePanel.Controls.Add(this.txtMiddleName);
            this.AddEmployeePanel.Controls.Add(this.LastNameLabel);
            this.AddEmployeePanel.Controls.Add(this.txtFirstName);
            this.AddEmployeePanel.Controls.Add(this.FirstNameLabel);
            this.AddEmployeePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddEmployeePanel.HorizontalScrollbarBarColor = true;
            this.AddEmployeePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AddEmployeePanel.HorizontalScrollbarSize = 10;
            this.AddEmployeePanel.Location = new System.Drawing.Point(0, 38);
            this.AddEmployeePanel.Name = "AddEmployeePanel";
            this.AddEmployeePanel.Size = new System.Drawing.Size(945, 589);
            this.AddEmployeePanel.TabIndex = 3;
            this.AddEmployeePanel.VerticalScrollbarBarColor = true;
            this.AddEmployeePanel.VerticalScrollbarHighlightOnWheel = false;
            this.AddEmployeePanel.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(807, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // logInPanel
            // 
            this.logInPanel.Controls.Add(this.txtPassword);
            this.logInPanel.Controls.Add(this.StatusLabel);
            this.logInPanel.Controls.Add(this.UsernameLabel);
            this.logInPanel.Controls.Add(this.statusComboBox);
            this.logInPanel.Controls.Add(this.txtUsername);
            this.logInPanel.Controls.Add(this.ConfirmPaswordLabel);
            this.logInPanel.Controls.Add(this.PasswordLabel);
            this.logInPanel.Controls.Add(this.txtConfirmPassword);
            this.logInPanel.HorizontalScrollbarBarColor = true;
            this.logInPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.logInPanel.HorizontalScrollbarSize = 10;
            this.logInPanel.Location = new System.Drawing.Point(27, 241);
            this.logInPanel.Name = "logInPanel";
            this.logInPanel.Size = new System.Drawing.Size(582, 257);
            this.logInPanel.TabIndex = 20;
            this.logInPanel.VerticalScrollbarBarColor = true;
            this.logInPanel.VerticalScrollbarHighlightOnWheel = false;
            this.logInPanel.VerticalScrollbarSize = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(14, 127);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(253, 23);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(14, 172);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(49, 19);
            this.StatusLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.StatusLabel.TabIndex = 17;
            this.StatusLabel.Text = "Status*";
            this.StatusLabel.UseStyleColors = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(14, 23);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(74, 19);
            this.UsernameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Username*";
            this.UsernameLabel.UseStyleColors = true;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ItemHeight = 23;
            this.statusComboBox.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.statusComboBox.Location = new System.Drawing.Point(14, 204);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(253, 29);
            this.statusComboBox.TabIndex = 16;
            this.statusComboBox.UseSelectable = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Depth = 0;
            this.txtUsername.Hint = "";
            this.txtUsername.Location = new System.Drawing.Point(14, 57);
            this.txtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.Size = new System.Drawing.Size(253, 23);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // ConfirmPaswordLabel
            // 
            this.ConfirmPaswordLabel.AutoSize = true;
            this.ConfirmPaswordLabel.Location = new System.Drawing.Point(314, 93);
            this.ConfirmPaswordLabel.Name = "ConfirmPaswordLabel";
            this.ConfirmPaswordLabel.Size = new System.Drawing.Size(121, 19);
            this.ConfirmPaswordLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.ConfirmPaswordLabel.TabIndex = 12;
            this.ConfirmPaswordLabel.Text = "Confirm Password*";
            this.ConfirmPaswordLabel.UseStyleColors = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(14, 93);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 19);
            this.PasswordLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password*";
            this.PasswordLabel.UseStyleColors = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Depth = 0;
            this.txtConfirmPassword.Hint = "";
            this.txtConfirmPassword.Location = new System.Drawing.Point(314, 127);
            this.txtConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '\0';
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.Size = new System.Drawing.Size(253, 23);
            this.txtConfirmPassword.TabIndex = 13;
            this.txtConfirmPassword.UseSystemPasswordChar = false;
            // 
            // CreateLogInDetailsLabel
            // 
            this.CreateLogInDetailsLabel.AutoSize = true;
            this.CreateLogInDetailsLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.CreateLogInDetailsLabel.Location = new System.Drawing.Point(27, 208);
            this.CreateLogInDetailsLabel.Name = "CreateLogInDetailsLabel";
            this.CreateLogInDetailsLabel.Size = new System.Drawing.Size(151, 19);
            this.CreateLogInDetailsLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.CreateLogInDetailsLabel.TabIndex = 19;
            this.CreateLogInDetailsLabel.Text = "Create Log In Details:";
            this.CreateLogInDetailsLabel.UseStyleColors = true;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(184, 208);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 18;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Depth = 0;
            this.txtEmployeeID.Hint = "";
            this.txtEmployeeID.Location = new System.Drawing.Point(27, 130);
            this.txtEmployeeID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.PasswordChar = '\0';
            this.txtEmployeeID.SelectedText = "";
            this.txtEmployeeID.SelectionLength = 0;
            this.txtEmployeeID.SelectionStart = 0;
            this.txtEmployeeID.Size = new System.Drawing.Size(178, 23);
            this.txtEmployeeID.TabIndex = 9;
            this.txtEmployeeID.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 96);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Employee ID*";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Hint = "";
            this.txtLastName.Location = new System.Drawing.Point(746, 37);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(178, 23);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Depth = 0;
            this.MiddleNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.MiddleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MiddleNameLabel.Location = new System.Drawing.Point(323, 41);
            this.MiddleNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(102, 19);
            this.MiddleNameLabel.TabIndex = 6;
            this.MiddleNameLabel.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Depth = 0;
            this.txtMiddleName.Hint = "";
            this.txtMiddleName.Location = new System.Drawing.Point(431, 37);
            this.txtMiddleName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.SelectionLength = 0;
            this.txtMiddleName.SelectionStart = 0;
            this.txtMiddleName.Size = new System.Drawing.Size(178, 23);
            this.txtMiddleName.TabIndex = 5;
            this.txtMiddleName.UseSystemPasswordChar = false;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Depth = 0;
            this.LastNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LastNameLabel.Location = new System.Drawing.Point(654, 41);
            this.LastNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(86, 19);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(116, 37);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(178, 23);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Depth = 0;
            this.FirstNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(23, 41);
            this.FirstNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(87, 19);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // AddEmployeeLink
            // 
            this.AddEmployeeLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddEmployeeLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AddEmployeeLink.Location = new System.Drawing.Point(0, 0);
            this.AddEmployeeLink.Name = "AddEmployeeLink";
            this.AddEmployeeLink.Size = new System.Drawing.Size(945, 38);
            this.AddEmployeeLink.TabIndex = 2;
            this.AddEmployeeLink.Text = "Add Employee";
            this.AddEmployeeLink.UseSelectable = true;
            // 
            // AddEmployeeDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddEmployeePanel);
            this.Controls.Add(this.AddEmployeeLink);
            this.Name = "AddEmployeeDashboardControl";
            this.Size = new System.Drawing.Size(945, 627);
            this.Load += new System.EventHandler(this.AddEmployeeDashboardControl_Load);
            this.AddEmployeePanel.ResumeLayout(false);
            this.AddEmployeePanel.PerformLayout();
            this.logInPanel.ResumeLayout(false);
            this.logInPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel AddEmployeePanel;
        private MetroFramework.Controls.MetroLink AddEmployeeLink;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialLabel FirstNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MaterialSkin.Controls.MaterialLabel MiddleNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMiddleName;
        private MaterialSkin.Controls.MaterialLabel LastNameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmployeeID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel StatusLabel;
        private MetroFramework.Controls.MetroComboBox statusComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConfirmPassword;
        private MetroFramework.Controls.MetroLabel ConfirmPaswordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsername;
        private MetroFramework.Controls.MetroLabel UsernameLabel;
        private MetroFramework.Controls.MetroLabel CreateLogInDetailsLabel;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private MetroFramework.Controls.MetroPanel logInPanel;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}
