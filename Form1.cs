using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlteraExtensoes
{
    public partial class Form1 : Form
    {
        public float prog;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Metodos.Renomear(textBox1.Text, textBox2.Text, checkBox1.Checked, progressBar1, label3, radioAtual.Checked, inputDir.Text);
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            Metodos.ChooseFolder(inputDir, folderBrowserDialog1);
        }

        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioPerso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPerso.Checked)
            {
                inputDir.Enabled = true;
                btn_Procurar.Enabled = true;
            }
            else
            {
                inputDir.Enabled = false;
                btn_Procurar.Enabled = false;
            }
        }

        private void radioAtual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
