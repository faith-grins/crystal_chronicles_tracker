using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystalChroniclesArtiTracker
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var artifacts = Ingest.GetArtifacts();
            var viewModel = new ArtiTrackerViewModel
            {
                Areas = Ingest.GetDungeons(artifacts),
                Artifacts = artifacts,
                Characters = Ingest.GetCharacters()
            };
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArtiTracker(viewModel));
        }
    }
}
