using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCP_Projectc_Ticket_Mirim
{
    public partial class Ticket_Mirim_main : Form
    {
        public Ticket_Mirim_main()
        {
            InitializeComponent();
        }

        private void Ticket_Mirim_main_Load(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines(@"..\txt\Con_Title.txt");
            
            comboBox_S.Items.AddRange(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ticket_Mirim_reservatiion reservatiion = new Ticket_Mirim_reservatiion();
            reservatiion.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
