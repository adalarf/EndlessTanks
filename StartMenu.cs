using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndlessTanks
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            var frame = new EndlessTanks();
            frame.Show();
            Hide();
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}
