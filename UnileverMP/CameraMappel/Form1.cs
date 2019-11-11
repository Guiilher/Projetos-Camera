using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Security;
using UnileverMP;
//using FtdAdapter;
using Modbus;
using System.IO.Ports;
using FtdAdapter;
using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;

namespace UnilevarMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnConectar.Enabled = false;
            btnWeQube.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            btnSKU2.Enabled = false;
            btnSKU.Enabled = false;
            btnRejeito.BackColor = Color.Red;
            ConfigurarIP();
            abrir();
            txtPorcentagemRuins.Text = "0";
            txtPorcentagemBons.Text = "0";
            txtPorcentagemRuins1.Text = "0";
            txtPorcentagemBons1.Text = "0";

        }

        /// <summary>
        /// Variáveis globais para acesso em todo o software
        /// </summary>
        public static class Globals
        {
            public static String ConfigIp = "192.168.100.98";
            public static String ConfigIp2 = "192.168.100.99";
            public static TcpClient Client;
            public static TcpClient Client1;// Modifiable
            public static NetworkStream stream;
            public static NetworkStream stream1;
            public static IAsyncResult result;
            public static IAsyncResult result1;
            public static int intPorta = 32001;
            public static int intPorta2 = 32001;

            //TcpClient Client = new TcpClient(Globals.ConfigIp, 32001); //"192.168.100.98"
        }

        public static String ConfigIp;
        public static int intPorta;
        public static String ConfigIp2;
        public static int intPorta2;
        string responseData;
        string responseData1;
        string responseData2;
        bool reset1;
        bool reset2;
        float bom_esq;
        float ruim_esq;
        float bom_dir;
        float ruim_dir;
        float total_esq;
        float total_dir;
        float porcentagem_dos_ruins_esq;
        float porcentagem_dos_ruins_dir;

        private void timer1_Tick(object sender, EventArgs e)
        {


            try

            {
                //CARREGA camera esquerda

                //NetworkStream stream = Globals.Client.GetStream();
                byte[] data = new Byte[999999 * 1024];
                string cap = "<LIMA CMD=\"Project_GetCameraImage\" DIR=\"Request\"CONTENT_TYPE = \"jpg/base64\" />";
                byte[] capbytes = Encoding.ASCII.GetBytes(cap);
                Globals.stream.Write(capbytes, 0, capbytes.Length);
                Thread.Sleep(180);
                Int32 cappbytes = Globals.stream.Read(data, 0, data.Length);
                responseData1 = System.Text.Encoding.ASCII.GetString(data, 0, cappbytes);
                var array = responseData1.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] imageBytes = //new Byte[999999 * 1024];
                data = Convert.FromBase64String(array[1]);
                MemoryStream ms = new MemoryStream(data, 0, data.Length);
                // Convert byte[] to Image
                ms.Write(data, 0, data.Length);
                Image image = Image.FromStream(ms, true);
                pictureBox1.Image = image;
                Thread.Sleep(50);


            }

            catch
            {
                //lblStatus.Text += string.Format("Offline {0} \r\n");
                //txtMsg.ScrollToCaret();
                responseData = "";
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try

            {
                //CARREGA camera direita

                //NetworkStream stream = Globals.Client.GetStream();
                byte[] data = new Byte[999999 * 1024];
                string cap = "<LIMA CMD=\"Project_GetCameraImage\" DIR=\"Request\"CONTENT_TYPE = \"jpg/base64\" />";
                byte[] capbytes = Encoding.ASCII.GetBytes(cap);
                Globals.stream1.Write(capbytes, 0, capbytes.Length);
                Thread.Sleep(180);
                Int32 cappbytes = Globals.stream1.Read(data, 0, data.Length);
                responseData1 = System.Text.Encoding.ASCII.GetString(data, 0, cappbytes);
                var array = responseData1.Split(new char[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] imageBytes = //new Byte[999999 * 1024];
                data = Convert.FromBase64String(array[1]);
                MemoryStream ms = new MemoryStream(data, 0, data.Length);
                // Convert byte[] to Image
                ms.Write(data, 0, data.Length);
                Image image = Image.FromStream(ms, true);
                pictureBox4.Image = image;
                Thread.Sleep(50);


            }

            catch
            {
                //lblStatus2.Text += string.Format("Não foi possível carregar a imagem! Erro {0} \r\n");
                //txtMsg.ScrollToCaret();
                responseData = "";
            }

        }


        private void abrir()
        {
            ConfigurarIP();
            
            try
            {
                //IP Câmera Esquerda
                //Globals.ConfigIp = "192.168.100.98";
                var Client = new TcpClient();
                var result = Client.BeginConnect(ConfigIp, intPorta, null, null);
                result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                if (!Client.Connected)
                {
                    throw new Exception("Failed to connect.");
                }

                //we have connected
                //Client.EndConnect(result);
                Globals.Client = Client;
                Globals.stream = Client.GetStream();
                Globals.result = result;
                lblStatus.Text = "Online";
                ptbLed1.BackColor = Color.Green;
                btnSKU.Enabled = true;
                //TcpClient Client = new TcpClient();
                //Client.ReceiveTimeout = 600;
                //Client.SendTimeout = 500;
                //Client.Connect("192.168.100.98", 32001);
                //Globals.Client = Client;
                //Globals.stream1 = Client.GetStream();

            }
            catch
            {
                responseData = "";
            }


            try
            {
                //IP Câmera Direita
                //Globals.ConfigIp2 = "192.168.100.99";
                var Client1 = new TcpClient();
                var result1 = Client1.BeginConnect(ConfigIp2, intPorta2, null, null);
                result1.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));
                if (!Client1.Connected)
                {
                    throw new Exception("Failed to connect.");
                }

                //we have connected
                //
                Globals.Client1 = Client1;
                Globals.stream1 = Client1.GetStream();
                Globals.result1 = result1;
                lblStatus2.Text = "Online";
                ptbLed2.BackColor = Color.Green;
                btnSKU2.Enabled = true;
                //TcpClient Client1 = new TcpClient();
                //Client1.SendTimeout = 500;
                //Client1.Connect("192.168.100.99", 32001);
                //Globals.Client1 = Client1;
                //Client1.SendTimeout = 200;
                //Globals.stream1 = Client1.GetStream();

            }
            catch
            {
                responseData = "";
            }


        }

        private void fechar()
        {
            if (lblStatus.Text == "Online")
            {
                Globals.Client.EndConnect(Globals.result);
                Globals.Client.Close();
                lblStatus.Text = "Offline";
                ptbLed1.BackColor = Color.Red;
                btnSKU.Enabled = false;
            }
            if (lblStatus2.Text == "Online")
            {
                Globals.Client1.EndConnect(Globals.result1);
                Globals.Client1.Close();
                lblStatus2.Text = "Offline";
                ptbLed2.BackColor = Color.Red;
                btnSKU2.Enabled = false;
              

            }

        }

        private void UnilevarMP_Load(object sender, EventArgs e)
        {
            abrir();

            btnConectar.Enabled = false;
            btnWeQube.Enabled = false;
        }


        //Abrir Pasta dos Projetos Câmera Esquerda
        private void btnSKU_Click(object sender, EventArgs e)
        {
            //Abre pasta dos Projetos
            openFileDialog1.InitialDirectory = "ftp://" + ConfigIp + "/Projects/";
            openFileDialog1.ShowDialog();
            //string suavariavel = System.IO.Path.GetFileName(openFileDialog1.FileName);
            string suavariavel = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            textBox1.Text = suavariavel;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 3);

            try

            {
                // Lê o Projeto
                byte[] data = new Byte[400000 * 1024];
                //string triggerMode = "<LIMA CMD=\"Project_SetNode\" DIR=\"Request\" PATH=\"Module Application.Module Match Code.Number Elements.Matchcode #1.Match Code\" VALUE=\"" + codCompara + "\" />"; 
                string projetoMode = "<LIMA DIR=\"Request\" CMD =\"Project_Load\" FILE =\"" + textBox1.Text + ".w_p\" />";
                byte[] projetoBytes = Encoding.ASCII.GetBytes(projetoMode);
                Globals.stream.Write(projetoBytes, 0, projetoBytes.Length);
                Thread.Sleep(50);
                Int32 projBytes = Globals.stream.Read(data, 0, data.Length);
                responseData2 = System.Text.Encoding.ASCII.GetString(data, 0, projBytes);
                //delay
                Thread.Sleep(100);
            }

            catch
            {
                //txtCompCod.Text += string.Format("Não foi possível carregar a imagem! Erro {0} \r\n");
                //txtMsg.ScrollToCaret();
                responseData = "";
            }
        }

        //Abrir Pasta dos Projetos Câmera Direita
        private void btnSKU2_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "ftp://" + ConfigIp2 + "/Projects/";
            openFileDialog2.ShowDialog();
            //string suavariavel = System.IO.Path.GetFileName(openFileDialog1.FileName);
            string suavariavel = System.IO.Path.GetFileNameWithoutExtension(openFileDialog2.FileName);
            textBox2.Text = suavariavel;
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 3);

            try

            {
                // Lê o Projeto
                byte[] data = new Byte[400000 * 1024];
                //string triggerMode = "<LIMA CMD=\"Project_SetNode\" DIR=\"Request\" PATH=\"Module Application.Module Match Code.Number Elements.Matchcode #1.Match Code\" VALUE=\"" + codCompara + "\" />"; 
                string projetoMode = "<LIMA DIR=\"Request\" CMD =\"Project_Load\" FILE =\"" + textBox2.Text + ".w_p\" />";
                byte[] projetoBytes = Encoding.ASCII.GetBytes(projetoMode);
                Globals.stream1.Write(projetoBytes, 0, projetoBytes.Length);
                Thread.Sleep(50);
                Int32 projBytes = Globals.stream1.Read(data, 0, data.Length);
                responseData2 = System.Text.Encoding.ASCII.GetString(data, 0, projBytes);
                //delay
                Thread.Sleep(100);
            }

            catch
            {
                //txtCompCod.Text += string.Format("Não foi possível carregar a imagem! Erro {0} \r\n");
                //txtMsg.ScrollToCaret();
                responseData = "";
            }
        }

        //Abrir WeQUbe
        private void btnWeQube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            pProcess.StartInfo.FileName = @"C:\Program Files (x86)\wenglor\weQube\bin\weQube[1.4.4].exe";

            pProcess.Start();

            pProcess.WaitForExit();
        }

        //Conectar Câmeras
        private void btnConectar_Click(object sender, EventArgs e)
        {
            abrir();
            Thread.Sleep(50);
            btnConectar.Enabled = false;
            btnWeQube.Enabled = false;
            btnDesconectar.Enabled = true;
            btnReset1.Enabled = true;
            btnReset2.Enabled = true;


        }

        //Desconectar Câmeres
        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            fechar();
            Thread.Sleep(50);
            btnDesconectar.Enabled = false;
            btnConectar.Enabled = true;
            btnWeQube.Enabled = true;
            btnSKU.Enabled = false;
            btnSKU2.Enabled = false;
            btnReset1.Enabled = false;
            btnReset2.Enabled = false;

        }

        //Sair do Programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                fechar();
            }
            catch (Exception ex)
            {
                string.Format("Não foi possível fechar a porta {0} \r\n", ex.Message);

            }

            Application.Exit();
        }

        private static void ConfigurarIP()
        {
            try
            {
                //Abre um arquivo com os dados do IP e Porta
                StreamReader stremIP = new StreamReader(@"C:\UnileverMP\IP.ing");

                //Lê o conteúdo do arquivo e quebra em uma array
                string[] arrValor = stremIP.ReadToEnd().Split('\n');

                stremIP.Close();
                stremIP.Dispose();

                if (arrValor.Length > 0)
                {
                    //Se o array possuir registros atualiza o valor das variaveis IP e Porta camera esquerda
                    ConfigIp = arrValor[1].Replace("\r", "");
                    ConfigIp2 = arrValor[5].Replace("\r", "");
                    intPorta = Convert.ToInt32(arrValor[2].Replace("\r", ""));
                    intPorta2 = Convert.ToInt32(arrValor[6].Replace("\r", ""));
                }
            }
            catch (Exception ex)
            {
                string.Format("Não foi possivel conectar IP  r\n", ex.Message);
            }

        }

        private void btnRejeito_Click(object sender, EventArgs e)
        {
            //btnRejeito.Image = System.Drawing.Image.FromFile(@"C: \Users\André Luís\Documents\Visual Studio 2015\Projects\UnileverMP\Encerrar.png");
            //btnRejeito.Image = Image.FromFile(@"C: \Users\André Luís\Documents\Visual Studio 2015\Projects\UnileverMP\Confirmar.png");
            if (btnRejeito.BackColor == Color.Red)
            {
                btnRejeito.BackColor = Color.Green;
            }
            else
            {
                btnRejeito.BackColor = Color.Red;
            }
        }

        private void ComunicaçãoCLP()
        {
            try
            {
                SerialPort port = new SerialPort("COM3");
                // configure serial port
                port.BaudRate = 19200;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Close();
                port.Open();
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);
                byte slaveId = 1;
                ushort startAddress = 4096;
                ushort numRegisters = 10;
                if (btnRejeito.BackColor == Color.Red)
                {
                    master.WriteSingleCoil(slaveId, 2070, false);
                }
                else
                {
                    master.WriteSingleCoil(slaveId, 2070, true);
                }
                if (reset1 == true)
                {
                    master.WriteSingleCoil(slaveId, 2068, true);
                    reset1 = false;
                }
                if (reset2 == true)
                {
                    master.WriteSingleCoil(slaveId, 2069, true);
                    reset2 = false;
                }



                ushort[] registers = master.ReadHoldingRegisters(slaveId, startAddress, numRegisters);
                //bool[] coil = master.ReadCoils(slaveId, 2068, 5);

                //Resultados na Camera esquerda

                bom_esq = (registers[1] * 65536) + registers[0];
                bom_dir = (registers[3] * 65536) + registers[2];
                total_esq = (registers[5] * 65536) + registers[4];
                total_dir = (registers[7] * 65536) + registers[6];
                txtBons.Text = Convert.ToString(bom_esq);
                ruim_esq = total_esq - bom_esq;
                txtRuins.Text = Convert.ToString(ruim_esq);
                txtTotal.Text = Convert.ToString(total_esq);
                if (ruim_esq > 0)
                txtPorcentagemRuins.Text = Convert.ToString((ruim_esq / total_esq) * 100);
                if ( bom_esq > 0)
                txtPorcentagemBons.Text = Convert.ToString((bom_esq / total_esq) * 100);

                //Resultados na Camera direita
                txtBons1.Text = Convert.ToString(bom_dir);
                ruim_dir = total_dir - bom_dir;
                txtRuins1.Text = Convert.ToString(ruim_dir);
                txtTotal1.Text = Convert.ToString(total_dir);
                if (ruim_dir > 0)
                txtPorcentagemRuins1.Text = Convert.ToString((ruim_dir / total_dir) * 100);
                if (bom_dir > 0)
                txtPorcentagemBons1.Text = Convert.ToString((bom_dir / total_dir) * 100);
                port.Close();
            }
            catch
            {
                responseData = "";
            }

        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            reset1 = true;
            txtPorcentagemRuins.Text = "0";
            txtPorcentagemBons.Text = "0";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ComunicaçãoCLP();
            Thread.Sleep(50);

        }

        private void btnReset2_Click(object sender, EventArgs e)
        {
            reset2 = true;
            txtPorcentagemRuins1.Text = "0";
            txtPorcentagemBons1.Text = "0";
        }
    }
}













