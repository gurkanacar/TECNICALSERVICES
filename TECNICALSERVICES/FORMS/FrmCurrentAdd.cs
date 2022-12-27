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
    public partial class FrmCurrentAdd : Form
    {
        public FrmCurrentAdd()
        {
            InitializeComponent();
        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();

        int secilen;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TBL_CURRENT t = new TBL_CURRENT();

                t.NAME = txtName.Text;
                t.SURNAME = txtSurname.Text;
                t.PHONE = txtPhone.Text;
                t.MAIL = txtMail.Text;
                t.PROVINCE = lookUpEdit1.Text;
                t.DISTRICT = lookUpEdit2.Text;
                t.BANK = txtBank.Text;
                t.TAXOFFICE = txtTaxoffice.Text;
                t.TAXNUMBER = txttaxNumber.Text;
                t.STATUES = txtStatues.Text;
                t.ADRESS = txtAddress.Text;

                db.TBL_CURRENT.Add(t);
                db.SaveChanges();
                MessageBox.Show("The Current has been successfully added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void FrmCurrentAdd_Load(object sender, EventArgs e)
        {
            lookUpEdit2.Properties.DataSource = (from x in db.TBL_iller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit8_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit1.Properties.DataSource = (from y in db.TBL_ilceler
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilce,
                                                     y.sehir
                                                 }).Where(z => z.sehir == secilen).ToList();
        }



    }
}
