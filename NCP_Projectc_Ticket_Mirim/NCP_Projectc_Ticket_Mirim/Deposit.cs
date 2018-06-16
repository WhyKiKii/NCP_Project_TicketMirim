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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void K_depositNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void K_depositCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void K_depositCancle_MouseHover(object sender, EventArgs e)
        {
            K_depositCancle.BackColor = Color.DarkViolet;
            K_depositCancle.ForeColor = Color.White;
        }

        private void K_depositCancle_MouseLeave(object sender, EventArgs e)
        {
            K_depositCancle.BackColor = Color.Transparent;
            K_depositCancle.ForeColor = Color.Black;
        }
    }
}
