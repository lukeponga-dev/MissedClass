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

            for(int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    OutputLB.Items.Add(i + " : is even");
                }
                else
                {
                    OutputLB.Items.Add(i + " : is odd");
                }
            }



            //Calling the function
            textBox1.Text = Add(5, 6) + "";

            int ii = 0;
            textBox2.Text = Remainder(100, 0, out ii) + "";
            textBox3.Text = Remainder(100, 50, out ii) + "";
            textBox4.Text = Remainder(100,100, out ii) + "";

        }

        //Defining the function
        void Nothing()
        {
            textBox1.Text = "Hello";
            return;
        }

        int Add(int x, int y)
        {
            int z = x + y;
            return z;
        }

        int Remainder(int money, int size, out int rem)
        {
            rem = 0;
            return 0;
        }
    }
}
