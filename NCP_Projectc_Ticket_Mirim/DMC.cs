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

    public partial class DMC : Form
    {
        public DMC()
        {
            InitializeComponent();
        }

        private void DMC_Load(object sender, EventArgs e)
        {
            con_name.Text = Ticket_Mirim_reservatiion.str;
        }
    }
}
