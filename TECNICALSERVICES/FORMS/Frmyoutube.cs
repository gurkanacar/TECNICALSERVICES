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
    public partial class Frmyoutube : Form
    {
        public Frmyoutube()
        {
            InitializeComponent();
        }

        private void Frmyoutube_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/");
        }
    }
}
