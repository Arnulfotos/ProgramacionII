namespace Clase4___Calificador
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
            Matematicas = new TextBox();
            Quimica = new TextBox();
            Fisica = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Evaluar = new Button();
            Target = new Label();
            SuspendLayout();
            // 
            // Matematicas
            // 
            Matematicas.Location = new Point(183, 87);
            Matematicas.Name = "Matematicas";
            Matematicas.Size = new Size(100, 23);
            Matematicas.TabIndex = 0;
            // 
            // Quimica
            // 
            Quimica.Location = new Point(341, 87);
            Quimica.Name = "Quimica";
            Quimica.Size = new Size(100, 23);
            Quimica.TabIndex = 0;
            // 
            // Fisica
            // 
            Fisica.Location = new Point(499, 87);
            Fisica.Name = "Fisica";
            Fisica.Size = new Size(100, 23);
            Fisica.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 54);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Matematicas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 54);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Quimica";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 54);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Fisica";
            label3.Click += label1_Click;
            // 
            // Evaluar
            // 
            Evaluar.Location = new Point(183, 153);
            Evaluar.Name = "Evaluar";
            Evaluar.Size = new Size(75, 23);
            Evaluar.TabIndex = 2;
            Evaluar.Text = "Evaluar";
            Evaluar.UseVisualStyleBackColor = true;
            Evaluar.Click += button1_Click;
            // 
            // Target
            // 
            Target.AutoSize = true;
            Target.Location = new Point(293, 157);
            Target.Name = "Target";
            Target.Size = new Size(122, 15);
            Target.TabIndex = 3;
            Target.Text = "Resultado del alumno";
            Target.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Target);
            Controls.Add(Evaluar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Fisica);
            Controls.Add(Quimica);
            Controls.Add(Matematicas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Matematicas;
        private TextBox Quimica;
        private TextBox Fisica;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Evaluar;
        private Label Target;
    }
}
