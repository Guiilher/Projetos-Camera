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
using static System.Windows.Forms.LinkLabel;
using System.Net.Sockets;

namespace Implacil
{
    public partial class Implacil : Form
    {
        public Implacil()
        {
            InitializeComponent();
        }

        

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
        }


        //Apagar dados do arquivo de texto
        private void button2_Click(object sender, EventArgs e)
        {
            Lista.SelectedItems.Clear();

            for (int i = Lista.Items.Count - 1; i >= 0; i--)
            {

                if (Lista.Items[i].ToString().Contains(txtCodigo1.Text + ";" + txtCodigo2.Text))
                {

                    Lista.SetSelected(i, true);
                    listBox2.Items.Add(Lista.SelectedItem);


                    int indice = Lista.SelectedIndex;

                    if (indice != -1)
                    {
                        string linha = Lista.Items[indice].ToString();


                        using (var input = File.OpenText(@"C:\Implacil\Lista\Implacil.txt"))
                        using (var output = new StreamWriter("tmpFoo.txt"))
                        {
                            string linhaAtual;
                            while ((linhaAtual = input.ReadLine()) != null)
                            {
                                if (linhaAtual != linha)
                                {
                                    output.WriteLine(linhaAtual);

                                }

                            }


                        }
                        //Compara o codigo da Lista principal e se for igual copia e manda para listbox2 e deleta da lista principal
                        StreamWriter arquivotxt = new StreamWriter(@"C:\Implacil\Implacil2.txt", true, Encoding.Default);
                        arquivotxt.WriteLine(txtCodigo1.Text + ";" + txtCodigo2.Text);
                        arquivotxt.Close();
                        Lista.Items.RemoveAt(indice); // Remove o item selecionado
                        File.Delete(@"C:\Implacil\Lista\Implacil.txt"); // Deleta o arquivo original
                        File.Move("tmpFoo.txt", @"C:\Implacil\Lista\Implacil.txt"); // Substitui o original pelo modificado
                        break;
                    }

                }




                ////Manda para listabox1 os codigos que não tem na lista principal e salva em um arquivo de texto
                else if (!Lista.Items.Contains(txtCodigo1.Text + ";" + txtCodigo2.Text))
                {

                    Lista.SelectedItem = listBox1.Items.Add(txtCodigo1.Text + ";" + txtCodigo2.Text);
                    StreamWriter arquivotxt = new StreamWriter(@"C:\Implacil\Implacil3.txt", true, Encoding.Default);
                    arquivotxt.WriteLine(txtCodigo1.Text + ";'" + txtCodigo2.Text);
                    arquivotxt.Close();
                    break;
                }

            }

        }


        //Metodo ARRAY
        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {

                var consulta =
                from linha in File.ReadAllLines(@"C:\Implacil\Lista\" + comboBox1.Text)
                let codigo = linha.Split(';')
                select new Codigos()
                {
                    Codigo1 = codigo[0],
                    Codigo2 = codigo[1],

                };

                foreach (var item in consulta)
                {

                    Lista.Items.Add(item.Codigo1 + ";" + item.Codigo2);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Erro : " + ex.Message);
            }

        }

      



        private void  btnCompararArquivos_Click(object sender, EventArgs e)
        {
            //List<string> mensagemLinha = new List<string>();
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Implacil\Implacil2.txt");
            //File.WriteAllLines(@"C:\Implacil\Implacil2.txt", lines.Take(lines.Length - 1).ToArray());

            string Caminho = @"C:\Implacil\ImplacilLista.txt";
            string Caminho1 = @"C:\Implacil\Implacil2.txt";

            string[] arquivo = File.ReadAllLines(Caminho);
            string[] arquivo1 = File.ReadAllLines(Caminho1);

            if(arquivo == arquivo1)
            {
                MessageBox.Show("igual");
            }

            else
            {
                MessageBox.Show("diferente");
            }
        }
       

        private void Implacil_Load(object sender, EventArgs e)
        {
            Listar();
            
        }

        private void Listar()
        {
            DirectoryInfo Dir = new DirectoryInfo(@"C:\Implacil\Lista");
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo File in Files)
            {
                string FileName = File.FullName.Replace(Dir.FullName, "").Remove(0, 1);
                comboBox1.Items.Add(FileName);
            }
        }

     

      
    }
}





