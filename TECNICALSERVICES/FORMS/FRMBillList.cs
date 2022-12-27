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
    public partial class FRMBillList : Form
    {
        public FRMBillList()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        void metod1()
        {
            // istenilen degerleri getirme
            var degerler = from u in db.TBL_BILLINFORMATION
                           select new
                           {
                               u.ID,
                               u.SERIES,
                               u.ITEMNO,
                               u.DATE,
                               u.TIME,
                               u.TAXOFFICE,
                              CARI = u.TBL_CURRENT.NAME + u.TBL_CURRENT.SURNAME,
                              PERSON =  u.TBL_PERSON.AD + u.TBL_PERSON.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();


            // lookUpEdit1.Properties.DataSource = db.TBL_DEPARTMAN.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBL_CURRENT
                                                 select new
                                                 {
                                                     x.ID,
                                                 AD = x.NAME +" "+x.SURNAME
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBL_PERSON
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void FRMBillList_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBL_BILLINFORMATION.ToList();
            metod1();
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_BILLINFORMATION
                           select new
                           {
                               u.ID,
                               u.SERIES,
                               u.ITEMNO,
                               u.DATE,
                               u.TIME,
                               u.TAXOFFICE,
                               CARI = u.TBL_CURRENT.NAME + u.TBL_CURRENT.SURNAME,
                               PERSON = u.TBL_PERSON.AD + u.TBL_PERSON.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_BILLINFORMATION t = new TBL_BILLINFORMATION();
            t.SERIES = txtserial.Text;
            t.ITEMNO = txtqueue.Text;
            t.DATE =Convert.ToDateTime(txtDate.Text);
            t.TIME = txtTime.Text;
            t.TAXOFFICE = txtTaxOffice.Text;
            t.CURRENT =int.Parse( lookUpEdit1.EditValue.ToString());
            t.PERSON =short.Parse( lookUpEdit2.EditValue.ToString());
            db.TBL_BILLINFORMATION.Add(t);
            db.SaveChanges();
            MessageBox.Show("The invoice is saved in the system. you can enter a pen");



        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFAturaKalemleri fr = new FrmFAturaKalemleri();
            fr.id =int.Parse( gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
