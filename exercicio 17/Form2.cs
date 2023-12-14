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

        public void AdicionarNome(string nome,string email)
        {
            listBox1.Items.Add($"{nome} - ({email})");
        }

        private void bttn_sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bttn_FazerRegistos_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
    }
}
