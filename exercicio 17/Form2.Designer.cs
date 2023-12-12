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
            button5 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(592, 369);
            button5.Name = "button5";
            button5.Size = new Size(196, 48);
            button5.TabIndex = 5;
            button5.Text = "Fazer Registos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            // button1
            // 
            button1.Location = new Point(726, 12);
            button1.Name = "button1";
            button1.Size = new Size(62, 48);
            button1.TabIndex = 7;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(button5);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private ListBox listBox1;
        private Button button1;
    }
}