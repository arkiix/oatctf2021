using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reverse2
{
    public partial class Casino : Form
    {
        private void Form1_Load(object sender, EventArgs e) { }

        public Casino()
        {
            InitializeComponent();
        }

        private int Get_Random()
        {
            Random rnd = new Random();
            int value = rnd.Next(10000, 99999);
            return value;
        }

        private string Check_Win(int number)
        {
            string res = "Lucky next time!";
            if (number == 77777)
                res = "Wow! oatctf{3bunny_wr0te_c4s1no}";
            return res;
        }

        private void button_Click(object sender, EventArgs e)
        {
            int num = Get_Random();
            numbers.Text = num.ToString();
            notifications.Text = Check_Win(num);
        }
    }
}
