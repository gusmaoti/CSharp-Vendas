namespace Fiap.Vendas
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            checkUser(txtUsername.Text, txtPasswrod.Text);
        }

        private void checkUser(string username, string password)
        {
            if (username == "Fiap" && password == "2025")
            {
                home telaInicio = new home();
                telaInicio.Show();
            }
            else
            {
                MessageBox.Show("Username or Password invalid!");
            }
        }
    }
}
