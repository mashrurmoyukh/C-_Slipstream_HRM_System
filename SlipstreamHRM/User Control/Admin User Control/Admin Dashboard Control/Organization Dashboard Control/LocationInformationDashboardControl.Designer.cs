namespace SlipstreamHRM.User_Control.Admin_User_Control.Admin_Dashboard_Control.Organization_Dashboard_Control
{
    partial class LocationInformationDashboardControl
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
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtLocationName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LocationNameLabel = new MetroFramework.Controls.MetroLabel();
            this.AddLocationLink = new MetroFramework.Controls.MetroLink();
            this.comboxCountry = new MetroFramework.Controls.MetroComboBox();
            this.CountryLabel = new MetroFramework.Controls.MetroLabel();
            this.LocationListLick = new MetroFramework.Controls.MetroLink();
            this.locationDataGridView = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel
            // 
            this.metroPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel.Controls.Add(this.comboxCountry);
            this.metroPanel.Controls.Add(this.CountryLabel);
            this.metroPanel.Controls.Add(this.AddLocationLink);
            this.metroPanel.Controls.Add(this.btnSave);
            this.metroPanel.Controls.Add(this.txtLocationName);
            this.metroPanel.Controls.Add(this.LocationNameLabel);
            this.metroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(0, 0);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(934, 139);
            this.metroPanel.TabIndex = 4;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = global::SlipstreamHRM.Properties.Resources.Green_Color;
            this.btnSave.Location = new System.Drawing.Point(828, 74);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "&Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLocationName
            // 
            this.txtLocationName.Depth = 0;
            this.txtLocationName.Hint = "";
            this.txtLocationName.Location = new System.Drawing.Point(45, 83);
            this.txtLocationName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.PasswordChar = '\0';
            this.txtLocationName.SelectedText = "";
            this.txtLocationName.SelectionLength = 0;
            this.txtLocationName.SelectionStart = 0;
            this.txtLocationName.Size = new System.Drawing.Size(356, 23);
            this.txtLocationName.TabIndex = 28;
            this.txtLocationName.UseSystemPasswordChar = false;
            // 
            // LocationNameLabel
            // 
            this.LocationNameLabel.AutoSize = true;
            this.LocationNameLabel.Location = new System.Drawing.Point(45, 59);
            this.LocationNameLabel.Name = "LocationNameLabel";
            this.LocationNameLabel.Size = new System.Drawing.Size(98, 19);
            this.LocationNameLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.LocationNameLabel.TabIndex = 27;
            this.LocationNameLabel.Text = "Location Name";
            this.LocationNameLabel.UseStyleColors = true;
            // 
            // AddLocationLink
            // 
            this.AddLocationLink.BackColor = System.Drawing.Color.SteelBlue;
            this.AddLocationLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddLocationLink.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.AddLocationLink.ForeColor = System.Drawing.Color.White;
            this.AddLocationLink.Location = new System.Drawing.Point(0, 0);
            this.AddLocationLink.Name = "AddLocationLink";
            this.AddLocationLink.Size = new System.Drawing.Size(932, 27);
            this.AddLocationLink.TabIndex = 49;
            this.AddLocationLink.Text = "Add Location";
            this.AddLocationLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddLocationLink.UseCustomBackColor = true;
            this.AddLocationLink.UseCustomForeColor = true;
            this.AddLocationLink.UseSelectable = true;
            // 
            // comboxCountry
            // 
            this.comboxCountry.FormattingEnabled = true;
            this.comboxCountry.ItemHeight = 23;
            this.comboxCountry.Location = new System.Drawing.Point(468, 77);
            this.comboxCountry.Name = "comboxCountry";
            this.comboxCountry.Size = new System.Drawing.Size(283, 29);
            this.comboxCountry.TabIndex = 51;
            this.comboxCountry.UseSelectable = true;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.CountryLabel.Location = new System.Drawing.Point(468, 59);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(47, 15);
            this.CountryLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.CountryLabel.TabIndex = 50;
            this.CountryLabel.Text = "Country";
            this.CountryLabel.UseStyleColors = true;
            // 
            // LocationListLick
            // 
            this.LocationListLick.BackColor = System.Drawing.Color.SteelBlue;
            this.LocationListLick.Dock = System.Windows.Forms.DockStyle.Top;
            this.LocationListLick.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.LocationListLick.ForeColor = System.Drawing.Color.White;
            this.LocationListLick.Location = new System.Drawing.Point(0, 139);
            this.LocationListLick.Name = "LocationListLick";
            this.LocationListLick.Size = new System.Drawing.Size(934, 27);
            this.LocationListLick.TabIndex = 50;
            this.LocationListLick.Text = "Lcation List";
            this.LocationListLick.UseCustomBackColor = true;
            this.LocationListLick.UseCustomForeColor = true;
            this.LocationListLick.UseSelectable = true;
            // 
            // locationDataGridView
            // 
            this.locationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.locationDataGridView.Location = new System.Drawing.Point(0, 210);
            this.locationDataGridView.Name = "locationDataGridView";
            this.locationDataGridView.Size = new System.Drawing.Size(934, 349);
            this.locationDataGridView.TabIndex = 51;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metroButton1.Location = new System.Drawing.Point(830, 172);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 32);
            this.metroButton1.TabIndex = 52;
            this.metroButton1.Text = "&Delete";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LocationInformationDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.locationDataGridView);
            this.Controls.Add(this.LocationListLick);
            this.Controls.Add(this.metroPanel);
            this.Name = "LocationInformationDashboardControl";
            this.Size = new System.Drawing.Size(934, 559);
            this.Load += new System.EventHandler(this.LocationInformationDashboardControl_Load);
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocationName;
        private MetroFramework.Controls.MetroLabel LocationNameLabel;
        private MetroFramework.Controls.MetroLink AddLocationLink;
        private MetroFramework.Controls.MetroComboBox comboxCountry;
        private MetroFramework.Controls.MetroLabel CountryLabel;
        private MetroFramework.Controls.MetroLink LocationListLick;
        private System.Windows.Forms.DataGridView locationDataGridView;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
