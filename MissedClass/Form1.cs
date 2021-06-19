using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissedClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {

            // display if number is even or odd from  1 to 10

            // i++ &&& i = i + 1 &&& i += 1
            // i += 2 $$$ i = i + 2
            // i-- &&& i = i -1 &&& i -= 1
            // i -= 2 &&& i = i - 2

            // 3 / 2 = 1.5
            // 3 / 2 = 1

            // 4 / 2 = 2
            // 4 % 2 = 0

            // 5 / 3 = 1.333
            // 5 % 3 = 2

            // 3 % 5 = 3

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    OutputLB.Items.Add(i + " : is even");
                }
                else
                {
                    OutputLB.Items.Add(i + " : is odd");
                }
            }




        }
    }
}
