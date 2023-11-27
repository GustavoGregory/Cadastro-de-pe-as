using Cadastro_de_peças.Modelos;

namespace Cadastro_de_peças
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Peca peca1 = new Peca("Gustavo", "Chave", DateTime.Now, null);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_add1.Visible = false;
            txt_add_key2.Visible = true;
            txt_add_val2.Visible = true;
            btn_add2.Visible = true;
            btn_del2.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btn_add2.Visible = false;
            btn_del2.Visible = false;
            txt_add_key3.Visible = true;
            txt_add_val3.Visible = true;
            btn_add3.Visible = true;
            btn_del3.Visible = true;
        }

        private void btn_add3_Click(object sender, EventArgs e)
        {
            btn_add3.Visible = false;
            btn_del3.Visible = false;
            txt_add_key4.Visible = true;
            txt_add_val4.Visible = true;
            btn_del4.Visible = true;
        }
    }
}
