using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalChroniclesArtiTracker
{
    public partial class ArtiTracker : Form
    {
        private ArtiTrackerViewModel ViewModel { get; set; }

        public ArtiTracker(ArtiTrackerViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }

        private void ArtiTracker_Load(object sender, EventArgs e)
        {
            DungeonBox.DataSource = ViewModel.Areas;
        }

        private void DungeonBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
