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
    public partial class FrmBillPen : Form
    {
        public FrmBillPen()
        {
            InitializeComponent();
        }

        DBtecnicalservicesEntities db = new DBtecnicalservicesEntities();
        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_BILLDETAIL t = new TBL_BILLDETAIL();
            t.PRODUCT = txtproduct.Text;
            t.NUMBER =short.Parse(txtnumber.Text);
            t.PRICE =decimal.Parse(txtprice.Text);
            t.TOTALPRICE =decimal.Parse(txttotalprice.Text);
            t.BILLID =int.Parse(txtbillid.Text);
            db.TBL_BILLDETAIL.Add(t);
            db.SaveChanges();
            MessageBox.Show("faturaya ait kalem girisi basari ile yapildi");
        }

        private void FrmBillPen_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_BILLDETAIL
                           select new
                           {
                               u.BILLDETAILID,
                               u.PRODUCT,
                               u.NUMBER,
                               u.PRICE,
                               u.TOTALPRICE,
                               u.BILLID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBL_BILLDETAIL
                           select new
                           {
                               u.BILLDETAILID,
                               u.PRODUCT,
                               u.NUMBER,
                               u.PRICE,
                               u.TOTALPRICE,
                               u.BILLID,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
