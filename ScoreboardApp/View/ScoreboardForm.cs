using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ScoreboardForm : Form
    {

        private Dictionary<string, int> players = new Dictionary<string, int>();

        public ScoreboardForm()
        {
            InitializeComponent();

            Size = new Size(350, 500);

            

        }

        private bool firstRow = true;
        private int numRows = 0;

        private void AddPlayerRow(string newPlayerName)
        {
            players[newPlayerName] = 0;
            Label label;
            
            if (firstRow)
            {
                label = new Label() { Location = new Point(115, 100), Text = newPlayerName + ": 0", };
                firstRow = false;
            }
            else
            {
                label = new Label() { Location = new Point(115, 25 * numRows + 100), Text = newPlayerName + ": 0", };
            }

            Controls.Add(label);

            numRows++;
        }


        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPlayerForm newPlayerForm = new NewPlayerForm();
            newPlayerForm.OnNewPlayer += AddPlayerRow;

            newPlayerForm.ShowDialog();
            //problem with a closed form raising events?
        }
    }
}
