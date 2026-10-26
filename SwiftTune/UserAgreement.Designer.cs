namespace SwiftTune
{
    partial class UserAgreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAgreement));
            this.UpControlPanel = new System.Windows.Forms.Panel();
            this.DockNamePanel = new System.Windows.Forms.Panel();
            this.DockNameText = new System.Windows.Forms.Label();
            this.DockCloseButton = new System.Windows.Forms.Button();
            this.PanelForTextHelp = new System.Windows.Forms.Panel();
            this.UserAgreementTextBox = new System.Windows.Forms.RichTextBox();
            this.ForButtonAgreementPanel = new System.Windows.Forms.Panel();
            this.BackToHelloMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UpControlPanel.SuspendLayout();
            this.DockNamePanel.SuspendLayout();
            this.PanelForTextHelp.SuspendLayout();
            this.ForButtonAgreementPanel.SuspendLayout();
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
            this.UpControlPanel.TabIndex = 2;
            // 
            // DockNamePanel
            // 
            this.DockNamePanel.Controls.Add(this.DockNameText);
            this.DockNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNamePanel.Location = new System.Drawing.Point(0, 0);
            this.DockNamePanel.Name = "DockNamePanel";
            this.DockNamePanel.Size = new System.Drawing.Size(725, 30);
            this.DockNamePanel.TabIndex = 6;
            // 
            // DockNameText
            // 
            this.DockNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNameText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DockNameText.ForeColor = System.Drawing.Color.White;
            this.DockNameText.Location = new System.Drawing.Point(0, 0);
            this.DockNameText.Name = "DockNameText";
            this.DockNameText.Size = new System.Drawing.Size(725, 30);
            this.DockNameText.TabIndex = 6;
            this.DockNameText.Text = "Резервне копіювання: Інструкції та поради";
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
            // PanelForTextHelp
            // 
            this.PanelForTextHelp.Controls.Add(this.UserAgreementTextBox);
            this.PanelForTextHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForTextHelp.Location = new System.Drawing.Point(0, 30);
            this.PanelForTextHelp.Name = "PanelForTextHelp";
            this.PanelForTextHelp.Size = new System.Drawing.Size(800, 368);
            this.PanelForTextHelp.TabIndex = 3;
            // 
            // UserAgreementTextBox
            // 
            this.UserAgreementTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.UserAgreementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserAgreementTextBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.UserAgreementTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgreementTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAgreementTextBox.ForeColor = System.Drawing.Color.White;
            this.UserAgreementTextBox.Location = new System.Drawing.Point(0, 0);
            this.UserAgreementTextBox.Name = "UserAgreementTextBox";
            this.UserAgreementTextBox.ReadOnly = true;
            this.UserAgreementTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.UserAgreementTextBox.Size = new System.Drawing.Size(800, 368);
            this.UserAgreementTextBox.TabIndex = 1;
            this.UserAgreementTextBox.Text = resources.GetString("UserAgreementTextBox.Text");
            this.UserAgreementTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.UserAgreementTextBox_LinkClicked);
            this.UserAgreementTextBox.Click += new System.EventHandler(this.UserAgreementTextBox_Click);
            this.UserAgreementTextBox.TextChanged += new System.EventHandler(this.UserAgreementTextBox_TextChanged);
            // 
            // ForButtonAgreementPanel
            // 
            this.ForButtonAgreementPanel.Controls.Add(this.BackToHelloMenu);
            this.ForButtonAgreementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForButtonAgreementPanel.Location = new System.Drawing.Point(0, 398);
            this.ForButtonAgreementPanel.Name = "ForButtonAgreementPanel";
            this.ForButtonAgreementPanel.Padding = new System.Windows.Forms.Padding(300, 10, 300, 10);
            this.ForButtonAgreementPanel.Size = new System.Drawing.Size(800, 52);
            this.ForButtonAgreementPanel.TabIndex = 10;
            // 
            // BackToHelloMenu
            // 
            this.BackToHelloMenu.BackColor = System.Drawing.Color.DarkGray;
            this.BackToHelloMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHelloMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackToHelloMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackToHelloMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            // UserAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ForButtonAgreementPanel);
            this.Controls.Add(this.PanelForTextHelp);
            this.Controls.Add(this.UpControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAgreement";
            this.UpControlPanel.ResumeLayout(false);
            this.DockNamePanel.ResumeLayout(false);
            this.PanelForTextHelp.ResumeLayout(false);
            this.ForButtonAgreementPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpControlPanel;
        private System.Windows.Forms.Button DockCloseButton;
        private System.Windows.Forms.Panel DockNamePanel;
        private System.Windows.Forms.Label DockNameText;
        private System.Windows.Forms.Panel PanelForTextHelp;
        private System.Windows.Forms.Panel ForButtonAgreementPanel;
        private System.Windows.Forms.Button BackToHelloMenu;
        private System.Windows.Forms.RichTextBox UserAgreementTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}