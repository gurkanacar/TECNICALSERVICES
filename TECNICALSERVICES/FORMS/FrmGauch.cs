using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECNICALSERVICES.FORMS
{
    public partial class FrmGauch : Form
    {
        public FrmGauch()
        {
            InitializeComponent();
        }

        private void FrmGauch_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 5;
            arcScaleComponent2.Value += 5;
            labelComponent1.Text = arcScaleComponent2.Value.ToString();
            if (arcScaleComponent1.Value == 180)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value -= 5;
            arcScaleComponent2.Value -= 5;
            labelComponent1.Text = arcScaleComponent2.Value.ToString();
            if (arcScaleComponent1.Value == 0)
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            arcScaleComponent3.Value += 5;
            if (arcScaleComponent3.Value == 100)
            {
                arcScaleComponent4.Value += 100;
                {
                    if (arcScaleComponent4.Value == 700)
                    {
                        timer3.Stop();
                        timer4.Start();
                    }
                }
            }
        }
    }
}
