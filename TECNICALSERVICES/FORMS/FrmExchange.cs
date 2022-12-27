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
    public partial class FrmExchange : Form
    {
        public FrmExchange()
        {
            InitializeComponent();
        }

        private void FrmExchange_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
