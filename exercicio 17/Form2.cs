using System;
using System.Windows.Forms;

namespace exercicio_17
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public void AdicionarNome(string nome)
        {
            listBox1.Items.Add(nome);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
