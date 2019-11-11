using Keyence.IV.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyenceSensor
{
    public partial class IPComputador : Form
    {
        public IPComputador()
        {
            InitializeComponent();
            UpdateControls();
        }

        private void UpdateControls()
        {
            comboBoxEnableIPAddress.Items.Clear();
            foreach (IPAddress item in AvailableNicExplorer.GetClients())
            {
                comboBoxEnableIPAddress.Items.Add(item);
                comboBoxEnableIPAddress.SelectedIndex = 0;
            }
            labelClientIPAddress.Text = VisionSensorStore.StartPoint.ToString();
        }

        private void ButtonChangeClick(object sender, EventArgs e)
        {
            if (comboBoxEnableIPAddress.SelectedIndex == -1)
            {
                return;
            }
            VisionSensorStore.StartPoint = AvailableNicExplorer.GetClients()[comboBoxEnableIPAddress.SelectedIndex];
            UpdateControls();
        }
    }
}
