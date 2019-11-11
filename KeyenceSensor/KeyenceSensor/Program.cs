using Keyence.IV.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyenceSensor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (VisionSensorStore store = GetVisionSensorStore())
            {
                Application.Run(new TelaSensor(store));
            }
        }

        private static VisionSensorStore GetVisionSensorStore()
        {
            VisionSensorStore store = null;
            try
            {
                store = new VisionSensorStore();
            }
            catch (ApplicationException e)
            {
                // You may have tried multiple activations.
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            ChooseNicInCaseMultiplyClientNicsAreAvailable();
            return store;
        }

        private static void ChooseNicInCaseMultiplyClientNicsAreAvailable()
        {
            // Select client(PC-side) Nic. You can change this settings later also.
            if (1 >= AvailableNicExplorer.GetClients().Count)
            {
                return;
            }
            using (var dialog = new IPComputador())
            {
                dialog.ShowDialog();
            }
        }
    }
}
