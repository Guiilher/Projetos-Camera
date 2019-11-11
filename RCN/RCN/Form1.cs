using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FtdAdapter;
using Modbus.Data;
using Modbus.Utility;
using System.Threading;
using System.Net.Sockets;


namespace RCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        string responseData;   
            
        private void btnPosicao1_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort port = new SerialPort("COM4");
                // configure serial port
                port.BaudRate = 19200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Close();
                port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);
                byte slaveId = 1;
                master.WriteSingleCoil(slaveId, 2068, true);
                port.Close();
            }
            catch
            {
                responseData = "";
            }

        }

        private void btnPosicao2_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort port = new SerialPort("COM4");
                // configure serial port
                port.BaudRate = 19200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Close();
                port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);
                byte slaveId = 1;
                master.WriteSingleCoil(slaveId, 2068, true);
                port.Close();
            }
            catch
            {
                responseData = "";
            }

        }

        private void btnPosicao3_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort port = new SerialPort("COM4");
                // configure serial port
                port.BaudRate = 19200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Close();
                port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);
                byte slaveId = 1;
                master.WriteSingleCoil(slaveId, 2068, true);
                port.Close();    
            }
            catch
            {
                responseData = "";
            }
        }

        private void btnPosicao4_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort port = new SerialPort("COM4");
                // configure serial port
                port.BaudRate = 19200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Close();
                port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);
                byte slaveId = 1;
                master.WriteSingleCoil(slaveId, 2068, true);
                port.Close();
            }
            catch 
            {
                responseData = "";
            }
        }
    }
    }
