using System.ComponentModel.Design;

namespace DersSinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        DersSinema.Sinema yeni;
        private void button1_Click(object sender, EventArgs e)
        {
            yeni = new DersSinema.Sinema(textBox1.Text, int.Parse(textBox2.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yeni.BiletSat(checkBox1.Checked);
            label3.Text = "Bilet Satt�m. Kalan Koltuk Say�s�" + yeni.BosKoltukOgren();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yeni.Bilet�ptal(checkBox1.Checked);
            label3.Text = "Bilet �ptal Ettim . Kalan Koltuk Say�s�" + yeni.BosKoltukOgren();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double deger = yeni.BakiyeOgren();
            label3.Text = "Bakiye " + deger.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int  deger = yeni.BosKoltukOgren();
            label3.Text = " Koltuk Say�s�  " + deger;
        }
    }
}