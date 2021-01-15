using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Properties;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<Image> list = new List<Image>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add(Resources._01);
            list.Add(Resources._02);
            list.Add(Resources._03);
            list.Add(Resources._04);
            list.Add(Resources._05);
            list.Add(Resources._06);
            list.Add(Resources._07);
            list.Add(Resources._08);
            list.Add(Resources._09);
            list.Add(Resources._10);



        }

        private void button_Click(object sender, EventArgs e)
        {
                poker poker1 = new poker();
                List<int> poker = poker1.GetPoker(10);

                string msg = "";
                for (int i = 0; i < poker.Count; i++)
                {
                    msg += $"{poker[i]} ,";
                }
                picResult.Image = list[poker[0]];

        }

        private void picResult_Click(object sender, EventArgs e)
        {

        }
    }
}
