namespace SwiftTune
{
    partial class OptimizationLevelsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptimizationLevelsScreen));
            this.UpControlPanel = new System.Windows.Forms.Panel();
            this.DockNamePanel = new System.Windows.Forms.Panel();
            this.DockNameText = new System.Windows.Forms.Label();
            this.DockHideButton = new System.Windows.Forms.Button();
            this.DockCloseButton = new System.Windows.Forms.Button();
            this.PanelForStatus = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusInTimeText = new System.Windows.Forms.Label();
            this.StatusInTimeDecoration = new System.Windows.Forms.Label();
            this.TrackerInOptimizationStart = new System.Windows.Forms.TrackBar();
            this.EmptyPanelDownTracker = new System.Windows.Forms.Panel();
            this.PanelForTrackerInto = new System.Windows.Forms.Panel();
            this.ForSettingsCustomLevelOptimizationIcon = new System.Windows.Forms.PictureBox();
            this.CustomLevelOptimizationText = new System.Windows.Forms.Label();
            this.LowerLevelOptimizationText = new System.Windows.Forms.Label();
            this.HigherLevelOptimizationText = new System.Windows.Forms.Label();
            this.StartOptimizationButton = new System.Windows.Forms.Button();
            this.EmptyPanelForStartOptimizationButton = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonToOpenExplorerForFileConfiguration = new System.Windows.Forms.PictureBox();
            this.AllRestoreToDefault = new System.Windows.Forms.PictureBox();
            this.UnderstoodButton = new System.Windows.Forms.PictureBox();
            this.EmptyPanelForRestorePoint = new System.Windows.Forms.Panel();
            this.ForCreateHiddenRestorePoint = new System.Windows.Forms.CheckBox();
            this.CreateRestorePointForce = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.UpControlPanel.SuspendLayout();
            this.DockNamePanel.SuspendLayout();
            this.PanelForStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackerInOptimizationStart)).BeginInit();
            this.PanelForTrackerInto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForSettingsCustomLevelOptimizationIcon)).BeginInit();
            this.EmptyPanelForStartOptimizationButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonToOpenExplorerForFileConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllRestoreToDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderstoodButton)).BeginInit();
            this.EmptyPanelForRestorePoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateRestorePointForce)).BeginInit();
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
            this.UpControlPanel.Size = new System.Drawing.Size(800, 30);
            this.UpControlPanel.TabIndex = 1;
            // 
            // DockNamePanel
            // 
            this.DockNamePanel.Controls.Add(this.DockNameText);
            this.DockNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNamePanel.Location = new System.Drawing.Point(0, 0);
            this.DockNamePanel.Name = "DockNamePanel";
            this.DockNamePanel.Size = new System.Drawing.Size(650, 30);
            this.DockNamePanel.TabIndex = 5;
            // 
            // DockNameText
            // 
            this.DockNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DockNameText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DockNameText.ForeColor = System.Drawing.Color.White;
            this.DockNameText.Location = new System.Drawing.Point(0, 0);
            this.DockNameText.Name = "DockNameText";
            this.DockNameText.Size = new System.Drawing.Size(650, 30);
            this.DockNameText.TabIndex = 5;
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
            this.DockHideButton.Location = new System.Drawing.Point(650, 0);
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
            this.DockCloseButton.Location = new System.Drawing.Point(725, 0);
            this.DockCloseButton.Name = "DockCloseButton";
            this.DockCloseButton.Size = new System.Drawing.Size(75, 30);
            this.DockCloseButton.TabIndex = 0;
            this.DockCloseButton.Text = "X";
            this.toolTip1.SetToolTip(this.DockCloseButton, "Закрити");
            this.DockCloseButton.UseVisualStyleBackColor = true;
            this.DockCloseButton.Click += new System.EventHandler(this.DockCloseButton_Click);
            // 
            // PanelForStatus
            // 
            this.PanelForStatus.Controls.Add(this.pictureBox1);
            this.PanelForStatus.Controls.Add(this.StatusInTimeText);
            this.PanelForStatus.Controls.Add(this.StatusInTimeDecoration);
            this.PanelForStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForStatus.Location = new System.Drawing.Point(0, 30);
            this.PanelForStatus.Name = "PanelForStatus";
            this.PanelForStatus.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.PanelForStatus.Size = new System.Drawing.Size(800, 30);
            this.PanelForStatus.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SwiftTune.Properties.Resources.other;
            this.pictureBox1.Location = new System.Drawing.Point(762, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Додаткове меню (для досвідчених користувачів)");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StatusInTimeText
            // 
            this.StatusInTimeText.AutoSize = true;
            this.StatusInTimeText.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusInTimeText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusInTimeText.ForeColor = System.Drawing.Color.Maroon;
            this.StatusInTimeText.Location = new System.Drawing.Point(97, 2);
            this.StatusInTimeText.Name = "StatusInTimeText";
            this.StatusInTimeText.Size = new System.Drawing.Size(131, 23);
            this.StatusInTimeText.TabIndex = 1;
            this.StatusInTimeText.Text = "Неактивний";
            this.StatusInTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusInTimeDecoration
            // 
            this.StatusInTimeDecoration.AutoSize = true;
            this.StatusInTimeDecoration.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusInTimeDecoration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusInTimeDecoration.ForeColor = System.Drawing.Color.White;
            this.StatusInTimeDecoration.Location = new System.Drawing.Point(5, 2);
            this.StatusInTimeDecoration.Name = "StatusInTimeDecoration";
            this.StatusInTimeDecoration.Size = new System.Drawing.Size(92, 23);
            this.StatusInTimeDecoration.TabIndex = 0;
            this.StatusInTimeDecoration.Text = "Статус:";
            this.StatusInTimeDecoration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TrackerInOptimizationStart
            // 
            this.TrackerInOptimizationStart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TrackerInOptimizationStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackerInOptimizationStart.LargeChange = 1;
            this.TrackerInOptimizationStart.Location = new System.Drawing.Point(25, 0);
            this.TrackerInOptimizationStart.Maximum = 3;
            this.TrackerInOptimizationStart.Minimum = 1;
            this.TrackerInOptimizationStart.Name = "TrackerInOptimizationStart";
            this.TrackerInOptimizationStart.Size = new System.Drawing.Size(705, 56);
            this.TrackerInOptimizationStart.TabIndex = 3;
            this.TrackerInOptimizationStart.Value = 1;
            this.TrackerInOptimizationStart.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // EmptyPanelDownTracker
            // 
            this.EmptyPanelDownTracker.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmptyPanelDownTracker.Location = new System.Drawing.Point(0, 60);
            this.EmptyPanelDownTracker.Name = "EmptyPanelDownTracker";
            this.EmptyPanelDownTracker.Size = new System.Drawing.Size(800, 120);
            this.EmptyPanelDownTracker.TabIndex = 4;
            // 
            // PanelForTrackerInto
            // 
            this.PanelForTrackerInto.Controls.Add(this.ForSettingsCustomLevelOptimizationIcon);
            this.PanelForTrackerInto.Controls.Add(this.CustomLevelOptimizationText);
            this.PanelForTrackerInto.Controls.Add(this.LowerLevelOptimizationText);
            this.PanelForTrackerInto.Controls.Add(this.HigherLevelOptimizationText);
            this.PanelForTrackerInto.Controls.Add(this.TrackerInOptimizationStart);
            this.PanelForTrackerInto.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelForTrackerInto.Location = new System.Drawing.Point(0, 180);
            this.PanelForTrackerInto.Name = "PanelForTrackerInto";
            this.PanelForTrackerInto.Padding = new System.Windows.Forms.Padding(25, 0, 70, 0);
            this.PanelForTrackerInto.Size = new System.Drawing.Size(800, 56);
            this.PanelForTrackerInto.TabIndex = 5;
            // 
            // ForSettingsCustomLevelOptimizationIcon
            // 
            this.ForSettingsCustomLevelOptimizationIcon.BackColor = System.Drawing.Color.DarkGray;
            this.ForSettingsCustomLevelOptimizationIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ForSettingsCustomLevelOptimizationIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForSettingsCustomLevelOptimizationIcon.Image = global::SwiftTune.Properties.Resources.settings;
            this.ForSettingsCustomLevelOptimizationIcon.Location = new System.Drawing.Point(725, 3);
            this.ForSettingsCustomLevelOptimizationIcon.Name = "ForSettingsCustomLevelOptimizationIcon";
            this.ForSettingsCustomLevelOptimizationIcon.Size = new System.Drawing.Size(26, 26);
            this.ForSettingsCustomLevelOptimizationIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ForSettingsCustomLevelOptimizationIcon.TabIndex = 8;
            this.ForSettingsCustomLevelOptimizationIcon.TabStop = false;
            this.toolTip1.SetToolTip(this.ForSettingsCustomLevelOptimizationIcon, "Налаштування для користувацького рівня оптимізації");
            this.ForSettingsCustomLevelOptimizationIcon.Click += new System.EventHandler(this.ForSettingsCustomLevelOptimizationIcon_Click);
            // 
            // CustomLevelOptimizationText
            // 
            this.CustomLevelOptimizationText.AutoSize = true;
            this.CustomLevelOptimizationText.BackColor = System.Drawing.Color.Transparent;
            this.CustomLevelOptimizationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomLevelOptimizationText.ForeColor = System.Drawing.Color.White;
            this.CustomLevelOptimizationText.Location = new System.Drawing.Point(646, 37);
            this.CustomLevelOptimizationText.Name = "CustomLevelOptimizationText";
            this.CustomLevelOptimizationText.Size = new System.Drawing.Size(131, 20);
            this.CustomLevelOptimizationText.TabIndex = 7;
            this.CustomLevelOptimizationText.Text = "Користувацький";
            this.CustomLevelOptimizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.CustomLevelOptimizationText, "Натисніть, щоб переглянути про цей рівень оптимізації");
            this.CustomLevelOptimizationText.Click += new System.EventHandler(this.CustomLevelOptimizationText_Click);
            this.CustomLevelOptimizationText.MouseEnter += new System.EventHandler(this.CustomLevelOptimizationText_MouseEnter);
            this.CustomLevelOptimizationText.MouseLeave += new System.EventHandler(this.CustomLevelOptimizationText_MouseLeave);
            // 
            // LowerLevelOptimizationText
            // 
            this.LowerLevelOptimizationText.AutoSize = true;
            this.LowerLevelOptimizationText.BackColor = System.Drawing.Color.Transparent;
            this.LowerLevelOptimizationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowerLevelOptimizationText.ForeColor = System.Drawing.Color.Green;
            this.LowerLevelOptimizationText.Location = new System.Drawing.Point(12, 37);
            this.LowerLevelOptimizationText.Name = "LowerLevelOptimizationText";
            this.LowerLevelOptimizationText.Size = new System.Drawing.Size(67, 20);
            this.LowerLevelOptimizationText.TabIndex = 2;
            this.LowerLevelOptimizationText.Text = "Низький";
            this.LowerLevelOptimizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LowerLevelOptimizationText, "Натисніть, щоб переглянути про цей рівень оптимізації");
            this.LowerLevelOptimizationText.Click += new System.EventHandler(this.LowerLevelOptimizationText_Click);
            this.LowerLevelOptimizationText.MouseEnter += new System.EventHandler(this.LowerLevelOptimizationText_MouseEnter);
            this.LowerLevelOptimizationText.MouseLeave += new System.EventHandler(this.LowerLevelOptimizationText_MouseLeave);
            // 
            // HigherLevelOptimizationText
            // 
            this.HigherLevelOptimizationText.AutoSize = true;
            this.HigherLevelOptimizationText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HigherLevelOptimizationText.ForeColor = System.Drawing.Color.Red;
            this.HigherLevelOptimizationText.Location = new System.Drawing.Point(343, 37);
            this.HigherLevelOptimizationText.Name = "HigherLevelOptimizationText";
            this.HigherLevelOptimizationText.Size = new System.Drawing.Size(73, 20);
            this.HigherLevelOptimizationText.TabIndex = 6;
            this.HigherLevelOptimizationText.Text = "Високий";
            this.HigherLevelOptimizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.HigherLevelOptimizationText, "Натисніть, щоб переглянути про цей рівень оптимізації");
            this.HigherLevelOptimizationText.Click += new System.EventHandler(this.HigherLevelOptimizationText_Click);
            this.HigherLevelOptimizationText.MouseEnter += new System.EventHandler(this.HigherLevelOptimizationText_MouseEnter);
            this.HigherLevelOptimizationText.MouseLeave += new System.EventHandler(this.HigherLevelOptimizationText_MouseLeave);
            // 
            // StartOptimizationButton
            // 
            this.StartOptimizationButton.BackColor = System.Drawing.Color.DarkGray;
            this.StartOptimizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartOptimizationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartOptimizationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(16)))));
            this.StartOptimizationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartOptimizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartOptimizationButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartOptimizationButton.Location = new System.Drawing.Point(305, 20);
            this.StartOptimizationButton.Name = "StartOptimizationButton";
            this.StartOptimizationButton.Size = new System.Drawing.Size(190, 45);
            this.StartOptimizationButton.TabIndex = 6;
            this.StartOptimizationButton.Text = "Оптимізувати";
            this.StartOptimizationButton.UseVisualStyleBackColor = false;
            this.StartOptimizationButton.Click += new System.EventHandler(this.StartOptimizationButton_Click);
            // 
            // EmptyPanelForStartOptimizationButton
            // 
            this.EmptyPanelForStartOptimizationButton.Controls.Add(this.pictureBox2);
            this.EmptyPanelForStartOptimizationButton.Controls.Add(this.ButtonToOpenExplorerForFileConfiguration);
            this.EmptyPanelForStartOptimizationButton.Controls.Add(this.AllRestoreToDefault);
            this.EmptyPanelForStartOptimizationButton.Controls.Add(this.UnderstoodButton);
            this.EmptyPanelForStartOptimizationButton.Controls.Add(this.StartOptimizationButton);
            this.EmptyPanelForStartOptimizationButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmptyPanelForStartOptimizationButton.Location = new System.Drawing.Point(0, 350);
            this.EmptyPanelForStartOptimizationButton.Name = "EmptyPanelForStartOptimizationButton";
            this.EmptyPanelForStartOptimizationButton.Size = new System.Drawing.Size(800, 100);
            this.EmptyPanelForStartOptimizationButton.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SwiftTune.Properties.Resources.InformationIcon;
            this.pictureBox2.Location = new System.Drawing.Point(16, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Натисніть, щоб переглянути поради перед запуском оптимізації");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ButtonToOpenExplorerForFileConfiguration
            // 
            this.ButtonToOpenExplorerForFileConfiguration.BackColor = System.Drawing.Color.DimGray;
            this.ButtonToOpenExplorerForFileConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToOpenExplorerForFileConfiguration.Image = global::SwiftTune.Properties.Resources.OpenInExplorerIcon;
            this.ButtonToOpenExplorerForFileConfiguration.Location = new System.Drawing.Point(762, 39);
            this.ButtonToOpenExplorerForFileConfiguration.Name = "ButtonToOpenExplorerForFileConfiguration";
            this.ButtonToOpenExplorerForFileConfiguration.Size = new System.Drawing.Size(26, 26);
            this.ButtonToOpenExplorerForFileConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonToOpenExplorerForFileConfiguration.TabIndex = 10;
            this.ButtonToOpenExplorerForFileConfiguration.TabStop = false;
            this.toolTip1.SetToolTip(this.ButtonToOpenExplorerForFileConfiguration, "Натисніть, щоб відкрити шлях до файлу конфігурації");
            this.ButtonToOpenExplorerForFileConfiguration.Click += new System.EventHandler(this.ButtonToOpenExplorerForFileConfiguration_Click);
            // 
            // AllRestoreToDefault
            // 
            this.AllRestoreToDefault.BackColor = System.Drawing.Color.DimGray;
            this.AllRestoreToDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllRestoreToDefault.Image = global::SwiftTune.Properties.Resources.Restore1;
            this.AllRestoreToDefault.Location = new System.Drawing.Point(762, 7);
            this.AllRestoreToDefault.Name = "AllRestoreToDefault";
            this.AllRestoreToDefault.Size = new System.Drawing.Size(26, 26);
            this.AllRestoreToDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AllRestoreToDefault.TabIndex = 9;
            this.AllRestoreToDefault.TabStop = false;
            this.toolTip1.SetToolTip(this.AllRestoreToDefault, "Натисніть, щоб запустити відновлення реєстру.\r\nВимагає UAC дозволу для коректної " +
        "роботи");
            this.AllRestoreToDefault.Click += new System.EventHandler(this.AllRestoreToDefault_Click);
            // 
            // UnderstoodButton
            // 
            this.UnderstoodButton.BackColor = System.Drawing.Color.DimGray;
            this.UnderstoodButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.UnderstoodButton.Image = global::SwiftTune.Properties.Resources.understood;
            this.UnderstoodButton.Location = new System.Drawing.Point(16, 39);
            this.UnderstoodButton.Name = "UnderstoodButton";
            this.UnderstoodButton.Size = new System.Drawing.Size(26, 26);
            this.UnderstoodButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnderstoodButton.TabIndex = 8;
            this.UnderstoodButton.TabStop = false;
            this.toolTip1.SetToolTip(this.UnderstoodButton, "Запуск оптимізації може вимагати неодноразового дозволу UAC (Запуск від імені адм" +
        "іністратора). \r\nВам необхідно дозволити UAC цій програмі для її коректної роботи" +
        ".");
            // 
            // EmptyPanelForRestorePoint
            // 
            this.EmptyPanelForRestorePoint.Controls.Add(this.ForCreateHiddenRestorePoint);
            this.EmptyPanelForRestorePoint.Controls.Add(this.CreateRestorePointForce);
            this.EmptyPanelForRestorePoint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EmptyPanelForRestorePoint.Location = new System.Drawing.Point(0, 300);
            this.EmptyPanelForRestorePoint.Name = "EmptyPanelForRestorePoint";
            this.EmptyPanelForRestorePoint.Padding = new System.Windows.Forms.Padding(225, 10, 225, 10);
            this.EmptyPanelForRestorePoint.Size = new System.Drawing.Size(800, 50);
            this.EmptyPanelForRestorePoint.TabIndex = 8;
            // 
            // ForCreateHiddenRestorePoint
            // 
            this.ForCreateHiddenRestorePoint.AutoCheck = false;
            this.ForCreateHiddenRestorePoint.AutoSize = true;
            this.ForCreateHiddenRestorePoint.BackColor = System.Drawing.Color.Transparent;
            this.ForCreateHiddenRestorePoint.Checked = true;
            this.ForCreateHiddenRestorePoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ForCreateHiddenRestorePoint.Cursor = System.Windows.Forms.Cursors.No;
            this.ForCreateHiddenRestorePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForCreateHiddenRestorePoint.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForCreateHiddenRestorePoint.ForeColor = System.Drawing.Color.DimGray;
            this.ForCreateHiddenRestorePoint.Location = new System.Drawing.Point(239, 10);
            this.ForCreateHiddenRestorePoint.Name = "ForCreateHiddenRestorePoint";
            this.ForCreateHiddenRestorePoint.Size = new System.Drawing.Size(331, 23);
            this.ForCreateHiddenRestorePoint.TabIndex = 0;
            this.ForCreateHiddenRestorePoint.Text = "Створення контрольної точки відновлення";
            this.toolTip1.SetToolTip(this.ForCreateHiddenRestorePoint, "Контрольна точка відновлення створюється автоматично згідно з умовами даної прогр" +
        "ами");
            this.ForCreateHiddenRestorePoint.UseVisualStyleBackColor = false;
            // 
            // CreateRestorePointForce
            // 
            this.CreateRestorePointForce.BackColor = System.Drawing.Color.DimGray;
            this.CreateRestorePointForce.Cursor = System.Windows.Forms.Cursors.No;
            this.CreateRestorePointForce.Image = global::SwiftTune.Properties.Resources.ForPlusIcon;
            this.CreateRestorePointForce.Location = new System.Drawing.Point(576, 10);
            this.CreateRestorePointForce.Name = "CreateRestorePointForce";
            this.CreateRestorePointForce.Size = new System.Drawing.Size(26, 26);
            this.CreateRestorePointForce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CreateRestorePointForce.TabIndex = 7;
            this.CreateRestorePointForce.TabStop = false;
            this.CreateRestorePointForce.Visible = false;
            this.CreateRestorePointForce.Click += new System.EventHandler(this.CreateRestorePointForce_Click);
            // 
            // OptimizationLevelsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmptyPanelForRestorePoint);
            this.Controls.Add(this.EmptyPanelForStartOptimizationButton);
            this.Controls.Add(this.PanelForTrackerInto);
            this.Controls.Add(this.EmptyPanelDownTracker);
            this.Controls.Add(this.PanelForStatus);
            this.Controls.Add(this.UpControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptimizationLevelsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptimizationLevelsScreen";
            this.UpControlPanel.ResumeLayout(false);
            this.DockNamePanel.ResumeLayout(false);
            this.PanelForStatus.ResumeLayout(false);
            this.PanelForStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackerInOptimizationStart)).EndInit();
            this.PanelForTrackerInto.ResumeLayout(false);
            this.PanelForTrackerInto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ForSettingsCustomLevelOptimizationIcon)).EndInit();
            this.EmptyPanelForStartOptimizationButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonToOpenExplorerForFileConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllRestoreToDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderstoodButton)).EndInit();
            this.EmptyPanelForRestorePoint.ResumeLayout(false);
            this.EmptyPanelForRestorePoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreateRestorePointForce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpControlPanel;
        private System.Windows.Forms.Button DockHideButton;
        private System.Windows.Forms.Button DockCloseButton;
        private System.Windows.Forms.Panel PanelForStatus;
        private System.Windows.Forms.Label StatusInTimeDecoration;
        private System.Windows.Forms.Label StatusInTimeText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel DockNamePanel;
        private System.Windows.Forms.Label DockNameText;
        private System.Windows.Forms.TrackBar TrackerInOptimizationStart;
        private System.Windows.Forms.Panel EmptyPanelDownTracker;
        private System.Windows.Forms.Panel PanelForTrackerInto;
        private System.Windows.Forms.Label CustomLevelOptimizationText;
        private System.Windows.Forms.Label LowerLevelOptimizationText;
        private System.Windows.Forms.Label HigherLevelOptimizationText;
        private System.Windows.Forms.Button StartOptimizationButton;
        private System.Windows.Forms.Panel EmptyPanelForStartOptimizationButton;
        private System.Windows.Forms.PictureBox ForSettingsCustomLevelOptimizationIcon;
        private System.Windows.Forms.Panel EmptyPanelForRestorePoint;
        private System.Windows.Forms.CheckBox ForCreateHiddenRestorePoint;
        private System.Windows.Forms.PictureBox CreateRestorePointForce;
        private System.Windows.Forms.PictureBox UnderstoodButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox AllRestoreToDefault;
        private System.Windows.Forms.PictureBox ButtonToOpenExplorerForFileConfiguration;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}