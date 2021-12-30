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

            Label label = new Label() { Text = "Players: Score", };
            table.Controls.Add(label, 0, 0);

        }



        private void AddPlayerRow(string newPlayerName)
        {
            players[newPlayerName] = 0;
            RowStyle newRow = new RowStyle(SizeType.Percent);
            newRow.SizeType = SizeType.Percent;
            

            table.RowStyles.Add(newRow);
            Label newPlayerInfo = new Label() { Text = newPlayerName + ": 0"};

            table.Controls.Add(newPlayerInfo);

            ResizeRows();

        }

        private void ResizeRows()
        {
            foreach (RowStyle row in table.RowStyles)
            {
                row.Height = 100f / table.RowCount;
            }
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
