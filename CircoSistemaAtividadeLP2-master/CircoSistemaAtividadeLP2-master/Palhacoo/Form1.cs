namespace Palhacoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Nome
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Idade
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Altura
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Peso
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //Sexo
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //Cadastrar dados do palhaco da classe Palhaco

            Palhaco palhaco = new Palhaco(textBox1.Text, int.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text), textBox5.Text);

            //Mostrar dados do palhaco na tela

            MessageBox.Show("Nome: " + palhaco.Nome + "\nIdade: " + palhaco.Idade + "\nAltura: " + palhaco.Altura + "\nPeso: " + palhaco.Peso + "\nSexo: " + palhaco.Sexo);

        }
    }
}