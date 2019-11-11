using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keyence.IV.Sdk;

namespace KeyenceSensor
{
    public partial class ListaProgramas : UserControl
    {
        private IVisionSensor sensor;

        public ListaProgramas()
        {
            InitializeComponent();
        }

        public event EventHandler ConnectionLost = delegate { };

        public void Initialize(IVisionSensor visionSensor)
        {
            CleanUp();
            sensor = visionSensor;
            sensor.ProgramSettingsUpdated += SensorProgramSettingsUpdated;
            // Display Initial Program List.
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void RefreshState()
        {
            SensorProgramSettingsUpdated(this, EventArgs.Empty);
        }

        public void CleanUp()
        {
            if (sensor != null)
            {
                sensor.ProgramSettingsUpdated -= SensorProgramSettingsUpdated;
            }
            listBoxPrograms.Items.Clear();

        }

        private void SensorProgramSettingsUpdated(object sender, EventArgs e)
        {
            listBoxPrograms.Items.Clear();
            foreach (ProgramHeader program in sensor.Programs)
            {
                listBoxPrograms.Items.Add(program.ToString());
            }
            UpdateLoginState();
        }

        private void ButtonSwitchProgramClick(object sender, EventArgs e)
        {
            if (listBoxPrograms.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                sensor.SwitchProgramTo(sensor.Programs[listBoxPrograms.SelectedIndex]);
            }
            catch (ConnectionLostException)
            {
                ConnectionLost(this, EventArgs.Empty);
            }
        }

        private void ButtonTriggerClick(object sender, EventArgs e)
        {
            try
            {
                sensor.Trigger();
            }
            catch (ConnectionLostException)
            {
                ConnectionLost(this, EventArgs.Empty);
            }

        }
        private void UpdateLoginState()
        {
            buttonSwitchProgram.Enabled = !sensor.ExternalProgramSwitch;
            buttonTrigger.Enabled = sensor.ActiveProgram.ExternalTrigger;

        }
    }
}
