using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppRever.View
{
    public partial class TelaForm : Form
    {

        public TelaForm()
        {
            InitializeComponent();
        }


        private void Btn_calcular_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtPr.Text, out double numero1) &&
                double.TryParse(txtSg.Text, out double numero2) &&
                double.TryParse(txtTr.Text, out double numero3))

            {

                double maior = Math.Max(numero1, Math.Max(numero2, numero3));
                double menor = Math.Min(numero1, Math.Min(numero2, numero3));
                Maior.Text = $"Maior: {maior}";
                Menor.Text = $"Menor: {menor}";


            }
        }
    }
}
