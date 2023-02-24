namespace VickyCortes
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mes = {"","Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            
            decimal capital =200000, tasa = 0.015M;
            int tiempo = 1;

           

            for (int i=1;i < mes.Length;i++) 
            {               
                listBox1.Items.Add(mes[i] + "------" + "L." + calcularInteres(capital, tasa, tiempo) * i);
            }
        }

        private decimal calcularInteres(decimal c, decimal i,int t)
        {
            return c*i*t;
        }
    }
}