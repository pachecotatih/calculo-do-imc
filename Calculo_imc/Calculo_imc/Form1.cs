using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Declaração da variável
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtIMC.Text = imc.ToString("0.00");
            if (imc < 18.49)
            
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso", "Cálculo do IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
                else if(imc < 24.99 )
                
                    MessageBox.Show("SITUAÇÃO: Você está com Peso dentro da Normalidade", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                   
 else if (imc < 29.99)
                
                    MessageBox.Show("SITUAÇÃO: Você está acima do Peso", "Cálculo de IMC",
                                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                   
                else if (imc < 34.99)
                
                    MessageBox.Show("Atenção!Você está com Obesidade Grau I", "Cálculo de IMC",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
                    
                else if (imc < 39.99)
                
                    MessageBox.Show("Atenção!Você está com Obesidade Grau II (severa)", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
                  
                else
                    MessageBox.Show("Atenção!Você está com grau de obesidade Grau III (mórbida)",
                   "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         
                
        }
    }
}
