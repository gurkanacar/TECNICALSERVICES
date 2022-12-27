using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TECNICALSERVICES.FORMS
{
    public partial class FrmQRCode : Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnQRCreat_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(txtSerialNum.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
