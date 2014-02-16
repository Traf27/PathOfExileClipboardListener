﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ExileClipboardListener.JSON;
using ExileClipboardListener.Classes;
using System.Collections.Generic;

namespace ExileClipboardListener.WinForms
{
    public partial class JSONReader : Form
    {
        private DataContracts.JSONStash _stash;
        private DataContracts.JSONInventory _inventory;
        private List<JSON.Character> _characters;
        private int _leagueId;
        private string _stashType;

        public JSONReader()
        {
            InitializeComponent();
        }

        private void Logon_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username == Properties.Settings.Default.PropertyValues["Username"].Property.DefaultValue.ToString())
            {
                MessageBox.Show("You need to enter your username/ password in the Settings before you can use this feature!");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            if (POEWeb.Authenticate())
            {
                Logon.Enabled = false;
                ItemList.Items.Clear();
                _characters = POEWeb.GetCharacters();
                var checkList = new List<string>();
                foreach (var c in _characters)
                {
                    if (!checkList.Contains(c.League))
                    {
                        checkList.Add(c.League);
                        League.Items.Add(c.League);
                    }
                }

                //If we have leagues let the stash grabbing commence
                if (League.Items.Count > 0)
                {
                    League.Enabled = true;
                    StashLeague.Enabled = true;
                    League.SelectedIndex = 0;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void GrabStash_Click(object sender, EventArgs e)
        {
            GetCurrentLeague();
            ItemList.Items.Clear();

            //Determine the tab number
            string tabNumber = StashTab.Text.Split('[')[1].Split(']')[0];
            while (tabNumber.Length > 1 && tabNumber.Substring(0, 1) == "0")
                tabNumber = tabNumber.Substring(1, tabNumber.Length - 1);
            Cursor.Current = Cursors.WaitCursor;
            _stash = POEWeb.GetStash(League.Text, tabNumber);
            Cursor.Current = Cursors.Default;
            foreach (var i in _stash.Items)
                ItemList.Items.Add(i.TypeLine);
            StashAll.Enabled = true;
            AddStash.Enabled = true;
            ViewItem.Enabled = true;
            _stashType = "Stash";
        }

        private void JSONReader_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the text description
            int index = ItemList.SelectedIndex;
            DataContracts.JSONItem i = _stashType == "Stash" ? _stash.Items[index] : _inventory.Items[index];
            string item = Parser.ParseItem(i);
            ItemScript.Text = item;

            //Get the icon image
            var size = new Size(32 * i.Width, 32 * i.Height);
            ItemIcon.Size = size;
            ItemIcon.Image = Parser.GetImage(i.TypeLine, i.Icon, i.Width, i.Height);
        }

        private void StashAll_Click(object sender, EventArgs e)
        {
            //Parse each item in the list, add them one at a time to the stash for the current league
            for (int i = 0; i < ItemList.Items.Count; i++)
            {
                toolStripStatusLabel1.Text = "Parsing " + (_stashType == "Stash" ? _stash.Items[i].TypeLine : _inventory.Items[i].TypeLine) + "... " + ((i * 100) / ItemList.Items.Count) + "%";
                Application.DoEvents();
                string itemText = Parser.ParseItem(_stashType == "Stash" ? _stash.Items[i] : _inventory.Items[i]);
                if (ParseItem.ParseStash(itemText))
                    GlobalMethods.SaveStash(_leagueId);
            }
            toolStripStatusLabel1.Text = "Ready";
        }

        private void AddStash_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedIndex == -1)
                return;
            string itemText = Parser.ParseItem(_stashType == "Stash" ? _stash.Items[ItemList.SelectedIndex] : _inventory.Items[ItemList.SelectedIndex]);
            if (ParseItem.ParseStash(itemText))
            {
                GlobalMethods.SaveStash(_leagueId);
                MessageBox.Show("Stashed!");
            }
            else
                MessageBox.Show("Failed!");
        }

        private void GrabStashTabs()
        {
            //Grab the first stash tab to see how many there are and what they are called
            StashTab.Items.Clear();
            Cursor.Current = Cursors.WaitCursor;
            _stash = POEWeb.GetStash(League.Text, "1");
            Cursor.Current = Cursors.Default;
            for (int tab = 0; tab < _stash.NumTabs; tab++)
                StashTab.Items.Add("Tab [" + tab.ToString("000") + "] " + _stash.Tabs[tab].n);
            if (StashTab.Items.Count > 0)
                StashTab.SelectedIndex = 0;
            StashTab.Enabled = true;
            StashTab.SelectedIndex = 0;
            GrabStash.Enabled = true;
        }

