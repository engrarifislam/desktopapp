using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int price = 100;
            string name = txtName.Text;
            int ticketQuantity = Convert.ToInt32(txtQuantity.Text);



            for(int i = 1; i <= ticketQuantity; i++)
            {
                if (ticketQuantity == 1)
                {
                    price = price * ticketQuantity;
                    break;
                }
                else if(ticketQuantity == 2){
                    price = price - 5;
                    price = price * ticketQuantity;
                    break;
                }
                else if (ticketQuantity == 3)
                {
                    price = price - 10;
                    price = price * ticketQuantity;
                    break;
                }
                else if (ticketQuantity == 4)
                {
                    price = price * i;
                }
                
            }
            Clear();
            MessageBox.Show("Congratulation !!!  " + name + "  Your Ticket Price:" + price);
           
        }
        void Clear() {
            txtName.Text = "";
            txtQuantity.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
