using Cadastro_de_peças.Modelos;
using System.Windows.Forms;

namespace Cadastro_de_peças
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public void EnvioDataGrid(object peca)
        {
            dataGridView1.DataSource = peca;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Nome");
            this.comboBox1.Items.Add("Tipo");
            this.comboBox1.Items.Add("Data de modificação");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