        private void GetCurrentLeague()
        {
            _leagueId = 0;
            while (_leagueId == 0)
            {
                _leagueId = GlobalMethods.GetScalarInt("SELECT LeagueId FROM League WHERE LeagueName = '" + League.Text + "';");
                if (_leagueId == 0)
                {
                    if (MessageBox.Show("The league: [" + League.Text + "] doesn't exist, do you want to create it?", "Confirm League Create", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    {
                        GrabStash.Enabled = false;
                        return;
                    }
                    GlobalMethods.RunQuery("INSERT INTO League(LeagueName, LeagueParentId) VALUES('" + League.Text + "',NULL);");
                }
            }
        }

        private void GrabInventory_Click(object sender, EventArgs e)
        {
            GetCurrentLeague();
            ItemList.Items.Clear();
            if (CharacterGrid.CurrentRow == null)
                return;
            string character = CharacterGrid.CurrentRow.Cells[CharacterGridNameColumn.Index].Value.ToString();
            Cursor.Current = Cursors.WaitCursor;
            _inventory = POEWeb.GetInventory(character);
            Cursor.Current = Cursors.Default;
            foreach (var i in _inventory.Items)
                ItemList.Items.Add(i.TypeLine);
            StashAll.Enabled = true;
            AddStash.Enabled = true;
            ViewItem.Enabled = true;
            _stashType = "Inventory";
        }

        private void CharacterGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (CharacterGrid.CurrentRow == null)
                return;
            //League.Text = CharacterGrid.CurrentRow.Cells[CharacterGridLeagueColumn.Index].Value.ToString();
        }

        private void ViewItem_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedIndex == -1)
                return;
            string itemText = Parser.ParseItem(_stashType == "Stash" ? _stash.Items[ItemList.SelectedIndex] : _inventory.Items[ItemList.SelectedIndex]);
            if (ParseItem.ParseStash(itemText))
                new ItemInformation { AllowStash = true }.ShowDialog();
        }

        private void League_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCurrentLeague();
            CharacterGrid.Rows.Clear();
            foreach (var c in _characters)
            {
                if (c.League == League.Text)
                {
                    var row = new object[4];
                    row[0] = c.Level;
                    row[1] = c.Class;
                    row[2] = c.Name;
                    row[3] = c.League;
                    CharacterGrid.Rows.Add(row);
                }
            }
            if (CharacterGrid.Rows.Count > 0)
            {
                CharacterGrid_SelectionChanged(null, null);
                GrabInventory.Enabled = true;
            }
            GrabStashTabs();
            ItemList.Items.Clear();
            ItemScript.Text = "";
        }

        private void StashLeague_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GetCurrentLeague();

            //Stash all character inventories
            for (int row = 0; row < CharacterGrid.Rows.Count; row++)
            {
                string character = CharacterGrid.Rows[row].Cells[CharacterGridNameColumn.Index].Value.ToString();
                _inventory = POEWeb.GetInventory(character);
                foreach (var i in _inventory.Items)
                {
                    toolStripStatusLabel1.Text = "Parsing " + i.TypeLine + "... ";
                    Application.DoEvents();
                    string itemText = Parser.ParseItem(i);
                    if (ParseItem.ParseStash(itemText))
                        GlobalMethods.SaveStash(_leagueId);
                }
            }

            //Stash all stash tabs
            for (int tab = 0; tab < _stash.NumTabs; tab++)
            {
                string tabNumber = tab.ToString();
                _stash = POEWeb.GetStash(League.Text, tabNumber);
                foreach (var i in _stash.Items)
                {
                    toolStripStatusLabel1.Text = "Parsing " + i.TypeLine + "... ";
                    Application.DoEvents();
                    string itemText = Parser.ParseItem(i);
                    if (ParseItem.ParseStash(itemText))
                        GlobalMethods.SaveStash(_leagueId);
                }
            }
            toolStripStatusLabel1.Text = "Ready";
            Cursor.Current = Cursors.Default;
        }
    }
}