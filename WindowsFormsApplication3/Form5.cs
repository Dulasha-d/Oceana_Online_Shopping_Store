using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (cmb.SelectedItem.ToString() == "Lipstick")
            {
                price = 500 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Scrunchies")
            {
                price = 100 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Earrings")
            {
                price = 200 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Necklass")
            {
                price = 600 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Bangle")
            {
                price = 500 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Eye Shadow Palete")
            {
                price = 800 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Hair Clip")
            {
                price = 100 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Hair Band")
            {
                price = 200 * Convert.ToInt16(txtQty.Text);
            }
            if (cmb.SelectedItem.ToString() == "Nail Polish")
            {
                 price= 500 * Convert.ToInt16(txtQty.Text);
            }

            //Loyalty Member
           string yes = "Bangle";
            string no = "Be a loyalty Member";
            if (rdoYes.Checked)
            {
                txtGift.Text = yes;
            }
            else
            {
                txtGift.Text = no;

            }

            txtBill.Text = Convert.ToString(price);

 




            
          
         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
