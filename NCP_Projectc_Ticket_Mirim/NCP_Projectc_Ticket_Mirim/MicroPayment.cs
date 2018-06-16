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
    public partial class MicroPayment : Form
    {
        public MicroPayment()
        {
            InitializeComponent();
        }

        private void K_microCertification_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void K_microCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MicroPayment_Load(object sender, EventArgs e)
        {

        }

        private void K_microCancle_MouseHover(object sender, EventArgs e)
        {
            K_microCancle.BackColor = Color.DarkViolet;
            K_microCancle.ForeColor = Color.White;
        }

        private void K_microCancle_MouseLeave(object sender, EventArgs e)
        {
            K_microCancle.BackColor = Color.Transparent;
            K_microCancle.ForeColor = Color.Black;
        }
    }
}
