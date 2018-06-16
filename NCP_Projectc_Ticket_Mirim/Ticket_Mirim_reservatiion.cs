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
    public partial class Ticket_Mirim_reservatiion : Form
    {
        public static string str;
        public Ticket_Mirim_reservatiion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "18시 00분", "20시 30분" };

            comboBox_yj.Items.AddRange(data);

            comboBox_yj.SelectedIndex = 0;
            /*선생님 경로로 바꾸세요!
            string f_name = @"C:\Users\Mirim\source\repos\NCP_Projectc_Ticket_Mirim\NCP_Projectc_Ticket_Mirim\concert_infor.txt";
            string textValue = System.IO.File.ReadAllText(f_name, Encoding.Default);
            concert_infor.Text = textValue;*/

            concert_infor.Text =
            " 콘서트    슈퍼루키（Ver．끝판왕）：좋은콘서트＃1－서울\n\n 라인업    김하온, 이병재, 이로한, 윤진영, 조원우\n,오담률, 김윤호, 하선호, 김근수, 박준호\n\n공연기간  2018.07.07\n\n공연장 고려대학교 화정 체육관\n\n주최 / 주관 주식회사 좋은 콘서트\n\n  ----------------------------------------------------------\n\n가격 R석  55,000원\n\n S석  33.000원\n\n일반 12,000원";


            /*StreamReader sr = new StreamReader("concert_infor.txt");

            while (sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();*/

            listBox_yj.Items.Add("전체 1200석");
            listBox_yj.Items.Add("R석 300석");
            listBox_yj.Items.Add("S석 300석");
            listBox_yj.Items.Add("일반 600석");
            

            //pictureBox1.Load(@"C:\Users\Mirim\source\repos\NCP_Project_yj\NCP_Project_yj\Ticket_Mirim.png");
            //pictureBox1.Image = System.Drawing.Image.FromFile(@"C:\Users\Mirim\source\repos\NCP_Project_yj\NCP_Project_yj\Ticket_Mirim.png");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_yj_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DMC dmc = new DMC();
            dmc.ShowDialog();
        }

        private void concert_infor_Click(object sender, EventArgs e)
        {

        }
    }
}
