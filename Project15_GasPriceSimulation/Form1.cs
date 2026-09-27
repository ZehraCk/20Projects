using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtDieselPrice.Text = dieselPrice.ToString()+" ₺";
            txtGasolinePrice.Text = gasolinePrice.ToString() + " ₺";
            txtLpgPrice.Text = lpgPrice.ToString() + " ₺";
        }
        double dieselPrice = 42.35;
        double gasolinePrice = 50.25;
        double dieselAmount=0;
        double lpgAmount=0;
        double lpgPrice = 23.76;
        double gasAmount=0;
        double progressBarValue = 0;
        double totalPrice=0;
        int count = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmount = Convert.ToDouble(txtGasAmount.Text);
            dieselAmount = Convert.ToDouble(txtGasAmount.Text);
            lpgAmount = Convert.ToDouble(txtGasAmount.Text);
            timer4.Start();
            timer4.Interval = 100; 

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
         
            this.Text = count.ToString();

            if (rdbGasoline.Checked)
            {
                count++;
                if (count <= gasAmount)
                {
                    totalPrice +=  gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";

                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }



                    progressBar1.Value += 3;
                if(progressBar1.Value == 99)
                {
                    timer4.Stop();
                   
                }
            }
            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";

                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }



                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer4.Stop();
                   
                }
            }
            if (rdbLpg.Checked)
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";

                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }



                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer4.Stop();
                    
                }
            }
        }
    }
}
