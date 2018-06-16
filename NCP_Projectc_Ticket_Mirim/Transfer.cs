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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void K_transferNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void K_transferCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void K_transferCancle_MouseHover(object sender, EventArgs e)
        {
            K_transferCancle.BackColor = Color.DarkViolet;
            K_transferCancle.ForeColor = Color.White;
        }

        private void K_transferCancle_MouseLeave(object sender, EventArgs e)
        {
            K_transferCancle.BackColor = Color.Transparent;
            K_transferCancle.ForeColor = Color.Black;
        }
    }
}
