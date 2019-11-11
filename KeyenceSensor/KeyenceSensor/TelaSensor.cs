using Keyence.IV.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyenceSensor
{
    public partial class TelaSensor : Form
    {
        public TelaSensor(VisionSensorStore store)
        {
            InitializeComponent();
            telaPrincipal.Initialize(store);
        }

        private void TelaSensorFormClosing(object sender, FormClosingEventArgs e)
        {
            telaPrincipal.CleanUp();

        }
    }
}
