using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VickyCortes
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private async void BtnCalcular_Click(object sender, EventArgs e)
        {
            string producto;
            decimal precio,cantidad,subtotal,desc,total;

            producto=TxtProducto.Text;
            precio= Convert.ToDecimal(TxtPrecio.Text);
            cantidad = Convert.ToDecimal(TxtCantidad.Text);
            desc = 0.15M; 
            subtotal = precio * cantidad;
            
            decimal descuento = await CalcularDescuentoAsync(subtotal,desc);
            total = subtotal - descuento;
            TxtTotal.Text = total.ToString();
            
        }

        private async Task<decimal> CalcularDescuentoAsync(decimal subtotal,decimal desc)
        {
            decimal valorDescuento = await Task.Run(() =>
            { return subtotal * desc; });

            return valorDescuento;
            

        }
    }
}
