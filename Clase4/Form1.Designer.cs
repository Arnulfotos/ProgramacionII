namespace Clase4
{
    partial class Arnulfotos
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
            label1 = new Label();
            Nombre = new TextBox();
            label2 = new Label();
            button1 = new Button();
            Valor1 = new TextBox();
            Valor2 = new TextBox();
            Resultado = new Label();
            Sumar = new Button();
            FetchData = new Label();
            Request = new Button();
            Target = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 39);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Mi primer programa";
            label1.Click += label1_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(158, 71);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(233, 23);
            Nombre.TabIndex = 1;
            Nombre.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 121);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(158, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Valor1
            // 
            Valor1.Location = new Point(559, 175);
            Valor1.Name = "Valor1";
            Valor1.Size = new Size(100, 23);
            Valor1.TabIndex = 4;
            // 
            // Valor2
            // 
            Valor2.Location = new Point(559, 221);
            Valor2.Name = "Valor2";
            Valor2.Size = new Size(100, 23);
            Valor2.TabIndex = 5;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(559, 259);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(59, 15);
            Resultado.TabIndex = 6;
            Resultado.Text = "Resultado";
            // 
            // Sumar
            // 
            Sumar.Location = new Point(559, 288);
            Sumar.Name = "Sumar";
            Sumar.Size = new Size(75, 23);
            Sumar.TabIndex = 7;
            Sumar.Text = "Sumar";
            Sumar.UseVisualStyleBackColor = true;
            Sumar.Click += Sumar_Click;
            // 
            // FetchData
            // 
            FetchData.AutoSize = true;
            FetchData.Location = new Point(158, 243);
            FetchData.Name = "FetchData";
            FetchData.Size = new Size(60, 15);
            FetchData.TabIndex = 8;
            FetchData.Text = "FetchData";
            FetchData.Click += label3_Click;
            // 
            // Request
            // 
            Request.Location = new Point(158, 261);
            Request.Name = "Request";
            Request.Size = new Size(75, 23);
            Request.TabIndex = 9;
            Request.Text = "Request";
            Request.UseVisualStyleBackColor = true;
            Request.Click += Request_Click;
            // 
            // Target
            // 
            Target.AutoSize = true;
            Target.Location = new Point(158, 309);
            Target.Name = "Target";
            Target.Size = new Size(39, 15);
            Target.TabIndex = 10;
            Target.Text = "Target";
            // 
            // Arnulfotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Target);
            Controls.Add(Request);
            Controls.Add(FetchData);
            Controls.Add(Sumar);
            Controls.Add(Resultado);
            Controls.Add(Valor2);
            Controls.Add(Valor1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(label1);
            Name = "Arnulfotos";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Nombre;
        private Label label2;
        private Button button1;
        private TextBox Valor1;
        private TextBox Valor2;
        private Label Resultado;
        private Button Sumar;
        private Label FetchData;
        private Button Request;
        private Label Target;
    }
}
