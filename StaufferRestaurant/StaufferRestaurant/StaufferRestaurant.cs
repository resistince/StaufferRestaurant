using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaufferRestaurant
{
    public partial class frmStaufferRestaurant : Form
    {
        public frmStaufferRestaurant()
        {
            InitializeComponent();
        }

        private void mnuWindowTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuWindowTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            try
            {
                ActiveMdiChild.Close();
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("No forms to close", "Close Error");
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
