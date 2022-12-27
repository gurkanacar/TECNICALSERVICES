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
    public partial class FrmErrorProductSaves : Form
    {
        public FrmErrorProductSaves()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnSell_Click(object sender, EventArgs e)
        {

            try
            {
                TBL_PRODUCTACCEPTENCE t = new TBL_PRODUCTACCEPTENCE();
                t.CURRENT = int.Parse(lookUpEdit1.EditValue.ToString());
                t.PERSON = short.Parse(lookUpEdit2.EditValue.ToString());
                t.ARRIVEDATE = DateTime.Parse(txtDate.Text);
                t.PROSERNUM = txtSerialNum.Text;
                t.PRODUCTSTATUSDETAIL = "urun kaydoldu";
                db.TBL_PRODUCTACCEPTENCE.Add(t);
                db.SaveChanges();
                MessageBox.Show("URUN ARIZA GIRISI YAPILDI");
            }
            catch (Exception)
            {

                MessageBox.Show("error");
            }

            

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmErrorProductSaves_Load(object sender, EventArgs e)
        {
            //musteri
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_CURRENT
                                                 select new
                                                 {
                                                     x.ID,
                                                 ad= x.NAME+" "+x.SURNAME
                                                 }).ToList();

            //personel
            lookUpEdit2.Properties.DataSource = (from x in db.TBL_PERSON
                                                 select new
                                                 {
                                                     x.ID,
                                                     ad = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDate_Click(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
