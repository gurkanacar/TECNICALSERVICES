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
    public partial class FrmErrorProdExplanition : Form
    {
        public FrmErrorProdExplanition()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TBL_PRODUCTFOLLOWING t = new TBL_PRODUCTFOLLOWING();
            t.EXPLANATION = richTextBox1.Text;
            t.SERIALNO = txtseri.Text;
            t.DATE =DateTime.Parse( textEdit1.Text);
            db.TBL_PRODUCTFOLLOWING.Add(t);

            //2.guncelleme
            TBL_PRODUCTACCEPTENCE tb = new TBL_PRODUCTACCEPTENCE();
            int productid =int.Parse( id.ToString());
            var deger = db.TBL_PRODUCTACCEPTENCE.Find(productid);
            deger.PRODUCTSTATUSDETAIL = comboBox1.Text;
            db.SaveChanges();

            MessageBox.Show("urun ariza detaylari guncellendi");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtseri_Click(object sender, EventArgs e)
        {
            txtseri.Text = "";
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            textEdit1.Text = DateTime.Now.ToString();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        public string id,seriNo;
        private void FrmErrorProdExplanition_Load(object sender, EventArgs e)
        {
            txtseri.Text = seriNo;
        }
    }
}
