using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyence.AutoID.SDK;
using System.Net.Sockets;
using System.Threading;

namespace Aerogas_EnviaCodigo
{
    class Program
    {
       

        static void Main(string[] args)
        {
           ReaderAccessor m_reader = new ReaderAccessor();
           ReaderSearcher m_searcher = new ReaderSearcher();

            //LER ARGUMENTO
            try
            {
                string CodConfig = args[0].ToString();
                string Ipconfig = args[1].ToString();
                //string CodConfig = "123456";
                //string Ipconfig = "192.168.100.1";

                string codComparacao = CodConfig;//Codigo de comparação
                Console.WriteLine("Enviar codigo para camera: " + codComparacao);
                
                //CONECTAR COM A CAMERA
                try
                {
                    //Stop liveview.
                    // liveviewForm1.EndReceive();
                    //Set ip address of liveview.
                    //liveviewForm1.IpAddress = Ipconfig;
                    ////Start liveview.
                    //liveviewForm1.BeginReceive();
                    ////Set ip address of ReaderAccessor.
                    m_reader.IpAddress = Ipconfig;
                    //Connect TCP/IP.
                    m_reader.Connect((data) =>
                    {

                        //Define received data actions here.Defined actions work asynchronously.
                        //"ReceivedDataWrite" works when reading data was received.
                        //BeginInvoke(new delegateUserControl(ReceivedDataWrite), Encoding.ASCII.GetString(data));
                    });

                    //TRANSFORMAR CODIGO E ENVIAR
                    try
                    {
                        //transf string em hex
                        codComparacao = toHex(CodConfig);
                        // Mandar código de comparacao
                        ReceivedDataWrite(m_reader.ExecCommand("WP,402," + codComparacao));
                        ReceivedDataWrite(m_reader.ExecCommand("SAVE"));
                        Console.WriteLine(String.Format("Código enviado..."));
                    }

                    catch (Exception ex2)
                    {
                        Console.WriteLine(String.Format("Não foi possível enviar o código de comparação!  Erro {0}/r/n", ex2.Message));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(String.Format("Falha na comunicação!  Erro {0}/r/n", ex.Message));
                }
                
            }
            catch
            {
                Console.WriteLine(String.Format("Não há argumento para alterar o código!  Erro {0}/r/n"));
            }

            //FECHAR PORTA
            m_reader.CloseFtp();
            //Console.Clear();

            //Console.ReadKey();

        }
        delegate void delegateUserControl(string str);
        private static void ReceivedDataWrite(string receivedData)
        {
             string DataText = (receivedData);
               
        }
        

        private static string toHex(string inp)
        {
            string outp = string.Empty;
            char[] value = inp.ToCharArray();
            foreach (char L in value)
            {
                int V = Convert.ToInt32(L);
                outp += string.Format("{0:x}", V);
            }
            return outp;
        }
    }
}
        
