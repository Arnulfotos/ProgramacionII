using System.Net.Http;

namespace Clase4
{
    public partial class Arnulfotos : Form
    {
        private HttpClient _httpClient;

        public Arnulfotos()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Nombre.Text.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sumar_Click(object sender, EventArgs e)
        {
            int sumar = int.Parse(Valor1.Text) + int.Parse(Valor2.Text);

            Resultado.Text = sumar.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void Request_Click(object sender, EventArgs e)
        {


            var rand = new Random();


            string url = $"https://jsonplaceholder.typicode.com/todos/{rand.Next(1, 11)}";

            var result = await _httpClient.GetAsync(url);
            var body = await result.Content.ReadAsStringAsync();

            Target.Text = body;
        }
    }
}
