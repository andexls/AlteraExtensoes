using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AlteraExtensoes
{

    class Metodos
    {
        static public void Renomear(String antes, String depois, Boolean subpastas, ProgressBar barra, Label barratext, bool atual, String pasta)
        {
            double valor = 0;
            String dir;
            SearchOption sub;
            if (subpastas) { sub = SearchOption.AllDirectories; } else { sub = SearchOption.TopDirectoryOnly; }

            if (atual) { dir = @".\"; } else { dir = pasta; }

            String[] arquivos = Directory.GetFiles(dir, "*", sub);
            foreach (String arq in arquivos){
                if ("."+antes == arq.Substring(arq.Length - antes.Length - 1))
                {
                    try
                    {
                        File.Move(arq, arq.Substring(0, arq.Length - antes.Length) + depois);
                    }
                    catch { }
                    
                }
                valor += 100.0 / arquivos.Count();
                barra.Value = (int)Math.Round(valor,0);
                barratext.Text = barra.Value.ToString()+"%";
                barra.Refresh();
                barratext.Refresh();
            }
        }

        static public void ChooseFolder(TextBox text,FolderBrowserDialog form)
        {
            form.SelectedPath = Directory.GetCurrentDirectory();
            if (form.ShowDialog() == DialogResult.OK)
            {
                text.Text = form.SelectedPath;
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
