using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCP_Projectc_Ticket_Mirim
{
    public partial class Ticket_Mirim_approval : Form
    {
        public Ticket_Mirim_approval()
        {
            InitializeComponent();
        }

        Credit_Card credit = new Credit_Card();
        Transfer transfer = new Transfer();
        Deposit deposit = new Deposit();
        MicroPayment microPayment = new MicroPayment();
        NaverPay naverPay = new NaverPay();
        Payco payco = new Payco();

        private void K_payment_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Credit_Card credit = new Credit_Card();
                credit.ShowDialog();
            }
            else if (radioButton2.Checked == true)
            {
                //Transfer transfer = new Transfer();
                transfer.ShowDialog();
            }
            else if (radioButton3.Checked == true)
            {
                //Deposit deposit = new Deposit();
                deposit.ShowDialog();
            }
            else if (radioButton4.Checked == true)
            {
               //MicroPayment micropayment = new MicroPayment();
                microPayment.ShowDialog();
            }
            else if (radioButton5.Checked == true)
            {
                //NaverPay naverpay = new NaverPay();
                naverPay.ShowDialog();
            }
            else if (radioButton6.Checked == true)
            {
                //Payco payco = new Payco();
                payco.ShowDialog();
            }
        }


        private void Ticket_Mirim_approval_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //Credit_Card credit = new Credit_Card();
                credit.ShowDialog();
            }
        }

        private void K_BackPage_Click(object sender, EventArgs e)
        {
             
            this.Visible = false;
            Ticket_Mirim_reservatiion approval = new Ticket_Mirim_reservatiion();
            approval.ShowDialog();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Ticket_Mirim_reservatiion.sit1;
        }
    }
}
