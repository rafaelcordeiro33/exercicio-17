namespace exercicio_17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bttn_GuardarRegisto = new Button();
            bttn_VerRegistos = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            VerPassword = new CheckBox();
            bttn_Sair = new Button();
            SuspendLayout();
            // 
            // bttn_GuardarRegisto
            // 
            bttn_GuardarRegisto.Location = new Point(275, 335);
            bttn_GuardarRegisto.Name = "bttn_GuardarRegisto";
            bttn_GuardarRegisto.Size = new Size(235, 79);
            bttn_GuardarRegisto.TabIndex = 3;
            bttn_GuardarRegisto.Text = "Guardar Registo";
            bttn_GuardarRegisto.UseVisualStyleBackColor = true;
            bttn_GuardarRegisto.Click += bttn_GuardarRegisto_Click;
            // 
            // bttn_VerRegistos
            // 
            bttn_VerRegistos.Location = new Point(592, 390);
            bttn_VerRegistos.Name = "bttn_VerRegistos";
            bttn_VerRegistos.Size = new Size(196, 48);
            bttn_VerRegistos.TabIndex = 4;
            bttn_VerRegistos.Text = "Ver Registos";
            bttn_VerRegistos.UseVisualStyleBackColor = true;
            bttn_VerRegistos.Click += bttn_VerRegistos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 88);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 166);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 6;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 243);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 7;
            label3.Text = "Password:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(299, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(183, 31);
            txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(299, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(299, 243);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(183, 31);
            txtPassword.TabIndex = 10;
            // 
            // VerPassword
            // 
            VerPassword.AutoSize = true;
            VerPassword.Location = new Point(495, 247);
            VerPassword.Name = "VerPassword";
            VerPassword.Size = new Size(62, 29);
            VerPassword.TabIndex = 11;
            VerPassword.Text = "ver";
            VerPassword.UseVisualStyleBackColor = true;
            VerPassword.CheckedChanged += VerPassword_CheckedChanged;
            // 
            // bttn_Sair
            // 
            bttn_Sair.Location = new Point(726, 12);
            bttn_Sair.Name = "bttn_Sair";
            bttn_Sair.Size = new Size(62, 48);
            bttn_Sair.TabIndex = 12;
            bttn_Sair.Text = "Sair";
            bttn_Sair.UseVisualStyleBackColor = true;
            bttn_Sair.Click += bttn_Sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_Sair);
            Controls.Add(VerPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bttn_VerRegistos);
            Controls.Add(bttn_GuardarRegisto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttn_GuardarRegisto;
        private Button bttn_VerRegistos;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox VerPassword;
        private Button bttn_Sair;
    }
}
