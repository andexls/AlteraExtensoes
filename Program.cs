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
        static public void Renomear(String antes, String depois, Boolean subpastas, ProgressBar barra, Label barratext)
        {
            double valor = 0;
            SearchOption sub;
            if (subpastas) { sub = SearchOption.AllDirectories; } else { sub = SearchOption.TopDirectoryOnly; }

            String[] arquivos = Directory.GetFiles(@".\", "*", sub);
            foreach (String arq in arquivos){
                if ("."+antes == arq.Substring(arq.Length - antes.Length - 1))
                {
                    File.Move(arq, arq.Substring(0, arq.Length - antes.Length) + depois);
                }
                valor += 100.0 / arquivos.Count();
                barra.Value = (int)Math.Round(valor,0);
                barratext.Text = barra.Value.ToString()+"%";
                barra.Refresh();
                barratext.Refresh();
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
