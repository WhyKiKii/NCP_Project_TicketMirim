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
    public partial class Ticket_Mirim_main : Form
    {
        public Ticket_Mirim_main()
        {
            InitializeComponent();
        }

        private void Ticket_Mirim_main_Load(object sender, EventArgs e)
        {
            string[] data = { "슈퍼루키（Ver．끝판왕）좋은콘서트＃1－서울", "오버워치 핫식스 APEX 시즌3 결승전","어반 뮤직 페스티벌 2018" };

            comboBox_S.Items.AddRange(data);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
