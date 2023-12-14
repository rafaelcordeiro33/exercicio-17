namespace exercicio_17
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            bttn_FazerRegistos = new Button();
            listBox1 = new ListBox();
            bttn_sair = new Button();
            SuspendLayout();
            // 
            // bttn_FazerRegistos
            // 
            bttn_FazerRegistos.Location = new Point(592, 369);
            bttn_FazerRegistos.Name = "bttn_FazerRegistos";
            bttn_FazerRegistos.Size = new Size(196, 48);
            bttn_FazerRegistos.TabIndex = 5;
            bttn_FazerRegistos.Text = "Fazer Registos";
            bttn_FazerRegistos.UseVisualStyleBackColor = true;
            bttn_FazerRegistos.Click += bttn_FazerRegistos_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(247, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 329);
            listBox1.TabIndex = 6;
            // 
            // bttn_sair
            // 
            bttn_sair.Location = new Point(726, 12);
            bttn_sair.Name = "bttn_sair";
            bttn_sair.Size = new Size(62, 48);
            bttn_sair.TabIndex = 7;
            bttn_sair.Text = "Sair";
            bttn_sair.UseVisualStyleBackColor = true;
            bttn_sair.Click += bttn_sair_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_sair);
            Controls.Add(listBox1);
            Controls.Add(bttn_FazerRegistos);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button bttn_FazerRegistos;
        private ListBox listBox1;
        private Button bttn_sair;
    }
}