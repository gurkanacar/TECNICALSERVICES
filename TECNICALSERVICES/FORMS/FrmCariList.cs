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
    public partial class FrmCariList : Form
    {
        public FrmCariList()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        int secilen;

        void liste()
        {
            var degerler = from x in db.TBL_CURRENT
                           select new
                           {
                               x.ID,
                               x.NAME,
                               x.SURNAME,
                               x.PROVINCE,
                               x.DISTRICT
                           };

            gridControl1.DataSource = degerler.ToList();

        }

        private void FrmCariList_Load(object sender, EventArgs e)
        {
            liste();

            labelControl6.Text = db.TBL_CURRENT.Count().ToString();

            lookUpEdit2.Properties.DataSource = (from x in db.TBL_iller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();


            labelControl17.Text = db.TBL_CURRENT.Select(x => x.PROVINCE).Distinct().Count().ToString();
            labelControl19.Text = db.TBL_CURRENT.Select(x => x.DISTRICT).Distinct().Count().ToString();
            
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEdit2.EditValue.ToString());
            lookUpEdit3.Properties.DataSource=(from y in db.TBL_ilceler select new
            {
                y.id,
                y.ilce,
                y.sehir

            }).Where(z=>z.sehir == secilen).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_CURRENT t = new TBL_CURRENT();
            t.NAME = txtName.Text;
            t.SURNAME = txtSurname.Text;
            t.PROVINCE = lookUpEdit2.Text;
            t.DISTRICT = lookUpEdit3.Text;
            db.TBL_CURRENT.Add(t);
            db.SaveChanges();
            MessageBox.Show("cari basari ile eklendi");
            liste();

            //t.PHONE = txtPhone.Text;
            //t.MAIL = txtMail.Text;
            //t.BANK = txtBank.Text;
            //t.TAXOFFICE = txtTaxOffice.Text;
            //t.TAXNUMBER = txTaxNum.Text;
            //t.STATUES = txtStatues.Text;
            //t.ADRESS = txtAdress.Text;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }
    }
}
