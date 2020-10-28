﻿using System;
using System.Windows.Forms;
using pkNX.Game;
using pkNX.Structures;

namespace pkNX.WinForms
{
    public sealed partial class GenericEditor<T> : Form where T : class
    {
        public GenericEditor(DataCache<T> cache, string[] names, string title, Action randomize = null)
        {
            InitializeComponent();
            Cache = cache;
            Text = title;
            Names = names;

            CB_EntryName.Items.AddRange(names);
            CB_EntryName.SelectedIndex = 0;

            if (randomize == null)
            {
                B_Rand.Visible = false;
                return;
            }
            B_Rand.Click += (_, __) =>
            {
                randomize();
                LoadIndex(0);
                System.Media.SystemSounds.Asterisk.Play();
            };
        }

        private readonly string[] Names;
        private readonly DataCache<T> Cache;
        public bool Modified { get; set; }

        private void CB_EntryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = CB_EntryName.SelectedIndex;
            LoadIndex(index);
        }

        private void LoadIndex(int index) => Grid.SelectedObject = Cache[index];

        private void B_Save_Click(object sender, EventArgs e)
        {
            LoadIndex(0);
            Modified = true;
            Close();
        }

        private void B_Dump_Click(object sender, EventArgs e)
        {
            var arr = Cache.LoadAll();
            var result = TableUtil.GetNamedTypeTable(arr, Names, Text.Split(' ')[0]);
            Clipboard.SetText(result);
            System.Media.SystemSounds.Asterisk.Play();
        }
    }
}
