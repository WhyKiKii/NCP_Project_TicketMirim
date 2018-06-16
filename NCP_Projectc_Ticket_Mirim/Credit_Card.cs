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
    public partial class Credit_Card : Form
    {
        public Credit_Card()
        {
            InitializeComponent();
        }

        private void K_creditNext_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void K_creditCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Credit_Card_Load(object sender, EventArgs e)
        {

        }

        private void Credit_Card_MouseHover(object sender, EventArgs e)
        {
            K_creditCancle.BackColor = Color.DarkViolet;
            K_creditCancle.ForeColor = Color.White;
        }

        private void K_creditCancle_MouseLeave(object sender, EventArgs e)
        {
            K_creditCancle.BackColor = Color.Transparent;
            K_creditCancle.ForeColor = Color.Black;
        }
    }
}
