namespace VickyCortes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mostrarNumeros();

        }

        private void mostrarNumeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add(i + ".Vicky Cortes");
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        listBox1.Items.Add(i + ".Cortes");
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            listBox1.Items.Add(i + ".Vicky");
                        }
                        else
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }

            }
        }
    }
}
