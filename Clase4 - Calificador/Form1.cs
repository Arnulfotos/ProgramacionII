namespace Clase4___Calificador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int calificacion = (int.Parse(Quimica.Text) + int.Parse(Matematicas.Text) + int.Parse(Fisica.Text) ) / 3;

            if( calificacion >= 7 )
            {
                Target.Text = $"El alumno paso la materia con {calificacion}";

            }
            else
            {
                Target.Text = $"El alumno reprobo con {calificacion}";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
