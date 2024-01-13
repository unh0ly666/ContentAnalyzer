﻿namespace ContentAnalyzer.Frontend.Desktop.Forms
{
    partial class ConfigureServiceForm
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
            groupBox5 = new GroupBox();
            LoadCollectionServiceConfiguration = new Button();
            SaveCollectionServiceConfiguration = new Button();
            PostQueueSize = new TextBox();
            label31 = new Label();
            ScanCommentsDelay = new TextBox();
            label30 = new Label();
            label29 = new Label();
            ScanPostDelay = new TextBox();
            groupBox7 = new GroupBox();
            SaveAppConfigButton = new Button();
            TokenTextBox = new TextBox();
            label3 = new Label();
            LoginTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CurrentBackendHost = new ComboBox();
            groupBox9 = new GroupBox();
            BackendHosts = new ListBox();
            AddBackendHost = new Button();
            DeleteBackendHost = new Button();
            NewBackendHost = new TextBox();
            label8 = new Label();
            ObserveDelay = new TextBox();
            SaveAnalysisServiceConfiguration = new Button();
            LoadAnalysisServiceConfiguration = new Button();
            groupBox6 = new GroupBox();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(LoadCollectionServiceConfiguration);
            groupBox5.Controls.Add(SaveCollectionServiceConfiguration);
            groupBox5.Controls.Add(PostQueueSize);
            groupBox5.Controls.Add(label31);
            groupBox5.Controls.Add(ScanCommentsDelay);
            groupBox5.Controls.Add(label30);
            groupBox5.Controls.Add(label29);
            groupBox5.Controls.Add(ScanPostDelay);
            groupBox5.ForeColor = SystemColors.MenuHighlight;
            groupBox5.Location = new Point(653, 149);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(575, 235);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Конфигурация сервиса сбора данных";
            // 
            // LoadCollectionServiceConfiguration
            // 
            LoadCollectionServiceConfiguration.FlatStyle = FlatStyle.Flat;
            LoadCollectionServiceConfiguration.Location = new Point(313, 164);
            LoadCollectionServiceConfiguration.Name = "LoadCollectionServiceConfiguration";
            LoadCollectionServiceConfiguration.Size = new Size(140, 41);
            LoadCollectionServiceConfiguration.TabIndex = 22;
            LoadCollectionServiceConfiguration.Text = "Загрузить";
            LoadCollectionServiceConfiguration.UseVisualStyleBackColor = true;
            LoadCollectionServiceConfiguration.Click += LoadCollectionServiceConfiguration_Click;
            // 
            // SaveCollectionServiceConfiguration
            // 
            SaveCollectionServiceConfiguration.FlatStyle = FlatStyle.Flat;
            SaveCollectionServiceConfiguration.Location = new Point(116, 164);
            SaveCollectionServiceConfiguration.Name = "SaveCollectionServiceConfiguration";
            SaveCollectionServiceConfiguration.Size = new Size(140, 41);
            SaveCollectionServiceConfiguration.TabIndex = 21;
            SaveCollectionServiceConfiguration.Text = "Сохранить";
            SaveCollectionServiceConfiguration.UseVisualStyleBackColor = true;
            SaveCollectionServiceConfiguration.Click += SaveCollectionServiceConfiguration_Click;
            // 
            // PostQueueSize
            // 
            PostQueueSize.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PostQueueSize.Location = new Point(360, 113);
            PostQueueSize.Margin = new Padding(5);
            PostQueueSize.Name = "PostQueueSize";
            PostQueueSize.Size = new Size(140, 26);
            PostQueueSize.TabIndex = 5;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(63, 114);
            label31.Margin = new Padding(5);
            label31.Name = "label31";
            label31.Size = new Size(272, 19);
            label31.TabIndex = 4;
            label31.Text = "Количество последних записей:";
            // 
            // ScanCommentsDelay
            // 
            ScanCommentsDelay.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ScanCommentsDelay.Location = new Point(360, 77);
            ScanCommentsDelay.Margin = new Padding(5);
            ScanCommentsDelay.Name = "ScanCommentsDelay";
            ScanCommentsDelay.Size = new Size(140, 26);
            ScanCommentsDelay.TabIndex = 3;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(63, 80);
            label30.Margin = new Padding(5);
            label30.Name = "label30";
            label30.Size = new Size(287, 19);
            label30.TabIndex = 2;
            label30.Text = "Период проверки комментариев:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(63, 44);
            label29.Margin = new Padding(5);
            label29.Name = "label29";
            label29.Size = new Size(231, 19);
            label29.TabIndex = 1;
            label29.Text = "Период проверки записей:";
            // 
            // ScanPostDelay
            // 
            ScanPostDelay.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ScanPostDelay.Location = new Point(360, 43);
            ScanPostDelay.Margin = new Padding(5);
            ScanPostDelay.Name = "ScanPostDelay";
            ScanPostDelay.Size = new Size(140, 26);
            ScanPostDelay.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(SaveAppConfigButton);
            groupBox7.Controls.Add(TokenTextBox);
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(LoginTextBox);
            groupBox7.Controls.Add(label2);
            groupBox7.Controls.Add(label1);
            groupBox7.Controls.Add(CurrentBackendHost);
            groupBox7.Controls.Add(groupBox9);
            groupBox7.ForeColor = SystemColors.MenuHighlight;
            groupBox7.Location = new Point(30, 149);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(4, 3, 4, 3);
            groupBox7.Size = new Size(575, 506);
            groupBox7.TabIndex = 20;
            groupBox7.TabStop = false;
            groupBox7.Text = "Конфигураци хоста";
            // 
            // SaveAppConfigButton
            // 
            SaveAppConfigButton.FlatStyle = FlatStyle.Flat;
            SaveAppConfigButton.Location = new Point(210, 433);
            SaveAppConfigButton.Name = "SaveAppConfigButton";
            SaveAppConfigButton.Size = new Size(140, 41);
            SaveAppConfigButton.TabIndex = 23;
            SaveAppConfigButton.Text = "Сохранить";
            SaveAppConfigButton.UseVisualStyleBackColor = true;
            SaveAppConfigButton.Click += SaveAppConfigButton_Click;
            // 
            // TokenTextBox
            // 
            TokenTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TokenTextBox.Location = new Point(264, 371);
            TokenTextBox.Margin = new Padding(5);
            TokenTextBox.Name = "TokenTextBox";
            TokenTextBox.PasswordChar = '*';
            TokenTextBox.Size = new Size(197, 26);
            TokenTextBox.TabIndex = 28;
            TokenTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 374);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 27;
            label3.Text = "Пароль:";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(264, 335);
            LoginTextBox.Margin = new Padding(5);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(197, 26);
            LoginTextBox.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 338);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(158, 19);
            label2.TabIndex = 25;
            label2.Text = "Имя пользователя:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 300);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(125, 19);
            label1.TabIndex = 23;
            label1.Text = "Текущий хост:";
            // 
            // CurrentBackendHost
            // 
            CurrentBackendHost.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentBackendHost.FormattingEnabled = true;
            CurrentBackendHost.Location = new Point(264, 297);
            CurrentBackendHost.Name = "CurrentBackendHost";
            CurrentBackendHost.Size = new Size(197, 28);
            CurrentBackendHost.TabIndex = 21;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(BackendHosts);
            groupBox9.Controls.Add(AddBackendHost);
            groupBox9.Controls.Add(DeleteBackendHost);
            groupBox9.Controls.Add(NewBackendHost);
            groupBox9.ForeColor = SystemColors.MenuHighlight;
            groupBox9.Location = new Point(80, 43);
            groupBox9.Margin = new Padding(4);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(4);
            groupBox9.Size = new Size(402, 224);
            groupBox9.TabIndex = 20;
            groupBox9.TabStop = false;
            groupBox9.Text = "Сохранённые хосты";
            // 
            // BackendHosts
            // 
            BackendHosts.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BackendHosts.FormattingEnabled = true;
            BackendHosts.ItemHeight = 20;
            BackendHosts.Location = new Point(102, 54);
            BackendHosts.Margin = new Padding(4, 3, 4, 3);
            BackendHosts.Name = "BackendHosts";
            BackendHosts.Size = new Size(196, 64);
            BackendHosts.TabIndex = 0;
            // 
            // AddBackendHost
            // 
            AddBackendHost.FlatStyle = FlatStyle.Flat;
            AddBackendHost.Location = new Point(102, 151);
            AddBackendHost.Margin = new Padding(4, 3, 4, 3);
            AddBackendHost.Name = "AddBackendHost";
            AddBackendHost.Size = new Size(100, 32);
            AddBackendHost.TabIndex = 4;
            AddBackendHost.Text = "Добавить";
            AddBackendHost.UseVisualStyleBackColor = true;
            AddBackendHost.Click += AddBackendHost_Click;
            // 
            // DeleteBackendHost
            // 
            DeleteBackendHost.FlatStyle = FlatStyle.Flat;
            DeleteBackendHost.Location = new Point(203, 151);
            DeleteBackendHost.Margin = new Padding(4, 3, 4, 3);
            DeleteBackendHost.Name = "DeleteBackendHost";
            DeleteBackendHost.Size = new Size(95, 32);
            DeleteBackendHost.TabIndex = 5;
            DeleteBackendHost.Text = "Удалить";
            DeleteBackendHost.UseVisualStyleBackColor = true;
            DeleteBackendHost.Click += DeleteBackendHost_Click;
            // 
            // NewBackendHost
            // 
            NewBackendHost.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NewBackendHost.Location = new Point(102, 119);
            NewBackendHost.Margin = new Padding(4, 3, 4, 3);
            NewBackendHost.Name = "NewBackendHost";
            NewBackendHost.PlaceholderText = "Новый хост...";
            NewBackendHost.Size = new Size(196, 26);
            NewBackendHost.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(88, 88);
            label8.Margin = new Padding(5);
            label8.Name = "label8";
            label8.Size = new Size(215, 19);
            label8.TabIndex = 8;
            label8.Text = "Период загрузки данных:";
            // 
            // ObserveDelay
            // 
            ObserveDelay.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ObserveDelay.Location = new Point(313, 85);
            ObserveDelay.Margin = new Padding(5);
            ObserveDelay.Name = "ObserveDelay";
            ObserveDelay.Size = new Size(140, 26);
            ObserveDelay.TabIndex = 9;
            // 
            // SaveAnalysisServiceConfiguration
            // 
            SaveAnalysisServiceConfiguration.FlatStyle = FlatStyle.Flat;
            SaveAnalysisServiceConfiguration.Location = new Point(116, 180);
            SaveAnalysisServiceConfiguration.Name = "SaveAnalysisServiceConfiguration";
            SaveAnalysisServiceConfiguration.Size = new Size(140, 41);
            SaveAnalysisServiceConfiguration.TabIndex = 23;
            SaveAnalysisServiceConfiguration.Text = "Сохранить";
            SaveAnalysisServiceConfiguration.UseVisualStyleBackColor = true;
            SaveAnalysisServiceConfiguration.Click += SaveAnalysisServiceConfiguration_Click;
            // 
            // LoadAnalysisServiceConfiguration
            // 
            LoadAnalysisServiceConfiguration.FlatStyle = FlatStyle.Flat;
            LoadAnalysisServiceConfiguration.Location = new Point(313, 180);
            LoadAnalysisServiceConfiguration.Name = "LoadAnalysisServiceConfiguration";
            LoadAnalysisServiceConfiguration.Size = new Size(140, 41);
            LoadAnalysisServiceConfiguration.TabIndex = 24;
            LoadAnalysisServiceConfiguration.Text = "Загрузить";
            LoadAnalysisServiceConfiguration.UseVisualStyleBackColor = true;
            LoadAnalysisServiceConfiguration.Click += LoadAnalysisServiceConfiguration_Click;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox6.Controls.Add(LoadAnalysisServiceConfiguration);
            groupBox6.Controls.Add(SaveAnalysisServiceConfiguration);
            groupBox6.Controls.Add(ObserveDelay);
            groupBox6.Controls.Add(label8);
            groupBox6.ForeColor = SystemColors.MenuHighlight;
            groupBox6.Location = new Point(653, 402);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(575, 253);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Конфигурация сервиса анализа данных";
            // 
            // ConfigureServiceForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1260, 812);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox7);
            Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConfigureServiceForm";
            Load += ConfigureAnalysisService_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TextBox DataAnalysisServiceHost;
        public TextBox DataCollectionServiceHost;
        private GroupBox groupBox5;
        private TextBox PostQueueSize;
        private Label label31;
        private TextBox ScanCommentsDelay;
        private Label label30;
        private Label label29;
        private TextBox ScanPostDelay;
        private GroupBox groupBox7;
        private GroupBox groupBox13;
        private GroupBox groupBox9;
        public ListBox BackendHosts;
        private Button AddBackendHost;
        private Button DeleteBackendHost;
        private TextBox NewBackendHost;
        private GroupBox groupBox10;
        private GroupBox groupBox14;
        private GroupBox groupBox12;
        private Button LoadCollectionServiceConfiguration;
        private Button SaveCollectionServiceConfiguration;
        private Label label1;
        private ComboBox CurrentBackendHost;
        private Label label8;
        private TextBox ObserveDelay;
        private Button SaveAnalysisServiceConfiguration;
        private Button LoadAnalysisServiceConfiguration;
        private GroupBox groupBox6;
        private TextBox TokenTextBox;
        private Label label3;
        private TextBox LoginTextBox;
        private Label label2;
        private Button SaveAppConfigButton;
    }
}