using Microsoft.Win32;

namespace exercicio_17
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            Utilizador.nome = txtNome.Text;
            Utilizador.email = txtEmail.Text;
            Utilizador.password = txtPassword.Text;
            txtPassword.UseSystemPasswordChar = true;
            form2 = new Form2(this);  // Passa uma referência do Form1 para o Form2
        }

        private void bttn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bttn_GuardarRegisto_Click(object sender, EventArgs e)
        {
            Utilizador.nome = txtNome.Text;
            Utilizador.email = txtEmail.Text;
            Utilizador.password = txtPassword.Text;

            if (Utilizador.nome == "" | Utilizador.email == "" | Utilizador.password == "")
            {MessageBox.Show("Tem de preencher todas as caixas para registar", "Erro de Validação", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);}     
            else {               
                form2.AdicionarNome(Utilizador.nome,Utilizador.email);
                txtNome.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
                MessageBox.Show($"Utilizador {Utilizador.nome} registado!");
            }
        }

        private void bttn_VerRegistos_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void VerPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (VerPassword.Checked) { txtPassword.UseSystemPasswordChar = false; }
            else { txtPassword.UseSystemPasswordChar = true; }
        }
    }
}
