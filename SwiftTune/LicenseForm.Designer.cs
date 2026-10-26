namespace SwiftTune
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.UpControlPanel = new System.Windows.Forms.Panel();
            this.DockNamePanel = new System.Windows.Forms.Panel();
            this.DockNameText = new System.Windows.Forms.Label();
            this.DockCloseButton = new System.Windows.Forms.Button();
            this.PanelForTextLicense = new System.Windows.Forms.Panel();
            this.LicenseTextBox = new System.Windows.Forms.RichTextBox();
            this.ForButtonLicensePanel = new System.Windows.Forms.Panel();
            this.BackToHelloMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UpControlPanel.SuspendLayout();
            this.DockNamePanel.SuspendLayout();
            this.PanelForTextLicense.SuspendLayout();
            this.ForButtonLicensePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpControlPanel
            // 
            this.UpControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.UpControlPanel.Controls.Add(this.DockNamePanel);
            this.UpControlPanel.Controls.Add(this.DockCloseButton);
            this.UpControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpControlPanel.Location = new System.Drawing.Point(0, 0);
            this.UpControlPanel.Name = "UpControlPanel";
            this.UpControlPanel.Size = new System.Drawing.Size(800, 30);
            this.UpControlPanel.TabIndex = 1;
            // 
            // DockNamePanel
            // 
            this.DockNamePanel.Controls.Add(this.DockNameText);
            this.DockNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNamePanel.Location = new System.Drawing.Point(0, 0);
            this.DockNamePanel.Name = "DockNamePanel";
            this.DockNamePanel.Size = new System.Drawing.Size(725, 30);
            this.DockNamePanel.TabIndex = 5;
            // 
            // DockNameText
            // 
            this.DockNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNameText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DockNameText.ForeColor = System.Drawing.Color.White;
            this.DockNameText.Location = new System.Drawing.Point(0, 0);
            this.DockNameText.Name = "DockNameText";
            this.DockNameText.Size = new System.Drawing.Size(725, 30);
            this.DockNameText.TabIndex = 5;
            this.DockNameText.Text = "Угода кінцевого користувача";
            this.DockNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DockNameText.Click += new System.EventHandler(this.DockNameText_Click);
            this.DockNameText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DockNameText_MouseDown);
            this.DockNameText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DockNameText_MouseMove);
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
            this.DockCloseButton.Location = new System.Drawing.Point(725, 0);
            this.DockCloseButton.Name = "DockCloseButton";
            this.DockCloseButton.Size = new System.Drawing.Size(75, 30);
            this.DockCloseButton.TabIndex = 0;
            this.DockCloseButton.Text = "X";
            this.toolTip1.SetToolTip(this.DockCloseButton, "Закрити");
            this.DockCloseButton.UseVisualStyleBackColor = true;
            this.DockCloseButton.Click += new System.EventHandler(this.DockCloseButton_Click);
            // 
            // PanelForTextLicense
            // 
            this.PanelForTextLicense.Controls.Add(this.LicenseTextBox);
            this.PanelForTextLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForTextLicense.Location = new System.Drawing.Point(0, 30);
            this.PanelForTextLicense.Name = "PanelForTextLicense";
            this.PanelForTextLicense.Size = new System.Drawing.Size(800, 368);
            this.PanelForTextLicense.TabIndex = 2;
            // 
            // LicenseTextBox
            // 
            this.LicenseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LicenseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LicenseTextBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.LicenseTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LicenseTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseTextBox.ForeColor = System.Drawing.Color.White;
            this.LicenseTextBox.Location = new System.Drawing.Point(0, 0);
            this.LicenseTextBox.Name = "LicenseTextBox";
            this.LicenseTextBox.ReadOnly = true;
            this.LicenseTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LicenseTextBox.Size = new System.Drawing.Size(800, 368);
            this.LicenseTextBox.TabIndex = 1;
            this.LicenseTextBox.Text = resources.GetString("LicenseTextBox.Text");
            // 
            // ForButtonLicensePanel
            // 
            this.ForButtonLicensePanel.Controls.Add(this.BackToHelloMenu);
            this.ForButtonLicensePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForButtonLicensePanel.Location = new System.Drawing.Point(0, 398);
            this.ForButtonLicensePanel.Name = "ForButtonLicensePanel";
            this.ForButtonLicensePanel.Padding = new System.Windows.Forms.Padding(300, 10, 300, 10);
            this.ForButtonLicensePanel.Size = new System.Drawing.Size(800, 52);
            this.ForButtonLicensePanel.TabIndex = 9;
            // 
            // BackToHelloMenu
            // 
            this.BackToHelloMenu.BackColor = System.Drawing.Color.DarkGray;
            this.BackToHelloMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHelloMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackToHelloMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackToHelloMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(16)))));
            this.BackToHelloMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackToHelloMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHelloMenu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToHelloMenu.ForeColor = System.Drawing.Color.Black;
            this.BackToHelloMenu.Location = new System.Drawing.Point(300, 10);
            this.BackToHelloMenu.Name = "BackToHelloMenu";
            this.BackToHelloMenu.Size = new System.Drawing.Size(200, 32);
            this.BackToHelloMenu.TabIndex = 0;
            this.BackToHelloMenu.Text = "Назад";
            this.BackToHelloMenu.UseVisualStyleBackColor = false;
            this.BackToHelloMenu.Click += new System.EventHandler(this.BackToHelloMenu_Click);
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ForButtonLicensePanel);
            this.Controls.Add(this.PanelForTextLicense);
            this.Controls.Add(this.UpControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LicenseText";
            this.Load += new System.EventHandler(this.LicenseText_Load);
            this.UpControlPanel.ResumeLayout(false);
            this.DockNamePanel.ResumeLayout(false);
            this.PanelForTextLicense.ResumeLayout(false);
            this.ForButtonLicensePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpControlPanel;
        private System.Windows.Forms.Button DockCloseButton;
        private System.Windows.Forms.Panel PanelForTextLicense;
        private System.Windows.Forms.Panel ForButtonLicensePanel;
        private System.Windows.Forms.Button BackToHelloMenu;
        private System.Windows.Forms.Panel DockNamePanel;
        private System.Windows.Forms.Label DockNameText;
        private System.Windows.Forms.RichTextBox LicenseTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}