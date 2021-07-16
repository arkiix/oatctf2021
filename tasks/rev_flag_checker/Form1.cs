using System;
using System.Windows.Forms;

namespace reverse1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private static bool Flag_check(string text)
        {
            bool res = true;
            int[] valid = new int[] { 218, 198, 236, 194, 236, 200, 242, 236, 212, 98, 186, 224, 206, 232, 98, 224, 226, 98, 186, 102, 226, 186, 246, 100, 238, 224, 110, 254 };
            int[] flag = new int[28];
            int[] numbers = new int[] { 2, 4 };
            for (int i = 0; i < 28; i++)
                flag[i] = (int)text[i] * numbers[0] ^ numbers[1];
            for (int i = 0; i < 28; i++)
            {
                if (valid[i] != flag[i])
                    res = false;
            }
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flag = textBox1.Text;
            if (flag.Length == 28)
            {
                if (Flag_check(flag))
                    label2.Text = "Yes! The flag is correct!";
                else
                    label2.Text = "Flag is wrong!";
            }
            else
                label2.Text = "Wrong flag length";
        }
    }
}
