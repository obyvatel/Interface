using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunGame
{
    public partial class FormGame : Form
    {
        Arena arena;
        public FormGame()
        {
            InitializeComponent();
            arena = new Arena(picture);
        }

        private void buttonAddGamer_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 100; j++)
            {
                Circle circle = Arena.NewCircle();
                arena.Show(circle);
            }
            arena.Refresh();
        }
    }
}
