using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class NewPlayerForm : Form
    {
        public delegate void OnNewPlayerHandler(string newPlayerName);
        public event OnNewPlayerHandler OnNewPlayer;
        
        public NewPlayerForm()
        {
            InitializeComponent();


        }

        private void textPlayerName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPlayerName = textPlayerName.Text;
                OnNewPlayer(newPlayerName);
                Close();
            }
        }
    }
}
