namespace SwiftTune
{
    partial class CustomLevelOptimizationDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomLevelOptimizationDetail));
            this.UpControlPanel = new System.Windows.Forms.Panel();
            this.DockNamePanel = new System.Windows.Forms.Panel();
            this.DockNameText = new System.Windows.Forms.Label();
            this.DockCloseButton = new System.Windows.Forms.Button();
            this.PanelForNameOfFileOptimization = new System.Windows.Forms.Panel();
            this.TextOfLevelOptimizationName = new System.Windows.Forms.Label();
            this.PanelForRichTBfromDetails = new System.Windows.Forms.Panel();
            this.RichTBtoTextDetails = new System.Windows.Forms.RichTextBox();
            this.PanelForButtonBack = new System.Windows.Forms.Panel();
            this.BackToHelloMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UpControlPanel.SuspendLayout();
            this.DockNamePanel.SuspendLayout();
            this.PanelForNameOfFileOptimization.SuspendLayout();
            this.PanelForRichTBfromDetails.SuspendLayout();
            this.PanelForButtonBack.SuspendLayout();
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
            this.UpControlPanel.Size = new System.Drawing.Size(477, 30);
            this.UpControlPanel.TabIndex = 2;
            // 
            // DockNamePanel
            // 
            this.DockNamePanel.Controls.Add(this.DockNameText);
            this.DockNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNamePanel.Location = new System.Drawing.Point(0, 0);
            this.DockNamePanel.Name = "DockNamePanel";
            this.DockNamePanel.Size = new System.Drawing.Size(402, 30);
            this.DockNamePanel.TabIndex = 6;
            // 
            // DockNameText
            // 
            this.DockNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNameText.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DockNameText.ForeColor = System.Drawing.Color.White;
            this.DockNameText.Location = new System.Drawing.Point(0, 0);
            this.DockNameText.Name = "DockNameText";
            this.DockNameText.Size = new System.Drawing.Size(402, 30);
            this.DockNameText.TabIndex = 6;
            this.DockNameText.Text = "SwiftTune (Користувацький рівень оптимізації)";
            this.DockNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.DockCloseButton.Location = new System.Drawing.Point(402, 0);
            this.DockCloseButton.Name = "DockCloseButton";
            this.DockCloseButton.Size = new System.Drawing.Size(75, 30);
            this.DockCloseButton.TabIndex = 0;
            this.DockCloseButton.Text = "X";
            this.toolTip1.SetToolTip(this.DockCloseButton, "Закрити");
            this.DockCloseButton.UseVisualStyleBackColor = true;
            this.DockCloseButton.Click += new System.EventHandler(this.DockCloseButton_Click);
            // 
            // PanelForNameOfFileOptimization
            // 
            this.PanelForNameOfFileOptimization.AutoSize = true;
            this.PanelForNameOfFileOptimization.BackColor = System.Drawing.Color.Transparent;
            this.PanelForNameOfFileOptimization.Controls.Add(this.TextOfLevelOptimizationName);
            this.PanelForNameOfFileOptimization.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForNameOfFileOptimization.Location = new System.Drawing.Point(0, 30);
            this.PanelForNameOfFileOptimization.Name = "PanelForNameOfFileOptimization";
            this.PanelForNameOfFileOptimization.Padding = new System.Windows.Forms.Padding(70, 5, 70, 5);
            this.PanelForNameOfFileOptimization.Size = new System.Drawing.Size(477, 52);
            this.PanelForNameOfFileOptimization.TabIndex = 3;
            // 
            // TextOfLevelOptimizationName
            // 
            this.TextOfLevelOptimizationName.AutoSize = true;
            this.TextOfLevelOptimizationName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextOfLevelOptimizationName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextOfLevelOptimizationName.ForeColor = System.Drawing.Color.White;
            this.TextOfLevelOptimizationName.Location = new System.Drawing.Point(70, 5);
            this.TextOfLevelOptimizationName.Name = "TextOfLevelOptimizationName";
            this.TextOfLevelOptimizationName.Size = new System.Drawing.Size(323, 42);
            this.TextOfLevelOptimizationName.TabIndex = 0;
            this.TextOfLevelOptimizationName.Text = "Користувацький рівень оптимізації\r\n(CustomLevelOptimization.bat)";
            this.TextOfLevelOptimizationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelForRichTBfromDetails
            // 
            this.PanelForRichTBfromDetails.Controls.Add(this.RichTBtoTextDetails);
            this.PanelForRichTBfromDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForRichTBfromDetails.Location = new System.Drawing.Point(0, 82);
            this.PanelForRichTBfromDetails.Name = "PanelForRichTBfromDetails";
            this.PanelForRichTBfromDetails.Size = new System.Drawing.Size(477, 425);
            this.PanelForRichTBfromDetails.TabIndex = 4;
            // 
            // RichTBtoTextDetails
            // 
            this.RichTBtoTextDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.RichTBtoTextDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.RichTBtoTextDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTBtoTextDetails.ForeColor = System.Drawing.Color.White;
            this.RichTBtoTextDetails.Location = new System.Drawing.Point(0, 0);
            this.RichTBtoTextDetails.Name = "RichTBtoTextDetails";
            this.RichTBtoTextDetails.ReadOnly = true;
            this.RichTBtoTextDetails.Size = new System.Drawing.Size(477, 425);
            this.RichTBtoTextDetails.TabIndex = 1;
            this.RichTBtoTextDetails.Text = "Цей режим не містить попередніх налаштувань, користувач самостійно обирає компоне" +
    "нти. Щоб обрати потрібні зміни, натисніть кнопку налаштувань праворуч від трекер" +
    "а оптимізації.";
            // 
            // PanelForButtonBack
            // 
            this.PanelForButtonBack.Controls.Add(this.BackToHelloMenu);
            this.PanelForButtonBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForButtonBack.Location = new System.Drawing.Point(0, 507);
            this.PanelForButtonBack.Name = "PanelForButtonBack";
            this.PanelForButtonBack.Padding = new System.Windows.Forms.Padding(150, 10, 150, 10);
            this.PanelForButtonBack.Size = new System.Drawing.Size(477, 68);
            this.PanelForButtonBack.TabIndex = 5;
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
            this.BackToHelloMenu.Location = new System.Drawing.Point(150, 10);
            this.BackToHelloMenu.Name = "BackToHelloMenu";
            this.BackToHelloMenu.Size = new System.Drawing.Size(177, 48);
            this.BackToHelloMenu.TabIndex = 1;
            this.BackToHelloMenu.Text = "Назад";
            this.BackToHelloMenu.UseVisualStyleBackColor = false;
            this.BackToHelloMenu.Click += new System.EventHandler(this.BackToHelloMenu_Click);
            // 
            // CustomLevelOptimizationDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(477, 575);
            this.Controls.Add(this.PanelForButtonBack);
            this.Controls.Add(this.PanelForRichTBfromDetails);
            this.Controls.Add(this.PanelForNameOfFileOptimization);
            this.Controls.Add(this.UpControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomLevelOptimizationDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomLevelOptimizationDetail";
            this.UpControlPanel.ResumeLayout(false);
            this.DockNamePanel.ResumeLayout(false);
            this.PanelForNameOfFileOptimization.ResumeLayout(false);
            this.PanelForNameOfFileOptimization.PerformLayout();
            this.PanelForRichTBfromDetails.ResumeLayout(false);
            this.PanelForButtonBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpControlPanel;
        private System.Windows.Forms.Button DockCloseButton;
        private System.Windows.Forms.Panel PanelForNameOfFileOptimization;
        private System.Windows.Forms.Label TextOfLevelOptimizationName;
        private System.Windows.Forms.Panel PanelForRichTBfromDetails;
        private System.Windows.Forms.Panel PanelForButtonBack;
        private System.Windows.Forms.Button BackToHelloMenu;
        private System.Windows.Forms.Panel DockNamePanel;
        private System.Windows.Forms.Label DockNameText;
        private System.Windows.Forms.RichTextBox RichTBtoTextDetails;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}