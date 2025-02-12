﻿namespace DevTool.Forms
{
    partial class LogViewerWindow
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
            this.LogDataGrid = new System.Windows.Forms.DataGridView();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.LogLevel = new System.Windows.Forms.ComboBox();
            this.MessageTextbox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LogDataGrid
            // 
            this.LogDataGrid.AllowUserToAddRows = false;
            this.LogDataGrid.AllowUserToDeleteRows = false;
            this.LogDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LogDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.LogDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Level,
            this.Message});
            this.LogDataGrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogDataGrid.Location = new System.Drawing.Point(1, 29);
            this.LogDataGrid.MultiSelect = false;
            this.LogDataGrid.Name = "LogDataGrid";
            this.LogDataGrid.ReadOnly = true;
            this.LogDataGrid.RowHeadersVisible = false;
            this.LogDataGrid.RowHeadersWidth = 51;
            this.LogDataGrid.RowTemplate.Height = 29;
            this.LogDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogDataGrid.Size = new System.Drawing.Size(1209, 445);
            this.LogDataGrid.TabIndex = 0;
            this.LogDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LogDataGrid_CellClick);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Location = new System.Drawing.Point(152, 2);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.PlaceholderText = "Search for...";
            this.SearchTextbox.Size = new System.Drawing.Size(958, 27);
            this.SearchTextbox.TabIndex = 1;
            // 
            // LogLevel
            // 
            this.LogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LogLevel.FormattingEnabled = true;
            this.LogLevel.Items.AddRange(new object[] {
            "All",
            "Error",
            "Warning",
            "Information"});
            this.LogLevel.Location = new System.Drawing.Point(1, 1);
            this.LogLevel.Name = "LogLevel";
            this.LogLevel.Size = new System.Drawing.Size(151, 28);
            this.LogLevel.TabIndex = 2;
            this.LogLevel.SelectedIndexChanged += new System.EventHandler(this.LogLevel_SelectedIndexChanged);
            // 
            // MessageTextbox
            // 
            this.MessageTextbox.Location = new System.Drawing.Point(1, 480);
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.RightMargin = 600;
            this.MessageTextbox.Size = new System.Drawing.Size(1209, 320);
            this.MessageTextbox.TabIndex = 3;
            this.MessageTextbox.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1116, 1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(94, 29);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 6;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 115;
            // 
            // Message
            // 
            this.Message.HeaderText = "Message";
            this.Message.MinimumWidth = 6;
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 880;
            // 
            // LogViewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 802);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MessageTextbox);
            this.Controls.Add(this.LogLevel);
            this.Controls.Add(this.LogDataGrid);
            this.Name = "LogViewerWindow";
            this.Text = "LogViewerWindow";
            this.Load += new System.EventHandler(this.LogViewerWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView LogDataGrid;
        private TextBox SearchTextbox;
        private ComboBox LogLevel;
        private RichTextBox MessageTextbox;
        private Button SearchButton;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn Message;
    }
}