using Microsoft.Win32;

namespace exercicio_17
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            textBox3.UseSystemPasswordChar = true;
            form2 = new Form2(this);  // Passa uma referência do Form1 para o Form2
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox3.UseSystemPasswordChar = false; }

            else { textBox3.UseSystemPasswordChar = true; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            form2.AdicionarNome(nome);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show($"Utilizador {nome} registado!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
