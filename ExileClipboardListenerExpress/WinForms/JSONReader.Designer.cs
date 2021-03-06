﻿namespace ExileClipboardListener.WinForms
{
    partial class JSONReader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JSONReader));
            this.Logon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StashTab = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.League = new System.Windows.Forms.ComboBox();
            this.ItemIcon = new System.Windows.Forms.PictureBox();
            this.ItemScript = new System.Windows.Forms.RichTextBox();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.GrabStash = new System.Windows.Forms.Button();
            this.StashAll = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharacterGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterGridNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterGridLeagueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStash = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrabInventory = new System.Windows.Forms.Button();
            this.ViewItem = new System.Windows.Forms.Button();
            this.StashLeague = new System.Windows.Forms.Button();
            this.StashAllInventories = new System.Windows.Forms.Button();
            this.QuickUpdate = new System.Windows.Forms.Button();
            this.QuickUpdateSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Logon
            // 
            this.Logon.Location = new System.Drawing.Point(12, 12);
            this.Logon.Name = "Logon";
            this.Logon.Size = new System.Drawing.Size(75, 23);
            this.Logon.TabIndex = 1;
            this.Logon.Text = "Logon";
            this.Logon.UseVisualStyleBackColor = true;
            this.Logon.Click += new System.EventHandler(this.Logon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stash Tab";
            // 
            // StashTab
            // 
            this.StashTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StashTab.Enabled = false;
            this.StashTab.FormattingEnabled = true;
            this.StashTab.Location = new System.Drawing.Point(75, 206);
            this.StashTab.Name = "StashTab";
            this.StashTab.Size = new System.Drawing.Size(505, 21);
            this.StashTab.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "League";
            // 
            // League
            // 
            this.League.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.League.Enabled = false;
            this.League.FormattingEnabled = true;
            this.League.Location = new System.Drawing.Point(160, 12);
            this.League.Name = "League";
            this.League.Size = new System.Drawing.Size(525, 21);
            this.League.Sorted = true;
            this.League.TabIndex = 7;
            this.League.SelectedIndexChanged += new System.EventHandler(this.League_SelectedIndexChanged);
            // 
            // ItemIcon
            // 
            this.ItemIcon.BackColor = System.Drawing.Color.DarkBlue;
            this.ItemIcon.Location = new System.Drawing.Point(691, 297);
            this.ItemIcon.Name = "ItemIcon";
            this.ItemIcon.Size = new System.Drawing.Size(32, 32);
            this.ItemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemIcon.TabIndex = 16;
            this.ItemIcon.TabStop = false;
            // 
            // ItemScript
            // 
            this.ItemScript.Location = new System.Drawing.Point(384, 255);
            this.ItemScript.Name = "ItemScript";
            this.ItemScript.Size = new System.Drawing.Size(301, 348);
            this.ItemScript.TabIndex = 15;
            this.ItemScript.Text = "";
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(12, 255);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(366, 316);
            this.ItemList.TabIndex = 13;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.ItemList_SelectedIndexChanged);
            // 
            // GrabStash
            // 
            this.GrabStash.Enabled = false;
            this.GrabStash.Location = new System.Drawing.Point(586, 206);
            this.GrabStash.Name = "GrabStash";
            this.GrabStash.Size = new System.Drawing.Size(99, 23);
            this.GrabStash.TabIndex = 12;
            this.GrabStash.Text = "Grab Stash";
            this.GrabStash.UseVisualStyleBackColor = true;
            this.GrabStash.Click += new System.EventHandler(this.GrabStash_Click);
            // 
            // StashAll
            // 
            this.StashAll.Enabled = false;
            this.StashAll.Location = new System.Drawing.Point(12, 580);
            this.StashAll.Name = "StashAll";
            this.StashAll.Size = new System.Drawing.Size(366, 23);
            this.StashAll.TabIndex = 17;
            this.StashAll.Text = "Add all these items to the Global Stash";
            this.StashAll.UseVisualStyleBackColor = true;
            this.StashAll.Click += new System.EventHandler(this.StashAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 606);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // CharacterGrid
            // 
            this.CharacterGrid.AllowUserToAddRows = false;
            this.CharacterGrid.AllowUserToDeleteRows = false;
            this.CharacterGrid.AllowUserToResizeRows = false;
            this.CharacterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CharacterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CharacterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.CharacterGridNameColumn,
            this.CharacterGridLeagueColumn});
            this.CharacterGrid.Location = new System.Drawing.Point(12, 41);
            this.CharacterGrid.Name = "CharacterGrid";
            this.CharacterGrid.ReadOnly = true;
            this.CharacterGrid.RowHeadersVisible = false;
            this.CharacterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CharacterGrid.Size = new System.Drawing.Size(673, 159);
            this.CharacterGrid.TabIndex = 19;
            this.CharacterGrid.SelectionChanged += new System.EventHandler(this.CharacterGrid_SelectionChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "N0";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Level";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Class";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 57;
            // 
            // CharacterGridNameColumn
            // 
            this.CharacterGridNameColumn.HeaderText = "Name";
            this.CharacterGridNameColumn.Name = "CharacterGridNameColumn";
            this.CharacterGridNameColumn.ReadOnly = true;
            this.CharacterGridNameColumn.Width = 60;
            // 
            // CharacterGridLeagueColumn
            // 
            this.CharacterGridLeagueColumn.HeaderText = "League";
            this.CharacterGridLeagueColumn.Name = "CharacterGridLeagueColumn";
            this.CharacterGridLeagueColumn.ReadOnly = true;
            this.CharacterGridLeagueColumn.Width = 68;
            // 
            // AddStash
            // 
            this.AddStash.Enabled = false;
            this.AddStash.Location = new System.Drawing.Point(691, 551);
            this.AddStash.Name = "AddStash";
            this.AddStash.Size = new System.Drawing.Size(117, 23);
            this.AddStash.TabIndex = 20;
            this.AddStash.Text = "Add to Stash";
            this.AddStash.UseVisualStyleBackColor = true;
            this.AddStash.Click += new System.EventHandler(this.AddStash_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Item List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Item Script";
            // 
            // GrabInventory
            // 
            this.GrabInventory.Enabled = false;
            this.GrabInventory.Location = new System.Drawing.Point(691, 148);
            this.GrabInventory.Name = "GrabInventory";
            this.GrabInventory.Size = new System.Drawing.Size(117, 23);
            this.GrabInventory.TabIndex = 24;
            this.GrabInventory.Text = "Grab Inventory";
            this.GrabInventory.UseVisualStyleBackColor = true;
            this.GrabInventory.Click += new System.EventHandler(this.GrabInventory_Click);
            // 
            // ViewItem
            // 
            this.ViewItem.Enabled = false;
            this.ViewItem.Location = new System.Drawing.Point(691, 522);
            this.ViewItem.Name = "ViewItem";
            this.ViewItem.Size = new System.Drawing.Size(117, 23);
            this.ViewItem.TabIndex = 25;
            this.ViewItem.Text = "View Item";
            this.ViewItem.UseVisualStyleBackColor = true;
            this.ViewItem.Click += new System.EventHandler(this.ViewItem_Click);
            // 
            // StashLeague
            // 
            this.StashLeague.Enabled = false;
            this.StashLeague.Location = new System.Drawing.Point(691, 425);
            this.StashLeague.Name = "StashLeague";
            this.StashLeague.Size = new System.Drawing.Size(117, 23);
            this.StashLeague.TabIndex = 26;
            this.StashLeague.Text = "Stash Entire League";
            this.StashLeague.UseVisualStyleBackColor = true;
            this.StashLeague.Click += new System.EventHandler(this.StashLeague_Click);
            // 
            // StashAllInventories
            // 
            this.StashAllInventories.Enabled = false;
            this.StashAllInventories.Location = new System.Drawing.Point(691, 177);
            this.StashAllInventories.Name = "StashAllInventories";
            this.StashAllInventories.Size = new System.Drawing.Size(117, 23);
            this.StashAllInventories.TabIndex = 27;
            this.StashAllInventories.Text = "Stash All Inventories";
            this.StashAllInventories.UseVisualStyleBackColor = true;
            this.StashAllInventories.Click += new System.EventHandler(this.StashAllInventories_Click);
            // 
            // QuickUpdate
            // 
            this.QuickUpdate.Enabled = false;
            this.QuickUpdate.Location = new System.Drawing.Point(691, 12);
            this.QuickUpdate.Name = "QuickUpdate";
            this.QuickUpdate.Size = new System.Drawing.Size(85, 23);
            this.QuickUpdate.TabIndex = 28;
            this.QuickUpdate.Text = "Quick Update";
            this.QuickUpdate.UseVisualStyleBackColor = true;
            this.QuickUpdate.Click += new System.EventHandler(this.QuickUpdate_Click);
            // 
            // QuickUpdateSettings
            // 
            this.QuickUpdateSettings.Location = new System.Drawing.Point(782, 12);
            this.QuickUpdateSettings.Name = "QuickUpdateSettings";
            this.QuickUpdateSettings.Size = new System.Drawing.Size(25, 23);
            this.QuickUpdateSettings.TabIndex = 29;
            this.QuickUpdateSettings.Text = "...";
            this.QuickUpdateSettings.UseVisualStyleBackColor = true;
            this.QuickUpdateSettings.Click += new System.EventHandler(this.QuickUpdateSettings_Click);
            // 
            // JSONReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 628);
            this.Controls.Add(this.QuickUpdateSettings);
            this.Controls.Add(this.QuickUpdate);
            this.Controls.Add(this.StashAllInventories);
            this.Controls.Add(this.StashLeague);
            this.Controls.Add(this.ViewItem);
            this.Controls.Add(this.GrabInventory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddStash);
            this.Controls.Add(this.CharacterGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StashAll);
            this.Controls.Add(this.ItemIcon);
            this.Controls.Add(this.ItemScript);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.GrabStash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StashTab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.League);
            this.Controls.Add(this.Logon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JSONReader";
            this.Text = "Stash Downloader";
            this.Load += new System.EventHandler(this.JSONReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StashTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox League;
        private System.Windows.Forms.PictureBox ItemIcon;
        private System.Windows.Forms.RichTextBox ItemScript;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Button GrabStash;
        private System.Windows.Forms.Button StashAll;
        private System.Windows.Forms.DataGridView CharacterGrid;
        private System.Windows.Forms.Button AddStash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GrabInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterGridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterGridLeagueColumn;
        private System.Windows.Forms.Button ViewItem;
        private System.Windows.Forms.Button StashLeague;
        private System.Windows.Forms.Button StashAllInventories;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button QuickUpdate;
        private System.Windows.Forms.Button QuickUpdateSettings;
    }
}