using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumePlanning
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MotzkinButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) new MotzkinForm().Show();
        }

        private void GeneralButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) new GeneralizedSystemForm().Show();
        }
    }
}
