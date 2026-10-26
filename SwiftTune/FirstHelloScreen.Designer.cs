namespace SwiftTune
{
    partial class FirstHelloScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstHelloScreen));
            this.UpControlPanel = new System.Windows.Forms.Panel();
            this.DockNamePanel = new System.Windows.Forms.Panel();
            this.DockNameText = new System.Windows.Forms.Label();
            this.DockHideButton = new System.Windows.Forms.Button();
            this.DockCloseButton = new System.Windows.Forms.Button();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.welcomepanel = new System.Windows.Forms.Panel();
            this.welcometext = new System.Windows.Forms.Label();
            this.forlogopanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DetailFromAppPanel = new System.Windows.Forms.Panel();
            this.FromAppText = new System.Windows.Forms.Label();
            this.ForLicensePanel = new System.Windows.Forms.Panel();
            this.LicenseClickText = new System.Windows.Forms.Label();
            this.checkBoxLicense = new System.Windows.Forms.CheckBox();
            this.ForRecommendationsPanel = new System.Windows.Forms.Panel();
            this.RecommendationsClickText = new System.Windows.Forms.Label();
            this.checkBoxRecommendations = new System.Windows.Forms.CheckBox();
            this.ForButtonNextPanel = new System.Windows.Forms.Panel();
            this.NextToMenuButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UpControlPanel.SuspendLayout();
            this.DockNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.welcomepanel.SuspendLayout();
            this.forlogopanel.SuspendLayout();
            this.DetailFromAppPanel.SuspendLayout();
            this.ForLicensePanel.SuspendLayout();
            this.ForRecommendationsPanel.SuspendLayout();
            this.ForButtonNextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpControlPanel
            // 
            this.UpControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.UpControlPanel.Controls.Add(this.DockNamePanel);
            this.UpControlPanel.Controls.Add(this.DockHideButton);
            this.UpControlPanel.Controls.Add(this.DockCloseButton);
            this.UpControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpControlPanel.Location = new System.Drawing.Point(0, 0);
            this.UpControlPanel.Name = "UpControlPanel";
            this.UpControlPanel.Size = new System.Drawing.Size(477, 30);
            this.UpControlPanel.TabIndex = 0;
            // 
            // DockNamePanel
            // 
            this.DockNamePanel.Controls.Add(this.DockNameText);
            this.DockNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNamePanel.Location = new System.Drawing.Point(0, 0);
            this.DockNamePanel.Name = "DockNamePanel";
            this.DockNamePanel.Size = new System.Drawing.Size(327, 30);
            this.DockNamePanel.TabIndex = 4;
            // 
            // DockNameText
            // 
            this.DockNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNameText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DockNameText.ForeColor = System.Drawing.Color.White;
            this.DockNameText.Location = new System.Drawing.Point(0, 0);
            this.DockNameText.Name = "DockNameText";
            this.DockNameText.Size = new System.Drawing.Size(327, 30);
            this.DockNameText.TabIndex = 4;
            this.DockNameText.Text = "SwiftTune";
            this.DockNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DockNameText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DockNameText_MouseDown);
            this.DockNameText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DockNameText_MouseMove);
            // 
            // DockHideButton
            // 
            this.DockHideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DockHideButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockHideButton.FlatAppearance.BorderSize = 0;
            this.DockHideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.DockHideButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DockHideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DockHideButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DockHideButton.Location = new System.Drawing.Point(327, 0);
            this.DockHideButton.Name = "DockHideButton";
            this.DockHideButton.Size = new System.Drawing.Size(75, 30);
            this.DockHideButton.TabIndex = 1;
            this.DockHideButton.Text = "—";
            this.toolTip1.SetToolTip(this.DockHideButton, "Згорнути");
            this.DockHideButton.UseVisualStyleBackColor = true;
            this.DockHideButton.Click += new System.EventHandler(this.DockHideButton_Click);
            // 
            // DockCloseButton
            // 
            this.DockCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DockCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DockCloseButton.FlatAppearance.BorderSize = 0;
            this.DockCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DockCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.DockCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DockCloseButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DockCloseButton.Location = new System.Drawing.Point(402, 0);
            this.DockCloseButton.Name = "DockCloseButton";
            this.DockCloseButton.Size = new System.Drawing.Size(75, 30);
            this.DockCloseButton.TabIndex = 0;
            this.DockCloseButton.Text = "X";
            this.toolTip1.SetToolTip(this.DockCloseButton, "Закрити");
            this.DockCloseButton.UseVisualStyleBackColor = true;
            this.DockCloseButton.Click += new System.EventHandler(this.DockCloseButton_Click);
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackgroundImage = global::SwiftTune.Properties.Resources.logo;
            this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPicture.Location = new System.Drawing.Point(0, 0);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(477, 180);
            this.LogoPicture.TabIndex = 1;
            this.LogoPicture.TabStop = false;
            this.LogoPicture.Click += new System.EventHandler(this.LogoPicture_Click_1);
            // 
            // welcomepanel
            // 
            this.welcomepanel.Controls.Add(this.welcometext);
            this.welcomepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomepanel.Location = new System.Drawing.Point(0, 30);
            this.welcomepanel.Name = "welcomepanel";
            this.welcomepanel.Size = new System.Drawing.Size(477, 40);
            this.welcomepanel.TabIndex = 2;
            // 
            // welcometext
            // 
            this.welcometext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcometext.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometext.ForeColor = System.Drawing.Color.White;
            this.welcometext.Location = new System.Drawing.Point(0, 0);
            this.welcometext.Name = "welcometext";
            this.welcometext.Size = new System.Drawing.Size(477, 40);
            this.welcometext.TabIndex = 3;
            this.welcometext.Text = "Ласкаво просимо";
            this.welcometext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forlogopanel
            // 
            this.forlogopanel.Controls.Add(this.panel1);
            this.forlogopanel.Controls.Add(this.LogoPicture);
            this.forlogopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.forlogopanel.Location = new System.Drawing.Point(0, 70);
            this.forlogopanel.Name = "forlogopanel";
            this.forlogopanel.Size = new System.Drawing.Size(477, 180);
            this.forlogopanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 127);
            this.panel1.TabIndex = 4;
            // 
            // DetailFromAppPanel
            // 
            this.DetailFromAppPanel.Controls.Add(this.FromAppText);
            this.DetailFromAppPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DetailFromAppPanel.Location = new System.Drawing.Point(0, 250);
            this.DetailFromAppPanel.Name = "DetailFromAppPanel";
            this.DetailFromAppPanel.Size = new System.Drawing.Size(477, 150);
            this.DetailFromAppPanel.TabIndex = 4;
            // 
            // FromAppText
            // 
            this.FromAppText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromAppText.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromAppText.ForeColor = System.Drawing.Color.White;
            this.FromAppText.Location = new System.Drawing.Point(0, 0);
            this.FromAppText.Name = "FromAppText";
            this.FromAppText.Padding = new System.Windows.Forms.Padding(5);
            this.FromAppText.Size = new System.Drawing.Size(477, 150);
            this.FromAppText.TabIndex = 0;
            this.FromAppText.Text = resources.GetString("FromAppText.Text");
            // 
            // ForLicensePanel
            // 
            this.ForLicensePanel.Controls.Add(this.LicenseClickText);
            this.ForLicensePanel.Controls.Add(this.checkBoxLicense);
            this.ForLicensePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ForLicensePanel.Location = new System.Drawing.Point(0, 400);
            this.ForLicensePanel.Name = "ForLicensePanel";
            this.ForLicensePanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ForLicensePanel.Size = new System.Drawing.Size(477, 50);
            this.ForLicensePanel.TabIndex = 6;
            // 
            // LicenseClickText
            // 
            this.LicenseClickText.AutoSize = true;
            this.LicenseClickText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LicenseClickText.Dock = System.Windows.Forms.DockStyle.Top;
            this.LicenseClickText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LicenseClickText.Location = new System.Drawing.Point(5, 25);
            this.LicenseClickText.Name = "LicenseClickText";
            this.LicenseClickText.Size = new System.Drawing.Size(275, 16);
            this.LicenseClickText.TabIndex = 1;
            this.LicenseClickText.Text = "Прочитати угоду кінцевого користувача";
            this.LicenseClickText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.LicenseClickText, "Натисніть аби переглянути угоду кінцевого користувача");
            this.LicenseClickText.Click += new System.EventHandler(this.LicenseClickText_Click);
            // 
            // checkBoxLicense
            // 
            this.checkBoxLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxLicense.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxLicense.FlatAppearance.BorderSize = 0;
            this.checkBoxLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLicense.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLicense.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxLicense.Location = new System.Drawing.Point(5, 0);
            this.checkBoxLicense.Name = "checkBoxLicense";
            this.checkBoxLicense.Size = new System.Drawing.Size(467, 25);
            this.checkBoxLicense.TabIndex = 0;
            this.checkBoxLicense.Text = "Угода кінцевого користувача";
            this.checkBoxLicense.UseVisualStyleBackColor = true;
            this.checkBoxLicense.CheckedChanged += new System.EventHandler(this.checkBoxLicense_CheckedChanged);
            // 
            // ForRecommendationsPanel
            // 
            this.ForRecommendationsPanel.Controls.Add(this.RecommendationsClickText);
            this.ForRecommendationsPanel.Controls.Add(this.checkBoxRecommendations);
            this.ForRecommendationsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ForRecommendationsPanel.Location = new System.Drawing.Point(0, 450);
            this.ForRecommendationsPanel.Name = "ForRecommendationsPanel";
            this.ForRecommendationsPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ForRecommendationsPanel.Size = new System.Drawing.Size(477, 50);
            this.ForRecommendationsPanel.TabIndex = 7;
            // 
            // RecommendationsClickText
            // 
            this.RecommendationsClickText.AutoSize = true;
            this.RecommendationsClickText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecommendationsClickText.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecommendationsClickText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RecommendationsClickText.Location = new System.Drawing.Point(5, 25);
            this.RecommendationsClickText.Name = "RecommendationsClickText";
            this.RecommendationsClickText.Size = new System.Drawing.Size(130, 16);
            this.RecommendationsClickText.TabIndex = 2;
            this.RecommendationsClickText.Text = "Прочитати поради";
            this.RecommendationsClickText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.RecommendationsClickText, "Натисніть аби переглянути поради щодо збереження цілісності свого ПК");
            this.RecommendationsClickText.Click += new System.EventHandler(this.RecommendationsClickText_Click);
            // 
            // checkBoxRecommendations
            // 
            this.checkBoxRecommendations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRecommendations.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRecommendations.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxRecommendations.FlatAppearance.BorderSize = 0;
            this.checkBoxRecommendations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRecommendations.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRecommendations.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxRecommendations.Location = new System.Drawing.Point(5, 0);
            this.checkBoxRecommendations.Name = "checkBoxRecommendations";
            this.checkBoxRecommendations.Size = new System.Drawing.Size(467, 25);
            this.checkBoxRecommendations.TabIndex = 1;
            this.checkBoxRecommendations.Text = "Ознайомлений(-а) із порадами\r\n\r\n";
            this.checkBoxRecommendations.UseVisualStyleBackColor = true;
            this.checkBoxRecommendations.CheckedChanged += new System.EventHandler(this.checkBoxLicense_CheckedChanged);
            // 
            // ForButtonNextPanel
            // 
            this.ForButtonNextPanel.Controls.Add(this.NextToMenuButton);
            this.ForButtonNextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForButtonNextPanel.Location = new System.Drawing.Point(0, 500);
            this.ForButtonNextPanel.Name = "ForButtonNextPanel";
            this.ForButtonNextPanel.Padding = new System.Windows.Forms.Padding(150, 10, 150, 10);
            this.ForButtonNextPanel.Size = new System.Drawing.Size(477, 75);
            this.ForButtonNextPanel.TabIndex = 8;
            // 
            // NextToMenuButton
            // 
            this.NextToMenuButton.BackColor = System.Drawing.Color.DarkGray;
            this.NextToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextToMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextToMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NextToMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(16)))));
            this.NextToMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NextToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextToMenuButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextToMenuButton.ForeColor = System.Drawing.Color.Black;
            this.NextToMenuButton.Location = new System.Drawing.Point(150, 10);
            this.NextToMenuButton.Name = "NextToMenuButton";
            this.NextToMenuButton.Size = new System.Drawing.Size(177, 55);
            this.NextToMenuButton.TabIndex = 0;
            this.NextToMenuButton.Text = "Продовжити";
            this.NextToMenuButton.UseVisualStyleBackColor = false;
            this.NextToMenuButton.Click += new System.EventHandler(this.NextToMenuButton_Click);
            // 
            // FirstHelloScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(477, 575);
            this.Controls.Add(this.ForButtonNextPanel);
            this.Controls.Add(this.ForRecommendationsPanel);
            this.Controls.Add(this.ForLicensePanel);
            this.Controls.Add(this.DetailFromAppPanel);
            this.Controls.Add(this.forlogopanel);
            this.Controls.Add(this.welcomepanel);
            this.Controls.Add(this.UpControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstHelloScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstHelloScreen";
            this.UpControlPanel.ResumeLayout(false);
            this.DockNamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.welcomepanel.ResumeLayout(false);
            this.forlogopanel.ResumeLayout(false);
            this.DetailFromAppPanel.ResumeLayout(false);
            this.ForLicensePanel.ResumeLayout(false);
            this.ForLicensePanel.PerformLayout();
            this.ForRecommendationsPanel.ResumeLayout(false);
            this.ForRecommendationsPanel.PerformLayout();
            this.ForButtonNextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpControlPanel;
        private System.Windows.Forms.Button DockHideButton;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Panel welcomepanel;
        private System.Windows.Forms.Panel forlogopanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel DetailFromAppPanel;
        private System.Windows.Forms.Label FromAppText;
        private System.Windows.Forms.Panel ForLicensePanel;
        private System.Windows.Forms.CheckBox checkBoxLicense;
        private System.Windows.Forms.Label LicenseClickText;
        private System.Windows.Forms.Panel ForRecommendationsPanel;
        private System.Windows.Forms.Label RecommendationsClickText;
        private System.Windows.Forms.CheckBox checkBoxRecommendations;
        private System.Windows.Forms.Panel ForButtonNextPanel;
        private System.Windows.Forms.Button NextToMenuButton;
        private System.Windows.Forms.Button DockCloseButton;
        private System.Windows.Forms.Panel DockNamePanel;
        private System.Windows.Forms.Label DockNameText;
        private System.Windows.Forms.Label welcometext;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}