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
    public partial class TelaPrincipal : UserControl
    {
        private IVisionSensor sensor;
        private VisionSensorStore store;
     

        public TelaPrincipal()
        {
            InitializeComponent();

        }
        public void Initialize(VisionSensorStore visionSensorStore)
        {
            store = visionSensorStore;
            UpdateControls();
            CleanUp();
            
            // Display Initial Program List.
            
            // Notify ActiveToolChanged event to imageDisplayControl to draw active tool window.
        }
        //Metodo limpar
        public void CleanUp()
        {
            if (sensor == null)
            {
                
                return;
            }
            
            sensor.ResultUpdated -= SensorResultUpdated;
            Disconnect(this, EventArgs.Empty);
        }


        //Habilita e Desabilita Botões e TextBox
        private void UpdateControls()
        {
            bool sensorEnable = sensor != null;
            iPePortasSensor.Enabled = !sensorEnable;
            btnConectar.Enabled = !sensorEnable;
            btnDesconectar.Enabled = sensorEnable;
            timer.Enabled = sensorEnable;
        }

        //Botão Conectar Camera
        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (!iPePortasSensor.EnableAddress)
            {
                return;
            }
            UpdateVisionSensorObject();
            SetupVisionSensorViewer();
            UpdateControls();
        }

        //Conecta IP e Porta
        private void UpdateVisionSensorObject()
        {
            if (UpdateVisionSensorIVHSeriesObject()) return;
            try
            {
                sensor = store.Create(iPePortasSensor.IpAddress, iPePortasSensor.PortNo);

            }
            catch (InvalidOperationException e)
            {
                // You may have tried to create same VisionSensor object before disposing it.
                MessageBox.Show(e.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ConnectionLostException e)
            {
                MessageBox.Show(e.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Conecta IP e Porta
        private bool UpdateVisionSensorIVHSeriesObject()
        {
            try
            {
                sensor = store.CreateIVHSeries(iPePortasSensor.IpAddress, iPePortasSensor.PortNo);

            }
            catch (InvalidOperationException)
            {
                return false;
            }
            catch (ConnectionLostException)
            {
                return false;
            }
            return true;
        }
        //Inicia Programa
        private void SetupVisionSensorViewer()
        {
            if (sensor == null)
            {
                return;
            }
            imagemSensor.Initialize(sensor);
            listaProgramas.Initialize(sensor);
            sensor.ResultUpdated += SensorResultUpdated;
            listaProgramas.ConnectionLost += Disconnect;
        }
        //zera programa
        private void TearDownVisionSensorViewer()
        {
            listaProgramas.ConnectionLost -= Disconnect;
            imagemSensor.CleanUp();
            listaProgramas.CleanUp();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (sensor == null)
            {
                return;
            }
            try
            {
                sensor.TickTack();
            }
            catch (ConnectionLostException)
            {
                Disconnect(sender, e);
            }
        }

        private void CheckBoxEventCheckedChanged(object sender, EventArgs e)
        {
            if (sensor == null)
            {
                return;
            }

            if (sensor.EventEnable)
            {
                imagemSensor.RefreshState();

                listaProgramas.RefreshState();

            }

        }
        //Disconectar Câmera
        private void Disconnect(object sender, EventArgs e)
        {
            TearDownVisionSensorViewer();
            sensor.Dispose();
            sensor = null;
            UpdateControls();
        }

        //Mostrar resultado OK e NG
        private void SensorResultUpdated(object sender, ToolResultUpdatedEventArgs e)
        {
            _labelResult.Text = e.TotalStatusResult ? "OK" : "NG";
            _labelResult.ForeColor = e.TotalStatusResult ? Color.Blue : Color.Red;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
